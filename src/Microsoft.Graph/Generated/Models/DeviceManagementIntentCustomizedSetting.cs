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
    /// Default and customized value of a setting in a Security Baseline
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementIntentCustomizedSetting : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>JSON representation of the customized value, if different from default</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomizedJson
        {
            get { return BackingStore?.Get<string?>("customizedJson"); }
            set { BackingStore?.Set("customizedJson", value); }
        }
#nullable restore
#else
        public string CustomizedJson
        {
            get { return BackingStore?.Get<string>("customizedJson"); }
            set { BackingStore?.Set("customizedJson", value); }
        }
#endif
        /// <summary>JSON representation of the default value from the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultJson
        {
            get { return BackingStore?.Get<string?>("defaultJson"); }
            set { BackingStore?.Set("defaultJson", value); }
        }
#nullable restore
#else
        public string DefaultJson
        {
            get { return BackingStore?.Get<string>("defaultJson"); }
            set { BackingStore?.Set("defaultJson", value); }
        }
#endif
        /// <summary>The ID of the setting definition for this setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefinitionId
        {
            get { return BackingStore?.Get<string?>("definitionId"); }
            set { BackingStore?.Set("definitionId", value); }
        }
#nullable restore
#else
        public string DefinitionId
        {
            get { return BackingStore?.Get<string>("definitionId"); }
            set { BackingStore?.Set("definitionId", value); }
        }
#endif
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
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementIntentCustomizedSetting"/> and sets the default values.
        /// </summary>
        public DeviceManagementIntentCustomizedSetting()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementIntentCustomizedSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.DeviceManagementIntentCustomizedSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagementIntentCustomizedSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "customizedJson", n => { CustomizedJson = n.GetStringValue(); } },
                { "defaultJson", n => { DefaultJson = n.GetStringValue(); } },
                { "definitionId", n => { DefinitionId = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("customizedJson", CustomizedJson);
            writer.WriteStringValue("defaultJson", DefaultJson);
            writer.WriteStringValue("definitionId", DefinitionId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
