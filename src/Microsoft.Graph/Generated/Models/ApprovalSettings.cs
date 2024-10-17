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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ApprovalSettings : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>One of SingleStage, Serial, Parallel, NoApproval (default). NoApproval is used when isApprovalRequired is false.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApprovalMode
        {
            get { return BackingStore?.Get<string?>("approvalMode"); }
            set { BackingStore?.Set("approvalMode", value); }
        }
#nullable restore
#else
        public string ApprovalMode
        {
            get { return BackingStore?.Get<string>("approvalMode"); }
            set { BackingStore?.Set("approvalMode", value); }
        }
#endif
        /// <summary>If approval is required, the one or two elements of this collection define each of the stages of approval. An empty array if no approval is required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ApprovalStage>? ApprovalStages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ApprovalStage>?>("approvalStages"); }
            set { BackingStore?.Set("approvalStages", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ApprovalStage> ApprovalStages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ApprovalStage>>("approvalStages"); }
            set { BackingStore?.Set("approvalStages", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether approval is required for requests in this policy.</summary>
        public bool? IsApprovalRequired
        {
            get { return BackingStore?.Get<bool?>("isApprovalRequired"); }
            set { BackingStore?.Set("isApprovalRequired", value); }
        }
        /// <summary>Indicates whether approval is required for a user to extend their assignment.</summary>
        public bool? IsApprovalRequiredForExtension
        {
            get { return BackingStore?.Get<bool?>("isApprovalRequiredForExtension"); }
            set { BackingStore?.Set("isApprovalRequiredForExtension", value); }
        }
        /// <summary>Indicates whether the requestor is required to supply a justification in their request.</summary>
        public bool? IsRequestorJustificationRequired
        {
            get { return BackingStore?.Get<bool?>("isRequestorJustificationRequired"); }
            set { BackingStore?.Set("isRequestorJustificationRequired", value); }
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
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ApprovalSettings"/> and sets the default values.
        /// </summary>
        public ApprovalSettings()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ApprovalSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.ApprovalSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ApprovalSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "approvalMode", n => { ApprovalMode = n.GetStringValue(); } },
                { "approvalStages", n => { ApprovalStages = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ApprovalStage>(global::Microsoft.Graph.Beta.Models.ApprovalStage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isApprovalRequired", n => { IsApprovalRequired = n.GetBoolValue(); } },
                { "isApprovalRequiredForExtension", n => { IsApprovalRequiredForExtension = n.GetBoolValue(); } },
                { "isRequestorJustificationRequired", n => { IsRequestorJustificationRequired = n.GetBoolValue(); } },
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
            writer.WriteStringValue("approvalMode", ApprovalMode);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ApprovalStage>("approvalStages", ApprovalStages);
            writer.WriteBoolValue("isApprovalRequired", IsApprovalRequired);
            writer.WriteBoolValue("isApprovalRequiredForExtension", IsApprovalRequiredForExtension);
            writer.WriteBoolValue("isRequestorJustificationRequired", IsRequestorJustificationRequired);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
