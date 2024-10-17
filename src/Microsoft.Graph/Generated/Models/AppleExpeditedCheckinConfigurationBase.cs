// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Experimental profile to increase the rate of device check-ins per day of iOS/macOS devices. This profile type is deprecated.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AppleExpeditedCheckinConfigurationBase : global::Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Gets or sets whether to enable expedited device check-ins.</summary>
        public bool? EnableExpeditedCheckin
        {
            get { return BackingStore?.Get<bool?>("enableExpeditedCheckin"); }
            set { BackingStore?.Set("enableExpeditedCheckin", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AppleExpeditedCheckinConfigurationBase"/> and sets the default values.
        /// </summary>
        public AppleExpeditedCheckinConfigurationBase() : base()
        {
            OdataType = "#microsoft.graph.appleExpeditedCheckinConfigurationBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AppleExpeditedCheckinConfigurationBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AppleExpeditedCheckinConfigurationBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.iosExpeditedCheckinConfiguration" => new global::Microsoft.Graph.Beta.Models.IosExpeditedCheckinConfiguration(),
                _ => new global::Microsoft.Graph.Beta.Models.AppleExpeditedCheckinConfigurationBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "enableExpeditedCheckin", n => { EnableExpeditedCheckin = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enableExpeditedCheckin", EnableExpeditedCheckin);
        }
    }
}
#pragma warning restore CS0618
