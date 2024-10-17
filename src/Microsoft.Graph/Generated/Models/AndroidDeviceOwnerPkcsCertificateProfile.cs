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
    /// Android Device Owner PKCS certificate profile
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AndroidDeviceOwnerPkcsCertificateProfile : global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateProfileBase, IParsable
    {
        /// <summary>Certificate access type. Possible values are: userApproval, specificApps, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateAccessType? CertificateAccessType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateAccessType?>("certificateAccessType"); }
            set { BackingStore?.Set("certificateAccessType", value); }
        }
        /// <summary>CertificateStore types</summary>
        public global::Microsoft.Graph.Beta.Models.CertificateStore? CertificateStore
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CertificateStore?>("certificateStore"); }
            set { BackingStore?.Set("certificateStore", value); }
        }
        /// <summary>PKCS Certificate Template Name</summary>
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
        /// <summary>PKCS Certification Authority</summary>
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
        /// <summary>PKCS Certification Authority Name</summary>
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
        /// <summary>Device Management Certification Authority Types.</summary>
        public global::Microsoft.Graph.Beta.Models.DeviceManagementCertificationAuthority? CertificationAuthorityType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagementCertificationAuthority?>("certificationAuthorityType"); }
            set { BackingStore?.Set("certificationAuthorityType", value); }
        }
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
        /// <summary>Custom String that defines the AAD Attribute.</summary>
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
        /// <summary>Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US</summary>
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
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerPkcsCertificateProfile"/> and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerPkcsCertificateProfile() : base()
        {
            OdataType = "#microsoft.graph.androidDeviceOwnerPkcsCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerPkcsCertificateProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerPkcsCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerPkcsCertificateProfile();
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
                { "certificateStore", n => { CertificateStore = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CertificateStore>(); } },
                { "certificateTemplateName", n => { CertificateTemplateName = n.GetStringValue(); } },
                { "certificationAuthority", n => { CertificationAuthority = n.GetStringValue(); } },
                { "certificationAuthorityName", n => { CertificationAuthorityName = n.GetStringValue(); } },
                { "certificationAuthorityType", n => { CertificationAuthorityType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.DeviceManagementCertificationAuthority>(); } },
                { "customSubjectAlternativeNames", n => { CustomSubjectAlternativeNames = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>(global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>(global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.AsList(); } },
                { "silentCertificateAccessDetails", n => { SilentCertificateAccessDetails = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerSilentCertificateAccess>(global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerSilentCertificateAccess.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerCertificateAccessType>("certificateAccessType", CertificateAccessType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CertificateStore>("certificateStore", CertificateStore);
            writer.WriteStringValue("certificateTemplateName", CertificateTemplateName);
            writer.WriteStringValue("certificationAuthority", CertificationAuthority);
            writer.WriteStringValue("certificationAuthorityName", CertificationAuthorityName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.DeviceManagementCertificationAuthority>("certificationAuthorityType", CertificationAuthorityType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>("customSubjectAlternativeNames", CustomSubjectAlternativeNames);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerSilentCertificateAccess>("silentCertificateAccessDetails", SilentCertificateAccessDetails);
            writer.WriteStringValue("subjectAlternativeNameFormatString", SubjectAlternativeNameFormatString);
            writer.WriteStringValue("subjectNameFormatString", SubjectNameFormatString);
        }
    }
}
#pragma warning restore CS0618
