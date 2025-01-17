// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> InterfaceIPConfiguration iPConfiguration in a network interface. </summary>
    public partial class IPConfiguration
    {
        /// <summary> Initializes a new instance of IPConfiguration. </summary>
        public IPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of IPConfiguration. </summary>
        /// <param name="name"> Name - The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="properties"> InterfaceIPConfigurationPropertiesFormat properties of IP configuration. </param>
        internal IPConfiguration(string name, IPConfigurationProperties properties)
        {
            Name = name;
            Properties = properties;
        }

        /// <summary> Name - The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> InterfaceIPConfigurationPropertiesFormat properties of IP configuration. </summary>
        public IPConfigurationProperties Properties { get; set; }
    }
}
