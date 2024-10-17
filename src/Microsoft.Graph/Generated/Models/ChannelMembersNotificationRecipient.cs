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
    public partial class ChannelMembersNotificationRecipient : global::Microsoft.Graph.Beta.Models.TeamworkNotificationRecipient, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The unique identifier for the channel whose members should receive the notification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChannelId
        {
            get { return BackingStore?.Get<string?>("channelId"); }
            set { BackingStore?.Set("channelId", value); }
        }
#nullable restore
#else
        public string ChannelId
        {
            get { return BackingStore?.Get<string>("channelId"); }
            set { BackingStore?.Set("channelId", value); }
        }
#endif
        /// <summary>The unique identifier for the team under which the channel resides.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamId
        {
            get { return BackingStore?.Get<string?>("teamId"); }
            set { BackingStore?.Set("teamId", value); }
        }
#nullable restore
#else
        public string TeamId
        {
            get { return BackingStore?.Get<string>("teamId"); }
            set { BackingStore?.Set("teamId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ChannelMembersNotificationRecipient"/> and sets the default values.
        /// </summary>
        public ChannelMembersNotificationRecipient() : base()
        {
            OdataType = "#microsoft.graph.channelMembersNotificationRecipient";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ChannelMembersNotificationRecipient"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ChannelMembersNotificationRecipient CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ChannelMembersNotificationRecipient();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "channelId", n => { ChannelId = n.GetStringValue(); } },
                { "teamId", n => { TeamId = n.GetStringValue(); } },
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
            writer.WriteStringValue("channelId", ChannelId);
            writer.WriteStringValue("teamId", TeamId);
        }
    }
}
#pragma warning restore CS0618
