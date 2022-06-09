using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class AzureADDevice : UpdatableAsset, IParsable {
        /// <summary>Specifies areas of the service in which the device is enrolled. Read-only. Returned by default.</summary>
        public List<UpdatableAssetEnrollment> Enrollments {
            get { return BackingStore?.Get<List<UpdatableAssetEnrollment>>(nameof(Enrollments)); }
            set { BackingStore?.Set(nameof(Enrollments), value); }
        }
        /// <summary>Specifies any errors that prevent the device from being enrolled in update management or receving deployed content. Read-only. Returned by default.</summary>
        public List<UpdatableAssetError> Errors {
            get { return BackingStore?.Get<List<UpdatableAssetError>>(nameof(Errors)); }
            set { BackingStore?.Set(nameof(Errors), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AzureADDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AzureADDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enrollments", n => { Enrollments = n.GetCollectionOfObjectValues<UpdatableAssetEnrollment>(UpdatableAssetEnrollment.CreateFromDiscriminatorValue).ToList(); } },
                {"errors", n => { Errors = n.GetCollectionOfObjectValues<UpdatableAssetError>(UpdatableAssetError.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UpdatableAssetEnrollment>("enrollments", Enrollments);
            writer.WriteCollectionOfObjectValues<UpdatableAssetError>("errors", Errors);
        }
    }
}
