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
    /// Entity that represents device state for an intent
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementIntentDeviceState : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Device name that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceDisplayName
        {
            get { return BackingStore?.Get<string?>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
#nullable restore
#else
        public string DeviceDisplayName
        {
            get { return BackingStore?.Get<string>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
#endif
        /// <summary>Device id that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId
        {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId
        {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>Last modified date time of an intent report</summary>
        public DateTimeOffset? LastReportedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastReportedDateTime"); }
            set { BackingStore?.Set("lastReportedDateTime", value); }
        }
        /// <summary>The state property</summary>
        public global::Microsoft.Graph.Beta.Models.ComplianceStatus? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ComplianceStatus?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The user name that is being reported on a device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName
        {
            get { return BackingStore?.Get<string?>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#nullable restore
#else
        public string UserName
        {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#endif
        /// <summary>The user principal name that is being reported on a device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName
        {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName
        {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ComplianceStatus>(); } },
                { "userName", n => { UserName = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ComplianceStatus>("state", State);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
#pragma warning restore CS0618
