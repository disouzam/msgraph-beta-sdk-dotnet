// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class MeetingTimeSuggestion : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>An array that shows the availability status of each attendee for this meeting suggestion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AttendeeAvailability>? AttendeeAvailability
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AttendeeAvailability>?>("attendeeAvailability"); }
            set { BackingStore?.Set("attendeeAvailability", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AttendeeAvailability> AttendeeAvailability
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AttendeeAvailability>>("attendeeAvailability"); }
            set { BackingStore?.Set("attendeeAvailability", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A percentage that represents the likelhood of all the attendees attending.</summary>
        public double? Confidence
        {
            get { return BackingStore?.Get<double?>("confidence"); }
            set { BackingStore?.Set("confidence", value); }
        }
        /// <summary>An array that specifies the name and geographic location of each meeting location for this meeting suggestion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Location>? Locations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Location>?>("locations"); }
            set { BackingStore?.Set("locations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Location> Locations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Location>>("locations"); }
            set { BackingStore?.Set("locations", value); }
        }
#endif
        /// <summary>A time period suggested for the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TimeSlot? MeetingTimeSlot
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeSlot?>("meetingTimeSlot"); }
            set { BackingStore?.Set("meetingTimeSlot", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TimeSlot MeetingTimeSlot
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeSlot>("meetingTimeSlot"); }
            set { BackingStore?.Set("meetingTimeSlot", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Order of meeting time suggestions sorted by their computed confidence value from high to low, then by chronology if there are suggestions with the same confidence.</summary>
        public int? Order
        {
            get { return BackingStore?.Get<int?>("order"); }
            set { BackingStore?.Set("order", value); }
        }
        /// <summary>Availability of the meeting organizer for this meeting suggestion. Possible values are: free, tentative, busy, oof, workingElsewhere, unknown.</summary>
        public global::Microsoft.Graph.Beta.Models.FreeBusyStatus? OrganizerAvailability
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.FreeBusyStatus?>("organizerAvailability"); }
            set { BackingStore?.Set("organizerAvailability", value); }
        }
        /// <summary>Reason for suggesting the meeting time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SuggestionReason
        {
            get { return BackingStore?.Get<string?>("suggestionReason"); }
            set { BackingStore?.Set("suggestionReason", value); }
        }
#nullable restore
#else
        public string SuggestionReason
        {
            get { return BackingStore?.Get<string>("suggestionReason"); }
            set { BackingStore?.Set("suggestionReason", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MeetingTimeSuggestion"/> and sets the default values.
        /// </summary>
        public MeetingTimeSuggestion()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MeetingTimeSuggestion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.MeetingTimeSuggestion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MeetingTimeSuggestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attendeeAvailability", n => { AttendeeAvailability = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AttendeeAvailability>(global::Microsoft.Graph.Beta.Models.AttendeeAvailability.CreateFromDiscriminatorValue)?.AsList(); } },
                { "confidence", n => { Confidence = n.GetDoubleValue(); } },
                { "locations", n => { Locations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Location>(global::Microsoft.Graph.Beta.Models.Location.CreateFromDiscriminatorValue)?.AsList(); } },
                { "meetingTimeSlot", n => { MeetingTimeSlot = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TimeSlot>(global::Microsoft.Graph.Beta.Models.TimeSlot.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "order", n => { Order = n.GetIntValue(); } },
                { "organizerAvailability", n => { OrganizerAvailability = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.FreeBusyStatus>(); } },
                { "suggestionReason", n => { SuggestionReason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AttendeeAvailability>("attendeeAvailability", AttendeeAvailability);
            writer.WriteDoubleValue("confidence", Confidence);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Location>("locations", Locations);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TimeSlot>("meetingTimeSlot", MeetingTimeSlot);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("order", Order);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.FreeBusyStatus>("organizerAvailability", OrganizerAvailability);
            writer.WriteStringValue("suggestionReason", SuggestionReason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
