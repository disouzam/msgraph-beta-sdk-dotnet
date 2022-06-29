using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AppleDeviceFeaturesConfigurationBase : DeviceConfiguration, IParsable {
        /// <summary>An array of AirPrint printers that should always be shown. This collection can contain a maximum of 500 elements.</summary>
        public List<AirPrintDestination> AirPrintDestinations {
            get { return BackingStore?.Get<List<AirPrintDestination>>(nameof(AirPrintDestinations)); }
            set { BackingStore?.Set(nameof(AirPrintDestinations), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AppleDeviceFeaturesConfigurationBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.iosDeviceFeaturesConfiguration" => new IosDeviceFeaturesConfiguration(),
                "#microsoft.graph.macOSDeviceFeaturesConfiguration" => new MacOSDeviceFeaturesConfiguration(),
                _ => new AppleDeviceFeaturesConfigurationBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"airPrintDestinations", n => { AirPrintDestinations = n.GetCollectionOfObjectValues<AirPrintDestination>(AirPrintDestination.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AirPrintDestination>("airPrintDestinations", AirPrintDestinations);
        }
    }
}
