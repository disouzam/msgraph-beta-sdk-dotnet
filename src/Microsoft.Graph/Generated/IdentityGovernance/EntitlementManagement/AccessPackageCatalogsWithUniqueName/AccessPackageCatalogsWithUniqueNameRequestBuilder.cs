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
namespace Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogsWithUniqueName
{
    /// <summary>
    /// Provides operations to manage the accessPackageCatalogs property of the microsoft.graph.entitlementManagement entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class AccessPackageCatalogsWithUniqueNameRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogsWithUniqueName.AccessPackageCatalogsWithUniqueNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="uniqueName">Alternate key of accessPackageCatalog</param>
        public AccessPackageCatalogsWithUniqueNameRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string uniqueName = "") : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs(uniqueName='{uniqueName}'){?%24expand,%24select}", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(uniqueName)) PathParameters.Add("uniqueName", uniqueName);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogsWithUniqueName.AccessPackageCatalogsWithUniqueNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessPackageCatalogsWithUniqueNameRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/entitlementManagement/accessPackageCatalogs(uniqueName='{uniqueName}'){?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete an accessPackageCatalog.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackagecatalog-delete?view=graph-rest-beta" />
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
        /// Retrieve the properties and relationships of an accessPackageCatalog object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackagecatalog-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessPackageCatalog"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.AccessPackageCatalog?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogsWithUniqueName.AccessPackageCatalogsWithUniqueNameRequestBuilder.AccessPackageCatalogsWithUniqueNameRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.AccessPackageCatalog> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogsWithUniqueName.AccessPackageCatalogsWithUniqueNameRequestBuilder.AccessPackageCatalogsWithUniqueNameRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.AccessPackageCatalog>(requestInfo, global::Microsoft.Graph.Beta.Models.AccessPackageCatalog.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update an existing accessPackageCatalog object to change one or more of its properties, such as the display name or description.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accesspackagecatalog-update?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessPackageCatalog"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.AccessPackageCatalog?> PatchAsync(global::Microsoft.Graph.Beta.Models.AccessPackageCatalog body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.AccessPackageCatalog> PatchAsync(global::Microsoft.Graph.Beta.Models.AccessPackageCatalog body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.AccessPackageCatalog>(requestInfo, global::Microsoft.Graph.Beta.Models.AccessPackageCatalog.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete an accessPackageCatalog.
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
        /// Retrieve the properties and relationships of an accessPackageCatalog object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogsWithUniqueName.AccessPackageCatalogsWithUniqueNameRequestBuilder.AccessPackageCatalogsWithUniqueNameRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogsWithUniqueName.AccessPackageCatalogsWithUniqueNameRequestBuilder.AccessPackageCatalogsWithUniqueNameRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update an existing accessPackageCatalog object to change one or more of its properties, such as the display name or description.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.AccessPackageCatalog body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.AccessPackageCatalog body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogsWithUniqueName.AccessPackageCatalogsWithUniqueNameRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete(" as of 2022-10/PrivatePreview:MicrosofEntitlementManagementCustomextensions")]
        public global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogsWithUniqueName.AccessPackageCatalogsWithUniqueNameRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogsWithUniqueName.AccessPackageCatalogsWithUniqueNameRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class AccessPackageCatalogsWithUniqueNameRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Retrieve the properties and relationships of an accessPackageCatalog object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class AccessPackageCatalogsWithUniqueNameRequestBuilderGetQueryParameters 
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
        public partial class AccessPackageCatalogsWithUniqueNameRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.IdentityGovernance.EntitlementManagement.AccessPackageCatalogsWithUniqueName.AccessPackageCatalogsWithUniqueNameRequestBuilder.AccessPackageCatalogsWithUniqueNameRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class AccessPackageCatalogsWithUniqueNameRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
