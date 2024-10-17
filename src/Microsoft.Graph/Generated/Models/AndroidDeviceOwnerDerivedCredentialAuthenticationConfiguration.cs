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
    /// Android COBO Derived Credential profile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration : global::Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Certificate access type. Possible values are: userApproval, specificApps, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateAccessType? CertificateAccessType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateAccessType?>("certificateAccessType"); }
            set { BackingStore?.Set("certificateAccessType", value); }
        }
        /// <summary>Tenant level settings for the Derived Credentials to be used for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings? DerivedCredentialSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings?>("derivedCredentialSettings"); }
            set { BackingStore?.Set("derivedCredentialSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings DerivedCredentialSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings"); }
            set { BackingStore?.Set("derivedCredentialSettings", value); }
        }
#endif
        /// <summary>Certificate access information. This collection can contain a maximum of 50 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerSilentCertificateAccess>? SilentCertificateAccessDetails
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerSilentCertificateAccess>?>("silentCertificateAccessDetails"); }
            set { BackingStore?.Set("silentCertificateAccessDetails", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerSilentCertificateAccess> SilentCertificateAccessDetails
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerSilentCertificateAccess>>("silentCertificateAccessDetails"); }
            set { BackingStore?.Set("silentCertificateAccessDetails", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration"/> and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration() : base()
        {
            OdataType = "#microsoft.graph.androidDeviceOwnerDerivedCredentialAuthenticationConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certificateAccessType", n => { CertificateAccessType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateAccessType>(); } },
                { "derivedCredentialSettings", n => { DerivedCredentialSettings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings>(global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue); } },
                { "silentCertificateAccessDetails", n => { SilentCertificateAccessDetails = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerSilentCertificateAccess>(global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerSilentCertificateAccess.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateAccessType>("certificateAccessType", CertificateAccessType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings", DerivedCredentialSettings);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerSilentCertificateAccess>("silentCertificateAccessDetails", SilentCertificateAccessDetails);
        }
    }
}
#pragma warning restore CS0618
