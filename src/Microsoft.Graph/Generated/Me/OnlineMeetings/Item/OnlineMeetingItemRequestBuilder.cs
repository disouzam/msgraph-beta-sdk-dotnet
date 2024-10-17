// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AiInsights;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AlternativeRecording;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AttendanceReports;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AttendeeReport;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.BroadcastRecording;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.GetVirtualAppointmentJoinWebUrl;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.MeetingAttendanceReport;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Recording;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Recordings;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Registration;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.SendVirtualAppointmentReminderSms;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.SendVirtualAppointmentSms;
using Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Transcripts;
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
namespace Microsoft.Graph.Beta.Me.OnlineMeetings.Item
{
    /// <summary>
    /// Provides operations to manage the onlineMeetings property of the microsoft.graph.user entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OnlineMeetingItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the aiInsights property of the microsoft.graph.onlineMeeting entity.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AiInsights.AiInsightsRequestBuilder AiInsights
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AiInsights.AiInsightsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the user entity.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AlternativeRecording.AlternativeRecordingRequestBuilder AlternativeRecording
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AlternativeRecording.AlternativeRecordingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the attendanceReports property of the microsoft.graph.onlineMeetingBase entity.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AttendanceReports.AttendanceReportsRequestBuilder AttendanceReports
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AttendanceReports.AttendanceReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the user entity.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AttendeeReport.AttendeeReportRequestBuilder AttendeeReport
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.AttendeeReport.AttendeeReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the user entity.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.BroadcastRecording.BroadcastRecordingRequestBuilder BroadcastRecording
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.BroadcastRecording.BroadcastRecordingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getVirtualAppointmentJoinWebUrl method.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlRequestBuilder GetVirtualAppointmentJoinWebUrl
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.GetVirtualAppointmentJoinWebUrl.GetVirtualAppointmentJoinWebUrlRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the meetingAttendanceReport property of the microsoft.graph.onlineMeeting entity.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.MeetingAttendanceReport.MeetingAttendanceReportRequestBuilder MeetingAttendanceReport
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.MeetingAttendanceReport.MeetingAttendanceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the user entity.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Recording.RecordingRequestBuilder Recording
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Recording.RecordingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the recordings property of the microsoft.graph.onlineMeeting entity.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Recordings.RecordingsRequestBuilder Recordings
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Recordings.RecordingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the registration property of the microsoft.graph.onlineMeeting entity.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Registration.RegistrationRequestBuilder Registration
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Registration.RegistrationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendVirtualAppointmentReminderSms method.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.SendVirtualAppointmentReminderSms.SendVirtualAppointmentReminderSmsRequestBuilder SendVirtualAppointmentReminderSms
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.SendVirtualAppointmentReminderSms.SendVirtualAppointmentReminderSmsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendVirtualAppointmentSms method.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.SendVirtualAppointmentSms.SendVirtualAppointmentSmsRequestBuilder SendVirtualAppointmentSms
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.SendVirtualAppointmentSms.SendVirtualAppointmentSmsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transcripts property of the microsoft.graph.onlineMeeting entity.</summary>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Transcripts.TranscriptsRequestBuilder Transcripts
        {
            get => new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.Transcripts.TranscriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnlineMeetingItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/onlineMeetings/{onlineMeeting%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnlineMeetingItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/onlineMeetings/{onlineMeeting%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete an onlineMeeting object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/onlinemeeting-delete?view=graph-rest-beta" />
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
        /// Information about a meeting, including the URL used to join a meeting, the attendees list, and the description.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OnlineMeeting"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.OnlineMeeting?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder.OnlineMeetingItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.OnlineMeeting> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder.OnlineMeetingItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.OnlineMeeting>(requestInfo, global::Microsoft.Graph.Beta.Models.OnlineMeeting.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of the specified onlineMeeting object. For the list of properties that support updating, see the Request body section.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/onlinemeeting-update?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OnlineMeeting"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.OnlineMeeting?> PatchAsync(global::Microsoft.Graph.Beta.Models.OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.OnlineMeeting> PatchAsync(global::Microsoft.Graph.Beta.Models.OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.OnlineMeeting>(requestInfo, global::Microsoft.Graph.Beta.Models.OnlineMeeting.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete an onlineMeeting object.
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
        /// Information about a meeting, including the URL used to join a meeting, the attendees list, and the description.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder.OnlineMeetingItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder.OnlineMeetingItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of the specified onlineMeeting object. For the list of properties that support updating, see the Request body section.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OnlineMeetingItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Information about a meeting, including the URL used to join a meeting, the attendees list, and the description.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OnlineMeetingItemRequestBuilderGetQueryParameters 
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
        public partial class OnlineMeetingItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Me.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder.OnlineMeetingItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OnlineMeetingItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
