// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.ODataErrors
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MainError : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code
        {
            get { return BackingStore?.Get<string?>("code"); }
            set { BackingStore?.Set("code", value); }
        }
#nullable restore
#else
        public string Code
        {
            get { return BackingStore?.Get<string>("code"); }
            set { BackingStore?.Set("code", value); }
        }
#endif
        /// <summary>The details property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ODataErrors.ErrorDetails>? Details
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ODataErrors.ErrorDetails>?>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ODataErrors.ErrorDetails> Details
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ODataErrors.ErrorDetails>>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#endif
        /// <summary>The innerError property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ODataErrors.InnerError? InnerError
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ODataErrors.InnerError?>("innerError"); }
            set { BackingStore?.Set("innerError", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ODataErrors.InnerError InnerError
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ODataErrors.InnerError>("innerError"); }
            set { BackingStore?.Set("innerError", value); }
        }
#endif
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message
        {
            get { return BackingStore?.Get<string?>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#nullable restore
#else
        public string Message
        {
            get { return BackingStore?.Get<string>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#endif
        /// <summary>The target property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Target
        {
            get { return BackingStore?.Get<string?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public string Target
        {
            get { return BackingStore?.Get<string>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ODataErrors.MainError"/> and sets the default values.
        /// </summary>
        public MainError()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ODataErrors.MainError"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.ODataErrors.MainError CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ODataErrors.MainError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "code", n => { Code = n.GetStringValue(); } },
                { "details", n => { Details = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ODataErrors.ErrorDetails>(global::Microsoft.Graph.Beta.Models.ODataErrors.ErrorDetails.CreateFromDiscriminatorValue)?.AsList(); } },
                { "innerError", n => { InnerError = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ODataErrors.InnerError>(global::Microsoft.Graph.Beta.Models.ODataErrors.InnerError.CreateFromDiscriminatorValue); } },
                { "message", n => { Message = n.GetStringValue(); } },
                { "target", n => { Target = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ODataErrors.ErrorDetails>("details", Details);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ODataErrors.InnerError>("innerError", InnerError);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
