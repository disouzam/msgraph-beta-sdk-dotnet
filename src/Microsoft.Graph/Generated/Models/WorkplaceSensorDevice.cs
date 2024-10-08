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
    public partial class WorkplaceSensorDevice : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The description of the device.</summary>
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
        /// <summary>The user-defined unique identifier of the device provided at the time of creation.</summary>
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
        /// <summary>The display name of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The IPv4 address of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpV4Address
        {
            get { return BackingStore?.Get<string?>("ipV4Address"); }
            set { BackingStore?.Set("ipV4Address", value); }
        }
#nullable restore
#else
        public string IpV4Address
        {
            get { return BackingStore?.Get<string>("ipV4Address"); }
            set { BackingStore?.Set("ipV4Address", value); }
        }
#endif
        /// <summary>The IPv6 address of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpV6Address
        {
            get { return BackingStore?.Get<string?>("ipV6Address"); }
            set { BackingStore?.Set("ipV6Address", value); }
        }
#nullable restore
#else
        public string IpV6Address
        {
            get { return BackingStore?.Get<string>("ipV6Address"); }
            set { BackingStore?.Set("ipV6Address", value); }
        }
#endif
        /// <summary>The MAC address of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MacAddress
        {
            get { return BackingStore?.Get<string?>("macAddress"); }
            set { BackingStore?.Set("macAddress", value); }
        }
#nullable restore
#else
        public string MacAddress
        {
            get { return BackingStore?.Get<string>("macAddress"); }
            set { BackingStore?.Set("macAddress", value); }
        }
#endif
        /// <summary>The manufacturer of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer
        {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer
        {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>The unique identifier of the place where the device is located. If the device is installed in a room equipped with a mailbox, this property should match the ExternalDirectoryObjectId or Microsoft Entra object ID of the room mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlaceId
        {
            get { return BackingStore?.Get<string?>("placeId"); }
            set { BackingStore?.Set("placeId", value); }
        }
#nullable restore
#else
        public string PlaceId
        {
            get { return BackingStore?.Get<string>("placeId"); }
            set { BackingStore?.Set("placeId", value); }
        }
#endif
        /// <summary>A list of sensors associated with the device that collect and report data about physical or environmental conditions, such as occupancy, people count, inferred occupancy, temperature, and more.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WorkplaceSensor>? Sensors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WorkplaceSensor>?>("sensors"); }
            set { BackingStore?.Set("sensors", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WorkplaceSensor> Sensors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WorkplaceSensor>>("sensors"); }
            set { BackingStore?.Set("sensors", value); }
        }
#endif
        /// <summary>A list of custom tags associated with the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags
        {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags
        {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WorkplaceSensorDevice"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WorkplaceSensorDevice CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WorkplaceSensorDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "ipV4Address", n => { IpV4Address = n.GetStringValue(); } },
                { "ipV6Address", n => { IpV6Address = n.GetStringValue(); } },
                { "macAddress", n => { MacAddress = n.GetStringValue(); } },
                { "manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                { "placeId", n => { PlaceId = n.GetStringValue(); } },
                { "sensors", n => { Sensors = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WorkplaceSensor>(global::Microsoft.Graph.Beta.Models.WorkplaceSensor.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("ipV4Address", IpV4Address);
            writer.WriteStringValue("ipV6Address", IpV6Address);
            writer.WriteStringValue("macAddress", MacAddress);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("placeId", PlaceId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WorkplaceSensor>("sensors", Sensors);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
        }
    }
}
#pragma warning restore CS0618
