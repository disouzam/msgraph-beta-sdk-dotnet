using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class TeamsTab : Entity, IParsable {
        /// <summary>Container for custom settings applied to a tab. The tab is considered configured only once this property is set.</summary>
        public TeamsTabConfiguration Configuration {
            get { return BackingStore?.Get<TeamsTabConfiguration>(nameof(Configuration)); }
            set { BackingStore?.Set(nameof(Configuration), value); }
        }
        /// <summary>Name of the tab.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The messageId property</summary>
        public string MessageId {
            get { return BackingStore?.Get<string>(nameof(MessageId)); }
            set { BackingStore?.Set(nameof(MessageId), value); }
        }
        /// <summary>Index of the order used for sorting tabs.</summary>
        public string SortOrderIndex {
            get { return BackingStore?.Get<string>(nameof(SortOrderIndex)); }
            set { BackingStore?.Set(nameof(SortOrderIndex), value); }
        }
        /// <summary>The application that is linked to the tab.</summary>
        public Microsoft.Graph.Beta.Models.TeamsApp TeamsApp {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsApp>(nameof(TeamsApp)); }
            set { BackingStore?.Set(nameof(TeamsApp), value); }
        }
        /// <summary>The teamsAppId property</summary>
        public string TeamsAppId {
            get { return BackingStore?.Get<string>(nameof(TeamsAppId)); }
            set { BackingStore?.Set(nameof(TeamsAppId), value); }
        }
        /// <summary>Deep link URL of the tab instance. Read only.</summary>
        public string WebUrl {
            get { return BackingStore?.Get<string>(nameof(WebUrl)); }
            set { BackingStore?.Set(nameof(WebUrl), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamsTab CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsTab();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configuration", n => { Configuration = n.GetObjectValue<TeamsTabConfiguration>(TeamsTabConfiguration.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"messageId", n => { MessageId = n.GetStringValue(); } },
                {"sortOrderIndex", n => { SortOrderIndex = n.GetStringValue(); } },
                {"teamsApp", n => { TeamsApp = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamsApp>(Microsoft.Graph.Beta.Models.TeamsApp.CreateFromDiscriminatorValue); } },
                {"teamsAppId", n => { TeamsAppId = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamsTabConfiguration>("configuration", Configuration);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("messageId", MessageId);
            writer.WriteStringValue("sortOrderIndex", SortOrderIndex);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamsApp>("teamsApp", TeamsApp);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
