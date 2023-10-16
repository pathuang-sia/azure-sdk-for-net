// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The marketplace gallery image resource patch definition. </summary>
    public partial class MarketplaceGalleryImagePatch
    {
        /// <summary> Initializes a new instance of MarketplaceGalleryImagePatch. </summary>
        public MarketplaceGalleryImagePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
