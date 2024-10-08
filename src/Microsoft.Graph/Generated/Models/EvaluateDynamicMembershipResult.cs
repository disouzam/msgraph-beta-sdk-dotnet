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
    public partial class EvaluateDynamicMembershipResult : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>If a group ID is provided, the value is the membership rule for the group. If a group ID isn&apos;t provided, the value is the membership rule that was provided as a parameter. For more information, see Dynamic membership rules for groups in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembershipRule
        {
            get { return BackingStore?.Get<string?>("membershipRule"); }
            set { BackingStore?.Set("membershipRule", value); }
        }
#nullable restore
#else
        public string MembershipRule
        {
            get { return BackingStore?.Get<string>("membershipRule"); }
            set { BackingStore?.Set("membershipRule", value); }
        }
#endif
        /// <summary>Provides a detailed analysis of the membership evaluation result.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ExpressionEvaluationDetails? MembershipRuleEvaluationDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ExpressionEvaluationDetails?>("membershipRuleEvaluationDetails"); }
            set { BackingStore?.Set("membershipRuleEvaluationDetails", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ExpressionEvaluationDetails MembershipRuleEvaluationDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ExpressionEvaluationDetails>("membershipRuleEvaluationDetails"); }
            set { BackingStore?.Set("membershipRuleEvaluationDetails", value); }
        }
#endif
        /// <summary>The value is true if the user or device is a member of the group. The value can also be true if a membership rule was provided and the user or device passes the rule evaluation; otherwise false.</summary>
        public bool? MembershipRuleEvaluationResult
        {
            get { return BackingStore?.Get<bool?>("membershipRuleEvaluationResult"); }
            set { BackingStore?.Set("membershipRuleEvaluationResult", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.EvaluateDynamicMembershipResult"/> and sets the default values.
        /// </summary>
        public EvaluateDynamicMembershipResult()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.EvaluateDynamicMembershipResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.EvaluateDynamicMembershipResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.EvaluateDynamicMembershipResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "membershipRule", n => { MembershipRule = n.GetStringValue(); } },
                { "membershipRuleEvaluationDetails", n => { MembershipRuleEvaluationDetails = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ExpressionEvaluationDetails>(global::Microsoft.Graph.Beta.Models.ExpressionEvaluationDetails.CreateFromDiscriminatorValue); } },
                { "membershipRuleEvaluationResult", n => { MembershipRuleEvaluationResult = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("membershipRule", MembershipRule);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ExpressionEvaluationDetails>("membershipRuleEvaluationDetails", MembershipRuleEvaluationDetails);
            writer.WriteBoolValue("membershipRuleEvaluationResult", MembershipRuleEvaluationResult);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
