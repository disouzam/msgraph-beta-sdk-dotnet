// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class EncryptedAzureStorageAccountFinding : global::Microsoft.Graph.Beta.Models.Finding, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The encryptionManagedBy property</summary>
        public global::Microsoft.Graph.Beta.Models.AzureEncryption? EncryptionManagedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AzureEncryption?>("encryptionManagedBy"); }
            set { BackingStore?.Set("encryptionManagedBy", value); }
        }
        /// <summary>The storageAccount property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource? StorageAccount
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource?>("storageAccount"); }
            set { BackingStore?.Set("storageAccount", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource StorageAccount
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>("storageAccount"); }
            set { BackingStore?.Set("storageAccount", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.EncryptedAzureStorageAccountFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.EncryptedAzureStorageAccountFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.EncryptedAzureStorageAccountFinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "encryptionManagedBy", n => { EncryptionManagedBy = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AzureEncryption>(); } },
                { "storageAccount", n => { StorageAccount = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>(global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AzureEncryption>("encryptionManagedBy", EncryptionManagedBy);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>("storageAccount", StorageAccount);
        }
    }
}
#pragma warning restore CS0618
