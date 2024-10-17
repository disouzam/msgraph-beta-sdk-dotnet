// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendanceReports;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.Presenters;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.Registrations;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithUserId;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item
{
    /// <summary>
    /// Provides operations to manage the sessions property of the microsoft.graph.virtualEvent entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class VirtualEventSessionItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the attendanceReports property of the microsoft.graph.onlineMeetingBase entity.</summary>
        public global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendanceReports.AttendanceReportsRequestBuilder AttendanceReports
        {
            get => new global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendanceReports.AttendanceReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the presenters property of the microsoft.graph.virtualEventSession entity.</summary>
        public global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.Presenters.PresentersRequestBuilder Presenters
        {
            get => new global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.Presenters.PresentersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the registrations property of the microsoft.graph.virtualEventSession entity.</summary>
        public global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.Registrations.RegistrationsRequestBuilder Registrations
        {
            get => new global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.Registrations.RegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.VirtualEventSessionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VirtualEventSessionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/solutions/virtualEvents/webinars/{virtualEventWebinar%2Did}/sessions/{virtualEventSession%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.VirtualEventSessionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VirtualEventSessionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/solutions/virtualEvents/webinars/{virtualEventWebinar%2Did}/sessions/{virtualEventSession%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property sessions for solutions
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
        /// Read the properties and relationships of a virtualEventSession object.  Currently, the following virtual event types are supported: virtualEventTownhall and virtualEventWebinar.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/virtualeventsession-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.VirtualEventSession"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.VirtualEventSession?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.VirtualEventSessionItemRequestBuilder.VirtualEventSessionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.VirtualEventSession> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.VirtualEventSessionItemRequestBuilder.VirtualEventSessionItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.VirtualEventSession>(requestInfo, global::Microsoft.Graph.Beta.Models.VirtualEventSession.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property sessions in solutions
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.VirtualEventSession"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.VirtualEventSession?> PatchAsync(global::Microsoft.Graph.Beta.Models.VirtualEventSession body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.VirtualEventSession> PatchAsync(global::Microsoft.Graph.Beta.Models.VirtualEventSession body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.VirtualEventSession>(requestInfo, global::Microsoft.Graph.Beta.Models.VirtualEventSession.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to manage the registrations property of the microsoft.graph.virtualEventSession entity.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder"/></returns>
        /// <param name="email">Alternate key of virtualEventRegistration</param>
        public global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder RegistrationsWithEmail(string email)
        {
            if(string.IsNullOrEmpty(email)) throw new ArgumentNullException(nameof(email));
            return new global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder(PathParameters, RequestAdapter, email);
        }
        /// <summary>
        /// Provides operations to manage the registrations property of the microsoft.graph.virtualEventSession entity.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithUserId.RegistrationsWithUserIdRequestBuilder"/></returns>
        /// <param name="userId">Alternate key of virtualEventRegistration</param>
        public global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithUserId.RegistrationsWithUserIdRequestBuilder RegistrationsWithUserId(string userId)
        {
            if(string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));
            return new global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithUserId.RegistrationsWithUserIdRequestBuilder(PathParameters, RequestAdapter, userId);
        }
        /// <summary>
        /// Delete navigation property sessions for solutions
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
        /// Read the properties and relationships of a virtualEventSession object.  Currently, the following virtual event types are supported: virtualEventTownhall and virtualEventWebinar.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.VirtualEventSessionItemRequestBuilder.VirtualEventSessionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.VirtualEventSessionItemRequestBuilder.VirtualEventSessionItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property sessions in solutions
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.VirtualEventSession body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.VirtualEventSession body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.VirtualEventSessionItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.VirtualEventSessionItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.VirtualEventSessionItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class VirtualEventSessionItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Read the properties and relationships of a virtualEventSession object.  Currently, the following virtual event types are supported: virtualEventTownhall and virtualEventWebinar.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class VirtualEventSessionItemRequestBuilderGetQueryParameters 
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
        public partial class VirtualEventSessionItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.VirtualEventSessionItemRequestBuilder.VirtualEventSessionItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class VirtualEventSessionItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
