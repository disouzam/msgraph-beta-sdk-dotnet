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
    public partial class CommsOperation : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Unique Client Context string. Max limit is 256 chars.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientContext
        {
            get { return BackingStore?.Get<string?>("clientContext"); }
            set { BackingStore?.Set("clientContext", value); }
        }
#nullable restore
#else
        public string ClientContext
        {
            get { return BackingStore?.Get<string>("clientContext"); }
            set { BackingStore?.Set("clientContext", value); }
        }
#endif
        /// <summary>The result information. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ResultInfo? ResultInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ResultInfo?>("resultInfo"); }
            set { BackingStore?.Set("resultInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ResultInfo ResultInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ResultInfo>("resultInfo"); }
            set { BackingStore?.Set("resultInfo", value); }
        }
#endif
        /// <summary>The status property</summary>
        public global::Microsoft.Graph.Beta.Models.OperationStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OperationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CommsOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CommsOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.addLargeGalleryViewOperation" => new global::Microsoft.Graph.Beta.Models.AddLargeGalleryViewOperation(),
                "#microsoft.graph.cancelMediaProcessingOperation" => new global::Microsoft.Graph.Beta.Models.CancelMediaProcessingOperation(),
                "#microsoft.graph.inviteParticipantsOperation" => new global::Microsoft.Graph.Beta.Models.InviteParticipantsOperation(),
                "#microsoft.graph.muteParticipantOperation" => new global::Microsoft.Graph.Beta.Models.MuteParticipantOperation(),
                "#microsoft.graph.muteParticipantsOperation" => new global::Microsoft.Graph.Beta.Models.MuteParticipantsOperation(),
                "#microsoft.graph.playPromptOperation" => new global::Microsoft.Graph.Beta.Models.PlayPromptOperation(),
                "#microsoft.graph.recordOperation" => new global::Microsoft.Graph.Beta.Models.RecordOperation(),
                "#microsoft.graph.sendDtmfTonesOperation" => new global::Microsoft.Graph.Beta.Models.SendDtmfTonesOperation(),
                "#microsoft.graph.startHoldMusicOperation" => new global::Microsoft.Graph.Beta.Models.StartHoldMusicOperation(),
                "#microsoft.graph.stopHoldMusicOperation" => new global::Microsoft.Graph.Beta.Models.StopHoldMusicOperation(),
                "#microsoft.graph.subscribeToToneOperation" => new global::Microsoft.Graph.Beta.Models.SubscribeToToneOperation(),
                "#microsoft.graph.unmuteParticipantOperation" => new global::Microsoft.Graph.Beta.Models.UnmuteParticipantOperation(),
                "#microsoft.graph.updateRecordingStatusOperation" => new global::Microsoft.Graph.Beta.Models.UpdateRecordingStatusOperation(),
                _ => new global::Microsoft.Graph.Beta.Models.CommsOperation(),
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
                { "clientContext", n => { ClientContext = n.GetStringValue(); } },
                { "resultInfo", n => { ResultInfo = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ResultInfo>(global::Microsoft.Graph.Beta.Models.ResultInfo.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.OperationStatus>(); } },
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
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.OperationStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
