// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing a collection of <see cref="HciMachineExtensionResource" /> and their operations.
    /// Each <see cref="HciMachineExtensionResource" /> in the collection will belong to the same instance of <see cref="HciVirtualMachineResource" />.
    /// To get a <see cref="HciMachineExtensionCollection" /> instance call the GetHciMachineExtensions method from an instance of <see cref="HciVirtualMachineResource" />.
    /// </summary>
    public partial class HciMachineExtensionCollection : ArmCollection, IEnumerable<HciMachineExtensionResource>, IAsyncEnumerable<HciMachineExtensionResource>
    {
        private readonly ClientDiagnostics _hciMachineExtensionMachineExtensionsClientDiagnostics;
        private readonly MachineExtensionsRestOperations _hciMachineExtensionMachineExtensionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HciMachineExtensionCollection"/> class for mocking. </summary>
        protected HciMachineExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HciMachineExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HciMachineExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hciMachineExtensionMachineExtensionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", HciMachineExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HciMachineExtensionResource.ResourceType, out string hciMachineExtensionMachineExtensionsApiVersion);
            _hciMachineExtensionMachineExtensionsRestClient = new MachineExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hciMachineExtensionMachineExtensionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HciVirtualMachineResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HciVirtualMachineResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HciMachineExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string extensionName, HciMachineExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hciMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HciMachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hciMachineExtensionMachineExtensionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<HciMachineExtensionResource>(new HciMachineExtensionOperationSource(Client), _hciMachineExtensionMachineExtensionsClientDiagnostics, Pipeline, _hciMachineExtensionMachineExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create or update the extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HciMachineExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string extensionName, HciMachineExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hciMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HciMachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hciMachineExtensionMachineExtensionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data, cancellationToken);
                var operation = new HciArmOperation<HciMachineExtensionResource>(new HciMachineExtensionOperationSource(Client), _hciMachineExtensionMachineExtensionsClientDiagnostics, Pipeline, _hciMachineExtensionMachineExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<HciMachineExtensionResource>> GetAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _hciMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HciMachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _hciMachineExtensionMachineExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciMachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<HciMachineExtensionResource> Get(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _hciMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HciMachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _hciMachineExtensionMachineExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciMachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all extensions of a non-Azure machine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{name}/extensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_ListByVirtualMachines</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HciMachineExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HciMachineExtensionResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hciMachineExtensionMachineExtensionsRestClient.CreateListByVirtualMachinesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hciMachineExtensionMachineExtensionsRestClient.CreateListByVirtualMachinesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HciMachineExtensionResource(Client, HciMachineExtensionData.DeserializeHciMachineExtensionData(e)), _hciMachineExtensionMachineExtensionsClientDiagnostics, Pipeline, "HciMachineExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The operation to get all extensions of a non-Azure machine
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{name}/extensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_ListByVirtualMachines</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HciMachineExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HciMachineExtensionResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hciMachineExtensionMachineExtensionsRestClient.CreateListByVirtualMachinesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hciMachineExtensionMachineExtensionsRestClient.CreateListByVirtualMachinesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HciMachineExtensionResource(Client, HciMachineExtensionData.DeserializeHciMachineExtensionData(e)), _hciMachineExtensionMachineExtensionsClientDiagnostics, Pipeline, "HciMachineExtensionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _hciMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HciMachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hciMachineExtensionMachineExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{name}/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MachineExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="extensionName"> The name of the machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(extensionName, nameof(extensionName));

            using var scope = _hciMachineExtensionMachineExtensionsClientDiagnostics.CreateScope("HciMachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _hciMachineExtensionMachineExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, extensionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HciMachineExtensionResource> IEnumerable<HciMachineExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HciMachineExtensionResource> IAsyncEnumerable<HciMachineExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
