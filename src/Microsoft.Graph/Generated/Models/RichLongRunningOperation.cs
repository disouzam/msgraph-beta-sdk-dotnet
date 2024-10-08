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
    /// The status of a long-running operation.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class RichLongRunningOperation : global::Microsoft.Graph.Beta.Models.LongRunningOperation, IParsable
    {
        /// <summary>Error due to which the operation failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PublicError? Error
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PublicError?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PublicError Error
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PublicError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#endif
        /// <summary>A value between 0 and 100 that indicates the progress of the operation.</summary>
        public int? PercentageComplete
        {
            get { return BackingStore?.Get<int?>("percentageComplete"); }
            set { BackingStore?.Set("percentageComplete", value); }
        }
        /// <summary>A unique identifier for the result.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId
        {
            get { return BackingStore?.Get<string?>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#nullable restore
#else
        public string ResourceId
        {
            get { return BackingStore?.Get<string>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#endif
        /// <summary>Type of the operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type
        {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type
        {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.RichLongRunningOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.RichLongRunningOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.RichLongRunningOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "error", n => { Error = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PublicError>(global::Microsoft.Graph.Beta.Models.PublicError.CreateFromDiscriminatorValue); } },
                { "percentageComplete", n => { PercentageComplete = n.GetIntValue(); } },
                { "resourceId", n => { ResourceId = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PublicError>("error", Error);
            writer.WriteIntValue("percentageComplete", PercentageComplete);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("type", Type);
        }
    }
}
#pragma warning restore CS0618
