### Example 1: Unlock critical operation protected by resource guard - delete backup instance
```powershell
$proxy = Get-AzDataProtectionResourceGuardMapping -ResourceGroupName $resourceGroupName -VaultName $vaultName -SubscriptionId $subscriptionId
$operationRequests = $proxy.ResourceGuardOperationDetail.DefaultResourceRequest
$resourceGuardOperationRequest = $operationRequests | Where-Object { $_ -match "deleteBackupInstanceRequests" }

$token = (Get-AzAccessToken -AsSecureString -TenantId "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx").Token
$instances = Get-AzDataProtectionBackupInstance -SubscriptionId $subscriptionId -ResourceGroupName $resourceGroupName -VaultName $vaultName

$unlock = Unlock-AzDataProtectionResourceGuardOperation -ResourceGroupName $resourceGroupName -SubscriptionId $subscriptionId -VaultName $vault.Name -ResourceGuardOperationRequest $resourceGuardOperationRequest -ResourceToBeDeleted $instances[0].Id -SecureToken $token
$unlock | fl 

Remove-AzDataProtectionBackupInstance -SubscriptionId $subscriptionId -ResourceGroupName $resourceGroupName -VaultName $vaultName  -Name $instances[0].Name
```

```output
2023-08-28T14:29:17.3982762Z
```

Ensure you have a contributor access over resource guard before doing unlock. 
Fetch and pass the cross tenant authorization token in case the resource guard is present in a different tenant.

The first command fetches the resource guard mapping between backup vault and the resource guard.
The second command fetches the operation requests corresponding to all critical operations protected by resource guard.
The third command fetch the operation request corresponding to the operation we want to unlock.
The fourth command fetches the access token corresponding to resource guard tenant.
The fifth command fetches the backup instance we want to stop protection.
The sixth command unlocks the delete backup operation which is protected by the resource guard. Ensure to have contributor access over resource guard before unlock.
Finally, we remove the backup instance for which we want to disable protection.

### Example 2: Unlock delete backup instance operation with short hand
```powershell
$token = (Get-AzAccessToken -AsSecureString -TenantId "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx").Token
$instances = Get-AzDataProtectionBackupInstance -SubscriptionId $subscriptionId -ResourceGroupName $resourceGroupName -VaultName $vaultName

$unlock = Unlock-AzDataProtectionResourceGuardOperation -ResourceGroupName $resourceGroupName -SubscriptionId $subscriptionId -VaultName $vault.Name -ResourceGuardOperationRequest DeleteBackupInstance -ResourceToBeDeleted $instances[0].Id -SecureToken $token
$unlock | fl 

Remove-AzDataProtectionBackupInstance -SubscriptionId $subscriptionId -ResourceGroupName $resourceGroupName -VaultName $vaultName  -Name $instances[0].Name
```

```output
2023-08-28T14:29:17.3982762Z
```

This example is faster way (short hand) for Example 1. In this example we show that by just passing the DeleteBackupInstance to ResourceGuardOperationRequest we can perform unlock. we pass the instance ARM Id as the resource to be deleted. Pass access token in case of cross tenant resource guard.

### Example 3: Unlock disable MUA operation with short hand
```powershell
$token = (Get-AzAccessToken -AsSecureString -TenantId "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx").Token
$proxy = Get-AzDataProtectionResourceGuardMapping -ResourceGroupName $resourceGroupName -VaultName $vaultName -SubscriptionId $subscriptionId

$unlock = Unlock-AzDataProtectionResourceGuardOperation -ResourceGroupName $resourceGroupName -SubscriptionId $subscriptionId -VaultName $vault.Name -ResourceGuardOperationRequest DisableMUA -ResourceToBeDeleted $proxy.Id -SecureToken $token
$unlock | fl 

Remove-AzDataProtectionResourceGuardMapping -ResourceGroupName $resourceGroupName -SubscriptionId $subscriptionId -VaultName $vaultName
```

```output
2023-08-28T14:29:17.3982762Z
```

This example is faster way (short hand) for Example 1. In this example we show that by just passing the DisableMUA to ResourceGuardOperationRequest we can perform unlock. we pass the resource guard mapping ARM Id as the resource to be deleted, this will disable MUA on the backup vault. Pass access token in case of cross tenant resource guard.
