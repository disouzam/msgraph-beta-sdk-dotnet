using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UnifiedRbacApplication : Entity, IParsable {
        /// <summary>Resource that represents a collection of related actions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRbacResourceNamespace>? ResourceNamespaces {
            get { return BackingStore?.Get<List<UnifiedRbacResourceNamespace>?>("resourceNamespaces"); }
            set { BackingStore?.Set("resourceNamespaces", value); }
        }
#nullable restore
#else
        public List<UnifiedRbacResourceNamespace> ResourceNamespaces {
            get { return BackingStore?.Get<List<UnifiedRbacResourceNamespace>>("resourceNamespaces"); }
            set { BackingStore?.Set("resourceNamespaces", value); }
        }
#endif
        /// <summary>Resource to grant access to users or groups.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleAssignment>? RoleAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleAssignment>?>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleAssignment> RoleAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleAssignment>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#endif
        /// <summary>The roles allowed by RBAC providers and the permissions assigned to the roles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleDefinition>? RoleDefinitions {
            get { return BackingStore?.Get<List<UnifiedRoleDefinition>?>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleDefinition> RoleDefinitions {
            get { return BackingStore?.Get<List<UnifiedRoleDefinition>>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#endif
        /// <summary>Resource to grant access to users or groups that are transitive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleAssignment>? TransitiveRoleAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleAssignment>?>("transitiveRoleAssignments"); }
            set { BackingStore?.Set("transitiveRoleAssignments", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleAssignment> TransitiveRoleAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleAssignment>>("transitiveRoleAssignments"); }
            set { BackingStore?.Set("transitiveRoleAssignments", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRbacApplication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRbacApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"resourceNamespaces", n => { ResourceNamespaces = n.GetCollectionOfObjectValues<UnifiedRbacResourceNamespace>(UnifiedRbacResourceNamespace.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>(UnifiedRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"transitiveRoleAssignments", n => { TransitiveRoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignment>(UnifiedRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UnifiedRbacResourceNamespace>("resourceNamespaces", ResourceNamespaces);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<UnifiedRoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignment>("transitiveRoleAssignments", TransitiveRoleAssignments);
        }
    }
}
