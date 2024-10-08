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
    /// The status of a long-running operation.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class AttackSimulationOperation : global::Microsoft.Graph.Beta.Models.LongRunningOperation, IParsable
    {
        /// <summary>Percentage of completion of the respective operation.</summary>
        public int? PercentageCompleted
        {
            get { return BackingStore?.Get<int?>("percentageCompleted"); }
            set { BackingStore?.Set("percentageCompleted", value); }
        }
        /// <summary>Tenant identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId
        {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId
        {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The attack simulation operation type. Possible values are: createSimulation, updateSimulation, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.AttackSimulationOperationType? Type
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AttackSimulationOperationType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AttackSimulationOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AttackSimulationOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AttackSimulationOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "percentageCompleted", n => { PercentageCompleted = n.GetIntValue(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AttackSimulationOperationType>(); } },
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
            writer.WriteIntValue("percentageCompleted", PercentageCompleted);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AttackSimulationOperationType>("type", Type);
        }
    }
}
#pragma warning restore CS0618
