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
    public partial class DriveRestoreArtifactsBulkAdditionRequest : global::Microsoft.Graph.Beta.Models.RestoreArtifactsBulkRequestBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list of directory object IDs that are added to the corresponding OneDrive for work or school restore session in a bulk operation. This property isn&apos;t implemented yet. Future value; don&apos;t use.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DirectoryObjectIds
        {
            get { return BackingStore?.Get<List<string>?>("directoryObjectIds"); }
            set { BackingStore?.Set("directoryObjectIds", value); }
        }
#nullable restore
#else
        public List<string> DirectoryObjectIds
        {
            get { return BackingStore?.Get<List<string>>("directoryObjectIds"); }
            set { BackingStore?.Set("directoryObjectIds", value); }
        }
#endif
        /// <summary>The list of email addresses that are added to the corresponding OneDrive for work or school restore session in a bulk operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Drives
        {
            get { return BackingStore?.Get<List<string>?>("drives"); }
            set { BackingStore?.Set("drives", value); }
        }
#nullable restore
#else
        public List<string> Drives
        {
            get { return BackingStore?.Get<List<string>>("drives"); }
            set { BackingStore?.Set("drives", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DriveRestoreArtifactsBulkAdditionRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DriveRestoreArtifactsBulkAdditionRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DriveRestoreArtifactsBulkAdditionRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "directoryObjectIds", n => { DirectoryObjectIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "drives", n => { Drives = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("directoryObjectIds", DirectoryObjectIds);
            writer.WriteCollectionOfPrimitiveValues<string>("drives", Drives);
        }
    }
}
#pragma warning restore CS0618
