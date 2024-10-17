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
    public partial class WorkplaceSensor : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The display name of the sensor. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
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
        /// <summary>The unique identifier of the place that the sensor detects. If the device is installed in a room equipped with a mailbox, this property should match the ExternalDirectoryObjectId or Microsoft Entra object ID of the room mailbox. If the sensor detects the same place as the location of the device, the property can be omitted. The default value is the place identifier of the device. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlaceId
        {
            get { return BackingStore?.Get<string?>("placeId"); }
            set { BackingStore?.Set("placeId", value); }
        }
#nullable restore
#else
        public string PlaceId
        {
            get { return BackingStore?.Get<string>("placeId"); }
            set { BackingStore?.Set("placeId", value); }
        }
#endif
        /// <summary>The user-defined unique identifier of the sensor on the device. If the device has multiple sensors of the same type, the property must be provided to identify each sensor. If the device has only one sensor of a type, the property can be omitted. The default value is the sensor type. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SensorId
        {
            get { return BackingStore?.Get<string?>("sensorId"); }
            set { BackingStore?.Set("sensorId", value); }
        }
#nullable restore
#else
        public string SensorId
        {
            get { return BackingStore?.Get<string>("sensorId"); }
            set { BackingStore?.Set("sensorId", value); }
        }
#endif
        /// <summary>The sensorType property</summary>
        public global::Microsoft.Graph.Beta.Models.WorkplaceSensorType? SensorType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkplaceSensorType?>("sensorType"); }
            set { BackingStore?.Set("sensorType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WorkplaceSensor"/> and sets the default values.
        /// </summary>
        public WorkplaceSensor()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WorkplaceSensor"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.WorkplaceSensor CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WorkplaceSensor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "placeId", n => { PlaceId = n.GetStringValue(); } },
                { "sensorId", n => { SensorId = n.GetStringValue(); } },
                { "sensorType", n => { SensorType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.WorkplaceSensorType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("placeId", PlaceId);
            writer.WriteStringValue("sensorId", SensorId);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.WorkplaceSensorType>("sensorType", SensorType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
