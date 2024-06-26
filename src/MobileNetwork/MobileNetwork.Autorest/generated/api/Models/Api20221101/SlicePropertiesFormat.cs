// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Network slice properties.</summary>
    public partial class SlicePropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISlicePropertiesFormat,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISlicePropertiesFormatInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>An optional description for this network slice.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISlicePropertiesFormatInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Snssai</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISnssai Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISlicePropertiesFormatInternal.Snssai { get => (this._snssai = this._snssai ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.Snssai()); set { {_snssai = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the network slice resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Snssai" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISnssai _snssai;

        /// <summary>
        /// Single-network slice selection assistance information (S-NSSAI). Unique at the scope of a mobile network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISnssai Snssai { get => (this._snssai = this._snssai ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.Snssai()); set => this._snssai = value; }

        /// <summary>Slice differentiator (SD).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string SnssaiSd { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISnssaiInternal)Snssai).Sd; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISnssaiInternal)Snssai).Sd = value ?? null; }

        /// <summary>Slice/service type (SST).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public int SnssaiSst { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISnssaiInternal)Snssai).Sst; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISnssaiInternal)Snssai).Sst = value ; }

        /// <summary>Creates an new <see cref="SlicePropertiesFormat" /> instance.</summary>
        public SlicePropertiesFormat()
        {

        }
    }
    /// Network slice properties.
    public partial interface ISlicePropertiesFormat :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable
    {
        /// <summary>An optional description for this network slice.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An optional description for this network slice.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The provisioning state of the network slice resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the network slice resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Slice differentiator (SD).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Slice differentiator (SD).",
        SerializedName = @"sd",
        PossibleTypes = new [] { typeof(string) })]
        string SnssaiSd { get; set; }
        /// <summary>Slice/service type (SST).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Slice/service type (SST).",
        SerializedName = @"sst",
        PossibleTypes = new [] { typeof(int) })]
        int SnssaiSst { get; set; }

    }
    /// Network slice properties.
    internal partial interface ISlicePropertiesFormatInternal

    {
        /// <summary>An optional description for this network slice.</summary>
        string Description { get; set; }
        /// <summary>The provisioning state of the network slice resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// Single-network slice selection assistance information (S-NSSAI). Unique at the scope of a mobile network.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISnssai Snssai { get; set; }
        /// <summary>Slice differentiator (SD).</summary>
        string SnssaiSd { get; set; }
        /// <summary>Slice/service type (SST).</summary>
        int SnssaiSst { get; set; }

    }
}