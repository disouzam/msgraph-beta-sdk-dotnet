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
    /// A class containing the properties used for PolicySet.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PolicySet : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Assignments of the PolicySet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.PolicySetAssignment>? Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PolicySetAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.PolicySetAssignment> Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PolicySetAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Creation time of the PolicySet.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description of the PolicySet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>DisplayName of the PolicySet.</summary>
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
        /// <summary>The errorCode property</summary>
        public global::Microsoft.Graph.Beta.Models.ErrorCode? ErrorCode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ErrorCode?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>Tags of the guided deployment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GuidedDeploymentTags
        {
            get { return BackingStore?.Get<List<string>?>("guidedDeploymentTags"); }
            set { BackingStore?.Set("guidedDeploymentTags", value); }
        }
#nullable restore
#else
        public List<string> GuidedDeploymentTags
        {
            get { return BackingStore?.Get<List<string>>("guidedDeploymentTags"); }
            set { BackingStore?.Set("guidedDeploymentTags", value); }
        }
#endif
        /// <summary>Items of the PolicySet with maximum count 100.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.PolicySetItem>? Items
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PolicySetItem>?>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.PolicySetItem> Items
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PolicySetItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#endif
        /// <summary>Last modified time of the PolicySet.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>RoleScopeTags of the PolicySet</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTags
        {
            get { return BackingStore?.Get<List<string>?>("roleScopeTags"); }
            set { BackingStore?.Set("roleScopeTags", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTags
        {
            get { return BackingStore?.Get<List<string>>("roleScopeTags"); }
            set { BackingStore?.Set("roleScopeTags", value); }
        }
#endif
        /// <summary>The enum to specify the status of PolicySet.</summary>
        public global::Microsoft.Graph.Beta.Models.PolicySetStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PolicySetStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PolicySet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.PolicySet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.PolicySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PolicySetAssignment>(global::Microsoft.Graph.Beta.Models.PolicySetAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "errorCode", n => { ErrorCode = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ErrorCode>(); } },
                { "guidedDeploymentTags", n => { GuidedDeploymentTags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PolicySetItem>(global::Microsoft.Graph.Beta.Models.PolicySetItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "roleScopeTags", n => { RoleScopeTags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PolicySetStatus>(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PolicySetAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ErrorCode>("errorCode", ErrorCode);
            writer.WriteCollectionOfPrimitiveValues<string>("guidedDeploymentTags", GuidedDeploymentTags);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PolicySetItem>("items", Items);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTags", RoleScopeTags);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PolicySetStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
