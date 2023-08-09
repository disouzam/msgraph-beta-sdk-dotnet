// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MetadataAction : InformationProtectionAction, IParsable {
        /// <summary>A collection of key value pairs that should be added to the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? MetadataToAdd {
            get { return BackingStore?.Get<List<KeyValuePair>?>("metadataToAdd"); }
            set { BackingStore?.Set("metadataToAdd", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> MetadataToAdd {
            get { return BackingStore?.Get<List<KeyValuePair>>("metadataToAdd"); }
            set { BackingStore?.Set("metadataToAdd", value); }
        }
#endif
        /// <summary>A collection of strings that indicate which keys to remove from the file metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MetadataToRemove {
            get { return BackingStore?.Get<List<string>?>("metadataToRemove"); }
            set { BackingStore?.Set("metadataToRemove", value); }
        }
#nullable restore
#else
        public List<string> MetadataToRemove {
            get { return BackingStore?.Get<List<string>>("metadataToRemove"); }
            set { BackingStore?.Set("metadataToRemove", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new metadataAction and sets the default values.
        /// </summary>
        public MetadataAction() : base() {
            OdataType = "#microsoft.graph.metadataAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MetadataAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MetadataAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"metadataToAdd", n => { MetadataToAdd = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"metadataToRemove", n => { MetadataToRemove = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("metadataToAdd", MetadataToAdd);
            writer.WriteCollectionOfPrimitiveValues<string>("metadataToRemove", MetadataToRemove);
        }
    }
}
