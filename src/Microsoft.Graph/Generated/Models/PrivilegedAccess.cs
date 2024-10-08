// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class PrivilegedAccess : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The display name of the provider managed by PIM.</summary>
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
        /// <summary>A collection of resources for the provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.GovernanceResource>? Resources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernanceResource>?>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.GovernanceResource> Resources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernanceResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#endif
        /// <summary>A collection of role assignment requests for the provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignmentRequest>? RoleAssignmentRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignmentRequest>?>("roleAssignmentRequests"); }
            set { BackingStore?.Set("roleAssignmentRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignmentRequest> RoleAssignmentRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignmentRequest>>("roleAssignmentRequests"); }
            set { BackingStore?.Set("roleAssignmentRequests", value); }
        }
#endif
        /// <summary>A collection of role assignments for the provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment>? RoleAssignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment>?>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment> RoleAssignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#endif
        /// <summary>A collection of role definitions for the provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition>? RoleDefinitions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition>?>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition> RoleDefinitions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition>>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#endif
        /// <summary>A collection of role settings for the provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.GovernanceRoleSetting>? RoleSettings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernanceRoleSetting>?>("roleSettings"); }
            set { BackingStore?.Set("roleSettings", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.GovernanceRoleSetting> RoleSettings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernanceRoleSetting>>("roleSettings"); }
            set { BackingStore?.Set("roleSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PrivilegedAccess"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.PrivilegedAccess CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.PrivilegedAccess();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "resources", n => { Resources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernanceResource>(global::Microsoft.Graph.Beta.Models.GovernanceResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleAssignmentRequests", n => { RoleAssignmentRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignmentRequest>(global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignmentRequest.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment>(global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition>(global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleSettings", n => { RoleSettings = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernanceRoleSetting>(global::Microsoft.Graph.Beta.Models.GovernanceRoleSetting.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernanceResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignmentRequest>("roleAssignmentRequests", RoleAssignmentRequests);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernanceRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernanceRoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernanceRoleSetting>("roleSettings", RoleSettings);
        }
    }
}
#pragma warning restore CS0618
