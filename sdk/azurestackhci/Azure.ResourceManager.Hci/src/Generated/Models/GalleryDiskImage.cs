// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> This is the disk image base class. </summary>
    internal partial class GalleryDiskImage
    {
        /// <summary> Initializes a new instance of GalleryDiskImage. </summary>
        public GalleryDiskImage()
        {
        }

        /// <summary> Initializes a new instance of GalleryDiskImage. </summary>
        /// <param name="sizeInMB"> This property indicates the size of the VHD to be created. </param>
        internal GalleryDiskImage(long? sizeInMB)
        {
            SizeInMB = sizeInMB;
        }

        /// <summary> This property indicates the size of the VHD to be created. </summary>
        public long? SizeInMB { get; }
    }
}
