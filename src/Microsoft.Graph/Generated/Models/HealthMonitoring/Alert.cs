// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.HealthMonitoring
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class Alert : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The alertType property</summary>
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.AlertType? AlertType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.AlertType?>("alertType"); }
            set { BackingStore?.Set("alertType", value); }
        }
        /// <summary>The category property</summary>
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.Category? Category
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Category?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The documentation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.Documentation? Documentation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Documentation?>("documentation"); }
            set { BackingStore?.Set("documentation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.Documentation Documentation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Documentation>("documentation"); }
            set { BackingStore?.Set("documentation", value); }
        }
#endif
        /// <summary>The enrichment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.Enrichment? Enrichment
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Enrichment?>("enrichment"); }
            set { BackingStore?.Set("enrichment", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.Enrichment Enrichment
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Enrichment>("enrichment"); }
            set { BackingStore?.Set("enrichment", value); }
        }
#endif
        /// <summary>The scenario property</summary>
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.Scenario? Scenario
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Scenario?>("scenario"); }
            set { BackingStore?.Set("scenario", value); }
        }
        /// <summary>The signals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.Signals? Signals
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Signals?>("signals"); }
            set { BackingStore?.Set("signals", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.Signals Signals
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Signals>("signals"); }
            set { BackingStore?.Set("signals", value); }
        }
#endif
        /// <summary>The state property</summary>
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.AlertState? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.AlertState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.HealthMonitoring.Alert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.HealthMonitoring.Alert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.HealthMonitoring.Alert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alertType", n => { AlertType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.AlertType>(); } },
                { "category", n => { Category = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Category>(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "documentation", n => { Documentation = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Documentation>(global::Microsoft.Graph.Beta.Models.HealthMonitoring.Documentation.CreateFromDiscriminatorValue); } },
                { "enrichment", n => { Enrichment = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Enrichment>(global::Microsoft.Graph.Beta.Models.HealthMonitoring.Enrichment.CreateFromDiscriminatorValue); } },
                { "scenario", n => { Scenario = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Scenario>(); } },
                { "signals", n => { Signals = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Signals>(global::Microsoft.Graph.Beta.Models.HealthMonitoring.Signals.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.AlertState>(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.AlertType>("alertType", AlertType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Category>("category", Category);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Documentation>("documentation", Documentation);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Enrichment>("enrichment", Enrichment);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Scenario>("scenario", Scenario);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.Signals>("signals", Signals);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.AlertState>("state", State);
        }
    }
}
#pragma warning restore CS0618
