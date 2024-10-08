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
namespace Microsoft.Graph.Beta.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection
{
    /// <summary>
    /// Provides operations to manage the parentSection property of the microsoft.graph.onenotePage entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class ParentSectionRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection.ParentSectionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ParentSectionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/onenote/notebooks/{notebook%2Did}/sections/{onenoteSection%2Did}/pages/{onenotePage%2Did}/parentSection{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection.ParentSectionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ParentSectionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/onenote/notebooks/{notebook%2Did}/sections/{onenoteSection%2Did}/pages/{onenotePage%2Did}/parentSection{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// The section that contains the page. Read-only.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OnenoteSection"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.OnenoteSection?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection.ParentSectionRequestBuilder.ParentSectionRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.OnenoteSection> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection.ParentSectionRequestBuilder.ParentSectionRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.OnenoteSection>(requestInfo, global::Microsoft.Graph.Beta.Models.OnenoteSection.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The section that contains the page. Read-only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection.ParentSectionRequestBuilder.ParentSectionRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection.ParentSectionRequestBuilder.ParentSectionRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection.ParentSectionRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete(" as of 2024-07/PrivatePreview:copilotExportAPI")]
        public global::Microsoft.Graph.Beta.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection.ParentSectionRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection.ParentSectionRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The section that contains the page. Read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class ParentSectionRequestBuilderGetQueryParameters 
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
        public partial class ParentSectionRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Me.Onenote.Notebooks.Item.Sections.Item.Pages.Item.ParentSection.ParentSectionRequestBuilder.ParentSectionRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
