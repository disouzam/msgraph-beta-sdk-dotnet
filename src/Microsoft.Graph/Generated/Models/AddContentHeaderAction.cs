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
    public partial class AddContentHeaderAction : global::Microsoft.Graph.Beta.Models.InformationProtectionAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The alignment property</summary>
        public global::Microsoft.Graph.Beta.Models.ContentAlignment? Alignment
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContentAlignment?>("alignment"); }
            set { BackingStore?.Set("alignment", value); }
        }
        /// <summary>Color of the font to use for the header.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FontColor
        {
            get { return BackingStore?.Get<string?>("fontColor"); }
            set { BackingStore?.Set("fontColor", value); }
        }
#nullable restore
#else
        public string FontColor
        {
            get { return BackingStore?.Get<string>("fontColor"); }
            set { BackingStore?.Set("fontColor", value); }
        }
#endif
        /// <summary>Name of the font to use for the header.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FontName
        {
            get { return BackingStore?.Get<string?>("fontName"); }
            set { BackingStore?.Set("fontName", value); }
        }
#nullable restore
#else
        public string FontName
        {
            get { return BackingStore?.Get<string>("fontName"); }
            set { BackingStore?.Set("fontName", value); }
        }
#endif
        /// <summary>Font size to use for the header.</summary>
        public int? FontSize
        {
            get { return BackingStore?.Get<int?>("fontSize"); }
            set { BackingStore?.Set("fontSize", value); }
        }
        /// <summary>The margin of the header from the top of the document.</summary>
        public int? Margin
        {
            get { return BackingStore?.Get<int?>("margin"); }
            set { BackingStore?.Set("margin", value); }
        }
        /// <summary>The contents of the header itself.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text
        {
            get { return BackingStore?.Get<string?>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#nullable restore
#else
        public string Text
        {
            get { return BackingStore?.Get<string>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#endif
        /// <summary>The name of the UI element where the header should be placed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UiElementName
        {
            get { return BackingStore?.Get<string?>("uiElementName"); }
            set { BackingStore?.Set("uiElementName", value); }
        }
#nullable restore
#else
        public string UiElementName
        {
            get { return BackingStore?.Get<string>("uiElementName"); }
            set { BackingStore?.Set("uiElementName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AddContentHeaderAction"/> and sets the default values.
        /// </summary>
        public AddContentHeaderAction() : base()
        {
            OdataType = "#microsoft.graph.addContentHeaderAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AddContentHeaderAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AddContentHeaderAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AddContentHeaderAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alignment", n => { Alignment = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ContentAlignment>(); } },
                { "fontColor", n => { FontColor = n.GetStringValue(); } },
                { "fontName", n => { FontName = n.GetStringValue(); } },
                { "fontSize", n => { FontSize = n.GetIntValue(); } },
                { "margin", n => { Margin = n.GetIntValue(); } },
                { "text", n => { Text = n.GetStringValue(); } },
                { "uiElementName", n => { UiElementName = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ContentAlignment>("alignment", Alignment);
            writer.WriteStringValue("fontColor", FontColor);
            writer.WriteStringValue("fontName", FontName);
            writer.WriteIntValue("fontSize", FontSize);
            writer.WriteIntValue("margin", Margin);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("uiElementName", UiElementName);
        }
    }
}
#pragma warning restore CS0618
