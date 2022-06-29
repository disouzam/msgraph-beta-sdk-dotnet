using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeliveryOptimizationBandwidthPercentage : DeliveryOptimizationBandwidth, IParsable {
        /// <summary>Specifies the maximum background download bandwidth that Delivery Optimization uses across all concurrent download activities as a percentage of available download bandwidth (0-100). Valid values 0 to 100</summary>
        public int? MaximumBackgroundBandwidthPercentage {
            get { return BackingStore?.Get<int?>(nameof(MaximumBackgroundBandwidthPercentage)); }
            set { BackingStore?.Set(nameof(MaximumBackgroundBandwidthPercentage), value); }
        }
        /// <summary>Specifies the maximum foreground download bandwidth that Delivery Optimization uses across all concurrent download activities as a percentage of available download bandwidth (0-100). Valid values 0 to 100</summary>
        public int? MaximumForegroundBandwidthPercentage {
            get { return BackingStore?.Get<int?>(nameof(MaximumForegroundBandwidthPercentage)); }
            set { BackingStore?.Set(nameof(MaximumForegroundBandwidthPercentage), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeliveryOptimizationBandwidthPercentage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeliveryOptimizationBandwidthPercentage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumBackgroundBandwidthPercentage", n => { MaximumBackgroundBandwidthPercentage = n.GetIntValue(); } },
                {"maximumForegroundBandwidthPercentage", n => { MaximumForegroundBandwidthPercentage = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("maximumBackgroundBandwidthPercentage", MaximumBackgroundBandwidthPercentage);
            writer.WriteIntValue("maximumForegroundBandwidthPercentage", MaximumForegroundBandwidthPercentage);
        }
    }
}
