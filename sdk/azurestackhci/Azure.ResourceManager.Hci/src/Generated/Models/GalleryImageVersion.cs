// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Specifies information about the gallery image version that you want to create or update. </summary>
    public partial class GalleryImageVersion
    {
        /// <summary> Initializes a new instance of GalleryImageVersion. </summary>
        public GalleryImageVersion()
        {
        }

        /// <summary> Initializes a new instance of GalleryImageVersion. </summary>
        /// <param name="name"> This is the version of the gallery image. </param>
        /// <param name="storageProfile"> This is the storage profile of a Gallery Image Version. </param>
        internal GalleryImageVersion(string name, GalleryImageVersionStorageProfile storageProfile)
        {
            Name = name;
            StorageProfile = storageProfile;
        }

        /// <summary> This is the version of the gallery image. </summary>
        public string Name { get; set; }
        /// <summary> This is the storage profile of a Gallery Image Version. </summary>
        internal GalleryImageVersionStorageProfile StorageProfile { get; set; }
        /// <summary> This property indicates the size of the VHD to be created. </summary>
        public long? OSDiskImageSizeInMB
        {
            get => StorageProfile is null ? default : StorageProfile.OSDiskImageSizeInMB;
        }
    }
}
