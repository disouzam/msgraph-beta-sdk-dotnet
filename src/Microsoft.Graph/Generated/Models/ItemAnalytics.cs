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
    public partial class ItemAnalytics : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The allTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ItemActivityStat? AllTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemActivityStat?>("allTime"); }
            set { BackingStore?.Set("allTime", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ItemActivityStat AllTime
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemActivityStat>("allTime"); }
            set { BackingStore?.Set("allTime", value); }
        }
#endif
        /// <summary>The itemActivityStats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ItemActivityStat>? ItemActivityStats
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ItemActivityStat>?>("itemActivityStats"); }
            set { BackingStore?.Set("itemActivityStats", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ItemActivityStat> ItemActivityStats
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ItemActivityStat>>("itemActivityStats"); }
            set { BackingStore?.Set("itemActivityStats", value); }
        }
#endif
        /// <summary>The lastSevenDays property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ItemActivityStat? LastSevenDays
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemActivityStat?>("lastSevenDays"); }
            set { BackingStore?.Set("lastSevenDays", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ItemActivityStat LastSevenDays
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemActivityStat>("lastSevenDays"); }
            set { BackingStore?.Set("lastSevenDays", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ItemAnalytics"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ItemAnalytics CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ItemAnalytics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allTime", n => { AllTime = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ItemActivityStat>(global::Microsoft.Graph.Beta.Models.ItemActivityStat.CreateFromDiscriminatorValue); } },
                { "itemActivityStats", n => { ItemActivityStats = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ItemActivityStat>(global::Microsoft.Graph.Beta.Models.ItemActivityStat.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastSevenDays", n => { LastSevenDays = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ItemActivityStat>(global::Microsoft.Graph.Beta.Models.ItemActivityStat.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ItemActivityStat>("allTime", AllTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ItemActivityStat>("itemActivityStats", ItemActivityStats);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ItemActivityStat>("lastSevenDays", LastSevenDays);
        }
    }
}
#pragma warning restore CS0618
