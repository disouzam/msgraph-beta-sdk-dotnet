// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Identity.ApiConnectors;
using Microsoft.Graph.Beta.Identity.AuthenticationEventListeners;
using Microsoft.Graph.Beta.Identity.AuthenticationEventsFlows;
using Microsoft.Graph.Beta.Identity.B2cUserFlows;
using Microsoft.Graph.Beta.Identity.B2xUserFlows;
using Microsoft.Graph.Beta.Identity.ConditionalAccess;
using Microsoft.Graph.Beta.Identity.ContinuousAccessEvaluationPolicy;
using Microsoft.Graph.Beta.Identity.CustomAuthenticationExtensions;
using Microsoft.Graph.Beta.Identity.IdentityProviders;
using Microsoft.Graph.Beta.Identity.UserFlowAttributes;
using Microsoft.Graph.Beta.Identity.UserFlows;
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
namespace Microsoft.Graph.Beta.Identity
{
    /// <summary>
    /// Provides operations to manage the identityContainer singleton.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IdentityRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the apiConnectors property of the microsoft.graph.identityContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Identity.ApiConnectors.ApiConnectorsRequestBuilder ApiConnectors
        {
            get => new global::Microsoft.Graph.Beta.Identity.ApiConnectors.ApiConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authenticationEventListeners property of the microsoft.graph.identityContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Identity.AuthenticationEventListeners.AuthenticationEventListenersRequestBuilder AuthenticationEventListeners
        {
            get => new global::Microsoft.Graph.Beta.Identity.AuthenticationEventListeners.AuthenticationEventListenersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authenticationEventsFlows property of the microsoft.graph.identityContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Identity.AuthenticationEventsFlows.AuthenticationEventsFlowsRequestBuilder AuthenticationEventsFlows
        {
            get => new global::Microsoft.Graph.Beta.Identity.AuthenticationEventsFlows.AuthenticationEventsFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the b2cUserFlows property of the microsoft.graph.identityContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Identity.B2cUserFlows.B2cUserFlowsRequestBuilder B2cUserFlows
        {
            get => new global::Microsoft.Graph.Beta.Identity.B2cUserFlows.B2cUserFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the b2xUserFlows property of the microsoft.graph.identityContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Identity.B2xUserFlows.B2xUserFlowsRequestBuilder B2xUserFlows
        {
            get => new global::Microsoft.Graph.Beta.Identity.B2xUserFlows.B2xUserFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The conditionalAccess property</summary>
        public global::Microsoft.Graph.Beta.Identity.ConditionalAccess.ConditionalAccessRequestBuilder ConditionalAccess
        {
            get => new global::Microsoft.Graph.Beta.Identity.ConditionalAccess.ConditionalAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the continuousAccessEvaluationPolicy property of the microsoft.graph.identityContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Identity.ContinuousAccessEvaluationPolicy.ContinuousAccessEvaluationPolicyRequestBuilder ContinuousAccessEvaluationPolicy
        {
            get => new global::Microsoft.Graph.Beta.Identity.ContinuousAccessEvaluationPolicy.ContinuousAccessEvaluationPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the customAuthenticationExtensions property of the microsoft.graph.identityContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Identity.CustomAuthenticationExtensions.CustomAuthenticationExtensionsRequestBuilder CustomAuthenticationExtensions
        {
            get => new global::Microsoft.Graph.Beta.Identity.CustomAuthenticationExtensions.CustomAuthenticationExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the identityProviders property of the microsoft.graph.identityContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Identity.IdentityProviders.IdentityProvidersRequestBuilder IdentityProviders
        {
            get => new global::Microsoft.Graph.Beta.Identity.IdentityProviders.IdentityProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userFlowAttributes property of the microsoft.graph.identityContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Identity.UserFlowAttributes.UserFlowAttributesRequestBuilder UserFlowAttributes
        {
            get => new global::Microsoft.Graph.Beta.Identity.UserFlowAttributes.UserFlowAttributesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userFlows property of the microsoft.graph.identityContainer entity.</summary>
        public global::Microsoft.Graph.Beta.Identity.UserFlows.UserFlowsRequestBuilder UserFlows
        {
            get => new global::Microsoft.Graph.Beta.Identity.UserFlows.UserFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Identity.IdentityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Identity.IdentityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get identity
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IdentityContainer"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.IdentityContainer?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Identity.IdentityRequestBuilder.IdentityRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.IdentityContainer> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Identity.IdentityRequestBuilder.IdentityRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.IdentityContainer>(requestInfo, global::Microsoft.Graph.Beta.Models.IdentityContainer.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update identity
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IdentityContainer"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.IdentityContainer?> PatchAsync(global::Microsoft.Graph.Beta.Models.IdentityContainer body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.IdentityContainer> PatchAsync(global::Microsoft.Graph.Beta.Models.IdentityContainer body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.IdentityContainer>(requestInfo, global::Microsoft.Graph.Beta.Models.IdentityContainer.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get identity
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Identity.IdentityRequestBuilder.IdentityRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Identity.IdentityRequestBuilder.IdentityRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update identity
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.IdentityContainer body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.IdentityContainer body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Identity.IdentityRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Identity.IdentityRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Identity.IdentityRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get identity
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class IdentityRequestBuilderGetQueryParameters 
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
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class IdentityRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Identity.IdentityRequestBuilder.IdentityRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class IdentityRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
