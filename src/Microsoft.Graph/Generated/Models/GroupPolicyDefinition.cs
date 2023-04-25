using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The entity describes all of the information about a single group policy.
    /// </summary>
    public class GroupPolicyDefinition : Entity, IParsable {
        /// <summary>The group policy category associated with the definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GroupPolicyCategory? Category {
            get { return BackingStore?.Get<GroupPolicyCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#nullable restore
#else
        public GroupPolicyCategory Category {
            get { return BackingStore?.Get<GroupPolicyCategory>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#endif
        /// <summary>The localized full category path for the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CategoryPath {
            get { return BackingStore?.Get<string?>("categoryPath"); }
            set { BackingStore?.Set("categoryPath", value); }
        }
#nullable restore
#else
        public string CategoryPath {
            get { return BackingStore?.Get<string>("categoryPath"); }
            set { BackingStore?.Set("categoryPath", value); }
        }
#endif
        /// <summary>Group Policy Definition Class Type.</summary>
        public GroupPolicyDefinitionClassType? ClassType {
            get { return BackingStore?.Get<GroupPolicyDefinitionClassType?>("classType"); }
            set { BackingStore?.Set("classType", value); }
        }
        /// <summary>The group policy file associated with the definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GroupPolicyDefinitionFile? DefinitionFile {
            get { return BackingStore?.Get<GroupPolicyDefinitionFile?>("definitionFile"); }
            set { BackingStore?.Set("definitionFile", value); }
        }
#nullable restore
#else
        public GroupPolicyDefinitionFile DefinitionFile {
            get { return BackingStore?.Get<GroupPolicyDefinitionFile>("definitionFile"); }
            set { BackingStore?.Set("definitionFile", value); }
        }
#endif
        /// <summary>The localized policy name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The localized explanation or help text associated with the policy. The default value is empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExplainText {
            get { return BackingStore?.Get<string?>("explainText"); }
            set { BackingStore?.Set("explainText", value); }
        }
#nullable restore
#else
        public string ExplainText {
            get { return BackingStore?.Get<string>("explainText"); }
            set { BackingStore?.Set("explainText", value); }
        }
#endif
        /// <summary>The category id of the parent category</summary>
        public Guid? GroupPolicyCategoryId {
            get { return BackingStore?.Get<Guid?>("groupPolicyCategoryId"); }
            set { BackingStore?.Set("groupPolicyCategoryId", value); }
        }
        /// <summary>Signifies whether or not there are related definitions to this definition</summary>
        public bool? HasRelatedDefinitions {
            get { return BackingStore?.Get<bool?>("hasRelatedDefinitions"); }
            set { BackingStore?.Set("hasRelatedDefinitions", value); }
        }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Minimum required CSP version for device configuration in this definition</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinDeviceCspVersion {
            get { return BackingStore?.Get<string?>("minDeviceCspVersion"); }
            set { BackingStore?.Set("minDeviceCspVersion", value); }
        }
#nullable restore
#else
        public string MinDeviceCspVersion {
            get { return BackingStore?.Get<string>("minDeviceCspVersion"); }
            set { BackingStore?.Set("minDeviceCspVersion", value); }
        }
#endif
        /// <summary>Minimum required CSP version for user configuration in this definition</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinUserCspVersion {
            get { return BackingStore?.Get<string?>("minUserCspVersion"); }
            set { BackingStore?.Set("minUserCspVersion", value); }
        }
#nullable restore
#else
        public string MinUserCspVersion {
            get { return BackingStore?.Get<string>("minUserCspVersion"); }
            set { BackingStore?.Set("minUserCspVersion", value); }
        }
#endif
        /// <summary>Definition of the next version of this definition</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GroupPolicyDefinition? NextVersionDefinition {
            get { return BackingStore?.Get<GroupPolicyDefinition?>("nextVersionDefinition"); }
            set { BackingStore?.Set("nextVersionDefinition", value); }
        }
#nullable restore
#else
        public GroupPolicyDefinition NextVersionDefinition {
            get { return BackingStore?.Get<GroupPolicyDefinition>("nextVersionDefinition"); }
            set { BackingStore?.Set("nextVersionDefinition", value); }
        }
#endif
        /// <summary>Type of Group Policy File or Definition.</summary>
        public GroupPolicyType? PolicyType {
            get { return BackingStore?.Get<GroupPolicyType?>("policyType"); }
            set { BackingStore?.Set("policyType", value); }
        }
        /// <summary>The group policy presentations associated with the definition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GroupPolicyPresentation>? Presentations {
            get { return BackingStore?.Get<List<GroupPolicyPresentation>?>("presentations"); }
            set { BackingStore?.Set("presentations", value); }
        }
#nullable restore
#else
        public List<GroupPolicyPresentation> Presentations {
            get { return BackingStore?.Get<List<GroupPolicyPresentation>>("presentations"); }
            set { BackingStore?.Set("presentations", value); }
        }
#endif
        /// <summary>Definition of the previous version of this definition</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GroupPolicyDefinition? PreviousVersionDefinition {
            get { return BackingStore?.Get<GroupPolicyDefinition?>("previousVersionDefinition"); }
            set { BackingStore?.Set("previousVersionDefinition", value); }
        }
#nullable restore
#else
        public GroupPolicyDefinition PreviousVersionDefinition {
            get { return BackingStore?.Get<GroupPolicyDefinition>("previousVersionDefinition"); }
            set { BackingStore?.Set("previousVersionDefinition", value); }
        }
#endif
        /// <summary>Localized string used to specify what operating system or application version is affected by the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupportedOn {
            get { return BackingStore?.Get<string?>("supportedOn"); }
            set { BackingStore?.Set("supportedOn", value); }
        }
#nullable restore
#else
        public string SupportedOn {
            get { return BackingStore?.Get<string>("supportedOn"); }
            set { BackingStore?.Set("supportedOn", value); }
        }
#endif
        /// <summary>Setting definition version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"category", n => { Category = n.GetObjectValue<GroupPolicyCategory>(GroupPolicyCategory.CreateFromDiscriminatorValue); } },
                {"categoryPath", n => { CategoryPath = n.GetStringValue(); } },
                {"classType", n => { ClassType = n.GetEnumValue<GroupPolicyDefinitionClassType>(); } },
                {"definitionFile", n => { DefinitionFile = n.GetObjectValue<GroupPolicyDefinitionFile>(GroupPolicyDefinitionFile.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"explainText", n => { ExplainText = n.GetStringValue(); } },
                {"groupPolicyCategoryId", n => { GroupPolicyCategoryId = n.GetGuidValue(); } },
                {"hasRelatedDefinitions", n => { HasRelatedDefinitions = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"minDeviceCspVersion", n => { MinDeviceCspVersion = n.GetStringValue(); } },
                {"minUserCspVersion", n => { MinUserCspVersion = n.GetStringValue(); } },
                {"nextVersionDefinition", n => { NextVersionDefinition = n.GetObjectValue<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue); } },
                {"policyType", n => { PolicyType = n.GetEnumValue<GroupPolicyType>(); } },
                {"presentations", n => { Presentations = n.GetCollectionOfObjectValues<GroupPolicyPresentation>(GroupPolicyPresentation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"previousVersionDefinition", n => { PreviousVersionDefinition = n.GetObjectValue<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue); } },
                {"supportedOn", n => { SupportedOn = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GroupPolicyCategory>("category", Category);
            writer.WriteStringValue("categoryPath", CategoryPath);
            writer.WriteEnumValue<GroupPolicyDefinitionClassType>("classType", ClassType);
            writer.WriteObjectValue<GroupPolicyDefinitionFile>("definitionFile", DefinitionFile);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("explainText", ExplainText);
            writer.WriteGuidValue("groupPolicyCategoryId", GroupPolicyCategoryId);
            writer.WriteBoolValue("hasRelatedDefinitions", HasRelatedDefinitions);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("minDeviceCspVersion", MinDeviceCspVersion);
            writer.WriteStringValue("minUserCspVersion", MinUserCspVersion);
            writer.WriteObjectValue<GroupPolicyDefinition>("nextVersionDefinition", NextVersionDefinition);
            writer.WriteEnumValue<GroupPolicyType>("policyType", PolicyType);
            writer.WriteCollectionOfObjectValues<GroupPolicyPresentation>("presentations", Presentations);
            writer.WriteObjectValue<GroupPolicyDefinition>("previousVersionDefinition", PreviousVersionDefinition);
            writer.WriteStringValue("supportedOn", SupportedOn);
            writer.WriteStringValue("version", Version);
        }
    }
}
