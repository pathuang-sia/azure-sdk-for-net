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

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="CaCertificateResource" /> and their operations.
    /// Each <see cref="CaCertificateResource" /> in the collection will belong to the same instance of <see cref="EventGridNamespaceResource" />.
    /// To get a <see cref="CaCertificateCollection" /> instance call the GetCaCertificates method from an instance of <see cref="EventGridNamespaceResource" />.
    /// </summary>
    public partial class CaCertificateCollection : ArmCollection, IEnumerable<CaCertificateResource>, IAsyncEnumerable<CaCertificateResource>
    {
        private readonly ClientDiagnostics _caCertificateClientDiagnostics;
        private readonly CaCertificatesRestOperations _caCertificateRestClient;

        /// <summary> Initializes a new instance of the <see cref="CaCertificateCollection"/> class for mocking. </summary>
        protected CaCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CaCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CaCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _caCertificateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", CaCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CaCertificateResource.ResourceType, out string caCertificateApiVersion);
            _caCertificateRestClient = new CaCertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, caCertificateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventGridNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventGridNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a CA certificate with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/caCertificates/{caCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CaCertificates_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="caCertificateName"> The CA certificate name. </param>
        /// <param name="data"> CA certificate information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="caCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="caCertificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CaCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string caCertificateName, CaCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(caCertificateName, nameof(caCertificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _caCertificateClientDiagnostics.CreateScope("CaCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _caCertificateRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, caCertificateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<CaCertificateResource>(new CaCertificateOperationSource(Client), _caCertificateClientDiagnostics, Pipeline, _caCertificateRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, caCertificateName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update a CA certificate with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/caCertificates/{caCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CaCertificates_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="caCertificateName"> The CA certificate name. </param>
        /// <param name="data"> CA certificate information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="caCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="caCertificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CaCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string caCertificateName, CaCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(caCertificateName, nameof(caCertificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _caCertificateClientDiagnostics.CreateScope("CaCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _caCertificateRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, caCertificateName, data, cancellationToken);
                var operation = new EventGridArmOperation<CaCertificateResource>(new CaCertificateOperationSource(Client), _caCertificateClientDiagnostics, Pipeline, _caCertificateRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, caCertificateName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get properties of a CA certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/caCertificates/{caCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CaCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="caCertificateName"> Name of the CA certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="caCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="caCertificateName"/> is null. </exception>
        public virtual async Task<Response<CaCertificateResource>> GetAsync(string caCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(caCertificateName, nameof(caCertificateName));

            using var scope = _caCertificateClientDiagnostics.CreateScope("CaCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _caCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, caCertificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CaCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a CA certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/caCertificates/{caCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CaCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="caCertificateName"> Name of the CA certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="caCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="caCertificateName"/> is null. </exception>
        public virtual Response<CaCertificateResource> Get(string caCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(caCertificateName, nameof(caCertificateName));

            using var scope = _caCertificateClientDiagnostics.CreateScope("CaCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _caCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, caCertificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CaCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all the CA certificates under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/caCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CaCertificates_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CaCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CaCertificateResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _caCertificateRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _caCertificateRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CaCertificateResource(Client, CaCertificateData.DeserializeCaCertificateData(e)), _caCertificateClientDiagnostics, Pipeline, "CaCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all the CA certificates under a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/caCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CaCertificates_ListByNamespace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CaCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CaCertificateResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _caCertificateRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _caCertificateRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CaCertificateResource(Client, CaCertificateData.DeserializeCaCertificateData(e)), _caCertificateClientDiagnostics, Pipeline, "CaCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/caCertificates/{caCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CaCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="caCertificateName"> Name of the CA certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="caCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="caCertificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string caCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(caCertificateName, nameof(caCertificateName));

            using var scope = _caCertificateClientDiagnostics.CreateScope("CaCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _caCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, caCertificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/namespaces/{namespaceName}/caCertificates/{caCertificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CaCertificates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="caCertificateName"> Name of the CA certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="caCertificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="caCertificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string caCertificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(caCertificateName, nameof(caCertificateName));

            using var scope = _caCertificateClientDiagnostics.CreateScope("CaCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _caCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, caCertificateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CaCertificateResource> IEnumerable<CaCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CaCertificateResource> IAsyncEnumerable<CaCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
