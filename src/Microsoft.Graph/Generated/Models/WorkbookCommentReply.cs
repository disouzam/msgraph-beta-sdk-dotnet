using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class WorkbookCommentReply : Entity, IParsable {
        /// <summary>The content of replied comment.</summary>
        public string Content {
            get { return BackingStore?.Get<string>(nameof(Content)); }
            set { BackingStore?.Set(nameof(Content), value); }
        }
        /// <summary>Indicates the type for the replied comment.</summary>
        public string ContentType {
            get { return BackingStore?.Get<string>(nameof(ContentType)); }
            set { BackingStore?.Set(nameof(ContentType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookCommentReply CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookCommentReply();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetStringValue(); } },
                {"contentType", n => { ContentType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("content", Content);
            writer.WriteStringValue("contentType", ContentType);
        }
    }
}
