// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.ClockOut;
using Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.Confirm;
using Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.EndBreak;
using Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.StartBreak;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item
{
    /// <summary>
    /// Provides operations to manage the timeCards property of the microsoft.graph.schedule entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class TimeCardItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the clockOut method.</summary>
        public global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.ClockOut.ClockOutRequestBuilder ClockOut
        {
            get => new global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.ClockOut.ClockOutRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the confirm method.</summary>
        public global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.Confirm.ConfirmRequestBuilder Confirm
        {
            get => new global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.Confirm.ConfirmRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the endBreak method.</summary>
        public global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.EndBreak.EndBreakRequestBuilder EndBreak
        {
            get => new global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.EndBreak.EndBreakRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the startBreak method.</summary>
        public global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.StartBreak.StartBreakRequestBuilder StartBreak
        {
            get => new global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.StartBreak.StartBreakRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.TimeCardItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeCardItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team%2Did}/schedule/timeCards/{timeCard%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.TimeCardItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeCardItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/teams/{team%2Did}/schedule/timeCards/{timeCard%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a timeCard instance in a schedule.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/timecard-delete?view=graph-rest-beta" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the properties and relationships of a timeCard object by ID.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/timecard-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TimeCard"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.TimeCard?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.TimeCardItemRequestBuilder.TimeCardItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.TimeCard> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.TimeCardItemRequestBuilder.TimeCardItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.TimeCard>(requestInfo, global::Microsoft.Graph.Beta.Models.TimeCard.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Replace an existing timeCard with updated values.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/timecard-replace?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TimeCard"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.TimeCard?> PatchAsync(global::Microsoft.Graph.Beta.Models.TimeCard body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.TimeCard> PatchAsync(global::Microsoft.Graph.Beta.Models.TimeCard body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.TimeCard>(requestInfo, global::Microsoft.Graph.Beta.Models.TimeCard.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a timeCard instance in a schedule.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Get the properties and relationships of a timeCard object by ID.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.TimeCardItemRequestBuilder.TimeCardItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.TimeCardItemRequestBuilder.TimeCardItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Replace an existing timeCard with updated values.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.TimeCard body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.TimeCard body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.TimeCardItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.TimeCardItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.TimeCardItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TimeCardItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get the properties and relationships of a timeCard object by ID.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TimeCardItemRequestBuilderGetQueryParameters 
        {
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TimeCardItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Teams.Item.Schedule.TimeCards.Item.TimeCardItemRequestBuilder.TimeCardItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TimeCardItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
