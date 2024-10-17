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
    public partial class ApprovalItemResponse : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The comment made by the approver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comments
        {
            get { return BackingStore?.Get<string?>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
#nullable restore
#else
        public string Comments
        {
            get { return BackingStore?.Get<string>("comments"); }
            set { BackingStore?.Set("comments", value); }
        }
#endif
        /// <summary>The identity set of the approver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Creation date and time of the response.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The identity set of the principal who owns the approval item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet>? Owners
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet>?>("owners"); }
            set { BackingStore?.Set("owners", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet> Owners
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet>>("owners"); }
            set { BackingStore?.Set("owners", value); }
        }
#endif
        /// <summary>Approver response based on the response options. The default response options are &apos;Approved&apos; and &apos;Rejected&apos;. The approval item creator can also define custom response options during approval item creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Response
        {
            get { return BackingStore?.Get<string?>("response"); }
            set { BackingStore?.Set("response", value); }
        }
#nullable restore
#else
        public string Response
        {
            get { return BackingStore?.Get<string>("response"); }
            set { BackingStore?.Set("response", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ApprovalItemResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ApprovalItemResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ApprovalItemResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "comments", n => { Comments = n.GetStringValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet>(global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "owners", n => { Owners = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet>(global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "response", n => { Response = n.GetStringValue(); } },
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
            writer.WriteStringValue("comments", Comments);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ApprovalIdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("response", Response);
        }
    }
}
#pragma warning restore CS0618
