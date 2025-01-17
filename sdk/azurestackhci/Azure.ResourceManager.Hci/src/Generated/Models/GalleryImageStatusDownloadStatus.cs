// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The download status of the gallery image. </summary>
    internal partial class GalleryImageStatusDownloadStatus
    {
        /// <summary> Initializes a new instance of GalleryImageStatusDownloadStatus. </summary>
        internal GalleryImageStatusDownloadStatus()
        {
        }

        /// <summary> Initializes a new instance of GalleryImageStatusDownloadStatus. </summary>
        /// <param name="downloadSizeInMB"> The downloaded sized of the image in MB. </param>
        internal GalleryImageStatusDownloadStatus(long? downloadSizeInMB)
        {
            DownloadSizeInMB = downloadSizeInMB;
        }

        /// <summary> The downloaded sized of the image in MB. </summary>
        public long? DownloadSizeInMB { get; }
    }
}
