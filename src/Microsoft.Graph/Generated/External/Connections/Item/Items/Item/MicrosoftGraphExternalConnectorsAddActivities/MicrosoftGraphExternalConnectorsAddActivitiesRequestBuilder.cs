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
namespace Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities
{
    /// <summary>
    /// Provides operations to call the addActivities method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class MicrosoftGraphExternalConnectorsAddActivitiesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.MicrosoftGraphExternalConnectorsAddActivitiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphExternalConnectorsAddActivitiesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/external/connections/{externalConnection%2Did}/items/{externalItem%2Did}/microsoft.graph.externalConnectors.addActivities", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.MicrosoftGraphExternalConnectorsAddActivitiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphExternalConnectorsAddActivitiesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/external/connections/{externalConnection%2Did}/items/{externalItem%2Did}/microsoft.graph.externalConnectors.addActivities", rawUrl)
        {
        }
        /// <summary>
        /// Invoke action addActivities
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostResponse?> PostAsAddActivitiesPostResponseAsync(global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostResponse> PostAsAddActivitiesPostResponseAsync(global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostResponse>(requestInfo, global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke action addActivities
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsAddActivitiesPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesResponse?> PostAsync(global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesResponse> PostAsync(global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesResponse>(requestInfo, global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke action addActivities
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.AddActivitiesPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.MicrosoftGraphExternalConnectorsAddActivitiesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.MicrosoftGraphExternalConnectorsAddActivitiesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.External.Connections.Item.Items.Item.MicrosoftGraphExternalConnectorsAddActivities.MicrosoftGraphExternalConnectorsAddActivitiesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class MicrosoftGraphExternalConnectorsAddActivitiesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
