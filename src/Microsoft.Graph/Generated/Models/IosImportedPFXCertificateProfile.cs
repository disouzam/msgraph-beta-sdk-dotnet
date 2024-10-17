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
    /// iOS PFX Import certificate profile
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IosImportedPFXCertificateProfile : global::Microsoft.Graph.Beta.Models.IosCertificateProfile, IParsable
    {
        /// <summary>PFX Import Options.</summary>
        public global::Microsoft.Graph.Beta.Models.IntendedPurpose? IntendedPurpose
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IntendedPurpose?>("intendedPurpose"); }
            set { BackingStore?.Set("intendedPurpose", value); }
        }
        /// <summary>Certificate state for devices. This collection can contain a maximum of 2147483647 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>? ManagedDeviceCertificateStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>?>("managedDeviceCertificateStates"); }
            set { BackingStore?.Set("managedDeviceCertificateStates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState> ManagedDeviceCertificateStates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>>("managedDeviceCertificateStates"); }
            set { BackingStore?.Set("managedDeviceCertificateStates", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IosImportedPFXCertificateProfile"/> and sets the default values.
        /// </summary>
        public IosImportedPFXCertificateProfile() : base()
        {
            OdataType = "#microsoft.graph.iosImportedPFXCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IosImportedPFXCertificateProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IosImportedPFXCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IosImportedPFXCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "intendedPurpose", n => { IntendedPurpose = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.IntendedPurpose>(); } },
                { "managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>(global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.IntendedPurpose>("intendedPurpose", IntendedPurpose);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
        }
    }
}
#pragma warning restore CS0618
