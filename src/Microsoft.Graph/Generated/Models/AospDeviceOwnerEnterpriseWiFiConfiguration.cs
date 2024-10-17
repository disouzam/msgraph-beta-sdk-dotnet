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
    /// By providing the configurations in this profile you can instruct the AOSP Device Owner device to connect to desired Wi-Fi endpoint. By specifying the authentication method and security types expected by Wi-Fi endpoint you can make the Wi-Fi connection seamless for end user.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AospDeviceOwnerEnterpriseWiFiConfiguration : global::Microsoft.Graph.Beta.Models.AospDeviceOwnerWiFiConfiguration, IParsable
    {
        /// <summary>Indicates the Authentication Method the client (device) needs to use when the EAP Type is configured to PEAP or EAP-TTLS. Possible values are: certificate, usernameAndPassword, derivedCredential.</summary>
        public global::Microsoft.Graph.Beta.Models.WiFiAuthenticationMethod? AuthenticationMethod
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WiFiAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Extensible Authentication Protocol (EAP) Configuration Types.</summary>
        public global::Microsoft.Graph.Beta.Models.AndroidEapType? EapType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidEapType?>("eapType"); }
            set { BackingStore?.Set("eapType", value); }
        }
        /// <summary>Identity Certificate for client authentication when EAP Type is configured to EAP-TLS, EAP-TTLS (with Certificate Authentication), or PEAP (with Certificate Authentication). This is the certificate presented by client to the Wi-Fi endpoint. The authentication server sitting behind the Wi-Fi endpoint must accept this certificate to successfully establish a Wi-Fi connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AospDeviceOwnerCertificateProfileBase? IdentityCertificateForClientAuthentication
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AospDeviceOwnerCertificateProfileBase?>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AospDeviceOwnerCertificateProfileBase IdentityCertificateForClientAuthentication
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AospDeviceOwnerCertificateProfileBase>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#endif
        /// <summary>Non-EAP Method for Authentication (Inner Identity) when EAP Type is EAP-TTLS and Authenticationmethod is Username and Password. Possible values are: unencryptedPassword, challengeHandshakeAuthenticationProtocol, microsoftChap, microsoftChapVersionTwo.</summary>
        public global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForEapTtlsType? InnerAuthenticationProtocolForEapTtls
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForEapTtlsType?>("innerAuthenticationProtocolForEapTtls"); }
            set { BackingStore?.Set("innerAuthenticationProtocolForEapTtls", value); }
        }
        /// <summary>Non-EAP Method for Authentication (Inner Identity) when EAP Type is PEAP and Authenticationmethod is Username and Password. This collection can contain a maximum of 500 elements. Possible values are: none, microsoftChapVersionTwo.</summary>
        public global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForPeap? InnerAuthenticationProtocolForPeap
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForPeap?>("innerAuthenticationProtocolForPeap"); }
            set { BackingStore?.Set("innerAuthenticationProtocolForPeap", value); }
        }
        /// <summary>Enable identity privacy (Outer Identity) when EAP Type is configured to EAP-TTLS or PEAP. The String provided here is used to mask the username of individual users when they attempt to connect to Wi-Fi network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OuterIdentityPrivacyTemporaryValue
        {
            get { return BackingStore?.Get<string?>("outerIdentityPrivacyTemporaryValue"); }
            set { BackingStore?.Set("outerIdentityPrivacyTemporaryValue", value); }
        }
#nullable restore
#else
        public string OuterIdentityPrivacyTemporaryValue
        {
            get { return BackingStore?.Get<string>("outerIdentityPrivacyTemporaryValue"); }
            set { BackingStore?.Set("outerIdentityPrivacyTemporaryValue", value); }
        }
#endif
        /// <summary>Trusted Root Certificate for Server Validation when EAP Type is configured to EAP-TLS, EAP-TTLS or PEAP. This is the certificate presented by the Wi-Fi endpoint when the device attempts to connect to Wi-Fi endpoint. The device (or user) must accept this certificate to continue the connection attempt.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AospDeviceOwnerTrustedRootCertificate? RootCertificateForServerValidation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AospDeviceOwnerTrustedRootCertificate?>("rootCertificateForServerValidation"); }
            set { BackingStore?.Set("rootCertificateForServerValidation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AospDeviceOwnerTrustedRootCertificate RootCertificateForServerValidation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AospDeviceOwnerTrustedRootCertificate>("rootCertificateForServerValidation"); }
            set { BackingStore?.Set("rootCertificateForServerValidation", value); }
        }
#endif
        /// <summary>Trusted server certificate names when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP. This is the common name used in the certificates issued by your trusted certificate authority (CA). If you provide this information, you can bypass the dynamic trust dialog that is displayed on end users&apos; devices when they connect to this Wi-Fi network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TrustedServerCertificateNames
        {
            get { return BackingStore?.Get<List<string>?>("trustedServerCertificateNames"); }
            set { BackingStore?.Set("trustedServerCertificateNames", value); }
        }
#nullable restore
#else
        public List<string> TrustedServerCertificateNames
        {
            get { return BackingStore?.Get<List<string>>("trustedServerCertificateNames"); }
            set { BackingStore?.Set("trustedServerCertificateNames", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AospDeviceOwnerEnterpriseWiFiConfiguration"/> and sets the default values.
        /// </summary>
        public AospDeviceOwnerEnterpriseWiFiConfiguration() : base()
        {
            OdataType = "#microsoft.graph.aospDeviceOwnerEnterpriseWiFiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AospDeviceOwnerEnterpriseWiFiConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AospDeviceOwnerEnterpriseWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AospDeviceOwnerEnterpriseWiFiConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.WiFiAuthenticationMethod>(); } },
                { "eapType", n => { EapType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AndroidEapType>(); } },
                { "identityCertificateForClientAuthentication", n => { IdentityCertificateForClientAuthentication = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AospDeviceOwnerCertificateProfileBase>(global::Microsoft.Graph.Beta.Models.AospDeviceOwnerCertificateProfileBase.CreateFromDiscriminatorValue); } },
                { "innerAuthenticationProtocolForEapTtls", n => { InnerAuthenticationProtocolForEapTtls = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForEapTtlsType>(); } },
                { "innerAuthenticationProtocolForPeap", n => { InnerAuthenticationProtocolForPeap = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForPeap>(); } },
                { "outerIdentityPrivacyTemporaryValue", n => { OuterIdentityPrivacyTemporaryValue = n.GetStringValue(); } },
                { "rootCertificateForServerValidation", n => { RootCertificateForServerValidation = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AospDeviceOwnerTrustedRootCertificate>(global::Microsoft.Graph.Beta.Models.AospDeviceOwnerTrustedRootCertificate.CreateFromDiscriminatorValue); } },
                { "trustedServerCertificateNames", n => { TrustedServerCertificateNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.WiFiAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AndroidEapType>("eapType", EapType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AospDeviceOwnerCertificateProfileBase>("identityCertificateForClientAuthentication", IdentityCertificateForClientAuthentication);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForEapTtlsType>("innerAuthenticationProtocolForEapTtls", InnerAuthenticationProtocolForEapTtls);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForPeap>("innerAuthenticationProtocolForPeap", InnerAuthenticationProtocolForPeap);
            writer.WriteStringValue("outerIdentityPrivacyTemporaryValue", OuterIdentityPrivacyTemporaryValue);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AospDeviceOwnerTrustedRootCertificate>("rootCertificateForServerValidation", RootCertificateForServerValidation);
            writer.WriteCollectionOfPrimitiveValues<string>("trustedServerCertificateNames", TrustedServerCertificateNames);
        }
    }
}
#pragma warning restore CS0618
