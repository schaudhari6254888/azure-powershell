// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>VMwareCbt protected disk details.</summary>
    public partial class VMwareCbtProtectedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal
    {

        /// <summary>Backing field for <see cref="CapacityInByte" /> property.</summary>
        private long? _capacityInByte;

        /// <summary>The disk capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? CapacityInByte { get => this._capacityInByte; }

        /// <summary>Backing field for <see cref="DiskEncryptionSetId" /> property.</summary>
        private string _diskEncryptionSetId;

        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskEncryptionSetId { get => this._diskEncryptionSetId; }

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The disk id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; }

        /// <summary>Backing field for <see cref="DiskName" /> property.</summary>
        private string _diskName;

        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskName { get => this._diskName; }

        /// <summary>Backing field for <see cref="DiskPath" /> property.</summary>
        private string _diskPath;

        /// <summary>The disk path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskPath { get => this._diskPath; }

        /// <summary>Backing field for <see cref="DiskType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? _diskType;

        /// <summary>The disk type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get => this._diskType; set => this._diskType = value; }

        /// <summary>Backing field for <see cref="GatewayOperationDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetails _gatewayOperationDetail;

        /// <summary>A value indicating the gateway operation details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetails GatewayOperationDetail { get => (this._gatewayOperationDetail = this._gatewayOperationDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.GatewayOperationDetails()); }

        /// <summary>A value indicating the datastore collection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string[] GatewayOperationDetailDataStore { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).DataStore; }

        /// <summary>A value indicating the ESXi host name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string GatewayOperationDetailHostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).HostName; }

        /// <summary>A value indicating the progress percentage of gateway operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public int? GatewayOperationDetailProgressPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).ProgressPercentage; }

        /// <summary>A value indicating the state of gateway operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string GatewayOperationDetailState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).State; }

        /// <summary>A value indicating the time elapsed for the operation in milliseconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? GatewayOperationDetailTimeElapsed { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).TimeElapsed; }

        /// <summary>A value indicating the time remaining for the operation in milliseconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? GatewayOperationDetailTimeRemaining { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).TimeRemaining; }

        /// <summary>A value indicating the upload speed in bytes per second.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? GatewayOperationDetailUploadSpeed { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).UploadSpeed; }

        /// <summary>A value indicating the VMware read throughput in bytes per second.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public long? GatewayOperationDetailVmwareReadThroughput { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).VmwareReadThroughput; }

        /// <summary>Backing field for <see cref="IsOSDisk" /> property.</summary>
        private string _isOSDisk;

        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsOSDisk { get => this._isOSDisk; }

        /// <summary>Backing field for <see cref="LogStorageAccountId" /> property.</summary>
        private string _logStorageAccountId;

        /// <summary>The log storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LogStorageAccountId { get => this._logStorageAccountId; }

        /// <summary>Backing field for <see cref="LogStorageAccountSasSecretName" /> property.</summary>
        private string _logStorageAccountSasSecretName;

        /// <summary>The key vault secret name of the log storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LogStorageAccountSasSecretName { get => this._logStorageAccountSasSecretName; }

        /// <summary>Internal Acessors for CapacityInByte</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.CapacityInByte { get => this._capacityInByte; set { {_capacityInByte = value;} } }

        /// <summary>Internal Acessors for DiskEncryptionSetId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.DiskEncryptionSetId { get => this._diskEncryptionSetId; set { {_diskEncryptionSetId = value;} } }

        /// <summary>Internal Acessors for DiskId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.DiskId { get => this._diskId; set { {_diskId = value;} } }

        /// <summary>Internal Acessors for DiskName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.DiskName { get => this._diskName; set { {_diskName = value;} } }

        /// <summary>Internal Acessors for DiskPath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.DiskPath { get => this._diskPath; set { {_diskPath = value;} } }

        /// <summary>Internal Acessors for GatewayOperationDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.GatewayOperationDetail { get => (this._gatewayOperationDetail = this._gatewayOperationDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.GatewayOperationDetails()); set { {_gatewayOperationDetail = value;} } }

        /// <summary>Internal Acessors for GatewayOperationDetailDataStore</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.GatewayOperationDetailDataStore { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).DataStore; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).DataStore = value; }

        /// <summary>Internal Acessors for GatewayOperationDetailHostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.GatewayOperationDetailHostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).HostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).HostName = value; }

        /// <summary>Internal Acessors for GatewayOperationDetailProgressPercentage</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.GatewayOperationDetailProgressPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).ProgressPercentage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).ProgressPercentage = value; }

        /// <summary>Internal Acessors for GatewayOperationDetailState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.GatewayOperationDetailState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).State = value; }

        /// <summary>Internal Acessors for GatewayOperationDetailTimeElapsed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.GatewayOperationDetailTimeElapsed { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).TimeElapsed; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).TimeElapsed = value; }

        /// <summary>Internal Acessors for GatewayOperationDetailTimeRemaining</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.GatewayOperationDetailTimeRemaining { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).TimeRemaining; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).TimeRemaining = value; }

        /// <summary>Internal Acessors for GatewayOperationDetailUploadSpeed</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.GatewayOperationDetailUploadSpeed { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).UploadSpeed; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).UploadSpeed = value; }

        /// <summary>Internal Acessors for GatewayOperationDetailVmwareReadThroughput</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.GatewayOperationDetailVmwareReadThroughput { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).VmwareReadThroughput; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetailsInternal)GatewayOperationDetail).VmwareReadThroughput = value; }

        /// <summary>Internal Acessors for IsOSDisk</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.IsOSDisk { get => this._isOSDisk; set { {_isOSDisk = value;} } }

        /// <summary>Internal Acessors for LogStorageAccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.LogStorageAccountId { get => this._logStorageAccountId; set { {_logStorageAccountId = value;} } }

        /// <summary>Internal Acessors for LogStorageAccountSasSecretName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.LogStorageAccountSasSecretName { get => this._logStorageAccountSasSecretName; set { {_logStorageAccountSasSecretName = value;} } }

        /// <summary>Internal Acessors for SeedBlobUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.SeedBlobUri { get => this._seedBlobUri; set { {_seedBlobUri = value;} } }

        /// <summary>Internal Acessors for SeedManagedDiskId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.SeedManagedDiskId { get => this._seedManagedDiskId; set { {_seedManagedDiskId = value;} } }

        /// <summary>Internal Acessors for TargetBlobUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.TargetBlobUri { get => this._targetBlobUri; set { {_targetBlobUri = value;} } }

        /// <summary>Internal Acessors for TargetManagedDiskId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMwareCbtProtectedDiskDetailsInternal.TargetManagedDiskId { get => this._targetManagedDiskId; set { {_targetManagedDiskId = value;} } }

        /// <summary>Backing field for <see cref="SectorSizeInByte" /> property.</summary>
        private int? _sectorSizeInByte;

        /// <summary>The logical sector size (in bytes), 512 by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? SectorSizeInByte { get => this._sectorSizeInByte; set => this._sectorSizeInByte = value; }

        /// <summary>Backing field for <see cref="SeedBlobUri" /> property.</summary>
        private string _seedBlobUri;

        /// <summary>The uri of the seed blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SeedBlobUri { get => this._seedBlobUri; }

        /// <summary>Backing field for <see cref="SeedManagedDiskId" /> property.</summary>
        private string _seedManagedDiskId;

        /// <summary>The ARM Id of the seed managed disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SeedManagedDiskId { get => this._seedManagedDiskId; }

        /// <summary>Backing field for <see cref="TargetBlobUri" /> property.</summary>
        private string _targetBlobUri;

        /// <summary>The uri of the target blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetBlobUri { get => this._targetBlobUri; }

        /// <summary>Backing field for <see cref="TargetDiskName" /> property.</summary>
        private string _targetDiskName;

        /// <summary>The name for the target managed disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetDiskName { get => this._targetDiskName; set => this._targetDiskName = value; }

        /// <summary>Backing field for <see cref="TargetManagedDiskId" /> property.</summary>
        private string _targetManagedDiskId;

        /// <summary>The ARM Id of the target managed disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetManagedDiskId { get => this._targetManagedDiskId; }

        /// <summary>Creates an new <see cref="VMwareCbtProtectedDiskDetails" /> instance.</summary>
        public VMwareCbtProtectedDiskDetails()
        {

        }
    }
    /// VMwareCbt protected disk details.
    public partial interface IVMwareCbtProtectedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The disk capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk capacity in bytes.",
        SerializedName = @"capacityInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? CapacityInByte { get;  }
        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The DiskEncryptionSet ARM Id.",
        SerializedName = @"diskEncryptionSetId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionSetId { get;  }
        /// <summary>The disk id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk id.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get;  }
        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk name.",
        SerializedName = @"diskName",
        PossibleTypes = new [] { typeof(string) })]
        string DiskName { get;  }
        /// <summary>The disk path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk path.",
        SerializedName = @"diskPath",
        PossibleTypes = new [] { typeof(string) })]
        string DiskPath { get;  }
        /// <summary>The disk type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk type.",
        SerializedName = @"diskType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get; set; }
        /// <summary>A value indicating the datastore collection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the datastore collection.",
        SerializedName = @"dataStores",
        PossibleTypes = new [] { typeof(string) })]
        string[] GatewayOperationDetailDataStore { get;  }
        /// <summary>A value indicating the ESXi host name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the ESXi host name.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string GatewayOperationDetailHostName { get;  }
        /// <summary>A value indicating the progress percentage of gateway operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the progress percentage of gateway operation.",
        SerializedName = @"progressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? GatewayOperationDetailProgressPercentage { get;  }
        /// <summary>A value indicating the state of gateway operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the state of gateway operation.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string GatewayOperationDetailState { get;  }
        /// <summary>A value indicating the time elapsed for the operation in milliseconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the time elapsed for the operation in milliseconds.",
        SerializedName = @"timeElapsed",
        PossibleTypes = new [] { typeof(long) })]
        long? GatewayOperationDetailTimeElapsed { get;  }
        /// <summary>A value indicating the time remaining for the operation in milliseconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the time remaining for the operation in milliseconds.",
        SerializedName = @"timeRemaining",
        PossibleTypes = new [] { typeof(long) })]
        long? GatewayOperationDetailTimeRemaining { get;  }
        /// <summary>A value indicating the upload speed in bytes per second.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the upload speed in bytes per second.",
        SerializedName = @"uploadSpeed",
        PossibleTypes = new [] { typeof(long) })]
        long? GatewayOperationDetailUploadSpeed { get;  }
        /// <summary>A value indicating the VMware read throughput in bytes per second.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating the VMware read throughput in bytes per second.",
        SerializedName = @"vmwareReadThroughput",
        PossibleTypes = new [] { typeof(long) })]
        long? GatewayOperationDetailVmwareReadThroughput { get;  }
        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether the disk is the OS disk.",
        SerializedName = @"isOSDisk",
        PossibleTypes = new [] { typeof(string) })]
        string IsOSDisk { get;  }
        /// <summary>The log storage account ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The log storage account ARM Id.",
        SerializedName = @"logStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string LogStorageAccountId { get;  }
        /// <summary>The key vault secret name of the log storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The key vault secret name of the log storage account.",
        SerializedName = @"logStorageAccountSasSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string LogStorageAccountSasSecretName { get;  }
        /// <summary>The logical sector size (in bytes), 512 by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The logical sector size (in bytes), 512 by default.",
        SerializedName = @"sectorSizeInBytes",
        PossibleTypes = new [] { typeof(int) })]
        int? SectorSizeInByte { get; set; }
        /// <summary>The uri of the seed blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The uri of the seed blob.",
        SerializedName = @"seedBlobUri",
        PossibleTypes = new [] { typeof(string) })]
        string SeedBlobUri { get;  }
        /// <summary>The ARM Id of the seed managed disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ARM Id of the seed managed disk.",
        SerializedName = @"seedManagedDiskId",
        PossibleTypes = new [] { typeof(string) })]
        string SeedManagedDiskId { get;  }
        /// <summary>The uri of the target blob.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The uri of the target blob.",
        SerializedName = @"targetBlobUri",
        PossibleTypes = new [] { typeof(string) })]
        string TargetBlobUri { get;  }
        /// <summary>The name for the target managed disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name for the target managed disk.",
        SerializedName = @"targetDiskName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDiskName { get; set; }
        /// <summary>The ARM Id of the target managed disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ARM Id of the target managed disk.",
        SerializedName = @"targetManagedDiskId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetManagedDiskId { get;  }

    }
    /// VMwareCbt protected disk details.
    internal partial interface IVMwareCbtProtectedDiskDetailsInternal

    {
        /// <summary>The disk capacity in bytes.</summary>
        long? CapacityInByte { get; set; }
        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        string DiskEncryptionSetId { get; set; }
        /// <summary>The disk id.</summary>
        string DiskId { get; set; }
        /// <summary>The disk name.</summary>
        string DiskName { get; set; }
        /// <summary>The disk path.</summary>
        string DiskPath { get; set; }
        /// <summary>The disk type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get; set; }
        /// <summary>A value indicating the gateway operation details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGatewayOperationDetails GatewayOperationDetail { get; set; }
        /// <summary>A value indicating the datastore collection.</summary>
        string[] GatewayOperationDetailDataStore { get; set; }
        /// <summary>A value indicating the ESXi host name.</summary>
        string GatewayOperationDetailHostName { get; set; }
        /// <summary>A value indicating the progress percentage of gateway operation.</summary>
        int? GatewayOperationDetailProgressPercentage { get; set; }
        /// <summary>A value indicating the state of gateway operation.</summary>
        string GatewayOperationDetailState { get; set; }
        /// <summary>A value indicating the time elapsed for the operation in milliseconds.</summary>
        long? GatewayOperationDetailTimeElapsed { get; set; }
        /// <summary>A value indicating the time remaining for the operation in milliseconds.</summary>
        long? GatewayOperationDetailTimeRemaining { get; set; }
        /// <summary>A value indicating the upload speed in bytes per second.</summary>
        long? GatewayOperationDetailUploadSpeed { get; set; }
        /// <summary>A value indicating the VMware read throughput in bytes per second.</summary>
        long? GatewayOperationDetailVmwareReadThroughput { get; set; }
        /// <summary>A value indicating whether the disk is the OS disk.</summary>
        string IsOSDisk { get; set; }
        /// <summary>The log storage account ARM Id.</summary>
        string LogStorageAccountId { get; set; }
        /// <summary>The key vault secret name of the log storage account.</summary>
        string LogStorageAccountSasSecretName { get; set; }
        /// <summary>The logical sector size (in bytes), 512 by default.</summary>
        int? SectorSizeInByte { get; set; }
        /// <summary>The uri of the seed blob.</summary>
        string SeedBlobUri { get; set; }
        /// <summary>The ARM Id of the seed managed disk.</summary>
        string SeedManagedDiskId { get; set; }
        /// <summary>The uri of the target blob.</summary>
        string TargetBlobUri { get; set; }
        /// <summary>The name for the target managed disk.</summary>
        string TargetDiskName { get; set; }
        /// <summary>The ARM Id of the target managed disk.</summary>
        string TargetManagedDiskId { get; set; }

    }
}