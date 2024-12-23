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
    /// Entity that represents a collection of metadata of a cloud certification authority.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CloudCertificationAuthority : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The URL to download the certification authority certificate. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateDownloadUrl
        {
            get { return BackingStore?.Get<string?>("certificateDownloadUrl"); }
            set { BackingStore?.Set("certificateDownloadUrl", value); }
        }
#nullable restore
#else
        public string CertificateDownloadUrl
        {
            get { return BackingStore?.Get<string>("certificateDownloadUrl"); }
            set { BackingStore?.Set("certificateDownloadUrl", value); }
        }
#endif
        /// <summary>Enum of possible cloud certification authority certificate cryptography and key size combinations.</summary>
        public global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityCertificateKeySize? CertificateKeySize
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityCertificateKeySize?>("certificateKeySize"); }
            set { BackingStore?.Set("certificateKeySize", value); }
        }
        /// <summary>The cloud certification authority&apos;s Certificate Revocation List URL that can be used to determine revocation status. Read-only.</summary>
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
        /// <summary>The certificate signing request used to create an issuing certification authority with a root certification authority external to Microsoft Cloud PKI. The based-64 encoded certificate signing request can be downloaded through this property. After downloading the certificate signing request, it must be signed by the external root certifcation authority. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateSigningRequest
        {
            get { return BackingStore?.Get<string?>("certificateSigningRequest"); }
            set { BackingStore?.Set("certificateSigningRequest", value); }
        }
#nullable restore
#else
        public string CertificateSigningRequest
        {
            get { return BackingStore?.Get<string>("certificateSigningRequest"); }
            set { BackingStore?.Set("certificateSigningRequest", value); }
        }
#endif
        /// <summary>Issuer (parent) certification authority identifier. Nullable. Read-only. Supports $orderby and $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificationAuthorityIssuerId
        {
            get { return BackingStore?.Get<string?>("certificationAuthorityIssuerId"); }
            set { BackingStore?.Set("certificationAuthorityIssuerId", value); }
        }
#nullable restore
#else
        public string CertificationAuthorityIssuerId
        {
            get { return BackingStore?.Get<string>("certificationAuthorityIssuerId"); }
            set { BackingStore?.Set("certificationAuthorityIssuerId", value); }
        }
#endif
        /// <summary>The URI of the issuing certification authority of a subordinate certification authority. Returns null if a root certification authority. Nullable. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificationAuthorityIssuerUri
        {
            get { return BackingStore?.Get<string?>("certificationAuthorityIssuerUri"); }
            set { BackingStore?.Set("certificationAuthorityIssuerUri", value); }
        }
#nullable restore
#else
        public string CertificationAuthorityIssuerUri
        {
            get { return BackingStore?.Get<string>("certificationAuthorityIssuerUri"); }
            set { BackingStore?.Set("certificationAuthorityIssuerUri", value); }
        }
#endif
        /// <summary>Enum type of possible certification authority statuses. These statuses indicate whether a certification authority is currently able to issue certificates or temporarily paused or permanently revoked.</summary>
        public global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityStatus? CertificationAuthorityStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityStatus?>("certificationAuthorityStatus"); }
            set { BackingStore?.Set("certificationAuthorityStatus", value); }
        }
        /// <summary>Enum type of possible certificate hashing algorithms used by the certification authority to create certificates.</summary>
        public global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityHashingAlgorithm? CloudCertificationAuthorityHashingAlgorithm
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityHashingAlgorithm?>("cloudCertificationAuthorityHashingAlgorithm"); }
            set { BackingStore?.Set("cloudCertificationAuthorityHashingAlgorithm", value); }
        }
        /// <summary>Required OData property to expose leaf certificate API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityLeafCertificate>? CloudCertificationAuthorityLeafCertificate
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityLeafCertificate>?>("cloudCertificationAuthorityLeafCertificate"); }
            set { BackingStore?.Set("cloudCertificationAuthorityLeafCertificate", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityLeafCertificate> CloudCertificationAuthorityLeafCertificate
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityLeafCertificate>>("cloudCertificationAuthorityLeafCertificate"); }
            set { BackingStore?.Set("cloudCertificationAuthorityLeafCertificate", value); }
        }
#endif
        /// <summary>Enum type of possible certificate authority types. This feature supports a two-tier certification authority model with a root certification authority and one or more child issuing (intermediate) certification authorities.</summary>
        public global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityType? CloudCertificationAuthorityType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityType?>("cloudCertificationAuthorityType"); }
            set { BackingStore?.Set("cloudCertificationAuthorityType", value); }
        }
        /// <summary>The common name of the certificate subject name, which must be unique. This property is a relative distinguished name used to compose the certificate subject name. Read-only. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommonName
        {
            get { return BackingStore?.Get<string?>("commonName"); }
            set { BackingStore?.Set("commonName", value); }
        }
#nullable restore
#else
        public string CommonName
        {
            get { return BackingStore?.Get<string>("commonName"); }
            set { BackingStore?.Set("commonName", value); }
        }
#endif
        /// <summary>The country name that is used to compose the subject name of a certification authority certificate in the form &apos;C=&apos;. Nullable. Example: US. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryName
        {
            get { return BackingStore?.Get<string?>("countryName"); }
            set { BackingStore?.Set("countryName", value); }
        }
#nullable restore
#else
        public string CountryName
        {
            get { return BackingStore?.Get<string>("countryName"); }
            set { BackingStore?.Set("countryName", value); }
        }
#endif
        /// <summary>Creation date of this cloud certification authority entity instance. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Nullable. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The certification authority description displayed in the Intune admin console. Nullable. Read/write. Returns null if not set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The certification authority display name the Intune admin console. Read/write. Supports $select and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>ETag for optimistic concurrency control. Read/write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ETag
        {
            get { return BackingStore?.Get<string?>("eTag"); }
            set { BackingStore?.Set("eTag", value); }
        }
#nullable restore
#else
        public string ETag
        {
            get { return BackingStore?.Get<string>("eTag"); }
            set { BackingStore?.Set("eTag", value); }
        }
#endif
        /// <summary>The certificate extended key usages, which specify the usage capabilities of the certificate. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage>? ExtendedKeyUsages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage>?>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage> ExtendedKeyUsages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage>>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#endif
        /// <summary>The issuerCommonName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerCommonName
        {
            get { return BackingStore?.Get<string?>("issuerCommonName"); }
            set { BackingStore?.Set("issuerCommonName", value); }
        }
#nullable restore
#else
        public string IssuerCommonName
        {
            get { return BackingStore?.Get<string>("issuerCommonName"); }
            set { BackingStore?.Set("issuerCommonName", value); }
        }
#endif
        /// <summary>Enum type of possible key platforms used by the certification authority.</summary>
        public global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityKeyPlatformType? KeyPlatform
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityKeyPlatformType?>("keyPlatform"); }
            set { BackingStore?.Set("keyPlatform", value); }
        }
        /// <summary>Last modification date and time of this certification authority entity instance. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Nullable. Read/write.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The locality (town, city, etc.) name that is used to compose the subject name of a certification authority certificate in the form &apos;L=&apos;. This is Nullable. Example: Redmond. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalityName
        {
            get { return BackingStore?.Get<string?>("localityName"); }
            set { BackingStore?.Set("localityName", value); }
        }
#nullable restore
#else
        public string LocalityName
        {
            get { return BackingStore?.Get<string>("localityName"); }
            set { BackingStore?.Set("localityName", value); }
        }
#endif
        /// <summary>The Online Certificate Status Protocol (OCSP) responder URI that can be used to determine certificate status. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OcspResponderUri
        {
            get { return BackingStore?.Get<string?>("ocspResponderUri"); }
            set { BackingStore?.Set("ocspResponderUri", value); }
        }
#nullable restore
#else
        public string OcspResponderUri
        {
            get { return BackingStore?.Get<string>("ocspResponderUri"); }
            set { BackingStore?.Set("ocspResponderUri", value); }
        }
#endif
        /// <summary>The organization name that is used as a distinguished name in the subject name of a certification authority certificate in the form &apos;O=&apos;. Nullable. Example: Microsoft. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationName
        {
            get { return BackingStore?.Get<string?>("organizationName"); }
            set { BackingStore?.Set("organizationName", value); }
        }
#nullable restore
#else
        public string OrganizationName
        {
            get { return BackingStore?.Get<string>("organizationName"); }
            set { BackingStore?.Set("organizationName", value); }
        }
#endif
        /// <summary>The organization unit name that is used as a distinguished name in the subject name of a certification authority certificate in the form &apos;OU=&apos;. Nullable. Example: Security. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationUnit
        {
            get { return BackingStore?.Get<string?>("organizationUnit"); }
            set { BackingStore?.Set("organizationUnit", value); }
        }
#nullable restore
#else
        public string OrganizationUnit
        {
            get { return BackingStore?.Get<string>("organizationUnit"); }
            set { BackingStore?.Set("organizationUnit", value); }
        }
#endif
        /// <summary>List of Scope Tags for this entity instance. Scope tags limit access to an entity instance. Nullable. Read/write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>The common name of the certificate subject name of the certification authority issuer. This property can be used to identify the certification authority that issued the current certification authority. For issuing certification authorities, this is the common name of the certificate subject name of the root certification authority to which it is anchored. For externally signed certification authorities, this is the common name of the certificate subject name of the signing certification authority. For root certification authorities, this is the common name of the certification authority&apos;s own certificate subject name. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RootCertificateCommonName
        {
            get { return BackingStore?.Get<string?>("rootCertificateCommonName"); }
            set { BackingStore?.Set("rootCertificateCommonName", value); }
        }
#nullable restore
#else
        public string RootCertificateCommonName
        {
            get { return BackingStore?.Get<string>("rootCertificateCommonName"); }
            set { BackingStore?.Set("rootCertificateCommonName", value); }
        }
#endif
        /// <summary>The SCEP server URL for device SCEP connections to request certificates. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScepServerUrl
        {
            get { return BackingStore?.Get<string?>("scepServerUrl"); }
            set { BackingStore?.Set("scepServerUrl", value); }
        }
#nullable restore
#else
        public string ScepServerUrl
        {
            get { return BackingStore?.Get<string>("scepServerUrl"); }
            set { BackingStore?.Set("scepServerUrl", value); }
        }
#endif
        /// <summary>The serial number used to uniquely identify a certificate with its issuing certification authority. Read-only. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber
        {
            get { return BackingStore?.Get<string?>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#nullable restore
#else
        public string SerialNumber
        {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#endif
        /// <summary>The state or province name that is used to compose the subject name of a certification authority certificate in the form &apos;ST=&apos;. Nullable. Example: Washington. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateName
        {
            get { return BackingStore?.Get<string?>("stateName"); }
            set { BackingStore?.Set("stateName", value); }
        }
#nullable restore
#else
        public string StateName
        {
            get { return BackingStore?.Get<string>("stateName"); }
            set { BackingStore?.Set("stateName", value); }
        }
#endif
        /// <summary>The subject name of the certificate. The subject is the target or intended beneficiary of the security being provided, such as a company or government entity. Read-only. Supports $orderby and $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectName
        {
            get { return BackingStore?.Get<string?>("subjectName"); }
            set { BackingStore?.Set("subjectName", value); }
        }
#nullable restore
#else
        public string SubjectName
        {
            get { return BackingStore?.Get<string>("subjectName"); }
            set { BackingStore?.Set("subjectName", value); }
        }
#endif
        /// <summary>Secure Hash Algorithm 1 digest of the certificate that can be used to identify it. Read-only. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Thumbprint
        {
            get { return BackingStore?.Get<string?>("thumbprint"); }
            set { BackingStore?.Set("thumbprint", value); }
        }
#nullable restore
#else
        public string Thumbprint
        {
            get { return BackingStore?.Get<string>("thumbprint"); }
            set { BackingStore?.Set("thumbprint", value); }
        }
#endif
        /// <summary>The end date time of the validity period of a certification authority certificate. Certificates cannot be used after this date time as they are longer valid. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Nullable. Read-only. Supports $orderby.</summary>
        public DateTimeOffset? ValidityEndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("validityEndDateTime"); }
            set { BackingStore?.Set("validityEndDateTime", value); }
        }
        /// <summary>The certification authority validity period in years configured by admins.</summary>
        public int? ValidityPeriodInYears
        {
            get { return BackingStore?.Get<int?>("validityPeriodInYears"); }
            set { BackingStore?.Set("validityPeriodInYears", value); }
        }
        /// <summary>The start date time of the validity period of a certification authority certificate. Certificates cannot be used before this date time as they are not yet valid. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Nullable. Read-only. Supports $orderby.</summary>
        public DateTimeOffset? ValidityStartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("validityStartDateTime"); }
            set { BackingStore?.Set("validityStartDateTime", value); }
        }
        /// <summary>The certification authority version, which is incremented each time the certification authority is renewed. Read-only.</summary>
        public int? VersionNumber
        {
            get { return BackingStore?.Get<int?>("versionNumber"); }
            set { BackingStore?.Set("versionNumber", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudCertificationAuthority"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CloudCertificationAuthority CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CloudCertificationAuthority();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certificateDownloadUrl", n => { CertificateDownloadUrl = n.GetStringValue(); } },
                { "certificateKeySize", n => { CertificateKeySize = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityCertificateKeySize>(); } },
                { "certificateRevocationListUrl", n => { CertificateRevocationListUrl = n.GetStringValue(); } },
                { "certificateSigningRequest", n => { CertificateSigningRequest = n.GetStringValue(); } },
                { "certificationAuthorityIssuerId", n => { CertificationAuthorityIssuerId = n.GetStringValue(); } },
                { "certificationAuthorityIssuerUri", n => { CertificationAuthorityIssuerUri = n.GetStringValue(); } },
                { "certificationAuthorityStatus", n => { CertificationAuthorityStatus = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityStatus>(); } },
                { "cloudCertificationAuthorityHashingAlgorithm", n => { CloudCertificationAuthorityHashingAlgorithm = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityHashingAlgorithm>(); } },
                { "cloudCertificationAuthorityLeafCertificate", n => { CloudCertificationAuthorityLeafCertificate = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityLeafCertificate>(global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityLeafCertificate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "cloudCertificationAuthorityType", n => { CloudCertificationAuthorityType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityType>(); } },
                { "commonName", n => { CommonName = n.GetStringValue(); } },
                { "countryName", n => { CountryName = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "eTag", n => { ETag = n.GetStringValue(); } },
                { "extendedKeyUsages", n => { ExtendedKeyUsages = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage>(global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "issuerCommonName", n => { IssuerCommonName = n.GetStringValue(); } },
                { "keyPlatform", n => { KeyPlatform = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityKeyPlatformType>(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "localityName", n => { LocalityName = n.GetStringValue(); } },
                { "ocspResponderUri", n => { OcspResponderUri = n.GetStringValue(); } },
                { "organizationName", n => { OrganizationName = n.GetStringValue(); } },
                { "organizationUnit", n => { OrganizationUnit = n.GetStringValue(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "rootCertificateCommonName", n => { RootCertificateCommonName = n.GetStringValue(); } },
                { "scepServerUrl", n => { ScepServerUrl = n.GetStringValue(); } },
                { "serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                { "stateName", n => { StateName = n.GetStringValue(); } },
                { "subjectName", n => { SubjectName = n.GetStringValue(); } },
                { "thumbprint", n => { Thumbprint = n.GetStringValue(); } },
                { "validityEndDateTime", n => { ValidityEndDateTime = n.GetDateTimeOffsetValue(); } },
                { "validityPeriodInYears", n => { ValidityPeriodInYears = n.GetIntValue(); } },
                { "validityStartDateTime", n => { ValidityStartDateTime = n.GetDateTimeOffsetValue(); } },
                { "versionNumber", n => { VersionNumber = n.GetIntValue(); } },
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
            writer.WriteStringValue("certificateDownloadUrl", CertificateDownloadUrl);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityCertificateKeySize>("certificateKeySize", CertificateKeySize);
            writer.WriteStringValue("certificateRevocationListUrl", CertificateRevocationListUrl);
            writer.WriteStringValue("certificateSigningRequest", CertificateSigningRequest);
            writer.WriteStringValue("certificationAuthorityIssuerId", CertificationAuthorityIssuerId);
            writer.WriteStringValue("certificationAuthorityIssuerUri", CertificationAuthorityIssuerUri);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityStatus>("certificationAuthorityStatus", CertificationAuthorityStatus);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityHashingAlgorithm>("cloudCertificationAuthorityHashingAlgorithm", CloudCertificationAuthorityHashingAlgorithm);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityLeafCertificate>("cloudCertificationAuthorityLeafCertificate", CloudCertificationAuthorityLeafCertificate);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityType>("cloudCertificationAuthorityType", CloudCertificationAuthorityType);
            writer.WriteStringValue("commonName", CommonName);
            writer.WriteStringValue("countryName", CountryName);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("eTag", ETag);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExtendedKeyUsage>("extendedKeyUsages", ExtendedKeyUsages);
            writer.WriteStringValue("issuerCommonName", IssuerCommonName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudCertificationAuthorityKeyPlatformType>("keyPlatform", KeyPlatform);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("localityName", LocalityName);
            writer.WriteStringValue("ocspResponderUri", OcspResponderUri);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteStringValue("organizationUnit", OrganizationUnit);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteStringValue("rootCertificateCommonName", RootCertificateCommonName);
            writer.WriteStringValue("scepServerUrl", ScepServerUrl);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("stateName", StateName);
            writer.WriteStringValue("subjectName", SubjectName);
            writer.WriteStringValue("thumbprint", Thumbprint);
            writer.WriteDateTimeOffsetValue("validityEndDateTime", ValidityEndDateTime);
            writer.WriteIntValue("validityPeriodInYears", ValidityPeriodInYears);
            writer.WriteDateTimeOffsetValue("validityStartDateTime", ValidityStartDateTime);
            writer.WriteIntValue("versionNumber", VersionNumber);
        }
    }
}
#pragma warning restore CS0618
