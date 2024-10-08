// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.InformationProtection.DecryptBuffer
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class DecryptBufferPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The encryptedBuffer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? EncryptedBuffer
        {
            get { return BackingStore?.Get<byte[]?>("encryptedBuffer"); }
            set { BackingStore?.Set("encryptedBuffer", value); }
        }
#nullable restore
#else
        public byte[] EncryptedBuffer
        {
            get { return BackingStore?.Get<byte[]>("encryptedBuffer"); }
            set { BackingStore?.Set("encryptedBuffer", value); }
        }
#endif
        /// <summary>The publishingLicense property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? PublishingLicense
        {
            get { return BackingStore?.Get<byte[]?>("publishingLicense"); }
            set { BackingStore?.Set("publishingLicense", value); }
        }
#nullable restore
#else
        public byte[] PublishingLicense
        {
            get { return BackingStore?.Get<byte[]>("publishingLicense"); }
            set { BackingStore?.Set("publishingLicense", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.InformationProtection.DecryptBuffer.DecryptBufferPostRequestBody"/> and sets the default values.
        /// </summary>
        public DecryptBufferPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.InformationProtection.DecryptBuffer.DecryptBufferPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.InformationProtection.DecryptBuffer.DecryptBufferPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.InformationProtection.DecryptBuffer.DecryptBufferPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "encryptedBuffer", n => { EncryptedBuffer = n.GetByteArrayValue(); } },
                { "publishingLicense", n => { PublishingLicense = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("encryptedBuffer", EncryptedBuffer);
            writer.WriteByteArrayValue("publishingLicense", PublishingLicense);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
