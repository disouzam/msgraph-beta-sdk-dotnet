// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class ApiDataConnector : global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataConnector, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The apiFormat property</summary>
        public global::Microsoft.Graph.Beta.Models.IndustryData.ApiFormat? ApiFormat
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IndustryData.ApiFormat?>("apiFormat"); }
            set { BackingStore?.Set("apiFormat", value); }
        }
        /// <summary>The base URL, including the scheme, host, and path for the API, with or without a trailing &apos;/&apos;. For example, &apos;https://example.com/ims/oneRoster/v1p1&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseUrl
        {
            get { return BackingStore?.Get<string?>("baseUrl"); }
            set { BackingStore?.Set("baseUrl", value); }
        }
#nullable restore
#else
        public string BaseUrl
        {
            get { return BackingStore?.Get<string>("baseUrl"); }
            set { BackingStore?.Set("baseUrl", value); }
        }
#endif
        /// <summary>The credential property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IndustryData.Credential? Credential
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IndustryData.Credential?>("credential"); }
            set { BackingStore?.Set("credential", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IndustryData.Credential Credential
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IndustryData.Credential>("credential"); }
            set { BackingStore?.Set("credential", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IndustryData.ApiDataConnector"/> and sets the default values.
        /// </summary>
        public ApiDataConnector() : base()
        {
            OdataType = "#microsoft.graph.industryData.apiDataConnector";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IndustryData.ApiDataConnector"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IndustryData.ApiDataConnector CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.industryData.oneRosterApiDataConnector" => new global::Microsoft.Graph.Beta.Models.IndustryData.OneRosterApiDataConnector(),
                _ => new global::Microsoft.Graph.Beta.Models.IndustryData.ApiDataConnector(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "apiFormat", n => { ApiFormat = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.IndustryData.ApiFormat>(); } },
                { "baseUrl", n => { BaseUrl = n.GetStringValue(); } },
                { "credential", n => { Credential = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IndustryData.Credential>(global::Microsoft.Graph.Beta.Models.IndustryData.Credential.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.IndustryData.ApiFormat>("apiFormat", ApiFormat);
            writer.WriteStringValue("baseUrl", BaseUrl);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IndustryData.Credential>("credential", Credential);
        }
    }
}
#pragma warning restore CS0618
