// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights
{
    internal class RoleAssignmentResourceFormatOperationSource : IOperationSource<RoleAssignmentResourceFormatResource>
    {
        private readonly ArmClient _client;

        internal RoleAssignmentResourceFormatOperationSource(ArmClient client)
        {
            _client = client;
        }

        RoleAssignmentResourceFormatResource IOperationSource<RoleAssignmentResourceFormatResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RoleAssignmentResourceFormatData.DeserializeRoleAssignmentResourceFormatData(document.RootElement);
            return new RoleAssignmentResourceFormatResource(_client, data);
        }

        async ValueTask<RoleAssignmentResourceFormatResource> IOperationSource<RoleAssignmentResourceFormatResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RoleAssignmentResourceFormatData.DeserializeRoleAssignmentResourceFormatData(document.RootElement);
            return new RoleAssignmentResourceFormatResource(_client, data);
        }
    }
}
