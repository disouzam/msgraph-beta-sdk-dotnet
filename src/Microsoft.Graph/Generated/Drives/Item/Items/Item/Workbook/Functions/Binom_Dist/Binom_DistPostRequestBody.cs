// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Binom_Dist
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Binom_DistPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The cumulative property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Cumulative
        {
            get { return BackingStore?.Get<UntypedNode?>("cumulative"); }
            set { BackingStore?.Set("cumulative", value); }
        }
#nullable restore
#else
        public UntypedNode Cumulative
        {
            get { return BackingStore?.Get<UntypedNode>("cumulative"); }
            set { BackingStore?.Set("cumulative", value); }
        }
#endif
        /// <summary>The numberS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? NumberS
        {
            get { return BackingStore?.Get<UntypedNode?>("numberS"); }
            set { BackingStore?.Set("numberS", value); }
        }
#nullable restore
#else
        public UntypedNode NumberS
        {
            get { return BackingStore?.Get<UntypedNode>("numberS"); }
            set { BackingStore?.Set("numberS", value); }
        }
#endif
        /// <summary>The probabilityS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ProbabilityS
        {
            get { return BackingStore?.Get<UntypedNode?>("probabilityS"); }
            set { BackingStore?.Set("probabilityS", value); }
        }
#nullable restore
#else
        public UntypedNode ProbabilityS
        {
            get { return BackingStore?.Get<UntypedNode>("probabilityS"); }
            set { BackingStore?.Set("probabilityS", value); }
        }
#endif
        /// <summary>The trials property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Trials
        {
            get { return BackingStore?.Get<UntypedNode?>("trials"); }
            set { BackingStore?.Set("trials", value); }
        }
#nullable restore
#else
        public UntypedNode Trials
        {
            get { return BackingStore?.Get<UntypedNode>("trials"); }
            set { BackingStore?.Set("trials", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Binom_Dist.Binom_DistPostRequestBody"/> and sets the default values.
        /// </summary>
        public Binom_DistPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Binom_Dist.Binom_DistPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Binom_Dist.Binom_DistPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Binom_Dist.Binom_DistPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cumulative", n => { Cumulative = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "numberS", n => { NumberS = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "probabilityS", n => { ProbabilityS = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "trials", n => { Trials = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("cumulative", Cumulative);
            writer.WriteObjectValue<UntypedNode>("numberS", NumberS);
            writer.WriteObjectValue<UntypedNode>("probabilityS", ProbabilityS);
            writer.WriteObjectValue<UntypedNode>("trials", Trials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
