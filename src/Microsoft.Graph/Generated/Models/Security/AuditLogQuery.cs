// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class AuditLogQuery : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The administrative units tagged to an audit log record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AdministrativeUnitIdFilters
        {
            get { return BackingStore?.Get<List<string>?>("administrativeUnitIdFilters"); }
            set { BackingStore?.Set("administrativeUnitIdFilters", value); }
        }
#nullable restore
#else
        public List<string> AdministrativeUnitIdFilters
        {
            get { return BackingStore?.Get<List<string>>("administrativeUnitIdFilters"); }
            set { BackingStore?.Set("administrativeUnitIdFilters", value); }
        }
#endif
        /// <summary>The display name of the saved audit log query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The end date of the date range in the query.</summary>
        public DateTimeOffset? FilterEndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("filterEndDateTime"); }
            set { BackingStore?.Set("filterEndDateTime", value); }
        }
        /// <summary>The start date of the date range in the query.</summary>
        public DateTimeOffset? FilterStartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("filterStartDateTime"); }
            set { BackingStore?.Set("filterStartDateTime", value); }
        }
        /// <summary>The IP address of the device that was used when the activity was logged.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IpAddressFilters
        {
            get { return BackingStore?.Get<List<string>?>("ipAddressFilters"); }
            set { BackingStore?.Set("ipAddressFilters", value); }
        }
#nullable restore
#else
        public List<string> IpAddressFilters
        {
            get { return BackingStore?.Get<List<string>>("ipAddressFilters"); }
            set { BackingStore?.Set("ipAddressFilters", value); }
        }
#endif
        /// <summary>Free text field to search non-indexed properties of the audit log.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeywordFilter
        {
            get { return BackingStore?.Get<string?>("keywordFilter"); }
            set { BackingStore?.Set("keywordFilter", value); }
        }
#nullable restore
#else
        public string KeywordFilter
        {
            get { return BackingStore?.Get<string>("keywordFilter"); }
            set { BackingStore?.Set("keywordFilter", value); }
        }
#endif
        /// <summary>For SharePoint and OneDrive for Business activity, the full path name of the file or folder accessed by the user. For Exchange admin audit logging, the name of the object that was modified by the cmdlet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ObjectIdFilters
        {
            get { return BackingStore?.Get<List<string>?>("objectIdFilters"); }
            set { BackingStore?.Set("objectIdFilters", value); }
        }
#nullable restore
#else
        public List<string> ObjectIdFilters
        {
            get { return BackingStore?.Get<List<string>>("objectIdFilters"); }
            set { BackingStore?.Set("objectIdFilters", value); }
        }
#endif
        /// <summary>The name of the user or admin activity. For a description of the most common operations/activities, see Search the audit log in the Office 365 Protection Center.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OperationFilters
        {
            get { return BackingStore?.Get<List<string>?>("operationFilters"); }
            set { BackingStore?.Set("operationFilters", value); }
        }
#nullable restore
#else
        public List<string> OperationFilters
        {
            get { return BackingStore?.Get<List<string>>("operationFilters"); }
            set { BackingStore?.Set("operationFilters", value); }
        }
#endif
        /// <summary>An individual audit log record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecord>? Records
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecord>?>("records"); }
            set { BackingStore?.Set("records", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecord> Records
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecord>>("records"); }
            set { BackingStore?.Set("records", value); }
        }
#endif
        /// <summary>The type of operation indicated by the record. The possible values are: exchangeAdmin, exchangeItem, exchangeItemGroup, sharePoint, syntheticProbe, sharePointFileOperation, oneDrive, azureActiveDirectory, azureActiveDirectoryAccountLogon, dataCenterSecurityCmdlet, complianceDLPSharePoint, sway, complianceDLPExchange, sharePointSharingOperation, azureActiveDirectoryStsLogon, skypeForBusinessPSTNUsage, skypeForBusinessUsersBlocked, securityComplianceCenterEOPCmdlet, exchangeAggregatedOperation, powerBIAudit, crm, yammer, skypeForBusinessCmdlets, discovery, microsoftTeams, threatIntelligence, mailSubmission, microsoftFlow, aeD, microsoftStream, complianceDLPSharePointClassification, threatFinder, project, sharePointListOperation, sharePointCommentOperation, dataGovernance, kaizala, securityComplianceAlerts, threatIntelligenceUrl, securityComplianceInsights, mipLabel, workplaceAnalytics, powerAppsApp, powerAppsPlan, threatIntelligenceAtpContent, labelContentExplorer, teamsHealthcare, exchangeItemAggregated, hygieneEvent, dataInsightsRestApiAudit, informationBarrierPolicyApplication, sharePointListItemOperation, sharePointContentTypeOperation, sharePointFieldOperation, microsoftTeamsAdmin, hrSignal, microsoftTeamsDevice, microsoftTeamsAnalytics, informationWorkerProtection, campaign, dlpEndpoint, airInvestigation, quarantine, microsoftForms, applicationAudit, complianceSupervisionExchange, customerKeyServiceEncryption, officeNative, mipAutoLabelSharePointItem, mipAutoLabelSharePointPolicyLocation, microsoftTeamsShifts, secureScore, mipAutoLabelExchangeItem, cortanaBriefing, search, wdatpAlerts, powerPlatformAdminDlp, powerPlatformAdminEnvironment, mdatpAudit, sensitivityLabelPolicyMatch, sensitivityLabelAction, sensitivityLabeledFileAction, attackSim, airManualInvestigation, securityComplianceRBAC, userTraining, airAdminActionInvestigation, mstic, physicalBadgingSignal, teamsEasyApprovals, aipDiscover, aipSensitivityLabelAction, aipProtectionAction, aipFileDeleted, aipHeartBeat, mcasAlerts, onPremisesFileShareScannerDlp, onPremisesSharePointScannerDlp, exchangeSearch, sharePointSearch, privacyDataMinimization, labelAnalyticsAggregate, myAnalyticsSettings, securityComplianceUserChange, complianceDLPExchangeClassification, complianceDLPEndpoint, mipExactDataMatch, msdeResponseActions, msdeGeneralSettings, msdeIndicatorsSettings, ms365DCustomDetection, msdeRolesSettings, mapgAlerts, mapgPolicy, mapgRemediation, privacyRemediationAction, privacyDigestEmail, mipAutoLabelSimulationProgress, mipAutoLabelSimulationCompletion, mipAutoLabelProgressFeedback, dlpSensitiveInformationType, mipAutoLabelSimulationStatistics, largeContentMetadata, microsoft365Group, cdpMlInferencingResult, filteringMailMetadata, cdpClassificationMailItem, cdpClassificationDocument, officeScriptsRunAction, filteringPostMailDeliveryAction, cdpUnifiedFeedback, tenantAllowBlockList, consumptionResource, healthcareSignal, dlpImportResult, cdpCompliancePolicyExecution, multiStageDisposition, privacyDataMatch, filteringDocMetadata, filteringEmailFeatures, powerBIDlp, filteringUrlInfo, filteringAttachmentInfo, coreReportingSettings, complianceConnector, powerPlatformLockboxResourceAccessRequest, powerPlatformLockboxResourceCommand, cdpPredictiveCodingLabel, cdpCompliancePolicyUserFeedback, webpageActivityEndpoint, omePortal, cmImprovementActionChange, filteringUrlClick, mipLabelAnalyticsAuditRecord, filteringEntityEvent, filteringRuleHits, filteringMailSubmission, labelExplorer, microsoftManagedServicePlatform, powerPlatformServiceActivity, scorePlatformGenericAuditRecord, filteringTimeTravelDocMetadata, alert, alertStatus, alertIncident, incidentStatus, case, caseInvestigation, recordsManagement, privacyRemediation, dataShareOperation, cdpDlpSensitive, ehrConnector, filteringMailGradingResult, publicFolder, privacyTenantAuditHistoryRecord, aipScannerDiscoverEvent, eduDataLakeDownloadOperation, m365ComplianceConnector, microsoftGraphDataConnectOperation, microsoftPurview, filteringEmailContentFeatures, powerPagesSite, powerAppsResource, plannerPlan, plannerCopyPlan, plannerTask, plannerRoster, plannerPlanList, plannerTaskList, plannerTenantSettings, projectForTheWebProject, projectForTheWebTask, projectForTheWebRoadmap, projectForTheWebRoadmapItem, projectForTheWebProjectSettings, projectForTheWebRoadmapSettings, quarantineMetadata, microsoftTodoAudit, timeTravelFilteringDocMetadata, teamsQuarantineMetadata, sharePointAppPermissionOperation, microsoftTeamsSensitivityLabelAction, filteringTeamsMetadata, filteringTeamsUrlInfo, filteringTeamsPostDeliveryAction, mdcAssessments, mdcRegulatoryComplianceStandards, mdcRegulatoryComplianceControls, mdcRegulatoryComplianceAssessments, mdcSecurityConnectors, mdaDataSecuritySignal, vivaGoals, filteringRuntimeInfo, attackSimAdmin, microsoftGraphDataConnectConsent, filteringAtpDetonationInfo, privacyPortal, managedTenants, unifiedSimulationMatchedItem, unifiedSimulationSummary, updateQuarantineMetadata, ms365DSuppressionRule, purviewDataMapOperation, filteringUrlPostClickAction, irmUserDefinedDetectionSignal, teamsUpdates, plannerRosterSensitivityLabel, ms365DIncident, filteringDelistingMetadata, complianceDLPSharePointClassificationExtended, microsoftDefenderForIdentityAudit, supervisoryReviewDayXInsight, defenderExpertsforXDRAdmin, cdpEdgeBlockedMessage, hostedRpa, cdpContentExplorerAggregateRecord, cdpHygieneAttachmentInfo, cdpHygieneSummary, cdpPostMailDeliveryAction, cdpEmailFeatures, cdpHygieneUrlInfo, cdpUrlClick, cdpPackageManagerHygieneEvent, filteringDocScan, timeTravelFilteringDocScan, mapgOnboard, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecordType?>? RecordTypeFilters
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecordType?>?>("recordTypeFilters"); }
            set { BackingStore?.Set("recordTypeFilters", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecordType?> RecordTypeFilters
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecordType?>>("recordTypeFilters"); }
            set { BackingStore?.Set("recordTypeFilters", value); }
        }
#endif
        /// <summary>The serviceFilters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ServiceFilters
        {
            get { return BackingStore?.Get<List<string>?>("serviceFilters"); }
            set { BackingStore?.Set("serviceFilters", value); }
        }
#nullable restore
#else
        public List<string> ServiceFilters
        {
            get { return BackingStore?.Get<List<string>>("serviceFilters"); }
            set { BackingStore?.Set("serviceFilters", value); }
        }
#endif
        /// <summary>Describes the current status of the query. The possible values are: notStarted, running, succeeded, failed, cancelled, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.Security.AuditLogQueryStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.AuditLogQueryStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The UPN (user principal name) of the user who performed the action (specified in the operation property) that resulted in the record being logged; for example, myname@mydomain_name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UserPrincipalNameFilters
        {
            get { return BackingStore?.Get<List<string>?>("userPrincipalNameFilters"); }
            set { BackingStore?.Set("userPrincipalNameFilters", value); }
        }
#nullable restore
#else
        public List<string> UserPrincipalNameFilters
        {
            get { return BackingStore?.Get<List<string>>("userPrincipalNameFilters"); }
            set { BackingStore?.Set("userPrincipalNameFilters", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.AuditLogQuery"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.AuditLogQuery CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.AuditLogQuery();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "administrativeUnitIdFilters", n => { AdministrativeUnitIdFilters = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "filterEndDateTime", n => { FilterEndDateTime = n.GetDateTimeOffsetValue(); } },
                { "filterStartDateTime", n => { FilterStartDateTime = n.GetDateTimeOffsetValue(); } },
                { "ipAddressFilters", n => { IpAddressFilters = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "keywordFilter", n => { KeywordFilter = n.GetStringValue(); } },
                { "objectIdFilters", n => { ObjectIdFilters = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "operationFilters", n => { OperationFilters = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "recordTypeFilters", n => { RecordTypeFilters = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecordType>()?.AsList(); } },
                { "records", n => { Records = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecord>(global::Microsoft.Graph.Beta.Models.Security.AuditLogRecord.CreateFromDiscriminatorValue)?.AsList(); } },
                { "serviceFilters", n => { ServiceFilters = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Security.AuditLogQueryStatus>(); } },
                { "userPrincipalNameFilters", n => { UserPrincipalNameFilters = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("administrativeUnitIdFilters", AdministrativeUnitIdFilters);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("filterEndDateTime", FilterEndDateTime);
            writer.WriteDateTimeOffsetValue("filterStartDateTime", FilterStartDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("ipAddressFilters", IpAddressFilters);
            writer.WriteStringValue("keywordFilter", KeywordFilter);
            writer.WriteCollectionOfPrimitiveValues<string>("objectIdFilters", ObjectIdFilters);
            writer.WriteCollectionOfPrimitiveValues<string>("operationFilters", OperationFilters);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecord>("records", Records);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.Security.AuditLogRecordType>("recordTypeFilters", RecordTypeFilters);
            writer.WriteCollectionOfPrimitiveValues<string>("serviceFilters", ServiceFilters);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Security.AuditLogQueryStatus>("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("userPrincipalNameFilters", UserPrincipalNameFilters);
        }
    }
}
#pragma warning restore CS0618
