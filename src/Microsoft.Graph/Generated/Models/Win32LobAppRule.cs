using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A base complex type to store the detection or requirement rule data for a Win32 LOB app.</summary>
    public class Win32LobAppRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The rule type indicating the purpose of the rule. Possible values are: detection, requirement.</summary>
        public Win32LobAppRuleType? RuleType {
            get { return BackingStore?.Get<Win32LobAppRuleType?>(nameof(RuleType)); }
            set { BackingStore?.Set(nameof(RuleType), value); }
        }
        /// <summary>
        /// Instantiates a new win32LobAppRule and sets the default values.
        /// </summary>
        public Win32LobAppRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Win32LobAppRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.win32LobAppFileSystemRule" => new Win32LobAppFileSystemRule(),
                "#microsoft.graph.win32LobAppPowerShellScriptRule" => new Win32LobAppPowerShellScriptRule(),
                "#microsoft.graph.win32LobAppProductCodeRule" => new Win32LobAppProductCodeRule(),
                "#microsoft.graph.win32LobAppRegistryRule" => new Win32LobAppRegistryRule(),
                _ => new Win32LobAppRule(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ruleType", n => { RuleType = n.GetEnumValue<Win32LobAppRuleType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Win32LobAppRuleType>("ruleType", RuleType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
