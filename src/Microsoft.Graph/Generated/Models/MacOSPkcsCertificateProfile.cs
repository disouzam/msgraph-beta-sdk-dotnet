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
    /// MacOS PKCS certificate profile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MacOSPkcsCertificateProfile : global::Microsoft.Graph.Beta.Models.MacOSCertificateProfileBase, IParsable
    {
        /// <summary>AllowAllAppsAccess setting</summary>
        public bool? AllowAllAppsAccess
        {
            get { return BackingStore?.Get<bool?>("allowAllAppsAccess"); }
            set { BackingStore?.Set("allowAllAppsAccess", value); }
        }
        /// <summary>Target store certificate. Possible values are: user, machine.</summary>
        public global::Microsoft.Graph.Beta.Models.CertificateStore? CertificateStore
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CertificateStore?>("certificateStore"); }
            set { BackingStore?.Set("certificateStore", value); }
        }
        /// <summary>PKCS certificate template name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateTemplateName
        {
            get { return BackingStore?.Get<string?>("certificateTemplateName"); }
            set { BackingStore?.Set("certificateTemplateName", value); }
        }
#nullable restore
#else
        public string CertificateTemplateName
        {
            get { return BackingStore?.Get<string>("certificateTemplateName"); }
            set { BackingStore?.Set("certificateTemplateName", value); }
        }
#endif
        /// <summary>PKCS certification authority FQDN.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificationAuthority
        {
            get { return BackingStore?.Get<string?>("certificationAuthority"); }
            set { BackingStore?.Set("certificationAuthority", value); }
        }
#nullable restore
#else
        public string CertificationAuthority
        {
            get { return BackingStore?.Get<string>("certificationAuthority"); }
            set { BackingStore?.Set("certificationAuthority", value); }
        }
#endif
        /// <summary>PKCS certification authority Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificationAuthorityName
        {
            get { return BackingStore?.Get<string?>("certificationAuthorityName"); }
            set { BackingStore?.Set("certificationAuthorityName", value); }
        }
#nullable restore
#else
        public string CertificationAuthorityName
        {
            get { return BackingStore?.Get<string>("certificationAuthorityName"); }
            set { BackingStore?.Set("certificationAuthorityName", value); }
        }
#endif
        /// <summary>Custom Subject Alternative Name Settings. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>? CustomSubjectAlternativeNames
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>?>("customSubjectAlternativeNames"); }
            set { BackingStore?.Set("customSubjectAlternativeNames", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName> CustomSubjectAlternativeNames
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>>("customSubjectAlternativeNames"); }
            set { BackingStore?.Set("customSubjectAlternativeNames", value); }
        }
#endif
        /// <summary>Indicates the deployment channel type used to deploy the configuration profile. Possible values are deviceChannel, userChannel. Possible values are: deviceChannel, userChannel, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.AppleDeploymentChannel? DeploymentChannel
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AppleDeploymentChannel?>("deploymentChannel"); }
            set { BackingStore?.Set("deploymentChannel", value); }
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
        /// <summary>Format string that defines the subject alternative name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectAlternativeNameFormatString
        {
            get { return BackingStore?.Get<string?>("subjectAlternativeNameFormatString"); }
            set { BackingStore?.Set("subjectAlternativeNameFormatString", value); }
        }
#nullable restore
#else
        public string SubjectAlternativeNameFormatString
        {
            get { return BackingStore?.Get<string>("subjectAlternativeNameFormatString"); }
            set { BackingStore?.Set("subjectAlternativeNameFormatString", value); }
        }
#endif
        /// <summary>Format string that defines the subject name. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectNameFormatString
        {
            get { return BackingStore?.Get<string?>("subjectNameFormatString"); }
            set { BackingStore?.Set("subjectNameFormatString", value); }
        }
#nullable restore
#else
        public string SubjectNameFormatString
        {
            get { return BackingStore?.Get<string>("subjectNameFormatString"); }
            set { BackingStore?.Set("subjectNameFormatString", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MacOSPkcsCertificateProfile"/> and sets the default values.
        /// </summary>
        public MacOSPkcsCertificateProfile() : base()
        {
            OdataType = "#microsoft.graph.macOSPkcsCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MacOSPkcsCertificateProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MacOSPkcsCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MacOSPkcsCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowAllAppsAccess", n => { AllowAllAppsAccess = n.GetBoolValue(); } },
                { "certificateStore", n => { CertificateStore = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CertificateStore>(); } },
                { "certificateTemplateName", n => { CertificateTemplateName = n.GetStringValue(); } },
                { "certificationAuthority", n => { CertificationAuthority = n.GetStringValue(); } },
                { "certificationAuthorityName", n => { CertificationAuthorityName = n.GetStringValue(); } },
                { "customSubjectAlternativeNames", n => { CustomSubjectAlternativeNames = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>(global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deploymentChannel", n => { DeploymentChannel = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AppleDeploymentChannel>(); } },
                { "managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>(global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "subjectAlternativeNameFormatString", n => { SubjectAlternativeNameFormatString = n.GetStringValue(); } },
                { "subjectNameFormatString", n => { SubjectNameFormatString = n.GetStringValue(); } },
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
            writer.WriteBoolValue("allowAllAppsAccess", AllowAllAppsAccess);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CertificateStore>("certificateStore", CertificateStore);
            writer.WriteStringValue("certificateTemplateName", CertificateTemplateName);
            writer.WriteStringValue("certificationAuthority", CertificationAuthority);
            writer.WriteStringValue("certificationAuthorityName", CertificationAuthorityName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>("customSubjectAlternativeNames", CustomSubjectAlternativeNames);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AppleDeploymentChannel>("deploymentChannel", DeploymentChannel);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
            writer.WriteStringValue("subjectAlternativeNameFormatString", SubjectAlternativeNameFormatString);
            writer.WriteStringValue("subjectNameFormatString", SubjectNameFormatString);
        }
    }
}
#pragma warning restore CS0618
