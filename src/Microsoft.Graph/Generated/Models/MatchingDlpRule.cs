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
    public partial class MatchingDlpRule : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The actions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DlpActionInfo>? Actions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DlpActionInfo>?>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DlpActionInfo> Actions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DlpActionInfo>>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The isMostRestrictive property</summary>
        public bool? IsMostRestrictive
        {
            get { return BackingStore?.Get<bool?>("isMostRestrictive"); }
            set { BackingStore?.Set("isMostRestrictive", value); }
        }
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
        /// <summary>The policyId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyId
        {
            get { return BackingStore?.Get<string?>("policyId"); }
            set { BackingStore?.Set("policyId", value); }
        }
#nullable restore
#else
        public string PolicyId
        {
            get { return BackingStore?.Get<string>("policyId"); }
            set { BackingStore?.Set("policyId", value); }
        }
#endif
        /// <summary>The policyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyName
        {
            get { return BackingStore?.Get<string?>("policyName"); }
            set { BackingStore?.Set("policyName", value); }
        }
#nullable restore
#else
        public string PolicyName
        {
            get { return BackingStore?.Get<string>("policyName"); }
            set { BackingStore?.Set("policyName", value); }
        }
#endif
        /// <summary>The priority property</summary>
        public int? Priority
        {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>The ruleId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleId
        {
            get { return BackingStore?.Get<string?>("ruleId"); }
            set { BackingStore?.Set("ruleId", value); }
        }
#nullable restore
#else
        public string RuleId
        {
            get { return BackingStore?.Get<string>("ruleId"); }
            set { BackingStore?.Set("ruleId", value); }
        }
#endif
        /// <summary>The ruleMode property</summary>
        public global::Microsoft.Graph.Beta.Models.RuleMode? RuleMode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.RuleMode?>("ruleMode"); }
            set { BackingStore?.Set("ruleMode", value); }
        }
        /// <summary>The ruleName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleName
        {
            get { return BackingStore?.Get<string?>("ruleName"); }
            set { BackingStore?.Set("ruleName", value); }
        }
#nullable restore
#else
        public string RuleName
        {
            get { return BackingStore?.Get<string>("ruleName"); }
            set { BackingStore?.Set("ruleName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MatchingDlpRule"/> and sets the default values.
        /// </summary>
        public MatchingDlpRule()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MatchingDlpRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.MatchingDlpRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MatchingDlpRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actions", n => { Actions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DlpActionInfo>(global::Microsoft.Graph.Beta.Models.DlpActionInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isMostRestrictive", n => { IsMostRestrictive = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "policyId", n => { PolicyId = n.GetStringValue(); } },
                { "policyName", n => { PolicyName = n.GetStringValue(); } },
                { "priority", n => { Priority = n.GetIntValue(); } },
                { "ruleId", n => { RuleId = n.GetStringValue(); } },
                { "ruleMode", n => { RuleMode = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.RuleMode>(); } },
                { "ruleName", n => { RuleName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DlpActionInfo>("actions", Actions);
            writer.WriteBoolValue("isMostRestrictive", IsMostRestrictive);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("ruleId", RuleId);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.RuleMode>("ruleMode", RuleMode);
            writer.WriteStringValue("ruleName", RuleName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
