// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Partner.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PartnerSecurityScore : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The current security score for the partner.</summary>
        public float? CurrentScore
        {
            get { return BackingStore?.Get<float?>("currentScore"); }
            set { BackingStore?.Set("currentScore", value); }
        }
        /// <summary>Contains customer-specific information for certain requirements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Partner.Security.CustomerInsight>? CustomerInsights
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Partner.Security.CustomerInsight>?>("customerInsights"); }
            set { BackingStore?.Set("customerInsights", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Partner.Security.CustomerInsight> CustomerInsights
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Partner.Security.CustomerInsight>>("customerInsights"); }
            set { BackingStore?.Set("customerInsights", value); }
        }
#endif
        /// <summary>Contains a list of recent score changes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityScoreHistory>? History
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityScoreHistory>?>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityScoreHistory> History
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityScoreHistory>>("history"); }
            set { BackingStore?.Set("history", value); }
        }
#endif
        /// <summary>The last time the data was checked.</summary>
        public DateTimeOffset? LastRefreshDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshDateTime"); }
            set { BackingStore?.Set("lastRefreshDateTime", value); }
        }
        /// <summary>The maximum score possible.</summary>
        public float? MaxScore
        {
            get { return BackingStore?.Get<float?>("maxScore"); }
            set { BackingStore?.Set("maxScore", value); }
        }
        /// <summary>Contains the list of security requirements that make up the score.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityRequirement>? Requirements
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityRequirement>?>("requirements"); }
            set { BackingStore?.Set("requirements", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityRequirement> Requirements
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityRequirement>>("requirements"); }
            set { BackingStore?.Set("requirements", value); }
        }
#endif
        /// <summary>The last time the security score or related properties changed.</summary>
        public DateTimeOffset? UpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("updatedDateTime"); }
            set { BackingStore?.Set("updatedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Partner.Security.PartnerSecurityScore"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Partner.Security.PartnerSecurityScore CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Partner.Security.PartnerSecurityScore();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "currentScore", n => { CurrentScore = n.GetFloatValue(); } },
                { "customerInsights", n => { CustomerInsights = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Partner.Security.CustomerInsight>(global::Microsoft.Graph.Beta.Models.Partner.Security.CustomerInsight.CreateFromDiscriminatorValue)?.AsList(); } },
                { "history", n => { History = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityScoreHistory>(global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityScoreHistory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastRefreshDateTime", n => { LastRefreshDateTime = n.GetDateTimeOffsetValue(); } },
                { "maxScore", n => { MaxScore = n.GetFloatValue(); } },
                { "requirements", n => { Requirements = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityRequirement>(global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityRequirement.CreateFromDiscriminatorValue)?.AsList(); } },
                { "updatedDateTime", n => { UpdatedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteFloatValue("currentScore", CurrentScore);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Partner.Security.CustomerInsight>("customerInsights", CustomerInsights);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityScoreHistory>("history", History);
            writer.WriteDateTimeOffsetValue("lastRefreshDateTime", LastRefreshDateTime);
            writer.WriteFloatValue("maxScore", MaxScore);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Partner.Security.SecurityRequirement>("requirements", Requirements);
            writer.WriteDateTimeOffsetValue("updatedDateTime", UpdatedDateTime);
        }
    }
}
#pragma warning restore CS0618
