using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Option Definition Template</summary>
    public class DeviceManagementConfigurationOptionDefinitionTemplate : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Option Children</summary>
        public List<DeviceManagementConfigurationSettingInstanceTemplate> Children {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingInstanceTemplate>>(nameof(Children)); }
            set { BackingStore?.Set(nameof(Children), value); }
        }
        /// <summary>Option ItemId</summary>
        public string ItemId {
            get { return BackingStore?.Get<string>(nameof(ItemId)); }
            set { BackingStore?.Set(nameof(ItemId), value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationOptionDefinitionTemplate and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationOptionDefinitionTemplate() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationOptionDefinitionTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationOptionDefinitionTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"children", n => { Children = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingInstanceTemplate>(DeviceManagementConfigurationSettingInstanceTemplate.CreateFromDiscriminatorValue).ToList(); } },
                {"itemId", n => { ItemId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingInstanceTemplate>("children", Children);
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
