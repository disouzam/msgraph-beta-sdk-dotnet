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
    public partial class PrintUsageByPrinter : global::Microsoft.Graph.Beta.Models.PrintUsage, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The ID of the printer represented by these statistics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrinterId
        {
            get { return BackingStore?.Get<string?>("printerId"); }
            set { BackingStore?.Set("printerId", value); }
        }
#nullable restore
#else
        public string PrinterId
        {
            get { return BackingStore?.Get<string>("printerId"); }
            set { BackingStore?.Set("printerId", value); }
        }
#endif
        /// <summary>The name of the printer represented by these statistics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrinterName
        {
            get { return BackingStore?.Get<string?>("printerName"); }
            set { BackingStore?.Set("printerName", value); }
        }
#nullable restore
#else
        public string PrinterName
        {
            get { return BackingStore?.Get<string>("printerName"); }
            set { BackingStore?.Set("printerName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PrintUsageByPrinter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.PrintUsageByPrinter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.PrintUsageByPrinter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "printerId", n => { PrinterId = n.GetStringValue(); } },
                { "printerName", n => { PrinterName = n.GetStringValue(); } },
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
            writer.WriteStringValue("printerId", PrinterId);
            writer.WriteStringValue("printerName", PrinterName);
        }
    }
}
#pragma warning restore CS0618
