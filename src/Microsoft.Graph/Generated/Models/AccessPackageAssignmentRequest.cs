using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class AccessPackageAssignmentRequest : Entity, IParsable {
        /// <summary>The access package associated with the accessPackageAssignmentRequest. An access package defines the collections of resource roles and the policies for how one or more users can get access to those resources. Read-only. Nullable. Supports $expand.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackage AccessPackage {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackage>(nameof(AccessPackage)); }
            set { BackingStore?.Set(nameof(AccessPackage), value); }
        }
        /// <summary>For a requestType of UserAdd or AdminAdd, this is an access package assignment requested to be created.  For a requestType of UserRemove, AdminRemove or SystemRemove, this has the id property of an existing assignment to be removed.  Supports $expand.</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageAssignment AccessPackageAssignment {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageAssignment>(nameof(AccessPackageAssignment)); }
            set { BackingStore?.Set(nameof(AccessPackageAssignment), value); }
        }
        /// <summary>Answers provided by the requestor to accessPackageQuestions asked of them at the time of request.</summary>
        public List<AccessPackageAnswer> Answers {
            get { return BackingStore?.Get<List<AccessPackageAnswer>>(nameof(Answers)); }
            set { BackingStore?.Set(nameof(Answers), value); }
        }
        /// <summary>The date of the end of processing, either successful or failure, of a request. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CompletedDate {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CompletedDate)); }
            set { BackingStore?.Set(nameof(CompletedDate), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>A collection of custom workflow extension instances being run on an assignment request. Read-only.</summary>
        public List<CustomExtensionHandlerInstance> CustomExtensionHandlerInstances {
            get { return BackingStore?.Get<List<CustomExtensionHandlerInstance>>(nameof(CustomExtensionHandlerInstances)); }
            set { BackingStore?.Set(nameof(CustomExtensionHandlerInstances), value); }
        }
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExpirationDateTime)); }
            set { BackingStore?.Set(nameof(ExpirationDateTime), value); }
        }
        /// <summary>True if the request is not to be processed for assignment.</summary>
        public bool? IsValidationOnly {
            get { return BackingStore?.Get<bool?>(nameof(IsValidationOnly)); }
            set { BackingStore?.Set(nameof(IsValidationOnly), value); }
        }
        /// <summary>The requestor&apos;s supplied justification.</summary>
        public string Justification {
            get { return BackingStore?.Get<string>(nameof(Justification)); }
            set { BackingStore?.Set(nameof(Justification), value); }
        }
        /// <summary>The subject who requested or, if a direct assignment, was assigned. Read-only. Nullable. Supports $expand.</summary>
        public AccessPackageSubject Requestor {
            get { return BackingStore?.Get<AccessPackageSubject>(nameof(Requestor)); }
            set { BackingStore?.Set(nameof(Requestor), value); }
        }
        /// <summary>One of PendingApproval, Canceled,  Denied, Delivering, Delivered, PartiallyDelivered, DeliveryFailed, Submitted or Scheduled. Read-only.</summary>
        public string RequestState {
            get { return BackingStore?.Get<string>(nameof(RequestState)); }
            set { BackingStore?.Set(nameof(RequestState), value); }
        }
        /// <summary>More information on the request processing status. Read-only.</summary>
        public string RequestStatus {
            get { return BackingStore?.Get<string>(nameof(RequestStatus)); }
            set { BackingStore?.Set(nameof(RequestStatus), value); }
        }
        /// <summary>One of UserAdd, UserRemove, AdminAdd, AdminRemove or SystemRemove. A request from the user themselves would have requestType of UserAdd or UserRemove. Read-only.</summary>
        public string RequestType {
            get { return BackingStore?.Get<string>(nameof(RequestType)); }
            set { BackingStore?.Set(nameof(RequestType), value); }
        }
        /// <summary>The range of dates that access is to be assigned to the requestor. Read-only.</summary>
        public RequestSchedule Schedule {
            get { return BackingStore?.Get<RequestSchedule>(nameof(Schedule)); }
            set { BackingStore?.Set(nameof(Schedule), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageAssignmentRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackage", n => { AccessPackage = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackage>(Microsoft.Graph.Beta.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                {"accessPackageAssignment", n => { AccessPackageAssignment = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageAssignment>(Microsoft.Graph.Beta.Models.AccessPackageAssignment.CreateFromDiscriminatorValue); } },
                {"answers", n => { Answers = n.GetCollectionOfObjectValues<AccessPackageAnswer>(AccessPackageAnswer.CreateFromDiscriminatorValue).ToList(); } },
                {"completedDate", n => { CompletedDate = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customExtensionHandlerInstances", n => { CustomExtensionHandlerInstances = n.GetCollectionOfObjectValues<CustomExtensionHandlerInstance>(CustomExtensionHandlerInstance.CreateFromDiscriminatorValue).ToList(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"isValidationOnly", n => { IsValidationOnly = n.GetBoolValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"requestor", n => { Requestor = n.GetObjectValue<AccessPackageSubject>(AccessPackageSubject.CreateFromDiscriminatorValue); } },
                {"requestState", n => { RequestState = n.GetStringValue(); } },
                {"requestStatus", n => { RequestStatus = n.GetStringValue(); } },
                {"requestType", n => { RequestType = n.GetStringValue(); } },
                {"schedule", n => { Schedule = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageAssignment>("accessPackageAssignment", AccessPackageAssignment);
            writer.WriteCollectionOfObjectValues<AccessPackageAnswer>("answers", Answers);
            writer.WriteDateTimeOffsetValue("completedDate", CompletedDate);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<CustomExtensionHandlerInstance>("customExtensionHandlerInstances", CustomExtensionHandlerInstances);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<AccessPackageSubject>("requestor", Requestor);
            writer.WriteStringValue("requestState", RequestState);
            writer.WriteStringValue("requestStatus", RequestStatus);
            writer.WriteStringValue("requestType", RequestType);
            writer.WriteObjectValue<RequestSchedule>("schedule", Schedule);
        }
    }
}
