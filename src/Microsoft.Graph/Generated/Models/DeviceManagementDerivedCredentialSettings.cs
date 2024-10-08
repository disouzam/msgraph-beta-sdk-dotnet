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
    /// Entity that describes tenant level settings for derived credentials
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DeviceManagementDerivedCredentialSettings : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The display name for the profile.</summary>
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
        /// <summary>The URL that will be accessible to end users as they retrieve a derived credential using the Company Portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HelpUrl
        {
            get { return BackingStore?.Get<string?>("helpUrl"); }
            set { BackingStore?.Set("helpUrl", value); }
        }
#nullable restore
#else
        public string HelpUrl
        {
            get { return BackingStore?.Get<string>("helpUrl"); }
            set { BackingStore?.Set("helpUrl", value); }
        }
#endif
        /// <summary>Supported values for the derived credential issuer.</summary>
        public global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialIssuer? Issuer
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialIssuer?>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
        /// <summary>Supported values for the notification type to use.</summary>
        public global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialNotificationType? NotificationType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialNotificationType?>("notificationType"); }
            set { BackingStore?.Set("notificationType", value); }
        }
        /// <summary>The nominal percentage of time before certificate renewal is initiated by the client.</summary>
        public int? RenewalThresholdPercentage
        {
            get { return BackingStore?.Get<int?>("renewalThresholdPercentage"); }
            set { BackingStore?.Set("renewalThresholdPercentage", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "helpUrl", n => { HelpUrl = n.GetStringValue(); } },
                { "issuer", n => { Issuer = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialIssuer>(); } },
                { "notificationType", n => { NotificationType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialNotificationType>(); } },
                { "renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("helpUrl", HelpUrl);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialIssuer>("issuer", Issuer);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.DeviceManagementDerivedCredentialNotificationType>("notificationType", NotificationType);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
        }
    }
}
#pragma warning restore CS0618
