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
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary>
    /// A class representing a collection of <see cref="CloudEndpointResource"/> and their operations.
    /// Each <see cref="CloudEndpointResource"/> in the collection will belong to the same instance of <see cref="StorageSyncGroupResource"/>.
    /// To get a <see cref="CloudEndpointCollection"/> instance call the GetCloudEndpoints method from an instance of <see cref="StorageSyncGroupResource"/>.
    /// </summary>
    public partial class CloudEndpointCollection : ArmCollection, IEnumerable<CloudEndpointResource>, IAsyncEnumerable<CloudEndpointResource>
    {
        private readonly ClientDiagnostics _cloudEndpointClientDiagnostics;
        private readonly CloudEndpointsRestOperations _cloudEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="CloudEndpointCollection"/> class for mocking. </summary>
        protected CloudEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CloudEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cloudEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageSync", CloudEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CloudEndpointResource.ResourceType, out string cloudEndpointApiVersion);
            _cloudEndpointRestClient = new CloudEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cloudEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageSyncGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageSyncGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new CloudEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints/{cloudEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudEndpointName"> Name of Cloud Endpoint object. </param>
        /// <param name="content"> Body of Cloud Endpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudEndpointName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<CloudEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string cloudEndpointName, CloudEndpointCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudEndpointName, nameof(cloudEndpointName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cloudEndpointClientDiagnostics.CreateScope("CloudEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cloudEndpointRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cloudEndpointName, content, cancellationToken).ConfigureAwait(false);
                var operation = new StorageSyncArmOperation<CloudEndpointResource>(new CloudEndpointOperationSource(Client), _cloudEndpointClientDiagnostics, Pipeline, _cloudEndpointRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cloudEndpointName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a new CloudEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints/{cloudEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cloudEndpointName"> Name of Cloud Endpoint object. </param>
        /// <param name="content"> Body of Cloud Endpoint resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudEndpointName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<CloudEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string cloudEndpointName, CloudEndpointCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudEndpointName, nameof(cloudEndpointName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _cloudEndpointClientDiagnostics.CreateScope("CloudEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cloudEndpointRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cloudEndpointName, content, cancellationToken);
                var operation = new StorageSyncArmOperation<CloudEndpointResource>(new CloudEndpointOperationSource(Client), _cloudEndpointClientDiagnostics, Pipeline, _cloudEndpointRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cloudEndpointName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a given CloudEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints/{cloudEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudEndpointName"> Name of Cloud Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudEndpointName"/> is null. </exception>
        public virtual async Task<Response<CloudEndpointResource>> GetAsync(string cloudEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudEndpointName, nameof(cloudEndpointName));

            using var scope = _cloudEndpointClientDiagnostics.CreateScope("CloudEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cloudEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a given CloudEndpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints/{cloudEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudEndpointName"> Name of Cloud Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudEndpointName"/> is null. </exception>
        public virtual Response<CloudEndpointResource> Get(string cloudEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudEndpointName, nameof(cloudEndpointName));

            using var scope = _cloudEndpointClientDiagnostics.CreateScope("CloudEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cloudEndpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a CloudEndpoint List.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_ListBySyncGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudEndpointRestClient.CreateListBySyncGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CloudEndpointResource(Client, CloudEndpointData.DeserializeCloudEndpointData(e)), _cloudEndpointClientDiagnostics, Pipeline, "CloudEndpointCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get a CloudEndpoint List.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_ListBySyncGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudEndpointRestClient.CreateListBySyncGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CloudEndpointResource(Client, CloudEndpointData.DeserializeCloudEndpointData(e)), _cloudEndpointClientDiagnostics, Pipeline, "CloudEndpointCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints/{cloudEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudEndpointName"> Name of Cloud Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudEndpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string cloudEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudEndpointName, nameof(cloudEndpointName));

            using var scope = _cloudEndpointClientDiagnostics.CreateScope("CloudEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cloudEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cloudEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints/{cloudEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudEndpointName"> Name of Cloud Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string cloudEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudEndpointName, nameof(cloudEndpointName));

            using var scope = _cloudEndpointClientDiagnostics.CreateScope("CloudEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _cloudEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cloudEndpointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints/{cloudEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudEndpointName"> Name of Cloud Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudEndpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<CloudEndpointResource>> GetIfExistsAsync(string cloudEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudEndpointName, nameof(cloudEndpointName));

            using var scope = _cloudEndpointClientDiagnostics.CreateScope("CloudEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cloudEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cloudEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CloudEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new CloudEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}/syncGroups/{syncGroupName}/cloudEndpoints/{cloudEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudEndpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudEndpointName"> Name of Cloud Endpoint object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cloudEndpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudEndpointName"/> is null. </exception>
        public virtual NullableResponse<CloudEndpointResource> GetIfExists(string cloudEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cloudEndpointName, nameof(cloudEndpointName));

            using var scope = _cloudEndpointClientDiagnostics.CreateScope("CloudEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cloudEndpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CloudEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new CloudEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudEndpointResource> IEnumerable<CloudEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudEndpointResource> IAsyncEnumerable<CloudEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
