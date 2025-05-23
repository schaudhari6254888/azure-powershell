// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Confluent.Runtime.PowerShell;

    /// <summary>Organization resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationResourceTypeConverter))]
    public partial class OrganizationResource
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OrganizationResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OrganizationResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OrganizationResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OrganizationResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Confluent.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OrganizationResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailId = (string) content.GetValueForProperty("OfferDetailId",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailFirstName = (string) content.GetValueForProperty("UserDetailFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailLastName = (string) content.GetValueForProperty("UserDetailLastName",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailEmailAddress = (string) content.GetValueForProperty("UserDetailEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourcePropertiesOfferDetail) content.GetValueForProperty("OfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetail, Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResourcePropertiesOfferDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourcePropertiesUserDetail) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResourcePropertiesUserDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("CreatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).CreatedTime = (global::System.DateTime?) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).CreatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OrganizationId = (string) content.GetValueForProperty("OrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("SsoUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).SsoUrl = (string) content.GetValueForProperty("SsoUrl",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).SsoUrl, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailStatus = (string) content.GetValueForProperty("OfferDetailStatus",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailStatus, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OrganizationResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailId = (string) content.GetValueForProperty("OfferDetailId",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailFirstName = (string) content.GetValueForProperty("UserDetailFirstName",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailLastName = (string) content.GetValueForProperty("UserDetailLastName",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailEmailAddress = (string) content.GetValueForProperty("UserDetailEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetailEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourcePropertiesOfferDetail) content.GetValueForProperty("OfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetail, Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResourcePropertiesOfferDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourcePropertiesUserDetail) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResourcePropertiesUserDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("CreatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).CreatedTime = (global::System.DateTime?) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).CreatedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OrganizationId = (string) content.GetValueForProperty("OrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("SsoUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).SsoUrl = (string) content.GetValueForProperty("SsoUrl",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).SsoUrl, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailStatus = (string) content.GetValueForProperty("OfferDetailStatus",((Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceInternal)this).OfferDetailStatus, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Confluent.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Organization resource.
    [System.ComponentModel.TypeConverter(typeof(OrganizationResourceTypeConverter))]
    public partial interface IOrganizationResource

    {

    }
}