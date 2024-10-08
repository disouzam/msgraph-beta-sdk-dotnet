// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class FilePlanCitation : global::Microsoft.Graph.Beta.Models.Security.FilePlanDescriptorBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the jurisdiction or agency that published the filePlanCitation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CitationJurisdiction
        {
            get { return BackingStore?.Get<string?>("citationJurisdiction"); }
            set { BackingStore?.Set("citationJurisdiction", value); }
        }
#nullable restore
#else
        public string CitationJurisdiction
        {
            get { return BackingStore?.Get<string>("citationJurisdiction"); }
            set { BackingStore?.Set("citationJurisdiction", value); }
        }
#endif
        /// <summary>Represents the URL to the published filePlanCitation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CitationUrl
        {
            get { return BackingStore?.Get<string?>("citationUrl"); }
            set { BackingStore?.Set("citationUrl", value); }
        }
#nullable restore
#else
        public string CitationUrl
        {
            get { return BackingStore?.Get<string>("citationUrl"); }
            set { BackingStore?.Set("citationUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.FilePlanCitation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.FilePlanCitation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.FilePlanCitation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "citationJurisdiction", n => { CitationJurisdiction = n.GetStringValue(); } },
                { "citationUrl", n => { CitationUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("citationJurisdiction", CitationJurisdiction);
            writer.WriteStringValue("citationUrl", CitationUrl);
        }
    }
}
#pragma warning restore CS0618
