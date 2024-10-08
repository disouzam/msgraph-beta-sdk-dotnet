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
    public partial class VirtualEventRegistration : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Date and time when the registrant cancels their registration for the virtual event. Only appears when applicable. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CancelationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("cancelationDateTime"); }
            set { BackingStore?.Set("cancelationDateTime", value); }
        }
        /// <summary>Email address of the registrant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email
        {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email
        {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>First name of the registrant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName
        {
            get { return BackingStore?.Get<string?>("firstName"); }
            set { BackingStore?.Set("firstName", value); }
        }
#nullable restore
#else
        public string FirstName
        {
            get { return BackingStore?.Get<string>("firstName"); }
            set { BackingStore?.Set("firstName", value); }
        }
#endif
        /// <summary>Last name of the registrant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName
        {
            get { return BackingStore?.Get<string?>("lastName"); }
            set { BackingStore?.Set("lastName", value); }
        }
#nullable restore
#else
        public string LastName
        {
            get { return BackingStore?.Get<string>("lastName"); }
            set { BackingStore?.Set("lastName", value); }
        }
#endif
        /// <summary>The registrant&apos;s preferred language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredLanguage
        {
            get { return BackingStore?.Get<string?>("preferredLanguage"); }
            set { BackingStore?.Set("preferredLanguage", value); }
        }
#nullable restore
#else
        public string PreferredLanguage
        {
            get { return BackingStore?.Get<string>("preferredLanguage"); }
            set { BackingStore?.Set("preferredLanguage", value); }
        }
#endif
        /// <summary>The registrant&apos;s time zone details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredTimezone
        {
            get { return BackingStore?.Get<string?>("preferredTimezone"); }
            set { BackingStore?.Set("preferredTimezone", value); }
        }
#nullable restore
#else
        public string PreferredTimezone
        {
            get { return BackingStore?.Get<string>("preferredTimezone"); }
            set { BackingStore?.Set("preferredTimezone", value); }
        }
#endif
        /// <summary>Date and time when the registrant registers for the virtual event. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RegistrationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("registrationDateTime"); }
            set { BackingStore?.Set("registrationDateTime", value); }
        }
        /// <summary>The registrant&apos;s answer to the registration questions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionAnswer>? RegistrationQuestionAnswers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionAnswer>?>("registrationQuestionAnswers"); }
            set { BackingStore?.Set("registrationQuestionAnswers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionAnswer> RegistrationQuestionAnswers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionAnswer>>("registrationQuestionAnswers"); }
            set { BackingStore?.Set("registrationQuestionAnswers", value); }
        }
#endif
        /// <summary>The sessions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventSession>? Sessions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventSession>?>("sessions"); }
            set { BackingStore?.Set("sessions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventSession> Sessions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventSession>>("sessions"); }
            set { BackingStore?.Set("sessions", value); }
        }
#endif
        /// <summary>Registration status of the registrant. Read-only.</summary>
        public global::Microsoft.Graph.Beta.Models.VirtualEventAttendeeRegistrationStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VirtualEventAttendeeRegistrationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The registrant&apos;s ID in Microsoft Entra ID. Only appears when the registrant is registered in Microsoft Entra ID.</summary>
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.VirtualEventRegistration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.VirtualEventRegistration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.VirtualEventRegistration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "cancelationDateTime", n => { CancelationDateTime = n.GetDateTimeOffsetValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "firstName", n => { FirstName = n.GetStringValue(); } },
                { "lastName", n => { LastName = n.GetStringValue(); } },
                { "preferredLanguage", n => { PreferredLanguage = n.GetStringValue(); } },
                { "preferredTimezone", n => { PreferredTimezone = n.GetStringValue(); } },
                { "registrationDateTime", n => { RegistrationDateTime = n.GetDateTimeOffsetValue(); } },
                { "registrationQuestionAnswers", n => { RegistrationQuestionAnswers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionAnswer>(global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionAnswer.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sessions", n => { Sessions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventSession>(global::Microsoft.Graph.Beta.Models.VirtualEventSession.CreateFromDiscriminatorValue)?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.VirtualEventAttendeeRegistrationStatus>(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("cancelationDateTime", CancelationDateTime);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("firstName", FirstName);
            writer.WriteStringValue("lastName", LastName);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteStringValue("preferredTimezone", PreferredTimezone);
            writer.WriteDateTimeOffsetValue("registrationDateTime", RegistrationDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionAnswer>("registrationQuestionAnswers", RegistrationQuestionAnswers);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventSession>("sessions", Sessions);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.VirtualEventAttendeeRegistrationStatus>("status", Status);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
#pragma warning restore CS0618
