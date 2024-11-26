// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DeviceManagementConfigurationSimpleSettingCollectionDefinition : global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingDefinition, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Maximum number of simple settings in the collection. Valid values 1 to 100</summary>
        public int? MaximumCount
        {
            get { return BackingStore?.Get<int?>("maximumCount"); }
            set { BackingStore?.Set("maximumCount", value); }
        }
        /// <summary>Minimum number of simple settings in the collection. Valid values 1 to 100</summary>
        public int? MinimumCount
        {
            get { return BackingStore?.Get<int?>("minimumCount"); }
            set { BackingStore?.Set("minimumCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingCollectionDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingCollectionDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingCollectionDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "maximumCount", n => { MaximumCount = n.GetIntValue(); } },
                { "minimumCount", n => { MinimumCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("maximumCount", MaximumCount);
            writer.WriteIntValue("minimumCount", MinimumCount);
        }
    }
}
#pragma warning restore CS0618
