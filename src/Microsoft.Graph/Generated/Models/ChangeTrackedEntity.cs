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
    public partial class ChangeTrackedEntity : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Identity of the user who created the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentitySet? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentitySet CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Identity of the user who last modified the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentitySet? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentitySet LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ChangeTrackedEntity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ChangeTrackedEntity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.dayNote" => new global::Microsoft.Graph.Beta.Models.DayNote(),
                "#microsoft.graph.offerShiftRequest" => new global::Microsoft.Graph.Beta.Models.OfferShiftRequest(),
                "#microsoft.graph.openShift" => new global::Microsoft.Graph.Beta.Models.OpenShift(),
                "#microsoft.graph.openShiftChangeRequest" => new global::Microsoft.Graph.Beta.Models.OpenShiftChangeRequest(),
                "#microsoft.graph.scheduleChangeRequest" => new global::Microsoft.Graph.Beta.Models.ScheduleChangeRequest(),
                "#microsoft.graph.schedulingGroup" => new global::Microsoft.Graph.Beta.Models.SchedulingGroup(),
                "#microsoft.graph.shift" => new global::Microsoft.Graph.Beta.Models.Shift(),
                "#microsoft.graph.shiftPreferences" => new global::Microsoft.Graph.Beta.Models.ShiftPreferences(),
                "#microsoft.graph.swapShiftsChangeRequest" => new global::Microsoft.Graph.Beta.Models.SwapShiftsChangeRequest(),
                "#microsoft.graph.timeCard" => new global::Microsoft.Graph.Beta.Models.TimeCard(),
                "#microsoft.graph.timeOff" => new global::Microsoft.Graph.Beta.Models.TimeOff(),
                "#microsoft.graph.timeOffReason" => new global::Microsoft.Graph.Beta.Models.TimeOffReason(),
                "#microsoft.graph.timeOffRequest" => new global::Microsoft.Graph.Beta.Models.TimeOffRequest(),
                "#microsoft.graph.workforceIntegration" => new global::Microsoft.Graph.Beta.Models.WorkforceIntegration(),
                _ => new global::Microsoft.Graph.Beta.Models.ChangeTrackedEntity(),
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
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>(global::Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>(global::Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>("createdBy", CreatedBy);
        }
    }
}
#pragma warning restore CS0618
