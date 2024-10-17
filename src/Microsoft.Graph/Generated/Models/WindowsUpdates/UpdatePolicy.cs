// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UpdatePolicy : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies the audience to target.</summary>
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
        /// <summary>Rules for governing the automatic creation of compliance changes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChangeRule>? ComplianceChangeRules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChangeRule>?>("complianceChangeRules"); }
            set { BackingStore?.Set("complianceChangeRules", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChangeRule> ComplianceChangeRules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChangeRule>>("complianceChangeRules"); }
            set { BackingStore?.Set("complianceChangeRules", value); }
        }
#endif
        /// <summary>Compliance changes like content approvals which result in the automatic creation of deployments using the audience and deploymentSettings of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChange>? ComplianceChanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChange>?>("complianceChanges"); }
            set { BackingStore?.Set("complianceChanges", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChange> ComplianceChanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChange>>("complianceChanges"); }
            set { BackingStore?.Set("complianceChanges", value); }
        }
#endif
        /// <summary>The date and time when the update policy was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Settings for governing how to deploy content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings? DeploymentSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings?>("deploymentSettings"); }
            set { BackingStore?.Set("deploymentSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings DeploymentSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>("deploymentSettings"); }
            set { BackingStore?.Set("deploymentSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy();
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
                { "complianceChangeRules", n => { ComplianceChangeRules = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChangeRule>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChangeRule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "complianceChanges", n => { ComplianceChanges = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChange>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChange.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deploymentSettings", n => { DeploymentSettings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChangeRule>("complianceChangeRules", ComplianceChangeRules);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ComplianceChange>("complianceChanges", ComplianceChanges);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>("deploymentSettings", DeploymentSettings);
        }
    }
}
#pragma warning restore CS0618
