// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class OnTokenIssuanceStartCustomExtensionHandler : global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartHandler, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The configuration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CustomExtensionOverwriteConfiguration? Configuration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CustomExtensionOverwriteConfiguration?>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CustomExtensionOverwriteConfiguration Configuration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CustomExtensionOverwriteConfiguration>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#endif
        /// <summary>The customExtension property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartCustomExtension? CustomExtension
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartCustomExtension?>("customExtension"); }
            set { BackingStore?.Set("customExtension", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartCustomExtension CustomExtension
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartCustomExtension>("customExtension"); }
            set { BackingStore?.Set("customExtension", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartCustomExtensionHandler"/> and sets the default values.
        /// </summary>
        public OnTokenIssuanceStartCustomExtensionHandler() : base()
        {
            OdataType = "#microsoft.graph.onTokenIssuanceStartCustomExtensionHandler";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartCustomExtensionHandler"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartCustomExtensionHandler CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartCustomExtensionHandler();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configuration", n => { Configuration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CustomExtensionOverwriteConfiguration>(global::Microsoft.Graph.Beta.Models.CustomExtensionOverwriteConfiguration.CreateFromDiscriminatorValue); } },
                { "customExtension", n => { CustomExtension = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartCustomExtension>(global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartCustomExtension.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CustomExtensionOverwriteConfiguration>("configuration", Configuration);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartCustomExtension>("customExtension", CustomExtension);
        }
    }
}
#pragma warning restore CS0618
