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
namespace Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime
{
    /// <summary>
    /// Provides operations to call the getDirectRoutingCalls method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="fromDateTime">Usage: fromDateTime={fromDateTime}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="toDateTime">Usage: toDateTime={toDateTime}</param>
        public MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, DateTimeOffset? fromDateTime = default, DateTimeOffset? toDateTime = default) : base(requestAdapter, "{+baseurl}/communications/callRecords/microsoft.graph.callRecords.getDirectRoutingCalls(fromDateTime={fromDateTime},toDateTime={toDateTime}){?%24count,%24filter,%24search,%24skip,%24top}", pathParameters)
        {
            if (fromDateTime != null) PathParameters.Add("fromDateTime", fromDateTime);
            if (toDateTime != null) PathParameters.Add("toDateTime", toDateTime);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/communications/callRecords/microsoft.graph.callRecords.getDirectRoutingCalls(fromDateTime={fromDateTime},toDateTime={toDateTime}){?%24count,%24filter,%24search,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get a log of direct routing calls as a collection of directRoutingLogRow entries.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.GetDirectRoutingCallsWithFromDateTimeWithToDateTimeGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.GetDirectRoutingCallsWithFromDateTimeWithToDateTimeGetResponse?> GetAsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.GetDirectRoutingCallsWithFromDateTimeWithToDateTimeGetResponse> GetAsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.GetDirectRoutingCallsWithFromDateTimeWithToDateTimeGetResponse>(requestInfo, global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.GetDirectRoutingCallsWithFromDateTimeWithToDateTimeGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a log of direct routing calls as a collection of directRoutingLogRow entries.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.GetDirectRoutingCallsWithFromDateTimeWithToDateTimeResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.GetDirectRoutingCallsWithFromDateTimeWithToDateTimeResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.GetDirectRoutingCallsWithFromDateTimeWithToDateTimeResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.GetDirectRoutingCallsWithFromDateTimeWithToDateTimeResponse>(requestInfo, global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.GetDirectRoutingCallsWithFromDateTimeWithToDateTimeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a log of direct routing calls as a collection of directRoutingLogRow entries.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a log of direct routing calls as a collection of directRoutingLogRow entries.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetQueryParameters 
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
        public partial class MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTime.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilder.MicrosoftGraphCallRecordsGetDirectRoutingCallsWithFromDateTimeWithToDateTimeRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
