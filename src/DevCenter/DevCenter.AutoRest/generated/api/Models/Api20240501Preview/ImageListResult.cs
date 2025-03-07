// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>Results of the image list operation.</summary>
    public partial class ImageListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IImageListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IImageListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IImageListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IImage[] Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IImageListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IImage[] _value;

        /// <summary>Current page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IImage[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="ImageListResult" /> instance.</summary>
        public ImageListResult()
        {

        }
    }
    /// Results of the image list operation.
    public partial interface IImageListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URL to get the next set of results if there are any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Current page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current page of results.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IImage) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IImage[] Value { get;  }

    }
    /// Results of the image list operation.
    internal partial interface IImageListResultInternal

    {
        /// <summary>URL to get the next set of results if there are any.</summary>
        string NextLink { get; set; }
        /// <summary>Current page of results.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IImage[] Value { get; set; }

    }
}