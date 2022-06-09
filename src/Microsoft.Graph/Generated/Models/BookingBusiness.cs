using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class BookingBusiness : BookingNamedEntity, IParsable {
        /// <summary>The street address of the business. The address property, together with phone and webSiteUrl, appear in the footer of a business scheduling page.</summary>
        public PhysicalAddress Address {
            get { return BackingStore?.Get<PhysicalAddress>(nameof(Address)); }
            set { BackingStore?.Set(nameof(Address), value); }
        }
        /// <summary>All the appointments of this business. Read-only. Nullable.</summary>
        public List<BookingAppointment> Appointments {
            get { return BackingStore?.Get<List<BookingAppointment>>(nameof(Appointments)); }
            set { BackingStore?.Set(nameof(Appointments), value); }
        }
        /// <summary>The hours of operation for the business.</summary>
        public List<BookingWorkHours> BusinessHours {
            get { return BackingStore?.Get<List<BookingWorkHours>>(nameof(BusinessHours)); }
            set { BackingStore?.Set(nameof(BusinessHours), value); }
        }
        /// <summary>The type of business.</summary>
        public string BusinessType {
            get { return BackingStore?.Get<string>(nameof(BusinessType)); }
            set { BackingStore?.Set(nameof(BusinessType), value); }
        }
        /// <summary>The set of appointments of this business in a specified date range. Read-only. Nullable.</summary>
        public List<BookingAppointment> CalendarView {
            get { return BackingStore?.Get<List<BookingAppointment>>(nameof(CalendarView)); }
            set { BackingStore?.Set(nameof(CalendarView), value); }
        }
        /// <summary>All the customers of this business. Read-only. Nullable.</summary>
        public List<BookingCustomer> Customers {
            get { return BackingStore?.Get<List<BookingCustomer>>(nameof(Customers)); }
            set { BackingStore?.Set(nameof(Customers), value); }
        }
        /// <summary>All the custom questions of this business. Read-only. Nullable.</summary>
        public List<BookingCustomQuestion> CustomQuestions {
            get { return BackingStore?.Get<List<BookingCustomQuestion>>(nameof(CustomQuestions)); }
            set { BackingStore?.Set(nameof(CustomQuestions), value); }
        }
        /// <summary>The code for the currency that the business operates in on Microsoft Bookings.</summary>
        public string DefaultCurrencyIso {
            get { return BackingStore?.Get<string>(nameof(DefaultCurrencyIso)); }
            set { BackingStore?.Set(nameof(DefaultCurrencyIso), value); }
        }
        /// <summary>The email address for the business.</summary>
        public string Email {
            get { return BackingStore?.Get<string>(nameof(Email)); }
            set { BackingStore?.Set(nameof(Email), value); }
        }
        /// <summary>The scheduling page has been made available to external customers. Use the publish and unpublish actions to set this property. Read-only.</summary>
        public bool? IsPublished {
            get { return BackingStore?.Get<bool?>(nameof(IsPublished)); }
            set { BackingStore?.Set(nameof(IsPublished), value); }
        }
        /// <summary>The languageTag property</summary>
        public string LanguageTag {
            get { return BackingStore?.Get<string>(nameof(LanguageTag)); }
            set { BackingStore?.Set(nameof(LanguageTag), value); }
        }
        /// <summary>The telephone number for the business. The phone property, together with address and webSiteUrl, appear in the footer of a business scheduling page.</summary>
        public string Phone {
            get { return BackingStore?.Get<string>(nameof(Phone)); }
            set { BackingStore?.Set(nameof(Phone), value); }
        }
        /// <summary>The URL for the scheduling page, which is set after you publish or unpublish the page. Read-only.</summary>
        public string PublicUrl {
            get { return BackingStore?.Get<string>(nameof(PublicUrl)); }
            set { BackingStore?.Set(nameof(PublicUrl), value); }
        }
        /// <summary>Specifies how bookings can be created for this business.</summary>
        public BookingSchedulingPolicy SchedulingPolicy {
            get { return BackingStore?.Get<BookingSchedulingPolicy>(nameof(SchedulingPolicy)); }
            set { BackingStore?.Set(nameof(SchedulingPolicy), value); }
        }
        /// <summary>All the services offered by this business. Read-only. Nullable.</summary>
        public List<BookingService> Services {
            get { return BackingStore?.Get<List<BookingService>>(nameof(Services)); }
            set { BackingStore?.Set(nameof(Services), value); }
        }
        /// <summary>All the staff members that provide services in this business. Read-only. Nullable.</summary>
        public List<BookingStaffMember> StaffMembers {
            get { return BackingStore?.Get<List<BookingStaffMember>>(nameof(StaffMembers)); }
            set { BackingStore?.Set(nameof(StaffMembers), value); }
        }
        /// <summary>The URL of the business web site. The webSiteUrl property, together with address, phone, appear in the footer of a business scheduling page.</summary>
        public string WebSiteUrl {
            get { return BackingStore?.Get<string>(nameof(WebSiteUrl)); }
            set { BackingStore?.Set(nameof(WebSiteUrl), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new BookingBusiness CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingBusiness();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"address", n => { Address = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"appointments", n => { Appointments = n.GetCollectionOfObjectValues<BookingAppointment>(BookingAppointment.CreateFromDiscriminatorValue).ToList(); } },
                {"businessHours", n => { BusinessHours = n.GetCollectionOfObjectValues<BookingWorkHours>(BookingWorkHours.CreateFromDiscriminatorValue).ToList(); } },
                {"businessType", n => { BusinessType = n.GetStringValue(); } },
                {"calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<BookingAppointment>(BookingAppointment.CreateFromDiscriminatorValue).ToList(); } },
                {"customers", n => { Customers = n.GetCollectionOfObjectValues<BookingCustomer>(BookingCustomer.CreateFromDiscriminatorValue).ToList(); } },
                {"customQuestions", n => { CustomQuestions = n.GetCollectionOfObjectValues<BookingCustomQuestion>(BookingCustomQuestion.CreateFromDiscriminatorValue).ToList(); } },
                {"defaultCurrencyIso", n => { DefaultCurrencyIso = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"isPublished", n => { IsPublished = n.GetBoolValue(); } },
                {"languageTag", n => { LanguageTag = n.GetStringValue(); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"publicUrl", n => { PublicUrl = n.GetStringValue(); } },
                {"schedulingPolicy", n => { SchedulingPolicy = n.GetObjectValue<BookingSchedulingPolicy>(BookingSchedulingPolicy.CreateFromDiscriminatorValue); } },
                {"services", n => { Services = n.GetCollectionOfObjectValues<BookingService>(BookingService.CreateFromDiscriminatorValue).ToList(); } },
                {"staffMembers", n => { StaffMembers = n.GetCollectionOfObjectValues<BookingStaffMember>(BookingStaffMember.CreateFromDiscriminatorValue).ToList(); } },
                {"webSiteUrl", n => { WebSiteUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PhysicalAddress>("address", Address);
            writer.WriteCollectionOfObjectValues<BookingAppointment>("appointments", Appointments);
            writer.WriteCollectionOfObjectValues<BookingWorkHours>("businessHours", BusinessHours);
            writer.WriteStringValue("businessType", BusinessType);
            writer.WriteCollectionOfObjectValues<BookingAppointment>("calendarView", CalendarView);
            writer.WriteCollectionOfObjectValues<BookingCustomer>("customers", Customers);
            writer.WriteCollectionOfObjectValues<BookingCustomQuestion>("customQuestions", CustomQuestions);
            writer.WriteStringValue("defaultCurrencyIso", DefaultCurrencyIso);
            writer.WriteStringValue("email", Email);
            writer.WriteBoolValue("isPublished", IsPublished);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("publicUrl", PublicUrl);
            writer.WriteObjectValue<BookingSchedulingPolicy>("schedulingPolicy", SchedulingPolicy);
            writer.WriteCollectionOfObjectValues<BookingService>("services", Services);
            writer.WriteCollectionOfObjectValues<BookingStaffMember>("staffMembers", StaffMembers);
            writer.WriteStringValue("webSiteUrl", WebSiteUrl);
        }
    }
}
