using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedAccess : Entity, IParsable {
        /// <summary>The display name of the provider managed by PIM.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>A collection of resources for the provider.</summary>
        public List<GovernanceResource> Resources {
            get { return BackingStore?.Get<List<GovernanceResource>>(nameof(Resources)); }
            set { BackingStore?.Set(nameof(Resources), value); }
        }
        /// <summary>A collection of role assignment requests for the provider.</summary>
        public List<GovernanceRoleAssignmentRequest> RoleAssignmentRequests {
            get { return BackingStore?.Get<List<GovernanceRoleAssignmentRequest>>(nameof(RoleAssignmentRequests)); }
            set { BackingStore?.Set(nameof(RoleAssignmentRequests), value); }
        }
        /// <summary>A collection of role assignments for the provider.</summary>
        public List<GovernanceRoleAssignment> RoleAssignments {
            get { return BackingStore?.Get<List<GovernanceRoleAssignment>>(nameof(RoleAssignments)); }
            set { BackingStore?.Set(nameof(RoleAssignments), value); }
        }
        /// <summary>A collection of role defintions for the provider.</summary>
        public List<GovernanceRoleDefinition> RoleDefinitions {
            get { return BackingStore?.Get<List<GovernanceRoleDefinition>>(nameof(RoleDefinitions)); }
            set { BackingStore?.Set(nameof(RoleDefinitions), value); }
        }
        /// <summary>A collection of role settings for the provider.</summary>
        public List<GovernanceRoleSetting> RoleSettings {
            get { return BackingStore?.Get<List<GovernanceRoleSetting>>(nameof(RoleSettings)); }
            set { BackingStore?.Set(nameof(RoleSettings), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrivilegedAccess CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedAccess();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<GovernanceResource>(GovernanceResource.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignmentRequests", n => { RoleAssignmentRequests = n.GetCollectionOfObjectValues<GovernanceRoleAssignmentRequest>(GovernanceRoleAssignmentRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<GovernanceRoleAssignment>(GovernanceRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<GovernanceRoleDefinition>(GovernanceRoleDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"roleSettings", n => { RoleSettings = n.GetCollectionOfObjectValues<GovernanceRoleSetting>(GovernanceRoleSetting.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<GovernanceResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<GovernanceRoleAssignmentRequest>("roleAssignmentRequests", RoleAssignmentRequests);
            writer.WriteCollectionOfObjectValues<GovernanceRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<GovernanceRoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteCollectionOfObjectValues<GovernanceRoleSetting>("roleSettings", RoleSettings);
        }
    }
}
