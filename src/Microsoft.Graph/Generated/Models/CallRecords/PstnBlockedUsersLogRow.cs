// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    public class PstnBlockedUsersLogRow : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date and time when the user was blocked/unblocked from making PSTN calls. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? BlockDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("blockDateTime"); }
            set { BackingStore?.Set("blockDateTime", value); }
        }
        /// <summary>The reason why the user is blocked/unblocked from making calls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BlockReason {
            get { return BackingStore?.Get<string?>("blockReason"); }
            set { BackingStore?.Set("blockReason", value); }
        }
#nullable restore
#else
        public string BlockReason {
            get { return BackingStore?.Get<string>("blockReason"); }
            set { BackingStore?.Set("blockReason", value); }
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
        /// <summary>Unique identifier (GUID) for the blocking/unblocking action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemediationId {
            get { return BackingStore?.Get<string?>("remediationId"); }
            set { BackingStore?.Set("remediationId", value); }
        }
#nullable restore
#else
        public string RemediationId {
            get { return BackingStore?.Get<string>("remediationId"); }
            set { BackingStore?.Set("remediationId", value); }
        }
#endif
        /// <summary>Indicates whether the user is blocked or unblocked from making PSTN calls in Microsoft Teams. The possible values are: blocked, unblocked, unknownFutureValue.</summary>
        public PstnUserBlockMode? UserBlockMode {
            get { return BackingStore?.Get<PstnUserBlockMode?>("userBlockMode"); }
            set { BackingStore?.Set("userBlockMode", value); }
        }
        /// <summary>Display name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName {
            get { return BackingStore?.Get<string?>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#nullable restore
#else
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#endif
        /// <summary>The unique identifier (GUID) of the user in Azure Active Directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>The user principal name (sign-in name) in Azure Active Directory. This is usually the same as the user&apos;s SIP address, and can be same as the user&apos;s e-mail address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>User&apos;s blocked number. For details, see E.164.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserTelephoneNumber {
            get { return BackingStore?.Get<string?>("userTelephoneNumber"); }
            set { BackingStore?.Set("userTelephoneNumber", value); }
        }
#nullable restore
#else
        public string UserTelephoneNumber {
            get { return BackingStore?.Get<string>("userTelephoneNumber"); }
            set { BackingStore?.Set("userTelephoneNumber", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new pstnBlockedUsersLogRow and sets the default values.
        /// </summary>
        public PstnBlockedUsersLogRow() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PstnBlockedUsersLogRow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PstnBlockedUsersLogRow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"blockDateTime", n => { BlockDateTime = n.GetDateTimeOffsetValue(); } },
                {"blockReason", n => { BlockReason = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"remediationId", n => { RemediationId = n.GetStringValue(); } },
                {"userBlockMode", n => { UserBlockMode = n.GetEnumValue<PstnUserBlockMode>(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userTelephoneNumber", n => { UserTelephoneNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("blockDateTime", BlockDateTime);
            writer.WriteStringValue("blockReason", BlockReason);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("remediationId", RemediationId);
            writer.WriteEnumValue<PstnUserBlockMode>("userBlockMode", UserBlockMode);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("userTelephoneNumber", UserTelephoneNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
