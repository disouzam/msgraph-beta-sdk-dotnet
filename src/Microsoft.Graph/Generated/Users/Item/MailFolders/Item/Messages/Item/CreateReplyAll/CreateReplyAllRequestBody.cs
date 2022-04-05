using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.MailFolders.Item.Messages.Item.CreateReplyAll {
    /// <summary>Provides operations to call the createReplyAll method.</summary>
    public class CreateReplyAllRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Comment property</summary>
        public string Comment { get; set; }
        /// <summary>The Message property</summary>
        public Microsoft.Graph.Beta.Models.Message Message { get; set; }
        /// <summary>
        /// Instantiates a new createReplyAllRequestBody and sets the default values.
        /// </summary>
        public CreateReplyAllRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateReplyAllRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateReplyAllRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as CreateReplyAllRequestBody).Comment = n.GetStringValue(); } },
                {"message", (o,n) => { (o as CreateReplyAllRequestBody).Message = n.GetObjectValue<Microsoft.Graph.Beta.Models.Message>(Microsoft.Graph.Beta.Models.Message.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Message>("message", Message);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
