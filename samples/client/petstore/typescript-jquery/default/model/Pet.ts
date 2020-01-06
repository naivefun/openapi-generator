/**
 * OpenAPI Petstore
 * This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import * as models from './models';

/**
 * A pet for sale in the pet store
 */
export interface Pet {
    id?: number;

    category?: models.Category;

    name: string;

    photoUrls: Array<string>;

    tags?: Array<models.Tag>;

    /**
     * pet status in the store
     */
    status?: Pet.StatusEnum;

}
export namespace Pet {
    export enum StatusEnum {
        Available = <any> 'available',
        Pending = <any> 'pending',
        Sold = <any> 'sold'
    }
}
