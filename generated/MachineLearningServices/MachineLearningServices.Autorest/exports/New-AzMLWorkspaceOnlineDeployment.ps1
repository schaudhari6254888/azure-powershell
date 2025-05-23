
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create or update Inference Endpoint Deployment (asynchronous).
.Description
Create or update Inference Endpoint Deployment (asynchronous).
.Example
New-AzMLWorkspaceOnlineDeployment -ResourceGroupName ml-rg-test -WorkspaceName mlworkspace-cli01 -EndpointName online-pwsh01 -Name blue -Location "eastus" -EndpointComputeType 'Managed' `
-CodeId "/subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroups/ml-rg-test/providers/Microsoft.MachineLearningServices/workspaces/mlworkspace-cli01/codes/787fc793-1ac7-414e-a035-7248767b7b23/versions/1" -CodeScoringScript "score.py" `
-EnvironmentId "/subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroups/ml-rg-test/providers/Microsoft.MachineLearningServices/workspaces/mlworkspace-cli01/environments/CliV2AnonymousEnvironment/versions/8a424b013f5b0177929a1697d772da41" `
-Model "/subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroups/ml-rg-test/providers/Microsoft.MachineLearningServices/workspaces/mlworkspace-cli01/models/a99089c5-23a6-4431-9ecd-37c70f01c9bc/versions/1" -InstanceType "Standard_F2s_v2" `
-SkuName "Default" -SkuCapacity 1

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IOnlineDeployment
.Link
https://learn.microsoft.com/powershell/module/az.machinelearningservices/new-azmlworkspaceonlinedeployment
#>
function New-AzMLWorkspaceOnlineDeployment {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IOnlineDeployment])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Path')]
    [System.String]
    # Inference endpoint name.
    ${EndpointName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Path')]
    [System.String]
    # Inference Endpoint Deployment name.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Path')]
    [System.String]
    # Name of Azure Machine Learning workspace.
    ${WorkspaceName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EndpointComputeType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EndpointComputeType]
    # [Required] The compute type of the endpoint.
    ${EndpointComputeType},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # If true, enables Application Insights logging.
    ${AppInsightsEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # ARM resource ID of the code asset.
    ${CodeId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # [Required] The script to execute on startup.
    # eg.
    # "score.py"
    ${CodeScoringScript},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataCollectorCollections]))]
    [System.Collections.Hashtable]
    # [Required] The collection configuration.
    # Each collection has it own configuration to collect model data and the name of collection can be arbitrary string.Model data collector can be used for either payload logging or custom logging or both of them.
    # Collection request and response are reserved for payload logging, others are for custom logging.
    ${DataCollectorCollection},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RollingRateType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RollingRateType]
    # When model data is collected to blob storage, we need to roll the data to different path to avoid logging all of them in a single blob file.If the rolling rate is hour, all data will be collected in the blob path /yyyy/MM/dd/HH/.If it's day, all data will be collected in blob path /yyyy/MM/dd/.The other benefit of rolling path is that model monitoring ui is able to select a time range of data very quickly.
    ${DataCollectorRollingRate},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Description of the endpoint deployment.
    ${Description},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EgressPublicNetworkAccessType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EgressPublicNetworkAccessType]
    # If Enabled, allow egress public network access.
    # If Disabled, this will create secure egress.
    # Default: Enabled.
    ${EgressPublicNetworkAccess},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEndpointDeploymentPropertiesBaseProperties]))]
    [System.Collections.Hashtable]
    # Property dictionary.
    # Properties can be added, but not removed or altered.
    ${EndpointDeploymentPropertiesBaseProperty},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # ARM resource ID or AssetId of the environment specification for the endpoint deployment.
    ${EnvironmentId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEndpointDeploymentPropertiesBaseEnvironmentVariables]))]
    [System.Collections.Hashtable]
    # Environment variables configuration for the deployment.
    ${EnvironmentVariable},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ManagedServiceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ManagedServiceIdentityType]
    # Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # The set of user assigned identities associated with the resource.
    # The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
    # The dictionary values can be empty objects ({}) in requests.
    ${IdentityUserAssigned},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Compute instance type.
    ${InstanceType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type.
    ${Kind},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Int32]
    # The number of failures to allow before returning an unhealthy status.
    ${LivenessProbeFailureThreshold},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.TimeSpan]
    # The delay before the first probe in ISO 8601 format.
    ${LivenessProbeInitialDelay},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.TimeSpan]
    # The length of time between probes in ISO 8601 format.
    ${LivenessProbePeriod},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Int32]
    # The number of successful probes before returning a healthy status.
    ${LivenessProbeSuccessThreshold},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.TimeSpan]
    # The probe timeout in ISO 8601 format.
    ${LivenessProbeTimeout},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # The URI path to the model.
    ${Model},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # The path to mount the model in custom container.
    ${ModelMountPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Int32]
    # The number of failures to allow before returning an unhealthy status.
    ${ReadinessProbeFailureThreshold},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.TimeSpan]
    # The delay before the first probe in ISO 8601 format.
    ${ReadinessProbeInitialDelay},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.TimeSpan]
    # The length of time between probes in ISO 8601 format.
    ${ReadinessProbePeriod},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Int32]
    # The number of successful probes before returning a healthy status.
    ${ReadinessProbeSuccessThreshold},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.TimeSpan]
    # The probe timeout in ISO 8601 format.
    ${ReadinessProbeTimeout},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String[]]
    # For payload logging, we only collect payload by default.
    # If customers also want to collect the specified headers, they can set them in captureHeaders so that backend will collect those headers along with payload.
    ${RequestLoggingCaptureHeader},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Int32]
    # The number of maximum concurrent requests per node allowed per deployment.
    # Defaults to 1.
    ${RequestMaxConcurrentPerInstance},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.TimeSpan]
    # (Deprecated for Managed Online Endpoints) The maximum amount of time a request will stay in the queue in ISO 8601 format.Defaults to 500ms.(Now increase `request_timeout_ms` to account for any networking/queue delays)
    ${RequestMaxQueueWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.TimeSpan]
    # The scoring timeout in ISO 8601 format.Defaults to 5000ms.
    ${RequestTimeout},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScaleType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScaleType]
    # [Required] Type of deployment scaling algorithm
    ${ScaleType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Int32]
    # If the SKU supports scale out/in then the capacity integer should be included.
    # If scale out/in is not possible for the resource this may be omitted.
    ${SkuCapacity},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # If the service has different generations of hardware, for the same SKU, then that can be captured here.
    ${SkuFamily},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # The name of the SKU.
    # Ex - P3.
    # It is typically a letter+number code
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # The SKU size.
    # When the name field is the combination of tier and some other value, this would be the standalone code.
    ${SkuSize},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SkuTier])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SkuTier]
    # This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT.
    ${SkuTier},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            CreateExpanded = 'Az.MachineLearningServices.private\New-AzMLWorkspaceOnlineDeployment_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
