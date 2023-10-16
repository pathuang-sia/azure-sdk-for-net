// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The VirtualHardDisksListResult. </summary>
    internal partial class VirtualHardDisksListResult
    {
        /// <summary> Initializes a new instance of VirtualHardDisksListResult. </summary>
        internal VirtualHardDisksListResult()
        {
            Value = new ChangeTrackingList<VirtualHardDiskData>();
        }

        /// <summary> Initializes a new instance of VirtualHardDisksListResult. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal VirtualHardDisksListResult(IReadOnlyList<VirtualHardDiskData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<VirtualHardDiskData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
