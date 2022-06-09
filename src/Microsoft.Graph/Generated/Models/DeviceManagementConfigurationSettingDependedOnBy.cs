using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSettingDependedOnBy : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Identifier of child setting that is dependent on the current setting</summary>
        public string DependedOnBy {
            get { return BackingStore?.Get<string>(nameof(DependedOnBy)); }
            set { BackingStore?.Set(nameof(DependedOnBy), value); }
        }
        /// <summary>Value that determines if the child setting is required based on the parent setting&apos;s selection</summary>
        public bool? Required {
            get { return BackingStore?.Get<bool?>(nameof(Required)); }
            set { BackingStore?.Set(nameof(Required), value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingDependedOnBy and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingDependedOnBy() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationSettingDependedOnBy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingDependedOnBy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dependedOnBy", n => { DependedOnBy = n.GetStringValue(); } },
                {"required", n => { Required = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dependedOnBy", DependedOnBy);
            writer.WriteBoolValue("required", Required);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
