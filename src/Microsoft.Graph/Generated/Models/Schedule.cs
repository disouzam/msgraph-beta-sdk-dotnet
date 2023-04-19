using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Schedule : Entity, IParsable {
        /// <summary>Indicates whether the schedule is enabled for the team. Required.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>The offerShiftRequests property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OfferShiftRequest>? OfferShiftRequests {
            get { return BackingStore?.Get<List<OfferShiftRequest>?>("offerShiftRequests"); }
            set { BackingStore?.Set("offerShiftRequests", value); }
        }
#nullable restore
#else
        public List<OfferShiftRequest> OfferShiftRequests {
            get { return BackingStore?.Get<List<OfferShiftRequest>>("offerShiftRequests"); }
            set { BackingStore?.Set("offerShiftRequests", value); }
        }
#endif
        /// <summary>Indicates whether offer shift requests are enabled for the schedule.</summary>
        public bool? OfferShiftRequestsEnabled {
            get { return BackingStore?.Get<bool?>("offerShiftRequestsEnabled"); }
            set { BackingStore?.Set("offerShiftRequestsEnabled", value); }
        }
        /// <summary>The open shift requests in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OpenShiftChangeRequest>? OpenShiftChangeRequests {
            get { return BackingStore?.Get<List<OpenShiftChangeRequest>?>("openShiftChangeRequests"); }
            set { BackingStore?.Set("openShiftChangeRequests", value); }
        }
#nullable restore
#else
        public List<OpenShiftChangeRequest> OpenShiftChangeRequests {
            get { return BackingStore?.Get<List<OpenShiftChangeRequest>>("openShiftChangeRequests"); }
            set { BackingStore?.Set("openShiftChangeRequests", value); }
        }
#endif
        /// <summary>The set of open shifts in a scheduling group in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OpenShift>? OpenShifts {
            get { return BackingStore?.Get<List<OpenShift>?>("openShifts"); }
            set { BackingStore?.Set("openShifts", value); }
        }
#nullable restore
#else
        public List<OpenShift> OpenShifts {
            get { return BackingStore?.Get<List<OpenShift>>("openShifts"); }
            set { BackingStore?.Set("openShifts", value); }
        }
#endif
        /// <summary>Indicates whether open shifts are enabled for the schedule.</summary>
        public bool? OpenShiftsEnabled {
            get { return BackingStore?.Get<bool?>("openShiftsEnabled"); }
            set { BackingStore?.Set("openShiftsEnabled", value); }
        }
        /// <summary>The status of the schedule provisioning. The possible values are notStarted, running, completed, failed.</summary>
        public OperationStatus? ProvisionStatus {
            get { return BackingStore?.Get<OperationStatus?>("provisionStatus"); }
            set { BackingStore?.Set("provisionStatus", value); }
        }
        /// <summary>Additional information about why schedule provisioning failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisionStatusCode {
            get { return BackingStore?.Get<string?>("provisionStatusCode"); }
            set { BackingStore?.Set("provisionStatusCode", value); }
        }
#nullable restore
#else
        public string ProvisionStatusCode {
            get { return BackingStore?.Get<string>("provisionStatusCode"); }
            set { BackingStore?.Set("provisionStatusCode", value); }
        }
#endif
        /// <summary>The logical grouping of users in the schedule (usually by role).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SchedulingGroup>? SchedulingGroups {
            get { return BackingStore?.Get<List<SchedulingGroup>?>("schedulingGroups"); }
            set { BackingStore?.Set("schedulingGroups", value); }
        }
#nullable restore
#else
        public List<SchedulingGroup> SchedulingGroups {
            get { return BackingStore?.Get<List<SchedulingGroup>>("schedulingGroups"); }
            set { BackingStore?.Set("schedulingGroups", value); }
        }
#endif
        /// <summary>The shifts in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Shift>? Shifts {
            get { return BackingStore?.Get<List<Shift>?>("shifts"); }
            set { BackingStore?.Set("shifts", value); }
        }
#nullable restore
#else
        public List<Shift> Shifts {
            get { return BackingStore?.Get<List<Shift>>("shifts"); }
            set { BackingStore?.Set("shifts", value); }
        }
#endif
        /// <summary>The swap requests for shifts in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SwapShiftsChangeRequest>? SwapShiftsChangeRequests {
            get { return BackingStore?.Get<List<SwapShiftsChangeRequest>?>("swapShiftsChangeRequests"); }
            set { BackingStore?.Set("swapShiftsChangeRequests", value); }
        }
#nullable restore
#else
        public List<SwapShiftsChangeRequest> SwapShiftsChangeRequests {
            get { return BackingStore?.Get<List<SwapShiftsChangeRequest>>("swapShiftsChangeRequests"); }
            set { BackingStore?.Set("swapShiftsChangeRequests", value); }
        }
#endif
        /// <summary>Indicates whether swap shifts requests are enabled for the schedule.</summary>
        public bool? SwapShiftsRequestsEnabled {
            get { return BackingStore?.Get<bool?>("swapShiftsRequestsEnabled"); }
            set { BackingStore?.Set("swapShiftsRequestsEnabled", value); }
        }
        /// <summary>The timeCards property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TimeCard>? TimeCards {
            get { return BackingStore?.Get<List<TimeCard>?>("timeCards"); }
            set { BackingStore?.Set("timeCards", value); }
        }
#nullable restore
#else
        public List<TimeCard> TimeCards {
            get { return BackingStore?.Get<List<TimeCard>>("timeCards"); }
            set { BackingStore?.Set("timeCards", value); }
        }
#endif
        /// <summary>Indicates whether time clock is enabled for the schedule.</summary>
        public bool? TimeClockEnabled {
            get { return BackingStore?.Get<bool?>("timeClockEnabled"); }
            set { BackingStore?.Set("timeClockEnabled", value); }
        }
        /// <summary>The timeClockSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TimeClockSettings? TimeClockSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TimeClockSettings?>("timeClockSettings"); }
            set { BackingStore?.Set("timeClockSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TimeClockSettings TimeClockSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TimeClockSettings>("timeClockSettings"); }
            set { BackingStore?.Set("timeClockSettings", value); }
        }
#endif
        /// <summary>The set of reasons for a time off in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TimeOffReason>? TimeOffReasons {
            get { return BackingStore?.Get<List<TimeOffReason>?>("timeOffReasons"); }
            set { BackingStore?.Set("timeOffReasons", value); }
        }
#nullable restore
#else
        public List<TimeOffReason> TimeOffReasons {
            get { return BackingStore?.Get<List<TimeOffReason>>("timeOffReasons"); }
            set { BackingStore?.Set("timeOffReasons", value); }
        }
#endif
        /// <summary>The time off requests in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TimeOffRequest>? TimeOffRequests {
            get { return BackingStore?.Get<List<TimeOffRequest>?>("timeOffRequests"); }
            set { BackingStore?.Set("timeOffRequests", value); }
        }
#nullable restore
#else
        public List<TimeOffRequest> TimeOffRequests {
            get { return BackingStore?.Get<List<TimeOffRequest>>("timeOffRequests"); }
            set { BackingStore?.Set("timeOffRequests", value); }
        }
#endif
        /// <summary>Indicates whether time off requests are enabled for the schedule.</summary>
        public bool? TimeOffRequestsEnabled {
            get { return BackingStore?.Get<bool?>("timeOffRequestsEnabled"); }
            set { BackingStore?.Set("timeOffRequestsEnabled", value); }
        }
        /// <summary>The instances of times off in the schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TimeOff>? TimesOff {
            get { return BackingStore?.Get<List<TimeOff>?>("timesOff"); }
            set { BackingStore?.Set("timesOff", value); }
        }
#nullable restore
#else
        public List<TimeOff> TimesOff {
            get { return BackingStore?.Get<List<TimeOff>>("timesOff"); }
            set { BackingStore?.Set("timesOff", value); }
        }
#endif
        /// <summary>Indicates the time zone of the schedule team using tz database format. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeZone {
            get { return BackingStore?.Get<string?>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#nullable restore
#else
        public string TimeZone {
            get { return BackingStore?.Get<string>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#endif
        /// <summary>The workforceIntegrationIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WorkforceIntegrationIds {
            get { return BackingStore?.Get<List<string>?>("workforceIntegrationIds"); }
            set { BackingStore?.Set("workforceIntegrationIds", value); }
        }
#nullable restore
#else
        public List<string> WorkforceIntegrationIds {
            get { return BackingStore?.Get<List<string>>("workforceIntegrationIds"); }
            set { BackingStore?.Set("workforceIntegrationIds", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Schedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Schedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"offerShiftRequests", n => { OfferShiftRequests = n.GetCollectionOfObjectValues<OfferShiftRequest>(OfferShiftRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"offerShiftRequestsEnabled", n => { OfferShiftRequestsEnabled = n.GetBoolValue(); } },
                {"openShiftChangeRequests", n => { OpenShiftChangeRequests = n.GetCollectionOfObjectValues<OpenShiftChangeRequest>(OpenShiftChangeRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"openShifts", n => { OpenShifts = n.GetCollectionOfObjectValues<OpenShift>(OpenShift.CreateFromDiscriminatorValue)?.ToList(); } },
                {"openShiftsEnabled", n => { OpenShiftsEnabled = n.GetBoolValue(); } },
                {"provisionStatus", n => { ProvisionStatus = n.GetEnumValue<OperationStatus>(); } },
                {"provisionStatusCode", n => { ProvisionStatusCode = n.GetStringValue(); } },
                {"schedulingGroups", n => { SchedulingGroups = n.GetCollectionOfObjectValues<SchedulingGroup>(SchedulingGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"shifts", n => { Shifts = n.GetCollectionOfObjectValues<Shift>(Shift.CreateFromDiscriminatorValue)?.ToList(); } },
                {"swapShiftsChangeRequests", n => { SwapShiftsChangeRequests = n.GetCollectionOfObjectValues<SwapShiftsChangeRequest>(SwapShiftsChangeRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"swapShiftsRequestsEnabled", n => { SwapShiftsRequestsEnabled = n.GetBoolValue(); } },
                {"timeCards", n => { TimeCards = n.GetCollectionOfObjectValues<TimeCard>(TimeCard.CreateFromDiscriminatorValue)?.ToList(); } },
                {"timeClockEnabled", n => { TimeClockEnabled = n.GetBoolValue(); } },
                {"timeClockSettings", n => { TimeClockSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.TimeClockSettings>(Microsoft.Graph.Beta.Models.TimeClockSettings.CreateFromDiscriminatorValue); } },
                {"timeOffReasons", n => { TimeOffReasons = n.GetCollectionOfObjectValues<TimeOffReason>(TimeOffReason.CreateFromDiscriminatorValue)?.ToList(); } },
                {"timeOffRequests", n => { TimeOffRequests = n.GetCollectionOfObjectValues<TimeOffRequest>(TimeOffRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"timeOffRequestsEnabled", n => { TimeOffRequestsEnabled = n.GetBoolValue(); } },
                {"timesOff", n => { TimesOff = n.GetCollectionOfObjectValues<TimeOff>(TimeOff.CreateFromDiscriminatorValue)?.ToList(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
                {"workforceIntegrationIds", n => { WorkforceIntegrationIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteCollectionOfObjectValues<OfferShiftRequest>("offerShiftRequests", OfferShiftRequests);
            writer.WriteBoolValue("offerShiftRequestsEnabled", OfferShiftRequestsEnabled);
            writer.WriteCollectionOfObjectValues<OpenShiftChangeRequest>("openShiftChangeRequests", OpenShiftChangeRequests);
            writer.WriteCollectionOfObjectValues<OpenShift>("openShifts", OpenShifts);
            writer.WriteBoolValue("openShiftsEnabled", OpenShiftsEnabled);
            writer.WriteCollectionOfObjectValues<SchedulingGroup>("schedulingGroups", SchedulingGroups);
            writer.WriteCollectionOfObjectValues<Shift>("shifts", Shifts);
            writer.WriteCollectionOfObjectValues<SwapShiftsChangeRequest>("swapShiftsChangeRequests", SwapShiftsChangeRequests);
            writer.WriteBoolValue("swapShiftsRequestsEnabled", SwapShiftsRequestsEnabled);
            writer.WriteCollectionOfObjectValues<TimeCard>("timeCards", TimeCards);
            writer.WriteBoolValue("timeClockEnabled", TimeClockEnabled);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TimeClockSettings>("timeClockSettings", TimeClockSettings);
            writer.WriteCollectionOfObjectValues<TimeOffReason>("timeOffReasons", TimeOffReasons);
            writer.WriteCollectionOfObjectValues<TimeOffRequest>("timeOffRequests", TimeOffRequests);
            writer.WriteBoolValue("timeOffRequestsEnabled", TimeOffRequestsEnabled);
            writer.WriteCollectionOfObjectValues<TimeOff>("timesOff", TimesOff);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteCollectionOfPrimitiveValues<string>("workforceIntegrationIds", WorkforceIntegrationIds);
        }
    }
}
