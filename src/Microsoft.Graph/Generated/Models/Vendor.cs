// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Vendor : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PostalAddressType? Address
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PostalAddressType?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PostalAddressType Address
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PostalAddressType>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The balance property</summary>
        public decimal? Balance
        {
            get { return BackingStore?.Get<decimal?>("balance"); }
            set { BackingStore?.Set("balance", value); }
        }
        /// <summary>The blocked property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Blocked
        {
            get { return BackingStore?.Get<string?>("blocked"); }
            set { BackingStore?.Set("blocked", value); }
        }
#nullable restore
#else
        public string Blocked
        {
            get { return BackingStore?.Get<string>("blocked"); }
            set { BackingStore?.Set("blocked", value); }
        }
#endif
        /// <summary>The currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Currency? Currency
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Currency?>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Currency Currency
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Currency>("currency"); }
            set { BackingStore?.Set("currency", value); }
        }
#endif
        /// <summary>The currencyCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode
        {
            get { return BackingStore?.Get<string?>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#nullable restore
#else
        public string CurrencyCode
        {
            get { return BackingStore?.Get<string>("currencyCode"); }
            set { BackingStore?.Set("currencyCode", value); }
        }
#endif
        /// <summary>The currencyId property</summary>
        public Guid? CurrencyId
        {
            get { return BackingStore?.Get<Guid?>("currencyId"); }
            set { BackingStore?.Set("currencyId", value); }
        }
        /// <summary>The displayName property</summary>
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
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email
        {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email
        {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>The id property</summary>
        public Guid? Id
        {
            get { return BackingStore?.Get<Guid?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Number
        {
            get { return BackingStore?.Get<string?>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#nullable restore
#else
        public string Number
        {
            get { return BackingStore?.Get<string>("number"); }
            set { BackingStore?.Set("number", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The paymentMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PaymentMethod? PaymentMethod
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PaymentMethod?>("paymentMethod"); }
            set { BackingStore?.Set("paymentMethod", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PaymentMethod PaymentMethod
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PaymentMethod>("paymentMethod"); }
            set { BackingStore?.Set("paymentMethod", value); }
        }
#endif
        /// <summary>The paymentMethodId property</summary>
        public Guid? PaymentMethodId
        {
            get { return BackingStore?.Get<Guid?>("paymentMethodId"); }
            set { BackingStore?.Set("paymentMethodId", value); }
        }
        /// <summary>The paymentTerm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PaymentTerm? PaymentTerm
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PaymentTerm?>("paymentTerm"); }
            set { BackingStore?.Set("paymentTerm", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PaymentTerm PaymentTerm
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PaymentTerm>("paymentTerm"); }
            set { BackingStore?.Set("paymentTerm", value); }
        }
#endif
        /// <summary>The paymentTermsId property</summary>
        public Guid? PaymentTermsId
        {
            get { return BackingStore?.Get<Guid?>("paymentTermsId"); }
            set { BackingStore?.Set("paymentTermsId", value); }
        }
        /// <summary>The phoneNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber
        {
            get { return BackingStore?.Get<string?>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#nullable restore
#else
        public string PhoneNumber
        {
            get { return BackingStore?.Get<string>("phoneNumber"); }
            set { BackingStore?.Set("phoneNumber", value); }
        }
#endif
        /// <summary>The picture property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Picture>? Picture
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Picture>?>("picture"); }
            set { BackingStore?.Set("picture", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Picture> Picture
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Picture>>("picture"); }
            set { BackingStore?.Set("picture", value); }
        }
#endif
        /// <summary>The taxLiable property</summary>
        public bool? TaxLiable
        {
            get { return BackingStore?.Get<bool?>("taxLiable"); }
            set { BackingStore?.Set("taxLiable", value); }
        }
        /// <summary>The taxRegistrationNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxRegistrationNumber
        {
            get { return BackingStore?.Get<string?>("taxRegistrationNumber"); }
            set { BackingStore?.Set("taxRegistrationNumber", value); }
        }
#nullable restore
#else
        public string TaxRegistrationNumber
        {
            get { return BackingStore?.Get<string>("taxRegistrationNumber"); }
            set { BackingStore?.Set("taxRegistrationNumber", value); }
        }
#endif
        /// <summary>The website property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Website
        {
            get { return BackingStore?.Get<string?>("website"); }
            set { BackingStore?.Set("website", value); }
        }
#nullable restore
#else
        public string Website
        {
            get { return BackingStore?.Get<string>("website"); }
            set { BackingStore?.Set("website", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Vendor"/> and sets the default values.
        /// </summary>
        public Vendor()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Vendor"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.Vendor CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Vendor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "address", n => { Address = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PostalAddressType>(global::Microsoft.Graph.Beta.Models.PostalAddressType.CreateFromDiscriminatorValue); } },
                { "balance", n => { Balance = n.GetDecimalValue(); } },
                { "blocked", n => { Blocked = n.GetStringValue(); } },
                { "currency", n => { Currency = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Currency>(global::Microsoft.Graph.Beta.Models.Currency.CreateFromDiscriminatorValue); } },
                { "currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                { "currencyId", n => { CurrencyId = n.GetGuidValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "number", n => { Number = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "paymentMethod", n => { PaymentMethod = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PaymentMethod>(global::Microsoft.Graph.Beta.Models.PaymentMethod.CreateFromDiscriminatorValue); } },
                { "paymentMethodId", n => { PaymentMethodId = n.GetGuidValue(); } },
                { "paymentTerm", n => { PaymentTerm = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PaymentTerm>(global::Microsoft.Graph.Beta.Models.PaymentTerm.CreateFromDiscriminatorValue); } },
                { "paymentTermsId", n => { PaymentTermsId = n.GetGuidValue(); } },
                { "phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                { "picture", n => { Picture = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Picture>(global::Microsoft.Graph.Beta.Models.Picture.CreateFromDiscriminatorValue)?.AsList(); } },
                { "taxLiable", n => { TaxLiable = n.GetBoolValue(); } },
                { "taxRegistrationNumber", n => { TaxRegistrationNumber = n.GetStringValue(); } },
                { "website", n => { Website = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PostalAddressType>("address", Address);
            writer.WriteDecimalValue("balance", Balance);
            writer.WriteStringValue("blocked", Blocked);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteGuidValue("currencyId", CurrencyId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteGuidValue("id", Id);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PaymentMethod>("paymentMethod", PaymentMethod);
            writer.WriteGuidValue("paymentMethodId", PaymentMethodId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteGuidValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Picture>("picture", Picture);
            writer.WriteBoolValue("taxLiable", TaxLiable);
            writer.WriteStringValue("taxRegistrationNumber", TaxRegistrationNumber);
            writer.WriteStringValue("website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
