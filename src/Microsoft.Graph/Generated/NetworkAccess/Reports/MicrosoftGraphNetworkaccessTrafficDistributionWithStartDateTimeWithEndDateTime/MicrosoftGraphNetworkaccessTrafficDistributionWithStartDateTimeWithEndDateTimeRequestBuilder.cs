// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.NetworkAccess.Reports.MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTime {
    /// <summary>
    /// Provides operations to call the trafficDistribution method.
    /// </summary>
    public class MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        public MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, DateTimeOffset? endDateTime = default, DateTimeOffset? startDateTime = default) : base(requestAdapter, "{+baseurl}/networkAccess/reports/microsoft.graph.networkaccess.trafficDistribution(startDateTime={startDateTime},endDateTime={endDateTime}){?%24top,%24skip,%24search,%24filter,%24count}", pathParameters) {
            if (endDateTime is not null) PathParameters.Add("endDateTime", endDateTime);
            if (startDateTime is not null) PathParameters.Add("startDateTime", startDateTime);
        }
        /// <summary>
        /// Instantiates a new MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/networkAccess/reports/microsoft.graph.networkaccess.trafficDistribution(startDateTime={startDateTime},endDateTime={endDateTime}){?%24top,%24skip,%24search,%24filter,%24count}", rawUrl) {
        }
        /// <summary>
        /// Invoke function trafficDistribution
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<TrafficDistributionWithStartDateTimeWithEndDateTimeGetResponse?> GetAsTrafficDistributionWithStartDateTimeWithEndDateTimeGetResponseAsync(Action<MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<TrafficDistributionWithStartDateTimeWithEndDateTimeGetResponse> GetAsTrafficDistributionWithStartDateTimeWithEndDateTimeGetResponseAsync(Action<MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<TrafficDistributionWithStartDateTimeWithEndDateTimeGetResponse>(requestInfo, TrafficDistributionWithStartDateTimeWithEndDateTimeGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function trafficDistribution
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsTrafficDistributionWithStartDateTimeWithEndDateTimeGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<TrafficDistributionWithStartDateTimeWithEndDateTimeResponse?> GetAsync(Action<MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<TrafficDistributionWithStartDateTimeWithEndDateTimeResponse> GetAsync(Action<MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<TrafficDistributionWithStartDateTimeWithEndDateTimeResponse>(requestInfo, TrafficDistributionWithStartDateTimeWithEndDateTimeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function trafficDistribution
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilder WithUrl(string rawUrl) {
            return new MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Invoke function trafficDistribution
        /// </summary>
        public class MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters {
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
        public class MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters QueryParameters { get; set; } = new MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new microsoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphNetworkaccessTrafficDistributionWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
