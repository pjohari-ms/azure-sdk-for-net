// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.StandbyPool
{
    /// <summary>
    /// A class representing a collection of <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> and their operations.
    /// Each <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> in the collection will belong to the same instance of <see cref="StandbyContainerGroupPoolResource"/>.
    /// To get a <see cref="StandbyContainerGroupPoolRuntimeViewCollection"/> instance call the GetStandbyContainerGroupPoolRuntimeViews method from an instance of <see cref="StandbyContainerGroupPoolResource"/>.
    /// </summary>
    public partial class StandbyContainerGroupPoolRuntimeViewCollection : ArmCollection, IEnumerable<StandbyContainerGroupPoolRuntimeViewResource>, IAsyncEnumerable<StandbyContainerGroupPoolRuntimeViewResource>
    {
        private readonly ClientDiagnostics _standbyContainerGroupPoolRuntimeViewClientDiagnostics;
        private readonly StandbyContainerGroupPoolRuntimeViewsRestOperations _standbyContainerGroupPoolRuntimeViewRestClient;

        /// <summary> Initializes a new instance of the <see cref="StandbyContainerGroupPoolRuntimeViewCollection"/> class for mocking. </summary>
        protected StandbyContainerGroupPoolRuntimeViewCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StandbyContainerGroupPoolRuntimeViewCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StandbyContainerGroupPoolRuntimeViewCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _standbyContainerGroupPoolRuntimeViewClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StandbyPool", StandbyContainerGroupPoolRuntimeViewResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StandbyContainerGroupPoolRuntimeViewResource.ResourceType, out string standbyContainerGroupPoolRuntimeViewApiVersion);
            _standbyContainerGroupPoolRuntimeViewRestClient = new StandbyContainerGroupPoolRuntimeViewsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, standbyContainerGroupPoolRuntimeViewApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StandbyContainerGroupPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StandbyContainerGroupPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a StandbyContainerGroupPoolRuntimeViewResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual async Task<Response<StandbyContainerGroupPoolRuntimeViewResource>> GetAsync(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyContainerGroupPoolRuntimeViewClientDiagnostics.CreateScope("StandbyContainerGroupPoolRuntimeViewCollection.Get");
            scope.Start();
            try
            {
                var response = await _standbyContainerGroupPoolRuntimeViewRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StandbyContainerGroupPoolRuntimeViewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a StandbyContainerGroupPoolRuntimeViewResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual Response<StandbyContainerGroupPoolRuntimeViewResource> Get(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyContainerGroupPoolRuntimeViewClientDiagnostics.CreateScope("StandbyContainerGroupPoolRuntimeViewCollection.Get");
            scope.Start();
            try
            {
                var response = _standbyContainerGroupPoolRuntimeViewRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StandbyContainerGroupPoolRuntimeViewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List StandbyContainerGroupPoolRuntimeViewResource resources by StandbyContainerGroupPoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}/runtimeViews</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolRuntimeViewResource_ListByStandbyPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StandbyContainerGroupPoolRuntimeViewResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _standbyContainerGroupPoolRuntimeViewRestClient.CreateListByStandbyPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _standbyContainerGroupPoolRuntimeViewRestClient.CreateListByStandbyPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StandbyContainerGroupPoolRuntimeViewResource(Client, StandbyContainerGroupPoolRuntimeViewData.DeserializeStandbyContainerGroupPoolRuntimeViewData(e)), _standbyContainerGroupPoolRuntimeViewClientDiagnostics, Pipeline, "StandbyContainerGroupPoolRuntimeViewCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List StandbyContainerGroupPoolRuntimeViewResource resources by StandbyContainerGroupPoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}/runtimeViews</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolRuntimeViewResource_ListByStandbyPool</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StandbyContainerGroupPoolRuntimeViewResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _standbyContainerGroupPoolRuntimeViewRestClient.CreateListByStandbyPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _standbyContainerGroupPoolRuntimeViewRestClient.CreateListByStandbyPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StandbyContainerGroupPoolRuntimeViewResource(Client, StandbyContainerGroupPoolRuntimeViewData.DeserializeStandbyContainerGroupPoolRuntimeViewData(e)), _standbyContainerGroupPoolRuntimeViewClientDiagnostics, Pipeline, "StandbyContainerGroupPoolRuntimeViewCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyContainerGroupPoolRuntimeViewClientDiagnostics.CreateScope("StandbyContainerGroupPoolRuntimeViewCollection.Exists");
            scope.Start();
            try
            {
                var response = await _standbyContainerGroupPoolRuntimeViewRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual Response<bool> Exists(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyContainerGroupPoolRuntimeViewClientDiagnostics.CreateScope("StandbyContainerGroupPoolRuntimeViewCollection.Exists");
            scope.Start();
            try
            {
                var response = _standbyContainerGroupPoolRuntimeViewRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual async Task<NullableResponse<StandbyContainerGroupPoolRuntimeViewResource>> GetIfExistsAsync(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyContainerGroupPoolRuntimeViewClientDiagnostics.CreateScope("StandbyContainerGroupPoolRuntimeViewCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _standbyContainerGroupPoolRuntimeViewRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StandbyContainerGroupPoolRuntimeViewResource>(response.GetRawResponse());
                return Response.FromValue(new StandbyContainerGroupPoolRuntimeViewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolRuntimeViewResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="runtimeView"/> is null. </exception>
        public virtual NullableResponse<StandbyContainerGroupPoolRuntimeViewResource> GetIfExists(string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var scope = _standbyContainerGroupPoolRuntimeViewClientDiagnostics.CreateScope("StandbyContainerGroupPoolRuntimeViewCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _standbyContainerGroupPoolRuntimeViewRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, runtimeView, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StandbyContainerGroupPoolRuntimeViewResource>(response.GetRawResponse());
                return Response.FromValue(new StandbyContainerGroupPoolRuntimeViewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StandbyContainerGroupPoolRuntimeViewResource> IEnumerable<StandbyContainerGroupPoolRuntimeViewResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StandbyContainerGroupPoolRuntimeViewResource> IAsyncEnumerable<StandbyContainerGroupPoolRuntimeViewResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
