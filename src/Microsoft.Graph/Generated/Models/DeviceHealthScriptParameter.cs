using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Base properties of the script parameter.</summary>
    public class DeviceHealthScriptParameter : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Whether Apply DefaultValue When Not Assigned</summary>
        public bool? ApplyDefaultValueWhenNotAssigned {
            get { return BackingStore?.Get<bool?>(nameof(ApplyDefaultValueWhenNotAssigned)); }
            set { BackingStore?.Set(nameof(ApplyDefaultValueWhenNotAssigned), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The description of the param</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Whether the param is required</summary>
        public bool? IsRequired {
            get { return BackingStore?.Get<bool?>(nameof(IsRequired)); }
            set { BackingStore?.Set(nameof(IsRequired), value); }
        }
        /// <summary>The name of the param</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>
        /// Instantiates a new deviceHealthScriptParameter and sets the default values.
        /// </summary>
        public DeviceHealthScriptParameter() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceHealthScriptParameter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceHealthScriptBooleanParameter" => new DeviceHealthScriptBooleanParameter(),
                "#microsoft.graph.deviceHealthScriptIntegerParameter" => new DeviceHealthScriptIntegerParameter(),
                "#microsoft.graph.deviceHealthScriptStringParameter" => new DeviceHealthScriptStringParameter(),
                _ => new DeviceHealthScriptParameter(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applyDefaultValueWhenNotAssigned", n => { ApplyDefaultValueWhenNotAssigned = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"isRequired", n => { IsRequired = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("applyDefaultValueWhenNotAssigned", ApplyDefaultValueWhenNotAssigned);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isRequired", IsRequired);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
