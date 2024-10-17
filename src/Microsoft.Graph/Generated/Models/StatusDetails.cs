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
    public partial class StatusDetails : global::Microsoft.Graph.Beta.Models.StatusBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Additional details if there is an error.</summary>
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
        /// <summary>Categorizes the error code. Possible values are Failure, NonServiceFailure, Success.</summary>
        public global::Microsoft.Graph.Beta.Models.ProvisioningStatusErrorCategory? ErrorCategory
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ProvisioningStatusErrorCategory?>("errorCategory"); }
            set { BackingStore?.Set("errorCategory", value); }
        }
        /// <summary>Unique error code if any occurred. Learn more</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorCode
        {
            get { return BackingStore?.Get<string?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
#nullable restore
#else
        public string ErrorCode
        {
            get { return BackingStore?.Get<string>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
#endif
        /// <summary>Summarizes the status and describes why the status happened.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason
        {
            get { return BackingStore?.Get<string?>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#nullable restore
#else
        public string Reason
        {
            get { return BackingStore?.Get<string>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#endif
        /// <summary>Provides the resolution for the corresponding error.</summary>
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
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.StatusDetails"/> and sets the default values.
        /// </summary>
        public StatusDetails() : base()
        {
            OdataType = "#microsoft.graph.statusDetails";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.StatusDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.StatusDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.StatusDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalDetails", n => { AdditionalDetails = n.GetStringValue(); } },
                { "errorCategory", n => { ErrorCategory = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ProvisioningStatusErrorCategory>(); } },
                { "errorCode", n => { ErrorCode = n.GetStringValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "recommendedAction", n => { RecommendedAction = n.GetStringValue(); } },
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
            writer.WriteStringValue("additionalDetails", AdditionalDetails);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ProvisioningStatusErrorCategory>("errorCategory", ErrorCategory);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("recommendedAction", RecommendedAction);
        }
    }
}
#pragma warning restore CS0618
