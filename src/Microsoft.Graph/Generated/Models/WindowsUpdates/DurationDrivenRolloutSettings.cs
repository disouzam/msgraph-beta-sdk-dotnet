// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class DurationDrivenRolloutSettings : global::Microsoft.Graph.Beta.Models.WindowsUpdates.GradualRolloutSettings, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The target duration of the rollout. Given durationBetweenOffers and durationUntilDeploymentEnd, the system will automatically calculate how many devices are in each offering.</summary>
        public TimeSpan? DurationUntilDeploymentEnd
        {
            get { return BackingStore?.Get<TimeSpan?>("durationUntilDeploymentEnd"); }
            set { BackingStore?.Set("durationUntilDeploymentEnd", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.DurationDrivenRolloutSettings"/> and sets the default values.
        /// </summary>
        public DurationDrivenRolloutSettings() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdates.durationDrivenRolloutSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.DurationDrivenRolloutSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WindowsUpdates.DurationDrivenRolloutSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsUpdates.DurationDrivenRolloutSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "durationUntilDeploymentEnd", n => { DurationUntilDeploymentEnd = n.GetTimeSpanValue(); } },
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
            writer.WriteTimeSpanValue("durationUntilDeploymentEnd", DurationUntilDeploymentEnd);
        }
    }
}
#pragma warning restore CS0618
