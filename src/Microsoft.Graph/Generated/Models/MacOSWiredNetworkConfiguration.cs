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
    /// MacOS wired network configuration profile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class MacOSWiredNetworkConfiguration : global::Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Authentication Method when EAP Type is configured to PEAP or EAP-TTLS. Possible values are: certificate, usernameAndPassword, derivedCredential.</summary>
        public global::Microsoft.Graph.Beta.Models.WiFiAuthenticationMethod? AuthenticationMethod
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WiFiAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Indicates the deployment channel type used to deploy the configuration profile. Possible values are deviceChannel, userChannel. Possible values are: deviceChannel, userChannel, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.AppleDeploymentChannel? DeploymentChannel
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AppleDeploymentChannel?>("deploymentChannel"); }
            set { BackingStore?.Set("deploymentChannel", value); }
        }
        /// <summary>EAP-FAST Configuration Option when EAP-FAST is the selected EAP Type. Possible values are: noProtectedAccessCredential, useProtectedAccessCredential, useProtectedAccessCredentialAndProvision, useProtectedAccessCredentialAndProvisionAnonymously.</summary>
        public global::Microsoft.Graph.Beta.Models.EapFastConfiguration? EapFastConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EapFastConfiguration?>("eapFastConfiguration"); }
            set { BackingStore?.Set("eapFastConfiguration", value); }
        }
        /// <summary>Extensible Authentication Protocol (EAP) configuration types.</summary>
        public global::Microsoft.Graph.Beta.Models.EapType? EapType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EapType?>("eapType"); }
            set { BackingStore?.Set("eapType", value); }
        }
        /// <summary>Enable identity privacy (Outer Identity) when EAP Type is configured to EAP-TTLS, EAP-FAST or PEAP. This property masks usernames with the text you enter. For example, if you use &apos;anonymous&apos;, each user that authenticates with this wired network using their real username is displayed as &apos;anonymous&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnableOuterIdentityPrivacy
        {
            get { return BackingStore?.Get<string?>("enableOuterIdentityPrivacy"); }
            set { BackingStore?.Set("enableOuterIdentityPrivacy", value); }
        }
#nullable restore
#else
        public string EnableOuterIdentityPrivacy
        {
            get { return BackingStore?.Get<string>("enableOuterIdentityPrivacy"); }
            set { BackingStore?.Set("enableOuterIdentityPrivacy", value); }
        }
#endif
        /// <summary>Identity Certificate for client authentication when EAP Type is configured to EAP-TLS, EAP-TTLS (with Certificate Authentication), or PEAP (with Certificate Authentication).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MacOSCertificateProfileBase? IdentityCertificateForClientAuthentication
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MacOSCertificateProfileBase?>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MacOSCertificateProfileBase IdentityCertificateForClientAuthentication
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MacOSCertificateProfileBase>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#endif
        /// <summary>Apple network interface type.</summary>
        public global::Microsoft.Graph.Beta.Models.WiredNetworkInterface? NetworkInterface
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WiredNetworkInterface?>("networkInterface"); }
            set { BackingStore?.Set("networkInterface", value); }
        }
        /// <summary>Network Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkName
        {
            get { return BackingStore?.Get<string?>("networkName"); }
            set { BackingStore?.Set("networkName", value); }
        }
#nullable restore
#else
        public string NetworkName
        {
            get { return BackingStore?.Get<string>("networkName"); }
            set { BackingStore?.Set("networkName", value); }
        }
#endif
        /// <summary>Non-EAP Method for Authentication (Inner Identity) when EAP Type is EAP-TTLS and Authenticationmethod is Username and Password. Possible values are: unencryptedPassword, challengeHandshakeAuthenticationProtocol, microsoftChap, microsoftChapVersionTwo.</summary>
        public global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForEapTtlsType? NonEapAuthenticationMethodForEapTtls
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForEapTtlsType?>("nonEapAuthenticationMethodForEapTtls"); }
            set { BackingStore?.Set("nonEapAuthenticationMethodForEapTtls", value); }
        }
        /// <summary>Trusted Root Certificate for Server Validation when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MacOSTrustedRootCertificate? RootCertificateForServerValidation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MacOSTrustedRootCertificate?>("rootCertificateForServerValidation"); }
            set { BackingStore?.Set("rootCertificateForServerValidation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MacOSTrustedRootCertificate RootCertificateForServerValidation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MacOSTrustedRootCertificate>("rootCertificateForServerValidation"); }
            set { BackingStore?.Set("rootCertificateForServerValidation", value); }
        }
#endif
        /// <summary>Trusted server certificate names when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP. This is the common name used in the certificates issued by your trusted certificate authority (CA). If you provide this information, you can bypass the dynamic trust dialog that is displayed on end users devices when they connect to this wired network.</summary>
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
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MacOSWiredNetworkConfiguration"/> and sets the default values.
        /// </summary>
        public MacOSWiredNetworkConfiguration() : base()
        {
            OdataType = "#microsoft.graph.macOSWiredNetworkConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MacOSWiredNetworkConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MacOSWiredNetworkConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MacOSWiredNetworkConfiguration();
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
                { "deploymentChannel", n => { DeploymentChannel = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AppleDeploymentChannel>(); } },
                { "eapFastConfiguration", n => { EapFastConfiguration = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.EapFastConfiguration>(); } },
                { "eapType", n => { EapType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.EapType>(); } },
                { "enableOuterIdentityPrivacy", n => { EnableOuterIdentityPrivacy = n.GetStringValue(); } },
                { "identityCertificateForClientAuthentication", n => { IdentityCertificateForClientAuthentication = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MacOSCertificateProfileBase>(global::Microsoft.Graph.Beta.Models.MacOSCertificateProfileBase.CreateFromDiscriminatorValue); } },
                { "networkInterface", n => { NetworkInterface = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.WiredNetworkInterface>(); } },
                { "networkName", n => { NetworkName = n.GetStringValue(); } },
                { "nonEapAuthenticationMethodForEapTtls", n => { NonEapAuthenticationMethodForEapTtls = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForEapTtlsType>(); } },
                { "rootCertificateForServerValidation", n => { RootCertificateForServerValidation = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MacOSTrustedRootCertificate>(global::Microsoft.Graph.Beta.Models.MacOSTrustedRootCertificate.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AppleDeploymentChannel>("deploymentChannel", DeploymentChannel);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.EapFastConfiguration>("eapFastConfiguration", EapFastConfiguration);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.EapType>("eapType", EapType);
            writer.WriteStringValue("enableOuterIdentityPrivacy", EnableOuterIdentityPrivacy);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MacOSCertificateProfileBase>("identityCertificateForClientAuthentication", IdentityCertificateForClientAuthentication);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.WiredNetworkInterface>("networkInterface", NetworkInterface);
            writer.WriteStringValue("networkName", NetworkName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.NonEapAuthenticationMethodForEapTtlsType>("nonEapAuthenticationMethodForEapTtls", NonEapAuthenticationMethodForEapTtls);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MacOSTrustedRootCertificate>("rootCertificateForServerValidation", RootCertificateForServerValidation);
            writer.WriteCollectionOfPrimitiveValues<string>("trustedServerCertificateNames", TrustedServerCertificateNames);
        }
    }
}
#pragma warning restore CS0618
