using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ActivateDeviceEsim;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.AssignmentFilterEvaluationStatusDetails;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.BypassActivationLock;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.CleanWindowsDevice;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.CreateDeviceLogCollectionRequest;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DeleteUserFromSharedAppleDevice;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Deprovision;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DetectedApps;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DeviceCategory;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DeviceCompliancePolicyStates;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DeviceConfigurationStates;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Disable;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DisableLostMode;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.EnableLostMode;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.GetCloudPcRemoteActionResults;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.GetFileVaultKey;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.GetNonCompliantSettings;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.GetOemWarranty;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.LocateDevice;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.LogCollectionRequests;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.LogoutSharedAppleDeviceActiveUser;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ManagedDeviceMobileAppConfigurationStates;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.OverrideComplianceState;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.PlayLostModeSound;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RebootNow;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RecoverPasscode;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Reenable;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RemoteLock;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ReprovisionCloudPc;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RequestRemoteAssistance;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ResetPasscode;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ResizeCloudPc;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RestoreCloudPc;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Retire;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RevokeAppleVppLicenses;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RotateBitLockerKeys;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RotateFileVaultKey;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.SecurityBaselineStates;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.SendCustomNotificationToCompanyPortal;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.SetDeviceName;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ShutDown;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.SyncDevice;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.TriggerConfigurationManagerAction;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.UpdateWindowsDeviceAccount;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Users;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.WindowsDefenderScan;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.WindowsDefenderUpdateSignatures;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.WindowsProtectionState;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Wipe;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item {
    /// <summary>Provides operations to manage the comanagedDevices property of the microsoft.graph.deviceManagement entity.</summary>
    public class ManagedDeviceItemRequestBuilder {
        /// <summary>The activateDeviceEsim property</summary>
        public ActivateDeviceEsimRequestBuilder ActivateDeviceEsim { get =>
            new ActivateDeviceEsimRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The assignmentFilterEvaluationStatusDetails property</summary>
        public AssignmentFilterEvaluationStatusDetailsRequestBuilder AssignmentFilterEvaluationStatusDetails { get =>
            new AssignmentFilterEvaluationStatusDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The bypassActivationLock property</summary>
        public BypassActivationLockRequestBuilder BypassActivationLock { get =>
            new BypassActivationLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cleanWindowsDevice property</summary>
        public CleanWindowsDeviceRequestBuilder CleanWindowsDevice { get =>
            new CleanWindowsDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The createDeviceLogCollectionRequest property</summary>
        public CreateDeviceLogCollectionRequestRequestBuilder CreateDeviceLogCollectionRequest { get =>
            new CreateDeviceLogCollectionRequestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deleteUserFromSharedAppleDevice property</summary>
        public DeleteUserFromSharedAppleDeviceRequestBuilder DeleteUserFromSharedAppleDevice { get =>
            new DeleteUserFromSharedAppleDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deprovision property</summary>
        public DeprovisionRequestBuilder Deprovision { get =>
            new DeprovisionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The detectedApps property</summary>
        public DetectedAppsRequestBuilder DetectedApps { get =>
            new DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceCategory property</summary>
        public DeviceCategoryRequestBuilder DeviceCategory { get =>
            new DeviceCategoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceCompliancePolicyStates property</summary>
        public DeviceCompliancePolicyStatesRequestBuilder DeviceCompliancePolicyStates { get =>
            new DeviceCompliancePolicyStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceConfigurationStates property</summary>
        public DeviceConfigurationStatesRequestBuilder DeviceConfigurationStates { get =>
            new DeviceConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The disable property</summary>
        public DisableRequestBuilder Disable { get =>
            new DisableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The disableLostMode property</summary>
        public DisableLostModeRequestBuilder DisableLostMode { get =>
            new DisableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enableLostMode property</summary>
        public EnableLostModeRequestBuilder EnableLostMode { get =>
            new EnableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The locateDevice property</summary>
        public LocateDeviceRequestBuilder LocateDevice { get =>
            new LocateDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logCollectionRequests property</summary>
        public LogCollectionRequestsRequestBuilder LogCollectionRequests { get =>
            new LogCollectionRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logoutSharedAppleDeviceActiveUser property</summary>
        public LogoutSharedAppleDeviceActiveUserRequestBuilder LogoutSharedAppleDeviceActiveUser { get =>
            new LogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedDeviceMobileAppConfigurationStates property</summary>
        public ManagedDeviceMobileAppConfigurationStatesRequestBuilder ManagedDeviceMobileAppConfigurationStates { get =>
            new ManagedDeviceMobileAppConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The overrideComplianceState property</summary>
        public OverrideComplianceStateRequestBuilder OverrideComplianceState { get =>
            new OverrideComplianceStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The playLostModeSound property</summary>
        public PlayLostModeSoundRequestBuilder PlayLostModeSound { get =>
            new PlayLostModeSoundRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rebootNow property</summary>
        public RebootNowRequestBuilder RebootNow { get =>
            new RebootNowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The recoverPasscode property</summary>
        public RecoverPasscodeRequestBuilder RecoverPasscode { get =>
            new RecoverPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reenable property</summary>
        public ReenableRequestBuilder Reenable { get =>
            new ReenableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The remoteLock property</summary>
        public RemoteLockRequestBuilder RemoteLock { get =>
            new RemoteLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reprovisionCloudPc property</summary>
        public ReprovisionCloudPcRequestBuilder ReprovisionCloudPc { get =>
            new ReprovisionCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The requestRemoteAssistance property</summary>
        public RequestRemoteAssistanceRequestBuilder RequestRemoteAssistance { get =>
            new RequestRemoteAssistanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The resetPasscode property</summary>
        public ResetPasscodeRequestBuilder ResetPasscode { get =>
            new ResetPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The resizeCloudPc property</summary>
        public ResizeCloudPcRequestBuilder ResizeCloudPc { get =>
            new ResizeCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The restoreCloudPc property</summary>
        public RestoreCloudPcRequestBuilder RestoreCloudPc { get =>
            new RestoreCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The retire property</summary>
        public RetireRequestBuilder Retire { get =>
            new RetireRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The revokeAppleVppLicenses property</summary>
        public RevokeAppleVppLicensesRequestBuilder RevokeAppleVppLicenses { get =>
            new RevokeAppleVppLicensesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rotateBitLockerKeys property</summary>
        public RotateBitLockerKeysRequestBuilder RotateBitLockerKeys { get =>
            new RotateBitLockerKeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rotateFileVaultKey property</summary>
        public RotateFileVaultKeyRequestBuilder RotateFileVaultKey { get =>
            new RotateFileVaultKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The securityBaselineStates property</summary>
        public SecurityBaselineStatesRequestBuilder SecurityBaselineStates { get =>
            new SecurityBaselineStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sendCustomNotificationToCompanyPortal property</summary>
        public SendCustomNotificationToCompanyPortalRequestBuilder SendCustomNotificationToCompanyPortal { get =>
            new SendCustomNotificationToCompanyPortalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The setDeviceName property</summary>
        public SetDeviceNameRequestBuilder SetDeviceName { get =>
            new SetDeviceNameRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The shutDown property</summary>
        public ShutDownRequestBuilder ShutDown { get =>
            new ShutDownRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The syncDevice property</summary>
        public SyncDeviceRequestBuilder SyncDevice { get =>
            new SyncDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The triggerConfigurationManagerAction property</summary>
        public TriggerConfigurationManagerActionRequestBuilder TriggerConfigurationManagerAction { get =>
            new TriggerConfigurationManagerActionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The updateWindowsDeviceAccount property</summary>
        public UpdateWindowsDeviceAccountRequestBuilder UpdateWindowsDeviceAccount { get =>
            new UpdateWindowsDeviceAccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The users property</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsDefenderScan property</summary>
        public WindowsDefenderScanRequestBuilder WindowsDefenderScan { get =>
            new WindowsDefenderScanRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsDefenderUpdateSignatures property</summary>
        public WindowsDefenderUpdateSignaturesRequestBuilder WindowsDefenderUpdateSignatures { get =>
            new WindowsDefenderUpdateSignaturesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsProtectionState property</summary>
        public WindowsProtectionStateRequestBuilder WindowsProtectionState { get =>
            new WindowsProtectionStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wipe property</summary>
        public WipeRequestBuilder Wipe { get =>
            new WipeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedDeviceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/comanagedDevices/{managedDevice_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedDeviceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/comanagedDevices/{managedDevice_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property comanagedDevices for deviceManagement
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
        /// The list of co-managed devices report
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
        /// Update the navigation property comanagedDevices in deviceManagement
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
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
        /// Delete navigation property comanagedDevices for deviceManagement
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
        /// The list of co-managed devices report
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.ManagedDevice> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.ManagedDevice>(requestInfo, Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getCloudPcRemoteActionResults method.
        /// </summary>
        public GetCloudPcRemoteActionResultsRequestBuilder GetCloudPcRemoteActionResults() {
            return new GetCloudPcRemoteActionResultsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getFileVaultKey method.
        /// </summary>
        public GetFileVaultKeyRequestBuilder GetFileVaultKey() {
            return new GetFileVaultKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getNonCompliantSettings method.
        /// </summary>
        public GetNonCompliantSettingsRequestBuilder GetNonCompliantSettings() {
            return new GetNonCompliantSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getOemWarranty method.
        /// </summary>
        public GetOemWarrantyRequestBuilder GetOemWarranty() {
            return new GetOemWarrantyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Update the navigation property comanagedDevices in deviceManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>The list of co-managed devices report</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
