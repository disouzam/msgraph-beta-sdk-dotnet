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
    public partial class CustomExtensionHandler : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates which custom workflow extension is executed at this stage. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension? CustomExtension
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension?>("customExtension"); }
            set { BackingStore?.Set("customExtension", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension CustomExtension
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension>("customExtension"); }
            set { BackingStore?.Set("customExtension", value); }
        }
#endif
        /// <summary>Indicates the stage of the access package assignment request workflow when the access package custom extension runs. The possible values are: assignmentRequestCreated, assignmentRequestApproved, assignmentRequestGranted, assignmentRequestRemoved, assignmentFourteenDaysBeforeExpiration, assignmentOneDayBeforeExpiration, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.AccessPackageCustomExtensionStage? Stage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackageCustomExtensionStage?>("stage"); }
            set { BackingStore?.Set("stage", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CustomExtensionHandler"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CustomExtensionHandler CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CustomExtensionHandler();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "customExtension", n => { CustomExtension = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension>(global::Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension.CreateFromDiscriminatorValue); } },
                { "stage", n => { Stage = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AccessPackageCustomExtensionStage>(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CustomAccessPackageWorkflowExtension>("customExtension", CustomExtension);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AccessPackageCustomExtensionStage>("stage", Stage);
        }
    }
}
#pragma warning restore CS0618
