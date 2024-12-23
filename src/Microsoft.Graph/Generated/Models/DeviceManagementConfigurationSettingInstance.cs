// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Setting instance within policy
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementConfigurationSettingInstance : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Setting Definition Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SettingDefinitionId
        {
            get { return BackingStore?.Get<string?>("settingDefinitionId"); }
            set { BackingStore?.Set("settingDefinitionId", value); }
        }
#nullable restore
#else
        public string SettingDefinitionId
        {
            get { return BackingStore?.Get<string>("settingDefinitionId"); }
            set { BackingStore?.Set("settingDefinitionId", value); }
        }
#endif
        /// <summary>Setting Instance Template Reference</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplateReference? SettingInstanceTemplateReference
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplateReference?>("settingInstanceTemplateReference"); }
            set { BackingStore?.Set("settingInstanceTemplateReference", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplateReference SettingInstanceTemplateReference
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplateReference>("settingInstanceTemplateReference"); }
            set { BackingStore?.Set("settingInstanceTemplateReference", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstance"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingInstance()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingCollectionInstance" => new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingCollectionInstance(),
                "#microsoft.graph.deviceManagementConfigurationChoiceSettingInstance" => new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingInstance(),
                "#microsoft.graph.deviceManagementConfigurationGroupSettingCollectionInstance" => new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingCollectionInstance(),
                "#microsoft.graph.deviceManagementConfigurationGroupSettingInstance" => new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationGroupSettingInstance(),
                "#microsoft.graph.deviceManagementConfigurationSettingGroupCollectionInstance" => new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingGroupCollectionInstance(),
                "#microsoft.graph.deviceManagementConfigurationSettingGroupInstance" => new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingGroupInstance(),
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingCollectionInstance" => new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingCollectionInstance(),
                "#microsoft.graph.deviceManagementConfigurationSimpleSettingInstance" => new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingInstance(),
                _ => new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstance(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "settingDefinitionId", n => { SettingDefinitionId = n.GetStringValue(); } },
                { "settingInstanceTemplateReference", n => { SettingInstanceTemplateReference = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplateReference>(global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplateReference.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("settingDefinitionId", SettingDefinitionId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstanceTemplateReference>("settingInstanceTemplateReference", SettingInstanceTemplateReference);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
