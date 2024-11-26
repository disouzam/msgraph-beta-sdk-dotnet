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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MfaUserCountMetric : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The count property</summary>
        public long? Count
        {
            get { return BackingStore?.Get<long?>("count"); }
            set { BackingStore?.Set("count", value); }
        }
        /// <summary>The factDate property</summary>
        public Date? FactDate
        {
            get { return BackingStore?.Get<Date?>("factDate"); }
            set { BackingStore?.Set("factDate", value); }
        }
        /// <summary>The mfaType property</summary>
        public global::Microsoft.Graph.Beta.Models.MfaType? MfaType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MfaType?>("mfaType"); }
            set { BackingStore?.Set("mfaType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MfaUserCountMetric"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MfaUserCountMetric CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MfaUserCountMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "count", n => { Count = n.GetLongValue(); } },
                { "factDate", n => { FactDate = n.GetDateValue(); } },
                { "mfaType", n => { MfaType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.MfaType>(); } },
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
            writer.WriteLongValue("count", Count);
            writer.WriteDateValue("factDate", FactDate);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.MfaType>("mfaType", MfaType);
        }
    }
}
#pragma warning restore CS0618
