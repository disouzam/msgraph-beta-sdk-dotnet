// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class VirtualEventRegistrationConfiguration : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Total capacity of the virtual event.</summary>
        public int? Capacity
        {
            get { return BackingStore?.Get<int?>("capacity"); }
            set { BackingStore?.Set("capacity", value); }
        }
        /// <summary>Registration questions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionBase>? Questions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionBase>?>("questions"); }
            set { BackingStore?.Set("questions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionBase> Questions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionBase>>("questions"); }
            set { BackingStore?.Set("questions", value); }
        }
#endif
        /// <summary>Registration URL of the virtual event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistrationWebUrl
        {
            get { return BackingStore?.Get<string?>("registrationWebUrl"); }
            set { BackingStore?.Set("registrationWebUrl", value); }
        }
#nullable restore
#else
        public string RegistrationWebUrl
        {
            get { return BackingStore?.Get<string>("registrationWebUrl"); }
            set { BackingStore?.Set("registrationWebUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.virtualEventWebinarRegistrationConfiguration" => new global::Microsoft.Graph.Beta.Models.VirtualEventWebinarRegistrationConfiguration(),
                _ => new global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "capacity", n => { Capacity = n.GetIntValue(); } },
                { "questions", n => { Questions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionBase>(global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "registrationWebUrl", n => { RegistrationWebUrl = n.GetStringValue(); } },
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
            writer.WriteIntValue("capacity", Capacity);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VirtualEventRegistrationQuestionBase>("questions", Questions);
            writer.WriteStringValue("registrationWebUrl", RegistrationWebUrl);
        }
    }
}
#pragma warning restore CS0618
