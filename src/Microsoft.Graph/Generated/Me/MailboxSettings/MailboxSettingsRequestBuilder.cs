// <auto-generated/>
#pragma warning disable CS0618
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
namespace Microsoft.Graph.Beta.Me.MailboxSettings
{
    /// <summary>
    /// Builds and executes requests for operations under \me\mailboxSettings
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class MailboxSettingsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Me.MailboxSettings.MailboxSettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MailboxSettingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/mailboxSettings{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Me.MailboxSettings.MailboxSettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MailboxSettingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/mailboxSettings{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get the user&apos;s mailboxSettings. You can view all mailbox settings, or get specific settings. Users can set the following settings for their mailboxes through an Outlook client: Users can set their preferred date and time formats using Outlook on the web. Users can choose one of the supported short date or short time formats. This GET operation returns the format the user has chosen. Users can set the time zone they prefer on any Outlook client, by choosing from the supported time zones that their administrator has set up for their mailbox server. The administrator can set up time zones in the Windows time zone format or  Internet Assigned Numbers Authority (IANA) time zone (also known as Olson time zone) format. The Windows format is the default. This GET operation returns the user&apos;s preferred time zone in the format that the administrator has set up. If you want that time zone to be in a specific format (Windows or IANA), you can first update the preferred time zone in that format as a mailbox setting. Subsequently you will be able to get the time zone in that format. Alternatively, you can manage the format conversion separately in your app.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/user-get-mailboxsettings?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MailboxSettings"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.MailboxSettings?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.MailboxSettings.MailboxSettingsRequestBuilder.MailboxSettingsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.MailboxSettings> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.MailboxSettings.MailboxSettingsRequestBuilder.MailboxSettingsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.MailboxSettings>(requestInfo, global::Microsoft.Graph.Beta.Models.MailboxSettings.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Enable, configure, or disable one or more of the following settings as part of a user&apos;s mailboxSettings: When updating the preferred date or time format for a user, specify it in respectively, the short date or short time format. When updating the preferred time zone for a user, specify it in the Windows or Internet Assigned Numbers Authority (IANA) time zone (also known as Olson time zone) format. You can also further customize the time zone as shown in example 2 below.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/user-update-mailboxsettings?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MailboxSettings"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.MailboxSettings?> PatchAsync(global::Microsoft.Graph.Beta.Models.MailboxSettings body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.MailboxSettings> PatchAsync(global::Microsoft.Graph.Beta.Models.MailboxSettings body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.MailboxSettings>(requestInfo, global::Microsoft.Graph.Beta.Models.MailboxSettings.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the user&apos;s mailboxSettings. You can view all mailbox settings, or get specific settings. Users can set the following settings for their mailboxes through an Outlook client: Users can set their preferred date and time formats using Outlook on the web. Users can choose one of the supported short date or short time formats. This GET operation returns the format the user has chosen. Users can set the time zone they prefer on any Outlook client, by choosing from the supported time zones that their administrator has set up for their mailbox server. The administrator can set up time zones in the Windows time zone format or  Internet Assigned Numbers Authority (IANA) time zone (also known as Olson time zone) format. The Windows format is the default. This GET operation returns the user&apos;s preferred time zone in the format that the administrator has set up. If you want that time zone to be in a specific format (Windows or IANA), you can first update the preferred time zone in that format as a mailbox setting. Subsequently you will be able to get the time zone in that format. Alternatively, you can manage the format conversion separately in your app.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.MailboxSettings.MailboxSettingsRequestBuilder.MailboxSettingsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.MailboxSettings.MailboxSettingsRequestBuilder.MailboxSettingsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Enable, configure, or disable one or more of the following settings as part of a user&apos;s mailboxSettings: When updating the preferred date or time format for a user, specify it in respectively, the short date or short time format. When updating the preferred time zone for a user, specify it in the Windows or Internet Assigned Numbers Authority (IANA) time zone (also known as Olson time zone) format. You can also further customize the time zone as shown in example 2 below.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.MailboxSettings body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.MailboxSettings body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Me.MailboxSettings.MailboxSettingsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
        public global::Microsoft.Graph.Beta.Me.MailboxSettings.MailboxSettingsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Me.MailboxSettings.MailboxSettingsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the user&apos;s mailboxSettings. You can view all mailbox settings, or get specific settings. Users can set the following settings for their mailboxes through an Outlook client: Users can set their preferred date and time formats using Outlook on the web. Users can choose one of the supported short date or short time formats. This GET operation returns the format the user has chosen. Users can set the time zone they prefer on any Outlook client, by choosing from the supported time zones that their administrator has set up for their mailbox server. The administrator can set up time zones in the Windows time zone format or  Internet Assigned Numbers Authority (IANA) time zone (also known as Olson time zone) format. The Windows format is the default. This GET operation returns the user&apos;s preferred time zone in the format that the administrator has set up. If you want that time zone to be in a specific format (Windows or IANA), you can first update the preferred time zone in that format as a mailbox setting. Subsequently you will be able to get the time zone in that format. Alternatively, you can manage the format conversion separately in your app.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class MailboxSettingsRequestBuilderGetQueryParameters 
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
        public partial class MailboxSettingsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Me.MailboxSettings.MailboxSettingsRequestBuilder.MailboxSettingsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class MailboxSettingsRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
