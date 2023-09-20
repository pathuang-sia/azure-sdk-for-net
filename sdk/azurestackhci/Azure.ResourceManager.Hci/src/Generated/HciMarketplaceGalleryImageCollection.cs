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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing a collection of <see cref="HciMarketplaceGalleryImageResource" /> and their operations.
    /// Each <see cref="HciMarketplaceGalleryImageResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="HciMarketplaceGalleryImageCollection" /> instance call the GetHciMarketplaceGalleryImages method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class HciMarketplaceGalleryImageCollection : ArmCollection, IEnumerable<HciMarketplaceGalleryImageResource>, IAsyncEnumerable<HciMarketplaceGalleryImageResource>
    {
        private readonly ClientDiagnostics _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics;
        private readonly MarketplaceGalleryImagesRestOperations _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="HciMarketplaceGalleryImageCollection"/> class for mocking. </summary>
        protected HciMarketplaceGalleryImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HciMarketplaceGalleryImageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HciMarketplaceGalleryImageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", HciMarketplaceGalleryImageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HciMarketplaceGalleryImageResource.ResourceType, out string hciMarketplaceGalleryImageMarketplaceGalleryImagesApiVersion);
            _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient = new MarketplaceGalleryImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hciMarketplaceGalleryImageMarketplaceGalleryImagesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update a marketplace gallery image. Please note some properties can be set only during marketplace gallery image creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="data"> The HciMarketplaceGalleryImage to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HciMarketplaceGalleryImageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string marketplaceGalleryImageName, HciMarketplaceGalleryImageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics.CreateScope("HciMarketplaceGalleryImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<HciMarketplaceGalleryImageResource>(new HciMarketplaceGalleryImageOperationSource(Client), _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics, Pipeline, _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// The operation to create or update a marketplace gallery image. Please note some properties can be set only during marketplace gallery image creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="data"> The HciMarketplaceGalleryImage to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HciMarketplaceGalleryImageResource> CreateOrUpdate(WaitUntil waitUntil, string marketplaceGalleryImageName, HciMarketplaceGalleryImageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics.CreateScope("HciMarketplaceGalleryImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, data, cancellationToken);
                var operation = new HciArmOperation<HciMarketplaceGalleryImageResource>(new HciMarketplaceGalleryImageOperationSource(Client), _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics, Pipeline, _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a marketplace gallery image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> is null. </exception>
        public virtual async Task<Response<HciMarketplaceGalleryImageResource>> GetAsync(string marketplaceGalleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));

            using var scope = _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics.CreateScope("HciMarketplaceGalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciMarketplaceGalleryImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a marketplace gallery image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> is null. </exception>
        public virtual Response<HciMarketplaceGalleryImageResource> Get(string marketplaceGalleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));

            using var scope = _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics.CreateScope("HciMarketplaceGalleryImageCollection.Get");
            scope.Start();
            try
            {
                var response = _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciMarketplaceGalleryImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the marketplace gallery images in the specified resource group. Use the nextLink property in the response to get the next page of marketplace gallery images.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HciMarketplaceGalleryImageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HciMarketplaceGalleryImageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HciMarketplaceGalleryImageResource(Client, HciMarketplaceGalleryImageData.DeserializeHciMarketplaceGalleryImageData(e)), _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics, Pipeline, "HciMarketplaceGalleryImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the marketplace gallery images in the specified resource group. Use the nextLink property in the response to get the next page of marketplace gallery images.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HciMarketplaceGalleryImageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HciMarketplaceGalleryImageResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HciMarketplaceGalleryImageResource(Client, HciMarketplaceGalleryImageData.DeserializeHciMarketplaceGalleryImageData(e)), _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics, Pipeline, "HciMarketplaceGalleryImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string marketplaceGalleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));

            using var scope = _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics.CreateScope("HciMarketplaceGalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/marketplaceGalleryImages/{marketplaceGalleryImageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceGalleryImages_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="marketplaceGalleryImageName"> Name of the marketplace gallery image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceGalleryImageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceGalleryImageName"/> is null. </exception>
        public virtual Response<bool> Exists(string marketplaceGalleryImageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(marketplaceGalleryImageName, nameof(marketplaceGalleryImageName));

            using var scope = _hciMarketplaceGalleryImageMarketplaceGalleryImagesClientDiagnostics.CreateScope("HciMarketplaceGalleryImageCollection.Exists");
            scope.Start();
            try
            {
                var response = _hciMarketplaceGalleryImageMarketplaceGalleryImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, marketplaceGalleryImageName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HciMarketplaceGalleryImageResource> IEnumerable<HciMarketplaceGalleryImageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HciMarketplaceGalleryImageResource> IAsyncEnumerable<HciMarketplaceGalleryImageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
