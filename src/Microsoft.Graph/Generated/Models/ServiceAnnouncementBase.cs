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
    public partial class ServiceAnnouncementBase : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Extra details about service event. This property doesn&apos;t support filters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.KeyValuePair>? Details
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyValuePair>?>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.KeyValuePair> Details
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyValuePair>>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#endif
        /// <summary>The end time of the service event.</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The last modified time of the service event.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The start time of the service event.</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The title of the service event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title
        {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title
        {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ServiceAnnouncementBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ServiceAnnouncementBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.serviceHealthIssue" => new global::Microsoft.Graph.Beta.Models.ServiceHealthIssue(),
                "#microsoft.graph.serviceUpdateMessage" => new global::Microsoft.Graph.Beta.Models.ServiceUpdateMessage(),
                _ => new global::Microsoft.Graph.Beta.Models.ServiceAnnouncementBase(),
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
                { "details", n => { Details = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyValuePair>(global::Microsoft.Graph.Beta.Models.KeyValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyValuePair>("details", Details);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("title", Title);
        }
    }
}
#pragma warning restore CS0618
