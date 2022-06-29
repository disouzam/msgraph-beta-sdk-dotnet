using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class DeviceCompliancePolicySettingStateSummary : Entity, IParsable {
        /// <summary>The number of devices in a conflict state. Optional. Read-only.</summary>
        public int? ConflictDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ConflictDeviceCount)); }
            set { BackingStore?.Set(nameof(ConflictDeviceCount), value); }
        }
        /// <summary>The number of devices in an error state. Optional. Read-only.</summary>
        public int? ErrorDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ErrorDeviceCount)); }
            set { BackingStore?.Set(nameof(ErrorDeviceCount), value); }
        }
        /// <summary>The number of devices in a failed state. Optional. Read-only.</summary>
        public int? FailedDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(FailedDeviceCount)); }
            set { BackingStore?.Set(nameof(FailedDeviceCount), value); }
        }
        /// <summary>The identifer for the Microsoft Intune account. Required. Read-only.</summary>
        public string IntuneAccountId {
            get { return BackingStore?.Get<string>(nameof(IntuneAccountId)); }
            set { BackingStore?.Set(nameof(IntuneAccountId), value); }
        }
        /// <summary>The identifier for the Intune setting. Optional. Read-only.</summary>
        public string IntuneSettingId {
            get { return BackingStore?.Get<string>(nameof(IntuneSettingId)); }
            set { BackingStore?.Set(nameof(IntuneSettingId), value); }
        }
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastRefreshedDateTime)); }
            set { BackingStore?.Set(nameof(LastRefreshedDateTime), value); }
        }
        /// <summary>The number of devices in a not applicable state. Optional. Read-only.</summary>
        public int? NotApplicableDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(NotApplicableDeviceCount)); }
            set { BackingStore?.Set(nameof(NotApplicableDeviceCount), value); }
        }
        /// <summary>The number of devices in a pending state. Optional. Read-only.</summary>
        public int? PendingDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(PendingDeviceCount)); }
            set { BackingStore?.Set(nameof(PendingDeviceCount), value); }
        }
        /// <summary>The type for the device compliance policy. Optional. Read-only.</summary>
        public string PolicyType {
            get { return BackingStore?.Get<string>(nameof(PolicyType)); }
            set { BackingStore?.Set(nameof(PolicyType), value); }
        }
        /// <summary>The name for the setting within the device compliance policy. Optional. Read-only.</summary>
        public string SettingName {
            get { return BackingStore?.Get<string>(nameof(SettingName)); }
            set { BackingStore?.Set(nameof(SettingName), value); }
        }
        /// <summary>The number of devices in a succeeded state. Optional. Read-only.</summary>
        public int? SucceededDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(SucceededDeviceCount)); }
            set { BackingStore?.Set(nameof(SucceededDeviceCount), value); }
        }
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
        public string TenantDisplayName {
            get { return BackingStore?.Get<string>(nameof(TenantDisplayName)); }
            set { BackingStore?.Set(nameof(TenantDisplayName), value); }
        }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Required. Read-only.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceCompliancePolicySettingStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceCompliancePolicySettingStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"conflictDeviceCount", n => { ConflictDeviceCount = n.GetIntValue(); } },
                {"errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                {"failedDeviceCount", n => { FailedDeviceCount = n.GetIntValue(); } },
                {"intuneAccountId", n => { IntuneAccountId = n.GetStringValue(); } },
                {"intuneSettingId", n => { IntuneSettingId = n.GetStringValue(); } },
                {"lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notApplicableDeviceCount", n => { NotApplicableDeviceCount = n.GetIntValue(); } },
                {"pendingDeviceCount", n => { PendingDeviceCount = n.GetIntValue(); } },
                {"policyType", n => { PolicyType = n.GetStringValue(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
                {"succeededDeviceCount", n => { SucceededDeviceCount = n.GetIntValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
            writer.WriteStringValue("intuneAccountId", IntuneAccountId);
            writer.WriteStringValue("intuneSettingId", IntuneSettingId);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("pendingDeviceCount", PendingDeviceCount);
            writer.WriteStringValue("policyType", PolicyType);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteIntValue("succeededDeviceCount", SucceededDeviceCount);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
