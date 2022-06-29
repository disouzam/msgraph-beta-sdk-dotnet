using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationIntegerSettingValueDefinition : DeviceManagementConfigurationSettingValueDefinition, IParsable {
        /// <summary>Maximum allowed value of the integer</summary>
        public long? MaximumValue {
            get { return BackingStore?.Get<long?>(nameof(MaximumValue)); }
            set { BackingStore?.Set(nameof(MaximumValue), value); }
        }
        /// <summary>Minimum allowed value of the integer</summary>
        public long? MinimumValue {
            get { return BackingStore?.Get<long?>(nameof(MinimumValue)); }
            set { BackingStore?.Set(nameof(MinimumValue), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationIntegerSettingValueDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationIntegerSettingValueDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumValue", n => { MaximumValue = n.GetLongValue(); } },
                {"minimumValue", n => { MinimumValue = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("maximumValue", MaximumValue);
            writer.WriteLongValue("minimumValue", MinimumValue);
        }
    }
}
