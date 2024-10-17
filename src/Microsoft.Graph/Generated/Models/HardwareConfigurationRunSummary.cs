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
    /// Contains properties for the run summary of a hardware configuration script.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class HardwareConfigurationRunSummary : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Number of devices for which hardware configuration state is error</summary>
        public int? ErrorDeviceCount
        {
            get { return BackingStore?.Get<int?>("errorDeviceCount"); }
            set { BackingStore?.Set("errorDeviceCount", value); }
        }
        /// <summary>Number of users for which hardware configuration state is error</summary>
        public int? ErrorUserCount
        {
            get { return BackingStore?.Get<int?>("errorUserCount"); }
            set { BackingStore?.Set("errorUserCount", value); }
        }
        /// <summary>Number of devices for which hardware configuration found an issue</summary>
        public int? FailedDeviceCount
        {
            get { return BackingStore?.Get<int?>("failedDeviceCount"); }
            set { BackingStore?.Set("failedDeviceCount", value); }
        }
        /// <summary>Number of users for which hardware configuration found an issue</summary>
        public int? FailedUserCount
        {
            get { return BackingStore?.Get<int?>("failedUserCount"); }
            set { BackingStore?.Set("failedUserCount", value); }
        }
        /// <summary>Last run time for the configuration across all devices</summary>
        public DateTimeOffset? LastRunDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRunDateTime"); }
            set { BackingStore?.Set("lastRunDateTime", value); }
        }
        /// <summary>Number of devices for which hardware configuration state is not applicable</summary>
        public int? NotApplicableDeviceCount
        {
            get { return BackingStore?.Get<int?>("notApplicableDeviceCount"); }
            set { BackingStore?.Set("notApplicableDeviceCount", value); }
        }
        /// <summary>Number of users for which hardware configuration state is not applicable</summary>
        public int? NotApplicableUserCount
        {
            get { return BackingStore?.Get<int?>("notApplicableUserCount"); }
            set { BackingStore?.Set("notApplicableUserCount", value); }
        }
        /// <summary>Number of devices for which hardware configuration is in pending state</summary>
        public int? PendingDeviceCount
        {
            get { return BackingStore?.Get<int?>("pendingDeviceCount"); }
            set { BackingStore?.Set("pendingDeviceCount", value); }
        }
        /// <summary>Number of users for which hardware configuration is in pending state</summary>
        public int? PendingUserCount
        {
            get { return BackingStore?.Get<int?>("pendingUserCount"); }
            set { BackingStore?.Set("pendingUserCount", value); }
        }
        /// <summary>Number of devices for which hardware configured without any issue</summary>
        public int? SuccessfulDeviceCount
        {
            get { return BackingStore?.Get<int?>("successfulDeviceCount"); }
            set { BackingStore?.Set("successfulDeviceCount", value); }
        }
        /// <summary>Number of users for which hardware configured without any issue</summary>
        public int? SuccessfulUserCount
        {
            get { return BackingStore?.Get<int?>("successfulUserCount"); }
            set { BackingStore?.Set("successfulUserCount", value); }
        }
        /// <summary>Number of devices for which hardware configuration state is unknown</summary>
        public int? UnknownDeviceCount
        {
            get { return BackingStore?.Get<int?>("unknownDeviceCount"); }
            set { BackingStore?.Set("unknownDeviceCount", value); }
        }
        /// <summary>Number of users for which hardware configuration state is unknown</summary>
        public int? UnknownUserCount
        {
            get { return BackingStore?.Get<int?>("unknownUserCount"); }
            set { BackingStore?.Set("unknownUserCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.HardwareConfigurationRunSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.HardwareConfigurationRunSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.HardwareConfigurationRunSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                { "errorUserCount", n => { ErrorUserCount = n.GetIntValue(); } },
                { "failedDeviceCount", n => { FailedDeviceCount = n.GetIntValue(); } },
                { "failedUserCount", n => { FailedUserCount = n.GetIntValue(); } },
                { "lastRunDateTime", n => { LastRunDateTime = n.GetDateTimeOffsetValue(); } },
                { "notApplicableDeviceCount", n => { NotApplicableDeviceCount = n.GetIntValue(); } },
                { "notApplicableUserCount", n => { NotApplicableUserCount = n.GetIntValue(); } },
                { "pendingDeviceCount", n => { PendingDeviceCount = n.GetIntValue(); } },
                { "pendingUserCount", n => { PendingUserCount = n.GetIntValue(); } },
                { "successfulDeviceCount", n => { SuccessfulDeviceCount = n.GetIntValue(); } },
                { "successfulUserCount", n => { SuccessfulUserCount = n.GetIntValue(); } },
                { "unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
                { "unknownUserCount", n => { UnknownUserCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("errorUserCount", ErrorUserCount);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
            writer.WriteIntValue("failedUserCount", FailedUserCount);
            writer.WriteDateTimeOffsetValue("lastRunDateTime", LastRunDateTime);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("notApplicableUserCount", NotApplicableUserCount);
            writer.WriteIntValue("pendingDeviceCount", PendingDeviceCount);
            writer.WriteIntValue("pendingUserCount", PendingUserCount);
            writer.WriteIntValue("successfulDeviceCount", SuccessfulDeviceCount);
            writer.WriteIntValue("successfulUserCount", SuccessfulUserCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
            writer.WriteIntValue("unknownUserCount", UnknownUserCount);
        }
    }
}
#pragma warning restore CS0618
