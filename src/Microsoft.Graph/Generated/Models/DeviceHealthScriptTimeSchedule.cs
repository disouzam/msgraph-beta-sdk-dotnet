// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Base type of Device health script time schedule.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceHealthScriptTimeSchedule : global::Microsoft.Graph.Beta.Models.DeviceHealthScriptRunSchedule, IParsable
    {
        /// <summary>At what time the script is scheduled to run. This collection can contain a maximum of 20 elements.</summary>
        public Time? Time
        {
            get { return BackingStore?.Get<Time?>("time"); }
            set { BackingStore?.Set("time", value); }
        }
        /// <summary>Indicate if the time is Utc or client local time.</summary>
        public bool? UseUtc
        {
            get { return BackingStore?.Get<bool?>("useUtc"); }
            set { BackingStore?.Set("useUtc", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeviceHealthScriptTimeSchedule"/> and sets the default values.
        /// </summary>
        public DeviceHealthScriptTimeSchedule() : base()
        {
            OdataType = "#microsoft.graph.deviceHealthScriptTimeSchedule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceHealthScriptTimeSchedule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceHealthScriptTimeSchedule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.deviceHealthScriptDailySchedule" => new global::Microsoft.Graph.Beta.Models.DeviceHealthScriptDailySchedule(),
                "#microsoft.graph.deviceHealthScriptRunOnceSchedule" => new global::Microsoft.Graph.Beta.Models.DeviceHealthScriptRunOnceSchedule(),
                _ => new global::Microsoft.Graph.Beta.Models.DeviceHealthScriptTimeSchedule(),
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
                { "time", n => { Time = n.GetTimeValue(); } },
                { "useUtc", n => { UseUtc = n.GetBoolValue(); } },
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
            writer.WriteTimeValue("time", Time);
            writer.WriteBoolValue("useUtc", UseUtc);
        }
    }
}
#pragma warning restore CS0618
