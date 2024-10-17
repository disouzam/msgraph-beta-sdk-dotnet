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
    /// The Managed App log collection response
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManagedAppLogCollectionRequest : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>DateTime of when the log upload request was completed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default. Read-only.</summary>
        public DateTimeOffset? CompletedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The unique identifier of the app instance for which diagnostic logs were collected. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedAppRegistrationId
        {
            get { return BackingStore?.Get<string?>("managedAppRegistrationId"); }
            set { BackingStore?.Set("managedAppRegistrationId", value); }
        }
#nullable restore
#else
        public string ManagedAppRegistrationId
        {
            get { return BackingStore?.Get<string>("managedAppRegistrationId"); }
            set { BackingStore?.Set("managedAppRegistrationId", value); }
        }
#endif
        /// <summary>The user principal name associated with the request for the managed application log collection. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestedBy
        {
            get { return BackingStore?.Get<string?>("requestedBy"); }
            set { BackingStore?.Set("requestedBy", value); }
        }
#nullable restore
#else
        public string RequestedBy
        {
            get { return BackingStore?.Get<string>("requestedBy"); }
            set { BackingStore?.Set("requestedBy", value); }
        }
#endif
        /// <summary>The user principal name associated with the request for the managed application log collection. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestedByUserPrincipalName
        {
            get { return BackingStore?.Get<string?>("requestedByUserPrincipalName"); }
            set { BackingStore?.Set("requestedByUserPrincipalName", value); }
        }
#nullable restore
#else
        public string RequestedByUserPrincipalName
        {
            get { return BackingStore?.Get<string>("requestedByUserPrincipalName"); }
            set { BackingStore?.Set("requestedByUserPrincipalName", value); }
        }
#endif
        /// <summary>DateTime of when the log upload request was received. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default. Read-only.</summary>
        public DateTimeOffset? RequestedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("requestedDateTime"); }
            set { BackingStore?.Set("requestedDateTime", value); }
        }
        /// <summary>Indicates the status for the app log collection request - pending, completed or failed. Default is pending.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status
        {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status
        {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>The collection of log upload results as reported by each component on the device. Such components can be the application itself, the Mobile Application Management (MAM) SDK, and other on-device components that are requested to upload diagnostic logs. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppLogUpload>? UploadedLogs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppLogUpload>?>("uploadedLogs"); }
            set { BackingStore?.Set("uploadedLogs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedAppLogUpload> UploadedLogs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedAppLogUpload>>("uploadedLogs"); }
            set { BackingStore?.Set("uploadedLogs", value); }
        }
#endif
        /// <summary>Represents the current consent status of the associated `managedAppLogCollectionRequest`.</summary>
        public global::Microsoft.Graph.Beta.Models.ManagedAppLogUploadConsent? UserLogUploadConsent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedAppLogUploadConsent?>("userLogUploadConsent"); }
            set { BackingStore?.Set("userLogUploadConsent", value); }
        }
        /// <summary>Version of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version
        {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version
        {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ManagedAppLogCollectionRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ManagedAppLogCollectionRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ManagedAppLogCollectionRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "managedAppRegistrationId", n => { ManagedAppRegistrationId = n.GetStringValue(); } },
                { "requestedBy", n => { RequestedBy = n.GetStringValue(); } },
                { "requestedByUserPrincipalName", n => { RequestedByUserPrincipalName = n.GetStringValue(); } },
                { "requestedDateTime", n => { RequestedDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "uploadedLogs", n => { UploadedLogs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedAppLogUpload>(global::Microsoft.Graph.Beta.Models.ManagedAppLogUpload.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userLogUploadConsent", n => { UserLogUploadConsent = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ManagedAppLogUploadConsent>(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteStringValue("managedAppRegistrationId", ManagedAppRegistrationId);
            writer.WriteStringValue("requestedBy", RequestedBy);
            writer.WriteStringValue("requestedByUserPrincipalName", RequestedByUserPrincipalName);
            writer.WriteDateTimeOffsetValue("requestedDateTime", RequestedDateTime);
            writer.WriteStringValue("status", Status);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedAppLogUpload>("uploadedLogs", UploadedLogs);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ManagedAppLogUploadConsent>("userLogUploadConsent", UserLogUploadConsent);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
