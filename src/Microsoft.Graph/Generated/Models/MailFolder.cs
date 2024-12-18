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
    public partial class MailFolder : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The number of immediate child mailFolders in the current mailFolder.</summary>
        public int? ChildFolderCount
        {
            get { return BackingStore?.Get<int?>("childFolderCount"); }
            set { BackingStore?.Set("childFolderCount", value); }
        }
        /// <summary>The collection of child folders in the mailFolder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MailFolder>? ChildFolders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MailFolder>?>("childFolders"); }
            set { BackingStore?.Set("childFolders", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MailFolder> ChildFolders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MailFolder>>("childFolders"); }
            set { BackingStore?.Set("childFolders", value); }
        }
#endif
        /// <summary>The mailFolder&apos;s display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Indicates whether the mailFolder is hidden. This property can be set only when creating the folder. Find more information in Hidden mail folders.</summary>
        public bool? IsHidden
        {
            get { return BackingStore?.Get<bool?>("isHidden"); }
            set { BackingStore?.Set("isHidden", value); }
        }
        /// <summary>The collection of rules that apply to the user&apos;s Inbox folder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MessageRule>? MessageRules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MessageRule>?>("messageRules"); }
            set { BackingStore?.Set("messageRules", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MessageRule> MessageRules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MessageRule>>("messageRules"); }
            set { BackingStore?.Set("messageRules", value); }
        }
#endif
        /// <summary>The collection of messages in the mailFolder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Message>? Messages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Message>?>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Message> Messages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Message>>("messages"); }
            set { BackingStore?.Set("messages", value); }
        }
#endif
        /// <summary>The collection of multi-value extended properties defined for the mailFolder. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>?>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty> MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#endif
        /// <summary>The operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MailFolderOperation>? Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MailFolderOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MailFolderOperation> Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MailFolderOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The unique identifier for the mailFolder&apos;s parent mailFolder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentFolderId
        {
            get { return BackingStore?.Get<string?>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
#nullable restore
#else
        public string ParentFolderId
        {
            get { return BackingStore?.Get<string>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
#endif
        /// <summary>The collection of single-value extended properties defined for the mailFolder. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>?>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty> SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#endif
        /// <summary>The number of items in the mailFolder.</summary>
        public int? TotalItemCount
        {
            get { return BackingStore?.Get<int?>("totalItemCount"); }
            set { BackingStore?.Set("totalItemCount", value); }
        }
        /// <summary>The number of items in the mailFolder marked as unread.</summary>
        public int? UnreadItemCount
        {
            get { return BackingStore?.Get<int?>("unreadItemCount"); }
            set { BackingStore?.Set("unreadItemCount", value); }
        }
        /// <summary>The userConfigurations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.UserConfiguration>? UserConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UserConfiguration>?>("userConfigurations"); }
            set { BackingStore?.Set("userConfigurations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.UserConfiguration> UserConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UserConfiguration>>("userConfigurations"); }
            set { BackingStore?.Set("userConfigurations", value); }
        }
#endif
        /// <summary>The well-known folder name for the folder. The possible values are listed above. This property is only set for default folders created by Outlook. For other folders, this property is null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WellKnownName
        {
            get { return BackingStore?.Get<string?>("wellKnownName"); }
            set { BackingStore?.Set("wellKnownName", value); }
        }
#nullable restore
#else
        public string WellKnownName
        {
            get { return BackingStore?.Get<string>("wellKnownName"); }
            set { BackingStore?.Set("wellKnownName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MailFolder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MailFolder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.mailSearchFolder" => new global::Microsoft.Graph.Beta.Models.MailSearchFolder(),
                _ => new global::Microsoft.Graph.Beta.Models.MailFolder(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "childFolderCount", n => { ChildFolderCount = n.GetIntValue(); } },
                { "childFolders", n => { ChildFolders = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MailFolder>(global::Microsoft.Graph.Beta.Models.MailFolder.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isHidden", n => { IsHidden = n.GetBoolValue(); } },
                { "messageRules", n => { MessageRules = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MessageRule>(global::Microsoft.Graph.Beta.Models.MessageRule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "messages", n => { Messages = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Message>(global::Microsoft.Graph.Beta.Models.Message.CreateFromDiscriminatorValue)?.AsList(); } },
                { "multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>(global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MailFolderOperation>(global::Microsoft.Graph.Beta.Models.MailFolderOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                { "singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>(global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "totalItemCount", n => { TotalItemCount = n.GetIntValue(); } },
                { "unreadItemCount", n => { UnreadItemCount = n.GetIntValue(); } },
                { "userConfigurations", n => { UserConfigurations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UserConfiguration>(global::Microsoft.Graph.Beta.Models.UserConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "wellKnownName", n => { WellKnownName = n.GetStringValue(); } },
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
            writer.WriteIntValue("childFolderCount", ChildFolderCount);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MailFolder>("childFolders", ChildFolders);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isHidden", IsHidden);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MessageRule>("messageRules", MessageRules);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Message>("messages", Messages);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MailFolderOperation>("operations", Operations);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteIntValue("totalItemCount", TotalItemCount);
            writer.WriteIntValue("unreadItemCount", UnreadItemCount);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UserConfiguration>("userConfigurations", UserConfigurations);
            writer.WriteStringValue("wellKnownName", WellKnownName);
        }
    }
}
#pragma warning restore CS0618
