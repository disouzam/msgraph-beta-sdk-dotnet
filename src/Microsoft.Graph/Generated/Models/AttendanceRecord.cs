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
    public partial class AttendanceRecord : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of time periods between joining and leaving a meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AttendanceInterval>? AttendanceIntervals
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AttendanceInterval>?>("attendanceIntervals"); }
            set { BackingStore?.Set("attendanceIntervals", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AttendanceInterval> AttendanceIntervals
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AttendanceInterval>>("attendanceIntervals"); }
            set { BackingStore?.Set("attendanceIntervals", value); }
        }
#endif
        /// <summary>Email address of the user associated with this attendance record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress
        {
            get { return BackingStore?.Get<string?>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#nullable restore
#else
        public string EmailAddress
        {
            get { return BackingStore?.Get<string>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#endif
        /// <summary>Identity of the user associated with this attendance record. The specific type will be one of the following derived types of identity, depending on the type of the user: communicationsUserIdentity, azureCommunicationServicesUserIdentity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Identity? Identity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Identity?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Identity Identity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Identity>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
        /// <summary>Unique identifier of a meetingRegistrant. Presents when the participant has registered for the meeting. (deprecated)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistrantId
        {
            get { return BackingStore?.Get<string?>("registrantId"); }
            set { BackingStore?.Set("registrantId", value); }
        }
#nullable restore
#else
        public string RegistrantId
        {
            get { return BackingStore?.Get<string>("registrantId"); }
            set { BackingStore?.Set("registrantId", value); }
        }
#endif
        /// <summary>Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role
        {
            get { return BackingStore?.Get<string?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#nullable restore
#else
        public string Role
        {
            get { return BackingStore?.Get<string>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#endif
        /// <summary>Total duration of the attendances in seconds.</summary>
        public int? TotalAttendanceInSeconds
        {
            get { return BackingStore?.Get<int?>("totalAttendanceInSeconds"); }
            set { BackingStore?.Set("totalAttendanceInSeconds", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AttendanceRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AttendanceRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AttendanceRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "attendanceIntervals", n => { AttendanceIntervals = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AttendanceInterval>(global::Microsoft.Graph.Beta.Models.AttendanceInterval.CreateFromDiscriminatorValue)?.AsList(); } },
                { "emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                { "identity", n => { Identity = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Identity>(global::Microsoft.Graph.Beta.Models.Identity.CreateFromDiscriminatorValue); } },
                { "registrantId", n => { RegistrantId = n.GetStringValue(); } },
                { "role", n => { Role = n.GetStringValue(); } },
                { "totalAttendanceInSeconds", n => { TotalAttendanceInSeconds = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AttendanceInterval>("attendanceIntervals", AttendanceIntervals);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Identity>("identity", Identity);
            writer.WriteStringValue("registrantId", RegistrantId);
            writer.WriteStringValue("role", Role);
            writer.WriteIntValue("totalAttendanceInSeconds", TotalAttendanceInSeconds);
        }
    }
}
#pragma warning restore CS0618
