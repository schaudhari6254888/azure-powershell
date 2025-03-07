// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies ProxyAgent settings while creating the virtual machine. Minimum
    /// api-version: 2023-09-01.
    /// </summary>
    public partial class ProxyAgentSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettingsInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>
        /// Specifies whether ProxyAgent feature should be enabled on the virtual machine
        /// or virtual machine scale set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="KeyIncarnationId" /> property.</summary>
        private int? _keyIncarnationId;

        /// <summary>
        /// Increase the value of this property allows user to reset the key used for
        /// securing communication channel between guest and host.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? KeyIncarnationId { get => this._keyIncarnationId; set => this._keyIncarnationId = value; }

        /// <summary>Backing field for <see cref="Mode" /> property.</summary>
        private string _mode;

        /// <summary>
        /// Specifies the mode that ProxyAgent will execute on if the feature is enabled.
        /// ProxyAgent will start to audit or monitor but not enforce access control over
        /// requests to host endpoints in Audit mode, while in Enforce mode it will enforce
        /// access control. The default value is Enforce mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Mode { get => this._mode; set => this._mode = value; }

        /// <summary>Creates an new <see cref="ProxyAgentSettings" /> instance.</summary>
        public ProxyAgentSettings()
        {

        }
    }
    /// Specifies ProxyAgent settings while creating the virtual machine. Minimum
    /// api-version: 2023-09-01.
    public partial interface IProxyAgentSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies whether ProxyAgent feature should be enabled on the virtual machine
        /// or virtual machine scale set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether ProxyAgent feature should be enabled on the virtual machine
        or virtual machine scale set.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// Increase the value of this property allows user to reset the key used for
        /// securing communication channel between guest and host.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Increase the value of this property allows user to reset the key used for
        securing communication channel between guest and host.",
        SerializedName = @"keyIncarnationId",
        PossibleTypes = new [] { typeof(int) })]
        int? KeyIncarnationId { get; set; }
        /// <summary>
        /// Specifies the mode that ProxyAgent will execute on if the feature is enabled.
        /// ProxyAgent will start to audit or monitor but not enforce access control over
        /// requests to host endpoints in Audit mode, while in Enforce mode it will enforce
        /// access control. The default value is Enforce mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the mode that ProxyAgent will execute on if the feature is enabled.
        ProxyAgent will start to audit or monitor but not enforce access control over
        requests to host endpoints in Audit mode, while in Enforce mode it will enforce
        access control. The default value is Enforce mode.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Audit", "Enforce")]
        string Mode { get; set; }

    }
    /// Specifies ProxyAgent settings while creating the virtual machine. Minimum
    /// api-version: 2023-09-01.
    internal partial interface IProxyAgentSettingsInternal

    {
        /// <summary>
        /// Specifies whether ProxyAgent feature should be enabled on the virtual machine
        /// or virtual machine scale set.
        /// </summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// Increase the value of this property allows user to reset the key used for
        /// securing communication channel between guest and host.
        /// </summary>
        int? KeyIncarnationId { get; set; }
        /// <summary>
        /// Specifies the mode that ProxyAgent will execute on if the feature is enabled.
        /// ProxyAgent will start to audit or monitor but not enforce access control over
        /// requests to host endpoints in Audit mode, while in Enforce mode it will enforce
        /// access control. The default value is Enforce mode.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Audit", "Enforce")]
        string Mode { get; set; }

    }
}