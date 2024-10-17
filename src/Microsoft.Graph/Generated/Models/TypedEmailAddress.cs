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
    public partial class TypedEmailAddress : global::Microsoft.Graph.Beta.Models.EmailAddress, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>To specify a custom type of email address, set type to other, and assign otherLabel to a custom string. For example, you may use a specific email address for your volunteer activities. Set type to other, and set otherLabel to a custom string such as Volunteer work.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OtherLabel
        {
            get { return BackingStore?.Get<string?>("otherLabel"); }
            set { BackingStore?.Set("otherLabel", value); }
        }
#nullable restore
#else
        public string OtherLabel
        {
            get { return BackingStore?.Get<string>("otherLabel"); }
            set { BackingStore?.Set("otherLabel", value); }
        }
#endif
        /// <summary>The type of email address. Possible values are: unknown, work, personal, main, other. The default value is unknown, which means address has not been set as a specific type.</summary>
        public global::Microsoft.Graph.Beta.Models.EmailType? Type
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EmailType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.TypedEmailAddress"/> and sets the default values.
        /// </summary>
        public TypedEmailAddress() : base()
        {
            OdataType = "#microsoft.graph.typedEmailAddress";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TypedEmailAddress"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.TypedEmailAddress CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.TypedEmailAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "otherLabel", n => { OtherLabel = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.EmailType>(); } },
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
            writer.WriteStringValue("otherLabel", OtherLabel);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.EmailType>("type", Type);
        }
    }
}
#pragma warning restore CS0618
