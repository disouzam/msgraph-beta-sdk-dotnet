// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class OAuth2ClientCredential : global::Microsoft.Graph.Beta.Models.IndustryData.OAuthClientCredential, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The OAuth scope that is provided to the authentication process.</summary>
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
        /// <summary>The URL with which to retrieve the token after authentication happens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenUrl
        {
            get { return BackingStore?.Get<string?>("tokenUrl"); }
            set { BackingStore?.Set("tokenUrl", value); }
        }
#nullable restore
#else
        public string TokenUrl
        {
            get { return BackingStore?.Get<string>("tokenUrl"); }
            set { BackingStore?.Set("tokenUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IndustryData.OAuth2ClientCredential"/> and sets the default values.
        /// </summary>
        public OAuth2ClientCredential() : base()
        {
            OdataType = "#microsoft.graph.industryData.oAuth2ClientCredential";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IndustryData.OAuth2ClientCredential"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IndustryData.OAuth2ClientCredential CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IndustryData.OAuth2ClientCredential();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "scope", n => { Scope = n.GetStringValue(); } },
                { "tokenUrl", n => { TokenUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("tokenUrl", TokenUrl);
        }
    }
}
#pragma warning restore CS0618
