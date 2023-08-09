// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Constraint enforcing the setting contains only vaild app types.
    /// </summary>
    public class DeviceManagementSettingAppConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>Acceptable app types to allow for this setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedTypes {
            get { return BackingStore?.Get<List<string>?>("supportedTypes"); }
            set { BackingStore?.Set("supportedTypes", value); }
        }
#nullable restore
#else
        public List<string> SupportedTypes {
            get { return BackingStore?.Get<List<string>>("supportedTypes"); }
            set { BackingStore?.Set("supportedTypes", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceManagementSettingAppConstraint and sets the default values.
        /// </summary>
        public DeviceManagementSettingAppConstraint() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingAppConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementSettingAppConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingAppConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"supportedTypes", n => { SupportedTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedTypes", SupportedTypes);
        }
    }
}
