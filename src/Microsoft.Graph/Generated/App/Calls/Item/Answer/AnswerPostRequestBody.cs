// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.App.Calls.Item.Answer
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class AnswerPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The acceptedModalities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Modality?>? AcceptedModalities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Modality?>?>("acceptedModalities"); }
            set { BackingStore?.Set("acceptedModalities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Modality?> AcceptedModalities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Modality?>>("acceptedModalities"); }
            set { BackingStore?.Set("acceptedModalities", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The callbackUri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallbackUri
        {
            get { return BackingStore?.Get<string?>("callbackUri"); }
            set { BackingStore?.Set("callbackUri", value); }
        }
#nullable restore
#else
        public string CallbackUri
        {
            get { return BackingStore?.Get<string>("callbackUri"); }
            set { BackingStore?.Set("callbackUri", value); }
        }
#endif
        /// <summary>The callOptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IncomingCallOptions? CallOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IncomingCallOptions?>("callOptions"); }
            set { BackingStore?.Set("callOptions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IncomingCallOptions CallOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IncomingCallOptions>("callOptions"); }
            set { BackingStore?.Set("callOptions", value); }
        }
#endif
        /// <summary>The mediaConfig property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MediaConfig? MediaConfig
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MediaConfig?>("mediaConfig"); }
            set { BackingStore?.Set("mediaConfig", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MediaConfig MediaConfig
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MediaConfig>("mediaConfig"); }
            set { BackingStore?.Set("mediaConfig", value); }
        }
#endif
        /// <summary>The participantCapacity property</summary>
        public int? ParticipantCapacity
        {
            get { return BackingStore?.Get<int?>("participantCapacity"); }
            set { BackingStore?.Set("participantCapacity", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.App.Calls.Item.Answer.AnswerPostRequestBody"/> and sets the default values.
        /// </summary>
        public AnswerPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.App.Calls.Item.Answer.AnswerPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.App.Calls.Item.Answer.AnswerPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.App.Calls.Item.Answer.AnswerPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "acceptedModalities", n => { AcceptedModalities = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.Modality>()?.AsList(); } },
                { "callOptions", n => { CallOptions = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IncomingCallOptions>(global::Microsoft.Graph.Beta.Models.IncomingCallOptions.CreateFromDiscriminatorValue); } },
                { "callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                { "mediaConfig", n => { MediaConfig = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MediaConfig>(global::Microsoft.Graph.Beta.Models.MediaConfig.CreateFromDiscriminatorValue); } },
                { "participantCapacity", n => { ParticipantCapacity = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.Modality>("acceptedModalities", AcceptedModalities);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IncomingCallOptions>("callOptions", CallOptions);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteIntValue("participantCapacity", ParticipantCapacity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
