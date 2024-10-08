// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.IndustryData;
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
    public partial class LongRunningOperation : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The start time of the operation. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The time of the last action in the operation. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastActionDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>URI of the resource that the operation is performed on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceLocation
        {
            get { return BackingStore?.Get<string?>("resourceLocation"); }
            set { BackingStore?.Set("resourceLocation", value); }
        }
#nullable restore
#else
        public string ResourceLocation
        {
            get { return BackingStore?.Get<string>("resourceLocation"); }
            set { BackingStore?.Set("resourceLocation", value); }
        }
#endif
        /// <summary>The status of the operation. The possible values are: notStarted, running, succeeded, failed, skipped, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.LongRunningOperationStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LongRunningOperationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Details about the status of the operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusDetail
        {
            get { return BackingStore?.Get<string?>("statusDetail"); }
            set { BackingStore?.Set("statusDetail", value); }
        }
#nullable restore
#else
        public string StatusDetail
        {
            get { return BackingStore?.Get<string>("statusDetail"); }
            set { BackingStore?.Set("statusDetail", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.LongRunningOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.LongRunningOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.attackSimulationOperation" => new global::Microsoft.Graph.Beta.Models.AttackSimulationOperation(),
                "#microsoft.graph.engagementAsyncOperation" => new global::Microsoft.Graph.Beta.Models.EngagementAsyncOperation(),
                "#microsoft.graph.goalsExportJob" => new global::Microsoft.Graph.Beta.Models.GoalsExportJob(),
                "#microsoft.graph.industryData.fileValidateOperation" => new global::Microsoft.Graph.Beta.Models.IndustryData.FileValidateOperation(),
                "#microsoft.graph.industryData.validateOperation" => new global::Microsoft.Graph.Beta.Models.IndustryData.ValidateOperation(),
                "#microsoft.graph.richLongRunningOperation" => new global::Microsoft.Graph.Beta.Models.RichLongRunningOperation(),
                _ => new global::Microsoft.Graph.Beta.Models.LongRunningOperation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                { "resourceLocation", n => { ResourceLocation = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.LongRunningOperationStatus>(); } },
                { "statusDetail", n => { StatusDetail = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("resourceLocation", ResourceLocation);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.LongRunningOperationStatus>("status", Status);
            writer.WriteStringValue("statusDetail", StatusDetail);
        }
    }
}
#pragma warning restore CS0618
