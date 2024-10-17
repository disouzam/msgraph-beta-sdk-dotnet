// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Reports.UserInsights.Daily.ActiveUsers;
using Microsoft.Graph.Beta.Reports.UserInsights.Daily.Authentications;
using Microsoft.Graph.Beta.Reports.UserInsights.Daily.InactiveUsers;
using Microsoft.Graph.Beta.Reports.UserInsights.Daily.InactiveUsersByApplication;
using Microsoft.Graph.Beta.Reports.UserInsights.Daily.MfaCompletions;
using Microsoft.Graph.Beta.Reports.UserInsights.Daily.SignUps;
using Microsoft.Graph.Beta.Reports.UserInsights.Daily.Summary;
using Microsoft.Graph.Beta.Reports.UserInsights.Daily.UserCount;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Reports.UserInsights.Daily
{
    /// <summary>
    /// Provides operations to manage the daily property of the microsoft.graph.userInsightsRoot entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DailyRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the activeUsers property of the microsoft.graph.dailyUserInsightMetricsRoot entity.</summary>
        public global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.ActiveUsers.ActiveUsersRequestBuilder ActiveUsers
        {
            get => new global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.ActiveUsers.ActiveUsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authentications property of the microsoft.graph.dailyUserInsightMetricsRoot entity.</summary>
        public global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.Authentications.AuthenticationsRequestBuilder Authentications
        {
            get => new global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.Authentications.AuthenticationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the inactiveUsers property of the microsoft.graph.dailyUserInsightMetricsRoot entity.</summary>
        public global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.InactiveUsers.InactiveUsersRequestBuilder InactiveUsers
        {
            get => new global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.InactiveUsers.InactiveUsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the inactiveUsersByApplication property of the microsoft.graph.dailyUserInsightMetricsRoot entity.</summary>
        public global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.InactiveUsersByApplication.InactiveUsersByApplicationRequestBuilder InactiveUsersByApplication
        {
            get => new global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.InactiveUsersByApplication.InactiveUsersByApplicationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the mfaCompletions property of the microsoft.graph.dailyUserInsightMetricsRoot entity.</summary>
        public global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.MfaCompletions.MfaCompletionsRequestBuilder MfaCompletions
        {
            get => new global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.MfaCompletions.MfaCompletionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the signUps property of the microsoft.graph.dailyUserInsightMetricsRoot entity.</summary>
        public global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.SignUps.SignUpsRequestBuilder SignUps
        {
            get => new global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.SignUps.SignUpsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the summary property of the microsoft.graph.dailyUserInsightMetricsRoot entity.</summary>
        public global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.Summary.SummaryRequestBuilder Summary
        {
            get => new global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.Summary.SummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userCount property of the microsoft.graph.dailyUserInsightMetricsRoot entity.</summary>
        public global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.UserCount.UserCountRequestBuilder UserCount
        {
            get => new global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.UserCount.UserCountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.DailyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DailyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/userInsights/daily{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.DailyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DailyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/userInsights/daily{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property daily for reports
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
        /// Summaries of daily user activities on apps registered in your tenant that is configured for Microsoft Entra External ID for customers.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.DailyRequestBuilder.DailyRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.DailyRequestBuilder.DailyRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot>(requestInfo, global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property daily in reports
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot?> PatchAsync(global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot> PatchAsync(global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot>(requestInfo, global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property daily for reports
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
        /// Summaries of daily user activities on apps registered in your tenant that is configured for Microsoft Entra External ID for customers.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.DailyRequestBuilder.DailyRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.DailyRequestBuilder.DailyRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property daily in reports
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.DailyUserInsightMetricsRoot body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.DailyRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.DailyRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.DailyRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DailyRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Summaries of daily user activities on apps registered in your tenant that is configured for Microsoft Entra External ID for customers.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DailyRequestBuilderGetQueryParameters 
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
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DailyRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Reports.UserInsights.Daily.DailyRequestBuilder.DailyRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DailyRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
