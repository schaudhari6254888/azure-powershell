// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Extensions;

    /// <summary>The extension settings. The format is specific for particular extension.</summary>
    public partial class ExtensionDataSourceExtensionSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IExtensionDataSourceExtensionSettings,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IExtensionDataSourceExtensionSettingsInternal
    {

        /// <summary>Creates an new <see cref="ExtensionDataSourceExtensionSettings" /> instance.</summary>
        public ExtensionDataSourceExtensionSettings()
        {

        }
    }
    /// The extension settings. The format is specific for particular extension.
    public partial interface IExtensionDataSourceExtensionSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IAssociativeArray<global::System.Object>
    {

    }
    /// The extension settings. The format is specific for particular extension.
    internal partial interface IExtensionDataSourceExtensionSettingsInternal

    {

    }
}