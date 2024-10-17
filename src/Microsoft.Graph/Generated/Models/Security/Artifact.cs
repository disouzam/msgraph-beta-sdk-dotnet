// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Artifact : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.Artifact"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.Artifact CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.host" => new global::Microsoft.Graph.Beta.Models.Security.Host(),
                "#microsoft.graph.security.hostComponent" => new global::Microsoft.Graph.Beta.Models.Security.HostComponent(),
                "#microsoft.graph.security.hostCookie" => new global::Microsoft.Graph.Beta.Models.Security.HostCookie(),
                "#microsoft.graph.security.hostname" => new global::Microsoft.Graph.Beta.Models.Security.Hostname(),
                "#microsoft.graph.security.hostSslCertificate" => new global::Microsoft.Graph.Beta.Models.Security.HostSslCertificate(),
                "#microsoft.graph.security.hostTracker" => new global::Microsoft.Graph.Beta.Models.Security.HostTracker(),
                "#microsoft.graph.security.ipAddress" => new global::Microsoft.Graph.Beta.Models.Security.IpAddress(),
                "#microsoft.graph.security.passiveDnsRecord" => new global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord(),
                "#microsoft.graph.security.sslCertificate" => new global::Microsoft.Graph.Beta.Models.Security.SslCertificate(),
                "#microsoft.graph.security.unclassifiedArtifact" => new global::Microsoft.Graph.Beta.Models.Security.UnclassifiedArtifact(),
                _ => new global::Microsoft.Graph.Beta.Models.Security.Artifact(),
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
