// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The DeviceManagementConfigurationPolicyAssignment entity assigns a specific DeviceManagementConfigurationPolicy to an AAD group.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DeviceManagementConfigurationPolicyAssignment : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Represents source of assignment.</summary>
        public global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentSource? Source
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>The identifier of the source of the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceId
        {
            get { return BackingStore?.Get<string?>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
#nullable restore
#else
        public string SourceId
        {
            get { return BackingStore?.Get<string>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
#endif
        /// <summary>The assignment target for the DeviceManagementConfigurationPolicy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget? Target
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget Target
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicyAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicyAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagementConfigurationPolicyAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "source", n => { Source = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentSource>(); } },
                { "sourceId", n => { SourceId = n.GetStringValue(); } },
                { "target", n => { Target = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget>(global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentSource>("source", Source);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
#pragma warning restore CS0618
