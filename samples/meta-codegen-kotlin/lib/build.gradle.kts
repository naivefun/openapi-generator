import com.github.jengelman.gradle.plugins.shadow.tasks.ShadowJar
import org.jetbrains.kotlin.gradle.tasks.KotlinCompile

plugins {
    kotlin("jvm") version "1.3.41"
    id("com.github.johnrengelman.shadow") version("5.0.0")
}

group = "org.openapitools"
version = "1.0-SNAPSHOT"

repositories {
    mavenLocal()
    mavenCentral()
}

dependencies {
    val openapiGeneratorVersion = "4.1.3"

    implementation(kotlin("stdlib-jdk8"))
    implementation("org.openapitools:openapi-generator:$openapiGeneratorVersion")

    runtime("org.openapitools:openapi-generator-cli:$openapiGeneratorVersion")

    testImplementation("org.junit.jupiter:junit-jupiter:5.5.2")
}

tasks.test {
    useJUnitPlatform()
    testLogging {
        events("passed", "skipped", "failed")
    }
}

tasks.register<Copy>("copyToLib") {
    from(project.configurations.runtime)
    into(File(buildDir, "libs"))
}

tasks.register<ShadowJar>("standalone") {
    archiveFileName.set("myClientCodegen-openapi-generator-standalone.jar")
    archiveClassifier.set("all")

    from(sourceSets["main"].output)

    configurations.add(project.configurations["runtimeClasspath"])
    configurations.add(project.configurations["runtime"])

    mergeServiceFiles()

    manifest.attributes(mapOf("Main-Class" to "org.openapitools.codegen.OpenAPIGenerator"))
}

tasks.withType<KotlinCompile> {
    kotlinOptions.jvmTarget = "1.8"
}

tasks.wrapper {
    this.distributionType = Wrapper.DistributionType.BIN
}

tasks.named("shadowJar") { dependsOn("copyToLib") }
