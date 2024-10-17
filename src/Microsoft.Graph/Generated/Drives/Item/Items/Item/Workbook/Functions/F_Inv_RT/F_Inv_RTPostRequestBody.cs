// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.F_Inv_RT
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class F_Inv_RTPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The degFreedom1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? DegFreedom1
        {
            get { return BackingStore?.Get<UntypedNode?>("degFreedom1"); }
            set { BackingStore?.Set("degFreedom1", value); }
        }
#nullable restore
#else
        public UntypedNode DegFreedom1
        {
            get { return BackingStore?.Get<UntypedNode>("degFreedom1"); }
            set { BackingStore?.Set("degFreedom1", value); }
        }
#endif
        /// <summary>The degFreedom2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? DegFreedom2
        {
            get { return BackingStore?.Get<UntypedNode?>("degFreedom2"); }
            set { BackingStore?.Set("degFreedom2", value); }
        }
#nullable restore
#else
        public UntypedNode DegFreedom2
        {
            get { return BackingStore?.Get<UntypedNode>("degFreedom2"); }
            set { BackingStore?.Set("degFreedom2", value); }
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
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.F_Inv_RT.F_Inv_RTPostRequestBody"/> and sets the default values.
        /// </summary>
        public F_Inv_RTPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.F_Inv_RT.F_Inv_RTPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.F_Inv_RT.F_Inv_RTPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.F_Inv_RT.F_Inv_RTPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "degFreedom1", n => { DegFreedom1 = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "degFreedom2", n => { DegFreedom2 = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<UntypedNode>("degFreedom1", DegFreedom1);
            writer.WriteObjectValue<UntypedNode>("degFreedom2", DegFreedom2);
            writer.WriteObjectValue<UntypedNode>("probability", Probability);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
