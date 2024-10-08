// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.ResourceNamespaces;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentApprovals;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentScheduleInstances;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentScheduleRequests;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentSchedules;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignments;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleDefinitions;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleInstances;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId;
using Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace
{
    /// <summary>
    /// Provides operations to manage the directory property of the microsoft.graph.roleManagement entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DirectoryRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the resourceNamespaces property of the microsoft.graph.rbacApplication entity.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.ResourceNamespaces.ResourceNamespacesRequestBuilder ResourceNamespaces
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.ResourceNamespaces.ResourceNamespacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentApprovals property of the microsoft.graph.rbacApplication entity.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentApprovals.RoleAssignmentApprovalsRequestBuilder RoleAssignmentApprovals
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentApprovals.RoleAssignmentApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignments property of the microsoft.graph.rbacApplication entity.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignments.RoleAssignmentsRequestBuilder RoleAssignments
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignments.RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentScheduleInstances property of the microsoft.graph.rbacApplication entity.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentScheduleInstances.RoleAssignmentScheduleInstancesRequestBuilder RoleAssignmentScheduleInstances
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentScheduleInstances.RoleAssignmentScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentScheduleRequests property of the microsoft.graph.rbacApplication entity.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentScheduleRequests.RoleAssignmentScheduleRequestsRequestBuilder RoleAssignmentScheduleRequests
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentScheduleRequests.RoleAssignmentScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleAssignmentSchedules property of the microsoft.graph.rbacApplication entity.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentSchedules.RoleAssignmentSchedulesRequestBuilder RoleAssignmentSchedules
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleAssignmentSchedules.RoleAssignmentSchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleDefinitions property of the microsoft.graph.rbacApplication entity.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleDefinitions.RoleDefinitionsRequestBuilder RoleDefinitions
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleDefinitions.RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilityScheduleInstances property of the microsoft.graph.rbacApplication entity.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleInstances.RoleEligibilityScheduleInstancesRequestBuilder RoleEligibilityScheduleInstances
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleInstances.RoleEligibilityScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilityScheduleRequests property of the microsoft.graph.rbacApplication entity.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder RoleEligibilityScheduleRequests
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilityScheduleRequests.RoleEligibilityScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleEligibilitySchedules property of the microsoft.graph.rbacApplication entity.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.RoleEligibilitySchedulesRequestBuilder RoleEligibilitySchedules
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleEligibilitySchedules.RoleEligibilitySchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the roleScheduleInstances method.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId.RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId.RoleScheduleInstancesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the roleSchedules method.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId.RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionId.RoleSchedulesdirectoryScopeIdDirectoryScopeIdAppScopeIdAppScopeIdPrincipalIdPrincipalIdRoleDefinitionIdRoleDefinitionIdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveRoleAssignments property of the microsoft.graph.rbacApplication entity.</summary>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.TransitiveRoleAssignmentsRequestBuilder TransitiveRoleAssignments
        {
            get => new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.TransitiveRoleAssignments.TransitiveRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.DirectoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/directory{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.DirectoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/roleManagement/directory{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property directory for roleManagement
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
        /// Get directory from roleManagement
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.RbacApplication"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.RbacApplication?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.DirectoryRequestBuilder.DirectoryRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.RbacApplication> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.DirectoryRequestBuilder.DirectoryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.RbacApplication>(requestInfo, global::Microsoft.Graph.Beta.Models.RbacApplication.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property directory in roleManagement
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.RbacApplication"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.RbacApplication?> PatchAsync(global::Microsoft.Graph.Beta.Models.RbacApplication body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.RbacApplication> PatchAsync(global::Microsoft.Graph.Beta.Models.RbacApplication body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.RbacApplication>(requestInfo, global::Microsoft.Graph.Beta.Models.RbacApplication.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property directory for roleManagement
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
        /// Get directory from roleManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.DirectoryRequestBuilder.DirectoryRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.DirectoryRequestBuilder.DirectoryRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property directory in roleManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.RbacApplication body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.RbacApplication body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.DirectoryRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.DirectoryRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.DirectoryRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DirectoryRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get directory from roleManagement
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DirectoryRequestBuilderGetQueryParameters 
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
        public partial class DirectoryRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.RoleManagement.DirectoryNamespace.DirectoryRequestBuilder.DirectoryRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DirectoryRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
