// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.EmployeeExperience.Communities;
using Microsoft.Graph.Beta.EmployeeExperience.EngagementAsyncOperations;
using Microsoft.Graph.Beta.EmployeeExperience.Goals;
using Microsoft.Graph.Beta.EmployeeExperience.LearningCourseActivities;
using Microsoft.Graph.Beta.EmployeeExperience.LearningCourseActivitiesWithExternalcourseActivityId;
using Microsoft.Graph.Beta.EmployeeExperience.LearningProviders;
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
namespace Microsoft.Graph.Beta.EmployeeExperience
{
    /// <summary>
    /// Provides operations to manage the employeeExperience singleton.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class EmployeeExperienceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the communities property of the microsoft.graph.employeeExperience entity.</summary>
        public global::Microsoft.Graph.Beta.EmployeeExperience.Communities.CommunitiesRequestBuilder Communities
        {
            get => new global::Microsoft.Graph.Beta.EmployeeExperience.Communities.CommunitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the engagementAsyncOperations property of the microsoft.graph.employeeExperience entity.</summary>
        public global::Microsoft.Graph.Beta.EmployeeExperience.EngagementAsyncOperations.EngagementAsyncOperationsRequestBuilder EngagementAsyncOperations
        {
            get => new global::Microsoft.Graph.Beta.EmployeeExperience.EngagementAsyncOperations.EngagementAsyncOperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the goals property of the microsoft.graph.employeeExperience entity.</summary>
        public global::Microsoft.Graph.Beta.EmployeeExperience.Goals.GoalsRequestBuilder Goals
        {
            get => new global::Microsoft.Graph.Beta.EmployeeExperience.Goals.GoalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the learningCourseActivities property of the microsoft.graph.employeeExperience entity.</summary>
        public global::Microsoft.Graph.Beta.EmployeeExperience.LearningCourseActivities.LearningCourseActivitiesRequestBuilder LearningCourseActivities
        {
            get => new global::Microsoft.Graph.Beta.EmployeeExperience.LearningCourseActivities.LearningCourseActivitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the learningProviders property of the microsoft.graph.employeeExperience entity.</summary>
        public global::Microsoft.Graph.Beta.EmployeeExperience.LearningProviders.LearningProvidersRequestBuilder LearningProviders
        {
            get => new global::Microsoft.Graph.Beta.EmployeeExperience.LearningProviders.LearningProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.EmployeeExperience.EmployeeExperienceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmployeeExperienceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/employeeExperience{?%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.EmployeeExperience.EmployeeExperienceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmployeeExperienceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/employeeExperience{?%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get employeeExperience
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.EmployeeExperience"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.EmployeeExperience?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.EmployeeExperience.EmployeeExperienceRequestBuilder.EmployeeExperienceRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.EmployeeExperience> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.EmployeeExperience.EmployeeExperienceRequestBuilder.EmployeeExperienceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.EmployeeExperience>(requestInfo, global::Microsoft.Graph.Beta.Models.EmployeeExperience.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to manage the learningCourseActivities property of the microsoft.graph.employeeExperience entity.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.EmployeeExperience.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder"/></returns>
        /// <param name="externalcourseActivityId">Alternate key of learningCourseActivity</param>
        public global::Microsoft.Graph.Beta.EmployeeExperience.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder LearningCourseActivitiesWithExternalcourseActivityId(string externalcourseActivityId)
        {
            if(string.IsNullOrEmpty(externalcourseActivityId)) throw new ArgumentNullException(nameof(externalcourseActivityId));
            return new global::Microsoft.Graph.Beta.EmployeeExperience.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder(PathParameters, RequestAdapter, externalcourseActivityId);
        }
        /// <summary>
        /// Update employeeExperience
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.EmployeeExperience"/></returns>
        /// <param name="body">Represents a container that exposes navigation properties for employee experience resources.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.EmployeeExperience?> PatchAsync(global::Microsoft.Graph.Beta.Models.EmployeeExperience body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.EmployeeExperience> PatchAsync(global::Microsoft.Graph.Beta.Models.EmployeeExperience body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.EmployeeExperience>(requestInfo, global::Microsoft.Graph.Beta.Models.EmployeeExperience.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get employeeExperience
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.EmployeeExperience.EmployeeExperienceRequestBuilder.EmployeeExperienceRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.EmployeeExperience.EmployeeExperienceRequestBuilder.EmployeeExperienceRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update employeeExperience
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Represents a container that exposes navigation properties for employee experience resources.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.EmployeeExperience body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.EmployeeExperience body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.EmployeeExperience.EmployeeExperienceRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.EmployeeExperience.EmployeeExperienceRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.EmployeeExperience.EmployeeExperienceRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get employeeExperience
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class EmployeeExperienceRequestBuilderGetQueryParameters 
        {
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
        public partial class EmployeeExperienceRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.EmployeeExperience.EmployeeExperienceRequestBuilder.EmployeeExperienceRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class EmployeeExperienceRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
