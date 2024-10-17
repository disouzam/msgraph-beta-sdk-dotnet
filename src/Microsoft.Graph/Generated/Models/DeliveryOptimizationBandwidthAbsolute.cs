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
    /// Bandwidth limits in kilobytes per second.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeliveryOptimizationBandwidthAbsolute : global::Microsoft.Graph.Beta.Models.DeliveryOptimizationBandwidth, IParsable
    {
        /// <summary>Specifies the maximum download bandwidth in KiloBytes/second that the device can use across all concurrent download activities using Delivery Optimization. Valid values 0 to 4294967295</summary>
        public long? MaximumDownloadBandwidthInKilobytesPerSecond
        {
            get { return BackingStore?.Get<long?>("maximumDownloadBandwidthInKilobytesPerSecond"); }
            set { BackingStore?.Set("maximumDownloadBandwidthInKilobytesPerSecond", value); }
        }
        /// <summary>Specifies the maximum upload bandwidth in KiloBytes/second that a device will use across all concurrent upload activity using Delivery Optimization (0-4000000). Valid values 0 to 4000000</summary>
        public long? MaximumUploadBandwidthInKilobytesPerSecond
        {
            get { return BackingStore?.Get<long?>("maximumUploadBandwidthInKilobytesPerSecond"); }
            set { BackingStore?.Set("maximumUploadBandwidthInKilobytesPerSecond", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeliveryOptimizationBandwidthAbsolute"/> and sets the default values.
        /// </summary>
        public DeliveryOptimizationBandwidthAbsolute() : base()
        {
            OdataType = "#microsoft.graph.deliveryOptimizationBandwidthAbsolute";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeliveryOptimizationBandwidthAbsolute"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeliveryOptimizationBandwidthAbsolute CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeliveryOptimizationBandwidthAbsolute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "maximumDownloadBandwidthInKilobytesPerSecond", n => { MaximumDownloadBandwidthInKilobytesPerSecond = n.GetLongValue(); } },
                { "maximumUploadBandwidthInKilobytesPerSecond", n => { MaximumUploadBandwidthInKilobytesPerSecond = n.GetLongValue(); } },
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
            writer.WriteLongValue("maximumDownloadBandwidthInKilobytesPerSecond", MaximumDownloadBandwidthInKilobytesPerSecond);
            writer.WriteLongValue("maximumUploadBandwidthInKilobytesPerSecond", MaximumUploadBandwidthInKilobytesPerSecond);
        }
    }
}
#pragma warning restore CS0618
