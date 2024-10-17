// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Android Device Owner Global Proxy Direct.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AndroidDeviceOwnerGlobalProxyDirect : global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerGlobalProxy, IParsable
    {
        /// <summary>The excluded hosts</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludedHosts
        {
            get { return BackingStore?.Get<List<string>?>("excludedHosts"); }
            set { BackingStore?.Set("excludedHosts", value); }
        }
#nullable restore
#else
        public List<string> ExcludedHosts
        {
            get { return BackingStore?.Get<List<string>>("excludedHosts"); }
            set { BackingStore?.Set("excludedHosts", value); }
        }
#endif
        /// <summary>The host name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Host
        {
            get { return BackingStore?.Get<string?>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#nullable restore
#else
        public string Host
        {
            get { return BackingStore?.Get<string>("host"); }
            set { BackingStore?.Set("host", value); }
        }
#endif
        /// <summary>The port</summary>
        public int? Port
        {
            get { return BackingStore?.Get<int?>("port"); }
            set { BackingStore?.Set("port", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerGlobalProxyDirect"/> and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerGlobalProxyDirect() : base()
        {
            OdataType = "#microsoft.graph.androidDeviceOwnerGlobalProxyDirect";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerGlobalProxyDirect"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerGlobalProxyDirect CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AndroidDeviceOwnerGlobalProxyDirect();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "excludedHosts", n => { ExcludedHosts = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "host", n => { Host = n.GetStringValue(); } },
                { "port", n => { Port = n.GetIntValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("excludedHosts", ExcludedHosts);
            writer.WriteStringValue("host", Host);
            writer.WriteIntValue("port", Port);
        }
    }
}
#pragma warning restore CS0618
