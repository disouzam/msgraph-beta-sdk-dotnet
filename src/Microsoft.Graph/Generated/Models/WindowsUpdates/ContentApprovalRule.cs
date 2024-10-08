// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class ContentApprovalRule : global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChangeRule, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A filter to determine which content matches the rule on an ongoing basis.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.ContentFilter? ContentFilter
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ContentFilter?>("contentFilter"); }
            set { BackingStore?.Set("contentFilter", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.ContentFilter ContentFilter
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ContentFilter>("contentFilter"); }
            set { BackingStore?.Set("contentFilter", value); }
        }
#endif
        /// <summary>The time before the deployment starts represented in ISO 8601 format for durations.</summary>
        public TimeSpan? DurationBeforeDeploymentStart
        {
            get { return BackingStore?.Get<TimeSpan?>("durationBeforeDeploymentStart"); }
            set { BackingStore?.Set("durationBeforeDeploymentStart", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.ContentApprovalRule"/> and sets the default values.
        /// </summary>
        public ContentApprovalRule() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdates.contentApprovalRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.ContentApprovalRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WindowsUpdates.ContentApprovalRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsUpdates.ContentApprovalRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "contentFilter", n => { ContentFilter = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ContentFilter>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.ContentFilter.CreateFromDiscriminatorValue); } },
                { "durationBeforeDeploymentStart", n => { DurationBeforeDeploymentStart = n.GetTimeSpanValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ContentFilter>("contentFilter", ContentFilter);
            writer.WriteTimeSpanValue("durationBeforeDeploymentStart", DurationBeforeDeploymentStart);
        }
    }
}
#pragma warning restore CS0618
