// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set network profile's network configurations. </summary>
    public partial class VirtualMachineScaleSetUpdateNetworkConfiguration : ComputeWriteableSubResourceData
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdateNetworkConfiguration. </summary>
        public VirtualMachineScaleSetUpdateNetworkConfiguration()
        {
            IPConfigurations = new ChangeTrackingList<VirtualMachineScaleSetUpdateIPConfiguration>();
        }

        /// <summary> The network configuration name. </summary>
        public string Name { get; set; }
        /// <summary> Whether this is a primary NIC on a virtual machine. </summary>
        public bool? Primary { get; set; }
        /// <summary> Specifies whether the network interface is accelerated networking-enabled. </summary>
        public bool? EnableAcceleratedNetworking { get; set; }
        /// <summary> Specifies whether the network interface is disabled for tcp state tracking. </summary>
        public bool? IsTcpStateTrackingDisabled { get; set; }
        /// <summary> Specifies whether the network interface is FPGA networking-enabled. </summary>
        public bool? EnableFpga { get; set; }
        /// <summary> The network security group. </summary>
        internal WritableSubResource NetworkSecurityGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier NetworkSecurityGroupId
        {
            get => NetworkSecurityGroup is null ? default : NetworkSecurityGroup.Id;
            set
            {
                if (NetworkSecurityGroup is null)
                    NetworkSecurityGroup = new WritableSubResource();
                NetworkSecurityGroup.Id = value;
            }
        }

        /// <summary> The dns settings to be applied on the network interfaces. </summary>
        internal VirtualMachineScaleSetNetworkConfigurationDnsSettings DnsSettings { get; set; }
        /// <summary> List of DNS servers IP addresses. </summary>
        public IList<string> DnsServers
        {
            get
            {
                if (DnsSettings is null)
                    DnsSettings = new VirtualMachineScaleSetNetworkConfigurationDnsSettings();
                return DnsSettings.DnsServers;
            }
        }

        /// <summary> The virtual machine scale set IP Configuration. </summary>
        public IList<VirtualMachineScaleSetUpdateIPConfiguration> IPConfigurations { get; }
        /// <summary> Whether IP forwarding enabled on this NIC. </summary>
        public bool? EnableIPForwarding { get; set; }
        /// <summary> Specify what happens to the network interface when the VM is deleted. </summary>
        public ComputeDeleteOption? DeleteOption { get; set; }
        /// <summary> Specifies whether the Auxiliary mode is enabled for the Network Interface resource. </summary>
        public ComputeNetworkInterfaceAuxiliaryMode? AuxiliaryMode { get; set; }
        /// <summary> Specifies whether the Auxiliary sku is enabled for the Network Interface resource. </summary>
        public ComputeNetworkInterfaceAuxiliarySku? AuxiliarySku { get; set; }
    }
}
