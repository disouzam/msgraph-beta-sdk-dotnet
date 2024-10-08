// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class IdentityContainer : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents potential issues within a customer&apos;s Microsoft Defender for Identity configuration that Microsoft Defender for Identity identified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.HealthIssue>? HealthIssues
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HealthIssue>?>("healthIssues"); }
            set { BackingStore?.Set("healthIssues", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.HealthIssue> HealthIssues
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HealthIssue>>("healthIssues"); }
            set { BackingStore?.Set("healthIssues", value); }
        }
#endif
        /// <summary>Represents a customer&apos;s Microsoft Defender for Identity sensors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.Sensor>? Sensors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.Sensor>?>("sensors"); }
            set { BackingStore?.Set("sensors", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.Sensor> Sensors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.Sensor>>("sensors"); }
            set { BackingStore?.Set("sensors", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.IdentityContainer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.IdentityContainer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.IdentityContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "healthIssues", n => { HealthIssues = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HealthIssue>(global::Microsoft.Graph.Beta.Models.Security.HealthIssue.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sensors", n => { Sensors = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.Sensor>(global::Microsoft.Graph.Beta.Models.Security.Sensor.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HealthIssue>("healthIssues", HealthIssues);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.Sensor>("sensors", Sensors);
        }
    }
}
#pragma warning restore CS0618
