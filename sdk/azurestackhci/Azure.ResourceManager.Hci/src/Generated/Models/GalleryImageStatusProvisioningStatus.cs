// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The GalleryImageStatusProvisioningStatus. </summary>
    public partial class GalleryImageStatusProvisioningStatus
    {
        /// <summary> Initializes a new instance of GalleryImageStatusProvisioningStatus. </summary>
        internal GalleryImageStatusProvisioningStatus()
        {
        }

        /// <summary> Initializes a new instance of GalleryImageStatusProvisioningStatus. </summary>
        /// <param name="operationId"> The ID of the operation performed on the gallery image. </param>
        /// <param name="status"> The status of the operation performed on the gallery image [Succeeded, Failed, InProgress]. </param>
        internal GalleryImageStatusProvisioningStatus(string operationId, HciClusterStatus? status)
        {
            OperationId = operationId;
            Status = status;
        }

        /// <summary> The ID of the operation performed on the gallery image. </summary>
        public string OperationId { get; }
        /// <summary> The status of the operation performed on the gallery image [Succeeded, Failed, InProgress]. </summary>
        public HciClusterStatus? Status { get; }
    }
}
