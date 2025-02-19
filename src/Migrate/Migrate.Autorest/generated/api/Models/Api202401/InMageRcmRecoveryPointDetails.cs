// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageRcm provider specific recovery point details.</summary>
    public partial class InMageRcmRecoveryPointDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmRecoveryPointDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmRecoveryPointDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IProviderSpecificRecoveryPointDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IProviderSpecificRecoveryPointDetails __providerSpecificRecoveryPointDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ProviderSpecificRecoveryPointDetails();

        /// <summary>Gets the provider type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IProviderSpecificRecoveryPointDetailsInternal)__providerSpecificRecoveryPointDetails).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IProviderSpecificRecoveryPointDetailsInternal)__providerSpecificRecoveryPointDetails).InstanceType = value ; }

        /// <summary>Backing field for <see cref="IsMultiVMSyncPoint" /> property.</summary>
        private string _isMultiVMSyncPoint;

        /// <summary>A value indicating whether the recovery point is multi VM consistent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IsMultiVMSyncPoint { get => this._isMultiVMSyncPoint; }

        /// <summary>Internal Acessors for IsMultiVMSyncPoint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmRecoveryPointDetailsInternal.IsMultiVMSyncPoint { get => this._isMultiVMSyncPoint; set { {_isMultiVMSyncPoint = value;} } }

        /// <summary>Creates an new <see cref="InMageRcmRecoveryPointDetails" /> instance.</summary>
        public InMageRcmRecoveryPointDetails()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__providerSpecificRecoveryPointDetails), __providerSpecificRecoveryPointDetails);
            await eventListener.AssertObjectIsValid(nameof(__providerSpecificRecoveryPointDetails), __providerSpecificRecoveryPointDetails);
        }
    }
    /// InMageRcm provider specific recovery point details.
    public partial interface IInMageRcmRecoveryPointDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IProviderSpecificRecoveryPointDetails
    {
        /// <summary>A value indicating whether the recovery point is multi VM consistent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A value indicating whether the recovery point is multi VM consistent.",
        SerializedName = @"isMultiVmSyncPoint",
        PossibleTypes = new [] { typeof(string) })]
        string IsMultiVMSyncPoint { get;  }

    }
    /// InMageRcm provider specific recovery point details.
    internal partial interface IInMageRcmRecoveryPointDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IProviderSpecificRecoveryPointDetailsInternal
    {
        /// <summary>A value indicating whether the recovery point is multi VM consistent.</summary>
        string IsMultiVMSyncPoint { get; set; }

    }
}