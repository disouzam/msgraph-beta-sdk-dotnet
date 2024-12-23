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
    /// Contains properties for device run state of the hardware configuration
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class HardwareConfigurationDeviceState : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>A list of identifier strings of different assignment filters applied</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentFilterIds
        {
            get { return BackingStore?.Get<string?>("assignmentFilterIds"); }
            set { BackingStore?.Set("assignmentFilterIds", value); }
        }
#nullable restore
#else
        public string AssignmentFilterIds
        {
            get { return BackingStore?.Get<string>("assignmentFilterIds"); }
            set { BackingStore?.Set("assignmentFilterIds", value); }
        }
#endif
        /// <summary>Error from the hardware configuration execution</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConfigurationError
        {
            get { return BackingStore?.Get<string?>("configurationError"); }
            set { BackingStore?.Set("configurationError", value); }
        }
#nullable restore
#else
        public string ConfigurationError
        {
            get { return BackingStore?.Get<string>("configurationError"); }
            set { BackingStore?.Set("configurationError", value); }
        }
#endif
        /// <summary>Output of the hardware configuration execution</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConfigurationOutput
        {
            get { return BackingStore?.Get<string?>("configurationOutput"); }
            set { BackingStore?.Set("configurationOutput", value); }
        }
#nullable restore
#else
        public string ConfigurationOutput
        {
            get { return BackingStore?.Get<string>("configurationOutput"); }
            set { BackingStore?.Set("configurationOutput", value); }
        }
#endif
        /// <summary>Indicates the type of execution status of the device management script.</summary>
        public global::Microsoft.Graph.Beta.Models.RunState? ConfigurationState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.RunState?>("configurationState"); }
            set { BackingStore?.Set("configurationState", value); }
        }
        /// <summary>The name of the device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName
        {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName
        {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>The Policy internal version</summary>
        public int? InternalVersion
        {
            get { return BackingStore?.Get<int?>("internalVersion"); }
            set { BackingStore?.Set("internalVersion", value); }
        }
        /// <summary>The last timestamp of when the hardware configuration executed</summary>
        public DateTimeOffset? LastStateUpdateDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastStateUpdateDateTime"); }
            set { BackingStore?.Set("lastStateUpdateDateTime", value); }
        }
        /// <summary>Operating system version of the device (E.g. 10.0.19042.1165, 10.0.19042.1288 etc.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion
        {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion
        {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>User Principal Name (UPN).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Upn
        {
            get { return BackingStore?.Get<string?>("upn"); }
            set { BackingStore?.Set("upn", value); }
        }
#nullable restore
#else
        public string Upn
        {
            get { return BackingStore?.Get<string>("upn"); }
            set { BackingStore?.Set("upn", value); }
        }
#endif
        /// <summary>The unique identifier of the Entra user associated with the device for which policy is applied. Read-Only.</summary>
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.HardwareConfigurationDeviceState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.HardwareConfigurationDeviceState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.HardwareConfigurationDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignmentFilterIds", n => { AssignmentFilterIds = n.GetStringValue(); } },
                { "configurationError", n => { ConfigurationError = n.GetStringValue(); } },
                { "configurationOutput", n => { ConfigurationOutput = n.GetStringValue(); } },
                { "configurationState", n => { ConfigurationState = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.RunState>(); } },
                { "deviceName", n => { DeviceName = n.GetStringValue(); } },
                { "internalVersion", n => { InternalVersion = n.GetIntValue(); } },
                { "lastStateUpdateDateTime", n => { LastStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "osVersion", n => { OsVersion = n.GetStringValue(); } },
                { "upn", n => { Upn = n.GetStringValue(); } },
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
            writer.WriteStringValue("assignmentFilterIds", AssignmentFilterIds);
            writer.WriteStringValue("configurationError", ConfigurationError);
            writer.WriteStringValue("configurationOutput", ConfigurationOutput);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.RunState>("configurationState", ConfigurationState);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteIntValue("internalVersion", InternalVersion);
            writer.WriteDateTimeOffsetValue("lastStateUpdateDateTime", LastStateUpdateDateTime);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("upn", Upn);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
#pragma warning restore CS0618
