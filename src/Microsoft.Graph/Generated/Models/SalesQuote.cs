using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class SalesQuote : Entity, IParsable {
        /// <summary>The acceptedDate property</summary>
        public Date? AcceptedDate {
            get { return BackingStore?.Get<Date?>(nameof(AcceptedDate)); }
            set { BackingStore?.Set(nameof(AcceptedDate), value); }
        }
        /// <summary>The billingPostalAddress property</summary>
        public PostalAddressType BillingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>(nameof(BillingPostalAddress)); }
            set { BackingStore?.Set(nameof(BillingPostalAddress), value); }
        }
        /// <summary>The billToCustomerId property</summary>
        public string BillToCustomerId {
            get { return BackingStore?.Get<string>(nameof(BillToCustomerId)); }
            set { BackingStore?.Set(nameof(BillToCustomerId), value); }
        }
        /// <summary>The billToCustomerNumber property</summary>
        public string BillToCustomerNumber {
            get { return BackingStore?.Get<string>(nameof(BillToCustomerNumber)); }
            set { BackingStore?.Set(nameof(BillToCustomerNumber), value); }
        }
        /// <summary>The billToName property</summary>
        public string BillToName {
            get { return BackingStore?.Get<string>(nameof(BillToName)); }
            set { BackingStore?.Set(nameof(BillToName), value); }
        }
        /// <summary>The currency property</summary>
        public Microsoft.Graph.Beta.Models.Currency Currency {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Currency>(nameof(Currency)); }
            set { BackingStore?.Set(nameof(Currency), value); }
        }
        /// <summary>The currencyCode property</summary>
        public string CurrencyCode {
            get { return BackingStore?.Get<string>(nameof(CurrencyCode)); }
            set { BackingStore?.Set(nameof(CurrencyCode), value); }
        }
        /// <summary>The currencyId property</summary>
        public string CurrencyId {
            get { return BackingStore?.Get<string>(nameof(CurrencyId)); }
            set { BackingStore?.Set(nameof(CurrencyId), value); }
        }
        /// <summary>The customer property</summary>
        public Microsoft.Graph.Beta.Models.Customer Customer {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Customer>(nameof(Customer)); }
            set { BackingStore?.Set(nameof(Customer), value); }
        }
        /// <summary>The customerId property</summary>
        public string CustomerId {
            get { return BackingStore?.Get<string>(nameof(CustomerId)); }
            set { BackingStore?.Set(nameof(CustomerId), value); }
        }
        /// <summary>The customerName property</summary>
        public string CustomerName {
            get { return BackingStore?.Get<string>(nameof(CustomerName)); }
            set { BackingStore?.Set(nameof(CustomerName), value); }
        }
        /// <summary>The customerNumber property</summary>
        public string CustomerNumber {
            get { return BackingStore?.Get<string>(nameof(CustomerNumber)); }
            set { BackingStore?.Set(nameof(CustomerNumber), value); }
        }
        /// <summary>The discountAmount property</summary>
        public decimal? DiscountAmount {
            get { return BackingStore?.Get<decimal?>(nameof(DiscountAmount)); }
            set { BackingStore?.Set(nameof(DiscountAmount), value); }
        }
        /// <summary>The documentDate property</summary>
        public Date? DocumentDate {
            get { return BackingStore?.Get<Date?>(nameof(DocumentDate)); }
            set { BackingStore?.Set(nameof(DocumentDate), value); }
        }
        /// <summary>The dueDate property</summary>
        public Date? DueDate {
            get { return BackingStore?.Get<Date?>(nameof(DueDate)); }
            set { BackingStore?.Set(nameof(DueDate), value); }
        }
        /// <summary>The email property</summary>
        public string Email {
            get { return BackingStore?.Get<string>(nameof(Email)); }
            set { BackingStore?.Set(nameof(Email), value); }
        }
        /// <summary>The externalDocumentNumber property</summary>
        public string ExternalDocumentNumber {
            get { return BackingStore?.Get<string>(nameof(ExternalDocumentNumber)); }
            set { BackingStore?.Set(nameof(ExternalDocumentNumber), value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The number property</summary>
        public string Number {
            get { return BackingStore?.Get<string>(nameof(Number)); }
            set { BackingStore?.Set(nameof(Number), value); }
        }
        /// <summary>The paymentTerm property</summary>
        public Microsoft.Graph.Beta.Models.PaymentTerm PaymentTerm {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PaymentTerm>(nameof(PaymentTerm)); }
            set { BackingStore?.Set(nameof(PaymentTerm), value); }
        }
        /// <summary>The paymentTermsId property</summary>
        public string PaymentTermsId {
            get { return BackingStore?.Get<string>(nameof(PaymentTermsId)); }
            set { BackingStore?.Set(nameof(PaymentTermsId), value); }
        }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber {
            get { return BackingStore?.Get<string>(nameof(PhoneNumber)); }
            set { BackingStore?.Set(nameof(PhoneNumber), value); }
        }
        /// <summary>The salesperson property</summary>
        public string Salesperson {
            get { return BackingStore?.Get<string>(nameof(Salesperson)); }
            set { BackingStore?.Set(nameof(Salesperson), value); }
        }
        /// <summary>The salesQuoteLines property</summary>
        public List<SalesQuoteLine> SalesQuoteLines {
            get { return BackingStore?.Get<List<SalesQuoteLine>>(nameof(SalesQuoteLines)); }
            set { BackingStore?.Set(nameof(SalesQuoteLines), value); }
        }
        /// <summary>The sellingPostalAddress property</summary>
        public PostalAddressType SellingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>(nameof(SellingPostalAddress)); }
            set { BackingStore?.Set(nameof(SellingPostalAddress), value); }
        }
        /// <summary>The sentDate property</summary>
        public DateTimeOffset? SentDate {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(SentDate)); }
            set { BackingStore?.Set(nameof(SentDate), value); }
        }
        /// <summary>The shipmentMethod property</summary>
        public Microsoft.Graph.Beta.Models.ShipmentMethod ShipmentMethod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ShipmentMethod>(nameof(ShipmentMethod)); }
            set { BackingStore?.Set(nameof(ShipmentMethod), value); }
        }
        /// <summary>The shipmentMethodId property</summary>
        public string ShipmentMethodId {
            get { return BackingStore?.Get<string>(nameof(ShipmentMethodId)); }
            set { BackingStore?.Set(nameof(ShipmentMethodId), value); }
        }
        /// <summary>The shippingPostalAddress property</summary>
        public PostalAddressType ShippingPostalAddress {
            get { return BackingStore?.Get<PostalAddressType>(nameof(ShippingPostalAddress)); }
            set { BackingStore?.Set(nameof(ShippingPostalAddress), value); }
        }
        /// <summary>The shipToContact property</summary>
        public string ShipToContact {
            get { return BackingStore?.Get<string>(nameof(ShipToContact)); }
            set { BackingStore?.Set(nameof(ShipToContact), value); }
        }
        /// <summary>The shipToName property</summary>
        public string ShipToName {
            get { return BackingStore?.Get<string>(nameof(ShipToName)); }
            set { BackingStore?.Set(nameof(ShipToName), value); }
        }
        /// <summary>The status property</summary>
        public string Status {
            get { return BackingStore?.Get<string>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The totalAmountExcludingTax property</summary>
        public decimal? TotalAmountExcludingTax {
            get { return BackingStore?.Get<decimal?>(nameof(TotalAmountExcludingTax)); }
            set { BackingStore?.Set(nameof(TotalAmountExcludingTax), value); }
        }
        /// <summary>The totalAmountIncludingTax property</summary>
        public decimal? TotalAmountIncludingTax {
            get { return BackingStore?.Get<decimal?>(nameof(TotalAmountIncludingTax)); }
            set { BackingStore?.Set(nameof(TotalAmountIncludingTax), value); }
        }
        /// <summary>The totalTaxAmount property</summary>
        public decimal? TotalTaxAmount {
            get { return BackingStore?.Get<decimal?>(nameof(TotalTaxAmount)); }
            set { BackingStore?.Set(nameof(TotalTaxAmount), value); }
        }
        /// <summary>The validUntilDate property</summary>
        public Date? ValidUntilDate {
            get { return BackingStore?.Get<Date?>(nameof(ValidUntilDate)); }
            set { BackingStore?.Set(nameof(ValidUntilDate), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SalesQuote CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SalesQuote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acceptedDate", n => { AcceptedDate = n.GetDateValue(); } },
                {"billingPostalAddress", n => { BillingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"billToCustomerId", n => { BillToCustomerId = n.GetStringValue(); } },
                {"billToCustomerNumber", n => { BillToCustomerNumber = n.GetStringValue(); } },
                {"billToName", n => { BillToName = n.GetStringValue(); } },
                {"currency", n => { Currency = n.GetObjectValue<Microsoft.Graph.Beta.Models.Currency>(Microsoft.Graph.Beta.Models.Currency.CreateFromDiscriminatorValue); } },
                {"currencyCode", n => { CurrencyCode = n.GetStringValue(); } },
                {"currencyId", n => { CurrencyId = n.GetStringValue(); } },
                {"customer", n => { Customer = n.GetObjectValue<Microsoft.Graph.Beta.Models.Customer>(Microsoft.Graph.Beta.Models.Customer.CreateFromDiscriminatorValue); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"customerName", n => { CustomerName = n.GetStringValue(); } },
                {"customerNumber", n => { CustomerNumber = n.GetStringValue(); } },
                {"discountAmount", n => { DiscountAmount = n.GetDecimalValue(); } },
                {"documentDate", n => { DocumentDate = n.GetDateValue(); } },
                {"dueDate", n => { DueDate = n.GetDateValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"externalDocumentNumber", n => { ExternalDocumentNumber = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"number", n => { Number = n.GetStringValue(); } },
                {"paymentTerm", n => { PaymentTerm = n.GetObjectValue<Microsoft.Graph.Beta.Models.PaymentTerm>(Microsoft.Graph.Beta.Models.PaymentTerm.CreateFromDiscriminatorValue); } },
                {"paymentTermsId", n => { PaymentTermsId = n.GetStringValue(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"salesperson", n => { Salesperson = n.GetStringValue(); } },
                {"salesQuoteLines", n => { SalesQuoteLines = n.GetCollectionOfObjectValues<SalesQuoteLine>(SalesQuoteLine.CreateFromDiscriminatorValue).ToList(); } },
                {"sellingPostalAddress", n => { SellingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"sentDate", n => { SentDate = n.GetDateTimeOffsetValue(); } },
                {"shipmentMethod", n => { ShipmentMethod = n.GetObjectValue<Microsoft.Graph.Beta.Models.ShipmentMethod>(Microsoft.Graph.Beta.Models.ShipmentMethod.CreateFromDiscriminatorValue); } },
                {"shipmentMethodId", n => { ShipmentMethodId = n.GetStringValue(); } },
                {"shippingPostalAddress", n => { ShippingPostalAddress = n.GetObjectValue<PostalAddressType>(PostalAddressType.CreateFromDiscriminatorValue); } },
                {"shipToContact", n => { ShipToContact = n.GetStringValue(); } },
                {"shipToName", n => { ShipToName = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"totalAmountExcludingTax", n => { TotalAmountExcludingTax = n.GetDecimalValue(); } },
                {"totalAmountIncludingTax", n => { TotalAmountIncludingTax = n.GetDecimalValue(); } },
                {"totalTaxAmount", n => { TotalTaxAmount = n.GetDecimalValue(); } },
                {"validUntilDate", n => { ValidUntilDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateValue("acceptedDate", AcceptedDate);
            writer.WriteObjectValue<PostalAddressType>("billingPostalAddress", BillingPostalAddress);
            writer.WriteStringValue("billToCustomerId", BillToCustomerId);
            writer.WriteStringValue("billToCustomerNumber", BillToCustomerNumber);
            writer.WriteStringValue("billToName", BillToName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Currency>("currency", Currency);
            writer.WriteStringValue("currencyCode", CurrencyCode);
            writer.WriteStringValue("currencyId", CurrencyId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Customer>("customer", Customer);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteStringValue("customerName", CustomerName);
            writer.WriteStringValue("customerNumber", CustomerNumber);
            writer.WriteDecimalValue("discountAmount", DiscountAmount);
            writer.WriteDateValue("documentDate", DocumentDate);
            writer.WriteDateValue("dueDate", DueDate);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("externalDocumentNumber", ExternalDocumentNumber);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("number", Number);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PaymentTerm>("paymentTerm", PaymentTerm);
            writer.WriteStringValue("paymentTermsId", PaymentTermsId);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteStringValue("salesperson", Salesperson);
            writer.WriteCollectionOfObjectValues<SalesQuoteLine>("salesQuoteLines", SalesQuoteLines);
            writer.WriteObjectValue<PostalAddressType>("sellingPostalAddress", SellingPostalAddress);
            writer.WriteDateTimeOffsetValue("sentDate", SentDate);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ShipmentMethod>("shipmentMethod", ShipmentMethod);
            writer.WriteStringValue("shipmentMethodId", ShipmentMethodId);
            writer.WriteObjectValue<PostalAddressType>("shippingPostalAddress", ShippingPostalAddress);
            writer.WriteStringValue("shipToContact", ShipToContact);
            writer.WriteStringValue("shipToName", ShipToName);
            writer.WriteStringValue("status", Status);
            writer.WriteDecimalValue("totalAmountExcludingTax", TotalAmountExcludingTax);
            writer.WriteDecimalValue("totalAmountIncludingTax", TotalAmountIncludingTax);
            writer.WriteDecimalValue("totalTaxAmount", TotalTaxAmount);
            writer.WriteDateValue("validUntilDate", ValidUntilDate);
        }
    }
}
