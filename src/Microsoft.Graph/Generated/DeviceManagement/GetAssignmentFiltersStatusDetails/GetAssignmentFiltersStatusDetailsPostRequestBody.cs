// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.GetAssignmentFiltersStatusDetails
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class GetAssignmentFiltersStatusDetailsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The assignmentFilterIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AssignmentFilterIds
        {
            get { return BackingStore?.Get<List<string>?>("assignmentFilterIds"); }
            set { BackingStore?.Set("assignmentFilterIds", value); }
        }
#nullable restore
#else
        public List<string> AssignmentFilterIds
        {
            get { return BackingStore?.Get<List<string>>("assignmentFilterIds"); }
            set { BackingStore?.Set("assignmentFilterIds", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The managedDeviceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId
        {
            get { return BackingStore?.Get<string?>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#nullable restore
#else
        public string ManagedDeviceId
        {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#endif
        /// <summary>The payloadId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PayloadId
        {
            get { return BackingStore?.Get<string?>("payloadId"); }
            set { BackingStore?.Set("payloadId", value); }
        }
#nullable restore
#else
        public string PayloadId
        {
            get { return BackingStore?.Get<string>("payloadId"); }
            set { BackingStore?.Set("payloadId", value); }
        }
#endif
        /// <summary>The skip property</summary>
        public int? Skip
        {
            get { return BackingStore?.Get<int?>("skip"); }
            set { BackingStore?.Set("skip", value); }
        }
        /// <summary>The top property</summary>
        public int? Top
        {
            get { return BackingStore?.Get<int?>("top"); }
            set { BackingStore?.Set("top", value); }
        }
        /// <summary>The userId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId
        {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId
        {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DeviceManagement.GetAssignmentFiltersStatusDetails.GetAssignmentFiltersStatusDetailsPostRequestBody"/> and sets the default values.
        /// </summary>
        public GetAssignmentFiltersStatusDetailsPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.GetAssignmentFiltersStatusDetails.GetAssignmentFiltersStatusDetailsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.DeviceManagement.GetAssignmentFiltersStatusDetails.GetAssignmentFiltersStatusDetailsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.DeviceManagement.GetAssignmentFiltersStatusDetails.GetAssignmentFiltersStatusDetailsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignmentFilterIds", n => { AssignmentFilterIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                { "payloadId", n => { PayloadId = n.GetStringValue(); } },
                { "skip", n => { Skip = n.GetIntValue(); } },
                { "top", n => { Top = n.GetIntValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("assignmentFilterIds", AssignmentFilterIds);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("payloadId", PayloadId);
            writer.WriteIntValue("skip", Skip);
            writer.WriteIntValue("top", Top);
            writer.WriteStringValue("userId", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
