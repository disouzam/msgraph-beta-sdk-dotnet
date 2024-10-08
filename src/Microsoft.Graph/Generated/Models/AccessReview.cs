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
    public partial class AccessReview : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The business flow template identifier. Required on create. This value is case sensitive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessFlowTemplateId
        {
            get { return BackingStore?.Get<string?>("businessFlowTemplateId"); }
            set { BackingStore?.Set("businessFlowTemplateId", value); }
        }
#nullable restore
#else
        public string BusinessFlowTemplateId
        {
            get { return BackingStore?.Get<string>("businessFlowTemplateId"); }
            set { BackingStore?.Set("businessFlowTemplateId", value); }
        }
#endif
        /// <summary>The user who created this review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.UserIdentity? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.UserIdentity?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.UserIdentity CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.UserIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The collection of decisions for this access review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AccessReviewDecision>? Decisions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessReviewDecision>?>("decisions"); }
            set { BackingStore?.Set("decisions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AccessReviewDecision> Decisions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessReviewDecision>>("decisions"); }
            set { BackingStore?.Set("decisions", value); }
        }
#endif
        /// <summary>The description provided by the access review creator, to show to the reviewers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The access review name. Required on create.</summary>
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
        /// <summary>The DateTime when the review is scheduled to end. This must be at least one day later than the start date. Required on create.</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The collection of access reviews instances past, present, and future, if this object is a recurring access review.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AccessReview>? Instances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessReview>?>("instances"); }
            set { BackingStore?.Set("instances", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AccessReview> Instances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessReview>>("instances"); }
            set { BackingStore?.Set("instances", value); }
        }
#endif
        /// <summary>The collection of decisions for the caller, if the caller is a reviewer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AccessReviewDecision>? MyDecisions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessReviewDecision>?>("myDecisions"); }
            set { BackingStore?.Set("myDecisions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AccessReviewDecision> MyDecisions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessReviewDecision>>("myDecisions"); }
            set { BackingStore?.Set("myDecisions", value); }
        }
#endif
        /// <summary>The object for which the access review is reviewing the access rights assignments. This identity can be the group for the review of memberships of users in a group, or the app for a review of assignments of users to an application. Required on create.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Identity? ReviewedEntity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Identity?>("reviewedEntity"); }
            set { BackingStore?.Set("reviewedEntity", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Identity ReviewedEntity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Identity>("reviewedEntity"); }
            set { BackingStore?.Set("reviewedEntity", value); }
        }
#endif
        /// <summary>The collection of reviewers for an access review, if access review reviewerType is of type delegated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AccessReviewReviewer>? Reviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessReviewReviewer>?>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AccessReviewReviewer> Reviewers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AccessReviewReviewer>>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#endif
        /// <summary>The relationship type of reviewer to the target object, one of: self, delegated, entityOwners. Required on create.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReviewerType
        {
            get { return BackingStore?.Get<string?>("reviewerType"); }
            set { BackingStore?.Set("reviewerType", value); }
        }
#nullable restore
#else
        public string ReviewerType
        {
            get { return BackingStore?.Get<string>("reviewerType"); }
            set { BackingStore?.Set("reviewerType", value); }
        }
#endif
        /// <summary>The settings of an accessReview, see type definition below.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AccessReviewSettings? Settings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessReviewSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AccessReviewSettings Settings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessReviewSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>The date and time when the review is scheduled to be start. This date can be in the future.  Required on create.</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>This read-only field specifies the status of an accessReview. The typical states include Initializing, NotStarted, Starting,InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status
        {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status
        {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessReview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AccessReview CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AccessReview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "businessFlowTemplateId", n => { BusinessFlowTemplateId = n.GetStringValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.UserIdentity>(global::Microsoft.Graph.Beta.Models.UserIdentity.CreateFromDiscriminatorValue); } },
                { "decisions", n => { Decisions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessReviewDecision>(global::Microsoft.Graph.Beta.Models.AccessReviewDecision.CreateFromDiscriminatorValue)?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "instances", n => { Instances = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessReview>(global::Microsoft.Graph.Beta.Models.AccessReview.CreateFromDiscriminatorValue)?.AsList(); } },
                { "myDecisions", n => { MyDecisions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessReviewDecision>(global::Microsoft.Graph.Beta.Models.AccessReviewDecision.CreateFromDiscriminatorValue)?.AsList(); } },
                { "reviewedEntity", n => { ReviewedEntity = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Identity>(global::Microsoft.Graph.Beta.Models.Identity.CreateFromDiscriminatorValue); } },
                { "reviewerType", n => { ReviewerType = n.GetStringValue(); } },
                { "reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessReviewReviewer>(global::Microsoft.Graph.Beta.Models.AccessReviewReviewer.CreateFromDiscriminatorValue)?.AsList(); } },
                { "settings", n => { Settings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AccessReviewSettings>(global::Microsoft.Graph.Beta.Models.AccessReviewSettings.CreateFromDiscriminatorValue); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
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
            writer.WriteStringValue("businessFlowTemplateId", BusinessFlowTemplateId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.UserIdentity>("createdBy", CreatedBy);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessReviewDecision>("decisions", Decisions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessReview>("instances", Instances);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessReviewDecision>("myDecisions", MyDecisions);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Identity>("reviewedEntity", ReviewedEntity);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AccessReviewReviewer>("reviewers", Reviewers);
            writer.WriteStringValue("reviewerType", ReviewerType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AccessReviewSettings>("settings", Settings);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
        }
    }
}
#pragma warning restore CS0618
