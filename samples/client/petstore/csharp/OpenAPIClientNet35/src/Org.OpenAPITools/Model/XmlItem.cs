/* 
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// XmlItem
    /// </summary>
    [DataContract]
    public partial class XmlItem :  IEquatable<XmlItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlItem" /> class.
        /// </summary>
        /// <param name="attributeString">attributeString.</param>
        /// <param name="attributeNumber">attributeNumber.</param>
        /// <param name="attributeInteger">attributeInteger.</param>
        /// <param name="attributeBoolean">attributeBoolean.</param>
        /// <param name="wrappedArray">wrappedArray.</param>
        /// <param name="nameString">nameString.</param>
        /// <param name="nameNumber">nameNumber.</param>
        /// <param name="nameInteger">nameInteger.</param>
        /// <param name="nameBoolean">nameBoolean.</param>
        /// <param name="nameArray">nameArray.</param>
        /// <param name="nameWrappedArray">nameWrappedArray.</param>
        /// <param name="prefixString">prefixString.</param>
        /// <param name="prefixNumber">prefixNumber.</param>
        /// <param name="prefixInteger">prefixInteger.</param>
        /// <param name="prefixBoolean">prefixBoolean.</param>
        /// <param name="prefixArray">prefixArray.</param>
        /// <param name="prefixWrappedArray">prefixWrappedArray.</param>
        /// <param name="namespaceString">namespaceString.</param>
        /// <param name="namespaceNumber">namespaceNumber.</param>
        /// <param name="namespaceInteger">namespaceInteger.</param>
        /// <param name="namespaceBoolean">namespaceBoolean.</param>
        /// <param name="namespaceArray">namespaceArray.</param>
        /// <param name="namespaceWrappedArray">namespaceWrappedArray.</param>
        /// <param name="prefixNsString">prefixNsString.</param>
        /// <param name="prefixNsNumber">prefixNsNumber.</param>
        /// <param name="prefixNsInteger">prefixNsInteger.</param>
        /// <param name="prefixNsBoolean">prefixNsBoolean.</param>
        /// <param name="prefixNsArray">prefixNsArray.</param>
        /// <param name="prefixNsWrappedArray">prefixNsWrappedArray.</param>
        public XmlItem(string attributeString = default(string), decimal attributeNumber = default(decimal), int attributeInteger = default(int), bool attributeBoolean = default(bool), List<int> wrappedArray = default(List<int>), string nameString = default(string), decimal nameNumber = default(decimal), int nameInteger = default(int), bool nameBoolean = default(bool), List<int> nameArray = default(List<int>), List<int> nameWrappedArray = default(List<int>), string prefixString = default(string), decimal prefixNumber = default(decimal), int prefixInteger = default(int), bool prefixBoolean = default(bool), List<int> prefixArray = default(List<int>), List<int> prefixWrappedArray = default(List<int>), string namespaceString = default(string), decimal namespaceNumber = default(decimal), int namespaceInteger = default(int), bool namespaceBoolean = default(bool), List<int> namespaceArray = default(List<int>), List<int> namespaceWrappedArray = default(List<int>), string prefixNsString = default(string), decimal prefixNsNumber = default(decimal), int prefixNsInteger = default(int), bool prefixNsBoolean = default(bool), List<int> prefixNsArray = default(List<int>), List<int> prefixNsWrappedArray = default(List<int>))
        {
            this.AttributeString = attributeString;
            this.AttributeNumber = attributeNumber;
            this.AttributeInteger = attributeInteger;
            this.AttributeBoolean = attributeBoolean;
            this.WrappedArray = wrappedArray;
            this.NameString = nameString;
            this.NameNumber = nameNumber;
            this.NameInteger = nameInteger;
            this.NameBoolean = nameBoolean;
            this.NameArray = nameArray;
            this.NameWrappedArray = nameWrappedArray;
            this.PrefixString = prefixString;
            this.PrefixNumber = prefixNumber;
            this.PrefixInteger = prefixInteger;
            this.PrefixBoolean = prefixBoolean;
            this.PrefixArray = prefixArray;
            this.PrefixWrappedArray = prefixWrappedArray;
            this.NamespaceString = namespaceString;
            this.NamespaceNumber = namespaceNumber;
            this.NamespaceInteger = namespaceInteger;
            this.NamespaceBoolean = namespaceBoolean;
            this.NamespaceArray = namespaceArray;
            this.NamespaceWrappedArray = namespaceWrappedArray;
            this.PrefixNsString = prefixNsString;
            this.PrefixNsNumber = prefixNsNumber;
            this.PrefixNsInteger = prefixNsInteger;
            this.PrefixNsBoolean = prefixNsBoolean;
            this.PrefixNsArray = prefixNsArray;
            this.PrefixNsWrappedArray = prefixNsWrappedArray;
        }
        
        /// <summary>
        /// Gets or Sets AttributeString
        /// </summary>
        [DataMember(Name="attribute_string", EmitDefaultValue=false)]
        public string AttributeString { get; set; }

        /// <summary>
        /// Gets or Sets AttributeNumber
        /// </summary>
        [DataMember(Name="attribute_number", EmitDefaultValue=false)]
        public decimal AttributeNumber { get; set; }

        /// <summary>
        /// Gets or Sets AttributeInteger
        /// </summary>
        [DataMember(Name="attribute_integer", EmitDefaultValue=false)]
        public int AttributeInteger { get; set; }

        /// <summary>
        /// Gets or Sets AttributeBoolean
        /// </summary>
        [DataMember(Name="attribute_boolean", EmitDefaultValue=false)]
        public bool AttributeBoolean { get; set; }

        /// <summary>
        /// Gets or Sets WrappedArray
        /// </summary>
        [DataMember(Name="wrapped_array", EmitDefaultValue=false)]
        public List<int> WrappedArray { get; set; }

        /// <summary>
        /// Gets or Sets NameString
        /// </summary>
        [DataMember(Name="name_string", EmitDefaultValue=false)]
        public string NameString { get; set; }

        /// <summary>
        /// Gets or Sets NameNumber
        /// </summary>
        [DataMember(Name="name_number", EmitDefaultValue=false)]
        public decimal NameNumber { get; set; }

        /// <summary>
        /// Gets or Sets NameInteger
        /// </summary>
        [DataMember(Name="name_integer", EmitDefaultValue=false)]
        public int NameInteger { get; set; }

        /// <summary>
        /// Gets or Sets NameBoolean
        /// </summary>
        [DataMember(Name="name_boolean", EmitDefaultValue=false)]
        public bool NameBoolean { get; set; }

        /// <summary>
        /// Gets or Sets NameArray
        /// </summary>
        [DataMember(Name="name_array", EmitDefaultValue=false)]
        public List<int> NameArray { get; set; }

        /// <summary>
        /// Gets or Sets NameWrappedArray
        /// </summary>
        [DataMember(Name="name_wrapped_array", EmitDefaultValue=false)]
        public List<int> NameWrappedArray { get; set; }

        /// <summary>
        /// Gets or Sets PrefixString
        /// </summary>
        [DataMember(Name="prefix_string", EmitDefaultValue=false)]
        public string PrefixString { get; set; }

        /// <summary>
        /// Gets or Sets PrefixNumber
        /// </summary>
        [DataMember(Name="prefix_number", EmitDefaultValue=false)]
        public decimal PrefixNumber { get; set; }

        /// <summary>
        /// Gets or Sets PrefixInteger
        /// </summary>
        [DataMember(Name="prefix_integer", EmitDefaultValue=false)]
        public int PrefixInteger { get; set; }

        /// <summary>
        /// Gets or Sets PrefixBoolean
        /// </summary>
        [DataMember(Name="prefix_boolean", EmitDefaultValue=false)]
        public bool PrefixBoolean { get; set; }

        /// <summary>
        /// Gets or Sets PrefixArray
        /// </summary>
        [DataMember(Name="prefix_array", EmitDefaultValue=false)]
        public List<int> PrefixArray { get; set; }

        /// <summary>
        /// Gets or Sets PrefixWrappedArray
        /// </summary>
        [DataMember(Name="prefix_wrapped_array", EmitDefaultValue=false)]
        public List<int> PrefixWrappedArray { get; set; }

        /// <summary>
        /// Gets or Sets NamespaceString
        /// </summary>
        [DataMember(Name="namespace_string", EmitDefaultValue=false)]
        public string NamespaceString { get; set; }

        /// <summary>
        /// Gets or Sets NamespaceNumber
        /// </summary>
        [DataMember(Name="namespace_number", EmitDefaultValue=false)]
        public decimal NamespaceNumber { get; set; }

        /// <summary>
        /// Gets or Sets NamespaceInteger
        /// </summary>
        [DataMember(Name="namespace_integer", EmitDefaultValue=false)]
        public int NamespaceInteger { get; set; }

        /// <summary>
        /// Gets or Sets NamespaceBoolean
        /// </summary>
        [DataMember(Name="namespace_boolean", EmitDefaultValue=false)]
        public bool NamespaceBoolean { get; set; }

        /// <summary>
        /// Gets or Sets NamespaceArray
        /// </summary>
        [DataMember(Name="namespace_array", EmitDefaultValue=false)]
        public List<int> NamespaceArray { get; set; }

        /// <summary>
        /// Gets or Sets NamespaceWrappedArray
        /// </summary>
        [DataMember(Name="namespace_wrapped_array", EmitDefaultValue=false)]
        public List<int> NamespaceWrappedArray { get; set; }

        /// <summary>
        /// Gets or Sets PrefixNsString
        /// </summary>
        [DataMember(Name="prefix_ns_string", EmitDefaultValue=false)]
        public string PrefixNsString { get; set; }

        /// <summary>
        /// Gets or Sets PrefixNsNumber
        /// </summary>
        [DataMember(Name="prefix_ns_number", EmitDefaultValue=false)]
        public decimal PrefixNsNumber { get; set; }

        /// <summary>
        /// Gets or Sets PrefixNsInteger
        /// </summary>
        [DataMember(Name="prefix_ns_integer", EmitDefaultValue=false)]
        public int PrefixNsInteger { get; set; }

        /// <summary>
        /// Gets or Sets PrefixNsBoolean
        /// </summary>
        [DataMember(Name="prefix_ns_boolean", EmitDefaultValue=false)]
        public bool PrefixNsBoolean { get; set; }

        /// <summary>
        /// Gets or Sets PrefixNsArray
        /// </summary>
        [DataMember(Name="prefix_ns_array", EmitDefaultValue=false)]
        public List<int> PrefixNsArray { get; set; }

        /// <summary>
        /// Gets or Sets PrefixNsWrappedArray
        /// </summary>
        [DataMember(Name="prefix_ns_wrapped_array", EmitDefaultValue=false)]
        public List<int> PrefixNsWrappedArray { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XmlItem {\n");
            sb.Append("  AttributeString: ").Append(AttributeString).Append("\n");
            sb.Append("  AttributeNumber: ").Append(AttributeNumber).Append("\n");
            sb.Append("  AttributeInteger: ").Append(AttributeInteger).Append("\n");
            sb.Append("  AttributeBoolean: ").Append(AttributeBoolean).Append("\n");
            sb.Append("  WrappedArray: ").Append(WrappedArray).Append("\n");
            sb.Append("  NameString: ").Append(NameString).Append("\n");
            sb.Append("  NameNumber: ").Append(NameNumber).Append("\n");
            sb.Append("  NameInteger: ").Append(NameInteger).Append("\n");
            sb.Append("  NameBoolean: ").Append(NameBoolean).Append("\n");
            sb.Append("  NameArray: ").Append(NameArray).Append("\n");
            sb.Append("  NameWrappedArray: ").Append(NameWrappedArray).Append("\n");
            sb.Append("  PrefixString: ").Append(PrefixString).Append("\n");
            sb.Append("  PrefixNumber: ").Append(PrefixNumber).Append("\n");
            sb.Append("  PrefixInteger: ").Append(PrefixInteger).Append("\n");
            sb.Append("  PrefixBoolean: ").Append(PrefixBoolean).Append("\n");
            sb.Append("  PrefixArray: ").Append(PrefixArray).Append("\n");
            sb.Append("  PrefixWrappedArray: ").Append(PrefixWrappedArray).Append("\n");
            sb.Append("  NamespaceString: ").Append(NamespaceString).Append("\n");
            sb.Append("  NamespaceNumber: ").Append(NamespaceNumber).Append("\n");
            sb.Append("  NamespaceInteger: ").Append(NamespaceInteger).Append("\n");
            sb.Append("  NamespaceBoolean: ").Append(NamespaceBoolean).Append("\n");
            sb.Append("  NamespaceArray: ").Append(NamespaceArray).Append("\n");
            sb.Append("  NamespaceWrappedArray: ").Append(NamespaceWrappedArray).Append("\n");
            sb.Append("  PrefixNsString: ").Append(PrefixNsString).Append("\n");
            sb.Append("  PrefixNsNumber: ").Append(PrefixNsNumber).Append("\n");
            sb.Append("  PrefixNsInteger: ").Append(PrefixNsInteger).Append("\n");
            sb.Append("  PrefixNsBoolean: ").Append(PrefixNsBoolean).Append("\n");
            sb.Append("  PrefixNsArray: ").Append(PrefixNsArray).Append("\n");
            sb.Append("  PrefixNsWrappedArray: ").Append(PrefixNsWrappedArray).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as XmlItem);
        }

        /// <summary>
        /// Returns true if XmlItem instances are equal
        /// </summary>
        /// <param name="input">Instance of XmlItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XmlItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttributeString == input.AttributeString ||
                    (this.AttributeString != null &&
                    this.AttributeString.Equals(input.AttributeString))
                ) && 
                (
                    this.AttributeNumber == input.AttributeNumber ||
                    (this.AttributeNumber != null &&
                    this.AttributeNumber.Equals(input.AttributeNumber))
                ) && 
                (
                    this.AttributeInteger == input.AttributeInteger ||
                    (this.AttributeInteger != null &&
                    this.AttributeInteger.Equals(input.AttributeInteger))
                ) && 
                (
                    this.AttributeBoolean == input.AttributeBoolean ||
                    (this.AttributeBoolean != null &&
                    this.AttributeBoolean.Equals(input.AttributeBoolean))
                ) && 
                (
                    this.WrappedArray == input.WrappedArray ||
                    this.WrappedArray != null &&
                    input.WrappedArray != null &&
                    this.WrappedArray.SequenceEqual(input.WrappedArray)
                ) && 
                (
                    this.NameString == input.NameString ||
                    (this.NameString != null &&
                    this.NameString.Equals(input.NameString))
                ) && 
                (
                    this.NameNumber == input.NameNumber ||
                    (this.NameNumber != null &&
                    this.NameNumber.Equals(input.NameNumber))
                ) && 
                (
                    this.NameInteger == input.NameInteger ||
                    (this.NameInteger != null &&
                    this.NameInteger.Equals(input.NameInteger))
                ) && 
                (
                    this.NameBoolean == input.NameBoolean ||
                    (this.NameBoolean != null &&
                    this.NameBoolean.Equals(input.NameBoolean))
                ) && 
                (
                    this.NameArray == input.NameArray ||
                    this.NameArray != null &&
                    input.NameArray != null &&
                    this.NameArray.SequenceEqual(input.NameArray)
                ) && 
                (
                    this.NameWrappedArray == input.NameWrappedArray ||
                    this.NameWrappedArray != null &&
                    input.NameWrappedArray != null &&
                    this.NameWrappedArray.SequenceEqual(input.NameWrappedArray)
                ) && 
                (
                    this.PrefixString == input.PrefixString ||
                    (this.PrefixString != null &&
                    this.PrefixString.Equals(input.PrefixString))
                ) && 
                (
                    this.PrefixNumber == input.PrefixNumber ||
                    (this.PrefixNumber != null &&
                    this.PrefixNumber.Equals(input.PrefixNumber))
                ) && 
                (
                    this.PrefixInteger == input.PrefixInteger ||
                    (this.PrefixInteger != null &&
                    this.PrefixInteger.Equals(input.PrefixInteger))
                ) && 
                (
                    this.PrefixBoolean == input.PrefixBoolean ||
                    (this.PrefixBoolean != null &&
                    this.PrefixBoolean.Equals(input.PrefixBoolean))
                ) && 
                (
                    this.PrefixArray == input.PrefixArray ||
                    this.PrefixArray != null &&
                    input.PrefixArray != null &&
                    this.PrefixArray.SequenceEqual(input.PrefixArray)
                ) && 
                (
                    this.PrefixWrappedArray == input.PrefixWrappedArray ||
                    this.PrefixWrappedArray != null &&
                    input.PrefixWrappedArray != null &&
                    this.PrefixWrappedArray.SequenceEqual(input.PrefixWrappedArray)
                ) && 
                (
                    this.NamespaceString == input.NamespaceString ||
                    (this.NamespaceString != null &&
                    this.NamespaceString.Equals(input.NamespaceString))
                ) && 
                (
                    this.NamespaceNumber == input.NamespaceNumber ||
                    (this.NamespaceNumber != null &&
                    this.NamespaceNumber.Equals(input.NamespaceNumber))
                ) && 
                (
                    this.NamespaceInteger == input.NamespaceInteger ||
                    (this.NamespaceInteger != null &&
                    this.NamespaceInteger.Equals(input.NamespaceInteger))
                ) && 
                (
                    this.NamespaceBoolean == input.NamespaceBoolean ||
                    (this.NamespaceBoolean != null &&
                    this.NamespaceBoolean.Equals(input.NamespaceBoolean))
                ) && 
                (
                    this.NamespaceArray == input.NamespaceArray ||
                    this.NamespaceArray != null &&
                    input.NamespaceArray != null &&
                    this.NamespaceArray.SequenceEqual(input.NamespaceArray)
                ) && 
                (
                    this.NamespaceWrappedArray == input.NamespaceWrappedArray ||
                    this.NamespaceWrappedArray != null &&
                    input.NamespaceWrappedArray != null &&
                    this.NamespaceWrappedArray.SequenceEqual(input.NamespaceWrappedArray)
                ) && 
                (
                    this.PrefixNsString == input.PrefixNsString ||
                    (this.PrefixNsString != null &&
                    this.PrefixNsString.Equals(input.PrefixNsString))
                ) && 
                (
                    this.PrefixNsNumber == input.PrefixNsNumber ||
                    (this.PrefixNsNumber != null &&
                    this.PrefixNsNumber.Equals(input.PrefixNsNumber))
                ) && 
                (
                    this.PrefixNsInteger == input.PrefixNsInteger ||
                    (this.PrefixNsInteger != null &&
                    this.PrefixNsInteger.Equals(input.PrefixNsInteger))
                ) && 
                (
                    this.PrefixNsBoolean == input.PrefixNsBoolean ||
                    (this.PrefixNsBoolean != null &&
                    this.PrefixNsBoolean.Equals(input.PrefixNsBoolean))
                ) && 
                (
                    this.PrefixNsArray == input.PrefixNsArray ||
                    this.PrefixNsArray != null &&
                    input.PrefixNsArray != null &&
                    this.PrefixNsArray.SequenceEqual(input.PrefixNsArray)
                ) && 
                (
                    this.PrefixNsWrappedArray == input.PrefixNsWrappedArray ||
                    this.PrefixNsWrappedArray != null &&
                    input.PrefixNsWrappedArray != null &&
                    this.PrefixNsWrappedArray.SequenceEqual(input.PrefixNsWrappedArray)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AttributeString != null)
                    hashCode = hashCode * 59 + this.AttributeString.GetHashCode();
                if (this.AttributeNumber != null)
                    hashCode = hashCode * 59 + this.AttributeNumber.GetHashCode();
                if (this.AttributeInteger != null)
                    hashCode = hashCode * 59 + this.AttributeInteger.GetHashCode();
                if (this.AttributeBoolean != null)
                    hashCode = hashCode * 59 + this.AttributeBoolean.GetHashCode();
                if (this.WrappedArray != null)
                    hashCode = hashCode * 59 + this.WrappedArray.GetHashCode();
                if (this.NameString != null)
                    hashCode = hashCode * 59 + this.NameString.GetHashCode();
                if (this.NameNumber != null)
                    hashCode = hashCode * 59 + this.NameNumber.GetHashCode();
                if (this.NameInteger != null)
                    hashCode = hashCode * 59 + this.NameInteger.GetHashCode();
                if (this.NameBoolean != null)
                    hashCode = hashCode * 59 + this.NameBoolean.GetHashCode();
                if (this.NameArray != null)
                    hashCode = hashCode * 59 + this.NameArray.GetHashCode();
                if (this.NameWrappedArray != null)
                    hashCode = hashCode * 59 + this.NameWrappedArray.GetHashCode();
                if (this.PrefixString != null)
                    hashCode = hashCode * 59 + this.PrefixString.GetHashCode();
                if (this.PrefixNumber != null)
                    hashCode = hashCode * 59 + this.PrefixNumber.GetHashCode();
                if (this.PrefixInteger != null)
                    hashCode = hashCode * 59 + this.PrefixInteger.GetHashCode();
                if (this.PrefixBoolean != null)
                    hashCode = hashCode * 59 + this.PrefixBoolean.GetHashCode();
                if (this.PrefixArray != null)
                    hashCode = hashCode * 59 + this.PrefixArray.GetHashCode();
                if (this.PrefixWrappedArray != null)
                    hashCode = hashCode * 59 + this.PrefixWrappedArray.GetHashCode();
                if (this.NamespaceString != null)
                    hashCode = hashCode * 59 + this.NamespaceString.GetHashCode();
                if (this.NamespaceNumber != null)
                    hashCode = hashCode * 59 + this.NamespaceNumber.GetHashCode();
                if (this.NamespaceInteger != null)
                    hashCode = hashCode * 59 + this.NamespaceInteger.GetHashCode();
                if (this.NamespaceBoolean != null)
                    hashCode = hashCode * 59 + this.NamespaceBoolean.GetHashCode();
                if (this.NamespaceArray != null)
                    hashCode = hashCode * 59 + this.NamespaceArray.GetHashCode();
                if (this.NamespaceWrappedArray != null)
                    hashCode = hashCode * 59 + this.NamespaceWrappedArray.GetHashCode();
                if (this.PrefixNsString != null)
                    hashCode = hashCode * 59 + this.PrefixNsString.GetHashCode();
                if (this.PrefixNsNumber != null)
                    hashCode = hashCode * 59 + this.PrefixNsNumber.GetHashCode();
                if (this.PrefixNsInteger != null)
                    hashCode = hashCode * 59 + this.PrefixNsInteger.GetHashCode();
                if (this.PrefixNsBoolean != null)
                    hashCode = hashCode * 59 + this.PrefixNsBoolean.GetHashCode();
                if (this.PrefixNsArray != null)
                    hashCode = hashCode * 59 + this.PrefixNsArray.GetHashCode();
                if (this.PrefixNsWrappedArray != null)
                    hashCode = hashCode * 59 + this.PrefixNsWrappedArray.GetHashCode();
                return hashCode;
            }
        }

    }

}
