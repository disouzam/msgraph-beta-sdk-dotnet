// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtension;
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
namespace Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item
{
    /// <summary>
    /// Provides operations to manage the customExtensionStageSettings property of the microsoft.graph.accessPackageAssignmentPolicy entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class CustomExtensionStageSettingItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the customExtension property of the microsoft.graph.customExtensionStageSetting entity.</summary>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
        public global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtension.CustomExtensionRequestBuilder CustomExtension
        {
            get => new global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtension.CustomExtensionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtensionStageSettingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomExtensionStageSettingItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackageAssignmentPolicy/customExtensionStageSettings/{customExtensionStageSetting%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtensionStageSettingItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomExtensionStageSettingItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment%2Did}/accessPackageAssignmentPolicy/customExtensionStageSettings/{customExtensionStageSetting%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property customExtensionStageSettings for identityGovernance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
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
        /// The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtensionStageSettingItemRequestBuilder.CustomExtensionStageSettingItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtensionStageSettingItemRequestBuilder.CustomExtensionStageSettingItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting>(requestInfo, global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property customExtensionStageSettings in identityGovernance
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting?> PatchAsync(global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting> PatchAsync(global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting>(requestInfo, global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property customExtensionStageSettings for identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
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
        /// The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtensionStageSettingItemRequestBuilder.CustomExtensionStageSettingItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtensionStageSettingItemRequestBuilder.CustomExtensionStageSettingItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property customExtensionStageSettings in identityGovernance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.CustomExtensionStageSetting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtensionStageSettingItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
        public global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtensionStageSettingItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtensionStageSettingItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class CustomExtensionStageSettingItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class CustomExtensionStageSettingItemRequestBuilderGetQueryParameters 
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
        public partial class CustomExtensionStageSettingItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageAssignments.Item.AccessPackageAssignmentPolicy.CustomExtensionStageSettings.Item.CustomExtensionStageSettingItemRequestBuilder.CustomExtensionStageSettingItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class CustomExtensionStageSettingItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
