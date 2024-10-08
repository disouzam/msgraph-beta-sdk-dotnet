// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.Networkaccess;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.Count;
using Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks
{
    /// <summary>
    /// Provides operations to manage the deviceLinks property of the microsoft.graph.networkaccess.branchSite entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DeviceLinksRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
        public global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceLinks property of the microsoft.graph.networkaccess.branchSite entity.</summary>
        /// <param name="position">The unique identifier of deviceLink</param>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.Item.DeviceLinkItemRequestBuilder"/></returns>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
        public global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.Item.DeviceLinkItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("deviceLink%2Did", position);
                return new global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.Item.DeviceLinkItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.DeviceLinksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceLinksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/networkAccess/connectivity/branches/{branchSite%2Did}/deviceLinks{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.DeviceLinksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceLinksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/networkAccess/connectivity/branches/{branchSite%2Did}/deviceLinks{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve a list of device links associated with a specific branch.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/networkaccess-branchsite-list-devicelinks?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLinkCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLinkCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.DeviceLinksRequestBuilder.DeviceLinksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLinkCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.DeviceLinksRequestBuilder.DeviceLinksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLinkCollectionResponse>(requestInfo, global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLinkCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a branch site with associated device links.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/networkaccess-branchsite-post-devicelinks?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink?> PostAsync(global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink> PostAsync(global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink>(requestInfo, global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a list of device links associated with a specific branch.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.DeviceLinksRequestBuilder.DeviceLinksRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.DeviceLinksRequestBuilder.DeviceLinksRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a branch site with associated device links.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Models.Networkaccess.DeviceLink body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.DeviceLinksRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("The Branches API is deprecated and will stop returning data on March 20, 2024. Please use the new Remote Network API. as of 2022-06/PrivatePreview:NetworkAccess")]
        public global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.DeviceLinksRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.DeviceLinksRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve a list of device links associated with a specific branch.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DeviceLinksRequestBuilderGetQueryParameters 
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
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DeviceLinksRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.NetworkAccess.Connectivity.Branches.Item.DeviceLinks.DeviceLinksRequestBuilder.DeviceLinksRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DeviceLinksRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
