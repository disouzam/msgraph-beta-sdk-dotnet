// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds
{
    /// <summary>
    /// Provides operations to call the getRoleScopeTagsByIds method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class GetRoleScopeTagsByIdsWithIdsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="ids">Usage: ids={ids}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRoleScopeTagsByIdsWithIdsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string ids = "") : base(requestAdapter, "{+baseurl}/deviceManagement/getRoleScopeTagsByIds(ids={ids}){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(ids)) PathParameters.Add("ids", ids);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRoleScopeTagsByIdsWithIdsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/getRoleScopeTagsByIds(ids={ids}){?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function getRoleScopeTagsByIds
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsGetResponse?> GetAsGetRoleScopeTagsByIdsWithIdsGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder.GetRoleScopeTagsByIdsWithIdsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsGetResponse> GetAsGetRoleScopeTagsByIdsWithIdsGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder.GetRoleScopeTagsByIdsWithIdsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsGetResponse>(requestInfo, global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function getRoleScopeTagsByIds
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetRoleScopeTagsByIdsWithIdsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder.GetRoleScopeTagsByIdsWithIdsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder.GetRoleScopeTagsByIdsWithIdsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsResponse>(requestInfo, global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function getRoleScopeTagsByIds
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder.GetRoleScopeTagsByIdsWithIdsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder.GetRoleScopeTagsByIdsWithIdsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Invoke function getRoleScopeTagsByIds
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class GetRoleScopeTagsByIdsWithIdsRequestBuilderGetQueryParameters 
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
        public partial class GetRoleScopeTagsByIdsWithIdsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.GetRoleScopeTagsByIdsWithIds.GetRoleScopeTagsByIdsWithIdsRequestBuilder.GetRoleScopeTagsByIdsWithIdsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
