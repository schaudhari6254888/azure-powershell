---
external help file: Az.Aks-help.xml
Module Name: Az.Aks
online version: https://learn.microsoft.com/powershell/module/az.aks/get-azaksmanagedclusteroutboundnetworkdependencyendpoint
schema: 2.0.0
---

# Get-AzAksManagedClusterOutboundNetworkDependencyEndpoint

## SYNOPSIS
Gets a list of egress endpoints (network endpoints of all outbound dependencies) in the specified managed cluster.
The operation returns properties of each egress endpoint.

## SYNTAX

```
Get-AzAksManagedClusterOutboundNetworkDependencyEndpoint -ResourceGroupName <String> -ResourceName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets a list of egress endpoints (network endpoints of all outbound dependencies) in the specified managed cluster.
The operation returns properties of each egress endpoint.

## EXAMPLES

### Example 1: List egress endpoints (network endpoints of all outbound dependencies) in the specified managed cluster
```powershell
$result = Get-AzAksManagedClusterOutboundNetworkDependencyEndpoint -ResourceGroupName mygroup -ResourceName mycluster
$result | select Category,Endpoint
```

```output
Category                  Endpoint
--------                  --------
azure-resource-management {management.azure.com, login.microsoftonline.com}
images                    {mcr.microsoft.com, *.data.mcr.microsoft.com}
artifacts                 {packages.microsoft.com, acs-mirror.azureedge.net}
time-sync                 {ntp.ubuntu.com}
ubuntu-optional           {security.ubuntu.com, azure.archive.ubuntu.com, changelogs.ubuntu.com}
apiserver                 {aks0b1f-idb7vuoi.hcp.eastus.azmk8s.io}
```

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceName
The name of the managed cluster resource.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IOutboundEnvironmentEndpoint

## NOTES

## RELATED LINKS
