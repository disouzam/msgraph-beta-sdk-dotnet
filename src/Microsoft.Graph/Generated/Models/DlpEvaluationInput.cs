using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DlpEvaluationInput : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The accessScope property</summary>
        public Microsoft.Graph.Beta.Models.AccessScope? AccessScope {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessScope?>(nameof(AccessScope)); }
            set { BackingStore?.Set(nameof(AccessScope), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The currentLabel property</summary>
        public Microsoft.Graph.Beta.Models.CurrentLabel CurrentLabel {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CurrentLabel>(nameof(CurrentLabel)); }
            set { BackingStore?.Set(nameof(CurrentLabel), value); }
        }
        /// <summary>The discoveredSensitiveTypes property</summary>
        public List<DiscoveredSensitiveType> DiscoveredSensitiveTypes {
            get { return BackingStore?.Get<List<DiscoveredSensitiveType>>(nameof(DiscoveredSensitiveTypes)); }
            set { BackingStore?.Set(nameof(DiscoveredSensitiveTypes), value); }
        }
        /// <summary>
        /// Instantiates a new dlpEvaluationInput and sets the default values.
        /// </summary>
        public DlpEvaluationInput() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DlpEvaluationInput CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.dlpEvaluationWindowsDevicesInput" => new DlpEvaluationWindowsDevicesInput(),
                _ => new DlpEvaluationInput(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessScope", n => { AccessScope = n.GetEnumValue<AccessScope>(); } },
                {"currentLabel", n => { CurrentLabel = n.GetObjectValue<Microsoft.Graph.Beta.Models.CurrentLabel>(Microsoft.Graph.Beta.Models.CurrentLabel.CreateFromDiscriminatorValue); } },
                {"discoveredSensitiveTypes", n => { DiscoveredSensitiveTypes = n.GetCollectionOfObjectValues<DiscoveredSensitiveType>(DiscoveredSensitiveType.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccessScope>("accessScope", AccessScope);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CurrentLabel>("currentLabel", CurrentLabel);
            writer.WriteCollectionOfObjectValues<DiscoveredSensitiveType>("discoveredSensitiveTypes", DiscoveredSensitiveTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
