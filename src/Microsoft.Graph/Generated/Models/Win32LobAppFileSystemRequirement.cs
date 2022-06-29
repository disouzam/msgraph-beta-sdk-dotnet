using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Win32LobAppFileSystemRequirement : Win32LobAppRequirement, IParsable {
        /// <summary>A value indicating whether this file or folder is for checking 32-bit app on 64-bit system</summary>
        public bool? Check32BitOn64System {
            get { return BackingStore?.Get<bool?>(nameof(Check32BitOn64System)); }
            set { BackingStore?.Set(nameof(Check32BitOn64System), value); }
        }
        /// <summary>The file system detection type. Possible values are: notConfigured, exists, modifiedDate, createdDate, version, sizeInMB, doesNotExist.</summary>
        public Win32LobAppFileSystemDetectionType? DetectionType {
            get { return BackingStore?.Get<Win32LobAppFileSystemDetectionType?>(nameof(DetectionType)); }
            set { BackingStore?.Set(nameof(DetectionType), value); }
        }
        /// <summary>The file or folder name to detect Win32 Line of Business (LoB) app</summary>
        public string FileOrFolderName {
            get { return BackingStore?.Get<string>(nameof(FileOrFolderName)); }
            set { BackingStore?.Set(nameof(FileOrFolderName), value); }
        }
        /// <summary>The file or folder path to detect Win32 Line of Business (LoB) app</summary>
        public string PathObject {
            get { return BackingStore?.Get<string>(nameof(PathObject)); }
            set { BackingStore?.Set(nameof(PathObject), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Win32LobAppFileSystemRequirement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppFileSystemRequirement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"check32BitOn64System", n => { Check32BitOn64System = n.GetBoolValue(); } },
                {"detectionType", n => { DetectionType = n.GetEnumValue<Win32LobAppFileSystemDetectionType>(); } },
                {"fileOrFolderName", n => { FileOrFolderName = n.GetStringValue(); } },
                {"path", n => { PathObject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("check32BitOn64System", Check32BitOn64System);
            writer.WriteEnumValue<Win32LobAppFileSystemDetectionType>("detectionType", DetectionType);
            writer.WriteStringValue("fileOrFolderName", FileOrFolderName);
            writer.WriteStringValue("path", PathObject);
        }
    }
}
