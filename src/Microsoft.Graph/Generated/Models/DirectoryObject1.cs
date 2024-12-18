// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DirectoryObject1 : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Conceptual container for user and group directory objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AdministrativeUnit>? AdministrativeUnits
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AdministrativeUnit>?>("administrativeUnits"); }
            set { BackingStore?.Set("administrativeUnits", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AdministrativeUnit> AdministrativeUnits
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AdministrativeUnit>>("administrativeUnits"); }
            set { BackingStore?.Set("administrativeUnits", value); }
        }
#endif
        /// <summary>Group of related custom security attribute definitions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AttributeSet>? AttributeSets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AttributeSet>?>("attributeSets"); }
            set { BackingStore?.Set("attributeSets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AttributeSet> AttributeSets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AttributeSet>>("attributeSets"); }
            set { BackingStore?.Set("attributeSets", value); }
        }
#endif
        /// <summary>Exposes the hardware OATH method in the directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AuthenticationMethodDevice? AuthenticationMethodDevices
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationMethodDevice?>("authenticationMethodDevices"); }
            set { BackingStore?.Set("authenticationMethodDevices", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AuthenticationMethodDevice AuthenticationMethodDevices
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationMethodDevice>("authenticationMethodDevices"); }
            set { BackingStore?.Set("authenticationMethodDevices", value); }
        }
#endif
        /// <summary>The certificateAuthorities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CertificateAuthorityPath? CertificateAuthorities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CertificateAuthorityPath?>("certificateAuthorities"); }
            set { BackingStore?.Set("certificateAuthorities", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CertificateAuthorityPath CertificateAuthorities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CertificateAuthorityPath>("certificateAuthorities"); }
            set { BackingStore?.Set("certificateAuthorities", value); }
        }
#endif
        /// <summary>Schema of a custom security attributes (key-value pairs).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CustomSecurityAttributeDefinition>? CustomSecurityAttributeDefinitions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomSecurityAttributeDefinition>?>("customSecurityAttributeDefinitions"); }
            set { BackingStore?.Set("customSecurityAttributeDefinitions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CustomSecurityAttributeDefinition> CustomSecurityAttributeDefinitions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomSecurityAttributeDefinition>>("customSecurityAttributeDefinitions"); }
            set { BackingStore?.Set("customSecurityAttributeDefinitions", value); }
        }
#endif
        /// <summary>Recently deleted items. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DirectoryObject>? DeletedItems
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DirectoryObject>?>("deletedItems"); }
            set { BackingStore?.Set("deletedItems", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DirectoryObject> DeletedItems
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DirectoryObject>>("deletedItems"); }
            set { BackingStore?.Set("deletedItems", value); }
        }
#endif
        /// <summary>The credentials of the device&apos;s local administrator account backed up to Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceLocalCredentialInfo>? DeviceLocalCredentials
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceLocalCredentialInfo>?>("deviceLocalCredentials"); }
            set { BackingStore?.Set("deviceLocalCredentials", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceLocalCredentialInfo> DeviceLocalCredentials
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceLocalCredentialInfo>>("deviceLocalCredentials"); }
            set { BackingStore?.Set("deviceLocalCredentials", value); }
        }
#endif
        /// <summary>Collection of external user profiles that represent collaborators in the directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ExternalUserProfile>? ExternalUserProfiles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExternalUserProfile>?>("externalUserProfiles"); }
            set { BackingStore?.Set("externalUserProfiles", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ExternalUserProfile> ExternalUserProfiles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExternalUserProfile>>("externalUserProfiles"); }
            set { BackingStore?.Set("externalUserProfiles", value); }
        }
#endif
        /// <summary>The featureRolloutPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.FeatureRolloutPolicy>? FeatureRolloutPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.FeatureRolloutPolicy>?>("featureRolloutPolicies"); }
            set { BackingStore?.Set("featureRolloutPolicies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.FeatureRolloutPolicy> FeatureRolloutPolicies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.FeatureRolloutPolicy>>("featureRolloutPolicies"); }
            set { BackingStore?.Set("featureRolloutPolicies", value); }
        }
#endif
        /// <summary>Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IdentityProviderBase>? FederationConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityProviderBase>?>("federationConfigurations"); }
            set { BackingStore?.Set("federationConfigurations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IdentityProviderBase> FederationConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityProviderBase>>("federationConfigurations"); }
            set { BackingStore?.Set("federationConfigurations", value); }
        }
#endif
        /// <summary>The impactedResources property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ImpactedResource>? ImpactedResources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ImpactedResource>?>("impactedResources"); }
            set { BackingStore?.Set("impactedResources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ImpactedResource> ImpactedResources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ImpactedResource>>("impactedResources"); }
            set { BackingStore?.Set("impactedResources", value); }
        }
#endif
        /// <summary>A collection of external users whose profile data is shared with the Microsoft Entra tenant. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.InboundSharedUserProfile>? InboundSharedUserProfiles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.InboundSharedUserProfile>?>("inboundSharedUserProfiles"); }
            set { BackingStore?.Set("inboundSharedUserProfiles", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.InboundSharedUserProfile> InboundSharedUserProfiles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.InboundSharedUserProfile>>("inboundSharedUserProfiles"); }
            set { BackingStore?.Set("inboundSharedUserProfiles", value); }
        }
#endif
        /// <summary>A container for on-premises directory synchronization functionalities that are available for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.OnPremisesDirectorySynchronization>? OnPremisesSynchronization
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OnPremisesDirectorySynchronization>?>("onPremisesSynchronization"); }
            set { BackingStore?.Set("onPremisesSynchronization", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.OnPremisesDirectorySynchronization> OnPremisesSynchronization
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OnPremisesDirectorySynchronization>>("onPremisesSynchronization"); }
            set { BackingStore?.Set("onPremisesSynchronization", value); }
        }
#endif
        /// <summary>The outboundSharedUserProfiles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.OutboundSharedUserProfile>? OutboundSharedUserProfiles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OutboundSharedUserProfile>?>("outboundSharedUserProfiles"); }
            set { BackingStore?.Set("outboundSharedUserProfiles", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.OutboundSharedUserProfile> OutboundSharedUserProfiles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OutboundSharedUserProfile>>("outboundSharedUserProfiles"); }
            set { BackingStore?.Set("outboundSharedUserProfiles", value); }
        }
#endif
        /// <summary>Collection of pending external user profiles representing collaborators in the directory that are unredeemed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.PendingExternalUserProfile>? PendingExternalUserProfiles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PendingExternalUserProfile>?>("pendingExternalUserProfiles"); }
            set { BackingStore?.Set("pendingExternalUserProfiles", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.PendingExternalUserProfile> PendingExternalUserProfiles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PendingExternalUserProfile>>("pendingExternalUserProfiles"); }
            set { BackingStore?.Set("pendingExternalUserProfiles", value); }
        }
#endif
        /// <summary>The collection of public key infrastructure instances for the certificate-based authentication feature for users in a Microsoft Entra tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PublicKeyInfrastructureRoot? PublicKeyInfrastructure
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PublicKeyInfrastructureRoot?>("publicKeyInfrastructure"); }
            set { BackingStore?.Set("publicKeyInfrastructure", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PublicKeyInfrastructureRoot PublicKeyInfrastructure
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PublicKeyInfrastructureRoot>("publicKeyInfrastructure"); }
            set { BackingStore?.Set("publicKeyInfrastructure", value); }
        }
#endif
        /// <summary>List of recommended improvements to improve tenant posture.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Recommendation>? Recommendations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Recommendation>?>("recommendations"); }
            set { BackingStore?.Set("recommendations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Recommendation> Recommendations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Recommendation>>("recommendations"); }
            set { BackingStore?.Set("recommendations", value); }
        }
#endif
        /// <summary>The sharedEmailDomains property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.SharedEmailDomain>? SharedEmailDomains
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SharedEmailDomain>?>("sharedEmailDomains"); }
            set { BackingStore?.Set("sharedEmailDomains", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.SharedEmailDomain> SharedEmailDomains
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SharedEmailDomain>>("sharedEmailDomains"); }
            set { BackingStore?.Set("sharedEmailDomains", value); }
        }
#endif
        /// <summary>List of commercial subscriptions that an organization has.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CompanySubscription>? Subscriptions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CompanySubscription>?>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CompanySubscription> Subscriptions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CompanySubscription>>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
#endif
        /// <summary>The templates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Template? Templates
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Template?>("templates"); }
            set { BackingStore?.Set("templates", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Template Templates
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Template>("templates"); }
            set { BackingStore?.Set("templates", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DirectoryObject1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DirectoryObject1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DirectoryObject1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "administrativeUnits", n => { AdministrativeUnits = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AdministrativeUnit>(global::Microsoft.Graph.Beta.Models.AdministrativeUnit.CreateFromDiscriminatorValue)?.AsList(); } },
                { "attributeSets", n => { AttributeSets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AttributeSet>(global::Microsoft.Graph.Beta.Models.AttributeSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "authenticationMethodDevices", n => { AuthenticationMethodDevices = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AuthenticationMethodDevice>(global::Microsoft.Graph.Beta.Models.AuthenticationMethodDevice.CreateFromDiscriminatorValue); } },
                { "certificateAuthorities", n => { CertificateAuthorities = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CertificateAuthorityPath>(global::Microsoft.Graph.Beta.Models.CertificateAuthorityPath.CreateFromDiscriminatorValue); } },
                { "customSecurityAttributeDefinitions", n => { CustomSecurityAttributeDefinitions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomSecurityAttributeDefinition>(global::Microsoft.Graph.Beta.Models.CustomSecurityAttributeDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deletedItems", n => { DeletedItems = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DirectoryObject>(global::Microsoft.Graph.Beta.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deviceLocalCredentials", n => { DeviceLocalCredentials = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceLocalCredentialInfo>(global::Microsoft.Graph.Beta.Models.DeviceLocalCredentialInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "externalUserProfiles", n => { ExternalUserProfiles = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExternalUserProfile>(global::Microsoft.Graph.Beta.Models.ExternalUserProfile.CreateFromDiscriminatorValue)?.AsList(); } },
                { "featureRolloutPolicies", n => { FeatureRolloutPolicies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.FeatureRolloutPolicy>(global::Microsoft.Graph.Beta.Models.FeatureRolloutPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "federationConfigurations", n => { FederationConfigurations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityProviderBase>(global::Microsoft.Graph.Beta.Models.IdentityProviderBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "impactedResources", n => { ImpactedResources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ImpactedResource>(global::Microsoft.Graph.Beta.Models.ImpactedResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "inboundSharedUserProfiles", n => { InboundSharedUserProfiles = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.InboundSharedUserProfile>(global::Microsoft.Graph.Beta.Models.InboundSharedUserProfile.CreateFromDiscriminatorValue)?.AsList(); } },
                { "onPremisesSynchronization", n => { OnPremisesSynchronization = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OnPremisesDirectorySynchronization>(global::Microsoft.Graph.Beta.Models.OnPremisesDirectorySynchronization.CreateFromDiscriminatorValue)?.AsList(); } },
                { "outboundSharedUserProfiles", n => { OutboundSharedUserProfiles = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OutboundSharedUserProfile>(global::Microsoft.Graph.Beta.Models.OutboundSharedUserProfile.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pendingExternalUserProfiles", n => { PendingExternalUserProfiles = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PendingExternalUserProfile>(global::Microsoft.Graph.Beta.Models.PendingExternalUserProfile.CreateFromDiscriminatorValue)?.AsList(); } },
                { "publicKeyInfrastructure", n => { PublicKeyInfrastructure = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PublicKeyInfrastructureRoot>(global::Microsoft.Graph.Beta.Models.PublicKeyInfrastructureRoot.CreateFromDiscriminatorValue); } },
                { "recommendations", n => { Recommendations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Recommendation>(global::Microsoft.Graph.Beta.Models.Recommendation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sharedEmailDomains", n => { SharedEmailDomains = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SharedEmailDomain>(global::Microsoft.Graph.Beta.Models.SharedEmailDomain.CreateFromDiscriminatorValue)?.AsList(); } },
                { "subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CompanySubscription>(global::Microsoft.Graph.Beta.Models.CompanySubscription.CreateFromDiscriminatorValue)?.AsList(); } },
                { "templates", n => { Templates = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Template>(global::Microsoft.Graph.Beta.Models.Template.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AdministrativeUnit>("administrativeUnits", AdministrativeUnits);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AttributeSet>("attributeSets", AttributeSets);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AuthenticationMethodDevice>("authenticationMethodDevices", AuthenticationMethodDevices);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CertificateAuthorityPath>("certificateAuthorities", CertificateAuthorities);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomSecurityAttributeDefinition>("customSecurityAttributeDefinitions", CustomSecurityAttributeDefinitions);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DirectoryObject>("deletedItems", DeletedItems);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceLocalCredentialInfo>("deviceLocalCredentials", DeviceLocalCredentials);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExternalUserProfile>("externalUserProfiles", ExternalUserProfiles);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.FeatureRolloutPolicy>("featureRolloutPolicies", FeatureRolloutPolicies);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityProviderBase>("federationConfigurations", FederationConfigurations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ImpactedResource>("impactedResources", ImpactedResources);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.InboundSharedUserProfile>("inboundSharedUserProfiles", InboundSharedUserProfiles);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OnPremisesDirectorySynchronization>("onPremisesSynchronization", OnPremisesSynchronization);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OutboundSharedUserProfile>("outboundSharedUserProfiles", OutboundSharedUserProfiles);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PendingExternalUserProfile>("pendingExternalUserProfiles", PendingExternalUserProfiles);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PublicKeyInfrastructureRoot>("publicKeyInfrastructure", PublicKeyInfrastructure);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Recommendation>("recommendations", Recommendations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SharedEmailDomain>("sharedEmailDomains", SharedEmailDomains);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CompanySubscription>("subscriptions", Subscriptions);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Template>("templates", Templates);
        }
    }
}
#pragma warning restore CS0618
