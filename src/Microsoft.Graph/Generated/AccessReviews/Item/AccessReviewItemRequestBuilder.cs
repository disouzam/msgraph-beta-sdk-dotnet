// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.AccessReviews.Item.ApplyDecisions;
using Microsoft.Graph.Beta.AccessReviews.Item.Decisions;
using Microsoft.Graph.Beta.AccessReviews.Item.Instances;
using Microsoft.Graph.Beta.AccessReviews.Item.MyDecisions;
using Microsoft.Graph.Beta.AccessReviews.Item.ResetDecisions;
using Microsoft.Graph.Beta.AccessReviews.Item.Reviewers;
using Microsoft.Graph.Beta.AccessReviews.Item.SendReminder;
using Microsoft.Graph.Beta.AccessReviews.Item.Stop;
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
namespace Microsoft.Graph.Beta.AccessReviews.Item
{
    /// <summary>
    /// Provides operations to manage the collection of accessReview entities.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AccessReviewItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the applyDecisions method.</summary>
        public global::Microsoft.Graph.Beta.AccessReviews.Item.ApplyDecisions.ApplyDecisionsRequestBuilder ApplyDecisions
        {
            get => new global::Microsoft.Graph.Beta.AccessReviews.Item.ApplyDecisions.ApplyDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the decisions property of the microsoft.graph.accessReview entity.</summary>
        public global::Microsoft.Graph.Beta.AccessReviews.Item.Decisions.DecisionsRequestBuilder Decisions
        {
            get => new global::Microsoft.Graph.Beta.AccessReviews.Item.Decisions.DecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the instances property of the microsoft.graph.accessReview entity.</summary>
        public global::Microsoft.Graph.Beta.AccessReviews.Item.Instances.InstancesRequestBuilder Instances
        {
            get => new global::Microsoft.Graph.Beta.AccessReviews.Item.Instances.InstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the myDecisions property of the microsoft.graph.accessReview entity.</summary>
        public global::Microsoft.Graph.Beta.AccessReviews.Item.MyDecisions.MyDecisionsRequestBuilder MyDecisions
        {
            get => new global::Microsoft.Graph.Beta.AccessReviews.Item.MyDecisions.MyDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the resetDecisions method.</summary>
        public global::Microsoft.Graph.Beta.AccessReviews.Item.ResetDecisions.ResetDecisionsRequestBuilder ResetDecisions
        {
            get => new global::Microsoft.Graph.Beta.AccessReviews.Item.ResetDecisions.ResetDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reviewers property of the microsoft.graph.accessReview entity.</summary>
        public global::Microsoft.Graph.Beta.AccessReviews.Item.Reviewers.ReviewersRequestBuilder Reviewers
        {
            get => new global::Microsoft.Graph.Beta.AccessReviews.Item.Reviewers.ReviewersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendReminder method.</summary>
        public global::Microsoft.Graph.Beta.AccessReviews.Item.SendReminder.SendReminderRequestBuilder SendReminder
        {
            get => new global::Microsoft.Graph.Beta.AccessReviews.Item.SendReminder.SendReminderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the stop method.</summary>
        public global::Microsoft.Graph.Beta.AccessReviews.Item.Stop.StopRequestBuilder Stop
        {
            get => new global::Microsoft.Graph.Beta.AccessReviews.Item.Stop.StopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.AccessReviews.Item.AccessReviewItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accessReviews/{accessReview%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.AccessReviews.Item.AccessReviewItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accessReviews/{accessReview%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// In the Microsoft Entra access reviews feature, delete an accessReview object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreview-delete?view=graph-rest-beta" />
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
        /// In the Microsoft Entra access reviews feature, retrieve an accessReview object.   To retrieve the reviewers of the access review, use the list accessReview reviewers API. To retrieve the decisions of the access review, use the list accessReview decisions API, or the list my accessReview decisions API. If this is a recurring access review, no decisions will be associated with the recurring access review series. Instead, use the instances relationship of that series to retrieve an accessReview collection of the past, current, and future instances of the access review. Each past and current instance will have decisions.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreview-get?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessReview"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.AccessReview?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AccessReviews.Item.AccessReviewItemRequestBuilder.AccessReviewItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.AccessReview> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AccessReviews.Item.AccessReviewItemRequestBuilder.AccessReviewItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.AccessReview>(requestInfo, global::Microsoft.Graph.Beta.Models.AccessReview.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// In the Microsoft Entra access reviews feature, update an existing accessReview object to change one or more of its properties. This API is not intended to change the reviewers or decisions of a review.  To change the reviewers, use the addReviewer or removeReviewer APIs.  To stop an already-started one-time review, or an already-started instance of a recurring review, early, use the stop API. To apply the decisions to the target group or app access rights, use the apply API. 
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreview-update?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessReview"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.AccessReview?> PatchAsync(global::Microsoft.Graph.Beta.Models.AccessReview body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.AccessReview> PatchAsync(global::Microsoft.Graph.Beta.Models.AccessReview body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.AccessReview>(requestInfo, global::Microsoft.Graph.Beta.Models.AccessReview.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// In the Microsoft Entra access reviews feature, delete an accessReview object.
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
        /// In the Microsoft Entra access reviews feature, retrieve an accessReview object.   To retrieve the reviewers of the access review, use the list accessReview reviewers API. To retrieve the decisions of the access review, use the list accessReview decisions API, or the list my accessReview decisions API. If this is a recurring access review, no decisions will be associated with the recurring access review series. Instead, use the instances relationship of that series to retrieve an accessReview collection of the past, current, and future instances of the access review. Each past and current instance will have decisions.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AccessReviews.Item.AccessReviewItemRequestBuilder.AccessReviewItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.AccessReviews.Item.AccessReviewItemRequestBuilder.AccessReviewItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// In the Microsoft Entra access reviews feature, update an existing accessReview object to change one or more of its properties. This API is not intended to change the reviewers or decisions of a review.  To change the reviewers, use the addReviewer or removeReviewer APIs.  To stop an already-started one-time review, or an already-started instance of a recurring review, early, use the stop API. To apply the decisions to the target group or app access rights, use the apply API. 
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.AccessReview body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.AccessReview body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.AccessReviews.Item.AccessReviewItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.AccessReviews.Item.AccessReviewItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.AccessReviews.Item.AccessReviewItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccessReviewItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// In the Microsoft Entra access reviews feature, retrieve an accessReview object.   To retrieve the reviewers of the access review, use the list accessReview reviewers API. To retrieve the decisions of the access review, use the list accessReview decisions API, or the list my accessReview decisions API. If this is a recurring access review, no decisions will be associated with the recurring access review series. Instead, use the instances relationship of that series to retrieve an accessReview collection of the past, current, and future instances of the access review. Each past and current instance will have decisions.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccessReviewItemRequestBuilderGetQueryParameters 
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
        public partial class AccessReviewItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.AccessReviews.Item.AccessReviewItemRequestBuilder.AccessReviewItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccessReviewItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
