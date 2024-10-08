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
    /// Delivery Optimization Max cache size percentage types.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DeliveryOptimizationMaxCacheSizePercentage : global::Microsoft.Graph.Beta.Models.DeliveryOptimizationMaxCacheSize, IParsable
    {
        /// <summary>Specifies the maximum cache size that Delivery Optimization can utilize, as a percentage of disk size (1-100). Valid values 1 to 100</summary>
        public int? MaximumCacheSizePercentage
        {
            get { return BackingStore?.Get<int?>("maximumCacheSizePercentage"); }
            set { BackingStore?.Set("maximumCacheSizePercentage", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeliveryOptimizationMaxCacheSizePercentage"/> and sets the default values.
        /// </summary>
        public DeliveryOptimizationMaxCacheSizePercentage() : base()
        {
            OdataType = "#microsoft.graph.deliveryOptimizationMaxCacheSizePercentage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeliveryOptimizationMaxCacheSizePercentage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeliveryOptimizationMaxCacheSizePercentage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeliveryOptimizationMaxCacheSizePercentage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "maximumCacheSizePercentage", n => { MaximumCacheSizePercentage = n.GetIntValue(); } },
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
            writer.WriteIntValue("maximumCacheSizePercentage", MaximumCacheSizePercentage);
        }
    }
}
#pragma warning restore CS0618
