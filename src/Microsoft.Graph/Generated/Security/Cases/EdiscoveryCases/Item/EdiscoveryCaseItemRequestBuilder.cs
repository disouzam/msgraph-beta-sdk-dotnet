// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Custodians;
using Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.LegalHolds;
using Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.MicrosoftGraphSecurityClose;
using Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.MicrosoftGraphSecurityReopen;
using Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources;
using Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Operations;
using Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.ReviewSets;
using Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Searches;
using Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Settings;
using Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item
{
    /// <summary>
    /// Provides operations to manage the ediscoveryCases property of the microsoft.graph.security.casesRoot entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class EdiscoveryCaseItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the custodians property of the microsoft.graph.security.ediscoveryCase entity.</summary>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Custodians.CustodiansRequestBuilder Custodians
        {
            get => new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Custodians.CustodiansRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the legalHolds property of the microsoft.graph.security.ediscoveryCase entity.</summary>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.LegalHolds.LegalHoldsRequestBuilder LegalHolds
        {
            get => new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.LegalHolds.LegalHoldsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the close method.</summary>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.MicrosoftGraphSecurityClose.MicrosoftGraphSecurityCloseRequestBuilder MicrosoftGraphSecurityClose
        {
            get => new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.MicrosoftGraphSecurityClose.MicrosoftGraphSecurityCloseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reopen method.</summary>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.MicrosoftGraphSecurityReopen.MicrosoftGraphSecurityReopenRequestBuilder MicrosoftGraphSecurityReopen
        {
            get => new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.MicrosoftGraphSecurityReopen.MicrosoftGraphSecurityReopenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the noncustodialDataSources property of the microsoft.graph.security.ediscoveryCase entity.</summary>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.NoncustodialDataSourcesRequestBuilder NoncustodialDataSources
        {
            get => new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.NoncustodialDataSources.NoncustodialDataSourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.security.ediscoveryCase entity.</summary>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Operations.OperationsRequestBuilder Operations
        {
            get => new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reviewSets property of the microsoft.graph.security.ediscoveryCase entity.</summary>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.ReviewSets.ReviewSetsRequestBuilder ReviewSets
        {
            get => new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.ReviewSets.ReviewSetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the searches property of the microsoft.graph.security.ediscoveryCase entity.</summary>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Searches.SearchesRequestBuilder Searches
        {
            get => new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Searches.SearchesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the settings property of the microsoft.graph.security.ediscoveryCase entity.</summary>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Settings.SettingsRequestBuilder Settings
        {
            get => new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Settings.SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tags property of the microsoft.graph.security.ediscoveryCase entity.</summary>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.TagsRequestBuilder Tags
        {
            get => new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.TagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.EdiscoveryCaseItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoveryCaseItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.EdiscoveryCaseItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoveryCaseItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete an ediscoveryCase object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-casesroot-delete-ediscoverycases?view=graph-rest-beta" />
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
        /// Read the properties and relationships of an ediscoveryCase object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-ediscoverycase-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.EdiscoveryCaseItemRequestBuilder.EdiscoveryCaseItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.EdiscoveryCaseItemRequestBuilder.EdiscoveryCaseItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase>(requestInfo, global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of an ediscoveryCase object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-ediscoverycase-update?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase?> PatchAsync(global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase> PatchAsync(global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase>(requestInfo, global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete an ediscoveryCase object.
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
        /// Read the properties and relationships of an ediscoveryCase object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.EdiscoveryCaseItemRequestBuilder.EdiscoveryCaseItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.EdiscoveryCaseItemRequestBuilder.EdiscoveryCaseItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of an ediscoveryCase object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.EdiscoveryCaseItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.EdiscoveryCaseItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.EdiscoveryCaseItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class EdiscoveryCaseItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Read the properties and relationships of an ediscoveryCase object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class EdiscoveryCaseItemRequestBuilderGetQueryParameters 
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
        public partial class EdiscoveryCaseItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.EdiscoveryCaseItemRequestBuilder.EdiscoveryCaseItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class EdiscoveryCaseItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
