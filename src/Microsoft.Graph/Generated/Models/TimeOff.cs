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
    public partial class TimeOff : global::Microsoft.Graph.Beta.Models.ChangeTrackedEntity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The draft version of this timeOff item that is viewable by managers. It must be shared before it is visible to team members. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TimeOffItem? DraftTimeOff
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeOffItem?>("draftTimeOff"); }
            set { BackingStore?.Set("draftTimeOff", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TimeOffItem DraftTimeOff
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeOffItem>("draftTimeOff"); }
            set { BackingStore?.Set("draftTimeOff", value); }
        }
#endif
        /// <summary>The timeOff is marked for deletion, a process that is finalized when the schedule is shared.</summary>
        public bool? IsStagedForDeletion
        {
            get { return BackingStore?.Get<bool?>("isStagedForDeletion"); }
            set { BackingStore?.Set("isStagedForDeletion", value); }
        }
        /// <summary>The shared version of this timeOff that is viewable by both employees and managers. Updates to the sharedTimeOff property send notifications to users in the Teams client. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TimeOffItem? SharedTimeOff
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeOffItem?>("sharedTimeOff"); }
            set { BackingStore?.Set("sharedTimeOff", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TimeOffItem SharedTimeOff
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeOffItem>("sharedTimeOff"); }
            set { BackingStore?.Set("sharedTimeOff", value); }
        }
#endif
        /// <summary>Information of the team that the timeOff is in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ShiftsTeamInfo? TeamInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ShiftsTeamInfo?>("teamInfo"); }
            set { BackingStore?.Set("teamInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ShiftsTeamInfo TeamInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ShiftsTeamInfo>("teamInfo"); }
            set { BackingStore?.Set("teamInfo", value); }
        }
#endif
        /// <summary>ID of the user assigned to the timeOff. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId
        {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId
        {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>Information of the user assigned to the timeOff.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ShiftsUserInfo? UserInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ShiftsUserInfo?>("userInfo"); }
            set { BackingStore?.Set("userInfo", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ShiftsUserInfo UserInfo
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ShiftsUserInfo>("userInfo"); }
            set { BackingStore?.Set("userInfo", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.TimeOff"/> and sets the default values.
        /// </summary>
        public TimeOff() : base()
        {
            OdataType = "#microsoft.graph.timeOff";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TimeOff"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.TimeOff CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.TimeOff();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "draftTimeOff", n => { DraftTimeOff = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TimeOffItem>(global::Microsoft.Graph.Beta.Models.TimeOffItem.CreateFromDiscriminatorValue); } },
                { "isStagedForDeletion", n => { IsStagedForDeletion = n.GetBoolValue(); } },
                { "sharedTimeOff", n => { SharedTimeOff = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TimeOffItem>(global::Microsoft.Graph.Beta.Models.TimeOffItem.CreateFromDiscriminatorValue); } },
                { "teamInfo", n => { TeamInfo = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ShiftsTeamInfo>(global::Microsoft.Graph.Beta.Models.ShiftsTeamInfo.CreateFromDiscriminatorValue); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userInfo", n => { UserInfo = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ShiftsUserInfo>(global::Microsoft.Graph.Beta.Models.ShiftsUserInfo.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TimeOffItem>("draftTimeOff", DraftTimeOff);
            writer.WriteBoolValue("isStagedForDeletion", IsStagedForDeletion);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TimeOffItem>("sharedTimeOff", SharedTimeOff);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
#pragma warning restore CS0618
