// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class SecurityAdminConfigurationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SecurityAdminConfigurationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SecurityAdminConfigurationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string networkManagerName, int? top, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkManagers/", false);
            uri.AppendPath(networkManagerName, true);
            uri.AppendPath("/securityAdminConfigurations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the network manager security admin configurations in a network manager, in a paginated format. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="networkManagerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityAdminConfigurationListResult>> ListAsync(string subscriptionId, string resourceGroupName, string networkManagerName, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(networkManagerName, nameof(networkManagerName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, networkManagerName, top, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAdminConfigurationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAdminConfigurationListResult.DeserializeSecurityAdminConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the network manager security admin configurations in a network manager, in a paginated format. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="networkManagerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityAdminConfigurationListResult> List(string subscriptionId, string resourceGroupName, string networkManagerName, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(networkManagerName, nameof(networkManagerName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, networkManagerName, top, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAdminConfigurationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAdminConfigurationListResult.DeserializeSecurityAdminConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string networkManagerName, string configurationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkManagers/", false);
            uri.AppendPath(networkManagerName, true);
            uri.AppendPath("/securityAdminConfigurations/", false);
            uri.AppendPath(configurationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieves a network manager security admin configuration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="configurationName"> The name of the network manager Security Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/> or <paramref name="configurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/> or <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityAdminConfigurationData>> GetAsync(string subscriptionId, string resourceGroupName, string networkManagerName, string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(networkManagerName, nameof(networkManagerName));
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAdminConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAdminConfigurationData.DeserializeSecurityAdminConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityAdminConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves a network manager security admin configuration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="configurationName"> The name of the network manager Security Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/> or <paramref name="configurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/> or <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityAdminConfigurationData> Get(string subscriptionId, string resourceGroupName, string networkManagerName, string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(networkManagerName, nameof(networkManagerName));
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAdminConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAdminConfigurationData.DeserializeSecurityAdminConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityAdminConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string networkManagerName, string configurationName, SecurityAdminConfigurationData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkManagers/", false);
            uri.AppendPath(networkManagerName, true);
            uri.AppendPath("/securityAdminConfigurations/", false);
            uri.AppendPath(configurationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates a network manager security admin configuration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="configurationName"> The name of the network manager Security Configuration. </param>
        /// <param name="data"> The security admin configuration to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/>, <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/> or <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityAdminConfigurationData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string networkManagerName, string configurationName, SecurityAdminConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(networkManagerName, nameof(networkManagerName));
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, networkManagerName, configurationName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SecurityAdminConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAdminConfigurationData.DeserializeSecurityAdminConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a network manager security admin configuration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="configurationName"> The name of the network manager Security Configuration. </param>
        /// <param name="data"> The security admin configuration to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/>, <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/> or <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityAdminConfigurationData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string networkManagerName, string configurationName, SecurityAdminConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(networkManagerName, nameof(networkManagerName));
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, networkManagerName, configurationName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SecurityAdminConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAdminConfigurationData.DeserializeSecurityAdminConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string networkManagerName, string configurationName, bool? force)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkManagers/", false);
            uri.AppendPath(networkManagerName, true);
            uri.AppendPath("/securityAdminConfigurations/", false);
            uri.AppendPath(configurationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (force != null)
            {
                uri.AppendQuery("force", force.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a network manager security admin configuration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="configurationName"> The name of the network manager Security Configuration. </param>
        /// <param name="force"> Deletes the resource even if it is part of a deployed configuration. If the configuration has been deployed, the service will do a cleanup deployment in the background, prior to the delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/> or <paramref name="configurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/> or <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string networkManagerName, string configurationName, bool? force = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(networkManagerName, nameof(networkManagerName));
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, networkManagerName, configurationName, force);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a network manager security admin configuration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="configurationName"> The name of the network manager Security Configuration. </param>
        /// <param name="force"> Deletes the resource even if it is part of a deployed configuration. If the configuration has been deployed, the service will do a cleanup deployment in the background, prior to the delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/> or <paramref name="configurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="networkManagerName"/> or <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string networkManagerName, string configurationName, bool? force = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(networkManagerName, nameof(networkManagerName));
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, networkManagerName, configurationName, force);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string networkManagerName, int? top, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the network manager security admin configurations in a network manager, in a paginated format. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="networkManagerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityAdminConfigurationListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string networkManagerName, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(networkManagerName, nameof(networkManagerName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, networkManagerName, top, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAdminConfigurationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityAdminConfigurationListResult.DeserializeSecurityAdminConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the network manager security admin configurations in a network manager, in a paginated format. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkManagerName"> The name of the network manager. </param>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="networkManagerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="networkManagerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityAdminConfigurationListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string networkManagerName, int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(networkManagerName, nameof(networkManagerName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, networkManagerName, top, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityAdminConfigurationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityAdminConfigurationListResult.DeserializeSecurityAdminConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
