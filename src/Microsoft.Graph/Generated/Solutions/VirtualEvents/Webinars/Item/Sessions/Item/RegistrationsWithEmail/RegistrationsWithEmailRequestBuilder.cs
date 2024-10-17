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
namespace Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail
{
    /// <summary>
    /// Provides operations to manage the registrations property of the microsoft.graph.virtualEventSession entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RegistrationsWithEmailRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="email">Alternate key of virtualEventRegistration</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RegistrationsWithEmailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string email = "") : base(requestAdapter, "{+baseurl}/solutions/virtualEvents/webinars/{virtualEventWebinar%2Did}/sessions/{virtualEventSession%2Did}/registrations(email='{email}'){?%24expand,%24select}", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(email)) PathParameters.Add("email", email);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RegistrationsWithEmailRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/solutions/virtualEvents/webinars/{virtualEventWebinar%2Did}/sessions/{virtualEventSession%2Did}/registrations(email='{email}'){?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get registrations from solutions
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.VirtualEventRegistration"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.VirtualEventRegistration?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder.RegistrationsWithEmailRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.VirtualEventRegistration> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder.RegistrationsWithEmailRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.VirtualEventRegistration>(requestInfo, global::Microsoft.Graph.Beta.Models.VirtualEventRegistration.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get registrations from solutions
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder.RegistrationsWithEmailRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder.RegistrationsWithEmailRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get registrations from solutions
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class RegistrationsWithEmailRequestBuilderGetQueryParameters 
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
        public partial class RegistrationsWithEmailRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.RegistrationsWithEmail.RegistrationsWithEmailRequestBuilder.RegistrationsWithEmailRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
