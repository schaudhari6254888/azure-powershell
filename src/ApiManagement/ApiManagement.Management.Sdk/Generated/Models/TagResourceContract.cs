// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// TagResource contract properties.
    /// </summary>
    public partial class TagResourceContract
    {
        /// <summary>
        /// Initializes a new instance of the TagResourceContract class.
        /// </summary>
        public TagResourceContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagResourceContract class.
        /// </summary>

        /// <param name="tag">Tag associated with the resource.
        /// </param>

        /// <param name="api">API associated with the tag.
        /// </param>

        /// <param name="operation">Operation associated with the tag.
        /// </param>

        /// <param name="product">Product associated with the tag.
        /// </param>
        public TagResourceContract(TagResourceContractProperties tag, ApiTagResourceContractProperties api = default(ApiTagResourceContractProperties), OperationTagResourceContractProperties operation = default(OperationTagResourceContractProperties), ProductTagResourceContractProperties product = default(ProductTagResourceContractProperties))

        {
            this.Tag = tag;
            this.Api = api;
            this.Operation = operation;
            this.Product = product;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets tag associated with the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tag")]
        public TagResourceContractProperties Tag {get; set; }

        /// <summary>
        /// Gets or sets aPI associated with the tag.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "api")]
        public ApiTagResourceContractProperties Api {get; set; }

        /// <summary>
        /// Gets or sets operation associated with the tag.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operation")]
        public OperationTagResourceContractProperties Operation {get; set; }

        /// <summary>
        /// Gets or sets product associated with the tag.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "product")]
        public ProductTagResourceContractProperties Product {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Tag == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Tag");
            }
            if (this.Tag != null)
            {
                this.Tag.Validate();
            }
            if (this.Api != null)
            {
                this.Api.Validate();
            }

            if (this.Product != null)
            {
                this.Product.Validate();
            }
        }
    }
}