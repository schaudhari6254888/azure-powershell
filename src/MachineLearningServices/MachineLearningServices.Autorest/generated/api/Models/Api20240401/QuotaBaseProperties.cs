// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>The properties for Quota update or retrieval.</summary>
    public partial class QuotaBaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IQuotaBaseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IQuotaBasePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Specifies the resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Limit" /> property.</summary>
        private long? _limit;

        /// <summary>The maximum permitted quota of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public long? Limit { get => this._limit; set => this._limit = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Specifies the resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.QuotaUnit? _unit;

        /// <summary>An enum describing the unit of quota measurement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.QuotaUnit? Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Creates an new <see cref="QuotaBaseProperties" /> instance.</summary>
        public QuotaBaseProperties()
        {

        }
    }
    /// The properties for Quota update or retrieval.
    public partial interface IQuotaBaseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The maximum permitted quota of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum permitted quota of the resource.",
        SerializedName = @"limit",
        PossibleTypes = new [] { typeof(long) })]
        long? Limit { get; set; }
        /// <summary>Specifies the resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }
        /// <summary>An enum describing the unit of quota measurement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An enum describing the unit of quota measurement.",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.QuotaUnit) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.QuotaUnit? Unit { get; set; }

    }
    /// The properties for Quota update or retrieval.
    internal partial interface IQuotaBasePropertiesInternal

    {
        /// <summary>Specifies the resource ID.</summary>
        string Id { get; set; }
        /// <summary>The maximum permitted quota of the resource.</summary>
        long? Limit { get; set; }
        /// <summary>Specifies the resource type.</summary>
        string Type { get; set; }
        /// <summary>An enum describing the unit of quota measurement.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.QuotaUnit? Unit { get; set; }

    }
}