// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AppPerformance : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The appFriendlyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppFriendlyName
        {
            get { return BackingStore?.Get<string?>("appFriendlyName"); }
            set { BackingStore?.Set("appFriendlyName", value); }
        }
#nullable restore
#else
        public string AppFriendlyName
        {
            get { return BackingStore?.Get<string>("appFriendlyName"); }
            set { BackingStore?.Set("appFriendlyName", value); }
        }
#endif
        /// <summary>The appName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppName
        {
            get { return BackingStore?.Get<string?>("appName"); }
            set { BackingStore?.Set("appName", value); }
        }
#nullable restore
#else
        public string AppName
        {
            get { return BackingStore?.Get<string>("appName"); }
            set { BackingStore?.Set("appName", value); }
        }
#endif
        /// <summary>The appPublisher property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppPublisher
        {
            get { return BackingStore?.Get<string?>("appPublisher"); }
            set { BackingStore?.Set("appPublisher", value); }
        }
#nullable restore
#else
        public string AppPublisher
        {
            get { return BackingStore?.Get<string>("appPublisher"); }
            set { BackingStore?.Set("appPublisher", value); }
        }
#endif
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The meanTimeToFailureInMinutes property</summary>
        public int? MeanTimeToFailureInMinutes
        {
            get { return BackingStore?.Get<int?>("meanTimeToFailureInMinutes"); }
            set { BackingStore?.Set("meanTimeToFailureInMinutes", value); }
        }
        /// <summary>The tenantDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDisplayName
        {
            get { return BackingStore?.Get<string?>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#nullable restore
#else
        public string TenantDisplayName
        {
            get { return BackingStore?.Get<string>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#endif
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId
        {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId
        {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The totalActiveDeviceCount property</summary>
        public int? TotalActiveDeviceCount
        {
            get { return BackingStore?.Get<int?>("totalActiveDeviceCount"); }
            set { BackingStore?.Set("totalActiveDeviceCount", value); }
        }
        /// <summary>The totalAppCrashCount property</summary>
        public int? TotalAppCrashCount
        {
            get { return BackingStore?.Get<int?>("totalAppCrashCount"); }
            set { BackingStore?.Set("totalAppCrashCount", value); }
        }
        /// <summary>The totalAppFreezeCount property</summary>
        public int? TotalAppFreezeCount
        {
            get { return BackingStore?.Get<int?>("totalAppFreezeCount"); }
            set { BackingStore?.Set("totalAppFreezeCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ManagedTenants.AppPerformance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ManagedTenants.AppPerformance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ManagedTenants.AppPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appFriendlyName", n => { AppFriendlyName = n.GetStringValue(); } },
                { "appName", n => { AppName = n.GetStringValue(); } },
                { "appPublisher", n => { AppPublisher = n.GetStringValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "meanTimeToFailureInMinutes", n => { MeanTimeToFailureInMinutes = n.GetIntValue(); } },
                { "tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "totalActiveDeviceCount", n => { TotalActiveDeviceCount = n.GetIntValue(); } },
                { "totalAppCrashCount", n => { TotalAppCrashCount = n.GetIntValue(); } },
                { "totalAppFreezeCount", n => { TotalAppFreezeCount = n.GetIntValue(); } },
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
            writer.WriteStringValue("appFriendlyName", AppFriendlyName);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteIntValue("totalActiveDeviceCount", TotalActiveDeviceCount);
            writer.WriteIntValue("totalAppCrashCount", TotalAppCrashCount);
            writer.WriteIntValue("totalAppFreezeCount", TotalAppFreezeCount);
        }
    }
}
#pragma warning restore CS0618
