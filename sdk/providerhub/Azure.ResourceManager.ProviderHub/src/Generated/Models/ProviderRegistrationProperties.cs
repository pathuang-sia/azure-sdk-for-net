// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ProviderRegistrationProperties. </summary>
    public partial class ProviderRegistrationProperties : ResourceProviderManifestProperties
    {
        /// <summary> Initializes a new instance of ProviderRegistrationProperties. </summary>
        public ProviderRegistrationProperties()
        {
        }

        /// <summary> Initializes a new instance of ProviderRegistrationProperties. </summary>
        /// <param name="providerAuthentication"></param>
        /// <param name="providerAuthorizations"></param>
        /// <param name="namespace"></param>
        /// <param name="providerVersion"></param>
        /// <param name="providerType"></param>
        /// <param name="requiredFeatures"></param>
        /// <param name="featuresRule"></param>
        /// <param name="requestHeaderOptions"></param>
        /// <param name="management"></param>
        /// <param name="capabilities"></param>
        /// <param name="metadata"> Anything. </param>
        /// <param name="templateDeploymentOptions"></param>
        /// <param name="providerHubMetadata"></param>
        /// <param name="provisioningState"></param>
        /// <param name="subscriptionLifecycleNotificationSpecifications"></param>
        internal ProviderRegistrationProperties(ResourceProviderAuthentication providerAuthentication, IList<ResourceProviderAuthorization> providerAuthorizations, string @namespace, string providerVersion, ResourceProviderType? providerType, IList<string> requiredFeatures, FeaturesRule featuresRule, RequestHeaderOptions requestHeaderOptions, ResourceProviderManagement management, IList<ResourceProviderCapabilities> capabilities, BinaryData metadata, TemplateDeploymentOptions templateDeploymentOptions, ProviderHubMetadata providerHubMetadata, ProviderHubProvisioningState? provisioningState, SubscriptionLifecycleNotificationSpecifications subscriptionLifecycleNotificationSpecifications) : base(providerAuthentication, providerAuthorizations, @namespace, providerVersion, providerType, requiredFeatures, featuresRule, requestHeaderOptions, management, capabilities, metadata, templateDeploymentOptions)
        {
            ProviderHubMetadata = providerHubMetadata;
            ProvisioningState = provisioningState;
            SubscriptionLifecycleNotificationSpecifications = subscriptionLifecycleNotificationSpecifications;
        }

        /// <summary> Gets or sets the provider hub metadata. </summary>
        public ProviderHubMetadata ProviderHubMetadata { get; set; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public ProviderHubProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets the subscription lifecycle notification specifications. </summary>
        public SubscriptionLifecycleNotificationSpecifications SubscriptionLifecycleNotificationSpecifications { get; set; }
    }
}
