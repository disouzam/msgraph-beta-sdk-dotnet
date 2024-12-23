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
    public partial class ApprovalWorkflowProvider : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The businessFlows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.BusinessFlow>? BusinessFlows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.BusinessFlow>?>("businessFlows"); }
            set { BackingStore?.Set("businessFlows", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.BusinessFlow> BusinessFlows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.BusinessFlow>>("businessFlows"); }
            set { BackingStore?.Set("businessFlows", value); }
        }
#endif
        /// <summary>The businessFlowsWithRequestsAwaitingMyDecision property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.BusinessFlow>? BusinessFlowsWithRequestsAwaitingMyDecision
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.BusinessFlow>?>("businessFlowsWithRequestsAwaitingMyDecision"); }
            set { BackingStore?.Set("businessFlowsWithRequestsAwaitingMyDecision", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.BusinessFlow> BusinessFlowsWithRequestsAwaitingMyDecision
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.BusinessFlow>>("businessFlowsWithRequestsAwaitingMyDecision"); }
            set { BackingStore?.Set("businessFlowsWithRequestsAwaitingMyDecision", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The policyTemplates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.GovernancePolicyTemplate>? PolicyTemplates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernancePolicyTemplate>?>("policyTemplates"); }
            set { BackingStore?.Set("policyTemplates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.GovernancePolicyTemplate> PolicyTemplates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GovernancePolicyTemplate>>("policyTemplates"); }
            set { BackingStore?.Set("policyTemplates", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ApprovalWorkflowProvider"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ApprovalWorkflowProvider CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ApprovalWorkflowProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "businessFlows", n => { BusinessFlows = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.BusinessFlow>(global::Microsoft.Graph.Beta.Models.BusinessFlow.CreateFromDiscriminatorValue)?.AsList(); } },
                { "businessFlowsWithRequestsAwaitingMyDecision", n => { BusinessFlowsWithRequestsAwaitingMyDecision = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.BusinessFlow>(global::Microsoft.Graph.Beta.Models.BusinessFlow.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "policyTemplates", n => { PolicyTemplates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernancePolicyTemplate>(global::Microsoft.Graph.Beta.Models.GovernancePolicyTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.BusinessFlow>("businessFlows", BusinessFlows);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.BusinessFlow>("businessFlowsWithRequestsAwaitingMyDecision", BusinessFlowsWithRequestsAwaitingMyDecision);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GovernancePolicyTemplate>("policyTemplates", PolicyTemplates);
        }
    }
}
#pragma warning restore CS0618
