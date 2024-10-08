// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class FileEvidence : global::Microsoft.Graph.Beta.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The status of the detection.The possible values are: detected, blocked, prevented, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.Security.DetectionStatus? DetectionStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.DetectionStatus?>("detectionStatus"); }
            set { BackingStore?.Set("detectionStatus", value); }
        }
        /// <summary>The file details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.FileDetails? FileDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.FileDetails?>("fileDetails"); }
            set { BackingStore?.Set("fileDetails", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.FileDetails FileDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.FileDetails>("fileDetails"); }
            set { BackingStore?.Set("fileDetails", value); }
        }
#endif
        /// <summary>A unique identifier assigned to a device by Microsoft Defender for Endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MdeDeviceId
        {
            get { return BackingStore?.Get<string?>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
#nullable restore
#else
        public string MdeDeviceId
        {
            get { return BackingStore?.Get<string>("mdeDeviceId"); }
            set { BackingStore?.Set("mdeDeviceId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Security.FileEvidence"/> and sets the default values.
        /// </summary>
        public FileEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.fileEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.FileEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.FileEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.FileEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "detectionStatus", n => { DetectionStatus = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Security.DetectionStatus>(); } },
                { "fileDetails", n => { FileDetails = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.FileDetails>(global::Microsoft.Graph.Beta.Models.Security.FileDetails.CreateFromDiscriminatorValue); } },
                { "mdeDeviceId", n => { MdeDeviceId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Security.DetectionStatus>("detectionStatus", DetectionStatus);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.FileDetails>("fileDetails", FileDetails);
            writer.WriteStringValue("mdeDeviceId", MdeDeviceId);
        }
    }
}
#pragma warning restore CS0618
