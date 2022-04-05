using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.ResourceNamespaces;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentApprovals;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignments;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentScheduleInstances;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentScheduleRequests;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleAssignmentSchedules;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleDefinitions;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilityScheduleInstances;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilityScheduleRequests;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleEligibilitySchedules;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleScheduleInstancesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionId;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.RoleSchedulesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionId;
using Microsoft.Graph.Beta.RoleManagement.EntitlementManagement.TransitiveRoleAssignments;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.RoleManagement.EntitlementManagement {
    /// <summary>Provides operations to manage the entitlementManagement property of the microsoft.graph.roleManagement entity.</summary>
    public class EntitlementManagementRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The resourceNamespaces property</summary>
        public ResourceNamespacesRequestBuilder ResourceNamespaces { get =>
            new ResourceNamespacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleAssignmentApprovals property</summary>
        public RoleAssignmentApprovalsRequestBuilder RoleAssignmentApprovals { get =>
            new RoleAssignmentApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleAssignments property</summary>
        public RoleAssignmentsRequestBuilder RoleAssignments { get =>
            new RoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleAssignmentScheduleInstances property</summary>
        public RoleAssignmentScheduleInstancesRequestBuilder RoleAssignmentScheduleInstances { get =>
            new RoleAssignmentScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleAssignmentScheduleRequests property</summary>
        public RoleAssignmentScheduleRequestsRequestBuilder RoleAssignmentScheduleRequests { get =>
            new RoleAssignmentScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleAssignmentSchedules property</summary>
        public RoleAssignmentSchedulesRequestBuilder RoleAssignmentSchedules { get =>
            new RoleAssignmentSchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleDefinitions property</summary>
        public RoleDefinitionsRequestBuilder RoleDefinitions { get =>
            new RoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleEligibilityScheduleInstances property</summary>
        public RoleEligibilityScheduleInstancesRequestBuilder RoleEligibilityScheduleInstances { get =>
            new RoleEligibilityScheduleInstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleEligibilityScheduleRequests property</summary>
        public RoleEligibilityScheduleRequestsRequestBuilder RoleEligibilityScheduleRequests { get =>
            new RoleEligibilityScheduleRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleEligibilitySchedules property</summary>
        public RoleEligibilitySchedulesRequestBuilder RoleEligibilitySchedules { get =>
            new RoleEligibilitySchedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The transitiveRoleAssignments property</summary>
        public TransitiveRoleAssignmentsRequestBuilder TransitiveRoleAssignments { get =>
            new TransitiveRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new EntitlementManagementRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public EntitlementManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/roleManagement/entitlementManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new EntitlementManagementRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public EntitlementManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/roleManagement/entitlementManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property entitlementManagement for roleManagement
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Container for roles and assignments for entitlement management resources.
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property entitlementManagement in roleManagement
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(RbacApplication body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property entitlementManagement for roleManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Container for roles and assignments for entitlement management resources.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<RbacApplication> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RbacApplication>(requestInfo, RbacApplication.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property entitlementManagement in roleManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(RbacApplication body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the roleScheduleInstances method.
        /// <param name="appScopeId">Usage: appScopeId=&apos;{appScopeId}&apos;</param>
        /// <param name="directoryScopeId">Usage: directoryScopeId=&apos;{directoryScopeId}&apos;</param>
        /// <param name="principalId">Usage: principalId=&apos;{principalId}&apos;</param>
        /// <param name="roleDefinitionId">Usage: roleDefinitionId=&apos;{roleDefinitionId}&apos;</param>
        /// </summary>
        public RoleScheduleInstancesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionIdRequestBuilder RoleScheduleInstancesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionId(string appScopeId, string directoryScopeId, string principalId, string roleDefinitionId) {
            if(string.IsNullOrEmpty(appScopeId)) throw new ArgumentNullException(nameof(appScopeId));
            if(string.IsNullOrEmpty(directoryScopeId)) throw new ArgumentNullException(nameof(directoryScopeId));
            if(string.IsNullOrEmpty(principalId)) throw new ArgumentNullException(nameof(principalId));
            if(string.IsNullOrEmpty(roleDefinitionId)) throw new ArgumentNullException(nameof(roleDefinitionId));
            return new RoleScheduleInstancesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionIdRequestBuilder(PathParameters, RequestAdapter, appScopeId, directoryScopeId, principalId, roleDefinitionId);
        }
        /// <summary>
        /// Provides operations to call the roleSchedules method.
        /// <param name="appScopeId">Usage: appScopeId=&apos;{appScopeId}&apos;</param>
        /// <param name="directoryScopeId">Usage: directoryScopeId=&apos;{directoryScopeId}&apos;</param>
        /// <param name="principalId">Usage: principalId=&apos;{principalId}&apos;</param>
        /// <param name="roleDefinitionId">Usage: roleDefinitionId=&apos;{roleDefinitionId}&apos;</param>
        /// </summary>
        public RoleSchedulesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionIdRequestBuilder RoleSchedulesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionId(string appScopeId, string directoryScopeId, string principalId, string roleDefinitionId) {
            if(string.IsNullOrEmpty(appScopeId)) throw new ArgumentNullException(nameof(appScopeId));
            if(string.IsNullOrEmpty(directoryScopeId)) throw new ArgumentNullException(nameof(directoryScopeId));
            if(string.IsNullOrEmpty(principalId)) throw new ArgumentNullException(nameof(principalId));
            if(string.IsNullOrEmpty(roleDefinitionId)) throw new ArgumentNullException(nameof(roleDefinitionId));
            return new RoleSchedulesWithDirectoryScopeIdWithAppScopeIdWithPrincipalIdWithRoleDefinitionIdRequestBuilder(PathParameters, RequestAdapter, appScopeId, directoryScopeId, principalId, roleDefinitionId);
        }
        /// <summary>Container for roles and assignments for entitlement management resources.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
