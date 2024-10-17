// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Users.Item.Outlook.MasterCategories;
using Microsoft.Graph.Beta.Users.Item.Outlook.SupportedLanguages;
using Microsoft.Graph.Beta.Users.Item.Outlook.SupportedTimeZones;
using Microsoft.Graph.Beta.Users.Item.Outlook.SupportedTimeZonesWithTimeZoneStandard;
using Microsoft.Graph.Beta.Users.Item.Outlook.TaskFolders;
using Microsoft.Graph.Beta.Users.Item.Outlook.TaskGroups;
using Microsoft.Graph.Beta.Users.Item.Outlook.Tasks;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Users.Item.Outlook
{
    /// <summary>
    /// Provides operations to manage the outlook property of the microsoft.graph.user entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OutlookRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the masterCategories property of the microsoft.graph.outlookUser entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Outlook.MasterCategories.MasterCategoriesRequestBuilder MasterCategories
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Outlook.MasterCategories.MasterCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the supportedLanguages method.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Outlook.SupportedLanguages.SupportedLanguagesRequestBuilder SupportedLanguages
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Outlook.SupportedLanguages.SupportedLanguagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the supportedTimeZones method.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Outlook.SupportedTimeZones.SupportedTimeZonesRequestBuilder SupportedTimeZones
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Outlook.SupportedTimeZones.SupportedTimeZonesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the taskFolders property of the microsoft.graph.outlookUser entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Outlook.TaskFolders.TaskFoldersRequestBuilder TaskFolders
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Outlook.TaskFolders.TaskFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the taskGroups property of the microsoft.graph.outlookUser entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Outlook.TaskGroups.TaskGroupsRequestBuilder TaskGroups
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Outlook.TaskGroups.TaskGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tasks property of the microsoft.graph.outlookUser entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.Outlook.Tasks.TasksRequestBuilder Tasks
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.Outlook.Tasks.TasksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.Outlook.OutlookRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OutlookRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/outlook{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.Outlook.OutlookRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OutlookRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/outlook{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Selective Outlook services available to the user. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OutlookUser"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.OutlookUser?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Outlook.OutlookRequestBuilder.OutlookRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.OutlookUser> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Outlook.OutlookRequestBuilder.OutlookRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.OutlookUser>(requestInfo, global::Microsoft.Graph.Beta.Models.OutlookUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the supportedTimeZones method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Users.Item.Outlook.SupportedTimeZonesWithTimeZoneStandard.SupportedTimeZonesWithTimeZoneStandardRequestBuilder"/></returns>
        /// <param name="timeZoneStandard">Usage: TimeZoneStandard=&apos;{TimeZoneStandard}&apos;</param>
        public global::Microsoft.Graph.Beta.Users.Item.Outlook.SupportedTimeZonesWithTimeZoneStandard.SupportedTimeZonesWithTimeZoneStandardRequestBuilder SupportedTimeZonesWithTimeZoneStandard(string timeZoneStandard)
        {
            if(string.IsNullOrEmpty(timeZoneStandard)) throw new ArgumentNullException(nameof(timeZoneStandard));
            return new global::Microsoft.Graph.Beta.Users.Item.Outlook.SupportedTimeZonesWithTimeZoneStandard.SupportedTimeZonesWithTimeZoneStandardRequestBuilder(PathParameters, RequestAdapter, timeZoneStandard);
        }
        /// <summary>
        /// Selective Outlook services available to the user. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Outlook.OutlookRequestBuilder.OutlookRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Outlook.OutlookRequestBuilder.OutlookRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Users.Item.Outlook.OutlookRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Users.Item.Outlook.OutlookRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Users.Item.Outlook.OutlookRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Selective Outlook services available to the user. Read-only. Nullable.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OutlookRequestBuilderGetQueryParameters 
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
        public partial class OutlookRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.Outlook.OutlookRequestBuilder.OutlookRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
