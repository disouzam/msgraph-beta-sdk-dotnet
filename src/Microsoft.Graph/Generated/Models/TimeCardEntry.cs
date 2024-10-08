// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class TimeCardEntry : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The list of breaks associated with the timeCard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.TimeCardBreak>? Breaks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.TimeCardBreak>?>("breaks"); }
            set { BackingStore?.Set("breaks", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.TimeCardBreak> Breaks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.TimeCardBreak>>("breaks"); }
            set { BackingStore?.Set("breaks", value); }
        }
#endif
        /// <summary>The clock-in event of the timeCard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TimeCardEvent? ClockInEvent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeCardEvent?>("clockInEvent"); }
            set { BackingStore?.Set("clockInEvent", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TimeCardEvent ClockInEvent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeCardEvent>("clockInEvent"); }
            set { BackingStore?.Set("clockInEvent", value); }
        }
#endif
        /// <summary>The clock-out event of the timeCard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TimeCardEvent? ClockOutEvent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeCardEvent?>("clockOutEvent"); }
            set { BackingStore?.Set("clockOutEvent", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TimeCardEvent ClockOutEvent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TimeCardEvent>("clockOutEvent"); }
            set { BackingStore?.Set("clockOutEvent", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.TimeCardEntry"/> and sets the default values.
        /// </summary>
        public TimeCardEntry()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TimeCardEntry"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.TimeCardEntry CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.TimeCardEntry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "breaks", n => { Breaks = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.TimeCardBreak>(global::Microsoft.Graph.Beta.Models.TimeCardBreak.CreateFromDiscriminatorValue)?.AsList(); } },
                { "clockInEvent", n => { ClockInEvent = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TimeCardEvent>(global::Microsoft.Graph.Beta.Models.TimeCardEvent.CreateFromDiscriminatorValue); } },
                { "clockOutEvent", n => { ClockOutEvent = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TimeCardEvent>(global::Microsoft.Graph.Beta.Models.TimeCardEvent.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.TimeCardBreak>("breaks", Breaks);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TimeCardEvent>("clockInEvent", ClockInEvent);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TimeCardEvent>("clockOutEvent", ClockOutEvent);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
