// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CanvasLayout : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Collection of horizontal sections on the SharePoint page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.HorizontalSection>? HorizontalSections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.HorizontalSection>?>("horizontalSections"); }
            set { BackingStore?.Set("horizontalSections", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.HorizontalSection> HorizontalSections
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.HorizontalSection>>("horizontalSections"); }
            set { BackingStore?.Set("horizontalSections", value); }
        }
#endif
        /// <summary>Vertical section on the SharePoint page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.VerticalSection? VerticalSection
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VerticalSection?>("verticalSection"); }
            set { BackingStore?.Set("verticalSection", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.VerticalSection VerticalSection
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VerticalSection>("verticalSection"); }
            set { BackingStore?.Set("verticalSection", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CanvasLayout"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CanvasLayout CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CanvasLayout();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "horizontalSections", n => { HorizontalSections = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.HorizontalSection>(global::Microsoft.Graph.Beta.Models.HorizontalSection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "verticalSection", n => { VerticalSection = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.VerticalSection>(global::Microsoft.Graph.Beta.Models.VerticalSection.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.HorizontalSection>("horizontalSections", HorizontalSections);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.VerticalSection>("verticalSection", VerticalSection);
        }
    }
}
#pragma warning restore CS0618
