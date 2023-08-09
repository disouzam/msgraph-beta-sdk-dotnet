// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class IpRange : RuleDestination, IParsable {
        /// <summary>Specifies the starting IP address of the IP range.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BeginAddress {
            get { return BackingStore?.Get<string?>("beginAddress"); }
            set { BackingStore?.Set("beginAddress", value); }
        }
#nullable restore
#else
        public string BeginAddress {
            get { return BackingStore?.Get<string>("beginAddress"); }
            set { BackingStore?.Set("beginAddress", value); }
        }
#endif
        /// <summary>Specifies the ending IP address of the IP range.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndAddress {
            get { return BackingStore?.Get<string?>("endAddress"); }
            set { BackingStore?.Set("endAddress", value); }
        }
#nullable restore
#else
        public string EndAddress {
            get { return BackingStore?.Get<string>("endAddress"); }
            set { BackingStore?.Set("endAddress", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new ipRange and sets the default values.
        /// </summary>
        public IpRange() : base() {
            OdataType = "#microsoft.graph.networkaccess.ipRange";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IpRange CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpRange();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"beginAddress", n => { BeginAddress = n.GetStringValue(); } },
                {"endAddress", n => { EndAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("beginAddress", BeginAddress);
            writer.WriteStringValue("endAddress", EndAddress);
        }
    }
}
