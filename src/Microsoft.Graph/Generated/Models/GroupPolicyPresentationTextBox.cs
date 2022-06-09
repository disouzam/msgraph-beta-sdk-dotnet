using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyPresentationTextBox : GroupPolicyPresentation, IParsable {
        /// <summary>Localized default string displayed in the text box. The default value is empty.</summary>
        public string DefaultValue {
            get { return BackingStore?.Get<string>(nameof(DefaultValue)); }
            set { BackingStore?.Set(nameof(DefaultValue), value); }
        }
        /// <summary>An unsigned integer that specifies the maximum number of text characters. Default value is 1023.</summary>
        public long? MaxLength {
            get { return BackingStore?.Get<long?>(nameof(MaxLength)); }
            set { BackingStore?.Set(nameof(MaxLength), value); }
        }
        /// <summary>Requirement to enter a value in the text box. Default value is false.</summary>
        public bool? Required {
            get { return BackingStore?.Get<bool?>(nameof(Required)); }
            set { BackingStore?.Set(nameof(Required), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyPresentationTextBox CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyPresentationTextBox();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultValue", n => { DefaultValue = n.GetStringValue(); } },
                {"maxLength", n => { MaxLength = n.GetLongValue(); } },
                {"required", n => { Required = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("defaultValue", DefaultValue);
            writer.WriteLongValue("maxLength", MaxLength);
            writer.WriteBoolValue("required", Required);
        }
    }
}
