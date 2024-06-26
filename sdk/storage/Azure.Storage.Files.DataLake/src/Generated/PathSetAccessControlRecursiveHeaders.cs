// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.Storage.Files.DataLake
{
    internal partial class PathSetAccessControlRecursiveHeaders
    {
        private readonly Response _response;
        public PathSetAccessControlRecursiveHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> When performing setAccessControlRecursive on a directory, the number of paths that are processed with each invocation is limited.  If the number of paths to be processed exceeds this limit, a continuation token is returned in this response header.  When a continuation token is returned in the response, it must be specified in a subsequent invocation of the setAccessControlRecursive operation to continue the setAccessControlRecursive operation on the directory. </summary>
        public string Continuation => _response.Headers.TryGetValue("x-ms-continuation", out string value) ? value : null;
        /// <summary> The version of the REST protocol used to process the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}
