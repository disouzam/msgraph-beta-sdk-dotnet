// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class MonthlyUserInsightMetricsRoot : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Insights for active users on apps registered in the tenant for a specified period.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ActiveUsersMetric>? ActiveUsers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ActiveUsersMetric>?>("activeUsers"); }
            set { BackingStore?.Set("activeUsers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ActiveUsersMetric> ActiveUsers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ActiveUsersMetric>>("activeUsers"); }
            set { BackingStore?.Set("activeUsers", value); }
        }
#endif
        /// <summary>Insights for authentications on apps registered in the tenant for a specified period.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AuthenticationsMetric>? Authentications
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthenticationsMetric>?>("authentications"); }
            set { BackingStore?.Set("authentications", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AuthenticationsMetric> Authentications
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthenticationsMetric>>("authentications"); }
            set { BackingStore?.Set("authentications", value); }
        }
#endif
        /// <summary>The inactiveUsers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersMetric>? InactiveUsers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersMetric>?>("inactiveUsers"); }
            set { BackingStore?.Set("inactiveUsers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersMetric> InactiveUsers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersMetric>>("inactiveUsers"); }
            set { BackingStore?.Set("inactiveUsers", value); }
        }
#endif
        /// <summary>The inactiveUsersByApplication property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric>? InactiveUsersByApplication
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric>?>("inactiveUsersByApplication"); }
            set { BackingStore?.Set("inactiveUsersByApplication", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric> InactiveUsersByApplication
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric>>("inactiveUsersByApplication"); }
            set { BackingStore?.Set("inactiveUsersByApplication", value); }
        }
#endif
        /// <summary>Insights for MFA usage on apps registered in the tenant for a specified period.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MfaCompletionMetric>? MfaCompletions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MfaCompletionMetric>?>("mfaCompletions"); }
            set { BackingStore?.Set("mfaCompletions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MfaCompletionMetric> MfaCompletions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MfaCompletionMetric>>("mfaCompletions"); }
            set { BackingStore?.Set("mfaCompletions", value); }
        }
#endif
        /// <summary>Insights for all user requests on apps registered in the tenant for a specified period.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.UserRequestsMetric>? Requests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UserRequestsMetric>?>("requests"); }
            set { BackingStore?.Set("requests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.UserRequestsMetric> Requests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UserRequestsMetric>>("requests"); }
            set { BackingStore?.Set("requests", value); }
        }
#endif
        /// <summary>Total sign-ups on apps registered in the tenant for a specified period.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.UserSignUpMetric>? SignUps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UserSignUpMetric>?>("signUps"); }
            set { BackingStore?.Set("signUps", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.UserSignUpMetric> SignUps
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UserSignUpMetric>>("signUps"); }
            set { BackingStore?.Set("signUps", value); }
        }
#endif
        /// <summary>Summary of all usage insights on apps registered in the tenant for a specified period.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.InsightSummary>? Summary
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.InsightSummary>?>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.InsightSummary> Summary
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.InsightSummary>>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MonthlyUserInsightMetricsRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MonthlyUserInsightMetricsRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MonthlyUserInsightMetricsRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeUsers", n => { ActiveUsers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ActiveUsersMetric>(global::Microsoft.Graph.Beta.Models.ActiveUsersMetric.CreateFromDiscriminatorValue)?.AsList(); } },
                { "authentications", n => { Authentications = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthenticationsMetric>(global::Microsoft.Graph.Beta.Models.AuthenticationsMetric.CreateFromDiscriminatorValue)?.AsList(); } },
                { "inactiveUsers", n => { InactiveUsers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersMetric>(global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersMetric.CreateFromDiscriminatorValue)?.AsList(); } },
                { "inactiveUsersByApplication", n => { InactiveUsersByApplication = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric>(global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mfaCompletions", n => { MfaCompletions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MfaCompletionMetric>(global::Microsoft.Graph.Beta.Models.MfaCompletionMetric.CreateFromDiscriminatorValue)?.AsList(); } },
                { "requests", n => { Requests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UserRequestsMetric>(global::Microsoft.Graph.Beta.Models.UserRequestsMetric.CreateFromDiscriminatorValue)?.AsList(); } },
                { "signUps", n => { SignUps = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UserSignUpMetric>(global::Microsoft.Graph.Beta.Models.UserSignUpMetric.CreateFromDiscriminatorValue)?.AsList(); } },
                { "summary", n => { Summary = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.InsightSummary>(global::Microsoft.Graph.Beta.Models.InsightSummary.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ActiveUsersMetric>("activeUsers", ActiveUsers);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthenticationsMetric>("authentications", Authentications);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersMetric>("inactiveUsers", InactiveUsers);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MonthlyInactiveUsersByApplicationMetric>("inactiveUsersByApplication", InactiveUsersByApplication);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MfaCompletionMetric>("mfaCompletions", MfaCompletions);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UserRequestsMetric>("requests", Requests);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UserSignUpMetric>("signUps", SignUps);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.InsightSummary>("summary", Summary);
        }
    }
}
#pragma warning restore CS0618
