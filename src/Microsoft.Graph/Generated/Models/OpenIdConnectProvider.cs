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
    public partial class OpenIdConnectProvider : global::Microsoft.Graph.Beta.Models.IdentityProvider, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>After the OIDC provider sends an ID token back to Microsoft Entra ID, Microsoft Entra ID needs to be able to map the claims from the received token to the claims that Microsoft Entra ID recognizes and uses. This complex type captures that mapping. It&apos;s a required property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ClaimsMapping? ClaimsMapping
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ClaimsMapping?>("claimsMapping"); }
            set { BackingStore?.Set("claimsMapping", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ClaimsMapping ClaimsMapping
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ClaimsMapping>("claimsMapping"); }
            set { BackingStore?.Set("claimsMapping", value); }
        }
#endif
        /// <summary>The domain hint can be used to skip directly to the sign-in page of the specified identity provider, instead of having the user make a selection among the list of available identity providers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DomainHint
        {
            get { return BackingStore?.Get<string?>("domainHint"); }
            set { BackingStore?.Set("domainHint", value); }
        }
#nullable restore
#else
        public string DomainHint
        {
            get { return BackingStore?.Get<string>("domainHint"); }
            set { BackingStore?.Set("domainHint", value); }
        }
#endif
        /// <summary>The URL for the metadata document of the OpenID Connect identity provider. Every OpenID Connect identity provider describes a metadata document that contains most of the information required to perform sign-in. This includes information such as the URLs to use and the location of the service&apos;s public signing keys. The OpenID Connect metadata document is always located at an endpoint that ends in a well-known/openid-configuration. For the OpenID Connect identity provider you&apos;re looking to add, you need to provide the metadata URL. It&apos;s a required property and is read only after creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MetadataUrl
        {
            get { return BackingStore?.Get<string?>("metadataUrl"); }
            set { BackingStore?.Set("metadataUrl", value); }
        }
#nullable restore
#else
        public string MetadataUrl
        {
            get { return BackingStore?.Get<string>("metadataUrl"); }
            set { BackingStore?.Set("metadataUrl", value); }
        }
#endif
        /// <summary>The responseMode property</summary>
        public global::Microsoft.Graph.Beta.Models.OpenIdConnectResponseMode? ResponseMode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OpenIdConnectResponseMode?>("responseMode"); }
            set { BackingStore?.Set("responseMode", value); }
        }
        /// <summary>The responseType property</summary>
        public global::Microsoft.Graph.Beta.Models.OpenIdConnectResponseTypes? ResponseType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OpenIdConnectResponseTypes?>("responseType"); }
            set { BackingStore?.Set("responseType", value); }
        }
        /// <summary>Scope defines the information and permissions you&apos;re looking to gather from your custom identity provider. OpenID Connect requests must contain the openid scope value in order to receive the ID token from the identity provider. Without the ID token, users aren&apos;t able to sign in to Azure AD B2C using the custom identity provider. Other scopes can be appended separated by space. For more information about the scope limitations, see RFC6749 Section 3.3. It&apos;s a required property.</summary>
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OpenIdConnectProvider"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.OpenIdConnectProvider CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.OpenIdConnectProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "claimsMapping", n => { ClaimsMapping = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ClaimsMapping>(global::Microsoft.Graph.Beta.Models.ClaimsMapping.CreateFromDiscriminatorValue); } },
                { "domainHint", n => { DomainHint = n.GetStringValue(); } },
                { "metadataUrl", n => { MetadataUrl = n.GetStringValue(); } },
                { "responseMode", n => { ResponseMode = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.OpenIdConnectResponseMode>(); } },
                { "responseType", n => { ResponseType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.OpenIdConnectResponseTypes>(); } },
                { "scope", n => { Scope = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ClaimsMapping>("claimsMapping", ClaimsMapping);
            writer.WriteStringValue("domainHint", DomainHint);
            writer.WriteStringValue("metadataUrl", MetadataUrl);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.OpenIdConnectResponseMode>("responseMode", ResponseMode);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.OpenIdConnectResponseTypes>("responseType", ResponseType);
            writer.WriteStringValue("scope", Scope);
        }
    }
}
#pragma warning restore CS0618
