// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceEnvironment;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceScopes;
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.Refresh;
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
namespace Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource
{
    /// <summary>
    /// Provides operations to manage the accessPackageResource property of the microsoft.graph.accessPackageResourceRole entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class AccessPackageResourceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the accessPackageResourceEnvironment property of the microsoft.graph.accessPackageResource entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceEnvironment.AccessPackageResourceEnvironmentRequestBuilder AccessPackageResourceEnvironment
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceEnvironment.AccessPackageResourceEnvironmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the accessPackageResourceScopes property of the microsoft.graph.accessPackageResource entity.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceScopes.AccessPackageResourceScopesRequestBuilder AccessPackageResourceScopes
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceScopes.AccessPackageResourceScopesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the refresh method.</summary>
        public global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.Refresh.RefreshRequestBuilder Refresh
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.Refresh.RefreshRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessPackageResourceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackage/accessPackageResourceRoleScopes/{accessPackageResourceRoleScope%2Did}/accessPackageResourceScope/accessPackageResource/accessPackageResourceRoles/{accessPackageResourceRole%2Did}/accessPackageResource{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessPackageResourceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackage/accessPackageResourceRoleScopes/{accessPackageResourceRoleScope%2Did}/accessPackageResourceScope/accessPackageResource/accessPackageResourceRoles/{accessPackageResourceRole%2Did}/accessPackageResource{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property accessPackageResource for identityGovernance
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
        /// Get accessPackageResource from identityGovernance
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessPackageResource"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.AccessPackageResource?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceRequestBuilder.AccessPackageResourceRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.AccessPackageResource> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceRequestBuilder.AccessPackageResourceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.AccessPackageResource>(requestInfo, global::Microsoft.Graph.Beta.Models.AccessPackageResource.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property accessPackageResource in identityGovernance
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessPackageResource"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.AccessPackageResource?> PatchAsync(global::Microsoft.Graph.Beta.Models.AccessPackageResource body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.AccessPackageResource> PatchAsync(global::Microsoft.Graph.Beta.Models.AccessPackageResource body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.AccessPackageResource>(requestInfo, global::Microsoft.Graph.Beta.Models.AccessPackageResource.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property accessPackageResource for identityGovernance
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
        /// Get accessPackageResource from identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceRequestBuilder.AccessPackageResourceRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceRequestBuilder.AccessPackageResourceRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property accessPackageResource in identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.AccessPackageResource body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.AccessPackageResource body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class AccessPackageResourceRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get accessPackageResource from identityGovernance
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class AccessPackageResourceRequestBuilderGetQueryParameters 
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
        public partial class AccessPackageResourceRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackage.AccessPackageResourceRoleScopes.Item.AccessPackageResourceScope.AccessPackageResource.AccessPackageResourceRoles.Item.AccessPackageResource.AccessPackageResourceRequestBuilder.AccessPackageResourceRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class AccessPackageResourceRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
