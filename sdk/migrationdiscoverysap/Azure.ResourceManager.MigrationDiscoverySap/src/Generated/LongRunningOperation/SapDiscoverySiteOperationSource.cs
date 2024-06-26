// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MigrationDiscoverySap
{
    internal class SapDiscoverySiteOperationSource : IOperationSource<SapDiscoverySiteResource>
    {
        private readonly ArmClient _client;

        internal SapDiscoverySiteOperationSource(ArmClient client)
        {
            _client = client;
        }

        SapDiscoverySiteResource IOperationSource<SapDiscoverySiteResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SapDiscoverySiteData.DeserializeSapDiscoverySiteData(document.RootElement);
            return new SapDiscoverySiteResource(_client, data);
        }

        async ValueTask<SapDiscoverySiteResource> IOperationSource<SapDiscoverySiteResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SapDiscoverySiteData.DeserializeSapDiscoverySiteData(document.RootElement);
            return new SapDiscoverySiteResource(_client, data);
        }
    }
}
