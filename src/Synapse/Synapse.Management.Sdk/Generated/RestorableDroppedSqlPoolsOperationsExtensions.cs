// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for RestorableDroppedSqlPoolsOperations
    /// </summary>
    public static partial class RestorableDroppedSqlPoolsOperationsExtensions
    {
        /// <summary>
        /// Gets a deleted sql pool that can be restored
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='restorableDroppedSqlPoolId'>
        /// The id of the deleted Sql Pool in the form of
        /// sqlPoolName,deletionTimeInFileTimeFormat
        /// </param>
        public static RestorableDroppedSqlPool Get(this IRestorableDroppedSqlPoolsOperations operations, string resourceGroupName, string workspaceName, string restorableDroppedSqlPoolId)
        {
                return ((IRestorableDroppedSqlPoolsOperations)operations).GetAsync(resourceGroupName, workspaceName, restorableDroppedSqlPoolId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a deleted sql pool that can be restored
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='restorableDroppedSqlPoolId'>
        /// The id of the deleted Sql Pool in the form of
        /// sqlPoolName,deletionTimeInFileTimeFormat
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<RestorableDroppedSqlPool> GetAsync(this IRestorableDroppedSqlPoolsOperations operations, string resourceGroupName, string workspaceName, string restorableDroppedSqlPoolId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, restorableDroppedSqlPoolId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets a list of deleted Sql pools that can be restored
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        public static System.Collections.Generic.IEnumerable<RestorableDroppedSqlPool> ListByWorkspace(this IRestorableDroppedSqlPoolsOperations operations, string resourceGroupName, string workspaceName)
        {
                return ((IRestorableDroppedSqlPoolsOperations)operations).ListByWorkspaceAsync(resourceGroupName, workspaceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a list of deleted Sql pools that can be restored
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<RestorableDroppedSqlPool>> ListByWorkspaceAsync(this IRestorableDroppedSqlPoolsOperations operations, string resourceGroupName, string workspaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByWorkspaceWithHttpMessagesAsync(resourceGroupName, workspaceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
