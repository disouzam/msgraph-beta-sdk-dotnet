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
    /// This topic provides descriptions of the declared methods, properties and relationships exposed by the iOS Lob App Provisioning Configuration resource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IosLobAppProvisioningConfiguration : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The associated group assignments for IosLobAppProvisioningConfiguration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IosLobAppProvisioningConfigurationAssignment>? Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IosLobAppProvisioningConfigurationAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IosLobAppProvisioningConfigurationAssignment> Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IosLobAppProvisioningConfigurationAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Admin provided description of the Device Configuration.</summary>
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
        /// <summary>The list of device installation states for this mobile app configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationDeviceStatus>? DeviceStatuses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationDeviceStatus>?>("deviceStatuses"); }
            set { BackingStore?.Set("deviceStatuses", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationDeviceStatus> DeviceStatuses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationDeviceStatus>>("deviceStatuses"); }
            set { BackingStore?.Set("deviceStatuses", value); }
        }
#endif
        /// <summary>Admin provided name of the device configuration.</summary>
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
        /// <summary>Optional profile expiration date and time.</summary>
        public DateTimeOffset? ExpirationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The associated group assignments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MobileAppProvisioningConfigGroupAssignment>? GroupAssignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileAppProvisioningConfigGroupAssignment>?>("groupAssignments"); }
            set { BackingStore?.Set("groupAssignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MobileAppProvisioningConfigGroupAssignment> GroupAssignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileAppProvisioningConfigGroupAssignment>>("groupAssignments"); }
            set { BackingStore?.Set("groupAssignments", value); }
        }
#endif
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Payload. (UTF8 encoded byte array)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Payload
        {
            get { return BackingStore?.Get<byte[]?>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#nullable restore
#else
        public byte[] Payload
        {
            get { return BackingStore?.Get<byte[]>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#endif
        /// <summary>Payload file name (.mobileprovision</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayloadFileName
        {
            get { return BackingStore?.Get<string?>("payloadFileName"); }
            set { BackingStore?.Set("payloadFileName", value); }
        }
#nullable restore
#else
        public string PayloadFileName
        {
            get { return BackingStore?.Get<string>("payloadFileName"); }
            set { BackingStore?.Set("payloadFileName", value); }
        }
#endif
        /// <summary>List of Scope Tags for this iOS LOB app provisioning configuration entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>The list of user installation states for this mobile app configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationUserStatus>? UserStatuses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationUserStatus>?>("userStatuses"); }
            set { BackingStore?.Set("userStatuses", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationUserStatus> UserStatuses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationUserStatus>>("userStatuses"); }
            set { BackingStore?.Set("userStatuses", value); }
        }
#endif
        /// <summary>Version of the device configuration.</summary>
        public int? Version
        {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IosLobAppProvisioningConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IosLobAppProvisioningConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IosLobAppProvisioningConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IosLobAppProvisioningConfigurationAssignment>(global::Microsoft.Graph.Beta.Models.IosLobAppProvisioningConfigurationAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationDeviceStatus>(global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationDeviceStatus.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "groupAssignments", n => { GroupAssignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileAppProvisioningConfigGroupAssignment>(global::Microsoft.Graph.Beta.Models.MobileAppProvisioningConfigGroupAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "payload", n => { Payload = n.GetByteArrayValue(); } },
                { "payloadFileName", n => { PayloadFileName = n.GetStringValue(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "userStatuses", n => { UserStatuses = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationUserStatus>(global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationUserStatus.CreateFromDiscriminatorValue)?.AsList(); } },
                { "version", n => { Version = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IosLobAppProvisioningConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileAppProvisioningConfigGroupAssignment>("groupAssignments", GroupAssignments);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteByteArrayValue("payload", Payload);
            writer.WriteStringValue("payloadFileName", PayloadFileName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceMobileAppConfigurationUserStatus>("userStatuses", UserStatuses);
            writer.WriteIntValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
