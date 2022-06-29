using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MediaPrompt : Prompt, IParsable {
        /// <summary>The loop property</summary>
        public int? Loop {
            get { return BackingStore?.Get<int?>(nameof(Loop)); }
            set { BackingStore?.Set(nameof(Loop), value); }
        }
        /// <summary>The mediaInfo property</summary>
        public Microsoft.Graph.Beta.Models.MediaInfo MediaInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaInfo>(nameof(MediaInfo)); }
            set { BackingStore?.Set(nameof(MediaInfo), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MediaPrompt CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaPrompt();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"loop", n => { Loop = n.GetIntValue(); } },
                {"mediaInfo", n => { MediaInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaInfo>(Microsoft.Graph.Beta.Models.MediaInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("loop", Loop);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaInfo>("mediaInfo", MediaInfo);
        }
    }
}
