// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class WorkbookChartDataLabelFormat : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the fill format of the current chart data label. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WorkbookChartFill? Fill
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartFill?>("fill"); }
            set { BackingStore?.Set("fill", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WorkbookChartFill Fill
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartFill>("fill"); }
            set { BackingStore?.Set("fill", value); }
        }
#endif
        /// <summary>Represents the font attributes (font name, font size, color, etc.) for a chart data label. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WorkbookChartFont? Font
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartFont?>("font"); }
            set { BackingStore?.Set("font", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WorkbookChartFont Font
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookChartFont>("font"); }
            set { BackingStore?.Set("font", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WorkbookChartDataLabelFormat"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WorkbookChartDataLabelFormat CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WorkbookChartDataLabelFormat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "fill", n => { Fill = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartFill>(global::Microsoft.Graph.Beta.Models.WorkbookChartFill.CreateFromDiscriminatorValue); } },
                { "font", n => { Font = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartFont>(global::Microsoft.Graph.Beta.Models.WorkbookChartFont.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartFill>("fill", Fill);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookChartFont>("font", Font);
        }
    }
}
#pragma warning restore CS0618
