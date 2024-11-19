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
    /// Policy used to configure detailed management settings targeted to specific security groups and for a specified set of apps on an iOS device
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IosManagedAppProtection : global::Microsoft.Graph.Beta.Models.TargetedManagedAppProtection, IParsable
    {
        /// <summary>Semicolon seperated list of device models allowed, as a string, for the managed app to work.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AllowedIosDeviceModels
        {
            get { return BackingStore?.Get<string?>("allowedIosDeviceModels"); }
            set { BackingStore?.Set("allowedIosDeviceModels", value); }
        }
#nullable restore
#else
        public string AllowedIosDeviceModels
        {
            get { return BackingStore?.Get<string>("allowedIosDeviceModels"); }
            set { BackingStore?.Set("allowedIosDeviceModels", value); }
        }
#endif
        /// <summary>Indicates  if content sync for widgets is allowed for iOS on App Protection Policies</summary>
        public bool? AllowWidgetContentSync
        {
            get { return BackingStore?.Get<bool?>("allowWidgetContentSync"); }
            set { BackingStore?.Set("allowWidgetContentSync", value); }
        }
        /// <summary>Defines a managed app behavior, either block or warn, if the user is clocked out (non-working time). Possible values are: block, wipe, warn, blockWhenSettingIsSupported.</summary>
        public global::Microsoft.Graph.Beta.Models.ManagedAppRemediationAction? AppActionIfAccountIsClockedOut
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedAppRemediationAction?>("appActionIfAccountIsClockedOut"); }
            set { BackingStore?.Set("appActionIfAccountIsClockedOut", value); }
        }
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public global::Microsoft.Graph.Beta.Models.ManagedAppRemediationAction? AppActionIfIosDeviceModelNotAllowed
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedAppRemediationAction?>("appActionIfIosDeviceModelNotAllowed"); }
            set { BackingStore?.Set("appActionIfIosDeviceModelNotAllowed", value); }
        }
        /// <summary>Represents the level to which app data is encrypted for managed apps</summary>
        public global::Microsoft.Graph.Beta.Models.ManagedAppDataEncryptionType? AppDataEncryptionType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedAppDataEncryptionType?>("appDataEncryptionType"); }
            set { BackingStore?.Set("appDataEncryptionType", value); }
        }
        /// <summary>List of apps to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedMobileApp>? Apps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedMobileApp>?>("apps"); }
            set { BackingStore?.Set("apps", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedMobileApp> Apps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedMobileApp>>("apps"); }
            set { BackingStore?.Set("apps", value); }
        }
#endif
        /// <summary>A custom browser protocol to open weblink on iOS. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomBrowserProtocol
        {
            get { return BackingStore?.Get<string?>("customBrowserProtocol"); }
            set { BackingStore?.Set("customBrowserProtocol", value); }
        }
#nullable restore
#else
        public string CustomBrowserProtocol
        {
            get { return BackingStore?.Get<string>("customBrowserProtocol"); }
            set { BackingStore?.Set("customBrowserProtocol", value); }
        }
#endif
        /// <summary>Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomDialerAppProtocol
        {
            get { return BackingStore?.Get<string?>("customDialerAppProtocol"); }
            set { BackingStore?.Set("customDialerAppProtocol", value); }
        }
#nullable restore
#else
        public string CustomDialerAppProtocol
        {
            get { return BackingStore?.Get<string>("customDialerAppProtocol"); }
            set { BackingStore?.Set("customDialerAppProtocol", value); }
        }
#endif
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount
        {
            get { return BackingStore?.Get<int?>("deployedAppCount"); }
            set { BackingStore?.Set("deployedAppCount", value); }
        }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ManagedAppPolicyDeploymentSummary? DeploymentSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedAppPolicyDeploymentSummary?>("deploymentSummary"); }
            set { BackingStore?.Set("deploymentSummary", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ManagedAppPolicyDeploymentSummary DeploymentSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedAppPolicyDeploymentSummary>("deploymentSummary"); }
            set { BackingStore?.Set("deploymentSummary", value); }
        }
#endif
        /// <summary>Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps.</summary>
        public bool? DisableProtectionOfManagedOutboundOpenInData
        {
            get { return BackingStore?.Get<bool?>("disableProtectionOfManagedOutboundOpenInData"); }
            set { BackingStore?.Set("disableProtectionOfManagedOutboundOpenInData", value); }
        }
        /// <summary>Apps in this list will be exempt from the policy and will be able to receive data from managed apps.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.KeyValuePair>? ExemptedAppProtocols
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyValuePair>?>("exemptedAppProtocols"); }
            set { BackingStore?.Set("exemptedAppProtocols", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.KeyValuePair> ExemptedAppProtocols
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyValuePair>>("exemptedAppProtocols"); }
            set { BackingStore?.Set("exemptedAppProtocols", value); }
        }
#endif
        /// <summary>A list of custom urls that are allowed to invocate an unmanaged app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExemptedUniversalLinks
        {
            get { return BackingStore?.Get<List<string>?>("exemptedUniversalLinks"); }
            set { BackingStore?.Set("exemptedUniversalLinks", value); }
        }
#nullable restore
#else
        public List<string> ExemptedUniversalLinks
        {
            get { return BackingStore?.Get<List<string>>("exemptedUniversalLinks"); }
            set { BackingStore?.Set("exemptedUniversalLinks", value); }
        }
#endif
        /// <summary>Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FaceIdBlocked
        {
            get { return BackingStore?.Get<bool?>("faceIdBlocked"); }
            set { BackingStore?.Set("faceIdBlocked", value); }
        }
        /// <summary>Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False.</summary>
        public bool? FilterOpenInToOnlyManagedApps
        {
            get { return BackingStore?.Get<bool?>("filterOpenInToOnlyManagedApps"); }
            set { BackingStore?.Set("filterOpenInToOnlyManagedApps", value); }
        }
        /// <summary>A list of custom urls that are allowed to invocate a managed app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ManagedUniversalLinks
        {
            get { return BackingStore?.Get<List<string>?>("managedUniversalLinks"); }
            set { BackingStore?.Set("managedUniversalLinks", value); }
        }
#nullable restore
#else
        public List<string> ManagedUniversalLinks
        {
            get { return BackingStore?.Get<List<string>>("managedUniversalLinks"); }
            set { BackingStore?.Set("managedUniversalLinks", value); }
        }
#endif
        /// <summary>When a specific app redirection is enforced by protectedMessagingRedirectAppType in an App Protection Policy, this value defines the app url redirect schemes which are allowed to be used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessagingRedirectAppUrlScheme
        {
            get { return BackingStore?.Get<string?>("messagingRedirectAppUrlScheme"); }
            set { BackingStore?.Set("messagingRedirectAppUrlScheme", value); }
        }
#nullable restore
#else
        public string MessagingRedirectAppUrlScheme
        {
            get { return BackingStore?.Get<string>("messagingRedirectAppUrlScheme"); }
            set { BackingStore?.Set("messagingRedirectAppUrlScheme", value); }
        }
#endif
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredSdkVersion
        {
            get { return BackingStore?.Get<string?>("minimumRequiredSdkVersion"); }
            set { BackingStore?.Set("minimumRequiredSdkVersion", value); }
        }
#nullable restore
#else
        public string MinimumRequiredSdkVersion
        {
            get { return BackingStore?.Get<string>("minimumRequiredSdkVersion"); }
            set { BackingStore?.Set("minimumRequiredSdkVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningSdkVersion
        {
            get { return BackingStore?.Get<string?>("minimumWarningSdkVersion"); }
            set { BackingStore?.Set("minimumWarningSdkVersion", value); }
        }
#nullable restore
#else
        public string MinimumWarningSdkVersion
        {
            get { return BackingStore?.Get<string>("minimumWarningSdkVersion"); }
            set { BackingStore?.Set("minimumWarningSdkVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWipeSdkVersion
        {
            get { return BackingStore?.Get<string?>("minimumWipeSdkVersion"); }
            set { BackingStore?.Set("minimumWipeSdkVersion", value); }
        }
#nullable restore
#else
        public string MinimumWipeSdkVersion
        {
            get { return BackingStore?.Get<string>("minimumWipeSdkVersion"); }
            set { BackingStore?.Set("minimumWipeSdkVersion", value); }
        }
#endif
        /// <summary>Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps.</summary>
        public bool? ProtectInboundDataFromUnknownSources
        {
            get { return BackingStore?.Get<bool?>("protectInboundDataFromUnknownSources"); }
            set { BackingStore?.Set("protectInboundDataFromUnknownSources", value); }
        }
        /// <summary>Defines if third party keyboards are allowed while accessing a managed app</summary>
        public bool? ThirdPartyKeyboardsBlocked
        {
            get { return BackingStore?.Get<bool?>("thirdPartyKeyboardsBlocked"); }
            set { BackingStore?.Set("thirdPartyKeyboardsBlocked", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IosManagedAppProtection"/> and sets the default values.
        /// </summary>
        public IosManagedAppProtection() : base()
        {
            OdataType = "#microsoft.graph.iosManagedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IosManagedAppProtection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IosManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IosManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowWidgetContentSync", n => { AllowWidgetContentSync = n.GetBoolValue(); } },
                { "allowedIosDeviceModels", n => { AllowedIosDeviceModels = n.GetStringValue(); } },
                { "appActionIfAccountIsClockedOut", n => { AppActionIfAccountIsClockedOut = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ManagedAppRemediationAction>(); } },
                { "appActionIfIosDeviceModelNotAllowed", n => { AppActionIfIosDeviceModelNotAllowed = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ManagedAppRemediationAction>(); } },
                { "appDataEncryptionType", n => { AppDataEncryptionType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ManagedAppDataEncryptionType>(); } },
                { "apps", n => { Apps = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedMobileApp>(global::Microsoft.Graph.Beta.Models.ManagedMobileApp.CreateFromDiscriminatorValue)?.AsList(); } },
                { "customBrowserProtocol", n => { CustomBrowserProtocol = n.GetStringValue(); } },
                { "customDialerAppProtocol", n => { CustomDialerAppProtocol = n.GetStringValue(); } },
                { "deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                { "deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ManagedAppPolicyDeploymentSummary>(global::Microsoft.Graph.Beta.Models.ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                { "disableProtectionOfManagedOutboundOpenInData", n => { DisableProtectionOfManagedOutboundOpenInData = n.GetBoolValue(); } },
                { "exemptedAppProtocols", n => { ExemptedAppProtocols = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyValuePair>(global::Microsoft.Graph.Beta.Models.KeyValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "exemptedUniversalLinks", n => { ExemptedUniversalLinks = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "faceIdBlocked", n => { FaceIdBlocked = n.GetBoolValue(); } },
                { "filterOpenInToOnlyManagedApps", n => { FilterOpenInToOnlyManagedApps = n.GetBoolValue(); } },
                { "managedUniversalLinks", n => { ManagedUniversalLinks = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "messagingRedirectAppUrlScheme", n => { MessagingRedirectAppUrlScheme = n.GetStringValue(); } },
                { "minimumRequiredSdkVersion", n => { MinimumRequiredSdkVersion = n.GetStringValue(); } },
                { "minimumWarningSdkVersion", n => { MinimumWarningSdkVersion = n.GetStringValue(); } },
                { "minimumWipeSdkVersion", n => { MinimumWipeSdkVersion = n.GetStringValue(); } },
                { "protectInboundDataFromUnknownSources", n => { ProtectInboundDataFromUnknownSources = n.GetBoolValue(); } },
                { "thirdPartyKeyboardsBlocked", n => { ThirdPartyKeyboardsBlocked = n.GetBoolValue(); } },
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
            writer.WriteStringValue("allowedIosDeviceModels", AllowedIosDeviceModels);
            writer.WriteBoolValue("allowWidgetContentSync", AllowWidgetContentSync);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ManagedAppRemediationAction>("appActionIfAccountIsClockedOut", AppActionIfAccountIsClockedOut);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ManagedAppRemediationAction>("appActionIfIosDeviceModelNotAllowed", AppActionIfIosDeviceModelNotAllowed);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ManagedAppDataEncryptionType>("appDataEncryptionType", AppDataEncryptionType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedMobileApp>("apps", Apps);
            writer.WriteStringValue("customBrowserProtocol", CustomBrowserProtocol);
            writer.WriteStringValue("customDialerAppProtocol", CustomDialerAppProtocol);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("disableProtectionOfManagedOutboundOpenInData", DisableProtectionOfManagedOutboundOpenInData);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyValuePair>("exemptedAppProtocols", ExemptedAppProtocols);
            writer.WriteCollectionOfPrimitiveValues<string>("exemptedUniversalLinks", ExemptedUniversalLinks);
            writer.WriteBoolValue("faceIdBlocked", FaceIdBlocked);
            writer.WriteBoolValue("filterOpenInToOnlyManagedApps", FilterOpenInToOnlyManagedApps);
            writer.WriteCollectionOfPrimitiveValues<string>("managedUniversalLinks", ManagedUniversalLinks);
            writer.WriteStringValue("messagingRedirectAppUrlScheme", MessagingRedirectAppUrlScheme);
            writer.WriteStringValue("minimumRequiredSdkVersion", MinimumRequiredSdkVersion);
            writer.WriteStringValue("minimumWarningSdkVersion", MinimumWarningSdkVersion);
            writer.WriteStringValue("minimumWipeSdkVersion", MinimumWipeSdkVersion);
            writer.WriteBoolValue("protectInboundDataFromUnknownSources", ProtectInboundDataFromUnknownSources);
            writer.WriteBoolValue("thirdPartyKeyboardsBlocked", ThirdPartyKeyboardsBlocked);
        }
    }
}
#pragma warning restore CS0618
