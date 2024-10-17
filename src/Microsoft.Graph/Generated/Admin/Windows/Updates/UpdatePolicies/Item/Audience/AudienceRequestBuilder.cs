// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.ApplicableContent;
using Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.Exclusions;
using Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.Members;
using Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudience;
using Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudienceById;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience
{
    /// <summary>
    /// Provides operations to manage the audience property of the microsoft.graph.windowsUpdates.updatePolicy entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AudienceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the applicableContent property of the microsoft.graph.windowsUpdates.deploymentAudience entity.</summary>
        public global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.ApplicableContent.ApplicableContentRequestBuilder ApplicableContent
        {
            get => new global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.ApplicableContent.ApplicableContentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the exclusions property of the microsoft.graph.windowsUpdates.deploymentAudience entity.</summary>
        public global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.Exclusions.ExclusionsRequestBuilder Exclusions
        {
            get => new global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.Exclusions.ExclusionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the members property of the microsoft.graph.windowsUpdates.deploymentAudience entity.</summary>
        public global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.Members.MembersRequestBuilder Members
        {
            get => new global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.Members.MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateAudience method.</summary>
        public global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudience.MicrosoftGraphWindowsUpdatesUpdateAudienceRequestBuilder MicrosoftGraphWindowsUpdatesUpdateAudience
        {
            get => new global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudience.MicrosoftGraphWindowsUpdatesUpdateAudienceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateAudienceById method.</summary>
        public global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudienceById.MicrosoftGraphWindowsUpdatesUpdateAudienceByIdRequestBuilder MicrosoftGraphWindowsUpdatesUpdateAudienceById
        {
            get => new global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudienceById.MicrosoftGraphWindowsUpdatesUpdateAudienceByIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.AudienceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AudienceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/windows/updates/updatePolicies/{updatePolicy%2Did}/audience{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.AudienceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AudienceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/windows/updates/updatePolicies/{updatePolicy%2Did}/audience{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property audience for admin
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
        /// Specifies the audience to target.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.AudienceRequestBuilder.AudienceRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.AudienceRequestBuilder.AudienceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience>(requestInfo, global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property audience in admin
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience?> PatchAsync(global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience> PatchAsync(global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience>(requestInfo, global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property audience for admin
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
        /// Specifies the audience to target.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.AudienceRequestBuilder.AudienceRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.AudienceRequestBuilder.AudienceRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property audience in admin
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.AudienceRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.AudienceRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.AudienceRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AudienceRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Specifies the audience to target.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AudienceRequestBuilderGetQueryParameters 
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
        public partial class AudienceRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatePolicies.Item.Audience.AudienceRequestBuilder.AudienceRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AudienceRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
