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
    public partial class OidcIdentityProvider : global::Microsoft.Graph.Beta.Models.IdentityProviderBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The clientAuthentication property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.OidcClientAuthentication? ClientAuthentication
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OidcClientAuthentication?>("clientAuthentication"); }
            set { BackingStore?.Set("clientAuthentication", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.OidcClientAuthentication ClientAuthentication
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OidcClientAuthentication>("clientAuthentication"); }
            set { BackingStore?.Set("clientAuthentication", value); }
        }
#endif
        /// <summary>The client ID for the application obtained when registering the application with the identity provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId
        {
            get { return BackingStore?.Get<string?>("clientId"); }
            set { BackingStore?.Set("clientId", value); }
        }
#nullable restore
#else
        public string ClientId
        {
            get { return BackingStore?.Get<string>("clientId"); }
            set { BackingStore?.Set("clientId", value); }
        }
#endif
        /// <summary>After the OIDC provider sends an ID token back to Microsoft Entra External ID, Microsoft Entra External ID needs to be able to map the claims from the received token to the claims that Microsoft Entra ID recognizes and uses. This complex type captures that mapping.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.OidcInboundClaimMappingOverride? InboundClaimMapping
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OidcInboundClaimMappingOverride?>("inboundClaimMapping"); }
            set { BackingStore?.Set("inboundClaimMapping", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.OidcInboundClaimMappingOverride InboundClaimMapping
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OidcInboundClaimMappingOverride>("inboundClaimMapping"); }
            set { BackingStore?.Set("inboundClaimMapping", value); }
        }
#endif
        /// <summary>The issuer URI. Issuer URI is a case-sensitive URL using https scheme contains scheme, host, and optionally, port number and path components and no query or fragment components. Note: Configuring other Microsoft Entra tenants as an external identity provider is currently not supported. As a result, the microsoftonline.com domain in the issuer URI is not accepted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer
        {
            get { return BackingStore?.Get<string?>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#nullable restore
#else
        public string Issuer
        {
            get { return BackingStore?.Get<string>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
#endif
        /// <summary>The responseType property</summary>
        public global::Microsoft.Graph.Beta.Models.OidcResponseType? ResponseType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OidcResponseType?>("responseType"); }
            set { BackingStore?.Set("responseType", value); }
        }
        /// <summary>Scope defines the information and permissions you are looking to gather from your custom identity provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Scope
        {
            get { return BackingStore?.Get<string?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#nullable restore
#else
        public string Scope
        {
            get { return BackingStore?.Get<string>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#endif
        /// <summary>The URL for the metadata document of the OpenID Connect identity provider. Every OpenID Connect identity provider describes a metadata document that contains most of the information required to perform sign-in. This includes information such as the URLs to use and the location of the service&apos;s public signing keys. The OpenID Connect metadata document is always located at an endpoint that ends in .well-known/openid-configuration. Note: The metadata document should, at minimum, contain the following properties: issuer, authorizationendpoint, tokenendpoint, tokenendpointauthmethodssupported, responsetypessupported, subjecttypessupported and jwks_uri. Visit OpenID Connect Discovery specifications for more details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WellKnownEndpoint
        {
            get { return BackingStore?.Get<string?>("wellKnownEndpoint"); }
            set { BackingStore?.Set("wellKnownEndpoint", value); }
        }
#nullable restore
#else
        public string WellKnownEndpoint
        {
            get { return BackingStore?.Get<string>("wellKnownEndpoint"); }
            set { BackingStore?.Set("wellKnownEndpoint", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.OidcIdentityProvider"/> and sets the default values.
        /// </summary>
        public OidcIdentityProvider() : base()
        {
            OdataType = "#microsoft.graph.oidcIdentityProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OidcIdentityProvider"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.OidcIdentityProvider CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.OidcIdentityProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "clientAuthentication", n => { ClientAuthentication = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.OidcClientAuthentication>(global::Microsoft.Graph.Beta.Models.OidcClientAuthentication.CreateFromDiscriminatorValue); } },
                { "clientId", n => { ClientId = n.GetStringValue(); } },
                { "inboundClaimMapping", n => { InboundClaimMapping = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.OidcInboundClaimMappingOverride>(global::Microsoft.Graph.Beta.Models.OidcInboundClaimMappingOverride.CreateFromDiscriminatorValue); } },
                { "issuer", n => { Issuer = n.GetStringValue(); } },
                { "responseType", n => { ResponseType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.OidcResponseType>(); } },
                { "scope", n => { Scope = n.GetStringValue(); } },
                { "wellKnownEndpoint", n => { WellKnownEndpoint = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.OidcClientAuthentication>("clientAuthentication", ClientAuthentication);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.OidcInboundClaimMappingOverride>("inboundClaimMapping", InboundClaimMapping);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.OidcResponseType>("responseType", ResponseType);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("wellKnownEndpoint", WellKnownEndpoint);
        }
    }
}
#pragma warning restore CS0618
