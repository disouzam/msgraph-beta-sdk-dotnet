// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class ParticipantEndpoint : global::Microsoft.Graph.Beta.Models.CallRecords.Endpoint, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Identity associated with the endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Identity? AssociatedIdentity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Identity?>("associatedIdentity"); }
            set { BackingStore?.Set("associatedIdentity", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Identity AssociatedIdentity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Identity>("associatedIdentity"); }
            set { BackingStore?.Set("associatedIdentity", value); }
        }
#endif
        /// <summary>CPU number of cores used by the media endpoint.</summary>
        public int? CpuCoresCount
        {
            get { return BackingStore?.Get<int?>("cpuCoresCount"); }
            set { BackingStore?.Set("cpuCoresCount", value); }
        }
        /// <summary>CPU name used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CpuName
        {
            get { return BackingStore?.Get<string?>("cpuName"); }
            set { BackingStore?.Set("cpuName", value); }
        }
#nullable restore
#else
        public string CpuName
        {
            get { return BackingStore?.Get<string>("cpuName"); }
            set { BackingStore?.Set("cpuName", value); }
        }
#endif
        /// <summary>CPU processor speed used by the media endpoint.</summary>
        public int? CpuProcessorSpeedInMhz
        {
            get { return BackingStore?.Get<int?>("cpuProcessorSpeedInMhz"); }
            set { BackingStore?.Set("cpuProcessorSpeedInMhz", value); }
        }
        /// <summary>The feedback provided by the user of this endpoint about the quality of the session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CallRecords.UserFeedback? Feedback
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CallRecords.UserFeedback?>("feedback"); }
            set { BackingStore?.Set("feedback", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CallRecords.UserFeedback Feedback
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CallRecords.UserFeedback>("feedback"); }
            set { BackingStore?.Set("feedback", value); }
        }
#endif
        /// <summary>Identity associated with the endpoint. The identity property is deprecated and will stop returning data on June 30, 2026. Going forward, use the associatedIdentity property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentitySet? Identity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentitySet Identity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
        /// <summary>Name of the device used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CallRecords.ParticipantEndpoint"/> and sets the default values.
        /// </summary>
        public ParticipantEndpoint() : base()
        {
            OdataType = "#microsoft.graph.callRecords.participantEndpoint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CallRecords.ParticipantEndpoint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CallRecords.ParticipantEndpoint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CallRecords.ParticipantEndpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "associatedIdentity", n => { AssociatedIdentity = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Identity>(global::Microsoft.Graph.Beta.Models.Identity.CreateFromDiscriminatorValue); } },
                { "cpuCoresCount", n => { CpuCoresCount = n.GetIntValue(); } },
                { "cpuName", n => { CpuName = n.GetStringValue(); } },
                { "cpuProcessorSpeedInMhz", n => { CpuProcessorSpeedInMhz = n.GetIntValue(); } },
                { "feedback", n => { Feedback = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CallRecords.UserFeedback>(global::Microsoft.Graph.Beta.Models.CallRecords.UserFeedback.CreateFromDiscriminatorValue); } },
                { "identity", n => { Identity = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>(global::Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Identity>("associatedIdentity", AssociatedIdentity);
            writer.WriteIntValue("cpuCoresCount", CpuCoresCount);
            writer.WriteStringValue("cpuName", CpuName);
            writer.WriteIntValue("cpuProcessorSpeedInMhz", CpuProcessorSpeedInMhz);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CallRecords.UserFeedback>("feedback", Feedback);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>("identity", Identity);
            writer.WriteStringValue("name", Name);
        }
    }
}
#pragma warning restore CS0618
