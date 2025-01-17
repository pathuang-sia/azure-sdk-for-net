// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The observed state of network interfaces. </summary>
    public partial class NetworkInterfaceStatus
    {
        /// <summary> Initializes a new instance of NetworkInterfaceStatus. </summary>
        internal NetworkInterfaceStatus()
        {
        }

        /// <summary> Initializes a new instance of NetworkInterfaceStatus. </summary>
        /// <param name="errorCode"> NetworkInterface provisioning error code. </param>
        /// <param name="errorMessage"> Descriptive error message. </param>
        /// <param name="provisioningStatus"></param>
        internal NetworkInterfaceStatus(string errorCode, string errorMessage, NetworkInterfaceStatusProvisioningStatus provisioningStatus)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            ProvisioningStatus = provisioningStatus;
        }

        /// <summary> NetworkInterface provisioning error code. </summary>
        public string ErrorCode { get; }
        /// <summary> Descriptive error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Gets the provisioning status. </summary>
        public NetworkInterfaceStatusProvisioningStatus ProvisioningStatus { get; }
    }
}
