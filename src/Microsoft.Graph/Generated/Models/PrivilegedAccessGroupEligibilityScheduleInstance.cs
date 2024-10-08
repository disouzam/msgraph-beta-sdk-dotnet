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
    public partial class PrivilegedAccessGroupEligibilityScheduleInstance : global::Microsoft.Graph.Beta.Models.PrivilegedAccessScheduleInstance, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identifier of the membership or ownership eligibility relationship to the group. Required. The possible values are: owner, member. Supports $filter (eq).</summary>
        public global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupRelationships? AccessId
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupRelationships?>("accessId"); }
            set { BackingStore?.Set("accessId", value); }
        }
        /// <summary>The identifier of the privilegedAccessGroupEligibilitySchedule from which this instance was created. Required. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EligibilityScheduleId
        {
            get { return BackingStore?.Get<string?>("eligibilityScheduleId"); }
            set { BackingStore?.Set("eligibilityScheduleId", value); }
        }
#nullable restore
#else
        public string EligibilityScheduleId
        {
            get { return BackingStore?.Get<string>("eligibilityScheduleId"); }
            set { BackingStore?.Set("eligibilityScheduleId", value); }
        }
#endif
        /// <summary>References the group that is the scope of the membership or ownership eligibility through PIM for groups. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Group? Group
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Group?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Group Group
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Group>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>The identifier of the group representing the scope of the membership or ownership eligibility through PIM for groups. Required. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId
        {
            get { return BackingStore?.Get<string?>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#nullable restore
#else
        public string GroupId
        {
            get { return BackingStore?.Get<string>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#endif
        /// <summary>Indicates whether the assignment is derived from a group assignment. It can further imply whether the calling principal can manage the assignment schedule. Required. The possible values are: direct, group, unknownFutureValue. Supports $filter (eq).</summary>
        public global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupMemberType? MemberType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupMemberType?>("memberType"); }
            set { BackingStore?.Set("memberType", value); }
        }
        /// <summary>References the principal that&apos;s in the scope of the membership or ownership eligibility request through the group that&apos;s governed by PIM. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DirectoryObject? Principal
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DirectoryObject?>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DirectoryObject Principal
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DirectoryObject>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#endif
        /// <summary>The identifier of the principal whose membership or ownership eligibility to the group is managed through PIM for groups. Required. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId
        {
            get { return BackingStore?.Get<string?>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#nullable restore
#else
        public string PrincipalId
        {
            get { return BackingStore?.Get<string>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupEligibilityScheduleInstance"/> and sets the default values.
        /// </summary>
        public PrivilegedAccessGroupEligibilityScheduleInstance() : base()
        {
            OdataType = "#microsoft.graph.privilegedAccessGroupEligibilityScheduleInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupEligibilityScheduleInstance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupEligibilityScheduleInstance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupEligibilityScheduleInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessId", n => { AccessId = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupRelationships>(); } },
                { "eligibilityScheduleId", n => { EligibilityScheduleId = n.GetStringValue(); } },
                { "group", n => { Group = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Group>(global::Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue); } },
                { "groupId", n => { GroupId = n.GetStringValue(); } },
                { "memberType", n => { MemberType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupMemberType>(); } },
                { "principal", n => { Principal = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DirectoryObject>(global::Microsoft.Graph.Beta.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "principalId", n => { PrincipalId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupRelationships>("accessId", AccessId);
            writer.WriteStringValue("eligibilityScheduleId", EligibilityScheduleId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Group>("group", Group);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PrivilegedAccessGroupMemberType>("memberType", MemberType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
        }
    }
}
#pragma warning restore CS0618
