using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>OMA Settings definition.</summary>
    public class OmaSetting : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Description.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Display Name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Indicates whether the value field is encrypted. This property is read-only.</summary>
        public bool? IsEncrypted {
            get { return BackingStore?.Get<bool?>(nameof(IsEncrypted)); }
            set { BackingStore?.Set(nameof(IsEncrypted), value); }
        }
        /// <summary>OMA.</summary>
        public string OmaUri {
            get { return BackingStore?.Get<string>(nameof(OmaUri)); }
            set { BackingStore?.Set(nameof(OmaUri), value); }
        }
        /// <summary>ReferenceId for looking up secret for decryption. This property is read-only.</summary>
        public string SecretReferenceValueId {
            get { return BackingStore?.Get<string>(nameof(SecretReferenceValueId)); }
            set { BackingStore?.Set(nameof(SecretReferenceValueId), value); }
        }
        /// <summary>
        /// Instantiates a new omaSetting and sets the default values.
        /// </summary>
        public OmaSetting() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OmaSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OmaSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isEncrypted", n => { IsEncrypted = n.GetBoolValue(); } },
                {"omaUri", n => { OmaUri = n.GetStringValue(); } },
                {"secretReferenceValueId", n => { SecretReferenceValueId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isEncrypted", IsEncrypted);
            writer.WriteStringValue("omaUri", OmaUri);
            writer.WriteStringValue("secretReferenceValueId", SecretReferenceValueId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
