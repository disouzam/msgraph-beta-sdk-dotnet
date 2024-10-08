// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class IndustryDataRunStatistics : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The collection of statistics for each activity included in this run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataActivityStatistics>? ActivityStatistics
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataActivityStatistics>?>("activityStatistics"); }
            set { BackingStore?.Set("activityStatistics", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataActivityStatistics> ActivityStatistics
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataActivityStatistics>>("activityStatistics"); }
            set { BackingStore?.Set("activityStatistics", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The aggregate statistics for all inbound flows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IndustryData.AggregatedInboundStatistics? InboundTotals
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IndustryData.AggregatedInboundStatistics?>("inboundTotals"); }
            set { BackingStore?.Set("inboundTotals", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IndustryData.AggregatedInboundStatistics InboundTotals
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IndustryData.AggregatedInboundStatistics>("inboundTotals"); }
            set { BackingStore?.Set("inboundTotals", value); }
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
        /// <summary>The ID of the underlying run for the statistics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RunId
        {
            get { return BackingStore?.Get<string?>("runId"); }
            set { BackingStore?.Set("runId", value); }
        }
#nullable restore
#else
        public string RunId
        {
            get { return BackingStore?.Get<string>("runId"); }
            set { BackingStore?.Set("runId", value); }
        }
#endif
        /// <summary>The status property</summary>
        public global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunStatistics"/> and sets the default values.
        /// </summary>
        public IndustryDataRunStatistics()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunStatistics"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunStatistics CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunStatistics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activityStatistics", n => { ActivityStatistics = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataActivityStatistics>(global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataActivityStatistics.CreateFromDiscriminatorValue)?.AsList(); } },
                { "inboundTotals", n => { InboundTotals = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IndustryData.AggregatedInboundStatistics>(global::Microsoft.Graph.Beta.Models.IndustryData.AggregatedInboundStatistics.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "runId", n => { RunId = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunStatus>(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
