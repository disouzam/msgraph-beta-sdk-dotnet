// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics baseline entity contains baseline values against which to compare the user experience analytics scores.
    /// </summary>
    public class UserExperienceAnalyticsBaseline : Entity, IParsable {
        /// <summary>The scores and insights for the application health metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsCategory? AppHealthMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory?>("appHealthMetrics"); }
            set { BackingStore?.Set("appHealthMetrics", value); }
        }
#nullable restore
#else
        public UserExperienceAnalyticsCategory AppHealthMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory>("appHealthMetrics"); }
            set { BackingStore?.Set("appHealthMetrics", value); }
        }
#endif
        /// <summary>The scores and insights for the battery health metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsCategory? BatteryHealthMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory?>("batteryHealthMetrics"); }
            set { BackingStore?.Set("batteryHealthMetrics", value); }
        }
#nullable restore
#else
        public UserExperienceAnalyticsCategory BatteryHealthMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory>("batteryHealthMetrics"); }
            set { BackingStore?.Set("batteryHealthMetrics", value); }
        }
#endif
        /// <summary>The scores and insights for the best practices metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsCategory? BestPracticesMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory?>("bestPracticesMetrics"); }
            set { BackingStore?.Set("bestPracticesMetrics", value); }
        }
#nullable restore
#else
        public UserExperienceAnalyticsCategory BestPracticesMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory>("bestPracticesMetrics"); }
            set { BackingStore?.Set("bestPracticesMetrics", value); }
        }
#endif
        /// <summary>The date the custom baseline was created. The value cannot be modified and is automatically populated when the baseline is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The scores and insights for the device boot performance metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsCategory? DeviceBootPerformanceMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory?>("deviceBootPerformanceMetrics"); }
            set { BackingStore?.Set("deviceBootPerformanceMetrics", value); }
        }
#nullable restore
#else
        public UserExperienceAnalyticsCategory DeviceBootPerformanceMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory>("deviceBootPerformanceMetrics"); }
            set { BackingStore?.Set("deviceBootPerformanceMetrics", value); }
        }
#endif
        /// <summary>The name of the baseline.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>When TRUE, indicates the current baseline is the commercial median baseline. When FALSE, indicates it is a custom baseline. FALSE by default.</summary>
        public bool? IsBuiltIn {
            get { return BackingStore?.Get<bool?>("isBuiltIn"); }
            set { BackingStore?.Set("isBuiltIn", value); }
        }
        /// <summary>The scores and insights for the reboot analytics metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsCategory? RebootAnalyticsMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory?>("rebootAnalyticsMetrics"); }
            set { BackingStore?.Set("rebootAnalyticsMetrics", value); }
        }
#nullable restore
#else
        public UserExperienceAnalyticsCategory RebootAnalyticsMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory>("rebootAnalyticsMetrics"); }
            set { BackingStore?.Set("rebootAnalyticsMetrics", value); }
        }
#endif
        /// <summary>The scores and insights for the resource performance metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsCategory? ResourcePerformanceMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory?>("resourcePerformanceMetrics"); }
            set { BackingStore?.Set("resourcePerformanceMetrics", value); }
        }
#nullable restore
#else
        public UserExperienceAnalyticsCategory ResourcePerformanceMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory>("resourcePerformanceMetrics"); }
            set { BackingStore?.Set("resourcePerformanceMetrics", value); }
        }
#endif
        /// <summary>The scores and insights for the work from anywhere metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsCategory? WorkFromAnywhereMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory?>("workFromAnywhereMetrics"); }
            set { BackingStore?.Set("workFromAnywhereMetrics", value); }
        }
#nullable restore
#else
        public UserExperienceAnalyticsCategory WorkFromAnywhereMetrics {
            get { return BackingStore?.Get<UserExperienceAnalyticsCategory>("workFromAnywhereMetrics"); }
            set { BackingStore?.Set("workFromAnywhereMetrics", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsBaseline CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBaseline();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appHealthMetrics", n => { AppHealthMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"batteryHealthMetrics", n => { BatteryHealthMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"bestPracticesMetrics", n => { BestPracticesMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceBootPerformanceMetrics", n => { DeviceBootPerformanceMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
                {"rebootAnalyticsMetrics", n => { RebootAnalyticsMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"resourcePerformanceMetrics", n => { ResourcePerformanceMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"workFromAnywhereMetrics", n => { WorkFromAnywhereMetrics = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("appHealthMetrics", AppHealthMetrics);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("batteryHealthMetrics", BatteryHealthMetrics);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("bestPracticesMetrics", BestPracticesMetrics);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("deviceBootPerformanceMetrics", DeviceBootPerformanceMetrics);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("rebootAnalyticsMetrics", RebootAnalyticsMetrics);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("resourcePerformanceMetrics", ResourcePerformanceMetrics);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("workFromAnywhereMetrics", WorkFromAnywhereMetrics);
        }
    }
}
