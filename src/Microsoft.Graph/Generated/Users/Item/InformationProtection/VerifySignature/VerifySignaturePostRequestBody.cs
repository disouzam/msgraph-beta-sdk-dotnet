using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.InformationProtection.VerifySignature {
    /// <summary>Provides operations to call the verifySignature method.</summary>
    public class VerifySignaturePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The digest property</summary>
        public byte[] Digest {
            get { return BackingStore?.Get<byte[]>(nameof(Digest)); }
            set { BackingStore?.Set(nameof(Digest), value); }
        }
        /// <summary>The signature property</summary>
        public byte[] Signature {
            get { return BackingStore?.Get<byte[]>(nameof(Signature)); }
            set { BackingStore?.Set(nameof(Signature), value); }
        }
        /// <summary>The signingKeyId property</summary>
        public string SigningKeyId {
            get { return BackingStore?.Get<string>(nameof(SigningKeyId)); }
            set { BackingStore?.Set(nameof(SigningKeyId), value); }
        }
        /// <summary>
        /// Instantiates a new verifySignaturePostRequestBody and sets the default values.
        /// </summary>
        public VerifySignaturePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static VerifySignaturePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VerifySignaturePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"digest", n => { Digest = n.GetByteArrayValue(); } },
                {"signature", n => { Signature = n.GetByteArrayValue(); } },
                {"signingKeyId", n => { SigningKeyId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("digest", Digest);
            writer.WriteByteArrayValue("signature", Signature);
            writer.WriteStringValue("signingKeyId", SigningKeyId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
