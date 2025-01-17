// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing the VirtualHardDisk data model.
    /// The virtual hard disk resource definition.
    /// </summary>
    public partial class VirtualHardDiskData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualHardDiskData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualHardDiskData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of VirtualHardDiskData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extendedLocation of the resource. </param>
        /// <param name="blockSizeBytes"></param>
        /// <param name="diskSizeGB"> Size of the disk in GB. </param>
        /// <param name="dynamic"> Boolean for enabling dynamic sizing on the virtual hard disk. </param>
        /// <param name="logicalSectorBytes"></param>
        /// <param name="physicalSectorBytes"></param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine [V1, V2]. </param>
        /// <param name="diskFileFormat"> The format of the actual VHD file [vhd, vhdx]. </param>
        /// <param name="provisioningState"> Provisioning state of the virtual hard disk. </param>
        /// <param name="containerId"> Storage ContainerID of the storage container to be used for VHD. </param>
        /// <param name="status"> The observed state of virtual hard disks. </param>
        internal VirtualHardDiskData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, int? blockSizeBytes, long? diskSizeGB, bool? @dynamic, int? logicalSectorBytes, int? physicalSectorBytes, HyperVGeneration? hyperVGeneration, DiskFileFormat? diskFileFormat, ProvisioningStateEnum? provisioningState, ResourceIdentifier containerId, VirtualHardDiskStatus status) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            BlockSizeBytes = blockSizeBytes;
            DiskSizeGB = diskSizeGB;
            Dynamic = @dynamic;
            LogicalSectorBytes = logicalSectorBytes;
            PhysicalSectorBytes = physicalSectorBytes;
            HyperVGeneration = hyperVGeneration;
            DiskFileFormat = diskFileFormat;
            ProvisioningState = provisioningState;
            ContainerId = containerId;
            Status = status;
        }

        /// <summary> The extendedLocation of the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Gets or sets the block size bytes. </summary>
        public int? BlockSizeBytes { get; set; }
        /// <summary> Size of the disk in GB. </summary>
        public long? DiskSizeGB { get; set; }
        /// <summary> Boolean for enabling dynamic sizing on the virtual hard disk. </summary>
        public bool? Dynamic { get; set; }
        /// <summary> Gets or sets the logical sector bytes. </summary>
        public int? LogicalSectorBytes { get; set; }
        /// <summary> Gets or sets the physical sector bytes. </summary>
        public int? PhysicalSectorBytes { get; set; }
        /// <summary> The hypervisor generation of the Virtual Machine [V1, V2]. </summary>
        public HyperVGeneration? HyperVGeneration { get; set; }
        /// <summary> The format of the actual VHD file [vhd, vhdx]. </summary>
        public DiskFileFormat? DiskFileFormat { get; set; }
        /// <summary> Provisioning state of the virtual hard disk. </summary>
        public ProvisioningStateEnum? ProvisioningState { get; }
        /// <summary> Storage ContainerID of the storage container to be used for VHD. </summary>
        public ResourceIdentifier ContainerId { get; set; }
        /// <summary> The observed state of virtual hard disks. </summary>
        public VirtualHardDiskStatus Status { get; }
    }
}
