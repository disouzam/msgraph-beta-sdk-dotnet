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
    public partial class StandardWebPart : global::Microsoft.Graph.Beta.Models.WebPart, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The instance identifier of the container text webPart. It only works for inline standard webPart in rich text webParts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerTextWebPartId
        {
            get { return BackingStore?.Get<string?>("containerTextWebPartId"); }
            set { BackingStore?.Set("containerTextWebPartId", value); }
        }
#nullable restore
#else
        public string ContainerTextWebPartId
        {
            get { return BackingStore?.Get<string>("containerTextWebPartId"); }
            set { BackingStore?.Set("containerTextWebPartId", value); }
        }
#endif
        /// <summary>Data of the webPart.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WebPartData? Data
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WebPartData?>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WebPartData Data
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WebPartData>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#endif
        /// <summary>A Guid that indicates the webPart type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebPartType
        {
            get { return BackingStore?.Get<string?>("webPartType"); }
            set { BackingStore?.Set("webPartType", value); }
        }
#nullable restore
#else
        public string WebPartType
        {
            get { return BackingStore?.Get<string>("webPartType"); }
            set { BackingStore?.Set("webPartType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.StandardWebPart"/> and sets the default values.
        /// </summary>
        public StandardWebPart() : base()
        {
            OdataType = "#microsoft.graph.standardWebPart";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.StandardWebPart"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.StandardWebPart CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.StandardWebPart();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "containerTextWebPartId", n => { ContainerTextWebPartId = n.GetStringValue(); } },
                { "data", n => { Data = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WebPartData>(global::Microsoft.Graph.Beta.Models.WebPartData.CreateFromDiscriminatorValue); } },
                { "webPartType", n => { WebPartType = n.GetStringValue(); } },
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
            writer.WriteStringValue("containerTextWebPartId", ContainerTextWebPartId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WebPartData>("data", Data);
            writer.WriteStringValue("webPartType", WebPartType);
        }
    }
}
#pragma warning restore CS0618
