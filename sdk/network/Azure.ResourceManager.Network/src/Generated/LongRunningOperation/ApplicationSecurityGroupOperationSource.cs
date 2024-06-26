// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class ApplicationSecurityGroupOperationSource : IOperationSource<ApplicationSecurityGroupResource>
    {
        private readonly ArmClient _client;

        internal ApplicationSecurityGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        ApplicationSecurityGroupResource IOperationSource<ApplicationSecurityGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApplicationSecurityGroupData.DeserializeApplicationSecurityGroupData(document.RootElement);
            return new ApplicationSecurityGroupResource(_client, data);
        }

        async ValueTask<ApplicationSecurityGroupResource> IOperationSource<ApplicationSecurityGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApplicationSecurityGroupData.DeserializeApplicationSecurityGroupData(document.RootElement);
            return new ApplicationSecurityGroupResource(_client, data);
        }
    }
}
