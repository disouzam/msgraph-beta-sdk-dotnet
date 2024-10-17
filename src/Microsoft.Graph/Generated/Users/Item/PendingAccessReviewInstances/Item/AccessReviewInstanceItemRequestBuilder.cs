// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AcceptRecommendations;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.ApplyDecisions;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.BatchRecordDecisions;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.ContactedReviewers;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Decisions;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Definition;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.ResetDecisions;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.SendReminder;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Stages;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Stop;
using Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.StopApplyDecisions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item
{
    /// <summary>
    /// Provides operations to manage the pendingAccessReviewInstances property of the microsoft.graph.user entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AccessReviewInstanceItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the acceptRecommendations method.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AcceptRecommendations.AcceptRecommendationsRequestBuilder AcceptRecommendations
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AcceptRecommendations.AcceptRecommendationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the applyDecisions method.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.ApplyDecisions.ApplyDecisionsRequestBuilder ApplyDecisions
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.ApplyDecisions.ApplyDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the batchRecordDecisions method.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.BatchRecordDecisions.BatchRecordDecisionsRequestBuilder BatchRecordDecisions
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.BatchRecordDecisions.BatchRecordDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contactedReviewers property of the microsoft.graph.accessReviewInstance entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.ContactedReviewers.ContactedReviewersRequestBuilder ContactedReviewers
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.ContactedReviewers.ContactedReviewersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the decisions property of the microsoft.graph.accessReviewInstance entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Decisions.DecisionsRequestBuilder Decisions
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Decisions.DecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the definition property of the microsoft.graph.accessReviewInstance entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Definition.DefinitionRequestBuilder Definition
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Definition.DefinitionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the resetDecisions method.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.ResetDecisions.ResetDecisionsRequestBuilder ResetDecisions
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.ResetDecisions.ResetDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendReminder method.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.SendReminder.SendReminderRequestBuilder SendReminder
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.SendReminder.SendReminderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the stages property of the microsoft.graph.accessReviewInstance entity.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Stages.StagesRequestBuilder Stages
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Stages.StagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the stop method.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Stop.StopRequestBuilder Stop
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.Stop.StopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the stopApplyDecisions method.</summary>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.StopApplyDecisions.StopApplyDecisionsRequestBuilder StopApplyDecisions
        {
            get => new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.StopApplyDecisions.StopApplyDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AccessReviewInstanceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewInstanceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/pendingAccessReviewInstances/{accessReviewInstance%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AccessReviewInstanceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewInstanceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/pendingAccessReviewInstances/{accessReviewInstance%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property pendingAccessReviewInstances for users
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
        /// Navigation property to get a list of access reviews pending approval by the reviewer.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessReviewInstance"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.AccessReviewInstance?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AccessReviewInstanceItemRequestBuilder.AccessReviewInstanceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.AccessReviewInstance> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AccessReviewInstanceItemRequestBuilder.AccessReviewInstanceItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.AccessReviewInstance>(requestInfo, global::Microsoft.Graph.Beta.Models.AccessReviewInstance.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property pendingAccessReviewInstances in users
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessReviewInstance"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.AccessReviewInstance?> PatchAsync(global::Microsoft.Graph.Beta.Models.AccessReviewInstance body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.AccessReviewInstance> PatchAsync(global::Microsoft.Graph.Beta.Models.AccessReviewInstance body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.AccessReviewInstance>(requestInfo, global::Microsoft.Graph.Beta.Models.AccessReviewInstance.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property pendingAccessReviewInstances for users
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
        /// Navigation property to get a list of access reviews pending approval by the reviewer.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AccessReviewInstanceItemRequestBuilder.AccessReviewInstanceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AccessReviewInstanceItemRequestBuilder.AccessReviewInstanceItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property pendingAccessReviewInstances in users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.AccessReviewInstance body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.AccessReviewInstance body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AccessReviewInstanceItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AccessReviewInstanceItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AccessReviewInstanceItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccessReviewInstanceItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Navigation property to get a list of access reviews pending approval by the reviewer.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccessReviewInstanceItemRequestBuilderGetQueryParameters 
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
        public partial class AccessReviewInstanceItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Users.Item.PendingAccessReviewInstances.Item.AccessReviewInstanceItemRequestBuilder.AccessReviewInstanceItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccessReviewInstanceItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
