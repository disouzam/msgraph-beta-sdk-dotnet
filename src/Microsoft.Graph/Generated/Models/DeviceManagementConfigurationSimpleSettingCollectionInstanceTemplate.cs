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
    /// Simple Setting Collection Instance Template
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate : global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplate, IParsable
    {
        /// <summary>Linked policy may append values which are not present in the template.</summary>
        public bool? AllowUnmanagedValues
        {
            get { return BackingStore?.Get<bool?>("allowUnmanagedValues"); }
            set { BackingStore?.Set("allowUnmanagedValues", value); }
        }
        /// <summary>Simple Setting Collection Value Template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingValueTemplate>? SimpleSettingCollectionValueTemplate
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingValueTemplate>?>("simpleSettingCollectionValueTemplate"); }
            set { BackingStore?.Set("simpleSettingCollectionValueTemplate", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingValueTemplate> SimpleSettingCollectionValueTemplate
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingValueTemplate>>("simpleSettingCollectionValueTemplate"); }
            set { BackingStore?.Set("simpleSettingCollectionValueTemplate", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionInstanceTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingCollectionInstanceTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowUnmanagedValues", n => { AllowUnmanagedValues = n.GetBoolValue(); } },
                { "simpleSettingCollectionValueTemplate", n => { SimpleSettingCollectionValueTemplate = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingValueTemplate>(global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingValueTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteBoolValue("allowUnmanagedValues", AllowUnmanagedValues);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingValueTemplate>("simpleSettingCollectionValueTemplate", SimpleSettingCollectionValueTemplate);
        }
    }
}
#pragma warning restore CS0618
