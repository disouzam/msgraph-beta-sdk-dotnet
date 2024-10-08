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
    public partial class PermissionsManagement : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents a change event of the scheduledPermissionsRequest entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.PermissionsRequestChange>? PermissionsRequestChanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PermissionsRequestChange>?>("permissionsRequestChanges"); }
            set { BackingStore?.Set("permissionsRequestChanges", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.PermissionsRequestChange> PermissionsRequestChanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PermissionsRequestChange>>("permissionsRequestChanges"); }
            set { BackingStore?.Set("permissionsRequestChanges", value); }
        }
#endif
        /// <summary>The scheduledPermissionsApprovals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Approval>? ScheduledPermissionsApprovals
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Approval>?>("scheduledPermissionsApprovals"); }
            set { BackingStore?.Set("scheduledPermissionsApprovals", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Approval> ScheduledPermissionsApprovals
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Approval>>("scheduledPermissionsApprovals"); }
            set { BackingStore?.Set("scheduledPermissionsApprovals", value); }
        }
#endif
        /// <summary>Represents a permissions request that Permissions Management uses to manage permissions for an identity on resources in the authorization system. This request can be granted, rejected or canceled by identities in Permissions Management.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ScheduledPermissionsRequest>? ScheduledPermissionsRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ScheduledPermissionsRequest>?>("scheduledPermissionsRequests"); }
            set { BackingStore?.Set("scheduledPermissionsRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ScheduledPermissionsRequest> ScheduledPermissionsRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ScheduledPermissionsRequest>>("scheduledPermissionsRequests"); }
            set { BackingStore?.Set("scheduledPermissionsRequests", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PermissionsManagement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.PermissionsManagement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.PermissionsManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "permissionsRequestChanges", n => { PermissionsRequestChanges = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PermissionsRequestChange>(global::Microsoft.Graph.Beta.Models.PermissionsRequestChange.CreateFromDiscriminatorValue)?.AsList(); } },
                { "scheduledPermissionsApprovals", n => { ScheduledPermissionsApprovals = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Approval>(global::Microsoft.Graph.Beta.Models.Approval.CreateFromDiscriminatorValue)?.AsList(); } },
                { "scheduledPermissionsRequests", n => { ScheduledPermissionsRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ScheduledPermissionsRequest>(global::Microsoft.Graph.Beta.Models.ScheduledPermissionsRequest.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PermissionsRequestChange>("permissionsRequestChanges", PermissionsRequestChanges);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Approval>("scheduledPermissionsApprovals", ScheduledPermissionsApprovals);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ScheduledPermissionsRequest>("scheduledPermissionsRequests", ScheduledPermissionsRequests);
        }
    }
}
#pragma warning restore CS0618
