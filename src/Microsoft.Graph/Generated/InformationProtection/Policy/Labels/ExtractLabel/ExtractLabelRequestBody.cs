using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.InformationProtection.Policy.Labels.ExtractLabel {
    /// <summary>Provides operations to call the extractLabel method.</summary>
    public class ExtractLabelRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contentInfo property</summary>
        public Microsoft.Graph.Beta.Models.ContentInfo ContentInfo { get; set; }
        /// <summary>
        /// Instantiates a new extractLabelRequestBody and sets the default values.
        /// </summary>
        public ExtractLabelRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExtractLabelRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExtractLabelRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentInfo", (o,n) => { (o as ExtractLabelRequestBody).ContentInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ContentInfo>(Microsoft.Graph.Beta.Models.ContentInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ContentInfo>("contentInfo", ContentInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
