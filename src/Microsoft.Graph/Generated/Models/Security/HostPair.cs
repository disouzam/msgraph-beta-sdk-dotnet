// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class HostPair : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The childHost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.Host? ChildHost
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.Host?>("childHost"); }
            set { BackingStore?.Set("childHost", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.Host ChildHost
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.Host>("childHost"); }
            set { BackingStore?.Set("childHost", value); }
        }
#endif
        /// <summary>The first date and time when Microsoft Defender Threat Intelligence observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The last date and time when Microsoft Defender Threat Intelligence observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The reason that two hosts are identified as hostPair.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LinkKind
        {
            get { return BackingStore?.Get<string?>("linkKind"); }
            set { BackingStore?.Set("linkKind", value); }
        }
#nullable restore
#else
        public string LinkKind
        {
            get { return BackingStore?.Get<string>("linkKind"); }
            set { BackingStore?.Set("linkKind", value); }
        }
#endif
        /// <summary>The parentHost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.Host? ParentHost
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.Host?>("parentHost"); }
            set { BackingStore?.Set("parentHost", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.Host ParentHost
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.Host>("parentHost"); }
            set { BackingStore?.Set("parentHost", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.HostPair"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.HostPair CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.HostPair();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "childHost", n => { ChildHost = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.Host>(global::Microsoft.Graph.Beta.Models.Security.Host.CreateFromDiscriminatorValue); } },
                { "firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "linkKind", n => { LinkKind = n.GetStringValue(); } },
                { "parentHost", n => { ParentHost = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.Host>(global::Microsoft.Graph.Beta.Models.Security.Host.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.Host>("childHost", ChildHost);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("linkKind", LinkKind);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.Host>("parentHost", ParentHost);
        }
    }
}
#pragma warning restore CS0618
