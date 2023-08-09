// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class WorkloadActionDeploymentStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The unique identifier for the workload action. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionId {
            get { return BackingStore?.Get<string?>("actionId"); }
            set { BackingStore?.Set("actionId", value); }
        }
#nullable restore
#else
        public string ActionId {
            get { return BackingStore?.Get<string>("actionId"); }
            set { BackingStore?.Set("actionId", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The identifier of any policy that was created by applying the workload action. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeployedPolicyId {
            get { return BackingStore?.Get<string?>("deployedPolicyId"); }
            set { BackingStore?.Set("deployedPolicyId", value); }
        }
#nullable restore
#else
        public string DeployedPolicyId {
            get { return BackingStore?.Get<string>("deployedPolicyId"); }
            set { BackingStore?.Set("deployedPolicyId", value); }
        }
#endif
        /// <summary>The detailed information for exceptions that occur when deploying the workload action. Optional. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.GenericError? Error {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.GenericError?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.GenericError Error {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.GenericError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#endif
        /// <summary>The excludeGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludeGroups {
            get { return BackingStore?.Get<List<string>?>("excludeGroups"); }
            set { BackingStore?.Set("excludeGroups", value); }
        }
#nullable restore
#else
        public List<string> ExcludeGroups {
            get { return BackingStore?.Get<List<string>>("excludeGroups"); }
            set { BackingStore?.Set("excludeGroups", value); }
        }
#endif
        /// <summary>The includeAllUsers property</summary>
        public bool? IncludeAllUsers {
            get { return BackingStore?.Get<bool?>("includeAllUsers"); }
            set { BackingStore?.Set("includeAllUsers", value); }
        }
        /// <summary>The includeGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncludeGroups {
            get { return BackingStore?.Get<List<string>?>("includeGroups"); }
            set { BackingStore?.Set("includeGroups", value); }
        }
#nullable restore
#else
        public List<string> IncludeGroups {
            get { return BackingStore?.Get<List<string>>("includeGroups"); }
            set { BackingStore?.Set("includeGroups", value); }
        }
#endif
        /// <summary>The date and time the workload action was last deployed. Optional.</summary>
        public DateTimeOffset? LastDeploymentDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastDeploymentDateTime"); }
            set { BackingStore?.Set("lastDeploymentDateTime", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The status property</summary>
        public WorkloadActionStatus? Status {
            get { return BackingStore?.Get<WorkloadActionStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new workloadActionDeploymentStatus and sets the default values.
        /// </summary>
        public WorkloadActionDeploymentStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkloadActionDeploymentStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkloadActionDeploymentStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionId", n => { ActionId = n.GetStringValue(); } },
                {"deployedPolicyId", n => { DeployedPolicyId = n.GetStringValue(); } },
                {"error", n => { Error = n.GetObjectValue<Microsoft.Graph.Beta.Models.GenericError>(Microsoft.Graph.Beta.Models.GenericError.CreateFromDiscriminatorValue); } },
                {"excludeGroups", n => { ExcludeGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"includeAllUsers", n => { IncludeAllUsers = n.GetBoolValue(); } },
                {"includeGroups", n => { IncludeGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"lastDeploymentDateTime", n => { LastDeploymentDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<WorkloadActionStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionId", ActionId);
            writer.WriteStringValue("deployedPolicyId", DeployedPolicyId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.GenericError>("error", Error);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeGroups", ExcludeGroups);
            writer.WriteBoolValue("includeAllUsers", IncludeAllUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("includeGroups", IncludeGroups);
            writer.WriteDateTimeOffsetValue("lastDeploymentDateTime", LastDeploymentDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<WorkloadActionStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
