// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.DataSource;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.LastIndexOperation;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryApplyHold;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryRelease;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryRemoveHold;
using Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryUpdateIndex;
using Microsoft.Graph.Beta.Models.Ediscovery;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item
{
    /// <summary>
    /// Provides operations to manage the noncustodialDataSources property of the microsoft.graph.ediscovery.case entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class NoncustodialDataSourceItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the dataSource property of the microsoft.graph.ediscovery.noncustodialDataSource entity.</summary>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
        public global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.DataSource.DataSourceRequestBuilder DataSource
        {
            get => new global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.DataSource.DataSourceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastIndexOperation property of the microsoft.graph.ediscovery.dataSourceContainer entity.</summary>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
        public global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.LastIndexOperation.LastIndexOperationRequestBuilder LastIndexOperation
        {
            get => new global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.LastIndexOperation.LastIndexOperationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the applyHold method.</summary>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
        public global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryApplyHold.MicrosoftGraphEdiscoveryApplyHoldRequestBuilder MicrosoftGraphEdiscoveryApplyHold
        {
            get => new global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryApplyHold.MicrosoftGraphEdiscoveryApplyHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the release method.</summary>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
        public global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryRelease.MicrosoftGraphEdiscoveryReleaseRequestBuilder MicrosoftGraphEdiscoveryRelease
        {
            get => new global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryRelease.MicrosoftGraphEdiscoveryReleaseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeHold method.</summary>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
        public global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryRemoveHold.MicrosoftGraphEdiscoveryRemoveHoldRequestBuilder MicrosoftGraphEdiscoveryRemoveHold
        {
            get => new global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryRemoveHold.MicrosoftGraphEdiscoveryRemoveHoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateIndex method.</summary>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
        public global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryUpdateIndex.MicrosoftGraphEdiscoveryUpdateIndexRequestBuilder MicrosoftGraphEdiscoveryUpdateIndex
        {
            get => new global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.MicrosoftGraphEdiscoveryUpdateIndex.MicrosoftGraphEdiscoveryUpdateIndexRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.NoncustodialDataSourceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NoncustodialDataSourceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compliance/ediscovery/cases/{case%2Did}/noncustodialDataSources/{noncustodialDataSource%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.NoncustodialDataSourceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NoncustodialDataSourceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compliance/ediscovery/cases/{case%2Did}/noncustodialDataSources/{noncustodialDataSource%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property noncustodialDataSources for compliance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
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
        /// Read the properties and relationships of a noncustodialDataSource object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/ediscovery-noncustodialdatasource-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.NoncustodialDataSourceItemRequestBuilder.NoncustodialDataSourceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.NoncustodialDataSourceItemRequestBuilder.NoncustodialDataSourceItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource>(requestInfo, global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property noncustodialDataSources in compliance
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource?> PatchAsync(global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource> PatchAsync(global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource>(requestInfo, global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property noncustodialDataSources for compliance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
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
        /// Read the properties and relationships of a noncustodialDataSource object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.NoncustodialDataSourceItemRequestBuilder.NoncustodialDataSourceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.NoncustodialDataSourceItemRequestBuilder.NoncustodialDataSourceItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property noncustodialDataSources in compliance
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.Ediscovery.NoncustodialDataSource body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.NoncustodialDataSourceItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace")]
        public global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.NoncustodialDataSourceItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.NoncustodialDataSourceItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class NoncustodialDataSourceItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Read the properties and relationships of a noncustodialDataSource object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class NoncustodialDataSourceItemRequestBuilderGetQueryParameters 
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
        public partial class NoncustodialDataSourceItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.NoncustodialDataSources.Item.NoncustodialDataSourceItemRequestBuilder.NoncustodialDataSourceItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class NoncustodialDataSourceItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
