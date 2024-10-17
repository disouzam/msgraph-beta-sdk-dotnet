// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.AuditLogs.CustomSecurityAttributeAudits;
using Microsoft.Graph.Beta.AuditLogs.DirectoryAudits;
using Microsoft.Graph.Beta.AuditLogs.DirectoryProvisioning;
using Microsoft.Graph.Beta.AuditLogs.Provisioning;
using Microsoft.Graph.Beta.AuditLogs.SignIns;
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
namespace Microsoft.Graph.Beta.AuditLogs
{
    /// <summary>
    /// Provides operations to manage the auditLogRoot singleton.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AuditLogsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the customSecurityAttributeAudits property of the microsoft.graph.auditLogRoot entity.</summary>
        public global::Microsoft.Graph.Beta.AuditLogs.CustomSecurityAttributeAudits.CustomSecurityAttributeAuditsRequestBuilder CustomSecurityAttributeAudits
        {
            get => new global::Microsoft.Graph.Beta.AuditLogs.CustomSecurityAttributeAudits.CustomSecurityAttributeAuditsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the directoryAudits property of the microsoft.graph.auditLogRoot entity.</summary>
        public global::Microsoft.Graph.Beta.AuditLogs.DirectoryAudits.DirectoryAuditsRequestBuilder DirectoryAudits
        {
            get => new global::Microsoft.Graph.Beta.AuditLogs.DirectoryAudits.DirectoryAuditsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the directoryProvisioning property of the microsoft.graph.auditLogRoot entity.</summary>
        public global::Microsoft.Graph.Beta.AuditLogs.DirectoryProvisioning.DirectoryProvisioningRequestBuilder DirectoryProvisioning
        {
            get => new global::Microsoft.Graph.Beta.AuditLogs.DirectoryProvisioning.DirectoryProvisioningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the provisioning property of the microsoft.graph.auditLogRoot entity.</summary>
        public global::Microsoft.Graph.Beta.AuditLogs.Provisioning.ProvisioningRequestBuilder Provisioning
        {
            get => new global::Microsoft.Graph.Beta.AuditLogs.Provisioning.ProvisioningRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the signIns property of the microsoft.graph.auditLogRoot entity.</summary>
        public global::Microsoft.Graph.Beta.AuditLogs.SignIns.SignInsRequestBuilder SignIns
        {
            get => new global::Microsoft.Graph.Beta.AuditLogs.SignIns.SignInsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.AuditLogs.AuditLogsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuditLogsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/auditLogs{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.AuditLogs.AuditLogsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuditLogsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/auditLogs{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get auditLogs
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AuditLogRoot"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.AuditLogRoot?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AuditLogs.AuditLogsRequestBuilder.AuditLogsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.AuditLogRoot> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AuditLogs.AuditLogsRequestBuilder.AuditLogsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.AuditLogRoot>(requestInfo, global::Microsoft.Graph.Beta.Models.AuditLogRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update auditLogs
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AuditLogRoot"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.AuditLogRoot?> PatchAsync(global::Microsoft.Graph.Beta.Models.AuditLogRoot body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.AuditLogRoot> PatchAsync(global::Microsoft.Graph.Beta.Models.AuditLogRoot body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.AuditLogRoot>(requestInfo, global::Microsoft.Graph.Beta.Models.AuditLogRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get auditLogs
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AuditLogs.AuditLogsRequestBuilder.AuditLogsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AuditLogs.AuditLogsRequestBuilder.AuditLogsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update auditLogs
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.AuditLogRoot body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.AuditLogRoot body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.AuditLogs.AuditLogsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.AuditLogs.AuditLogsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.AuditLogs.AuditLogsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get auditLogs
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AuditLogsRequestBuilderGetQueryParameters 
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
        public partial class AuditLogsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.AuditLogs.AuditLogsRequestBuilder.AuditLogsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AuditLogsRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
