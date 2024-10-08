// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Represents a particular service offered by a booking business.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class BookingService : global::Microsoft.Graph.Beta.Models.BookingNamedEntity, IParsable
    {
        /// <summary>Additional information that is sent to the customer when an appointment is confirmed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation
        {
            get { return BackingStore?.Get<string?>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#nullable restore
#else
        public string AdditionalInformation
        {
            get { return BackingStore?.Get<string>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#endif
        /// <summary>The date, time and timezone when the Service was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Contains the set of custom questions associated with a particular service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.BookingQuestionAssignment>? CustomQuestions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.BookingQuestionAssignment>?>("customQuestions"); }
            set { BackingStore?.Set("customQuestions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.BookingQuestionAssignment> CustomQuestions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.BookingQuestionAssignment>>("customQuestions"); }
            set { BackingStore?.Set("customQuestions", value); }
        }
#endif
        /// <summary>The default length of the service, represented in numbers of days, hours, minutes, and seconds. For example, P11D23H59M59.999999999999S.</summary>
        public TimeSpan? DefaultDuration
        {
            get { return BackingStore?.Get<TimeSpan?>("defaultDuration"); }
            set { BackingStore?.Set("defaultDuration", value); }
        }
        /// <summary>The default physical location for the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Location? DefaultLocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Location?>("defaultLocation"); }
            set { BackingStore?.Set("defaultLocation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Location DefaultLocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Location>("defaultLocation"); }
            set { BackingStore?.Set("defaultLocation", value); }
        }
#endif
        /// <summary>The default monetary price for the service.</summary>
        public double? DefaultPrice
        {
            get { return BackingStore?.Get<double?>("defaultPrice"); }
            set { BackingStore?.Set("defaultPrice", value); }
        }
        /// <summary>Represents the type of pricing of a booking service.</summary>
        public global::Microsoft.Graph.Beta.Models.BookingPriceType? DefaultPriceType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.BookingPriceType?>("defaultPriceType"); }
            set { BackingStore?.Set("defaultPriceType", value); }
        }
        /// <summary>The default set of reminders for an appointment of this service. The value of this property is available only when reading this bookingService by its ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.BookingReminder>? DefaultReminders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.BookingReminder>?>("defaultReminders"); }
            set { BackingStore?.Set("defaultReminders", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.BookingReminder> DefaultReminders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.BookingReminder>>("defaultReminders"); }
            set { BackingStore?.Set("defaultReminders", value); }
        }
#endif
        /// <summary>A text description for the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Indicates if an anonymousJoinWebUrl(webrtcUrl) is generated for the appointment booked for this service. The default value is false.</summary>
        public bool? IsAnonymousJoinEnabled
        {
            get { return BackingStore?.Get<bool?>("isAnonymousJoinEnabled"); }
            set { BackingStore?.Set("isAnonymousJoinEnabled", value); }
        }
        /// <summary>Indicates that the customer can manage bookings created by the staff. The default value is false.</summary>
        public bool? IsCustomerAllowedToManageBooking
        {
            get { return BackingStore?.Get<bool?>("isCustomerAllowedToManageBooking"); }
            set { BackingStore?.Set("isCustomerAllowedToManageBooking", value); }
        }
        /// <summary>True means this service isn&apos;t available to customers for booking.</summary>
        public bool? IsHiddenFromCustomers
        {
            get { return BackingStore?.Get<bool?>("isHiddenFromCustomers"); }
            set { BackingStore?.Set("isHiddenFromCustomers", value); }
        }
        /// <summary>Indicates that the appointments for the service are held online. The default value is false.</summary>
        public bool? IsLocationOnline
        {
            get { return BackingStore?.Get<bool?>("isLocationOnline"); }
            set { BackingStore?.Set("isLocationOnline", value); }
        }
        /// <summary>The language of the self service booking page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageTag
        {
            get { return BackingStore?.Get<string?>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#nullable restore
#else
        public string LanguageTag
        {
            get { return BackingStore?.Get<string>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#endif
        /// <summary>The date, time and timezone when the Service  was last updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The maximum number of customers allowed in a service. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment.  To create a customer, use the Create bookingCustomer operation.</summary>
        public int? MaximumAttendeesCount
        {
            get { return BackingStore?.Get<int?>("maximumAttendeesCount"); }
            set { BackingStore?.Set("maximumAttendeesCount", value); }
        }
        /// <summary>Additional information about this service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes
        {
            get { return BackingStore?.Get<string?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public string Notes
        {
            get { return BackingStore?.Get<string>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>The time to buffer after an appointment for this service ends, and before the next customer appointment can be booked.</summary>
        public TimeSpan? PostBuffer
        {
            get { return BackingStore?.Get<TimeSpan?>("postBuffer"); }
            set { BackingStore?.Set("postBuffer", value); }
        }
        /// <summary>The time to buffer before an appointment for this service can start.</summary>
        public TimeSpan? PreBuffer
        {
            get { return BackingStore?.Get<TimeSpan?>("preBuffer"); }
            set { BackingStore?.Set("preBuffer", value); }
        }
        /// <summary>The set of policies that determine how appointments for this type of service should be created and managed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.BookingSchedulingPolicy? SchedulingPolicy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.BookingSchedulingPolicy?>("schedulingPolicy"); }
            set { BackingStore?.Set("schedulingPolicy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.BookingSchedulingPolicy SchedulingPolicy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.BookingSchedulingPolicy>("schedulingPolicy"); }
            set { BackingStore?.Set("schedulingPolicy", value); }
        }
#endif
        /// <summary>True indicates SMS notifications can be sent to the customers for the appointment of the service. Default value is false.</summary>
        public bool? SmsNotificationsEnabled
        {
            get { return BackingStore?.Get<bool?>("smsNotificationsEnabled"); }
            set { BackingStore?.Set("smsNotificationsEnabled", value); }
        }
        /// <summary>Represents those staff members who provide this service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StaffMemberIds
        {
            get { return BackingStore?.Get<List<string>?>("staffMemberIds"); }
            set { BackingStore?.Set("staffMemberIds", value); }
        }
#nullable restore
#else
        public List<string> StaffMemberIds
        {
            get { return BackingStore?.Get<List<string>>("staffMemberIds"); }
            set { BackingStore?.Set("staffMemberIds", value); }
        }
#endif
        /// <summary>The URL a customer uses to access the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.BookingService"/> and sets the default values.
        /// </summary>
        public BookingService() : base()
        {
            OdataType = "#microsoft.graph.bookingService";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.BookingService"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.BookingService CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.BookingService();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customQuestions", n => { CustomQuestions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.BookingQuestionAssignment>(global::Microsoft.Graph.Beta.Models.BookingQuestionAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "defaultDuration", n => { DefaultDuration = n.GetTimeSpanValue(); } },
                { "defaultLocation", n => { DefaultLocation = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Location>(global::Microsoft.Graph.Beta.Models.Location.CreateFromDiscriminatorValue); } },
                { "defaultPrice", n => { DefaultPrice = n.GetDoubleValue(); } },
                { "defaultPriceType", n => { DefaultPriceType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.BookingPriceType>(); } },
                { "defaultReminders", n => { DefaultReminders = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.BookingReminder>(global::Microsoft.Graph.Beta.Models.BookingReminder.CreateFromDiscriminatorValue)?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "isAnonymousJoinEnabled", n => { IsAnonymousJoinEnabled = n.GetBoolValue(); } },
                { "isCustomerAllowedToManageBooking", n => { IsCustomerAllowedToManageBooking = n.GetBoolValue(); } },
                { "isHiddenFromCustomers", n => { IsHiddenFromCustomers = n.GetBoolValue(); } },
                { "isLocationOnline", n => { IsLocationOnline = n.GetBoolValue(); } },
                { "languageTag", n => { LanguageTag = n.GetStringValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "maximumAttendeesCount", n => { MaximumAttendeesCount = n.GetIntValue(); } },
                { "notes", n => { Notes = n.GetStringValue(); } },
                { "postBuffer", n => { PostBuffer = n.GetTimeSpanValue(); } },
                { "preBuffer", n => { PreBuffer = n.GetTimeSpanValue(); } },
                { "schedulingPolicy", n => { SchedulingPolicy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.BookingSchedulingPolicy>(global::Microsoft.Graph.Beta.Models.BookingSchedulingPolicy.CreateFromDiscriminatorValue); } },
                { "smsNotificationsEnabled", n => { SmsNotificationsEnabled = n.GetBoolValue(); } },
                { "staffMemberIds", n => { StaffMemberIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.BookingQuestionAssignment>("customQuestions", CustomQuestions);
            writer.WriteTimeSpanValue("defaultDuration", DefaultDuration);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Location>("defaultLocation", DefaultLocation);
            writer.WriteDoubleValue("defaultPrice", DefaultPrice);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.BookingPriceType>("defaultPriceType", DefaultPriceType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.BookingReminder>("defaultReminders", DefaultReminders);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isAnonymousJoinEnabled", IsAnonymousJoinEnabled);
            writer.WriteBoolValue("isCustomerAllowedToManageBooking", IsCustomerAllowedToManageBooking);
            writer.WriteBoolValue("isHiddenFromCustomers", IsHiddenFromCustomers);
            writer.WriteBoolValue("isLocationOnline", IsLocationOnline);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteIntValue("maximumAttendeesCount", MaximumAttendeesCount);
            writer.WriteStringValue("notes", Notes);
            writer.WriteTimeSpanValue("postBuffer", PostBuffer);
            writer.WriteTimeSpanValue("preBuffer", PreBuffer);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.BookingSchedulingPolicy>("schedulingPolicy", SchedulingPolicy);
            writer.WriteBoolValue("smsNotificationsEnabled", SmsNotificationsEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("staffMemberIds", StaffMemberIds);
        }
    }
}
#pragma warning restore CS0618
