// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties related to the custom endpoints to which your IoT hub routes messages based on the routing rules. A maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint is allowed across all endpoint types for free hubs. </summary>
    public partial class RoutingEndpoints
    {
        /// <summary> Initializes a new instance of RoutingEndpoints. </summary>
        public RoutingEndpoints()
        {
            ServiceBusQueues = new ChangeTrackingList<RoutingServiceBusQueueEndpointProperties>();
            ServiceBusTopics = new ChangeTrackingList<RoutingServiceBusTopicEndpointProperties>();
            EventHubs = new ChangeTrackingList<RoutingEventHubProperties>();
            StorageContainers = new ChangeTrackingList<RoutingStorageContainerProperties>();
            CosmosDBSqlContainers = new ChangeTrackingList<RoutingCosmosDBSqlApiProperties>();
        }

        /// <summary> Initializes a new instance of RoutingEndpoints. </summary>
        /// <param name="serviceBusQueues"> The list of Service Bus queue endpoints that IoT hub routes the messages to, based on the routing rules. </param>
        /// <param name="serviceBusTopics"> The list of Service Bus topic endpoints that the IoT hub routes the messages to, based on the routing rules. </param>
        /// <param name="eventHubs"> The list of Event Hubs endpoints that IoT hub routes messages to, based on the routing rules. This list does not include the built-in Event Hubs endpoint. </param>
        /// <param name="storageContainers"> The list of storage container endpoints that IoT hub routes messages to, based on the routing rules. </param>
        /// <param name="cosmosDBSqlContainers"> The list of Cosmos DB container endpoints that IoT hub routes messages to, based on the routing rules. </param>
        internal RoutingEndpoints(IList<RoutingServiceBusQueueEndpointProperties> serviceBusQueues, IList<RoutingServiceBusTopicEndpointProperties> serviceBusTopics, IList<RoutingEventHubProperties> eventHubs, IList<RoutingStorageContainerProperties> storageContainers, IList<RoutingCosmosDBSqlApiProperties> cosmosDBSqlContainers)
        {
            ServiceBusQueues = serviceBusQueues;
            ServiceBusTopics = serviceBusTopics;
            EventHubs = eventHubs;
            StorageContainers = storageContainers;
            CosmosDBSqlContainers = cosmosDBSqlContainers;
        }

        /// <summary> The list of Service Bus queue endpoints that IoT hub routes the messages to, based on the routing rules. </summary>
        public IList<RoutingServiceBusQueueEndpointProperties> ServiceBusQueues { get; }
        /// <summary> The list of Service Bus topic endpoints that the IoT hub routes the messages to, based on the routing rules. </summary>
        public IList<RoutingServiceBusTopicEndpointProperties> ServiceBusTopics { get; }
        /// <summary> The list of Event Hubs endpoints that IoT hub routes messages to, based on the routing rules. This list does not include the built-in Event Hubs endpoint. </summary>
        public IList<RoutingEventHubProperties> EventHubs { get; }
        /// <summary> The list of storage container endpoints that IoT hub routes messages to, based on the routing rules. </summary>
        public IList<RoutingStorageContainerProperties> StorageContainers { get; }
        /// <summary> The list of Cosmos DB container endpoints that IoT hub routes messages to, based on the routing rules. </summary>
        public IList<RoutingCosmosDBSqlApiProperties> CosmosDBSqlContainers { get; }
    }
}
