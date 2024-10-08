// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.PowerShell;

    /// <summary>Switch Billing Parameter specification.</summary>
    [System.ComponentModel.TypeConverter(typeof(SwitchBillingParameterTypeConverter))]
    public partial class SwitchBillingParameter
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.SwitchBillingParameter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameter" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameter DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SwitchBillingParameter(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.SwitchBillingParameter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameter" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameter DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SwitchBillingParameter(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SwitchBillingParameter" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SwitchBillingParameter" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameter FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.SwitchBillingParameter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SwitchBillingParameter(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Request"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).Request = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingRequest) content.GetValueForProperty("Request",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).Request, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.SwitchBillingRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("RequestPlanData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestPlanData = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IPlanData) content.GetValueForProperty("RequestPlanData",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestPlanData, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.PlanDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("RequestAzureResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestAzureResourceId = (string) content.GetValueForProperty("RequestAzureResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestAzureResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("RequestOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestOrganizationId = (string) content.GetValueForProperty("RequestOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("RequestUserEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestUserEmail = (string) content.GetValueForProperty("RequestUserEmail",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestUserEmail, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataUsageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataUsageType = (string) content.GetValueForProperty("PlanDataUsageType",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataUsageType, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataBillingCycle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataBillingCycle = (string) content.GetValueForProperty("PlanDataBillingCycle",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataBillingCycle, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataPlanDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataPlanDetail = (string) content.GetValueForProperty("PlanDataPlanDetail",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataPlanDetail, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataEffectiveDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataEffectiveDate = (global::System.DateTime?) content.GetValueForProperty("PlanDataEffectiveDate",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataEffectiveDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.SwitchBillingParameter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SwitchBillingParameter(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Request"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).Request = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingRequest) content.GetValueForProperty("Request",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).Request, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.SwitchBillingRequestTypeConverter.ConvertFrom);
            }
            if (content.Contains("RequestPlanData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestPlanData = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IPlanData) content.GetValueForProperty("RequestPlanData",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestPlanData, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.PlanDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("RequestAzureResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestAzureResourceId = (string) content.GetValueForProperty("RequestAzureResourceId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestAzureResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("RequestOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestOrganizationId = (string) content.GetValueForProperty("RequestOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("RequestUserEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestUserEmail = (string) content.GetValueForProperty("RequestUserEmail",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).RequestUserEmail, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataUsageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataUsageType = (string) content.GetValueForProperty("PlanDataUsageType",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataUsageType, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataBillingCycle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataBillingCycle = (string) content.GetValueForProperty("PlanDataBillingCycle",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataBillingCycle, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataPlanDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataPlanDetail = (string) content.GetValueForProperty("PlanDataPlanDetail",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataPlanDetail, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataEffectiveDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataEffectiveDate = (global::System.DateTime?) content.GetValueForProperty("PlanDataEffectiveDate",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ISwitchBillingParameterInternal)this).PlanDataEffectiveDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Switch Billing Parameter specification.
    [System.ComponentModel.TypeConverter(typeof(SwitchBillingParameterTypeConverter))]
    public partial interface ISwitchBillingParameter

    {

    }
}