// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TeamworkDeviceConfiguration : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The camera configuration. Applicable only for Microsoft Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TeamworkCameraConfiguration? CameraConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkCameraConfiguration?>("cameraConfiguration"); }
            set { BackingStore?.Set("cameraConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TeamworkCameraConfiguration CameraConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkCameraConfiguration>("cameraConfiguration"); }
            set { BackingStore?.Set("cameraConfiguration", value); }
        }
#endif
        /// <summary>Identity of the user who created the device configuration document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentitySet? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentitySet CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The UTC date and time when the device configuration document was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The display configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TeamworkDisplayConfiguration? DisplayConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkDisplayConfiguration?>("displayConfiguration"); }
            set { BackingStore?.Set("displayConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TeamworkDisplayConfiguration DisplayConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkDisplayConfiguration>("displayConfiguration"); }
            set { BackingStore?.Set("displayConfiguration", value); }
        }
#endif
        /// <summary>The hardware configuration. Applicable only for Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TeamworkHardwareConfiguration? HardwareConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkHardwareConfiguration?>("hardwareConfiguration"); }
            set { BackingStore?.Set("hardwareConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TeamworkHardwareConfiguration HardwareConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkHardwareConfiguration>("hardwareConfiguration"); }
            set { BackingStore?.Set("hardwareConfiguration", value); }
        }
#endif
        /// <summary>Identity of the user who last modified the device configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentitySet? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentitySet LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The UTC date and time when the device configuration was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The microphone configuration. Applicable only for Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TeamworkMicrophoneConfiguration? MicrophoneConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkMicrophoneConfiguration?>("microphoneConfiguration"); }
            set { BackingStore?.Set("microphoneConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TeamworkMicrophoneConfiguration MicrophoneConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkMicrophoneConfiguration>("microphoneConfiguration"); }
            set { BackingStore?.Set("microphoneConfiguration", value); }
        }
#endif
        /// <summary>Information related to software versions for the device, such as firmware, operating system, Teams client, and admin agent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TeamworkDeviceSoftwareVersions? SoftwareVersions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkDeviceSoftwareVersions?>("softwareVersions"); }
            set { BackingStore?.Set("softwareVersions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TeamworkDeviceSoftwareVersions SoftwareVersions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkDeviceSoftwareVersions>("softwareVersions"); }
            set { BackingStore?.Set("softwareVersions", value); }
        }
#endif
        /// <summary>The speaker configuration. Applicable only for Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TeamworkSpeakerConfiguration? SpeakerConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkSpeakerConfiguration?>("speakerConfiguration"); }
            set { BackingStore?.Set("speakerConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TeamworkSpeakerConfiguration SpeakerConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkSpeakerConfiguration>("speakerConfiguration"); }
            set { BackingStore?.Set("speakerConfiguration", value); }
        }
#endif
        /// <summary>The system configuration. Not applicable for Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TeamworkSystemConfiguration? SystemConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkSystemConfiguration?>("systemConfiguration"); }
            set { BackingStore?.Set("systemConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TeamworkSystemConfiguration SystemConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkSystemConfiguration>("systemConfiguration"); }
            set { BackingStore?.Set("systemConfiguration", value); }
        }
#endif
        /// <summary>The Teams client configuration. Applicable only for Teams Rooms-enabled devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TeamworkTeamsClientConfiguration? TeamsClientConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkTeamsClientConfiguration?>("teamsClientConfiguration"); }
            set { BackingStore?.Set("teamsClientConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TeamworkTeamsClientConfiguration TeamsClientConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamworkTeamsClientConfiguration>("teamsClientConfiguration"); }
            set { BackingStore?.Set("teamsClientConfiguration", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TeamworkDeviceConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.TeamworkDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.TeamworkDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "cameraConfiguration", n => { CameraConfiguration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkCameraConfiguration>(global::Microsoft.Graph.Beta.Models.TeamworkCameraConfiguration.CreateFromDiscriminatorValue); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>(global::Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "displayConfiguration", n => { DisplayConfiguration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkDisplayConfiguration>(global::Microsoft.Graph.Beta.Models.TeamworkDisplayConfiguration.CreateFromDiscriminatorValue); } },
                { "hardwareConfiguration", n => { HardwareConfiguration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkHardwareConfiguration>(global::Microsoft.Graph.Beta.Models.TeamworkHardwareConfiguration.CreateFromDiscriminatorValue); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>(global::Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "microphoneConfiguration", n => { MicrophoneConfiguration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkMicrophoneConfiguration>(global::Microsoft.Graph.Beta.Models.TeamworkMicrophoneConfiguration.CreateFromDiscriminatorValue); } },
                { "softwareVersions", n => { SoftwareVersions = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkDeviceSoftwareVersions>(global::Microsoft.Graph.Beta.Models.TeamworkDeviceSoftwareVersions.CreateFromDiscriminatorValue); } },
                { "speakerConfiguration", n => { SpeakerConfiguration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkSpeakerConfiguration>(global::Microsoft.Graph.Beta.Models.TeamworkSpeakerConfiguration.CreateFromDiscriminatorValue); } },
                { "systemConfiguration", n => { SystemConfiguration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkSystemConfiguration>(global::Microsoft.Graph.Beta.Models.TeamworkSystemConfiguration.CreateFromDiscriminatorValue); } },
                { "teamsClientConfiguration", n => { TeamsClientConfiguration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkTeamsClientConfiguration>(global::Microsoft.Graph.Beta.Models.TeamworkTeamsClientConfiguration.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkCameraConfiguration>("cameraConfiguration", CameraConfiguration);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkDisplayConfiguration>("displayConfiguration", DisplayConfiguration);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkHardwareConfiguration>("hardwareConfiguration", HardwareConfiguration);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkMicrophoneConfiguration>("microphoneConfiguration", MicrophoneConfiguration);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkDeviceSoftwareVersions>("softwareVersions", SoftwareVersions);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkSpeakerConfiguration>("speakerConfiguration", SpeakerConfiguration);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkSystemConfiguration>("systemConfiguration", SystemConfiguration);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TeamworkTeamsClientConfiguration>("teamsClientConfiguration", TeamsClientConfiguration);
        }
    }
}
#pragma warning restore CS0618
