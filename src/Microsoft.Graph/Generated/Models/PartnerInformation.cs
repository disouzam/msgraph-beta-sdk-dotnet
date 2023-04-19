using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PartnerInformation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The commerceUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommerceUrl {
            get { return BackingStore?.Get<string?>("commerceUrl"); }
            set { BackingStore?.Set("commerceUrl", value); }
        }
#nullable restore
#else
        public string CommerceUrl {
            get { return BackingStore?.Get<string>("commerceUrl"); }
            set { BackingStore?.Set("commerceUrl", value); }
        }
#endif
        /// <summary>The companyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName {
            get { return BackingStore?.Get<string?>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#nullable restore
#else
        public string CompanyName {
            get { return BackingStore?.Get<string>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#endif
        /// <summary>The companyType property</summary>
        public PartnerTenantType? CompanyType {
            get { return BackingStore?.Get<PartnerTenantType?>("companyType"); }
            set { BackingStore?.Set("companyType", value); }
        }
        /// <summary>The helpUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HelpUrl {
            get { return BackingStore?.Get<string?>("helpUrl"); }
            set { BackingStore?.Set("helpUrl", value); }
        }
#nullable restore
#else
        public string HelpUrl {
            get { return BackingStore?.Get<string>("helpUrl"); }
            set { BackingStore?.Set("helpUrl", value); }
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
        /// <summary>The partnerTenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PartnerTenantId {
            get { return BackingStore?.Get<string?>("partnerTenantId"); }
            set { BackingStore?.Set("partnerTenantId", value); }
        }
#nullable restore
#else
        public string PartnerTenantId {
            get { return BackingStore?.Get<string>("partnerTenantId"); }
            set { BackingStore?.Set("partnerTenantId", value); }
        }
#endif
        /// <summary>The supportEmails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportEmails {
            get { return BackingStore?.Get<List<string>?>("supportEmails"); }
            set { BackingStore?.Set("supportEmails", value); }
        }
#nullable restore
#else
        public List<string> SupportEmails {
            get { return BackingStore?.Get<List<string>>("supportEmails"); }
            set { BackingStore?.Set("supportEmails", value); }
        }
#endif
        /// <summary>The supportTelephones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportTelephones {
            get { return BackingStore?.Get<List<string>?>("supportTelephones"); }
            set { BackingStore?.Set("supportTelephones", value); }
        }
#nullable restore
#else
        public List<string> SupportTelephones {
            get { return BackingStore?.Get<List<string>>("supportTelephones"); }
            set { BackingStore?.Set("supportTelephones", value); }
        }
#endif
        /// <summary>The supportUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupportUrl {
            get { return BackingStore?.Get<string?>("supportUrl"); }
            set { BackingStore?.Set("supportUrl", value); }
        }
#nullable restore
#else
        public string SupportUrl {
            get { return BackingStore?.Get<string>("supportUrl"); }
            set { BackingStore?.Set("supportUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new partnerInformation and sets the default values.
        /// </summary>
        public PartnerInformation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PartnerInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PartnerInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"commerceUrl", n => { CommerceUrl = n.GetStringValue(); } },
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"companyType", n => { CompanyType = n.GetEnumValue<PartnerTenantType>(); } },
                {"helpUrl", n => { HelpUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"partnerTenantId", n => { PartnerTenantId = n.GetStringValue(); } },
                {"supportEmails", n => { SupportEmails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"supportTelephones", n => { SupportTelephones = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"supportUrl", n => { SupportUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("commerceUrl", CommerceUrl);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteEnumValue<PartnerTenantType>("companyType", CompanyType);
            writer.WriteStringValue("helpUrl", HelpUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("partnerTenantId", PartnerTenantId);
            writer.WriteCollectionOfPrimitiveValues<string>("supportEmails", SupportEmails);
            writer.WriteCollectionOfPrimitiveValues<string>("supportTelephones", SupportTelephones);
            writer.WriteStringValue("supportUrl", SupportUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
