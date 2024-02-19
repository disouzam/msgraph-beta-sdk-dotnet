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
namespace Microsoft.Graph.Beta.DeviceManagement.AssignmentFilters.GetPlatformSupportedPropertiesWithPlatform {
    /// <summary>
    /// Provides operations to call the getPlatformSupportedProperties method.
    /// </summary>
    public class GetPlatformSupportedPropertiesWithPlatformRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="GetPlatformSupportedPropertiesWithPlatformRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="platform">Usage: platform=&apos;{platform}&apos;</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetPlatformSupportedPropertiesWithPlatformRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string platform = "") : base(requestAdapter, "{+baseurl}/deviceManagement/assignmentFilters/getPlatformSupportedProperties(platform='{platform}'){?%24count,%24filter,%24search,%24skip,%24top}", pathParameters) {
            if (!string.IsNullOrWhiteSpace(platform)) PathParameters.Add("platform", platform);
        }
        /// <summary>
        /// Instantiates a new <see cref="GetPlatformSupportedPropertiesWithPlatformRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetPlatformSupportedPropertiesWithPlatformRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/assignmentFilters/getPlatformSupportedProperties(platform='{platform}'){?%24count,%24filter,%24search,%24skip,%24top}", rawUrl) {
        }
        /// <summary>
        /// Invoke function getPlatformSupportedProperties
        /// </summary>
        /// <returns>A <see cref="GetPlatformSupportedPropertiesWithPlatformGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetPlatformSupportedPropertiesWithPlatformGetResponse?> GetAsGetPlatformSupportedPropertiesWithPlatformGetResponseAsync(Action<RequestConfiguration<GetPlatformSupportedPropertiesWithPlatformRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GetPlatformSupportedPropertiesWithPlatformGetResponse> GetAsGetPlatformSupportedPropertiesWithPlatformGetResponseAsync(Action<RequestConfiguration<GetPlatformSupportedPropertiesWithPlatformRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GetPlatformSupportedPropertiesWithPlatformGetResponse>(requestInfo, GetPlatformSupportedPropertiesWithPlatformGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function getPlatformSupportedProperties
        /// </summary>
        /// <returns>A <see cref="GetPlatformSupportedPropertiesWithPlatformResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetPlatformSupportedPropertiesWithPlatformGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetPlatformSupportedPropertiesWithPlatformResponse?> GetAsync(Action<RequestConfiguration<GetPlatformSupportedPropertiesWithPlatformRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GetPlatformSupportedPropertiesWithPlatformResponse> GetAsync(Action<RequestConfiguration<GetPlatformSupportedPropertiesWithPlatformRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GetPlatformSupportedPropertiesWithPlatformResponse>(requestInfo, GetPlatformSupportedPropertiesWithPlatformResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Invoke function getPlatformSupportedProperties
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GetPlatformSupportedPropertiesWithPlatformRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GetPlatformSupportedPropertiesWithPlatformRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="GetPlatformSupportedPropertiesWithPlatformRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GetPlatformSupportedPropertiesWithPlatformRequestBuilder WithUrl(string rawUrl) {
            return new GetPlatformSupportedPropertiesWithPlatformRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Invoke function getPlatformSupportedProperties
        /// </summary>
        public class GetPlatformSupportedPropertiesWithPlatformRequestBuilderGetQueryParameters {
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
        public class GetPlatformSupportedPropertiesWithPlatformRequestBuilderGetRequestConfiguration : RequestConfiguration<GetPlatformSupportedPropertiesWithPlatformRequestBuilderGetQueryParameters> {
        }
    }
}
