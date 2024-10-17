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
    public partial class DayNote : global::Microsoft.Graph.Beta.Models.ChangeTrackedEntity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The date of the day note.</summary>
        public Date? DayNoteDate
        {
            get { return BackingStore?.Get<Date?>("dayNoteDate"); }
            set { BackingStore?.Set("dayNoteDate", value); }
        }
        /// <summary>The draft version of this day note that is viewable by managers. Only contentType text is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ItemBody? DraftDayNote
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemBody?>("draftDayNote"); }
            set { BackingStore?.Set("draftDayNote", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ItemBody DraftDayNote
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemBody>("draftDayNote"); }
            set { BackingStore?.Set("draftDayNote", value); }
        }
#endif
        /// <summary>The shared version of this day note that is viewable by both employees and managers. Only contentType text is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ItemBody? SharedDayNote
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemBody?>("sharedDayNote"); }
            set { BackingStore?.Set("sharedDayNote", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ItemBody SharedDayNote
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemBody>("sharedDayNote"); }
            set { BackingStore?.Set("sharedDayNote", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DayNote"/> and sets the default values.
        /// </summary>
        public DayNote() : base()
        {
            OdataType = "#microsoft.graph.dayNote";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DayNote"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DayNote CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DayNote();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "dayNoteDate", n => { DayNoteDate = n.GetDateValue(); } },
                { "draftDayNote", n => { DraftDayNote = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ItemBody>(global::Microsoft.Graph.Beta.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "sharedDayNote", n => { SharedDayNote = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ItemBody>(global::Microsoft.Graph.Beta.Models.ItemBody.CreateFromDiscriminatorValue); } },
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
            writer.WriteDateValue("dayNoteDate", DayNoteDate);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ItemBody>("draftDayNote", DraftDayNote);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ItemBody>("sharedDayNote", SharedDayNote);
        }
    }
}
#pragma warning restore CS0618
