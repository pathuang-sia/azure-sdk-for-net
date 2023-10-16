// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The observed state of marketplace gallery images. </summary>
    public partial class MarketplaceGalleryImageStatus
    {
        /// <summary> Initializes a new instance of MarketplaceGalleryImageStatus. </summary>
        internal MarketplaceGalleryImageStatus()
        {
        }

        /// <summary> Initializes a new instance of MarketplaceGalleryImageStatus. </summary>
        /// <param name="errorCode"> MarketplaceGalleryImage provisioning error code. </param>
        /// <param name="errorMessage"> Descriptive error message. </param>
        /// <param name="provisioningStatus"></param>
        /// <param name="downloadStatus"> The download status of the gallery image. </param>
        /// <param name="progressPercentage"> The progress of the operation in percentage. </param>
        internal MarketplaceGalleryImageStatus(string errorCode, string errorMessage, MarketplaceGalleryImageStatusProvisioningStatus provisioningStatus, MarketplaceGalleryImageStatusDownloadStatus downloadStatus, long? progressPercentage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            ProvisioningStatus = provisioningStatus;
            DownloadStatus = downloadStatus;
            ProgressPercentage = progressPercentage;
        }

        /// <summary> MarketplaceGalleryImage provisioning error code. </summary>
        public string ErrorCode { get; }
        /// <summary> Descriptive error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Gets the provisioning status. </summary>
        public MarketplaceGalleryImageStatusProvisioningStatus ProvisioningStatus { get; }
        /// <summary> The download status of the gallery image. </summary>
        internal MarketplaceGalleryImageStatusDownloadStatus DownloadStatus { get; }
        /// <summary> The downloaded sized of the image in MB. </summary>
        public long? DownloadSizeInMB
        {
            get => DownloadStatus?.DownloadSizeInMB;
        }

        /// <summary> The progress of the operation in percentage. </summary>
        public long? ProgressPercentage { get; }
    }
}
