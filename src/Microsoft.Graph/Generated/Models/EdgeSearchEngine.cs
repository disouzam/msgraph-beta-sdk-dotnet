using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EdgeSearchEngine : EdgeSearchEngineBase, IParsable {
        /// <summary>Allows IT admins to set a predefined default search engine for MDM-Controlled devices. Possible values are: default, bing.</summary>
        public Microsoft.Graph.Beta.Models.EdgeSearchEngineType? EdgeSearchEngineType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EdgeSearchEngineType?>(nameof(EdgeSearchEngineType)); }
            set { BackingStore?.Set(nameof(EdgeSearchEngineType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EdgeSearchEngine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdgeSearchEngine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"edgeSearchEngineType", n => { EdgeSearchEngineType = n.GetEnumValue<EdgeSearchEngineType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EdgeSearchEngineType>("edgeSearchEngineType", EdgeSearchEngineType);
        }
    }
}
