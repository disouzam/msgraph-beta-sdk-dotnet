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
    public partial class CloudPcBulkCreateSnapshot : global::Microsoft.Graph.Beta.Models.CloudPcBulkAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessTier property</summary>
        public global::Microsoft.Graph.Beta.Models.CloudPcBlobAccessTier? AccessTier
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcBlobAccessTier?>("accessTier"); }
            set { BackingStore?.Set("accessTier", value); }
        }
        /// <summary>The storageAccountId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StorageAccountId
        {
            get { return BackingStore?.Get<string?>("storageAccountId"); }
            set { BackingStore?.Set("storageAccountId", value); }
        }
#nullable restore
#else
        public string StorageAccountId
        {
            get { return BackingStore?.Get<string>("storageAccountId"); }
            set { BackingStore?.Set("storageAccountId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CloudPcBulkCreateSnapshot"/> and sets the default values.
        /// </summary>
        public CloudPcBulkCreateSnapshot() : base()
        {
            OdataType = "#microsoft.graph.cloudPcBulkCreateSnapshot";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPcBulkCreateSnapshot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CloudPcBulkCreateSnapshot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CloudPcBulkCreateSnapshot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessTier", n => { AccessTier = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcBlobAccessTier>(); } },
                { "storageAccountId", n => { StorageAccountId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcBlobAccessTier>("accessTier", AccessTier);
            writer.WriteStringValue("storageAccountId", StorageAccountId);
        }
    }
}
#pragma warning restore CS0618
