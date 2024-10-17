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
namespace Microsoft.Graph.Beta.Groups.Item.Events.Item.Instances.Item.TentativelyAccept
{
    /// <summary>
    /// Provides operations to call the tentativelyAccept method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TentativelyAcceptRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Groups.Item.Events.Item.Instances.Item.TentativelyAccept.TentativelyAcceptRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TentativelyAcceptRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/events/{event%2Did}/instances/{event%2Did1}/tentativelyAccept", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Groups.Item.Events.Item.Instances.Item.TentativelyAccept.TentativelyAcceptRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TentativelyAcceptRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/events/{event%2Did}/instances/{event%2Did1}/tentativelyAccept", rawUrl)
        {
        }
        /// <summary>
        /// Tentatively accept the specified event in a user calendar. If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the proposedNewTime parameter. For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/event-tentativelyaccept?view=graph-rest-beta" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::Microsoft.Graph.Beta.Groups.Item.Events.Item.Instances.Item.TentativelyAccept.TentativelyAcceptPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::Microsoft.Graph.Beta.Groups.Item.Events.Item.Instances.Item.TentativelyAccept.TentativelyAcceptPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Tentatively accept the specified event in a user calendar. If the event allows proposals for new times, on responding tentative to the event, an invitee can choose to suggest an alternative time by including the proposedNewTime parameter. For more information on how to propose a time, and how to receive and accept a new time proposal, see Propose new meeting times.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Groups.Item.Events.Item.Instances.Item.TentativelyAccept.TentativelyAcceptPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Microsoft.Graph.Beta.Groups.Item.Events.Item.Instances.Item.TentativelyAccept.TentativelyAcceptPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Groups.Item.Events.Item.Instances.Item.TentativelyAccept.TentativelyAcceptRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Groups.Item.Events.Item.Instances.Item.TentativelyAccept.TentativelyAcceptRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Groups.Item.Events.Item.Instances.Item.TentativelyAccept.TentativelyAcceptRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class TentativelyAcceptRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
