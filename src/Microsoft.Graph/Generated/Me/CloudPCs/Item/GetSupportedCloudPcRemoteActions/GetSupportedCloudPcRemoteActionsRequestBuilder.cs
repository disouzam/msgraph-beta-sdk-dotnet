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
namespace Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions
{
    /// <summary>
    /// Provides operations to call the getSupportedCloudPcRemoteActions method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class GetSupportedCloudPcRemoteActionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetSupportedCloudPcRemoteActionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/cloudPCs/{cloudPC%2Did}/getSupportedCloudPcRemoteActions(){?%24count,%24filter,%24search,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetSupportedCloudPcRemoteActionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/cloudPCs/{cloudPC%2Did}/getSupportedCloudPcRemoteActions(){?%24count,%24filter,%24search,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get a list of supported Cloud PC remote actions for a specific Cloud PC device, including the action names and capabilities.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/cloudpc-getsupportedcloudpcremoteactions?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsGetResponse?> GetAsGetSupportedCloudPcRemoteActionsGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder.GetSupportedCloudPcRemoteActionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsGetResponse> GetAsGetSupportedCloudPcRemoteActionsGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder.GetSupportedCloudPcRemoteActionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsGetResponse>(requestInfo, global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a list of supported Cloud PC remote actions for a specific Cloud PC device, including the action names and capabilities.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/cloudpc-getsupportedcloudpcremoteactions?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetSupportedCloudPcRemoteActionsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder.GetSupportedCloudPcRemoteActionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder.GetSupportedCloudPcRemoteActionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsResponse>(requestInfo, global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a list of supported Cloud PC remote actions for a specific Cloud PC device, including the action names and capabilities.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder.GetSupportedCloudPcRemoteActionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder.GetSupportedCloudPcRemoteActionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
        public global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a list of supported Cloud PC remote actions for a specific Cloud PC device, including the action names and capabilities.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class GetSupportedCloudPcRemoteActionsRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
        public partial class GetSupportedCloudPcRemoteActionsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Me.CloudPCs.Item.GetSupportedCloudPcRemoteActions.GetSupportedCloudPcRemoteActionsRequestBuilder.GetSupportedCloudPcRemoteActionsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
