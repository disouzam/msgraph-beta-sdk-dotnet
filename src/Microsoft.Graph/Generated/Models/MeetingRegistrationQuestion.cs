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
    public partial class MeetingRegistrationQuestion : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Answer input type of the custom registration question.</summary>
        public global::Microsoft.Graph.Beta.Models.AnswerInputType? AnswerInputType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AnswerInputType?>("answerInputType"); }
            set { BackingStore?.Set("answerInputType", value); }
        }
        /// <summary>Answer options when answerInputType is radioButton.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AnswerOptions
        {
            get { return BackingStore?.Get<List<string>?>("answerOptions"); }
            set { BackingStore?.Set("answerOptions", value); }
        }
#nullable restore
#else
        public List<string> AnswerOptions
        {
            get { return BackingStore?.Get<List<string>>("answerOptions"); }
            set { BackingStore?.Set("answerOptions", value); }
        }
#endif
        /// <summary>Display name of the custom registration question.</summary>
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
        /// <summary>Indicates whether the question is required. Default value is false.</summary>
        public bool? IsRequired
        {
            get { return BackingStore?.Get<bool?>("isRequired"); }
            set { BackingStore?.Set("isRequired", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MeetingRegistrationQuestion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MeetingRegistrationQuestion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MeetingRegistrationQuestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "answerInputType", n => { AnswerInputType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AnswerInputType>(); } },
                { "answerOptions", n => { AnswerOptions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isRequired", n => { IsRequired = n.GetBoolValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AnswerInputType>("answerInputType", AnswerInputType);
            writer.WriteCollectionOfPrimitiveValues<string>("answerOptions", AnswerOptions);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isRequired", IsRequired);
        }
    }
}
#pragma warning restore CS0618
