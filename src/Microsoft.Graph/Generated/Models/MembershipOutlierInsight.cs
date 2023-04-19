using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MembershipOutlierInsight : GovernanceInsight, IParsable {
        /// <summary>Navigation link to the container directory object. For example, to a group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? Container {
            get { return BackingStore?.Get<DirectoryObject?>("container"); }
            set { BackingStore?.Set("container", value); }
        }
#nullable restore
#else
        public DirectoryObject Container {
            get { return BackingStore?.Get<DirectoryObject>("container"); }
            set { BackingStore?.Set("container", value); }
        }
#endif
        /// <summary>Indicates the identifier of the container, for example, a group ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerId {
            get { return BackingStore?.Get<string?>("containerId"); }
            set { BackingStore?.Set("containerId", value); }
        }
#nullable restore
#else
        public string ContainerId {
            get { return BackingStore?.Get<string>("containerId"); }
            set { BackingStore?.Set("containerId", value); }
        }
#endif
        /// <summary>The lastModifiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public User? LastModifiedBy {
            get { return BackingStore?.Get<User?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public User LastModifiedBy {
            get { return BackingStore?.Get<User>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>Navigation link to a member object. For example, to a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? Member {
            get { return BackingStore?.Get<DirectoryObject?>("member"); }
            set { BackingStore?.Set("member", value); }
        }
#nullable restore
#else
        public DirectoryObject Member {
            get { return BackingStore?.Get<DirectoryObject>("member"); }
            set { BackingStore?.Set("member", value); }
        }
#endif
        /// <summary>Indicates the identifier of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberId {
            get { return BackingStore?.Get<string?>("memberId"); }
            set { BackingStore?.Set("memberId", value); }
        }
#nullable restore
#else
        public string MemberId {
            get { return BackingStore?.Get<string>("memberId"); }
            set { BackingStore?.Set("memberId", value); }
        }
#endif
        /// <summary>The outlierContainerType property</summary>
        public Microsoft.Graph.Beta.Models.OutlierContainerType? OutlierContainerType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OutlierContainerType?>("outlierContainerType"); }
            set { BackingStore?.Set("outlierContainerType", value); }
        }
        /// <summary>The outlierMemberType property</summary>
        public Microsoft.Graph.Beta.Models.OutlierMemberType? OutlierMemberType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OutlierMemberType?>("outlierMemberType"); }
            set { BackingStore?.Set("outlierMemberType", value); }
        }
        /// <summary>
        /// Instantiates a new MembershipOutlierInsight and sets the default values.
        /// </summary>
        public MembershipOutlierInsight() : base() {
            OdataType = "#microsoft.graph.membershipOutlierInsight";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MembershipOutlierInsight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MembershipOutlierInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"container", n => { Container = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"containerId", n => { ContainerId = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<User>(User.CreateFromDiscriminatorValue); } },
                {"member", n => { Member = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"memberId", n => { MemberId = n.GetStringValue(); } },
                {"outlierContainerType", n => { OutlierContainerType = n.GetEnumValue<OutlierContainerType>(); } },
                {"outlierMemberType", n => { OutlierMemberType = n.GetEnumValue<OutlierMemberType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DirectoryObject>("container", Container);
            writer.WriteStringValue("containerId", ContainerId);
            writer.WriteObjectValue<User>("lastModifiedBy", LastModifiedBy);
            writer.WriteObjectValue<DirectoryObject>("member", Member);
            writer.WriteStringValue("memberId", MemberId);
            writer.WriteEnumValue<OutlierContainerType>("outlierContainerType", OutlierContainerType);
            writer.WriteEnumValue<OutlierMemberType>("outlierMemberType", OutlierMemberType);
        }
    }
}
