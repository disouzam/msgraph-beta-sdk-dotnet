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
    /// The user experience analytics battery health model performance entity contains battery related information for all unique device models in their organization.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class UserExperienceAnalyticsBatteryHealthModelPerformance : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Number of active devices for that model. Valid values 0 to 2147483647</summary>
        public int? ActiveDevices
        {
            get { return BackingStore?.Get<int?>("activeDevices"); }
            set { BackingStore?.Set("activeDevices", value); }
        }
        /// <summary>The mean of the battery age for all devices of a given model in a tenant. Unit in days. Valid values 0 to 2147483647</summary>
        public int? AverageBatteryAgeInDays
        {
            get { return BackingStore?.Get<int?>("averageBatteryAgeInDays"); }
            set { BackingStore?.Set("averageBatteryAgeInDays", value); }
        }
        /// <summary>The mean of the estimated runtimes on full charge for all devices of a given model. Unit in minutes. Valid values 0 to 2147483647</summary>
        public int? AverageEstimatedRuntimeInMinutes
        {
            get { return BackingStore?.Get<int?>("averageEstimatedRuntimeInMinutes"); }
            set { BackingStore?.Set("averageEstimatedRuntimeInMinutes", value); }
        }
        /// <summary>The mean of the maximum capacity for all devices of a given model. Maximum capacity measures the full charge vs. design capacity for a device’s batteries.. Valid values 0 to 2147483647</summary>
        public int? AverageMaxCapacityPercentage
        {
            get { return BackingStore?.Get<int?>("averageMaxCapacityPercentage"); }
            set { BackingStore?.Set("averageMaxCapacityPercentage", value); }
        }
        /// <summary>The manufacturer name of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceManufacturerName
        {
            get { return BackingStore?.Get<string?>("deviceManufacturerName"); }
            set { BackingStore?.Set("deviceManufacturerName", value); }
        }
#nullable restore
#else
        public string DeviceManufacturerName
        {
            get { return BackingStore?.Get<string>("deviceManufacturerName"); }
            set { BackingStore?.Set("deviceManufacturerName", value); }
        }
#endif
        /// <summary>The model name of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceModelName
        {
            get { return BackingStore?.Get<string?>("deviceModelName"); }
            set { BackingStore?.Set("deviceModelName", value); }
        }
#nullable restore
#else
        public string DeviceModelName
        {
            get { return BackingStore?.Get<string>("deviceModelName"); }
            set { BackingStore?.Set("deviceModelName", value); }
        }
#endif
        /// <summary>Name of the device manufacturer. Deprecated in favor of DeviceManufacturerName.</summary>
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
        /// <summary>The mean of number of times the battery has been discharged an amount that equals 100% of its capacity for all devices of a given model in a tenant. Valid values 0 to 2147483647</summary>
        public int? MeanFullBatteryDrainCount
        {
            get { return BackingStore?.Get<int?>("meanFullBatteryDrainCount"); }
            set { BackingStore?.Set("meanFullBatteryDrainCount", value); }
        }
        /// <summary>The median of the estimated runtimes on full charge for all devices of a given model. Unit in minutes. Valid values 0 to 2147483647</summary>
        public int? MedianEstimatedRuntimeInMinutes
        {
            get { return BackingStore?.Get<int?>("medianEstimatedRuntimeInMinutes"); }
            set { BackingStore?.Set("medianEstimatedRuntimeInMinutes", value); }
        }
        /// <summary>The median of number of times the battery has been discharged an amount that equals 100% of its capacity for all devices of a given model in a tenant. Valid values 0 to 2147483647</summary>
        public int? MedianFullBatteryDrainCount
        {
            get { return BackingStore?.Get<int?>("medianFullBatteryDrainCount"); }
            set { BackingStore?.Set("medianFullBatteryDrainCount", value); }
        }
        /// <summary>The median of the maximum capacity for all devices of a given model. Maximum capacity measures the full charge vs. design capacity for a device’s batteries.. Valid values 0 to 2147483647</summary>
        public int? MedianMaxCapacityPercentage
        {
            get { return BackingStore?.Get<int?>("medianMaxCapacityPercentage"); }
            set { BackingStore?.Set("medianMaxCapacityPercentage", value); }
        }
        /// <summary>The model name of the device. Deprecated in favor of DeviceModelName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model
        {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model
        {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>A weighted average of a model’s maximum capacity score and runtime estimate score. Values range from 0-100. Valid values 0 to 2147483647</summary>
        public int? ModelBatteryHealthScore
        {
            get { return BackingStore?.Get<int?>("modelBatteryHealthScore"); }
            set { BackingStore?.Set("modelBatteryHealthScore", value); }
        }
        /// <summary>The modelHealthStatus property</summary>
        public global::Microsoft.Graph.Beta.Models.UserExperienceAnalyticsHealthState? ModelHealthStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.UserExperienceAnalyticsHealthState?>("modelHealthStatus"); }
            set { BackingStore?.Set("modelHealthStatus", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthModelPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeDevices", n => { ActiveDevices = n.GetIntValue(); } },
                { "averageBatteryAgeInDays", n => { AverageBatteryAgeInDays = n.GetIntValue(); } },
                { "averageEstimatedRuntimeInMinutes", n => { AverageEstimatedRuntimeInMinutes = n.GetIntValue(); } },
                { "averageMaxCapacityPercentage", n => { AverageMaxCapacityPercentage = n.GetIntValue(); } },
                { "deviceManufacturerName", n => { DeviceManufacturerName = n.GetStringValue(); } },
                { "deviceModelName", n => { DeviceModelName = n.GetStringValue(); } },
                { "manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                { "meanFullBatteryDrainCount", n => { MeanFullBatteryDrainCount = n.GetIntValue(); } },
                { "medianEstimatedRuntimeInMinutes", n => { MedianEstimatedRuntimeInMinutes = n.GetIntValue(); } },
                { "medianFullBatteryDrainCount", n => { MedianFullBatteryDrainCount = n.GetIntValue(); } },
                { "medianMaxCapacityPercentage", n => { MedianMaxCapacityPercentage = n.GetIntValue(); } },
                { "model", n => { Model = n.GetStringValue(); } },
                { "modelBatteryHealthScore", n => { ModelBatteryHealthScore = n.GetIntValue(); } },
                { "modelHealthStatus", n => { ModelHealthStatus = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.UserExperienceAnalyticsHealthState>(); } },
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
            writer.WriteIntValue("activeDevices", ActiveDevices);
            writer.WriteIntValue("averageBatteryAgeInDays", AverageBatteryAgeInDays);
            writer.WriteIntValue("averageEstimatedRuntimeInMinutes", AverageEstimatedRuntimeInMinutes);
            writer.WriteIntValue("averageMaxCapacityPercentage", AverageMaxCapacityPercentage);
            writer.WriteStringValue("deviceManufacturerName", DeviceManufacturerName);
            writer.WriteStringValue("deviceModelName", DeviceModelName);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteIntValue("meanFullBatteryDrainCount", MeanFullBatteryDrainCount);
            writer.WriteIntValue("medianEstimatedRuntimeInMinutes", MedianEstimatedRuntimeInMinutes);
            writer.WriteIntValue("medianFullBatteryDrainCount", MedianFullBatteryDrainCount);
            writer.WriteIntValue("medianMaxCapacityPercentage", MedianMaxCapacityPercentage);
            writer.WriteStringValue("model", Model);
            writer.WriteIntValue("modelBatteryHealthScore", ModelBatteryHealthScore);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.UserExperienceAnalyticsHealthState>("modelHealthStatus", ModelHealthStatus);
        }
    }
}
#pragma warning restore CS0618
