using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains properties for App configuration setting item.</summary>
    public class AppConfigurationSettingItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>app configuration key.</summary>
        public string AppConfigKey {
            get { return BackingStore?.Get<string>(nameof(AppConfigKey)); }
            set { BackingStore?.Set(nameof(AppConfigKey), value); }
        }
        /// <summary>app configuration key type. Possible values are: stringType, integerType, realType, booleanType, tokenType.</summary>
        public MdmAppConfigKeyType? AppConfigKeyType {
            get { return BackingStore?.Get<MdmAppConfigKeyType?>(nameof(AppConfigKeyType)); }
            set { BackingStore?.Set(nameof(AppConfigKeyType), value); }
        }
        /// <summary>app configuration key value.</summary>
        public string AppConfigKeyValue {
            get { return BackingStore?.Get<string>(nameof(AppConfigKeyValue)); }
            set { BackingStore?.Set(nameof(AppConfigKeyValue), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>
        /// Instantiates a new appConfigurationSettingItem and sets the default values.
        /// </summary>
        public AppConfigurationSettingItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AppConfigurationSettingItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppConfigurationSettingItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appConfigKey", n => { AppConfigKey = n.GetStringValue(); } },
                {"appConfigKeyType", n => { AppConfigKeyType = n.GetEnumValue<MdmAppConfigKeyType>(); } },
                {"appConfigKeyValue", n => { AppConfigKeyValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appConfigKey", AppConfigKey);
            writer.WriteEnumValue<MdmAppConfigKeyType>("appConfigKeyType", AppConfigKeyType);
            writer.WriteStringValue("appConfigKeyValue", AppConfigKeyValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
