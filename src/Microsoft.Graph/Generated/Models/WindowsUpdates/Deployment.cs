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
    public partial class Deployment : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies the audience to which content is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience? Audience
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience?>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience Audience
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
#endif
        /// <summary>Specifies what content to deploy. Cannot be changed. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent? Content
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent Content
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>The date and time the deployment was created. Returned by default. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date and time the deployment was last modified. Returned by default. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Settings specified on the specific deployment governing how to deploy content. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings? Settings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings Settings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Execution status of the deployment. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentState? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentState State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentState>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "audience", n => { Audience = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience.CreateFromDiscriminatorValue); } },
                { "content", n => { Content = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "settings", n => { Settings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentState>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentState.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience>("audience", Audience);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeployableContent>("content", Content);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>("settings", Settings);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentState>("state", State);
        }
    }
}
#pragma warning restore CS0618
