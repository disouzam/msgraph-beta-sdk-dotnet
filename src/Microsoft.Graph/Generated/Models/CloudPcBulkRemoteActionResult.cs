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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CloudPcBulkRemoteActionResult : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>A list of all the Intune managed device IDs that completed the bulk action with a failure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? FailedDeviceIds
        {
            get { return BackingStore?.Get<List<string>?>("failedDeviceIds"); }
            set { BackingStore?.Set("failedDeviceIds", value); }
        }
#nullable restore
#else
        public List<string> FailedDeviceIds
        {
            get { return BackingStore?.Get<List<string>>("failedDeviceIds"); }
            set { BackingStore?.Set("failedDeviceIds", value); }
        }
#endif
        /// <summary>A list of all the Intune managed device IDs that were not found when the bulk action was attempted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? NotFoundDeviceIds
        {
            get { return BackingStore?.Get<List<string>?>("notFoundDeviceIds"); }
            set { BackingStore?.Set("notFoundDeviceIds", value); }
        }
#nullable restore
#else
        public List<string> NotFoundDeviceIds
        {
            get { return BackingStore?.Get<List<string>>("notFoundDeviceIds"); }
            set { BackingStore?.Set("notFoundDeviceIds", value); }
        }
#endif
        /// <summary>A list of all the Intune managed device IDs that were identified as unsupported for the bulk action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? NotSupportedDeviceIds
        {
            get { return BackingStore?.Get<List<string>?>("notSupportedDeviceIds"); }
            set { BackingStore?.Set("notSupportedDeviceIds", value); }
        }
#nullable restore
#else
        public List<string> NotSupportedDeviceIds
        {
            get { return BackingStore?.Get<List<string>>("notSupportedDeviceIds"); }
            set { BackingStore?.Set("notSupportedDeviceIds", value); }
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
        /// <summary>A list of all the Intune managed device IDs that completed the bulk action successfully.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SuccessfulDeviceIds
        {
            get { return BackingStore?.Get<List<string>?>("successfulDeviceIds"); }
            set { BackingStore?.Set("successfulDeviceIds", value); }
        }
#nullable restore
#else
        public List<string> SuccessfulDeviceIds
        {
            get { return BackingStore?.Get<List<string>>("successfulDeviceIds"); }
            set { BackingStore?.Set("successfulDeviceIds", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CloudPcBulkRemoteActionResult"/> and sets the default values.
        /// </summary>
        public CloudPcBulkRemoteActionResult()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPcBulkRemoteActionResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.CloudPcBulkRemoteActionResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CloudPcBulkRemoteActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "failedDeviceIds", n => { FailedDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "notFoundDeviceIds", n => { NotFoundDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "notSupportedDeviceIds", n => { NotSupportedDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "successfulDeviceIds", n => { SuccessfulDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("failedDeviceIds", FailedDeviceIds);
            writer.WriteCollectionOfPrimitiveValues<string>("notFoundDeviceIds", NotFoundDeviceIds);
            writer.WriteCollectionOfPrimitiveValues<string>("notSupportedDeviceIds", NotSupportedDeviceIds);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("successfulDeviceIds", SuccessfulDeviceIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
