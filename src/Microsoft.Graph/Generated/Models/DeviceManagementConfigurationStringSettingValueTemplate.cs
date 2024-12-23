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
    /// String Setting Value Template
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementConfigurationStringSettingValueTemplate : global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingValueTemplate, IParsable
    {
        /// <summary>String Setting Value Default Template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationStringSettingValueDefaultTemplate? DefaultValue
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationStringSettingValueDefaultTemplate?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationStringSettingValueDefaultTemplate DefaultValue
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationStringSettingValueDefaultTemplate>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationStringSettingValueTemplate"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationStringSettingValueTemplate() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationStringSettingValueTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationStringSettingValueTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationStringSettingValueTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationStringSettingValueTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "defaultValue", n => { DefaultValue = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationStringSettingValueDefaultTemplate>(global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationStringSettingValueDefaultTemplate.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationStringSettingValueDefaultTemplate>("defaultValue", DefaultValue);
        }
    }
}
#pragma warning restore CS0618
