using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>BitLocker Fixed Drive Policies.</summary>
    public class BitLockerFixedDrivePolicy : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Select the encryption method for fixed drives. Possible values are: aesCbc128, aesCbc256, xtsAes128, xtsAes256.</summary>
        public BitLockerEncryptionMethod? EncryptionMethod {
            get { return BackingStore?.Get<BitLockerEncryptionMethod?>(nameof(EncryptionMethod)); }
            set { BackingStore?.Set(nameof(EncryptionMethod), value); }
        }
        /// <summary>This policy setting allows you to control how BitLocker-protected fixed data drives are recovered in the absence of the required credentials. This policy setting is applied when you turn on BitLocker.</summary>
        public BitLockerRecoveryOptions RecoveryOptions {
            get { return BackingStore?.Get<BitLockerRecoveryOptions>(nameof(RecoveryOptions)); }
            set { BackingStore?.Set(nameof(RecoveryOptions), value); }
        }
        /// <summary>This policy setting determines whether BitLocker protection is required for fixed data drives to be writable on a computer.</summary>
        public bool? RequireEncryptionForWriteAccess {
            get { return BackingStore?.Get<bool?>(nameof(RequireEncryptionForWriteAccess)); }
            set { BackingStore?.Set(nameof(RequireEncryptionForWriteAccess), value); }
        }
        /// <summary>
        /// Instantiates a new bitLockerFixedDrivePolicy and sets the default values.
        /// </summary>
        public BitLockerFixedDrivePolicy() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BitLockerFixedDrivePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BitLockerFixedDrivePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"encryptionMethod", n => { EncryptionMethod = n.GetEnumValue<BitLockerEncryptionMethod>(); } },
                {"recoveryOptions", n => { RecoveryOptions = n.GetObjectValue<BitLockerRecoveryOptions>(BitLockerRecoveryOptions.CreateFromDiscriminatorValue); } },
                {"requireEncryptionForWriteAccess", n => { RequireEncryptionForWriteAccess = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<BitLockerEncryptionMethod>("encryptionMethod", EncryptionMethod);
            writer.WriteObjectValue<BitLockerRecoveryOptions>("recoveryOptions", RecoveryOptions);
            writer.WriteBoolValue("requireEncryptionForWriteAccess", RequireEncryptionForWriteAccess);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
