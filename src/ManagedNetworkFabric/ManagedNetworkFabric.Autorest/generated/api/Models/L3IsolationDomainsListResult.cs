// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>List of L3 Isolation Domains.</summary>
    public partial class L3IsolationDomainsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL3IsolationDomainsListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL3IsolationDomainsListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Url to follow for getting next page of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL3IsolationDomain> _value;

        /// <summary>List of L3 Isolation Domain resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL3IsolationDomain> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="L3IsolationDomainsListResult" /> instance.</summary>
        public L3IsolationDomainsListResult()
        {

        }
    }
    /// List of L3 Isolation Domains.
    public partial interface IL3IsolationDomainsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable
    {
        /// <summary>Url to follow for getting next page of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Url to follow for getting next page of resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of L3 Isolation Domain resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of L3 Isolation Domain resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL3IsolationDomain) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL3IsolationDomain> Value { get; set; }

    }
    /// List of L3 Isolation Domains.
    internal partial interface IL3IsolationDomainsListResultInternal

    {
        /// <summary>Url to follow for getting next page of resources.</summary>
        string NextLink { get; set; }
        /// <summary>List of L3 Isolation Domain resources.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL3IsolationDomain> Value { get; set; }

    }
}