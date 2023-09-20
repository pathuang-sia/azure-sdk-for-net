// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ResourceConnector.Models
{
    /// <summary> Cluster User Credential appliance. </summary>
    public partial class ApplianceCredentialKubeconfig
    {
        /// <summary> Initializes a new instance of ApplianceCredentialKubeconfig. </summary>
        internal ApplianceCredentialKubeconfig()
        {
        }

        /// <summary> Initializes a new instance of ApplianceCredentialKubeconfig. </summary>
        /// <param name="name"> Name which contains the role of the kubeconfig. </param>
        /// <param name="value"> Contains the kubeconfig value. </param>
        internal ApplianceCredentialKubeconfig(AccessProfileType? name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> Name which contains the role of the kubeconfig. </summary>
        public AccessProfileType? Name { get; }
        /// <summary> Contains the kubeconfig value. </summary>
        public string Value { get; }
    }
}
