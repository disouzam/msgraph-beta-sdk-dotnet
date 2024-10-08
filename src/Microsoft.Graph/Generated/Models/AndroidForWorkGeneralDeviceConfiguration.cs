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
    /// Android For Work general device configuration.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class AndroidForWorkGeneralDeviceConfiguration : global::Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Determine domains allow-list for accounts that can be added to work profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedGoogleAccountDomains
        {
            get { return BackingStore?.Get<List<string>?>("allowedGoogleAccountDomains"); }
            set { BackingStore?.Set("allowedGoogleAccountDomains", value); }
        }
#nullable restore
#else
        public List<string> AllowedGoogleAccountDomains
        {
            get { return BackingStore?.Get<List<string>>("allowedGoogleAccountDomains"); }
            set { BackingStore?.Set("allowedGoogleAccountDomains", value); }
        }
#endif
        /// <summary>Prevent using unified password for unlocking device and work profile.</summary>
        public bool? BlockUnifiedPasswordForWorkProfile
        {
            get { return BackingStore?.Get<bool?>("blockUnifiedPasswordForWorkProfile"); }
            set { BackingStore?.Set("blockUnifiedPasswordForWorkProfile", value); }
        }
        /// <summary>Indicates whether or not to block face unlock.</summary>
        public bool? PasswordBlockFaceUnlock
        {
            get { return BackingStore?.Get<bool?>("passwordBlockFaceUnlock"); }
            set { BackingStore?.Set("passwordBlockFaceUnlock", value); }
        }
        /// <summary>Indicates whether or not to block fingerprint unlock.</summary>
        public bool? PasswordBlockFingerprintUnlock
        {
            get { return BackingStore?.Get<bool?>("passwordBlockFingerprintUnlock"); }
            set { BackingStore?.Set("passwordBlockFingerprintUnlock", value); }
        }
        /// <summary>Indicates whether or not to block iris unlock.</summary>
        public bool? PasswordBlockIrisUnlock
        {
            get { return BackingStore?.Get<bool?>("passwordBlockIrisUnlock"); }
            set { BackingStore?.Set("passwordBlockIrisUnlock", value); }
        }
        /// <summary>Indicates whether or not to block Smart Lock and other trust agents.</summary>
        public bool? PasswordBlockTrustAgents
        {
            get { return BackingStore?.Get<bool?>("passwordBlockTrustAgents"); }
            set { BackingStore?.Set("passwordBlockTrustAgents", value); }
        }
        /// <summary>Number of days before the password expires. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays
        {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>Minimum length of passwords. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength
        {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout
        {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeScreenTimeout"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeScreenTimeout", value); }
        }
        /// <summary>Number of previous passwords to block. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount
        {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Android For Work required password type.</summary>
        public global::Microsoft.Graph.Beta.Models.AndroidForWorkRequiredPasswordType? PasswordRequiredType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidForWorkRequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>Number of sign in failures allowed before factory reset. Valid values 1 to 16</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset
        {
            get { return BackingStore?.Get<int?>("passwordSignInFailureCountBeforeFactoryReset"); }
            set { BackingStore?.Set("passwordSignInFailureCountBeforeFactoryReset", value); }
        }
        /// <summary>The password complexity types that can be set on Android. One of: NONE, LOW, MEDIUM, HIGH. This is an API targeted to Android 11+.</summary>
        public global::Microsoft.Graph.Beta.Models.AndroidRequiredPasswordComplexity? RequiredPasswordComplexity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidRequiredPasswordComplexity?>("requiredPasswordComplexity"); }
            set { BackingStore?.Set("requiredPasswordComplexity", value); }
        }
        /// <summary>Require the Android Verify apps feature is turned on.</summary>
        public bool? SecurityRequireVerifyApps
        {
            get { return BackingStore?.Get<bool?>("securityRequireVerifyApps"); }
            set { BackingStore?.Set("securityRequireVerifyApps", value); }
        }
        /// <summary>Enable lockdown mode for always-on VPN.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VpnAlwaysOnPackageIdentifier
        {
            get { return BackingStore?.Get<string?>("vpnAlwaysOnPackageIdentifier"); }
            set { BackingStore?.Set("vpnAlwaysOnPackageIdentifier", value); }
        }
#nullable restore
#else
        public string VpnAlwaysOnPackageIdentifier
        {
            get { return BackingStore?.Get<string>("vpnAlwaysOnPackageIdentifier"); }
            set { BackingStore?.Set("vpnAlwaysOnPackageIdentifier", value); }
        }
#endif
        /// <summary>Enable lockdown mode for always-on VPN.</summary>
        public bool? VpnEnableAlwaysOnLockdownMode
        {
            get { return BackingStore?.Get<bool?>("vpnEnableAlwaysOnLockdownMode"); }
            set { BackingStore?.Set("vpnEnableAlwaysOnLockdownMode", value); }
        }
        /// <summary>An enum representing possible values for account use in work profile.</summary>
        public global::Microsoft.Graph.Beta.Models.AndroidWorkProfileAccountUse? WorkProfileAccountUse
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidWorkProfileAccountUse?>("workProfileAccountUse"); }
            set { BackingStore?.Set("workProfileAccountUse", value); }
        }
        /// <summary>Allow widgets from work profile apps.</summary>
        public bool? WorkProfileAllowWidgets
        {
            get { return BackingStore?.Get<bool?>("workProfileAllowWidgets"); }
            set { BackingStore?.Set("workProfileAllowWidgets", value); }
        }
        /// <summary>Block users from adding/removing accounts in work profile.</summary>
        public bool? WorkProfileBlockAddingAccounts
        {
            get { return BackingStore?.Get<bool?>("workProfileBlockAddingAccounts"); }
            set { BackingStore?.Set("workProfileBlockAddingAccounts", value); }
        }
        /// <summary>Block work profile camera.</summary>
        public bool? WorkProfileBlockCamera
        {
            get { return BackingStore?.Get<bool?>("workProfileBlockCamera"); }
            set { BackingStore?.Set("workProfileBlockCamera", value); }
        }
        /// <summary>Block display work profile caller ID in personal profile.</summary>
        public bool? WorkProfileBlockCrossProfileCallerId
        {
            get { return BackingStore?.Get<bool?>("workProfileBlockCrossProfileCallerId"); }
            set { BackingStore?.Set("workProfileBlockCrossProfileCallerId", value); }
        }
        /// <summary>Block work profile contacts availability in personal profile.</summary>
        public bool? WorkProfileBlockCrossProfileContactsSearch
        {
            get { return BackingStore?.Get<bool?>("workProfileBlockCrossProfileContactsSearch"); }
            set { BackingStore?.Set("workProfileBlockCrossProfileContactsSearch", value); }
        }
        /// <summary>Boolean that indicates if the setting disallow cross profile copy/paste is enabled.</summary>
        public bool? WorkProfileBlockCrossProfileCopyPaste
        {
            get { return BackingStore?.Get<bool?>("workProfileBlockCrossProfileCopyPaste"); }
            set { BackingStore?.Set("workProfileBlockCrossProfileCopyPaste", value); }
        }
        /// <summary>Indicates whether or not to block notifications while device locked.</summary>
        public bool? WorkProfileBlockNotificationsWhileDeviceLocked
        {
            get { return BackingStore?.Get<bool?>("workProfileBlockNotificationsWhileDeviceLocked"); }
            set { BackingStore?.Set("workProfileBlockNotificationsWhileDeviceLocked", value); }
        }
        /// <summary>Prevent app installations from unknown sources in the personal profile.</summary>
        public bool? WorkProfileBlockPersonalAppInstallsFromUnknownSources
        {
            get { return BackingStore?.Get<bool?>("workProfileBlockPersonalAppInstallsFromUnknownSources"); }
            set { BackingStore?.Set("workProfileBlockPersonalAppInstallsFromUnknownSources", value); }
        }
        /// <summary>Block screen capture in work profile.</summary>
        public bool? WorkProfileBlockScreenCapture
        {
            get { return BackingStore?.Get<bool?>("workProfileBlockScreenCapture"); }
            set { BackingStore?.Set("workProfileBlockScreenCapture", value); }
        }
        /// <summary>Allow bluetooth devices to access enterprise contacts.</summary>
        public bool? WorkProfileBluetoothEnableContactSharing
        {
            get { return BackingStore?.Get<bool?>("workProfileBluetoothEnableContactSharing"); }
            set { BackingStore?.Set("workProfileBluetoothEnableContactSharing", value); }
        }
        /// <summary>Android For Work cross profile data sharing type.</summary>
        public global::Microsoft.Graph.Beta.Models.AndroidForWorkCrossProfileDataSharingType? WorkProfileDataSharingType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidForWorkCrossProfileDataSharingType?>("workProfileDataSharingType"); }
            set { BackingStore?.Set("workProfileDataSharingType", value); }
        }
        /// <summary>Android For Work default app permission policy type.</summary>
        public global::Microsoft.Graph.Beta.Models.AndroidForWorkDefaultAppPermissionPolicyType? WorkProfileDefaultAppPermissionPolicy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidForWorkDefaultAppPermissionPolicyType?>("workProfileDefaultAppPermissionPolicy"); }
            set { BackingStore?.Set("workProfileDefaultAppPermissionPolicy", value); }
        }
        /// <summary>Indicates whether or not to block face unlock for work profile.</summary>
        public bool? WorkProfilePasswordBlockFaceUnlock
        {
            get { return BackingStore?.Get<bool?>("workProfilePasswordBlockFaceUnlock"); }
            set { BackingStore?.Set("workProfilePasswordBlockFaceUnlock", value); }
        }
        /// <summary>Indicates whether or not to block fingerprint unlock for work profile.</summary>
        public bool? WorkProfilePasswordBlockFingerprintUnlock
        {
            get { return BackingStore?.Get<bool?>("workProfilePasswordBlockFingerprintUnlock"); }
            set { BackingStore?.Set("workProfilePasswordBlockFingerprintUnlock", value); }
        }
        /// <summary>Indicates whether or not to block iris unlock for work profile.</summary>
        public bool? WorkProfilePasswordBlockIrisUnlock
        {
            get { return BackingStore?.Get<bool?>("workProfilePasswordBlockIrisUnlock"); }
            set { BackingStore?.Set("workProfilePasswordBlockIrisUnlock", value); }
        }
        /// <summary>Indicates whether or not to block Smart Lock and other trust agents for work profile.</summary>
        public bool? WorkProfilePasswordBlockTrustAgents
        {
            get { return BackingStore?.Get<bool?>("workProfilePasswordBlockTrustAgents"); }
            set { BackingStore?.Set("workProfilePasswordBlockTrustAgents", value); }
        }
        /// <summary>Number of days before the work profile password expires. Valid values 1 to 365</summary>
        public int? WorkProfilePasswordExpirationDays
        {
            get { return BackingStore?.Get<int?>("workProfilePasswordExpirationDays"); }
            set { BackingStore?.Set("workProfilePasswordExpirationDays", value); }
        }
        /// <summary>Minimum length of work profile password. Valid values 4 to 16</summary>
        public int? WorkProfilePasswordMinimumLength
        {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinimumLength"); }
            set { BackingStore?.Set("workProfilePasswordMinimumLength", value); }
        }
        /// <summary>Minimum # of letter characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinLetterCharacters
        {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinLetterCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinLetterCharacters", value); }
        }
        /// <summary>Minimum # of lower-case characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinLowerCaseCharacters
        {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinLowerCaseCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinLowerCaseCharacters", value); }
        }
        /// <summary>Minimum # of non-letter characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinNonLetterCharacters
        {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinNonLetterCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinNonLetterCharacters", value); }
        }
        /// <summary>Minimum # of numeric characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinNumericCharacters
        {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinNumericCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinNumericCharacters", value); }
        }
        /// <summary>Minimum # of symbols required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinSymbolCharacters
        {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinSymbolCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinSymbolCharacters", value); }
        }
        /// <summary>Minimum # of upper-case characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinUpperCaseCharacters
        {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinUpperCaseCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinUpperCaseCharacters", value); }
        }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout
        {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinutesOfInactivityBeforeScreenTimeout"); }
            set { BackingStore?.Set("workProfilePasswordMinutesOfInactivityBeforeScreenTimeout", value); }
        }
        /// <summary>Number of previous work profile passwords to block. Valid values 0 to 24</summary>
        public int? WorkProfilePasswordPreviousPasswordBlockCount
        {
            get { return BackingStore?.Get<int?>("workProfilePasswordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("workProfilePasswordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Android For Work required password type.</summary>
        public global::Microsoft.Graph.Beta.Models.AndroidForWorkRequiredPasswordType? WorkProfilePasswordRequiredType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidForWorkRequiredPasswordType?>("workProfilePasswordRequiredType"); }
            set { BackingStore?.Set("workProfilePasswordRequiredType", value); }
        }
        /// <summary>Number of sign in failures allowed before work profile is removed and all corporate data deleted. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordSignInFailureCountBeforeFactoryReset
        {
            get { return BackingStore?.Get<int?>("workProfilePasswordSignInFailureCountBeforeFactoryReset"); }
            set { BackingStore?.Set("workProfilePasswordSignInFailureCountBeforeFactoryReset", value); }
        }
        /// <summary>The password complexity types that can be set on Android. One of: NONE, LOW, MEDIUM, HIGH. This is an API targeted to Android 11+.</summary>
        public global::Microsoft.Graph.Beta.Models.AndroidRequiredPasswordComplexity? WorkProfileRequiredPasswordComplexity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AndroidRequiredPasswordComplexity?>("workProfileRequiredPasswordComplexity"); }
            set { BackingStore?.Set("workProfileRequiredPasswordComplexity", value); }
        }
        /// <summary>Password is required or not for work profile</summary>
        public bool? WorkProfileRequirePassword
        {
            get { return BackingStore?.Get<bool?>("workProfileRequirePassword"); }
            set { BackingStore?.Set("workProfileRequirePassword", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AndroidForWorkGeneralDeviceConfiguration"/> and sets the default values.
        /// </summary>
        public AndroidForWorkGeneralDeviceConfiguration() : base()
        {
            OdataType = "#microsoft.graph.androidForWorkGeneralDeviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AndroidForWorkGeneralDeviceConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AndroidForWorkGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AndroidForWorkGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowedGoogleAccountDomains", n => { AllowedGoogleAccountDomains = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "blockUnifiedPasswordForWorkProfile", n => { BlockUnifiedPasswordForWorkProfile = n.GetBoolValue(); } },
                { "passwordBlockFaceUnlock", n => { PasswordBlockFaceUnlock = n.GetBoolValue(); } },
                { "passwordBlockFingerprintUnlock", n => { PasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                { "passwordBlockIrisUnlock", n => { PasswordBlockIrisUnlock = n.GetBoolValue(); } },
                { "passwordBlockTrustAgents", n => { PasswordBlockTrustAgents = n.GetBoolValue(); } },
                { "passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                { "passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                { "passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                { "passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                { "passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkRequiredPasswordType>(); } },
                { "passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                { "requiredPasswordComplexity", n => { RequiredPasswordComplexity = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AndroidRequiredPasswordComplexity>(); } },
                { "securityRequireVerifyApps", n => { SecurityRequireVerifyApps = n.GetBoolValue(); } },
                { "vpnAlwaysOnPackageIdentifier", n => { VpnAlwaysOnPackageIdentifier = n.GetStringValue(); } },
                { "vpnEnableAlwaysOnLockdownMode", n => { VpnEnableAlwaysOnLockdownMode = n.GetBoolValue(); } },
                { "workProfileAccountUse", n => { WorkProfileAccountUse = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AndroidWorkProfileAccountUse>(); } },
                { "workProfileAllowWidgets", n => { WorkProfileAllowWidgets = n.GetBoolValue(); } },
                { "workProfileBlockAddingAccounts", n => { WorkProfileBlockAddingAccounts = n.GetBoolValue(); } },
                { "workProfileBlockCamera", n => { WorkProfileBlockCamera = n.GetBoolValue(); } },
                { "workProfileBlockCrossProfileCallerId", n => { WorkProfileBlockCrossProfileCallerId = n.GetBoolValue(); } },
                { "workProfileBlockCrossProfileContactsSearch", n => { WorkProfileBlockCrossProfileContactsSearch = n.GetBoolValue(); } },
                { "workProfileBlockCrossProfileCopyPaste", n => { WorkProfileBlockCrossProfileCopyPaste = n.GetBoolValue(); } },
                { "workProfileBlockNotificationsWhileDeviceLocked", n => { WorkProfileBlockNotificationsWhileDeviceLocked = n.GetBoolValue(); } },
                { "workProfileBlockPersonalAppInstallsFromUnknownSources", n => { WorkProfileBlockPersonalAppInstallsFromUnknownSources = n.GetBoolValue(); } },
                { "workProfileBlockScreenCapture", n => { WorkProfileBlockScreenCapture = n.GetBoolValue(); } },
                { "workProfileBluetoothEnableContactSharing", n => { WorkProfileBluetoothEnableContactSharing = n.GetBoolValue(); } },
                { "workProfileDataSharingType", n => { WorkProfileDataSharingType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkCrossProfileDataSharingType>(); } },
                { "workProfileDefaultAppPermissionPolicy", n => { WorkProfileDefaultAppPermissionPolicy = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkDefaultAppPermissionPolicyType>(); } },
                { "workProfilePasswordBlockFaceUnlock", n => { WorkProfilePasswordBlockFaceUnlock = n.GetBoolValue(); } },
                { "workProfilePasswordBlockFingerprintUnlock", n => { WorkProfilePasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                { "workProfilePasswordBlockIrisUnlock", n => { WorkProfilePasswordBlockIrisUnlock = n.GetBoolValue(); } },
                { "workProfilePasswordBlockTrustAgents", n => { WorkProfilePasswordBlockTrustAgents = n.GetBoolValue(); } },
                { "workProfilePasswordExpirationDays", n => { WorkProfilePasswordExpirationDays = n.GetIntValue(); } },
                { "workProfilePasswordMinLetterCharacters", n => { WorkProfilePasswordMinLetterCharacters = n.GetIntValue(); } },
                { "workProfilePasswordMinLowerCaseCharacters", n => { WorkProfilePasswordMinLowerCaseCharacters = n.GetIntValue(); } },
                { "workProfilePasswordMinNonLetterCharacters", n => { WorkProfilePasswordMinNonLetterCharacters = n.GetIntValue(); } },
                { "workProfilePasswordMinNumericCharacters", n => { WorkProfilePasswordMinNumericCharacters = n.GetIntValue(); } },
                { "workProfilePasswordMinSymbolCharacters", n => { WorkProfilePasswordMinSymbolCharacters = n.GetIntValue(); } },
                { "workProfilePasswordMinUpperCaseCharacters", n => { WorkProfilePasswordMinUpperCaseCharacters = n.GetIntValue(); } },
                { "workProfilePasswordMinimumLength", n => { WorkProfilePasswordMinimumLength = n.GetIntValue(); } },
                { "workProfilePasswordMinutesOfInactivityBeforeScreenTimeout", n => { WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                { "workProfilePasswordPreviousPasswordBlockCount", n => { WorkProfilePasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                { "workProfilePasswordRequiredType", n => { WorkProfilePasswordRequiredType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkRequiredPasswordType>(); } },
                { "workProfilePasswordSignInFailureCountBeforeFactoryReset", n => { WorkProfilePasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                { "workProfileRequirePassword", n => { WorkProfileRequirePassword = n.GetBoolValue(); } },
                { "workProfileRequiredPasswordComplexity", n => { WorkProfileRequiredPasswordComplexity = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AndroidRequiredPasswordComplexity>(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("allowedGoogleAccountDomains", AllowedGoogleAccountDomains);
            writer.WriteBoolValue("blockUnifiedPasswordForWorkProfile", BlockUnifiedPasswordForWorkProfile);
            writer.WriteBoolValue("passwordBlockFaceUnlock", PasswordBlockFaceUnlock);
            writer.WriteBoolValue("passwordBlockFingerprintUnlock", PasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("passwordBlockIrisUnlock", PasswordBlockIrisUnlock);
            writer.WriteBoolValue("passwordBlockTrustAgents", PasswordBlockTrustAgents);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AndroidRequiredPasswordComplexity>("requiredPasswordComplexity", RequiredPasswordComplexity);
            writer.WriteBoolValue("securityRequireVerifyApps", SecurityRequireVerifyApps);
            writer.WriteStringValue("vpnAlwaysOnPackageIdentifier", VpnAlwaysOnPackageIdentifier);
            writer.WriteBoolValue("vpnEnableAlwaysOnLockdownMode", VpnEnableAlwaysOnLockdownMode);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AndroidWorkProfileAccountUse>("workProfileAccountUse", WorkProfileAccountUse);
            writer.WriteBoolValue("workProfileAllowWidgets", WorkProfileAllowWidgets);
            writer.WriteBoolValue("workProfileBlockAddingAccounts", WorkProfileBlockAddingAccounts);
            writer.WriteBoolValue("workProfileBlockCamera", WorkProfileBlockCamera);
            writer.WriteBoolValue("workProfileBlockCrossProfileCallerId", WorkProfileBlockCrossProfileCallerId);
            writer.WriteBoolValue("workProfileBlockCrossProfileContactsSearch", WorkProfileBlockCrossProfileContactsSearch);
            writer.WriteBoolValue("workProfileBlockCrossProfileCopyPaste", WorkProfileBlockCrossProfileCopyPaste);
            writer.WriteBoolValue("workProfileBlockNotificationsWhileDeviceLocked", WorkProfileBlockNotificationsWhileDeviceLocked);
            writer.WriteBoolValue("workProfileBlockPersonalAppInstallsFromUnknownSources", WorkProfileBlockPersonalAppInstallsFromUnknownSources);
            writer.WriteBoolValue("workProfileBlockScreenCapture", WorkProfileBlockScreenCapture);
            writer.WriteBoolValue("workProfileBluetoothEnableContactSharing", WorkProfileBluetoothEnableContactSharing);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkCrossProfileDataSharingType>("workProfileDataSharingType", WorkProfileDataSharingType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkDefaultAppPermissionPolicyType>("workProfileDefaultAppPermissionPolicy", WorkProfileDefaultAppPermissionPolicy);
            writer.WriteBoolValue("workProfilePasswordBlockFaceUnlock", WorkProfilePasswordBlockFaceUnlock);
            writer.WriteBoolValue("workProfilePasswordBlockFingerprintUnlock", WorkProfilePasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("workProfilePasswordBlockIrisUnlock", WorkProfilePasswordBlockIrisUnlock);
            writer.WriteBoolValue("workProfilePasswordBlockTrustAgents", WorkProfilePasswordBlockTrustAgents);
            writer.WriteIntValue("workProfilePasswordExpirationDays", WorkProfilePasswordExpirationDays);
            writer.WriteIntValue("workProfilePasswordMinimumLength", WorkProfilePasswordMinimumLength);
            writer.WriteIntValue("workProfilePasswordMinLetterCharacters", WorkProfilePasswordMinLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinLowerCaseCharacters", WorkProfilePasswordMinLowerCaseCharacters);
            writer.WriteIntValue("workProfilePasswordMinNonLetterCharacters", WorkProfilePasswordMinNonLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinNumericCharacters", WorkProfilePasswordMinNumericCharacters);
            writer.WriteIntValue("workProfilePasswordMinSymbolCharacters", WorkProfilePasswordMinSymbolCharacters);
            writer.WriteIntValue("workProfilePasswordMinUpperCaseCharacters", WorkProfilePasswordMinUpperCaseCharacters);
            writer.WriteIntValue("workProfilePasswordMinutesOfInactivityBeforeScreenTimeout", WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("workProfilePasswordPreviousPasswordBlockCount", WorkProfilePasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AndroidForWorkRequiredPasswordType>("workProfilePasswordRequiredType", WorkProfilePasswordRequiredType);
            writer.WriteIntValue("workProfilePasswordSignInFailureCountBeforeFactoryReset", WorkProfilePasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AndroidRequiredPasswordComplexity>("workProfileRequiredPasswordComplexity", WorkProfileRequiredPasswordComplexity);
            writer.WriteBoolValue("workProfileRequirePassword", WorkProfileRequirePassword);
        }
    }
}
#pragma warning restore CS0618
