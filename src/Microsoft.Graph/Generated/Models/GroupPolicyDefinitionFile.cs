using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The entity represents an ADMX (Administrative Template) XML file. The ADMX file contains a collection of group policy definitions and their locations by category path. The group policy definition file also contains the languages supported as determined by the language dependent ADML (Administrative Template) language files.</summary>
    public class GroupPolicyDefinitionFile : Entity, IParsable {
        /// <summary>The group policy definitions associated with the file.</summary>
        public List<GroupPolicyDefinition> Definitions {
            get { return BackingStore?.Get<List<GroupPolicyDefinition>>(nameof(Definitions)); }
            set { BackingStore?.Set(nameof(Definitions), value); }
        }
        /// <summary>The localized description of the policy settings in the ADMX file. The default value is empty.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The localized friendly name of the ADMX file.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The file name of the ADMX file without the path. For example: edge.admx</summary>
        public string FileName {
            get { return BackingStore?.Get<string>(nameof(FileName)); }
            set { BackingStore?.Set(nameof(FileName), value); }
        }
        /// <summary>The supported language codes for the ADMX file.</summary>
        public List<string> LanguageCodes {
            get { return BackingStore?.Get<List<string>>(nameof(LanguageCodes)); }
            set { BackingStore?.Set(nameof(LanguageCodes), value); }
        }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Specifies the type of group policy. Possible values are: admxBacked, admxIngested.</summary>
        public GroupPolicyType? PolicyType {
            get { return BackingStore?.Get<GroupPolicyType?>(nameof(PolicyType)); }
            set { BackingStore?.Set(nameof(PolicyType), value); }
        }
        /// <summary>The revision version associated with the file.</summary>
        public string Revision {
            get { return BackingStore?.Get<string>(nameof(Revision)); }
            set { BackingStore?.Set(nameof(Revision), value); }
        }
        /// <summary>Specifies the URI used to identify the namespace within the ADMX file.</summary>
        public string TargetNamespace {
            get { return BackingStore?.Get<string>(nameof(TargetNamespace)); }
            set { BackingStore?.Set(nameof(TargetNamespace), value); }
        }
        /// <summary>Specifies the logical name that refers to the namespace within the ADMX file.</summary>
        public string TargetPrefix {
            get { return BackingStore?.Get<string>(nameof(TargetPrefix)); }
            set { BackingStore?.Set(nameof(TargetPrefix), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyDefinitionFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.groupPolicyUploadedDefinitionFile" => new GroupPolicyUploadedDefinitionFile(),
                _ => new GroupPolicyDefinitionFile(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"definitions", n => { Definitions = n.GetCollectionOfObjectValues<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"languageCodes", n => { LanguageCodes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"policyType", n => { PolicyType = n.GetEnumValue<GroupPolicyType>(); } },
                {"revision", n => { Revision = n.GetStringValue(); } },
                {"targetNamespace", n => { TargetNamespace = n.GetStringValue(); } },
                {"targetPrefix", n => { TargetPrefix = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<GroupPolicyDefinition>("definitions", Definitions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteCollectionOfPrimitiveValues<string>("languageCodes", LanguageCodes);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<GroupPolicyType>("policyType", PolicyType);
            writer.WriteStringValue("revision", Revision);
            writer.WriteStringValue("targetNamespace", TargetNamespace);
            writer.WriteStringValue("targetPrefix", TargetPrefix);
        }
    }
}
