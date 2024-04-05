// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// String constraints
    /// </summary>
    public class DeviceManagementConfigurationStringSettingValueDefinition : DeviceManagementConfigurationSettingValueDefinition, IParsable 
    {
        /// <summary>Supported file types for this setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? FileTypes {
            get { return BackingStore?.Get<List<string>?>("fileTypes"); }
            set { BackingStore?.Set("fileTypes", value); }
        }
#nullable restore
#else
        public List<string> FileTypes {
            get { return BackingStore?.Get<List<string>>("fileTypes"); }
            set { BackingStore?.Set("fileTypes", value); }
        }
#endif
        /// <summary>Pre-defined format of the string. Possible values are: none, email, guid, ip, base64, url, version, xml, date, time, binary, regEx, json, dateTime, surfaceHub, bashScript, unknownFutureValue.</summary>
        public DeviceManagementConfigurationStringFormat? Format {
            get { return BackingStore?.Get<DeviceManagementConfigurationStringFormat?>("format"); }
            set { BackingStore?.Set("format", value); }
        }
        /// <summary>Regular expression or any xml or json schema that the input string should match</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InputValidationSchema {
            get { return BackingStore?.Get<string?>("inputValidationSchema"); }
            set { BackingStore?.Set("inputValidationSchema", value); }
        }
#nullable restore
#else
        public string InputValidationSchema {
            get { return BackingStore?.Get<string>("inputValidationSchema"); }
            set { BackingStore?.Set("inputValidationSchema", value); }
        }
#endif
        /// <summary>Specifies whether the setting needs to be treated as a secret. Settings marked as yes will be encrypted in transit and at rest and will be displayed as asterisks when represented in the UX.</summary>
        public bool? IsSecret {
            get { return BackingStore?.Get<bool?>("isSecret"); }
            set { BackingStore?.Set("isSecret", value); }
        }
        /// <summary>Maximum length of string. Valid values 0 to 87516</summary>
        public long? MaximumLength {
            get { return BackingStore?.Get<long?>("maximumLength"); }
            set { BackingStore?.Set("maximumLength", value); }
        }
        /// <summary>Minimum length of string. Valid values 0 to 87516</summary>
        public long? MinimumLength {
            get { return BackingStore?.Get<long?>("minimumLength"); }
            set { BackingStore?.Set("minimumLength", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="DeviceManagementConfigurationStringSettingValueDefinition"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationStringSettingValueDefinition() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationStringSettingValueDefinition";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementConfigurationStringSettingValueDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementConfigurationStringSettingValueDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationStringSettingValueDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"fileTypes", n => { FileTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"format", n => { Format = n.GetEnumValue<DeviceManagementConfigurationStringFormat>(); } },
                {"inputValidationSchema", n => { InputValidationSchema = n.GetStringValue(); } },
                {"isSecret", n => { IsSecret = n.GetBoolValue(); } },
                {"maximumLength", n => { MaximumLength = n.GetLongValue(); } },
                {"minimumLength", n => { MinimumLength = n.GetLongValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("fileTypes", FileTypes);
            writer.WriteEnumValue<DeviceManagementConfigurationStringFormat>("format", Format);
            writer.WriteStringValue("inputValidationSchema", InputValidationSchema);
            writer.WriteBoolValue("isSecret", IsSecret);
            writer.WriteLongValue("maximumLength", MaximumLength);
            writer.WriteLongValue("minimumLength", MinimumLength);
        }
    }
}
