// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Windows 8.1 Trusted Certificate configuration profile
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class Windows81TrustedRootCertificate : global::Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>File name to display in UI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertFileName
        {
            get { return BackingStore?.Get<string?>("certFileName"); }
            set { BackingStore?.Set("certFileName", value); }
        }
#nullable restore
#else
        public string CertFileName
        {
            get { return BackingStore?.Get<string>("certFileName"); }
            set { BackingStore?.Set("certFileName", value); }
        }
#endif
        /// <summary>Possible values for the Certificate Destination Store.</summary>
        public global::Microsoft.Graph.Beta.Models.CertificateDestinationStore? DestinationStore
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CertificateDestinationStore?>("destinationStore"); }
            set { BackingStore?.Set("destinationStore", value); }
        }
        /// <summary>Trusted Root Certificate</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? TrustedRootCertificate
        {
            get { return BackingStore?.Get<byte[]?>("trustedRootCertificate"); }
            set { BackingStore?.Set("trustedRootCertificate", value); }
        }
#nullable restore
#else
        public byte[] TrustedRootCertificate
        {
            get { return BackingStore?.Get<byte[]>("trustedRootCertificate"); }
            set { BackingStore?.Set("trustedRootCertificate", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Windows81TrustedRootCertificate"/> and sets the default values.
        /// </summary>
        public Windows81TrustedRootCertificate() : base()
        {
            OdataType = "#microsoft.graph.windows81TrustedRootCertificate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Windows81TrustedRootCertificate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Windows81TrustedRootCertificate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Windows81TrustedRootCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certFileName", n => { CertFileName = n.GetStringValue(); } },
                { "destinationStore", n => { DestinationStore = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CertificateDestinationStore>(); } },
                { "trustedRootCertificate", n => { TrustedRootCertificate = n.GetByteArrayValue(); } },
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
            writer.WriteStringValue("certFileName", CertFileName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CertificateDestinationStore>("destinationStore", DestinationStore);
            writer.WriteByteArrayValue("trustedRootCertificate", TrustedRootCertificate);
        }
    }
}
#pragma warning restore CS0618
