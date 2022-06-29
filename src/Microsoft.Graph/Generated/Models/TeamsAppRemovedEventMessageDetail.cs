using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamsAppRemovedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator {
            get { return BackingStore?.Get<IdentitySet>(nameof(Initiator)); }
            set { BackingStore?.Set(nameof(Initiator), value); }
        }
        /// <summary>Display name of the teamsApp.</summary>
        public string TeamsAppDisplayName {
            get { return BackingStore?.Get<string>(nameof(TeamsAppDisplayName)); }
            set { BackingStore?.Set(nameof(TeamsAppDisplayName), value); }
        }
        /// <summary>Unique identifier of the teamsApp.</summary>
        public string TeamsAppId {
            get { return BackingStore?.Get<string>(nameof(TeamsAppId)); }
            set { BackingStore?.Set(nameof(TeamsAppId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamsAppRemovedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsAppRemovedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"teamsAppDisplayName", n => { TeamsAppDisplayName = n.GetStringValue(); } },
                {"teamsAppId", n => { TeamsAppId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteStringValue("teamsAppDisplayName", TeamsAppDisplayName);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
        }
    }
}
