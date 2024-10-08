// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.Account;
using Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.Item_Escaped;
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
namespace Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item
{
    /// <summary>
    /// Provides operations to manage the salesCreditMemoLines property of the microsoft.graph.company entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class SalesCreditMemoLineItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the account property of the microsoft.graph.salesCreditMemoLine entity.</summary>
        public global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.Account.AccountRequestBuilder Account
        {
            get => new global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.Account.AccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the item property of the microsoft.graph.salesCreditMemoLine entity.</summary>
        public global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.Item_Escaped.Item_EscapedRequestBuilder Item
        {
            get => new global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.Item_Escaped.Item_EscapedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.SalesCreditMemoLineItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SalesCreditMemoLineItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/financials/companies/{company%2Did}/salesCreditMemoLines/{salesCreditMemoLine%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.SalesCreditMemoLineItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SalesCreditMemoLineItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/financials/companies/{company%2Did}/salesCreditMemoLines/{salesCreditMemoLine%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get salesCreditMemoLines from financials
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.SalesCreditMemoLineItemRequestBuilder.SalesCreditMemoLineItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.SalesCreditMemoLineItemRequestBuilder.SalesCreditMemoLineItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine>(requestInfo, global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property salesCreditMemoLines in financials
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine?> PatchAsync(global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine> PatchAsync(global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine>(requestInfo, global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get salesCreditMemoLines from financials
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.SalesCreditMemoLineItemRequestBuilder.SalesCreditMemoLineItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.SalesCreditMemoLineItemRequestBuilder.SalesCreditMemoLineItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property salesCreditMemoLines in financials
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.SalesCreditMemoLine body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.SalesCreditMemoLineItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.SalesCreditMemoLineItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.SalesCreditMemoLineItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get salesCreditMemoLines from financials
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class SalesCreditMemoLineItemRequestBuilderGetQueryParameters 
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
        public partial class SalesCreditMemoLineItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Financials.Companies.Item.SalesCreditMemoLines.Item.SalesCreditMemoLineItemRequestBuilder.SalesCreditMemoLineItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class SalesCreditMemoLineItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
