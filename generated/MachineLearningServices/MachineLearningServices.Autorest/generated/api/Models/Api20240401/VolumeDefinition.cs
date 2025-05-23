// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Describes the volume configuration for the container</summary>
    public partial class VolumeDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVolumeDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVolumeDefinitionInternal
    {

        /// <summary>Backing field for <see cref="Bind" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IBindOptions _bind;

        /// <summary>Bind Options of the mount</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IBindOptions Bind { get => (this._bind = this._bind ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.BindOptions()); set => this._bind = value; }

        /// <summary>Indicate whether to create host path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public bool? BindCreateHostPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IBindOptionsInternal)Bind).CreateHostPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IBindOptionsInternal)Bind).CreateHostPath = value ?? default(bool); }

        /// <summary>Type of Bind Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string BindPropagation { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IBindOptionsInternal)Bind).Propagation; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IBindOptionsInternal)Bind).Propagation = value ?? null; }

        /// <summary>Mention the selinux options.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string BindSelinux { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IBindOptionsInternal)Bind).Selinux; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IBindOptionsInternal)Bind).Selinux = value ?? null; }

        /// <summary>Backing field for <see cref="Consistency" /> property.</summary>
        private string _consistency;

        /// <summary>Consistency of the volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Consistency { get => this._consistency; set => this._consistency = value; }

        /// <summary>Internal Acessors for Bind</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IBindOptions Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVolumeDefinitionInternal.Bind { get => (this._bind = this._bind ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.BindOptions()); set { {_bind = value;} } }

        /// <summary>Internal Acessors for Tmpf</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITmpfsOptions Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVolumeDefinitionInternal.Tmpf { get => (this._tmpf = this._tmpf ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.TmpfsOptions()); set { {_tmpf = value;} } }

        /// <summary>Internal Acessors for Volume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVolumeOptions Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVolumeDefinitionInternal.Volume { get => (this._volume = this._volume ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VolumeOptions()); set { {_volume = value;} } }

        /// <summary>Backing field for <see cref="ReadOnly" /> property.</summary>
        private bool? _readOnly;

        /// <summary>Indicate whether to mount volume as readOnly. Default value for this is false.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public bool? ReadOnly { get => this._readOnly; set => this._readOnly = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private string _source;

        /// <summary>Source of the mount. For bind mounts this is the host path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Source { get => this._source; set => this._source = value; }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        /// <summary>Target of the mount. For bind mounts this is the path in the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Target { get => this._target; set => this._target = value; }

        /// <summary>Backing field for <see cref="Tmpf" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITmpfsOptions _tmpf;

        /// <summary>tmpfs option of the mount</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITmpfsOptions Tmpf { get => (this._tmpf = this._tmpf ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.TmpfsOptions()); set => this._tmpf = value; }

        /// <summary>Mention the Tmpfs size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public int? TmpfSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITmpfsOptionsInternal)Tmpf).Size; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITmpfsOptionsInternal)Tmpf).Size = value ?? default(int); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.VolumeDefinitionType? _type;

        /// <summary>Type of Volume Definition. Possible Values: bind,volume,tmpfs,npipe</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.VolumeDefinitionType? Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Volume" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVolumeOptions _volume;

        /// <summary>Volume Options of the mount</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVolumeOptions Volume { get => (this._volume = this._volume ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VolumeOptions()); set => this._volume = value; }

        /// <summary>Indicate whether volume is nocopy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public bool? VolumeNocopy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVolumeOptionsInternal)Volume).Nocopy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVolumeOptionsInternal)Volume).Nocopy = value ?? default(bool); }

        /// <summary>Creates an new <see cref="VolumeDefinition" /> instance.</summary>
        public VolumeDefinition()
        {

        }
    }
    /// Describes the volume configuration for the container
    public partial interface IVolumeDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Indicate whether to create host path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicate whether to create host path.",
        SerializedName = @"createHostPath",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BindCreateHostPath { get; set; }
        /// <summary>Type of Bind Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of Bind Option",
        SerializedName = @"propagation",
        PossibleTypes = new [] { typeof(string) })]
        string BindPropagation { get; set; }
        /// <summary>Mention the selinux options.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mention the selinux options.",
        SerializedName = @"selinux",
        PossibleTypes = new [] { typeof(string) })]
        string BindSelinux { get; set; }
        /// <summary>Consistency of the volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Consistency of the volume",
        SerializedName = @"consistency",
        PossibleTypes = new [] { typeof(string) })]
        string Consistency { get; set; }
        /// <summary>Indicate whether to mount volume as readOnly. Default value for this is false.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicate whether to mount volume as readOnly. Default value for this is false.",
        SerializedName = @"readOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ReadOnly { get; set; }
        /// <summary>Source of the mount. For bind mounts this is the host path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source of the mount. For bind mounts this is the host path.",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        string Source { get; set; }
        /// <summary>Target of the mount. For bind mounts this is the path in the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target of the mount. For bind mounts this is the path in the container.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get; set; }
        /// <summary>Mention the Tmpfs size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mention the Tmpfs size",
        SerializedName = @"size",
        PossibleTypes = new [] { typeof(int) })]
        int? TmpfSize { get; set; }
        /// <summary>Type of Volume Definition. Possible Values: bind,volume,tmpfs,npipe</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of Volume Definition. Possible Values: bind,volume,tmpfs,npipe",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.VolumeDefinitionType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.VolumeDefinitionType? Type { get; set; }
        /// <summary>Indicate whether volume is nocopy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicate whether volume is nocopy",
        SerializedName = @"nocopy",
        PossibleTypes = new [] { typeof(bool) })]
        bool? VolumeNocopy { get; set; }

    }
    /// Describes the volume configuration for the container
    internal partial interface IVolumeDefinitionInternal

    {
        /// <summary>Bind Options of the mount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IBindOptions Bind { get; set; }
        /// <summary>Indicate whether to create host path.</summary>
        bool? BindCreateHostPath { get; set; }
        /// <summary>Type of Bind Option</summary>
        string BindPropagation { get; set; }
        /// <summary>Mention the selinux options.</summary>
        string BindSelinux { get; set; }
        /// <summary>Consistency of the volume</summary>
        string Consistency { get; set; }
        /// <summary>Indicate whether to mount volume as readOnly. Default value for this is false.</summary>
        bool? ReadOnly { get; set; }
        /// <summary>Source of the mount. For bind mounts this is the host path.</summary>
        string Source { get; set; }
        /// <summary>Target of the mount. For bind mounts this is the path in the container.</summary>
        string Target { get; set; }
        /// <summary>tmpfs option of the mount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITmpfsOptions Tmpf { get; set; }
        /// <summary>Mention the Tmpfs size</summary>
        int? TmpfSize { get; set; }
        /// <summary>Type of Volume Definition. Possible Values: bind,volume,tmpfs,npipe</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.VolumeDefinitionType? Type { get; set; }
        /// <summary>Volume Options of the mount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVolumeOptions Volume { get; set; }
        /// <summary>Indicate whether volume is nocopy</summary>
        bool? VolumeNocopy { get; set; }

    }
}