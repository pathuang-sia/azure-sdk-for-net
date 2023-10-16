// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> HTTP Proxy configuration for the VM. </summary>
    public partial class HttpProxyConfiguration
    {
        /// <summary> Initializes a new instance of HttpProxyConfiguration. </summary>
        public HttpProxyConfiguration()
        {
            NoProxy = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of HttpProxyConfiguration. </summary>
        /// <param name="httpProxy"> The HTTP proxy server endpoint to use. </param>
        /// <param name="httpsProxy"> The HTTPS proxy server endpoint to use. </param>
        /// <param name="noProxy"> The endpoints that should not go through proxy. </param>
        /// <param name="trustedCa"> Alternative CA cert to use for connecting to proxy servers. </param>
        internal HttpProxyConfiguration(string httpProxy, string httpsProxy, IList<string> noProxy, string trustedCa)
        {
            HttpProxy = httpProxy;
            HttpsProxy = httpsProxy;
            NoProxy = noProxy;
            TrustedCa = trustedCa;
        }

        /// <summary> The HTTP proxy server endpoint to use. </summary>
        public string HttpProxy { get; set; }
        /// <summary> The HTTPS proxy server endpoint to use. </summary>
        public string HttpsProxy { get; set; }
        /// <summary> The endpoints that should not go through proxy. </summary>
        public IList<string> NoProxy { get; }
        /// <summary> Alternative CA cert to use for connecting to proxy servers. </summary>
        public string TrustedCa { get; set; }
    }
}
