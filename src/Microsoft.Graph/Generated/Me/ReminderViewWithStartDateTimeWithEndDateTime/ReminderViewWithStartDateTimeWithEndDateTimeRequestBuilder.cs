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
namespace Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime
{
    /// <summary>
    /// Provides operations to call the reminderView method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="endDateTime">Usage: EndDateTime=&apos;{EndDateTime}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="startDateTime">Usage: StartDateTime=&apos;{StartDateTime}&apos;</param>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string endDateTime = "", string startDateTime = "") : base(requestAdapter, "{+baseurl}/me/reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}'){?%24count,%24filter,%24search,%24skip,%24top}", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(endDateTime)) PathParameters.Add("EndDateTime", endDateTime);
            if (!string.IsNullOrWhiteSpace(startDateTime)) PathParameters.Add("StartDateTime", startDateTime);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/reminderView(StartDateTime='{StartDateTime}',EndDateTime='{EndDateTime}'){?%24count,%24filter,%24search,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Return a list of event reminders in a user calendar within the specified start and end times.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/user-reminderview?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeGetResponse?> GetAsReminderViewWithStartDateTimeWithEndDateTimeGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeGetResponse> GetAsReminderViewWithStartDateTimeWithEndDateTimeGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeGetResponse>(requestInfo, global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Return a list of event reminders in a user calendar within the specified start and end times.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/user-reminderview?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsReminderViewWithStartDateTimeWithEndDateTimeGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeResponse>(requestInfo, global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Return a list of event reminders in a user calendar within the specified start and end times.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
        public global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Return a list of event reminders in a user calendar within the specified start and end times.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters 
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
        public partial class ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Me.ReminderViewWithStartDateTimeWithEndDateTime.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilder.ReminderViewWithStartDateTimeWithEndDateTimeRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
