// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Beta_Inv
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class Beta_InvPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The A property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? A
        {
            get { return BackingStore?.Get<UntypedNode?>("A"); }
            set { BackingStore?.Set("A", value); }
        }
#nullable restore
#else
        public UntypedNode A
        {
            get { return BackingStore?.Get<UntypedNode>("A"); }
            set { BackingStore?.Set("A", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The alpha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Alpha
        {
            get { return BackingStore?.Get<UntypedNode?>("alpha"); }
            set { BackingStore?.Set("alpha", value); }
        }
#nullable restore
#else
        public UntypedNode Alpha
        {
            get { return BackingStore?.Get<UntypedNode>("alpha"); }
            set { BackingStore?.Set("alpha", value); }
        }
#endif
        /// <summary>The B property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? B
        {
            get { return BackingStore?.Get<UntypedNode?>("B"); }
            set { BackingStore?.Set("B", value); }
        }
#nullable restore
#else
        public UntypedNode B
        {
            get { return BackingStore?.Get<UntypedNode>("B"); }
            set { BackingStore?.Set("B", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The beta property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Beta
        {
            get { return BackingStore?.Get<UntypedNode?>("beta"); }
            set { BackingStore?.Set("beta", value); }
        }
#nullable restore
#else
        public UntypedNode Beta
        {
            get { return BackingStore?.Get<UntypedNode>("beta"); }
            set { BackingStore?.Set("beta", value); }
        }
#endif
        /// <summary>The probability property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Probability
        {
            get { return BackingStore?.Get<UntypedNode?>("probability"); }
            set { BackingStore?.Set("probability", value); }
        }
#nullable restore
#else
        public UntypedNode Probability
        {
            get { return BackingStore?.Get<UntypedNode>("probability"); }
            set { BackingStore?.Set("probability", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Beta_Inv.Beta_InvPostRequestBody"/> and sets the default values.
        /// </summary>
        public Beta_InvPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Beta_Inv.Beta_InvPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Beta_Inv.Beta_InvPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.Beta_Inv.Beta_InvPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "A", n => { A = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "alpha", n => { Alpha = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "B", n => { B = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "beta", n => { Beta = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "probability", n => { Probability = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("A", A);
            writer.WriteObjectValue<UntypedNode>("alpha", Alpha);
            writer.WriteObjectValue<UntypedNode>("B", B);
            writer.WriteObjectValue<UntypedNode>("beta", Beta);
            writer.WriteObjectValue<UntypedNode>("probability", Probability);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
