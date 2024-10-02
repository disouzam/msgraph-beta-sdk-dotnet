// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class AuthenticationFailure : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The count property</summary>
        public long? Count
        {
            get { return BackingStore?.Get<long?>("count"); }
            set { BackingStore?.Set("count", value); }
        }
        /// <summary>The reason property</summary>
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
        /// <summary>The reasonCode property</summary>
        public global::Microsoft.Graph.Beta.Models.AuthenticationFailureReasonCode? ReasonCode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationFailureReasonCode?>("reasonCode"); }
            set { BackingStore?.Set("reasonCode", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AuthenticationFailure"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AuthenticationFailure CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AuthenticationFailure();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "count", n => { Count = n.GetLongValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "reasonCode", n => { ReasonCode = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AuthenticationFailureReasonCode>(); } },
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
            writer.WriteLongValue("count", Count);
            writer.WriteStringValue("reason", Reason);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AuthenticationFailureReasonCode>("reasonCode", ReasonCode);
        }
    }
}
#pragma warning restore CS0618
