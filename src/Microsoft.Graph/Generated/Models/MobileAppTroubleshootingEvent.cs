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
    /// Event representing a users device application install status.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MobileAppTroubleshootingEvent : global::Microsoft.Graph.Beta.Models.DeviceManagementTroubleshootingEvent, IParsable
    {
        /// <summary>Intune application identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationId
        {
            get { return BackingStore?.Get<string?>("applicationId"); }
            set { BackingStore?.Set("applicationId", value); }
        }
#nullable restore
#else
        public string ApplicationId
        {
            get { return BackingStore?.Get<string>("applicationId"); }
            set { BackingStore?.Set("applicationId", value); }
        }
#endif
        /// <summary>The collection property of AppLogUploadRequest.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AppLogCollectionRequest>? AppLogCollectionRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AppLogCollectionRequest>?>("appLogCollectionRequests"); }
            set { BackingStore?.Set("appLogCollectionRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AppLogCollectionRequest> AppLogCollectionRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AppLogCollectionRequest>>("appLogCollectionRequests"); }
            set { BackingStore?.Set("appLogCollectionRequests", value); }
        }
#endif
        /// <summary>Device identifier created or collected by Intune.</summary>
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
        /// <summary>Intune Mobile Application Troubleshooting History Item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MobileAppTroubleshootingHistoryItem>? History
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileAppTroubleshootingHistoryItem>?>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MobileAppTroubleshootingHistoryItem> History
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileAppTroubleshootingHistoryItem>>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#endif
        /// <summary>Device identifier created or collected by Intune.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceIdentifier
        {
            get { return BackingStore?.Get<string?>("managedDeviceIdentifier"); }
            set { BackingStore?.Set("managedDeviceIdentifier", value); }
        }
#nullable restore
#else
        public string ManagedDeviceIdentifier
        {
            get { return BackingStore?.Get<string>("managedDeviceIdentifier"); }
            set { BackingStore?.Set("managedDeviceIdentifier", value); }
        }
#endif
        /// <summary>Identifier for the user that tried to enroll the device.</summary>
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MobileAppTroubleshootingEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MobileAppTroubleshootingEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MobileAppTroubleshootingEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appLogCollectionRequests", n => { AppLogCollectionRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AppLogCollectionRequest>(global::Microsoft.Graph.Beta.Models.AppLogCollectionRequest.CreateFromDiscriminatorValue)?.AsList(); } },
                { "applicationId", n => { ApplicationId = n.GetStringValue(); } },
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "history", n => { History = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileAppTroubleshootingHistoryItem>(global::Microsoft.Graph.Beta.Models.MobileAppTroubleshootingHistoryItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedDeviceIdentifier", n => { ManagedDeviceIdentifier = n.GetStringValue(); } },
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
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AppLogCollectionRequest>("appLogCollectionRequests", AppLogCollectionRequests);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileAppTroubleshootingHistoryItem>("history", History);
            writer.WriteStringValue("managedDeviceIdentifier", ManagedDeviceIdentifier);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
#pragma warning restore CS0618
