// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item
{
    /// <summary>
    /// Provides operations to manage the childTags property of the microsoft.graph.security.ediscoveryReviewTag entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class EdiscoveryReviewTagItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item.EdiscoveryReviewTagItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoveryReviewTagItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/tags/{ediscoveryReviewTag%2Did}/childTags/{ediscoveryReviewTag%2Did1}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item.EdiscoveryReviewTagItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EdiscoveryReviewTagItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/tags/{ediscoveryReviewTag%2Did}/childTags/{ediscoveryReviewTag%2Did1}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Returns the tags that are a child of a tag.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item.EdiscoveryReviewTagItemRequestBuilder.EdiscoveryReviewTagItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item.EdiscoveryReviewTagItemRequestBuilder.EdiscoveryReviewTagItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag>(requestInfo, global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the tags that are a child of a tag.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item.EdiscoveryReviewTagItemRequestBuilder.EdiscoveryReviewTagItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item.EdiscoveryReviewTagItemRequestBuilder.EdiscoveryReviewTagItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item.EdiscoveryReviewTagItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item.EdiscoveryReviewTagItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item.EdiscoveryReviewTagItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns the tags that are a child of a tag.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class EdiscoveryReviewTagItemRequestBuilderGetQueryParameters 
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
        public partial class EdiscoveryReviewTagItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Security.Cases.EdiscoveryCases.Item.Tags.Item.ChildTags.Item.EdiscoveryReviewTagItemRequestBuilder.EdiscoveryReviewTagItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
