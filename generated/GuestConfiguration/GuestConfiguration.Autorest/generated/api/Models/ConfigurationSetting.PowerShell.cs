// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.PowerShell;

    /// <summary>Configuration setting of LCM (Local Configuration Manager).</summary>
    [System.ComponentModel.TypeConverter(typeof(ConfigurationSettingTypeConverter))]
    public partial class ConfigurationSetting
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.ConfigurationSetting"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ConfigurationSetting(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ConfigurationMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ConfigurationMode = (string) content.GetValueForProperty("ConfigurationMode",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ConfigurationMode, global::System.Convert.ToString);
            }
            if (content.Contains("AllowModuleOverwrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).AllowModuleOverwrite = (bool?) content.GetValueForProperty("AllowModuleOverwrite",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).AllowModuleOverwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ActionAfterReboot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ActionAfterReboot = (string) content.GetValueForProperty("ActionAfterReboot",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ActionAfterReboot, global::System.Convert.ToString);
            }
            if (content.Contains("RefreshFrequencyMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).RefreshFrequencyMin = (float?) content.GetValueForProperty("RefreshFrequencyMin",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).RefreshFrequencyMin, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("RebootIfNeeded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).RebootIfNeeded = (bool?) content.GetValueForProperty("RebootIfNeeded",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).RebootIfNeeded, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConfigurationModeFrequencyMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ConfigurationModeFrequencyMin = (float?) content.GetValueForProperty("ConfigurationModeFrequencyMin",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ConfigurationModeFrequencyMin, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.ConfigurationSetting"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ConfigurationSetting(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ConfigurationMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ConfigurationMode = (string) content.GetValueForProperty("ConfigurationMode",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ConfigurationMode, global::System.Convert.ToString);
            }
            if (content.Contains("AllowModuleOverwrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).AllowModuleOverwrite = (bool?) content.GetValueForProperty("AllowModuleOverwrite",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).AllowModuleOverwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ActionAfterReboot"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ActionAfterReboot = (string) content.GetValueForProperty("ActionAfterReboot",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ActionAfterReboot, global::System.Convert.ToString);
            }
            if (content.Contains("RefreshFrequencyMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).RefreshFrequencyMin = (float?) content.GetValueForProperty("RefreshFrequencyMin",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).RefreshFrequencyMin, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            if (content.Contains("RebootIfNeeded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).RebootIfNeeded = (bool?) content.GetValueForProperty("RebootIfNeeded",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).RebootIfNeeded, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConfigurationModeFrequencyMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ConfigurationModeFrequencyMin = (float?) content.GetValueForProperty("ConfigurationModeFrequencyMin",((Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSettingInternal)this).ConfigurationModeFrequencyMin, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.ConfigurationSetting"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSetting" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSetting DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ConfigurationSetting(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.ConfigurationSetting"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSetting" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSetting DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ConfigurationSetting(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConfigurationSetting" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ConfigurationSetting" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IConfigurationSetting FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Configuration setting of LCM (Local Configuration Manager).
    [System.ComponentModel.TypeConverter(typeof(ConfigurationSettingTypeConverter))]
    public partial interface IConfigurationSetting

    {

    }
}