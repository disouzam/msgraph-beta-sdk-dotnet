using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Operating System version range.</summary>
    public class OperatingSystemVersionRange : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The description of this range (e.g. Valid 1702 builds)</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The highest inclusive version that this range contains.</summary>
        public string HighestVersion {
            get { return BackingStore?.Get<string>(nameof(HighestVersion)); }
            set { BackingStore?.Set(nameof(HighestVersion), value); }
        }
        /// <summary>The lowest inclusive version that this range contains.</summary>
        public string LowestVersion {
            get { return BackingStore?.Get<string>(nameof(LowestVersion)); }
            set { BackingStore?.Set(nameof(LowestVersion), value); }
        }
        /// <summary>
        /// Instantiates a new operatingSystemVersionRange and sets the default values.
        /// </summary>
        public OperatingSystemVersionRange() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OperatingSystemVersionRange CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OperatingSystemVersionRange();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"highestVersion", n => { HighestVersion = n.GetStringValue(); } },
                {"lowestVersion", n => { LowestVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("highestVersion", HighestVersion);
            writer.WriteStringValue("lowestVersion", LowestVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
