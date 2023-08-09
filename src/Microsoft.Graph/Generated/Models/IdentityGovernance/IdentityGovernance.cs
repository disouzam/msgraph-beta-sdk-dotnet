// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class IdentityGovernance : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The accessReviews property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessReviewSet? AccessReviews {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessReviewSet?>("accessReviews"); }
            set { BackingStore?.Set("accessReviews", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessReviewSet AccessReviews {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessReviewSet>("accessReviews"); }
            set { BackingStore?.Set("accessReviews", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The appConsent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AppConsentApprovalRoute? AppConsent {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AppConsentApprovalRoute?>("appConsent"); }
            set { BackingStore?.Set("appConsent", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AppConsentApprovalRoute AppConsent {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AppConsentApprovalRoute>("appConsent"); }
            set { BackingStore?.Set("appConsent", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The entitlementManagement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.EntitlementManagement? EntitlementManagement {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EntitlementManagement?>("entitlementManagement"); }
            set { BackingStore?.Set("entitlementManagement", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.EntitlementManagement EntitlementManagement {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EntitlementManagement>("entitlementManagement"); }
            set { BackingStore?.Set("entitlementManagement", value); }
        }
#endif
        /// <summary>The lifecycleWorkflows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LifecycleWorkflowsContainer? LifecycleWorkflows {
            get { return BackingStore?.Get<LifecycleWorkflowsContainer?>("lifecycleWorkflows"); }
            set { BackingStore?.Set("lifecycleWorkflows", value); }
        }
#nullable restore
#else
        public LifecycleWorkflowsContainer LifecycleWorkflows {
            get { return BackingStore?.Get<LifecycleWorkflowsContainer>("lifecycleWorkflows"); }
            set { BackingStore?.Set("lifecycleWorkflows", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The privilegedAccess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PrivilegedAccessRoot? PrivilegedAccess {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrivilegedAccessRoot?>("privilegedAccess"); }
            set { BackingStore?.Set("privilegedAccess", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PrivilegedAccessRoot PrivilegedAccess {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrivilegedAccessRoot>("privilegedAccess"); }
            set { BackingStore?.Set("privilegedAccess", value); }
        }
#endif
        /// <summary>The roleManagementAlerts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.RoleManagementAlert? RoleManagementAlerts {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RoleManagementAlert?>("roleManagementAlerts"); }
            set { BackingStore?.Set("roleManagementAlerts", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.RoleManagementAlert RoleManagementAlerts {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RoleManagementAlert>("roleManagementAlerts"); }
            set { BackingStore?.Set("roleManagementAlerts", value); }
        }
#endif
        /// <summary>The termsOfUse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TermsOfUseContainer? TermsOfUse {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TermsOfUseContainer?>("termsOfUse"); }
            set { BackingStore?.Set("termsOfUse", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TermsOfUseContainer TermsOfUse {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TermsOfUseContainer>("termsOfUse"); }
            set { BackingStore?.Set("termsOfUse", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new identityGovernance and sets the default values.
        /// </summary>
        public IdentityGovernance() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IdentityGovernance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentityGovernance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessReviews", n => { AccessReviews = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessReviewSet>(Microsoft.Graph.Beta.Models.AccessReviewSet.CreateFromDiscriminatorValue); } },
                {"appConsent", n => { AppConsent = n.GetObjectValue<Microsoft.Graph.Beta.Models.AppConsentApprovalRoute>(Microsoft.Graph.Beta.Models.AppConsentApprovalRoute.CreateFromDiscriminatorValue); } },
                {"entitlementManagement", n => { EntitlementManagement = n.GetObjectValue<Microsoft.Graph.Beta.Models.EntitlementManagement>(Microsoft.Graph.Beta.Models.EntitlementManagement.CreateFromDiscriminatorValue); } },
                {"lifecycleWorkflows", n => { LifecycleWorkflows = n.GetObjectValue<LifecycleWorkflowsContainer>(LifecycleWorkflowsContainer.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"privilegedAccess", n => { PrivilegedAccess = n.GetObjectValue<Microsoft.Graph.Beta.Models.PrivilegedAccessRoot>(Microsoft.Graph.Beta.Models.PrivilegedAccessRoot.CreateFromDiscriminatorValue); } },
                {"roleManagementAlerts", n => { RoleManagementAlerts = n.GetObjectValue<Microsoft.Graph.Beta.Models.RoleManagementAlert>(Microsoft.Graph.Beta.Models.RoleManagementAlert.CreateFromDiscriminatorValue); } },
                {"termsOfUse", n => { TermsOfUse = n.GetObjectValue<Microsoft.Graph.Beta.Models.TermsOfUseContainer>(Microsoft.Graph.Beta.Models.TermsOfUseContainer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessReviewSet>("accessReviews", AccessReviews);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AppConsentApprovalRoute>("appConsent", AppConsent);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.EntitlementManagement>("entitlementManagement", EntitlementManagement);
            writer.WriteObjectValue<LifecycleWorkflowsContainer>("lifecycleWorkflows", LifecycleWorkflows);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PrivilegedAccessRoot>("privilegedAccess", PrivilegedAccess);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.RoleManagementAlert>("roleManagementAlerts", RoleManagementAlerts);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TermsOfUseContainer>("termsOfUse", TermsOfUse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
