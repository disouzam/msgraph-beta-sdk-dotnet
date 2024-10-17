// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Me.TranslateExchangeIds
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TranslateExchangeIdsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The InputIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? InputIds
        {
            get { return BackingStore?.Get<List<string>?>("InputIds"); }
            set { BackingStore?.Set("InputIds", value); }
        }
#nullable restore
#else
        public List<string> InputIds
        {
            get { return BackingStore?.Get<List<string>>("InputIds"); }
            set { BackingStore?.Set("InputIds", value); }
        }
#endif
        /// <summary>The SourceIdType property</summary>
        public global::Microsoft.Graph.Beta.Models.ExchangeIdFormat? SourceIdType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ExchangeIdFormat?>("SourceIdType"); }
            set { BackingStore?.Set("SourceIdType", value); }
        }
        /// <summary>The TargetIdType property</summary>
        public global::Microsoft.Graph.Beta.Models.ExchangeIdFormat? TargetIdType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ExchangeIdFormat?>("TargetIdType"); }
            set { BackingStore?.Set("TargetIdType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Me.TranslateExchangeIds.TranslateExchangeIdsPostRequestBody"/> and sets the default values.
        /// </summary>
        public TranslateExchangeIdsPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Me.TranslateExchangeIds.TranslateExchangeIdsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Me.TranslateExchangeIds.TranslateExchangeIdsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Me.TranslateExchangeIds.TranslateExchangeIdsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "InputIds", n => { InputIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "SourceIdType", n => { SourceIdType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ExchangeIdFormat>(); } },
                { "TargetIdType", n => { TargetIdType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ExchangeIdFormat>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("InputIds", InputIds);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ExchangeIdFormat>("SourceIdType", SourceIdType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ExchangeIdFormat>("TargetIdType", TargetIdType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
