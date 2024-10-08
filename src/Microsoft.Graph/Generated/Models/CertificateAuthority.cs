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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class CertificateAuthority : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Required. The base64 encoded string representing the public certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Certificate
        {
            get { return BackingStore?.Get<byte[]?>("certificate"); }
            set { BackingStore?.Set("certificate", value); }
        }
#nullable restore
#else
        public byte[] Certificate
        {
            get { return BackingStore?.Get<byte[]>("certificate"); }
            set { BackingStore?.Set("certificate", value); }
        }
#endif
        /// <summary>The URL of the certificate revocation list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateRevocationListUrl
        {
            get { return BackingStore?.Get<string?>("certificateRevocationListUrl"); }
            set { BackingStore?.Set("certificateRevocationListUrl", value); }
        }
#nullable restore
#else
        public string CertificateRevocationListUrl
        {
            get { return BackingStore?.Get<string>("certificateRevocationListUrl"); }
            set { BackingStore?.Set("certificateRevocationListUrl", value); }
        }
#endif
        /// <summary>The URL contains the list of all revoked certificates since the last time a full certificate revocaton list was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeltaCertificateRevocationListUrl
        {
            get { return BackingStore?.Get<string?>("deltaCertificateRevocationListUrl"); }
            set { BackingStore?.Set("deltaCertificateRevocationListUrl", value); }
        }
#nullable restore
#else
        public string DeltaCertificateRevocationListUrl
        {
            get { return BackingStore?.Get<string>("deltaCertificateRevocationListUrl"); }
            set { BackingStore?.Set("deltaCertificateRevocationListUrl", value); }
        }
#endif
        /// <summary>Required. true if the trusted certificate is a root authority, false if the trusted certificate is an intermediate authority.</summary>
        public bool? IsRootAuthority
        {
            get { return BackingStore?.Get<bool?>("isRootAuthority"); }
            set { BackingStore?.Set("isRootAuthority", value); }
        }
        /// <summary>The issuer of the certificate, calculated from the certificate value. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer
        {
            get { return BackingStore?.Get<string?>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#nullable restore
#else
        public string Issuer
        {
            get { return BackingStore?.Get<string>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#endif
        /// <summary>The subject key identifier of the certificate, calculated from the certificate value. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerSki
        {
            get { return BackingStore?.Get<string?>("issuerSki"); }
            set { BackingStore?.Set("issuerSki", value); }
        }
#nullable restore
#else
        public string IssuerSki
        {
            get { return BackingStore?.Get<string>("issuerSki"); }
            set { BackingStore?.Set("issuerSki", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CertificateAuthority"/> and sets the default values.
        /// </summary>
        public CertificateAuthority()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CertificateAuthority"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.CertificateAuthority CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CertificateAuthority();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "certificate", n => { Certificate = n.GetByteArrayValue(); } },
                { "certificateRevocationListUrl", n => { CertificateRevocationListUrl = n.GetStringValue(); } },
                { "deltaCertificateRevocationListUrl", n => { DeltaCertificateRevocationListUrl = n.GetStringValue(); } },
                { "isRootAuthority", n => { IsRootAuthority = n.GetBoolValue(); } },
                { "issuer", n => { Issuer = n.GetStringValue(); } },
                { "issuerSki", n => { IssuerSki = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("certificate", Certificate);
            writer.WriteStringValue("certificateRevocationListUrl", CertificateRevocationListUrl);
            writer.WriteStringValue("deltaCertificateRevocationListUrl", DeltaCertificateRevocationListUrl);
            writer.WriteBoolValue("isRootAuthority", IsRootAuthority);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("issuerSki", IssuerSki);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
