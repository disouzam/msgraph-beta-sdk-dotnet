// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.Applications;
using Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ApplicationsWithAppId;
using Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ApplicationsWithUniqueName;
using Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.Members;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item
{
    /// <summary>
    /// Provides operations to manage the connectorGroups property of the microsoft.graph.onPremisesPublishingProfile entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ConnectorGroupItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the applications property of the microsoft.graph.connectorGroup entity.</summary>
        public global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.Applications.ApplicationsRequestBuilder Applications
        {
            get => new global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.Applications.ApplicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the members property of the microsoft.graph.connectorGroup entity.</summary>
        public global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.Members.MembersRequestBuilder Members
        {
            get => new global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.Members.MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to manage the applications property of the microsoft.graph.connectorGroup entity.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ApplicationsWithAppId.ApplicationsWithAppIdRequestBuilder"/></returns>
        /// <param name="appId">Alternate key of application</param>
        public global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ApplicationsWithAppId.ApplicationsWithAppIdRequestBuilder ApplicationsWithAppId(string appId)
        {
            if(string.IsNullOrEmpty(appId)) throw new ArgumentNullException(nameof(appId));
            return new global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ApplicationsWithAppId.ApplicationsWithAppIdRequestBuilder(PathParameters, RequestAdapter, appId);
        }
        /// <summary>
        /// Provides operations to manage the applications property of the microsoft.graph.connectorGroup entity.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ApplicationsWithUniqueName.ApplicationsWithUniqueNameRequestBuilder"/></returns>
        /// <param name="uniqueName">Alternate key of application</param>
        public global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ApplicationsWithUniqueName.ApplicationsWithUniqueNameRequestBuilder ApplicationsWithUniqueName(string uniqueName)
        {
            if(string.IsNullOrEmpty(uniqueName)) throw new ArgumentNullException(nameof(uniqueName));
            return new global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ApplicationsWithUniqueName.ApplicationsWithUniqueNameRequestBuilder(PathParameters, RequestAdapter, uniqueName);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ConnectorGroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConnectorGroupItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/connectorGroups/{connectorGroup%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ConnectorGroupItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConnectorGroupItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/onPremisesPublishingProfiles/{onPremisesPublishingProfile%2Did}/connectorGroups/{connectorGroup%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property connectorGroups for onPremisesPublishingProfiles
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
        /// List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ConnectorGroup"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.ConnectorGroup?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ConnectorGroupItemRequestBuilder.ConnectorGroupItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.ConnectorGroup> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ConnectorGroupItemRequestBuilder.ConnectorGroupItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.ConnectorGroup>(requestInfo, global::Microsoft.Graph.Beta.Models.ConnectorGroup.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property connectorGroups in onPremisesPublishingProfiles
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ConnectorGroup"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.ConnectorGroup?> PatchAsync(global::Microsoft.Graph.Beta.Models.ConnectorGroup body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.ConnectorGroup> PatchAsync(global::Microsoft.Graph.Beta.Models.ConnectorGroup body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.ConnectorGroup>(requestInfo, global::Microsoft.Graph.Beta.Models.ConnectorGroup.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property connectorGroups for onPremisesPublishingProfiles
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
        /// List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ConnectorGroupItemRequestBuilder.ConnectorGroupItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ConnectorGroupItemRequestBuilder.ConnectorGroupItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property connectorGroups in onPremisesPublishingProfiles
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.ConnectorGroup body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.ConnectorGroup body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ConnectorGroupItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ConnectorGroupItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ConnectorGroupItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ConnectorGroupItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ConnectorGroupItemRequestBuilderGetQueryParameters 
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
        public partial class ConnectorGroupItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.OnPremisesPublishingProfiles.Item.ConnectorGroups.Item.ConnectorGroupItemRequestBuilder.ConnectorGroupItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ConnectorGroupItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
