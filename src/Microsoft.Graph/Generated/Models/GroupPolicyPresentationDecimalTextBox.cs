using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyPresentationDecimalTextBox : GroupPolicyPresentation, IParsable {
        /// <summary>An unsigned integer that specifies the initial value for the decimal text box. The default value is 1.</summary>
        public long? DefaultValue {
            get { return BackingStore?.Get<long?>(nameof(DefaultValue)); }
            set { BackingStore?.Set(nameof(DefaultValue), value); }
        }
        /// <summary>An unsigned integer that specifies the maximum allowed value. The default value is 9999.</summary>
        public long? MaxValue {
            get { return BackingStore?.Get<long?>(nameof(MaxValue)); }
            set { BackingStore?.Set(nameof(MaxValue), value); }
        }
        /// <summary>An unsigned integer that specifies the minimum allowed value. The default value is 0.</summary>
        public long? MinValue {
            get { return BackingStore?.Get<long?>(nameof(MinValue)); }
            set { BackingStore?.Set(nameof(MinValue), value); }
        }
        /// <summary>Requirement to enter a value in the parameter box. The default value is false.</summary>
        public bool? Required {
            get { return BackingStore?.Get<bool?>(nameof(Required)); }
            set { BackingStore?.Set(nameof(Required), value); }
        }
        /// <summary>If true, create a spin control; otherwise, create a text box for numeric entry. The default value is true.</summary>
        public bool? Spin {
            get { return BackingStore?.Get<bool?>(nameof(Spin)); }
            set { BackingStore?.Set(nameof(Spin), value); }
        }
        /// <summary>An unsigned integer that specifies the increment of change for the spin control. The default value is 1.</summary>
        public long? SpinStep {
            get { return BackingStore?.Get<long?>(nameof(SpinStep)); }
            set { BackingStore?.Set(nameof(SpinStep), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyPresentationDecimalTextBox CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyPresentationDecimalTextBox();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultValue", n => { DefaultValue = n.GetLongValue(); } },
                {"maxValue", n => { MaxValue = n.GetLongValue(); } },
                {"minValue", n => { MinValue = n.GetLongValue(); } },
                {"required", n => { Required = n.GetBoolValue(); } },
                {"spin", n => { Spin = n.GetBoolValue(); } },
                {"spinStep", n => { SpinStep = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("defaultValue", DefaultValue);
            writer.WriteLongValue("maxValue", MaxValue);
            writer.WriteLongValue("minValue", MinValue);
            writer.WriteBoolValue("required", Required);
            writer.WriteBoolValue("spin", Spin);
            writer.WriteLongValue("spinStep", SpinStep);
        }
    }
}
