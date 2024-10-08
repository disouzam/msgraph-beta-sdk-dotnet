// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Contains file or folder path to detect a Win32 App
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class Win32LobAppFileSystemRequirement : global::Microsoft.Graph.Beta.Models.Win32LobAppRequirement, IParsable
    {
        /// <summary>A value indicating whether this file or folder is for checking 32-bit app on 64-bit system</summary>
        public bool? Check32BitOn64System
        {
            get { return BackingStore?.Get<bool?>("check32BitOn64System"); }
            set { BackingStore?.Set("check32BitOn64System", value); }
        }
        /// <summary>Contains all supported file system detection type.</summary>
        public global::Microsoft.Graph.Beta.Models.Win32LobAppFileSystemDetectionType? DetectionType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Win32LobAppFileSystemDetectionType?>("detectionType"); }
            set { BackingStore?.Set("detectionType", value); }
        }
        /// <summary>The file or folder name to detect Win32 Line of Business (LoB) app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileOrFolderName
        {
            get { return BackingStore?.Get<string?>("fileOrFolderName"); }
            set { BackingStore?.Set("fileOrFolderName", value); }
        }
#nullable restore
#else
        public string FileOrFolderName
        {
            get { return BackingStore?.Get<string>("fileOrFolderName"); }
            set { BackingStore?.Set("fileOrFolderName", value); }
        }
#endif
        /// <summary>The file or folder path to detect Win32 Line of Business (LoB) app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path
        {
            get { return BackingStore?.Get<string?>("path"); }
            set { BackingStore?.Set("path", value); }
        }
#nullable restore
#else
        public string Path
        {
            get { return BackingStore?.Get<string>("path"); }
            set { BackingStore?.Set("path", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Win32LobAppFileSystemRequirement"/> and sets the default values.
        /// </summary>
        public Win32LobAppFileSystemRequirement() : base()
        {
            OdataType = "#microsoft.graph.win32LobAppFileSystemRequirement";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Win32LobAppFileSystemRequirement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Win32LobAppFileSystemRequirement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Win32LobAppFileSystemRequirement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "check32BitOn64System", n => { Check32BitOn64System = n.GetBoolValue(); } },
                { "detectionType", n => { DetectionType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Win32LobAppFileSystemDetectionType>(); } },
                { "fileOrFolderName", n => { FileOrFolderName = n.GetStringValue(); } },
                { "path", n => { Path = n.GetStringValue(); } },
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
            writer.WriteBoolValue("check32BitOn64System", Check32BitOn64System);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Win32LobAppFileSystemDetectionType>("detectionType", DetectionType);
            writer.WriteStringValue("fileOrFolderName", FileOrFolderName);
            writer.WriteStringValue("path", Path);
        }
    }
}
#pragma warning restore CS0618
