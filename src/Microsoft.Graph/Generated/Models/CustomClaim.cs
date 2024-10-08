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
    public partial class CustomClaim : global::Microsoft.Graph.Beta.Models.CustomClaimBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the claim to be emitted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>An optional namespace to be included as part of the claim name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Namespace
        {
            get { return BackingStore?.Get<string?>("namespace"); }
            set { BackingStore?.Set("namespace", value); }
        }
#nullable restore
#else
        public string Namespace
        {
            get { return BackingStore?.Get<string>("namespace"); }
            set { BackingStore?.Set("namespace", value); }
        }
#endif
        /// <summary>If specified, it sets the nameFormat attribute associated with the claim in the SAML response. The possible values are: unspecified, uri, basic, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.SamlAttributeNameFormat? SamlAttributeNameFormat
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SamlAttributeNameFormat?>("samlAttributeNameFormat"); }
            set { BackingStore?.Set("samlAttributeNameFormat", value); }
        }
        /// <summary>List of token formats for which this claim should be emitted. The possible values are: saml,jwt, unknownFutureValue</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.TokenFormat?>? TokenFormat
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.TokenFormat?>?>("tokenFormat"); }
            set { BackingStore?.Set("tokenFormat", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.TokenFormat?> TokenFormat
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.TokenFormat?>>("tokenFormat"); }
            set { BackingStore?.Set("tokenFormat", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CustomClaim"/> and sets the default values.
        /// </summary>
        public CustomClaim() : base()
        {
            OdataType = "#microsoft.graph.customClaim";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CustomClaim"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CustomClaim CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CustomClaim();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "name", n => { Name = n.GetStringValue(); } },
                { "namespace", n => { Namespace = n.GetStringValue(); } },
                { "samlAttributeNameFormat", n => { SamlAttributeNameFormat = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.SamlAttributeNameFormat>(); } },
                { "tokenFormat", n => { TokenFormat = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.TokenFormat>()?.AsList(); } },
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
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("namespace", Namespace);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.SamlAttributeNameFormat>("samlAttributeNameFormat", SamlAttributeNameFormat);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.TokenFormat>("tokenFormat", TokenFormat);
        }
    }
}
#pragma warning restore CS0618
