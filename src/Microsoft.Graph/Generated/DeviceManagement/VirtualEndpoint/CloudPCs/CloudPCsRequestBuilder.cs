// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.BulkResize;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Count;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.GetProvisionedCloudPCsWithGroupIdWithServicePlanId;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.ValidateBulkResize;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs
{
    /// <summary>
    /// Provides operations to manage the cloudPCs property of the microsoft.graph.virtualEndpoint entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CloudPCsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the bulkResize method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.BulkResize.BulkResizeRequestBuilder BulkResize
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.BulkResize.BulkResizeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the validateBulkResize method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.ValidateBulkResize.ValidateBulkResizeRequestBuilder ValidateBulkResize
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.ValidateBulkResize.ValidateBulkResizeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cloudPCs property of the microsoft.graph.virtualEndpoint entity.</summary>
        /// <param name="position">The unique identifier of cloudPC</param>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.CloudPCItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.CloudPCItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("cloudPC%2Did", position);
                return new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.CloudPCItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.CloudPCsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CloudPCsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/cloudPCs{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.CloudPCsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CloudPCsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/cloudPCs{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// List the cloudPC devices in a tenant.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/virtualendpoint-list-cloudpcs?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPCCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.CloudPCCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.CloudPCsRequestBuilder.CloudPCsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.CloudPCCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.CloudPCsRequestBuilder.CloudPCsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.CloudPCCollectionResponse>(requestInfo, global::Microsoft.Graph.Beta.Models.CloudPCCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the getProvisionedCloudPCs method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.GetProvisionedCloudPCsWithGroupIdWithServicePlanId.GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilder"/></returns>
        /// <param name="groupId">Usage: groupId=&apos;{groupId}&apos;</param>
        /// <param name="servicePlanId">Usage: servicePlanId=&apos;{servicePlanId}&apos;</param>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.GetProvisionedCloudPCsWithGroupIdWithServicePlanId.GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilder GetProvisionedCloudPCsWithGroupIdWithServicePlanId(string groupId, string servicePlanId)
        {
            if(string.IsNullOrEmpty(groupId)) throw new ArgumentNullException(nameof(groupId));
            if(string.IsNullOrEmpty(servicePlanId)) throw new ArgumentNullException(nameof(servicePlanId));
            return new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.GetProvisionedCloudPCsWithGroupIdWithServicePlanId.GetProvisionedCloudPCsWithGroupIdWithServicePlanIdRequestBuilder(PathParameters, RequestAdapter, groupId, servicePlanId);
        }
        /// <summary>
        /// Create new navigation property to cloudPCs for deviceManagement
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPC"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.CloudPC?> PostAsync(global::Microsoft.Graph.Beta.Models.CloudPC body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.CloudPC> PostAsync(global::Microsoft.Graph.Beta.Models.CloudPC body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.CloudPC>(requestInfo, global::Microsoft.Graph.Beta.Models.CloudPC.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List the cloudPC devices in a tenant.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.CloudPCsRequestBuilder.CloudPCsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.CloudPCsRequestBuilder.CloudPCsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to cloudPCs for deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Models.CloudPC body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Models.CloudPC body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.CloudPCsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.CloudPCsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.CloudPCsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List the cloudPC devices in a tenant.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CloudPCsRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CloudPCsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.CloudPCsRequestBuilder.CloudPCsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CloudPCsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
