// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class CrossTenantAccessPolicyConfigurationDefault : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Determines the default configuration for automatic user consent settings. The inboundAllowed and outboundAllowed properties are always false and can&apos;t be updated in the default configuration. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.InboundOutboundPolicyConfiguration? AutomaticUserConsentSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.InboundOutboundPolicyConfiguration?>("automaticUserConsentSettings"); }
            set { BackingStore?.Set("automaticUserConsentSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.InboundOutboundPolicyConfiguration AutomaticUserConsentSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.InboundOutboundPolicyConfiguration>("automaticUserConsentSettings"); }
            set { BackingStore?.Set("automaticUserConsentSettings", value); }
        }
#endif
        /// <summary>Defines your default configuration for users from other organizations accessing your resources via Microsoft Entra B2B collaboration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting? B2bCollaborationInbound
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting?>("b2bCollaborationInbound"); }
            set { BackingStore?.Set("b2bCollaborationInbound", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting B2bCollaborationInbound
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>("b2bCollaborationInbound"); }
            set { BackingStore?.Set("b2bCollaborationInbound", value); }
        }
#endif
        /// <summary>Defines your default configuration for users in your organization going outbound to access resources in another organization via Microsoft Entra B2B collaboration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting? B2bCollaborationOutbound
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting?>("b2bCollaborationOutbound"); }
            set { BackingStore?.Set("b2bCollaborationOutbound", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting B2bCollaborationOutbound
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>("b2bCollaborationOutbound"); }
            set { BackingStore?.Set("b2bCollaborationOutbound", value); }
        }
#endif
        /// <summary>Defines your default configuration for users from other organizations accessing your resources via Microsoft Entra B2B direct connect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting? B2bDirectConnectInbound
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting?>("b2bDirectConnectInbound"); }
            set { BackingStore?.Set("b2bDirectConnectInbound", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting B2bDirectConnectInbound
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectInbound"); }
            set { BackingStore?.Set("b2bDirectConnectInbound", value); }
        }
#endif
        /// <summary>Defines your default configuration for users in your organization going outbound to access resources in another organization via Microsoft Entra B2B direct connect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting? B2bDirectConnectOutbound
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting?>("b2bDirectConnectOutbound"); }
            set { BackingStore?.Set("b2bDirectConnectOutbound", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting B2bDirectConnectOutbound
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectOutbound"); }
            set { BackingStore?.Set("b2bDirectConnectOutbound", value); }
        }
#endif
        /// <summary>Determines the default configuration for trusting other Conditional Access claims from external Microsoft Entra organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyInboundTrust? InboundTrust
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyInboundTrust?>("inboundTrust"); }
            set { BackingStore?.Set("inboundTrust", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyInboundTrust InboundTrust
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyInboundTrust>("inboundTrust"); }
            set { BackingStore?.Set("inboundTrust", value); }
        }
#endif
        /// <summary>Defines the priority order based on which an identity provider is selected during invitation redemption for a guest user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DefaultInvitationRedemptionIdentityProviderConfiguration? InvitationRedemptionIdentityProviderConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DefaultInvitationRedemptionIdentityProviderConfiguration?>("invitationRedemptionIdentityProviderConfiguration"); }
            set { BackingStore?.Set("invitationRedemptionIdentityProviderConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DefaultInvitationRedemptionIdentityProviderConfiguration InvitationRedemptionIdentityProviderConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DefaultInvitationRedemptionIdentityProviderConfiguration>("invitationRedemptionIdentityProviderConfiguration"); }
            set { BackingStore?.Set("invitationRedemptionIdentityProviderConfiguration", value); }
        }
#endif
        /// <summary>If true, the default configuration is set to the system default configuration. If false, the default settings are customized.</summary>
        public bool? IsServiceDefault
        {
            get { return BackingStore?.Get<bool?>("isServiceDefault"); }
            set { BackingStore?.Set("isServiceDefault", value); }
        }
        /// <summary>Defines the default tenant restrictions configuration for users in your organization who access an external organization on your network or devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyTenantRestrictions? TenantRestrictions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyTenantRestrictions?>("tenantRestrictions"); }
            set { BackingStore?.Set("tenantRestrictions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyTenantRestrictions TenantRestrictions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyTenantRestrictions>("tenantRestrictions"); }
            set { BackingStore?.Set("tenantRestrictions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyConfigurationDefault"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyConfigurationDefault CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyConfigurationDefault();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "automaticUserConsentSettings", n => { AutomaticUserConsentSettings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.InboundOutboundPolicyConfiguration>(global::Microsoft.Graph.Beta.Models.InboundOutboundPolicyConfiguration.CreateFromDiscriminatorValue); } },
                { "b2bCollaborationInbound", n => { B2bCollaborationInbound = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>(global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                { "b2bCollaborationOutbound", n => { B2bCollaborationOutbound = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>(global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                { "b2bDirectConnectInbound", n => { B2bDirectConnectInbound = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>(global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                { "b2bDirectConnectOutbound", n => { B2bDirectConnectOutbound = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>(global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                { "inboundTrust", n => { InboundTrust = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyInboundTrust>(global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyInboundTrust.CreateFromDiscriminatorValue); } },
                { "invitationRedemptionIdentityProviderConfiguration", n => { InvitationRedemptionIdentityProviderConfiguration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DefaultInvitationRedemptionIdentityProviderConfiguration>(global::Microsoft.Graph.Beta.Models.DefaultInvitationRedemptionIdentityProviderConfiguration.CreateFromDiscriminatorValue); } },
                { "isServiceDefault", n => { IsServiceDefault = n.GetBoolValue(); } },
                { "tenantRestrictions", n => { TenantRestrictions = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyTenantRestrictions>(global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyTenantRestrictions.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.InboundOutboundPolicyConfiguration>("automaticUserConsentSettings", AutomaticUserConsentSettings);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>("b2bCollaborationInbound", B2bCollaborationInbound);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>("b2bCollaborationOutbound", B2bCollaborationOutbound);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectInbound", B2bDirectConnectInbound);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectOutbound", B2bDirectConnectOutbound);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyInboundTrust>("inboundTrust", InboundTrust);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DefaultInvitationRedemptionIdentityProviderConfiguration>("invitationRedemptionIdentityProviderConfiguration", InvitationRedemptionIdentityProviderConfiguration);
            writer.WriteBoolValue("isServiceDefault", IsServiceDefault);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CrossTenantAccessPolicyTenantRestrictions>("tenantRestrictions", TenantRestrictions);
        }
    }
}
#pragma warning restore CS0618
