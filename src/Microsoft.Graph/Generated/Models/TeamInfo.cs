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
    public partial class TeamInfo : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the team.</summary>
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
        /// <summary>The team property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Team? Team
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Team?>("team"); }
            set { BackingStore?.Set("team", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Team Team
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Team>("team"); }
            set { BackingStore?.Set("team", value); }
        }
#endif
        /// <summary>The ID of the Microsoft Entra tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId
        {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId
        {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TeamInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.TeamInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.associatedTeamInfo" => new global::Microsoft.Graph.Beta.Models.AssociatedTeamInfo(),
                "#microsoft.graph.sharedWithChannelTeamInfo" => new global::Microsoft.Graph.Beta.Models.SharedWithChannelTeamInfo(),
                _ => new global::Microsoft.Graph.Beta.Models.TeamInfo(),
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
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "team", n => { Team = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Team>(global::Microsoft.Graph.Beta.Models.Team.CreateFromDiscriminatorValue); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Team>("team", Team);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
#pragma warning restore CS0618
