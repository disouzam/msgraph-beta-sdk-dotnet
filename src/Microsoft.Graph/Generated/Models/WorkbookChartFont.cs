using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class WorkbookChartFont : Entity, IParsable {
        /// <summary>Represents the bold status of font.</summary>
        public bool? Bold {
            get { return BackingStore?.Get<bool?>(nameof(Bold)); }
            set { BackingStore?.Set(nameof(Bold), value); }
        }
        /// <summary>HTML color code representation of the text color. E.g. #FF0000 represents Red.</summary>
        public string Color {
            get { return BackingStore?.Get<string>(nameof(Color)); }
            set { BackingStore?.Set(nameof(Color), value); }
        }
        /// <summary>Represents the italic status of the font.</summary>
        public bool? Italic {
            get { return BackingStore?.Get<bool?>(nameof(Italic)); }
            set { BackingStore?.Set(nameof(Italic), value); }
        }
        /// <summary>Font name (e.g. &apos;Calibri&apos;)</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Size of the font (e.g. 11)</summary>
        public double? Size {
            get { return BackingStore?.Get<double?>(nameof(Size)); }
            set { BackingStore?.Set(nameof(Size), value); }
        }
        /// <summary>Type of underline applied to the font. The possible values are: None, Single.</summary>
        public string Underline {
            get { return BackingStore?.Get<string>(nameof(Underline)); }
            set { BackingStore?.Set(nameof(Underline), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookChartFont CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartFont();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bold", n => { Bold = n.GetBoolValue(); } },
                {"color", n => { Color = n.GetStringValue(); } },
                {"italic", n => { Italic = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"size", n => { Size = n.GetDoubleValue(); } },
                {"underline", n => { Underline = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("bold", Bold);
            writer.WriteStringValue("color", Color);
            writer.WriteBoolValue("italic", Italic);
            writer.WriteStringValue("name", Name);
            writer.WriteDoubleValue("size", Size);
            writer.WriteStringValue("underline", Underline);
        }
    }
}
