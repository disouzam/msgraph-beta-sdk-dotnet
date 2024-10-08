// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.Count;
using Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphApplication;
using Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphDevice;
using Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphGroup;
using Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphOrgContact;
using Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphServicePrincipal;
using Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphUser;
using Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.Item;
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
namespace Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors
{
    /// <summary>
    /// Provides operations to manage the membersWithLicenseErrors property of the microsoft.graph.group entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class MembersWithLicenseErrorsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.Count.CountRequestBuilder Count
        {
            get => new global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to application.</summary>
        public global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphApplication.GraphApplicationRequestBuilder GraphApplication
        {
            get => new global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphApplication.GraphApplicationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to device.</summary>
        public global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphDevice.GraphDeviceRequestBuilder GraphDevice
        {
            get => new global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphDevice.GraphDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to group.</summary>
        public global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphGroup.GraphGroupRequestBuilder GraphGroup
        {
            get => new global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphGroup.GraphGroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to orgContact.</summary>
        public global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphOrgContact.GraphOrgContactRequestBuilder GraphOrgContact
        {
            get => new global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphOrgContact.GraphOrgContactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to servicePrincipal.</summary>
        public global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphServicePrincipal.GraphServicePrincipalRequestBuilder GraphServicePrincipal
        {
            get => new global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphServicePrincipal.GraphServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to user.</summary>
        public global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphUser.GraphUserRequestBuilder GraphUser
        {
            get => new global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.GraphUser.GraphUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the membersWithLicenseErrors property of the microsoft.graph.group entity.</summary>
        /// <param name="position">The unique identifier of directoryObject</param>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.Item.DirectoryObjectItemRequestBuilder"/></returns>
        public global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.Item.DirectoryObjectItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("directoryObject%2Did", position);
                return new global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.Item.DirectoryObjectItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.MembersWithLicenseErrorsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembersWithLicenseErrorsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/membersWithLicenseErrors{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.MembersWithLicenseErrorsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembersWithLicenseErrorsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/membersWithLicenseErrors{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// A list of group members with license errors from this group-based license assignment. Read-only.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.MembersWithLicenseErrorsRequestBuilder.MembersWithLicenseErrorsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.MembersWithLicenseErrorsRequestBuilder.MembersWithLicenseErrorsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse>(requestInfo, global::Microsoft.Graph.Beta.Models.DirectoryObjectCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// A list of group members with license errors from this group-based license assignment. Read-only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.MembersWithLicenseErrorsRequestBuilder.MembersWithLicenseErrorsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.MembersWithLicenseErrorsRequestBuilder.MembersWithLicenseErrorsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.MembersWithLicenseErrorsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.MembersWithLicenseErrorsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.MembersWithLicenseErrorsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// A list of group members with license errors from this group-based license assignment. Read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class MembersWithLicenseErrorsRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class MembersWithLicenseErrorsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Groups.Item.MembersWithLicenseErrors.MembersWithLicenseErrorsRequestBuilder.MembersWithLicenseErrorsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
