// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Ios Scep Certificate Profile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IosScepCertificateProfile>))]
    public partial class IosScepCertificateProfile : IosCertificateProfileBase
    {
    
        ///<summary>
        /// The IosScepCertificateProfile constructor
        ///</summary>
        public IosScepCertificateProfile()
        {
            this.ODataType = "microsoft.graph.iosScepCertificateProfile";
        }

        /// <summary>
        /// Gets or sets certificate store.
        /// Target store certificate. Possible values are: user, machine.
        /// </summary>
        [JsonPropertyName("certificateStore")]
        public CertificateStore? CertificateStore { get; set; }
    
        /// <summary>
        /// Gets or sets custom subject alternative names.
        /// Custom Subject Alternative Name Settings. The OnPremisesUserPrincipalName variable is support as well as others documented here: http://go.microsoft.com/fwlink/?LinkId=2027630. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("customSubjectAlternativeNames")]
        public IEnumerable<CustomSubjectAlternativeName> CustomSubjectAlternativeNames { get; set; }
    
        /// <summary>
        /// Gets or sets extended key usages.
        /// Extended Key Usage (EKU) settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("extendedKeyUsages")]
        public IEnumerable<ExtendedKeyUsage> ExtendedKeyUsages { get; set; }
    
        /// <summary>
        /// Gets or sets key size.
        /// SCEP Key Size. Possible values are: size1024, size2048, size4096.
        /// </summary>
        [JsonPropertyName("keySize")]
        public KeySize? KeySize { get; set; }
    
        /// <summary>
        /// Gets or sets key usage.
        /// SCEP Key Usage. Possible values are: keyEncipherment, digitalSignature.
        /// </summary>
        [JsonPropertyName("keyUsage")]
        public KeyUsages? KeyUsage { get; set; }
    
        /// <summary>
        /// Gets or sets scep server urls.
        /// SCEP Server Url(s).
        /// </summary>
        [JsonPropertyName("scepServerUrls")]
        public IEnumerable<string> ScepServerUrls { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name format string.
        /// Custom String that defines the AAD Attribute.
        /// </summary>
        [JsonPropertyName("subjectAlternativeNameFormatString")]
        public string SubjectAlternativeNameFormatString { get; set; }
    
        /// <summary>
        /// Gets or sets subject name format string.
        /// Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US
        /// </summary>
        [JsonPropertyName("subjectNameFormatString")]
        public string SubjectNameFormatString { get; set; }
    
        /// <summary>
        /// Gets or sets managed device certificate states.
        /// Certificate state for devices
        /// </summary>
        [JsonPropertyName("managedDeviceCertificateStates")]
        public IIosScepCertificateProfileManagedDeviceCertificateStatesCollectionPage ManagedDeviceCertificateStates { get; set; }

        /// <summary>
        /// Gets or sets managedDeviceCertificateStatesNextLink.
        /// </summary>
        [JsonPropertyName("managedDeviceCertificateStates@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ManagedDeviceCertificateStatesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets root certificate.
        /// Trusted Root Certificate.
        /// </summary>
        [JsonPropertyName("rootCertificate")]
        public IosTrustedRootCertificate RootCertificate { get; set; }
    
    }
}

