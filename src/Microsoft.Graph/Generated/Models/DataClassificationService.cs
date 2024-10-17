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
    public partial class DataClassificationService : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The classifyFileJobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.JobResponseBase>? ClassifyFileJobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.JobResponseBase>?>("classifyFileJobs"); }
            set { BackingStore?.Set("classifyFileJobs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.JobResponseBase> ClassifyFileJobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.JobResponseBase>>("classifyFileJobs"); }
            set { BackingStore?.Set("classifyFileJobs", value); }
        }
#endif
        /// <summary>The classifyTextJobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.JobResponseBase>? ClassifyTextJobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.JobResponseBase>?>("classifyTextJobs"); }
            set { BackingStore?.Set("classifyTextJobs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.JobResponseBase> ClassifyTextJobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.JobResponseBase>>("classifyTextJobs"); }
            set { BackingStore?.Set("classifyTextJobs", value); }
        }
#endif
        /// <summary>The evaluateDlpPoliciesJobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.JobResponseBase>? EvaluateDlpPoliciesJobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.JobResponseBase>?>("evaluateDlpPoliciesJobs"); }
            set { BackingStore?.Set("evaluateDlpPoliciesJobs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.JobResponseBase> EvaluateDlpPoliciesJobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.JobResponseBase>>("evaluateDlpPoliciesJobs"); }
            set { BackingStore?.Set("evaluateDlpPoliciesJobs", value); }
        }
#endif
        /// <summary>The evaluateLabelJobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.JobResponseBase>? EvaluateLabelJobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.JobResponseBase>?>("evaluateLabelJobs"); }
            set { BackingStore?.Set("evaluateLabelJobs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.JobResponseBase> EvaluateLabelJobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.JobResponseBase>>("evaluateLabelJobs"); }
            set { BackingStore?.Set("evaluateLabelJobs", value); }
        }
#endif
        /// <summary>The exactMatchDataStores property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ExactMatchDataStore>? ExactMatchDataStores
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExactMatchDataStore>?>("exactMatchDataStores"); }
            set { BackingStore?.Set("exactMatchDataStores", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ExactMatchDataStore> ExactMatchDataStores
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExactMatchDataStore>>("exactMatchDataStores"); }
            set { BackingStore?.Set("exactMatchDataStores", value); }
        }
#endif
        /// <summary>The exactMatchUploadAgents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ExactMatchUploadAgent>? ExactMatchUploadAgents
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExactMatchUploadAgent>?>("exactMatchUploadAgents"); }
            set { BackingStore?.Set("exactMatchUploadAgents", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ExactMatchUploadAgent> ExactMatchUploadAgents
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ExactMatchUploadAgent>>("exactMatchUploadAgents"); }
            set { BackingStore?.Set("exactMatchUploadAgents", value); }
        }
#endif
        /// <summary>The jobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.JobResponseBase>? Jobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.JobResponseBase>?>("jobs"); }
            set { BackingStore?.Set("jobs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.JobResponseBase> Jobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.JobResponseBase>>("jobs"); }
            set { BackingStore?.Set("jobs", value); }
        }
#endif
        /// <summary>The sensitiveTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.SensitiveType>? SensitiveTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SensitiveType>?>("sensitiveTypes"); }
            set { BackingStore?.Set("sensitiveTypes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.SensitiveType> SensitiveTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SensitiveType>>("sensitiveTypes"); }
            set { BackingStore?.Set("sensitiveTypes", value); }
        }
#endif
        /// <summary>The sensitivityLabels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.SensitivityLabel>? SensitivityLabels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SensitivityLabel>?>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.SensitivityLabel> SensitivityLabels
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SensitivityLabel>>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DataClassificationService"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DataClassificationService CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DataClassificationService();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "classifyFileJobs", n => { ClassifyFileJobs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.JobResponseBase>(global::Microsoft.Graph.Beta.Models.JobResponseBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "classifyTextJobs", n => { ClassifyTextJobs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.JobResponseBase>(global::Microsoft.Graph.Beta.Models.JobResponseBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "evaluateDlpPoliciesJobs", n => { EvaluateDlpPoliciesJobs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.JobResponseBase>(global::Microsoft.Graph.Beta.Models.JobResponseBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "evaluateLabelJobs", n => { EvaluateLabelJobs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.JobResponseBase>(global::Microsoft.Graph.Beta.Models.JobResponseBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "exactMatchDataStores", n => { ExactMatchDataStores = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExactMatchDataStore>(global::Microsoft.Graph.Beta.Models.ExactMatchDataStore.CreateFromDiscriminatorValue)?.AsList(); } },
                { "exactMatchUploadAgents", n => { ExactMatchUploadAgents = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExactMatchUploadAgent>(global::Microsoft.Graph.Beta.Models.ExactMatchUploadAgent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "jobs", n => { Jobs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.JobResponseBase>(global::Microsoft.Graph.Beta.Models.JobResponseBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sensitiveTypes", n => { SensitiveTypes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SensitiveType>(global::Microsoft.Graph.Beta.Models.SensitiveType.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sensitivityLabels", n => { SensitivityLabels = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SensitivityLabel>(global::Microsoft.Graph.Beta.Models.SensitivityLabel.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.JobResponseBase>("classifyFileJobs", ClassifyFileJobs);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.JobResponseBase>("classifyTextJobs", ClassifyTextJobs);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.JobResponseBase>("evaluateDlpPoliciesJobs", EvaluateDlpPoliciesJobs);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.JobResponseBase>("evaluateLabelJobs", EvaluateLabelJobs);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExactMatchDataStore>("exactMatchDataStores", ExactMatchDataStores);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ExactMatchUploadAgent>("exactMatchUploadAgents", ExactMatchUploadAgents);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.JobResponseBase>("jobs", Jobs);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SensitiveType>("sensitiveTypes", SensitiveTypes);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SensitivityLabel>("sensitivityLabels", SensitivityLabels);
        }
    }
}
#pragma warning restore CS0618
