namespace Microsoft.Azure.Management.Resources
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq;
    using System.Linq.Expressions;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ResourceGroupsOperations operations.
    /// </summary>
    public partial interface IResourceGroupsOperations
    {
        /// <summary>
        /// Get all of the resources under a subscription.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Query parameters. If null is passed returns all resource groups.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='top'>
        /// Query parameters. If null is passed returns all resource groups.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Page<GenericResource>>> ListResourcesWithHttpMessagesAsync(string resourceGroupName, Expression<Func<GenericResourceFilter, bool>> filter = default(Expression<Func<GenericResourceFilter, bool>>), int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks whether resource group exists.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to check. The name is case
        /// insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<bool?>> CheckExistenceWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to be created or updated.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update resource group service
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ResourceGroup>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, ResourceGroup parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to be created or updated.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update resource group service
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ResourceGroup>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, ResourceGroup parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Begin deleting resource group.To determine whether the operation
        /// has finished processing the request, call
        /// GetLongRunningOperationStatus.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to be deleted. The name is case
        /// insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Begin deleting resource group.To determine whether the operation
        /// has finished processing the request, call
        /// GetLongRunningOperationStatus.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to be deleted. The name is case
        /// insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to get. The name is case
        /// insensitive.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ResourceGroup>> GetWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resource groups can be updated through a simple PATCH operation to
        /// a group address. The format of the request is the same as that
        /// for creating a resource groups, though if a field is unspecified
        /// current value will be carried over.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to be created or updated. The name
        /// is case insensitive.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the update state resource group service
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ResourceGroup>> PatchWithHttpMessagesAsync(string resourceGroupName, ResourceGroup parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a collection of resource groups.
        /// </summary>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='top'>
        /// Query parameters. If null is passed returns all resource groups.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Page<ResourceGroup>>> ListWithHttpMessagesAsync(Expression<Func<ResourceGroupFilter, bool>> filter = default(Expression<Func<ResourceGroupFilter, bool>>), int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all of the resources under a subscription.
        /// </summary>
        /// <param name='nextPageLink'>
        /// NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Page<GenericResource>>> ListResourcesNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a collection of resource groups.
        /// </summary>
        /// <param name='nextPageLink'>
        /// NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Page<ResourceGroup>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
