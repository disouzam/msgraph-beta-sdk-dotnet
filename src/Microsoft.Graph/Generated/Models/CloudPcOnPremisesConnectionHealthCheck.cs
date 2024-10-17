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
    public partial class CloudPcOnPremisesConnectionHealthCheck : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>More details about the health check or the recommended action. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalDetail
        {
            get { return BackingStore?.Get<string?>("additionalDetail"); }
            set { BackingStore?.Set("additionalDetail", value); }
        }
#nullable restore
#else
        public string AdditionalDetail
        {
            get { return BackingStore?.Get<string>("additionalDetail"); }
            set { BackingStore?.Set("additionalDetail", value); }
        }
#endif
        /// <summary>More details about the health check or the recommended action. Read-only. The additionalDetails property is deprecated and stopped returning data on January 31, 2024. Goind forward, use the additionalDetail property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalDetails
        {
            get { return BackingStore?.Get<string?>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#nullable restore
#else
        public string AdditionalDetails
        {
            get { return BackingStore?.Get<string>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The unique identifier of the health check item-related activities. This identifier can be useful in troubleshooting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId
        {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId
        {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>The display name for this health check item.</summary>
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
        /// <summary>The end time of the health check item. Read-only.</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The type of error that occurred during this health check.</summary>
        public global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionHealthCheckErrorType? ErrorType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionHealthCheckErrorType?>("errorType"); }
            set { BackingStore?.Set("errorType", value); }
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
        /// <summary>The recommended action to fix the corresponding error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecommendedAction
        {
            get { return BackingStore?.Get<string?>("recommendedAction"); }
            set { BackingStore?.Set("recommendedAction", value); }
        }
#nullable restore
#else
        public string RecommendedAction
        {
            get { return BackingStore?.Get<string>("recommendedAction"); }
            set { BackingStore?.Set("recommendedAction", value); }
        }
#endif
        /// <summary>The start time of the health check item. Read-only.</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The status property</summary>
        public global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionHealthCheck"/> and sets the default values.
        /// </summary>
        public CloudPcOnPremisesConnectionHealthCheck()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionHealthCheck"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionHealthCheck CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionHealthCheck();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "additionalDetail", n => { AdditionalDetail = n.GetStringValue(); } },
                { "additionalDetails", n => { AdditionalDetails = n.GetStringValue(); } },
                { "correlationId", n => { CorrelationId = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "errorType", n => { ErrorType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionHealthCheckErrorType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "recommendedAction", n => { RecommendedAction = n.GetStringValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalDetail", AdditionalDetail);
            writer.WriteStringValue("additionalDetails", AdditionalDetails);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionHealthCheckErrorType>("errorType", ErrorType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("recommendedAction", RecommendedAction);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcOnPremisesConnectionStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
