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
    /// MacOS endpoint protection configuration profile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MacOSEndpointProtectionConfiguration : global::Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? AdvancedThreatProtectionAutomaticSampleSubmission
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("advancedThreatProtectionAutomaticSampleSubmission"); }
            set { BackingStore?.Set("advancedThreatProtectionAutomaticSampleSubmission", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? AdvancedThreatProtectionCloudDelivered
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("advancedThreatProtectionCloudDelivered"); }
            set { BackingStore?.Set("advancedThreatProtectionCloudDelivered", value); }
        }
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? AdvancedThreatProtectionDiagnosticDataCollection
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("advancedThreatProtectionDiagnosticDataCollection"); }
            set { BackingStore?.Set("advancedThreatProtectionDiagnosticDataCollection", value); }
        }
        /// <summary>A list of file extensions to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AdvancedThreatProtectionExcludedExtensions
        {
            get { return BackingStore?.Get<List<string>?>("advancedThreatProtectionExcludedExtensions"); }
            set { BackingStore?.Set("advancedThreatProtectionExcludedExtensions", value); }
        }
#nullable restore
#else
        public List<string> AdvancedThreatProtectionExcludedExtensions
        {
            get { return BackingStore?.Get<List<string>>("advancedThreatProtectionExcludedExtensions"); }
            set { BackingStore?.Set("advancedThreatProtectionExcludedExtensions", value); }
        }
#endif
        /// <summary>A list of paths to files to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AdvancedThreatProtectionExcludedFiles
        {
            get { return BackingStore?.Get<List<string>?>("advancedThreatProtectionExcludedFiles"); }
            set { BackingStore?.Set("advancedThreatProtectionExcludedFiles", value); }
        }
#nullable restore
#else
        public List<string> AdvancedThreatProtectionExcludedFiles
        {
            get { return BackingStore?.Get<List<string>>("advancedThreatProtectionExcludedFiles"); }
            set { BackingStore?.Set("advancedThreatProtectionExcludedFiles", value); }
        }
#endif
        /// <summary>A list of paths to folders to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AdvancedThreatProtectionExcludedFolders
        {
            get { return BackingStore?.Get<List<string>?>("advancedThreatProtectionExcludedFolders"); }
            set { BackingStore?.Set("advancedThreatProtectionExcludedFolders", value); }
        }
#nullable restore
#else
        public List<string> AdvancedThreatProtectionExcludedFolders
        {
            get { return BackingStore?.Get<List<string>>("advancedThreatProtectionExcludedFolders"); }
            set { BackingStore?.Set("advancedThreatProtectionExcludedFolders", value); }
        }
#endif
        /// <summary>A list of process names to exclude from antivirus scanning for Microsoft Defender Advanced Threat Protection on macOS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AdvancedThreatProtectionExcludedProcesses
        {
            get { return BackingStore?.Get<List<string>?>("advancedThreatProtectionExcludedProcesses"); }
            set { BackingStore?.Set("advancedThreatProtectionExcludedProcesses", value); }
        }
#nullable restore
#else
        public List<string> AdvancedThreatProtectionExcludedProcesses
        {
            get { return BackingStore?.Get<List<string>>("advancedThreatProtectionExcludedProcesses"); }
            set { BackingStore?.Set("advancedThreatProtectionExcludedProcesses", value); }
        }
#endif
        /// <summary>Possible values of a property</summary>
        public global::Microsoft.Graph.Beta.Models.Enablement? AdvancedThreatProtectionRealTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Enablement?>("advancedThreatProtectionRealTime"); }
            set { BackingStore?.Set("advancedThreatProtectionRealTime", value); }
        }
        /// <summary>Optional. If set to true, the user can defer the enabling of FileVault until they sign out.</summary>
        public bool? FileVaultAllowDeferralUntilSignOut
        {
            get { return BackingStore?.Get<bool?>("fileVaultAllowDeferralUntilSignOut"); }
            set { BackingStore?.Set("fileVaultAllowDeferralUntilSignOut", value); }
        }
        /// <summary>Optional. When using the Defer option, if set to true, the user is not prompted to enable FileVault at sign-out.</summary>
        public bool? FileVaultDisablePromptAtSignOut
        {
            get { return BackingStore?.Get<bool?>("fileVaultDisablePromptAtSignOut"); }
            set { BackingStore?.Set("fileVaultDisablePromptAtSignOut", value); }
        }
        /// <summary>Whether FileVault should be enabled or not.</summary>
        public bool? FileVaultEnabled
        {
            get { return BackingStore?.Get<bool?>("fileVaultEnabled"); }
            set { BackingStore?.Set("fileVaultEnabled", value); }
        }
        /// <summary>Optional. A hidden personal recovery key does not appear on the user&apos;s screen during FileVault encryption, reducing the risk of it ending up in the wrong hands.</summary>
        public bool? FileVaultHidePersonalRecoveryKey
        {
            get { return BackingStore?.Get<bool?>("fileVaultHidePersonalRecoveryKey"); }
            set { BackingStore?.Set("fileVaultHidePersonalRecoveryKey", value); }
        }
        /// <summary>Required if selected recovery key type(s) include InstitutionalRecoveryKey. The DER Encoded certificate file used to set an institutional recovery key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? FileVaultInstitutionalRecoveryKeyCertificate
        {
            get { return BackingStore?.Get<byte[]?>("fileVaultInstitutionalRecoveryKeyCertificate"); }
            set { BackingStore?.Set("fileVaultInstitutionalRecoveryKeyCertificate", value); }
        }
#nullable restore
#else
        public byte[] FileVaultInstitutionalRecoveryKeyCertificate
        {
            get { return BackingStore?.Get<byte[]>("fileVaultInstitutionalRecoveryKeyCertificate"); }
            set { BackingStore?.Set("fileVaultInstitutionalRecoveryKeyCertificate", value); }
        }
#endif
        /// <summary>File name of the institutional recovery key certificate to display in UI. (.der).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileVaultInstitutionalRecoveryKeyCertificateFileName
        {
            get { return BackingStore?.Get<string?>("fileVaultInstitutionalRecoveryKeyCertificateFileName"); }
            set { BackingStore?.Set("fileVaultInstitutionalRecoveryKeyCertificateFileName", value); }
        }
#nullable restore
#else
        public string FileVaultInstitutionalRecoveryKeyCertificateFileName
        {
            get { return BackingStore?.Get<string>("fileVaultInstitutionalRecoveryKeyCertificateFileName"); }
            set { BackingStore?.Set("fileVaultInstitutionalRecoveryKeyCertificateFileName", value); }
        }
#endif
        /// <summary>Optional. When using the Defer option, this is the maximum number of times the user can ignore prompts to enable FileVault before FileVault will be required for the user to sign in. If set to -1, it will always prompt to enable FileVault until FileVault is enabled, though it will allow the user to bypass enabling FileVault. Setting this to 0 will disable the feature.</summary>
        public int? FileVaultNumberOfTimesUserCanIgnore
        {
            get { return BackingStore?.Get<int?>("fileVaultNumberOfTimesUserCanIgnore"); }
            set { BackingStore?.Set("fileVaultNumberOfTimesUserCanIgnore", value); }
        }
        /// <summary>Required if selected recovery key type(s) include PersonalRecoveryKey. A short message displayed to the user that explains how they can retrieve their personal recovery key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileVaultPersonalRecoveryKeyHelpMessage
        {
            get { return BackingStore?.Get<string?>("fileVaultPersonalRecoveryKeyHelpMessage"); }
            set { BackingStore?.Set("fileVaultPersonalRecoveryKeyHelpMessage", value); }
        }
#nullable restore
#else
        public string FileVaultPersonalRecoveryKeyHelpMessage
        {
            get { return BackingStore?.Get<string>("fileVaultPersonalRecoveryKeyHelpMessage"); }
            set { BackingStore?.Set("fileVaultPersonalRecoveryKeyHelpMessage", value); }
        }
#endif
        /// <summary>Optional. If selected recovery key type(s) include PersonalRecoveryKey, the frequency to rotate that key, in months.</summary>
        public int? FileVaultPersonalRecoveryKeyRotationInMonths
        {
            get { return BackingStore?.Get<int?>("fileVaultPersonalRecoveryKeyRotationInMonths"); }
            set { BackingStore?.Set("fileVaultPersonalRecoveryKeyRotationInMonths", value); }
        }
        /// <summary>Recovery key types for macOS FileVault</summary>
        public global::Microsoft.Graph.Beta.Models.MacOSFileVaultRecoveryKeyTypes? FileVaultSelectedRecoveryKeyTypes
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MacOSFileVaultRecoveryKeyTypes?>("fileVaultSelectedRecoveryKeyTypes"); }
            set { BackingStore?.Set("fileVaultSelectedRecoveryKeyTypes", value); }
        }
        /// <summary>List of applications with firewall settings. Firewall settings for applications not on this list are determined by the user. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MacOSFirewallApplication>? FirewallApplications
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MacOSFirewallApplication>?>("firewallApplications"); }
            set { BackingStore?.Set("firewallApplications", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MacOSFirewallApplication> FirewallApplications
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MacOSFirewallApplication>>("firewallApplications"); }
            set { BackingStore?.Set("firewallApplications", value); }
        }
#endif
        /// <summary>Corresponds to the &apos;Block all incoming connections&apos; option.</summary>
        public bool? FirewallBlockAllIncoming
        {
            get { return BackingStore?.Get<bool?>("firewallBlockAllIncoming"); }
            set { BackingStore?.Set("firewallBlockAllIncoming", value); }
        }
        /// <summary>Whether the firewall should be enabled or not.</summary>
        public bool? FirewallEnabled
        {
            get { return BackingStore?.Get<bool?>("firewallEnabled"); }
            set { BackingStore?.Set("firewallEnabled", value); }
        }
        /// <summary>Corresponds to &apos;Enable stealth mode.&apos;</summary>
        public bool? FirewallEnableStealthMode
        {
            get { return BackingStore?.Get<bool?>("firewallEnableStealthMode"); }
            set { BackingStore?.Set("firewallEnableStealthMode", value); }
        }
        /// <summary>App source options for macOS Gatekeeper.</summary>
        public global::Microsoft.Graph.Beta.Models.MacOSGatekeeperAppSources? GatekeeperAllowedAppSource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MacOSGatekeeperAppSources?>("gatekeeperAllowedAppSource"); }
            set { BackingStore?.Set("gatekeeperAllowedAppSource", value); }
        }
        /// <summary>If set to true, the user override for Gatekeeper will be disabled.</summary>
        public bool? GatekeeperBlockOverride
        {
            get { return BackingStore?.Get<bool?>("gatekeeperBlockOverride"); }
            set { BackingStore?.Set("gatekeeperBlockOverride", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MacOSEndpointProtectionConfiguration"/> and sets the default values.
        /// </summary>
        public MacOSEndpointProtectionConfiguration() : base()
        {
            OdataType = "#microsoft.graph.macOSEndpointProtectionConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MacOSEndpointProtectionConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MacOSEndpointProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MacOSEndpointProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "advancedThreatProtectionAutomaticSampleSubmission", n => { AdvancedThreatProtectionAutomaticSampleSubmission = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "advancedThreatProtectionCloudDelivered", n => { AdvancedThreatProtectionCloudDelivered = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "advancedThreatProtectionDiagnosticDataCollection", n => { AdvancedThreatProtectionDiagnosticDataCollection = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "advancedThreatProtectionExcludedExtensions", n => { AdvancedThreatProtectionExcludedExtensions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "advancedThreatProtectionExcludedFiles", n => { AdvancedThreatProtectionExcludedFiles = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "advancedThreatProtectionExcludedFolders", n => { AdvancedThreatProtectionExcludedFolders = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "advancedThreatProtectionExcludedProcesses", n => { AdvancedThreatProtectionExcludedProcesses = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "advancedThreatProtectionRealTime", n => { AdvancedThreatProtectionRealTime = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>(); } },
                { "fileVaultAllowDeferralUntilSignOut", n => { FileVaultAllowDeferralUntilSignOut = n.GetBoolValue(); } },
                { "fileVaultDisablePromptAtSignOut", n => { FileVaultDisablePromptAtSignOut = n.GetBoolValue(); } },
                { "fileVaultEnabled", n => { FileVaultEnabled = n.GetBoolValue(); } },
                { "fileVaultHidePersonalRecoveryKey", n => { FileVaultHidePersonalRecoveryKey = n.GetBoolValue(); } },
                { "fileVaultInstitutionalRecoveryKeyCertificate", n => { FileVaultInstitutionalRecoveryKeyCertificate = n.GetByteArrayValue(); } },
                { "fileVaultInstitutionalRecoveryKeyCertificateFileName", n => { FileVaultInstitutionalRecoveryKeyCertificateFileName = n.GetStringValue(); } },
                { "fileVaultNumberOfTimesUserCanIgnore", n => { FileVaultNumberOfTimesUserCanIgnore = n.GetIntValue(); } },
                { "fileVaultPersonalRecoveryKeyHelpMessage", n => { FileVaultPersonalRecoveryKeyHelpMessage = n.GetStringValue(); } },
                { "fileVaultPersonalRecoveryKeyRotationInMonths", n => { FileVaultPersonalRecoveryKeyRotationInMonths = n.GetIntValue(); } },
                { "fileVaultSelectedRecoveryKeyTypes", n => { FileVaultSelectedRecoveryKeyTypes = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.MacOSFileVaultRecoveryKeyTypes>(); } },
                { "firewallApplications", n => { FirewallApplications = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MacOSFirewallApplication>(global::Microsoft.Graph.Beta.Models.MacOSFirewallApplication.CreateFromDiscriminatorValue)?.AsList(); } },
                { "firewallBlockAllIncoming", n => { FirewallBlockAllIncoming = n.GetBoolValue(); } },
                { "firewallEnableStealthMode", n => { FirewallEnableStealthMode = n.GetBoolValue(); } },
                { "firewallEnabled", n => { FirewallEnabled = n.GetBoolValue(); } },
                { "gatekeeperAllowedAppSource", n => { GatekeeperAllowedAppSource = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.MacOSGatekeeperAppSources>(); } },
                { "gatekeeperBlockOverride", n => { GatekeeperBlockOverride = n.GetBoolValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("advancedThreatProtectionAutomaticSampleSubmission", AdvancedThreatProtectionAutomaticSampleSubmission);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("advancedThreatProtectionCloudDelivered", AdvancedThreatProtectionCloudDelivered);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("advancedThreatProtectionDiagnosticDataCollection", AdvancedThreatProtectionDiagnosticDataCollection);
            writer.WriteCollectionOfPrimitiveValues<string>("advancedThreatProtectionExcludedExtensions", AdvancedThreatProtectionExcludedExtensions);
            writer.WriteCollectionOfPrimitiveValues<string>("advancedThreatProtectionExcludedFiles", AdvancedThreatProtectionExcludedFiles);
            writer.WriteCollectionOfPrimitiveValues<string>("advancedThreatProtectionExcludedFolders", AdvancedThreatProtectionExcludedFolders);
            writer.WriteCollectionOfPrimitiveValues<string>("advancedThreatProtectionExcludedProcesses", AdvancedThreatProtectionExcludedProcesses);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Enablement>("advancedThreatProtectionRealTime", AdvancedThreatProtectionRealTime);
            writer.WriteBoolValue("fileVaultAllowDeferralUntilSignOut", FileVaultAllowDeferralUntilSignOut);
            writer.WriteBoolValue("fileVaultDisablePromptAtSignOut", FileVaultDisablePromptAtSignOut);
            writer.WriteBoolValue("fileVaultEnabled", FileVaultEnabled);
            writer.WriteBoolValue("fileVaultHidePersonalRecoveryKey", FileVaultHidePersonalRecoveryKey);
            writer.WriteByteArrayValue("fileVaultInstitutionalRecoveryKeyCertificate", FileVaultInstitutionalRecoveryKeyCertificate);
            writer.WriteStringValue("fileVaultInstitutionalRecoveryKeyCertificateFileName", FileVaultInstitutionalRecoveryKeyCertificateFileName);
            writer.WriteIntValue("fileVaultNumberOfTimesUserCanIgnore", FileVaultNumberOfTimesUserCanIgnore);
            writer.WriteStringValue("fileVaultPersonalRecoveryKeyHelpMessage", FileVaultPersonalRecoveryKeyHelpMessage);
            writer.WriteIntValue("fileVaultPersonalRecoveryKeyRotationInMonths", FileVaultPersonalRecoveryKeyRotationInMonths);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.MacOSFileVaultRecoveryKeyTypes>("fileVaultSelectedRecoveryKeyTypes", FileVaultSelectedRecoveryKeyTypes);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MacOSFirewallApplication>("firewallApplications", FirewallApplications);
            writer.WriteBoolValue("firewallBlockAllIncoming", FirewallBlockAllIncoming);
            writer.WriteBoolValue("firewallEnabled", FirewallEnabled);
            writer.WriteBoolValue("firewallEnableStealthMode", FirewallEnableStealthMode);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.MacOSGatekeeperAppSources>("gatekeeperAllowedAppSource", GatekeeperAllowedAppSource);
            writer.WriteBoolValue("gatekeeperBlockOverride", GatekeeperBlockOverride);
        }
    }
}
#pragma warning restore CS0618
