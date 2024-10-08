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
    /// This class contains compliance settings for Windows 8.1.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class Windows81CompliancePolicy : global::Microsoft.Graph.Beta.Models.DeviceCompliancePolicy, IParsable
    {
        /// <summary>Maximum Windows 8.1 version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsMaximumVersion
        {
            get { return BackingStore?.Get<string?>("osMaximumVersion"); }
            set { BackingStore?.Set("osMaximumVersion", value); }
        }
#nullable restore
#else
        public string OsMaximumVersion
        {
            get { return BackingStore?.Get<string>("osMaximumVersion"); }
            set { BackingStore?.Set("osMaximumVersion", value); }
        }
#endif
        /// <summary>Minimum Windows 8.1 version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsMinimumVersion
        {
            get { return BackingStore?.Get<string?>("osMinimumVersion"); }
            set { BackingStore?.Set("osMinimumVersion", value); }
        }
#nullable restore
#else
        public string OsMinimumVersion
        {
            get { return BackingStore?.Get<string>("osMinimumVersion"); }
            set { BackingStore?.Set("osMinimumVersion", value); }
        }
#endif
        /// <summary>Indicates whether or not to block simple password.</summary>
        public bool? PasswordBlockSimple
        {
            get { return BackingStore?.Get<bool?>("passwordBlockSimple"); }
            set { BackingStore?.Set("passwordBlockSimple", value); }
        }
        /// <summary>Password expiration in days.</summary>
        public int? PasswordExpirationDays
        {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount
        {
            get { return BackingStore?.Get<int?>("passwordMinimumCharacterSetCount"); }
            set { BackingStore?.Set("passwordMinimumCharacterSetCount", value); }
        }
        /// <summary>The minimum password length.</summary>
        public int? PasswordMinimumLength
        {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock
        {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeLock"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeLock", value); }
        }
        /// <summary>The number of previous passwords to prevent re-use of. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount
        {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Require a password to unlock Windows device.</summary>
        public bool? PasswordRequired
        {
            get { return BackingStore?.Get<bool?>("passwordRequired"); }
            set { BackingStore?.Set("passwordRequired", value); }
        }
        /// <summary>Possible values of required passwords.</summary>
        public global::Microsoft.Graph.Beta.Models.RequiredPasswordType? PasswordRequiredType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.RequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>Indicates whether or not to require encryption on a windows 8.1 device.</summary>
        public bool? StorageRequireEncryption
        {
            get { return BackingStore?.Get<bool?>("storageRequireEncryption"); }
            set { BackingStore?.Set("storageRequireEncryption", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Windows81CompliancePolicy"/> and sets the default values.
        /// </summary>
        public Windows81CompliancePolicy() : base()
        {
            OdataType = "#microsoft.graph.windows81CompliancePolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Windows81CompliancePolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Windows81CompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Windows81CompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                { "osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                { "passwordBlockSimple", n => { PasswordBlockSimple = n.GetBoolValue(); } },
                { "passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                { "passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                { "passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                { "passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                { "passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                { "passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                { "passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.RequiredPasswordType>(); } },
                { "storageRequireEncryption", n => { StorageRequireEncryption = n.GetBoolValue(); } },
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
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteBoolValue("passwordBlockSimple", PasswordBlockSimple);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
        }
    }
}
#pragma warning restore CS0618
