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
    public partial class OutlookTask : global::Microsoft.Graph.Beta.Models.OutlookItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the person who has been assigned the task in Outlook. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo
        {
            get { return BackingStore?.Get<string?>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#nullable restore
#else
        public string AssignedTo
        {
            get { return BackingStore?.Get<string>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#endif
        /// <summary>The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the task. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Attachment>? Attachments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Attachment>?>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Attachment> Attachments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Attachment>>("attachments"); }
            set { BackingStore?.Set("attachments", value); }
        }
#endif
        /// <summary>The task body that typically contains information about the task. Only the HTML type is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ItemBody? Body
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemBody?>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ItemBody Body
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemBody>("body"); }
            set { BackingStore?.Set("body", value); }
        }
#endif
        /// <summary>The date in the specified time zone that the task was finished.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone? CompletedDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone CompletedDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
#endif
        /// <summary>The date in the specified time zone that the task is to be finished.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone? DueDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone?>("dueDateTime"); }
            set { BackingStore?.Set("dueDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone DueDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("dueDateTime"); }
            set { BackingStore?.Set("dueDateTime", value); }
        }
#endif
        /// <summary>Set to true if the task has attachments.</summary>
        public bool? HasAttachments
        {
            get { return BackingStore?.Get<bool?>("hasAttachments"); }
            set { BackingStore?.Set("hasAttachments", value); }
        }
        /// <summary>The importance of the event. Possible values are: low, normal, high.</summary>
        public global::Microsoft.Graph.Beta.Models.Importance? Importance
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Importance?>("importance"); }
            set { BackingStore?.Set("importance", value); }
        }
        /// <summary>Set to true if an alert is set to remind the user of the task.</summary>
        public bool? IsReminderOn
        {
            get { return BackingStore?.Get<bool?>("isReminderOn"); }
            set { BackingStore?.Set("isReminderOn", value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the task. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>?>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty> MultiValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#endif
        /// <summary>The name of the person who created the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner
        {
            get { return BackingStore?.Get<string?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public string Owner
        {
            get { return BackingStore?.Get<string>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>The unique identifier for the task&apos;s parent folder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentFolderId
        {
            get { return BackingStore?.Get<string?>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
#nullable restore
#else
        public string ParentFolderId
        {
            get { return BackingStore?.Get<string>("parentFolderId"); }
            set { BackingStore?.Set("parentFolderId", value); }
        }
#endif
        /// <summary>The recurrence pattern for the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PatternedRecurrence? Recurrence
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PatternedRecurrence?>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PatternedRecurrence Recurrence
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PatternedRecurrence>("recurrence"); }
            set { BackingStore?.Set("recurrence", value); }
        }
#endif
        /// <summary>The date and time for a reminder alert of the task to occur.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone? ReminderDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone?>("reminderDateTime"); }
            set { BackingStore?.Set("reminderDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone ReminderDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("reminderDateTime"); }
            set { BackingStore?.Set("reminderDateTime", value); }
        }
#endif
        /// <summary>Indicates the level of privacy for the task. Possible values are: normal, personal, private, confidential.</summary>
        public global::Microsoft.Graph.Beta.Models.Sensitivity? Sensitivity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Sensitivity?>("sensitivity"); }
            set { BackingStore?.Set("sensitivity", value); }
        }
        /// <summary>The collection of single-value extended properties defined for the task. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>?>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty> SingleValueExtendedProperties
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#endif
        /// <summary>The date in the specified time zone when the task is to begin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone? StartDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone StartDateTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
#endif
        /// <summary>Indicates the state or progress of the task. Possible values are: notStarted, inProgress, completed, waitingOnOthers, deferred.</summary>
        public global::Microsoft.Graph.Beta.Models.TaskStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TaskStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>A brief description or title of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject
        {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject
        {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.OutlookTask"/> and sets the default values.
        /// </summary>
        public OutlookTask() : base()
        {
            OdataType = "#microsoft.graph.outlookTask";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OutlookTask"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.OutlookTask CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.OutlookTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                { "attachments", n => { Attachments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Attachment>(global::Microsoft.Graph.Beta.Models.Attachment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "body", n => { Body = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ItemBody>(global::Microsoft.Graph.Beta.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "completedDateTime", n => { CompletedDateTime = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>(global::Microsoft.Graph.Beta.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "dueDateTime", n => { DueDateTime = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>(global::Microsoft.Graph.Beta.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                { "importance", n => { Importance = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Importance>(); } },
                { "isReminderOn", n => { IsReminderOn = n.GetBoolValue(); } },
                { "multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>(global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "owner", n => { Owner = n.GetStringValue(); } },
                { "parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                { "recurrence", n => { Recurrence = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PatternedRecurrence>(global::Microsoft.Graph.Beta.Models.PatternedRecurrence.CreateFromDiscriminatorValue); } },
                { "reminderDateTime", n => { ReminderDateTime = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>(global::Microsoft.Graph.Beta.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "sensitivity", n => { Sensitivity = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Sensitivity>(); } },
                { "singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>(global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "startDateTime", n => { StartDateTime = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>(global::Microsoft.Graph.Beta.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.TaskStatus>(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
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
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Attachment>("attachments", Attachments);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ItemBody>("body", Body);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("completedDateTime", CompletedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("dueDateTime", DueDateTime);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Importance>("importance", Importance);
            writer.WriteBoolValue("isReminderOn", IsReminderOn);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("owner", Owner);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PatternedRecurrence>("recurrence", Recurrence);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("reminderDateTime", ReminderDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Sensitivity>("sensitivity", Sensitivity);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.TaskStatus>("status", Status);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
#pragma warning restore CS0618
