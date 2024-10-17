// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// BitLocker Fixed Drive Policies.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BitLockerFixedDrivePolicy : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Select the encryption method for fixed drives. Possible values are: aesCbc128, aesCbc256, xtsAes128, xtsAes256.</summary>
        public global::Microsoft.Graph.Beta.Models.BitLockerEncryptionMethod? EncryptionMethod
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.BitLockerEncryptionMethod?>("encryptionMethod"); }
            set { BackingStore?.Set("encryptionMethod", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>This policy setting allows you to control how BitLocker-protected fixed data drives are recovered in the absence of the required credentials. This policy setting is applied when you turn on BitLocker.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.BitLockerRecoveryOptions? RecoveryOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.BitLockerRecoveryOptions?>("recoveryOptions"); }
            set { BackingStore?.Set("recoveryOptions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.BitLockerRecoveryOptions RecoveryOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.BitLockerRecoveryOptions>("recoveryOptions"); }
            set { BackingStore?.Set("recoveryOptions", value); }
        }
#endif
        /// <summary>This policy setting determines whether BitLocker protection is required for fixed data drives to be writable on a computer.</summary>
        public bool? RequireEncryptionForWriteAccess
        {
            get { return BackingStore?.Get<bool?>("requireEncryptionForWriteAccess"); }
            set { BackingStore?.Set("requireEncryptionForWriteAccess", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy"/> and sets the default values.
        /// </summary>
        public BitLockerFixedDrivePolicy()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "encryptionMethod", n => { EncryptionMethod = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.BitLockerEncryptionMethod>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "recoveryOptions", n => { RecoveryOptions = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.BitLockerRecoveryOptions>(global::Microsoft.Graph.Beta.Models.BitLockerRecoveryOptions.CreateFromDiscriminatorValue); } },
                { "requireEncryptionForWriteAccess", n => { RequireEncryptionForWriteAccess = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.BitLockerEncryptionMethod>("encryptionMethod", EncryptionMethod);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.BitLockerRecoveryOptions>("recoveryOptions", RecoveryOptions);
            writer.WriteBoolValue("requireEncryptionForWriteAccess", RequireEncryptionForWriteAccess);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
