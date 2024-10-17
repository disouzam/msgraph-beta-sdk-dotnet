// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ExportJobs;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetActionStatusReports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetCloudPcPerformanceReport;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetCloudPcRecommendationReports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetConnectionQualityReports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetDailyAggregatedRemoteConnectionReports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetFrontlineReport;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetInaccessibleCloudPcReports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRawRemoteConnectionReports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionLatencyWithCloudPcId;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionStatusWithCloudPcId;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRemoteConnectionHistoricalReports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetSharedUseLicenseUsageReport;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetTotalAggregatedRemoteConnectionReports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.RetrieveConnectionQualityReports;
using Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.RetrieveCrossRegionDisasterRecoveryReport;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports
{
    /// <summary>
    /// Provides operations to manage the reports property of the microsoft.graph.virtualEndpoint entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ReportsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the exportJobs property of the microsoft.graph.cloudPcReports entity.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ExportJobs.ExportJobsRequestBuilder ExportJobs
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ExportJobs.ExportJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getActionStatusReports method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetActionStatusReports.GetActionStatusReportsRequestBuilder GetActionStatusReports
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetActionStatusReports.GetActionStatusReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCloudPcPerformanceReport method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetCloudPcPerformanceReport.GetCloudPcPerformanceReportRequestBuilder GetCloudPcPerformanceReport
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetCloudPcPerformanceReport.GetCloudPcPerformanceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCloudPcRecommendationReports method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetCloudPcRecommendationReports.GetCloudPcRecommendationReportsRequestBuilder GetCloudPcRecommendationReports
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetCloudPcRecommendationReports.GetCloudPcRecommendationReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getConnectionQualityReports method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetConnectionQualityReports.GetConnectionQualityReportsRequestBuilder GetConnectionQualityReports
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetConnectionQualityReports.GetConnectionQualityReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDailyAggregatedRemoteConnectionReports method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetDailyAggregatedRemoteConnectionReports.GetDailyAggregatedRemoteConnectionReportsRequestBuilder GetDailyAggregatedRemoteConnectionReports
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetDailyAggregatedRemoteConnectionReports.GetDailyAggregatedRemoteConnectionReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getFrontlineReport method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetFrontlineReport.GetFrontlineReportRequestBuilder GetFrontlineReport
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetFrontlineReport.GetFrontlineReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getInaccessibleCloudPcReports method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetInaccessibleCloudPcReports.GetInaccessibleCloudPcReportsRequestBuilder GetInaccessibleCloudPcReports
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetInaccessibleCloudPcReports.GetInaccessibleCloudPcReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getRawRemoteConnectionReports method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRawRemoteConnectionReports.GetRawRemoteConnectionReportsRequestBuilder GetRawRemoteConnectionReports
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRawRemoteConnectionReports.GetRawRemoteConnectionReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getRemoteConnectionHistoricalReports method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRemoteConnectionHistoricalReports.GetRemoteConnectionHistoricalReportsRequestBuilder GetRemoteConnectionHistoricalReports
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRemoteConnectionHistoricalReports.GetRemoteConnectionHistoricalReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getSharedUseLicenseUsageReport method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetSharedUseLicenseUsageReport.GetSharedUseLicenseUsageReportRequestBuilder GetSharedUseLicenseUsageReport
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetSharedUseLicenseUsageReport.GetSharedUseLicenseUsageReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getTotalAggregatedRemoteConnectionReports method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetTotalAggregatedRemoteConnectionReports.GetTotalAggregatedRemoteConnectionReportsRequestBuilder GetTotalAggregatedRemoteConnectionReports
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetTotalAggregatedRemoteConnectionReports.GetTotalAggregatedRemoteConnectionReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retrieveConnectionQualityReports method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.RetrieveConnectionQualityReports.RetrieveConnectionQualityReportsRequestBuilder RetrieveConnectionQualityReports
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.RetrieveConnectionQualityReports.RetrieveConnectionQualityReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retrieveCrossRegionDisasterRecoveryReport method.</summary>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.RetrieveCrossRegionDisasterRecoveryReport.RetrieveCrossRegionDisasterRecoveryReportRequestBuilder RetrieveCrossRegionDisasterRecoveryReport
        {
            get => new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.RetrieveCrossRegionDisasterRecoveryReport.RetrieveCrossRegionDisasterRecoveryReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/reports{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/virtualEndpoint/reports{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
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
        /// Cloud PC related reports.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPcReports"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.CloudPcReports?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.CloudPcReports> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.CloudPcReports>(requestInfo, global::Microsoft.Graph.Beta.Models.CloudPcReports.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the getRealTimeRemoteConnectionLatency method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionLatencyWithCloudPcId.GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilder"/></returns>
        /// <param name="cloudPcId">Usage: cloudPcId=&apos;{cloudPcId}&apos;</param>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionLatencyWithCloudPcId.GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilder GetRealTimeRemoteConnectionLatencyWithCloudPcId(string cloudPcId)
        {
            if(string.IsNullOrEmpty(cloudPcId)) throw new ArgumentNullException(nameof(cloudPcId));
            return new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionLatencyWithCloudPcId.GetRealTimeRemoteConnectionLatencyWithCloudPcIdRequestBuilder(PathParameters, RequestAdapter, cloudPcId);
        }
        /// <summary>
        /// Provides operations to call the getRealTimeRemoteConnectionStatus method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionStatusWithCloudPcId.GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder"/></returns>
        /// <param name="cloudPcId">Usage: cloudPcId=&apos;{cloudPcId}&apos;</param>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionStatusWithCloudPcId.GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder GetRealTimeRemoteConnectionStatusWithCloudPcId(string cloudPcId)
        {
            if(string.IsNullOrEmpty(cloudPcId)) throw new ArgumentNullException(nameof(cloudPcId));
            return new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.GetRealTimeRemoteConnectionStatusWithCloudPcId.GetRealTimeRemoteConnectionStatusWithCloudPcIdRequestBuilder(PathParameters, RequestAdapter, cloudPcId);
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPcReports"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.CloudPcReports?> PatchAsync(global::Microsoft.Graph.Beta.Models.CloudPcReports body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.CloudPcReports> PatchAsync(global::Microsoft.Graph.Beta.Models.CloudPcReports body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.CloudPcReports>(requestInfo, global::Microsoft.Graph.Beta.Models.CloudPcReports.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property reports for deviceManagement
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
        /// Cloud PC related reports.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property reports in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.CloudPcReports body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.CloudPcReports body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ReportsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ReportsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ReportsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReportsRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Cloud PC related reports.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReportsRequestBuilderGetQueryParameters 
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
        public partial class ReportsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReportsRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
