// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Communications.Calls.Item.Redirect
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class RedirectPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The maskCallee property</summary>
        public bool? MaskCallee
        {
            get { return BackingStore?.Get<bool?>("maskCallee"); }
            set { BackingStore?.Set("maskCallee", value); }
        }
        /// <summary>The maskCaller property</summary>
        public bool? MaskCaller
        {
            get { return BackingStore?.Get<bool?>("maskCaller"); }
            set { BackingStore?.Set("maskCaller", value); }
        }
        /// <summary>The targetDisposition property</summary>
        public global::Microsoft.Graph.Beta.Models.CallDisposition? TargetDisposition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CallDisposition?>("targetDisposition"); }
            set { BackingStore?.Set("targetDisposition", value); }
        }
        /// <summary>The targets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.InvitationParticipantInfo>? Targets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.InvitationParticipantInfo>?>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.InvitationParticipantInfo> Targets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.InvitationParticipantInfo>>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#endif
        /// <summary>The timeout property</summary>
        public int? Timeout
        {
            get { return BackingStore?.Get<int?>("timeout"); }
            set { BackingStore?.Set("timeout", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Communications.Calls.Item.Redirect.RedirectPostRequestBody"/> and sets the default values.
        /// </summary>
        public RedirectPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Communications.Calls.Item.Redirect.RedirectPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Communications.Calls.Item.Redirect.RedirectPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Communications.Calls.Item.Redirect.RedirectPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                { "maskCallee", n => { MaskCallee = n.GetBoolValue(); } },
                { "maskCaller", n => { MaskCaller = n.GetBoolValue(); } },
                { "targetDisposition", n => { TargetDisposition = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CallDisposition>(); } },
                { "targets", n => { Targets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.InvitationParticipantInfo>(global::Microsoft.Graph.Beta.Models.InvitationParticipantInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "timeout", n => { Timeout = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteBoolValue("maskCallee", MaskCallee);
            writer.WriteBoolValue("maskCaller", MaskCaller);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CallDisposition>("targetDisposition", TargetDisposition);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.InvitationParticipantInfo>("targets", Targets);
            writer.WriteIntValue("timeout", Timeout);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
