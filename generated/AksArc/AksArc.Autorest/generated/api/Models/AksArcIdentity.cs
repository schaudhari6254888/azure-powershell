// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Extensions;

    public partial class AksArcIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAksArcIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAksArcIdentityInternal
    {

        /// <summary>Backing field for <see cref="AgentPoolName" /> property.</summary>
        private string _agentPoolName;

        /// <summary>Parameter for the name of the agent pool in the provisioned cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string AgentPoolName { get => this._agentPoolName; set => this._agentPoolName = value; }

        /// <summary>Backing field for <see cref="ConnectedClusterResourceUri" /> property.</summary>
        private string _connectedClusterResourceUri;

        /// <summary>
        /// The fully qualified Azure Resource Manager identifier of the connected cluster resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string ConnectedClusterResourceUri { get => this._connectedClusterResourceUri; set => this._connectedClusterResourceUri = value; }

        /// <summary>Backing field for <see cref="CustomLocationResourceUri" /> property.</summary>
        private string _customLocationResourceUri;

        /// <summary>
        /// The fully qualified Azure Resource Manager identifier of the custom location resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string CustomLocationResourceUri { get => this._customLocationResourceUri; set => this._customLocationResourceUri = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="VirtualNetworkName" /> property.</summary>
        private string _virtualNetworkName;

        /// <summary>Parameter for the name of the virtual network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string VirtualNetworkName { get => this._virtualNetworkName; set => this._virtualNetworkName = value; }

        /// <summary>Creates an new <see cref="AksArcIdentity" /> instance.</summary>
        public AksArcIdentity()
        {

        }
    }
    public partial interface IAksArcIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.IJsonSerializable
    {
        /// <summary>Parameter for the name of the agent pool in the provisioned cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Parameter for the name of the agent pool in the provisioned cluster.",
        SerializedName = @"agentPoolName",
        PossibleTypes = new [] { typeof(string) })]
        string AgentPoolName { get; set; }
        /// <summary>
        /// The fully qualified Azure Resource Manager identifier of the connected cluster resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fully qualified Azure Resource Manager identifier of the connected cluster resource.",
        SerializedName = @"connectedClusterResourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectedClusterResourceUri { get; set; }
        /// <summary>
        /// The fully qualified Azure Resource Manager identifier of the custom location resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fully qualified Azure Resource Manager identifier of the custom location resource.",
        SerializedName = @"customLocationResourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string CustomLocationResourceUri { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>Parameter for the name of the virtual network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Parameter for the name of the virtual network",
        SerializedName = @"virtualNetworkName",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualNetworkName { get; set; }

    }
    internal partial interface IAksArcIdentityInternal

    {
        /// <summary>Parameter for the name of the agent pool in the provisioned cluster.</summary>
        string AgentPoolName { get; set; }
        /// <summary>
        /// The fully qualified Azure Resource Manager identifier of the connected cluster resource.
        /// </summary>
        string ConnectedClusterResourceUri { get; set; }
        /// <summary>
        /// The fully qualified Azure Resource Manager identifier of the custom location resource.
        /// </summary>
        string CustomLocationResourceUri { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }
        /// <summary>Parameter for the name of the virtual network</summary>
        string VirtualNetworkName { get; set; }

    }
}