// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogs.Item.CustomAccessPackageWorkflowExtensions.Item {
    /// <summary>
    /// Provides operations to manage the customAccessPackageWorkflowExtensions property of the microsoft.graph.accessPackageCatalog entity.
    /// </summary>
    public class CustomAccessPackageWorkflowExtensionItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="CustomAccessPackageWorkflowExtensionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomAccessPackageWorkflowExtensionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs/{accessPackageCatalog%2Did}/customAccessPackageWorkflowExtensions/{customAccessPackageWorkflowExtension%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CustomAccessPackageWorkflowExtensionItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomAccessPackageWorkflowExtensionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs/{accessPackageCatalog%2Did}/customAccessPackageWorkflowExtensions/{customAccessPackageWorkflowExtension%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete an accessPackageAssignmentRequestWorkflowExtension object. The custom workflow extension must first be removed from any associated policies before it can be deleted. Follow these steps to remove the custom workflow extension from any associated policies:1. First retrieve the accessPackageCatalogId by calling the Get accessPackageAssignmentPolicies operation and appending ?$expand=accessPackage($expand=accessPackageCatalog) to the query. For example, https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageAssignmentPolicies?$expand=accessPackage($expand=accessPackageCatalog).2. Use the access package catalog ID and retrieve the ID of the accessPackageCustomWorkflowExtension object that you want to delete by running the List accessPackageCustomWorkflowExtensions operation.3. Call the Update accessPackageAssignmentPolicy operation to remove the custom workflow extension object from the policy. For an example, see Example 3: Remove the customExtensionStageSettings from a policy.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackageassignmentrequestworkflowextension-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
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
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Read the properties and relationships of a customAccessPackageWorkflowExtension object for an accessPackageCatalog object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/customaccesspackageworkflowextension-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="CustomAccessPackageWorkflowExtension"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CustomAccessPackageWorkflowExtension?> GetAsync(Action<RequestConfiguration<CustomAccessPackageWorkflowExtensionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<CustomAccessPackageWorkflowExtension> GetAsync(Action<RequestConfiguration<CustomAccessPackageWorkflowExtensionItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CustomAccessPackageWorkflowExtension>(requestInfo, CustomAccessPackageWorkflowExtension.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of an existing customAccessPackageWorkflowExtension object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/customaccesspackageworkflowextension-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="CustomAccessPackageWorkflowExtension"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CustomAccessPackageWorkflowExtension?> PatchAsync(CustomAccessPackageWorkflowExtension body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<CustomAccessPackageWorkflowExtension> PatchAsync(CustomAccessPackageWorkflowExtension body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CustomAccessPackageWorkflowExtension>(requestInfo, CustomAccessPackageWorkflowExtension.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete an accessPackageAssignmentRequestWorkflowExtension object. The custom workflow extension must first be removed from any associated policies before it can be deleted. Follow these steps to remove the custom workflow extension from any associated policies:1. First retrieve the accessPackageCatalogId by calling the Get accessPackageAssignmentPolicies operation and appending ?$expand=accessPackage($expand=accessPackageCatalog) to the query. For example, https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageAssignmentPolicies?$expand=accessPackage($expand=accessPackageCatalog).2. Use the access package catalog ID and retrieve the ID of the accessPackageCustomWorkflowExtension object that you want to delete by running the List accessPackageCustomWorkflowExtensions operation.3. Call the Update accessPackageAssignmentPolicy operation to remove the custom workflow extension object from the policy. For an example, see Example 3: Remove the customExtensionStageSettings from a policy.
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
            var requestInfo = new RequestInformation(Method.DELETE, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs/{accessPackageCatalog%2Did}/customAccessPackageWorkflowExtensions/{customAccessPackageWorkflowExtension%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a customAccessPackageWorkflowExtension object for an accessPackageCatalog object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CustomAccessPackageWorkflowExtensionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CustomAccessPackageWorkflowExtensionItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of an existing customAccessPackageWorkflowExtension object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(CustomAccessPackageWorkflowExtension body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(CustomAccessPackageWorkflowExtension body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs/{accessPackageCatalog%2Did}/customAccessPackageWorkflowExtensions/{customAccessPackageWorkflowExtension%2Did}", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="CustomAccessPackageWorkflowExtensionItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
        public CustomAccessPackageWorkflowExtensionItemRequestBuilder WithUrl(string rawUrl)
        {
            return new CustomAccessPackageWorkflowExtensionItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CustomAccessPackageWorkflowExtensionItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Read the properties and relationships of a customAccessPackageWorkflowExtension object for an accessPackageCatalog object.
        /// </summary>
        public class CustomAccessPackageWorkflowExtensionItemRequestBuilderGetQueryParameters 
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
        public class CustomAccessPackageWorkflowExtensionItemRequestBuilderGetRequestConfiguration : RequestConfiguration<CustomAccessPackageWorkflowExtensionItemRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CustomAccessPackageWorkflowExtensionItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
