using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    public class SmsLogRow : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Amount of money or cost of the SMS that is charged.</summary>
        public decimal? CallCharge {
            get { return BackingStore?.Get<decimal?>("callCharge"); }
            set { BackingStore?.Set("callCharge", value); }
        }
        /// <summary>Currency used to calculate the cost of the call. For details, see ISO 4217.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency {
            get { return BackingStore?.Get<string?>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#nullable restore
#else
        public string Currency {
            get { return BackingStore?.Get<string>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#endif
        /// <summary>Indicates whether the SMS was Domestic (within a country or region) or International (outside a country or region) based on the user&apos;s location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationContext {
            get { return BackingStore?.Get<string?>("destinationContext"); }
            set { BackingStore?.Set("destinationContext", value); }
        }
#nullable restore
#else
        public string DestinationContext {
            get { return BackingStore?.Get<string>("destinationContext"); }
            set { BackingStore?.Set("destinationContext", value); }
        }
#endif
        /// <summary>Country or region of a phone number that received the SMS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationName {
            get { return BackingStore?.Get<string?>("destinationName"); }
            set { BackingStore?.Set("destinationName", value); }
        }
#nullable restore
#else
        public string DestinationName {
            get { return BackingStore?.Get<string>("destinationName"); }
            set { BackingStore?.Set("destinationName", value); }
        }
#endif
        /// <summary>Partially obfuscated phone number that received the SMS. For details, see E.164.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationNumber {
            get { return BackingStore?.Get<string?>("destinationNumber"); }
            set { BackingStore?.Set("destinationNumber", value); }
        }
#nullable restore
#else
        public string DestinationNumber {
            get { return BackingStore?.Get<string>("destinationNumber"); }
            set { BackingStore?.Set("destinationNumber", value); }
        }
#endif
        /// <summary>Unique identifier (GUID) for the SMS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
        /// <summary>The license used for the SMS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LicenseCapability {
            get { return BackingStore?.Get<string?>("licenseCapability"); }
            set { BackingStore?.Set("licenseCapability", value); }
        }
#nullable restore
#else
        public string LicenseCapability {
            get { return BackingStore?.Get<string>("licenseCapability"); }
            set { BackingStore?.Set("licenseCapability", value); }
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
        /// <summary>For an outbound SMS, the country code of the receiver; otherwise (inbound SMS) the country code of the sender. For details, see ISO 3166-1 alpha-2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OtherPartyCountryCode {
            get { return BackingStore?.Get<string?>("otherPartyCountryCode"); }
            set { BackingStore?.Set("otherPartyCountryCode", value); }
        }
#nullable restore
#else
        public string OtherPartyCountryCode {
            get { return BackingStore?.Get<string>("otherPartyCountryCode"); }
            set { BackingStore?.Set("otherPartyCountryCode", value); }
        }
#endif
        /// <summary>The date and time when the SMS was sent.</summary>
        public DateTimeOffset? SentDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("sentDateTime"); }
            set { BackingStore?.Set("sentDateTime", value); }
        }
        /// <summary>SMS identifier. Not guaranteed to be unique.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SmsId {
            get { return BackingStore?.Get<string?>("smsId"); }
            set { BackingStore?.Set("smsId", value); }
        }
#nullable restore
#else
        public string SmsId {
            get { return BackingStore?.Get<string>("smsId"); }
            set { BackingStore?.Set("smsId", value); }
        }
#endif
        /// <summary>Type of SMS such as outbound or inbound.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SmsType {
            get { return BackingStore?.Get<string?>("smsType"); }
            set { BackingStore?.Set("smsType", value); }
        }
#nullable restore
#else
        public string SmsType {
            get { return BackingStore?.Get<string>("smsType"); }
            set { BackingStore?.Set("smsType", value); }
        }
#endif
        /// <summary>Number of SMS units sent/received.</summary>
        public int? SmsUnits {
            get { return BackingStore?.Get<int?>("smsUnits"); }
            set { BackingStore?.Set("smsUnits", value); }
        }
        /// <summary>Partially obfuscated phone number that sent the SMS. For details, see E.164.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceNumber {
            get { return BackingStore?.Get<string?>("sourceNumber"); }
            set { BackingStore?.Set("sourceNumber", value); }
        }
#nullable restore
#else
        public string SourceNumber {
            get { return BackingStore?.Get<string>("sourceNumber"); }
            set { BackingStore?.Set("sourceNumber", value); }
        }
#endif
        /// <summary>Country code of the tenant. For details, see ISO 3166-1 alpha-2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantCountryCode {
            get { return BackingStore?.Get<string?>("tenantCountryCode"); }
            set { BackingStore?.Set("tenantCountryCode", value); }
        }
#nullable restore
#else
        public string TenantCountryCode {
            get { return BackingStore?.Get<string>("tenantCountryCode"); }
            set { BackingStore?.Set("tenantCountryCode", value); }
        }
#endif
        /// <summary>Country code of the user. For details, see ISO 3166-1 alpha-2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserCountryCode {
            get { return BackingStore?.Get<string?>("userCountryCode"); }
            set { BackingStore?.Set("userCountryCode", value); }
        }
#nullable restore
#else
        public string UserCountryCode {
            get { return BackingStore?.Get<string>("userCountryCode"); }
            set { BackingStore?.Set("userCountryCode", value); }
        }
#endif
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
        /// <summary>
        /// Instantiates a new smsLogRow and sets the default values.
        /// </summary>
        public SmsLogRow() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SmsLogRow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SmsLogRow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"callCharge", n => { CallCharge = n.GetDecimalValue(); } },
                {"currency", n => { Currency = n.GetStringValue(); } },
                {"destinationContext", n => { DestinationContext = n.GetStringValue(); } },
                {"destinationName", n => { DestinationName = n.GetStringValue(); } },
                {"destinationNumber", n => { DestinationNumber = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"licenseCapability", n => { LicenseCapability = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"otherPartyCountryCode", n => { OtherPartyCountryCode = n.GetStringValue(); } },
                {"sentDateTime", n => { SentDateTime = n.GetDateTimeOffsetValue(); } },
                {"smsId", n => { SmsId = n.GetStringValue(); } },
                {"smsType", n => { SmsType = n.GetStringValue(); } },
                {"smsUnits", n => { SmsUnits = n.GetIntValue(); } },
                {"sourceNumber", n => { SourceNumber = n.GetStringValue(); } },
                {"tenantCountryCode", n => { TenantCountryCode = n.GetStringValue(); } },
                {"userCountryCode", n => { UserCountryCode = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDecimalValue("callCharge", CallCharge);
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("destinationContext", DestinationContext);
            writer.WriteStringValue("destinationName", DestinationName);
            writer.WriteStringValue("destinationNumber", DestinationNumber);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("licenseCapability", LicenseCapability);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("otherPartyCountryCode", OtherPartyCountryCode);
            writer.WriteDateTimeOffsetValue("sentDateTime", SentDateTime);
            writer.WriteStringValue("smsId", SmsId);
            writer.WriteStringValue("smsType", SmsType);
            writer.WriteIntValue("smsUnits", SmsUnits);
            writer.WriteStringValue("sourceNumber", SourceNumber);
            writer.WriteStringValue("tenantCountryCode", TenantCountryCode);
            writer.WriteStringValue("userCountryCode", UserCountryCode);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
