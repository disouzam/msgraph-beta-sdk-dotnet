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
    /// Windows Log Collection request entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DeviceLogCollectionResponse : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The User Principal Name (UPN) of the user that enrolled the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnrolledByUser
        {
            get { return BackingStore?.Get<string?>("enrolledByUser"); }
            set { BackingStore?.Set("enrolledByUser", value); }
        }
#nullable restore
#else
        public string EnrolledByUser
        {
            get { return BackingStore?.Get<string>("enrolledByUser"); }
            set { BackingStore?.Set("enrolledByUser", value); }
        }
#endif
        /// <summary>The error code, if any. Valid values -9.22337203685478E+18 to 9.22337203685478E+18</summary>
        public long? ErrorCode
        {
            get { return BackingStore?.Get<long?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>The DateTime of the expiration of the logs.</summary>
        public DateTimeOffset? ExpirationDateTimeUTC
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTimeUTC"); }
            set { BackingStore?.Set("expirationDateTimeUTC", value); }
        }
        /// <summary>The UPN for who initiated the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InitiatedByUserPrincipalName
        {
            get { return BackingStore?.Get<string?>("initiatedByUserPrincipalName"); }
            set { BackingStore?.Set("initiatedByUserPrincipalName", value); }
        }
#nullable restore
#else
        public string InitiatedByUserPrincipalName
        {
            get { return BackingStore?.Get<string>("initiatedByUserPrincipalName"); }
            set { BackingStore?.Set("initiatedByUserPrincipalName", value); }
        }
#endif
        /// <summary>Indicates Intune device unique identifier.</summary>
        public Guid? ManagedDeviceId
        {
            get { return BackingStore?.Get<Guid?>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
        /// <summary>The DateTime the request was received.</summary>
        public DateTimeOffset? ReceivedDateTimeUTC
        {
            get { return BackingStore?.Get<DateTimeOffset?>("receivedDateTimeUTC"); }
            set { BackingStore?.Set("receivedDateTimeUTC", value); }
        }
        /// <summary>The DateTime of the request.</summary>
        public DateTimeOffset? RequestedDateTimeUTC
        {
            get { return BackingStore?.Get<DateTimeOffset?>("requestedDateTimeUTC"); }
            set { BackingStore?.Set("requestedDateTimeUTC", value); }
        }
        /// <summary>The size of the logs. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? Size
        {
            get { return BackingStore?.Get<double?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>The size of the logs in KB. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? SizeInKB
        {
            get { return BackingStore?.Get<double?>("sizeInKB"); }
            set { BackingStore?.Set("sizeInKB", value); }
        }
        /// <summary>AppLogUploadStatus</summary>
        public global::Microsoft.Graph.Beta.Models.AppLogUploadState? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AppLogUploadState?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceLogCollectionResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceLogCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceLogCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "enrolledByUser", n => { EnrolledByUser = n.GetStringValue(); } },
                { "errorCode", n => { ErrorCode = n.GetLongValue(); } },
                { "expirationDateTimeUTC", n => { ExpirationDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                { "initiatedByUserPrincipalName", n => { InitiatedByUserPrincipalName = n.GetStringValue(); } },
                { "managedDeviceId", n => { ManagedDeviceId = n.GetGuidValue(); } },
                { "receivedDateTimeUTC", n => { ReceivedDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                { "requestedDateTimeUTC", n => { RequestedDateTimeUTC = n.GetDateTimeOffsetValue(); } },
                { "size", n => { Size = n.GetDoubleValue(); } },
                { "sizeInKB", n => { SizeInKB = n.GetDoubleValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AppLogUploadState>(); } },
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
            writer.WriteStringValue("enrolledByUser", EnrolledByUser);
            writer.WriteLongValue("errorCode", ErrorCode);
            writer.WriteDateTimeOffsetValue("expirationDateTimeUTC", ExpirationDateTimeUTC);
            writer.WriteStringValue("initiatedByUserPrincipalName", InitiatedByUserPrincipalName);
            writer.WriteGuidValue("managedDeviceId", ManagedDeviceId);
            writer.WriteDateTimeOffsetValue("receivedDateTimeUTC", ReceivedDateTimeUTC);
            writer.WriteDateTimeOffsetValue("requestedDateTimeUTC", RequestedDateTimeUTC);
            writer.WriteDoubleValue("size", Size);
            writer.WriteDoubleValue("sizeInKB", SizeInKB);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AppLogUploadState>("status", Status);
        }
    }
}
#pragma warning restore CS0618
