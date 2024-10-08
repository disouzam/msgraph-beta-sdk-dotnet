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
    public partial class AppliedAuthenticationEventListener : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The type of authentication event that triggered the custom authentication extension request. The possible values are: tokenIssuanceStart, pageRenderStart, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.AuthenticationEventType? EventType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationEventType?>("eventType"); }
            set { BackingStore?.Set("eventType", value); }
        }
        /// <summary>ID of the authentication event listener that was executed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExecutedListenerId
        {
            get { return BackingStore?.Get<string?>("executedListenerId"); }
            set { BackingStore?.Set("executedListenerId", value); }
        }
#nullable restore
#else
        public string ExecutedListenerId
        {
            get { return BackingStore?.Get<string>("executedListenerId"); }
            set { BackingStore?.Set("executedListenerId", value); }
        }
#endif
        /// <summary>The result from the listening client, such as an Azure Logic App and Azure Functions, of this authentication event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AuthenticationEventHandlerResult? HandlerResult
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationEventHandlerResult?>("handlerResult"); }
            set { BackingStore?.Set("handlerResult", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AuthenticationEventHandlerResult HandlerResult
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationEventHandlerResult>("handlerResult"); }
            set { BackingStore?.Set("handlerResult", value); }
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
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AppliedAuthenticationEventListener"/> and sets the default values.
        /// </summary>
        public AppliedAuthenticationEventListener()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AppliedAuthenticationEventListener"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.AppliedAuthenticationEventListener CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AppliedAuthenticationEventListener();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "eventType", n => { EventType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AuthenticationEventType>(); } },
                { "executedListenerId", n => { ExecutedListenerId = n.GetStringValue(); } },
                { "handlerResult", n => { HandlerResult = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AuthenticationEventHandlerResult>(global::Microsoft.Graph.Beta.Models.AuthenticationEventHandlerResult.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AuthenticationEventType>("eventType", EventType);
            writer.WriteStringValue("executedListenerId", ExecutedListenerId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AuthenticationEventHandlerResult>("handlerResult", HandlerResult);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
