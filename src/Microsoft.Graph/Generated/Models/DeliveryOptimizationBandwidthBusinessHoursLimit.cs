using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Bandwidth business hours and percentages type</summary>
    public class DeliveryOptimizationBandwidthBusinessHoursLimit : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specifies the beginning of business hours using a 24-hour clock (0-23). Valid values 0 to 23</summary>
        public int? BandwidthBeginBusinessHours {
            get { return BackingStore?.Get<int?>(nameof(BandwidthBeginBusinessHours)); }
            set { BackingStore?.Set(nameof(BandwidthBeginBusinessHours), value); }
        }
        /// <summary>Specifies the end of business hours using a 24-hour clock (0-23). Valid values 0 to 23</summary>
        public int? BandwidthEndBusinessHours {
            get { return BackingStore?.Get<int?>(nameof(BandwidthEndBusinessHours)); }
            set { BackingStore?.Set(nameof(BandwidthEndBusinessHours), value); }
        }
        /// <summary>Specifies the percentage of bandwidth to limit during business hours (0-100). Valid values 0 to 100</summary>
        public int? BandwidthPercentageDuringBusinessHours {
            get { return BackingStore?.Get<int?>(nameof(BandwidthPercentageDuringBusinessHours)); }
            set { BackingStore?.Set(nameof(BandwidthPercentageDuringBusinessHours), value); }
        }
        /// <summary>Specifies the percentage of bandwidth to limit outsidse business hours (0-100). Valid values 0 to 100</summary>
        public int? BandwidthPercentageOutsideBusinessHours {
            get { return BackingStore?.Get<int?>(nameof(BandwidthPercentageOutsideBusinessHours)); }
            set { BackingStore?.Set(nameof(BandwidthPercentageOutsideBusinessHours), value); }
        }
        /// <summary>
        /// Instantiates a new deliveryOptimizationBandwidthBusinessHoursLimit and sets the default values.
        /// </summary>
        public DeliveryOptimizationBandwidthBusinessHoursLimit() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeliveryOptimizationBandwidthBusinessHoursLimit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeliveryOptimizationBandwidthBusinessHoursLimit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bandwidthBeginBusinessHours", n => { BandwidthBeginBusinessHours = n.GetIntValue(); } },
                {"bandwidthEndBusinessHours", n => { BandwidthEndBusinessHours = n.GetIntValue(); } },
                {"bandwidthPercentageDuringBusinessHours", n => { BandwidthPercentageDuringBusinessHours = n.GetIntValue(); } },
                {"bandwidthPercentageOutsideBusinessHours", n => { BandwidthPercentageOutsideBusinessHours = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("bandwidthBeginBusinessHours", BandwidthBeginBusinessHours);
            writer.WriteIntValue("bandwidthEndBusinessHours", BandwidthEndBusinessHours);
            writer.WriteIntValue("bandwidthPercentageDuringBusinessHours", BandwidthPercentageDuringBusinessHours);
            writer.WriteIntValue("bandwidthPercentageOutsideBusinessHours", BandwidthPercentageOutsideBusinessHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
