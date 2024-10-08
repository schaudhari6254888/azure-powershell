$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Start-AzContainerGroupConfidentialSku.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Start-AzContainerGroupConfidentialSku' {
    It 'Start' {
        Start-AzContainerGroup -Name $env.confidentialContainerGroupName -ResourceGroupName $env.resourceGroupName
    }

    It 'StartViaIdentity' {
        $start = Get-AzContainerGroup -ResourceGroupName $env.resourceGroupName -Name $env.confidentialContainerGroupName
        Start-AzContainerGroup -InputObject $start
    }
}
