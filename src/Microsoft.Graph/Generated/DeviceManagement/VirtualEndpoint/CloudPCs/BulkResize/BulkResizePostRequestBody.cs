// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.BulkResize
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class BulkResizePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The cloudPcIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CloudPcIds
        {
            get { return BackingStore?.Get<List<string>?>("cloudPcIds"); }
            set { BackingStore?.Set("cloudPcIds", value); }
        }
#nullable restore
#else
        public List<string> CloudPcIds
        {
            get { return BackingStore?.Get<List<string>>("cloudPcIds"); }
            set { BackingStore?.Set("cloudPcIds", value); }
        }
#endif
        /// <summary>The targetServicePlanId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetServicePlanId
        {
            get { return BackingStore?.Get<string?>("targetServicePlanId"); }
            set { BackingStore?.Set("targetServicePlanId", value); }
        }
#nullable restore
#else
        public string TargetServicePlanId
        {
            get { return BackingStore?.Get<string>("targetServicePlanId"); }
            set { BackingStore?.Set("targetServicePlanId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.BulkResize.BulkResizePostRequestBody"/> and sets the default values.
        /// </summary>
        public BulkResizePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.BulkResize.BulkResizePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.BulkResize.BulkResizePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.BulkResize.BulkResizePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cloudPcIds", n => { CloudPcIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "targetServicePlanId", n => { TargetServicePlanId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("cloudPcIds", CloudPcIds);
            writer.WriteStringValue("targetServicePlanId", TargetServicePlanId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
