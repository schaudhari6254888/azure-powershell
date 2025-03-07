// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System.Linq;

    /// <summary>
    /// Name of Iot Hub type
    /// </summary>
    public partial class Name
    {
        /// <summary>
        /// Initializes a new instance of the Name class.
        /// </summary>
        public Name()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Name class.
        /// </summary>

        /// <param name="value">IotHub type
        /// </param>

        /// <param name="localizedValue">Localized value of name
        /// </param>
        public Name(string value = default(string), string localizedValue = default(string))

        {
            this.Value = value;
            this.LocalizedValue = localizedValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets iotHub type
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value {get; set; }

        /// <summary>
        /// Gets or sets localized value of name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "localizedValue")]
        public string LocalizedValue {get; set; }
    }
}