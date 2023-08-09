// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CompanyInformation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PostalAddressType? Address {
            get { return BackingStore?.Get<PostalAddressType?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public PostalAddressType Address {
            get { return BackingStore?.Get<PostalAddressType>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The currencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode {
            get { return BackingStore?.Get<string?>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#nullable restore
#else
        public string CurrencyCode {
            get { return BackingStore?.Get<string>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#endif
        /// <summary>The currentFiscalYearStartDate property</summary>
        public Date? CurrentFiscalYearStartDate {
            get { return BackingStore?.Get<Date?>("currentFiscalYearStartDate"); }
            set { BackingStore?.Set("currentFiscalYearStartDate", value); }
        }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>The faxNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FaxNumber {
            get { return BackingStore?.Get<string?>("faxNumber"); }
            set { BackingStore?.Set("faxNumber", value); }
        }
#nullable restore
#else
        public string FaxNumber {
            get { return BackingStore?.Get<string>("faxNumber"); }
            set { BackingStore?.Set("faxNumber", value); }
        }
#endif
        /// <summary>The id property</summary>
        public Guid? Id {
            get { return BackingStore?.Get<Guid?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The industry property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Industry {
            get { return BackingStore?.Get<string?>("industry"); }
            set { BackingStore?.Set("industry", value); }
        }
#nullable restore
#else
        public string Industry {
            get { return BackingStore?.Get<string>("industry"); }
            set { BackingStore?.Set("industry", value); }
        }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
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
        /// <summary>The phoneNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber {
            get { return BackingStore?.Get<string?>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#nullable restore
#else
        public string PhoneNumber {
            get { return BackingStore?.Get<string>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#endif
        /// <summary>The picture property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Picture {
            get { return BackingStore?.Get<byte[]?>("picture"); }
            set { BackingStore?.Set("picture", value); }
        }
#nullable restore
#else
        public byte[] Picture {
            get { return BackingStore?.Get<byte[]>("picture"); }
            set { BackingStore?.Set("picture", value); }
        }
#endif
        /// <summary>The taxRegistrationNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxRegistrationNumber {
            get { return BackingStore?.Get<string?>("taxRegistrationNumber"); }
            set { BackingStore?.Set("taxRegistrationNumber", value); }
        }
#nullable restore
#else
        public string TaxRegistrationNumber {
            get { return BackingStore?.Get<string>("taxRegistrationNumber"); }
            set { BackingStore?.Set("taxRegistrationNumber", value); }
        }
#endif
        /// <summary>The website property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Website {
            get { return BackingStore?.Get<string?>("website"); }
            set { BackingStore?.Set("website", value); }
        }
#nullable restore
#else
        public string Website {
            get { return BackingStore?.Get<string>("website"); }
            set { BackingStore?.Set("website", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new companyInformation and sets the default values.
        /// </summary>
        public CompanyInformation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CompanyInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CompanyInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currentFiscalYearStartDate", n => { CurrentFiscalYearStartDate = n.GetDateValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"faxNumber", n => { FaxNumber = n.GetStringValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"industry", n => { Industry = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"picture", n => { Picture = n.GetByteArrayValue(); } },
                {"taxRegistrationNumber", n => { TaxRegistrationNumber = n.GetStringValue(); } },
                {"website", n => { Website = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PostalAddressType>("address", Address);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteDateValue("currentFiscalYearStartDate", CurrentFiscalYearStartDate);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("faxNumber", FaxNumber);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("industry", Industry);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteByteArrayValue("picture", Picture);
            writer.WriteStringValue("taxRegistrationNumber", TaxRegistrationNumber);
            writer.WriteStringValue("website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
