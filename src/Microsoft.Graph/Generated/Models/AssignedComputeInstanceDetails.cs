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
    public partial class AssignedComputeInstanceDetails : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents a set of S3 buckets accessed by this EC2 instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>? AccessedStorageBuckets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>?>("accessedStorageBuckets"); }
            set { BackingStore?.Set("accessedStorageBuckets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource> AccessedStorageBuckets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>>("accessedStorageBuckets"); }
            set { BackingStore?.Set("accessedStorageBuckets", value); }
        }
#endif
        /// <summary>assigned EC2 instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource? AssignedComputeInstance
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource?>("assignedComputeInstance"); }
            set { BackingStore?.Set("assignedComputeInstance", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource AssignedComputeInstance
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>("assignedComputeInstance"); }
            set { BackingStore?.Set("assignedComputeInstance", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AssignedComputeInstanceDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AssignedComputeInstanceDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AssignedComputeInstanceDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessedStorageBuckets", n => { AccessedStorageBuckets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>(global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "assignedComputeInstance", n => { AssignedComputeInstance = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>(global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>("accessedStorageBuckets", AccessedStorageBuckets);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>("assignedComputeInstance", AssignedComputeInstance);
        }
    }
}
#pragma warning restore CS0618
