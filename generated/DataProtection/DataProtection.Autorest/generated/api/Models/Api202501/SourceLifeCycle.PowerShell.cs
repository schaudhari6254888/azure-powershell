// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Source LifeCycle</summary>
    [System.ComponentModel.TypeConverter(typeof(SourceLifeCycleTypeConverter))]
    public partial class SourceLifeCycle
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.SourceLifeCycle"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycle" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycle DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SourceLifeCycle(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.SourceLifeCycle"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycle" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycle DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SourceLifeCycle(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SourceLifeCycle" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SourceLifeCycle" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycle FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.SourceLifeCycle"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SourceLifeCycle(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeleteAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfter = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDeleteOption) content.GetValueForProperty("DeleteAfter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfter, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.DeleteOptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceDataStore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStore = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDataStoreInfoBase) content.GetValueForProperty("SourceDataStore",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStore, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.DataStoreInfoBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetDataStoreCopySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).TargetDataStoreCopySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ITargetCopySetting[]) content.GetValueForProperty("TargetDataStoreCopySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).TargetDataStoreCopySetting, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ITargetCopySetting>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.TargetCopySettingTypeConverter.ConvertFrom));
            }
            if (content.Contains("DeleteAfterDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfterDuration = (string) content.GetValueForProperty("DeleteAfterDuration",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfterDuration, global::System.Convert.ToString);
            }
            if (content.Contains("DeleteAfterObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfterObjectType = (string) content.GetValueForProperty("DeleteAfterObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfterObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceDataStoreType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStoreType = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes) content.GetValueForProperty("SourceDataStoreType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStoreType, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes.CreateFrom);
            }
            if (content.Contains("SourceDataStoreObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStoreObjectType = (string) content.GetValueForProperty("SourceDataStoreObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStoreObjectType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.SourceLifeCycle"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SourceLifeCycle(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeleteAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfter = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDeleteOption) content.GetValueForProperty("DeleteAfter",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfter, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.DeleteOptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceDataStore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStore = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IDataStoreInfoBase) content.GetValueForProperty("SourceDataStore",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStore, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.DataStoreInfoBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetDataStoreCopySetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).TargetDataStoreCopySetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ITargetCopySetting[]) content.GetValueForProperty("TargetDataStoreCopySetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).TargetDataStoreCopySetting, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ITargetCopySetting>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.TargetCopySettingTypeConverter.ConvertFrom));
            }
            if (content.Contains("DeleteAfterDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfterDuration = (string) content.GetValueForProperty("DeleteAfterDuration",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfterDuration, global::System.Convert.ToString);
            }
            if (content.Contains("DeleteAfterObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfterObjectType = (string) content.GetValueForProperty("DeleteAfterObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).DeleteAfterObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceDataStoreType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStoreType = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes) content.GetValueForProperty("SourceDataStoreType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStoreType, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.DataStoreTypes.CreateFrom);
            }
            if (content.Contains("SourceDataStoreObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStoreObjectType = (string) content.GetValueForProperty("SourceDataStoreObjectType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.ISourceLifeCycleInternal)this).SourceDataStoreObjectType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Source LifeCycle
    [System.ComponentModel.TypeConverter(typeof(SourceLifeCycleTypeConverter))]
    public partial interface ISourceLifeCycle

    {

    }
}