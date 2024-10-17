// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ChatMessageMention : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Index of an entity being mentioned in the specified chatMessage. Matches the {index} value in the corresponding &lt;at id=&apos;{index}&apos;&gt; tag in the message body.</summary>
        public int? Id
        {
            get { return BackingStore?.Get<int?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
        /// <summary>The entity (user, application, team, channel, or chat) that was @mentioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ChatMessageMentionedIdentitySet? Mentioned
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ChatMessageMentionedIdentitySet?>("mentioned"); }
            set { BackingStore?.Set("mentioned", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ChatMessageMentionedIdentitySet Mentioned
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ChatMessageMentionedIdentitySet>("mentioned"); }
            set { BackingStore?.Set("mentioned", value); }
        }
#endif
        /// <summary>String used to represent the mention. For example, a user&apos;s display name, a team name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MentionText
        {
            get { return BackingStore?.Get<string?>("mentionText"); }
            set { BackingStore?.Set("mentionText", value); }
        }
#nullable restore
#else
        public string MentionText
        {
            get { return BackingStore?.Get<string>("mentionText"); }
            set { BackingStore?.Set("mentionText", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ChatMessageMention"/> and sets the default values.
        /// </summary>
        public ChatMessageMention()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ChatMessageMention"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.ChatMessageMention CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ChatMessageMention();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "id", n => { Id = n.GetIntValue(); } },
                { "mentionText", n => { MentionText = n.GetStringValue(); } },
                { "mentioned", n => { Mentioned = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ChatMessageMentionedIdentitySet>(global::Microsoft.Graph.Beta.Models.ChatMessageMentionedIdentitySet.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("id", Id);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ChatMessageMentionedIdentitySet>("mentioned", Mentioned);
            writer.WriteStringValue("mentionText", MentionText);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
