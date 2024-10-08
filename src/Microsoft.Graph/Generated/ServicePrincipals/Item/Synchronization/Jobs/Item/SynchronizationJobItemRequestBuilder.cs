// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.BulkUpload;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Pause;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.ProvisionOnDemand;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Restart;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Schema;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Start;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.ValidateCredentials;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item
{
    /// <summary>
    /// Provides operations to manage the jobs property of the microsoft.graph.synchronization entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class SynchronizationJobItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the bulkUpload property of the microsoft.graph.synchronizationJob entity.</summary>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.BulkUpload.BulkUploadRequestBuilder BulkUpload
        {
            get => new global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.BulkUpload.BulkUploadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the pause method.</summary>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Pause.PauseRequestBuilder Pause
        {
            get => new global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Pause.PauseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the provisionOnDemand method.</summary>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.ProvisionOnDemand.ProvisionOnDemandRequestBuilder ProvisionOnDemand
        {
            get => new global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.ProvisionOnDemand.ProvisionOnDemandRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restart method.</summary>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Restart.RestartRequestBuilder Restart
        {
            get => new global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Restart.RestartRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the schema property of the microsoft.graph.synchronizationJob entity.</summary>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Schema.SchemaRequestBuilder Schema
        {
            get => new global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Schema.SchemaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the start method.</summary>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Start.StartRequestBuilder Start
        {
            get => new global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.Start.StartRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the validateCredentials method.</summary>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.ValidateCredentials.ValidateCredentialsRequestBuilder ValidateCredentials
        {
            get => new global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.ValidateCredentials.ValidateCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.SynchronizationJobItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SynchronizationJobItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/synchronization/jobs/{synchronizationJob%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.SynchronizationJobItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SynchronizationJobItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/synchronization/jobs/{synchronizationJob%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Stop the synchronization job, and permanently delete all the state associated with it. Synchronized accounts are left as-is.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/synchronization-synchronizationjob-delete?view=graph-rest-beta" />
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
        /// Retrieve the existing synchronization job and its properties.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/synchronization-synchronizationjob-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SynchronizationJob"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.SynchronizationJob?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.SynchronizationJobItemRequestBuilder.SynchronizationJobItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.SynchronizationJob> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.SynchronizationJobItemRequestBuilder.SynchronizationJobItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.SynchronizationJob>(requestInfo, global::Microsoft.Graph.Beta.Models.SynchronizationJob.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property jobs in servicePrincipals
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SynchronizationJob"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.SynchronizationJob?> PatchAsync(global::Microsoft.Graph.Beta.Models.SynchronizationJob body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.SynchronizationJob> PatchAsync(global::Microsoft.Graph.Beta.Models.SynchronizationJob body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.SynchronizationJob>(requestInfo, global::Microsoft.Graph.Beta.Models.SynchronizationJob.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Stop the synchronization job, and permanently delete all the state associated with it. Synchronized accounts are left as-is.
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
        /// Retrieve the existing synchronization job and its properties.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.SynchronizationJobItemRequestBuilder.SynchronizationJobItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.SynchronizationJobItemRequestBuilder.SynchronizationJobItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property jobs in servicePrincipals
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.SynchronizationJob body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.SynchronizationJob body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.SynchronizationJobItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.SynchronizationJobItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.SynchronizationJobItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class SynchronizationJobItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Retrieve the existing synchronization job and its properties.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class SynchronizationJobItemRequestBuilderGetQueryParameters 
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
        public partial class SynchronizationJobItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.SynchronizationJobItemRequestBuilder.SynchronizationJobItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class SynchronizationJobItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
