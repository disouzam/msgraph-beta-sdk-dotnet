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
    /// An abstract base class for all iOS-specific single sign-on extension types.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IosSingleSignOnExtension : global::Microsoft.Graph.Beta.Models.SingleSignOnExtension, IParsable
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IosSingleSignOnExtension"/> and sets the default values.
        /// </summary>
        public IosSingleSignOnExtension() : base()
        {
            OdataType = "#microsoft.graph.iosSingleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IosSingleSignOnExtension"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IosSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.iosAzureAdSingleSignOnExtension" => new global::Microsoft.Graph.Beta.Models.IosAzureAdSingleSignOnExtension(),
                "#microsoft.graph.iosCredentialSingleSignOnExtension" => new global::Microsoft.Graph.Beta.Models.IosCredentialSingleSignOnExtension(),
                "#microsoft.graph.iosKerberosSingleSignOnExtension" => new global::Microsoft.Graph.Beta.Models.IosKerberosSingleSignOnExtension(),
                "#microsoft.graph.iosRedirectSingleSignOnExtension" => new global::Microsoft.Graph.Beta.Models.IosRedirectSingleSignOnExtension(),
                _ => new global::Microsoft.Graph.Beta.Models.IosSingleSignOnExtension(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
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
        }
    }
}
#pragma warning restore CS0618
