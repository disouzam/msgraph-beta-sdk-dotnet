// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Policy used to configure detailed management settings targeted to specific security groups
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class TargetedManagedAppProtection : global::Microsoft.Graph.Beta.Models.ManagedAppProtection, IParsable
    {
        /// <summary>Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps</summary>
        public global::Microsoft.Graph.Beta.Models.TargetedManagedAppGroupType? AppGroupType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TargetedManagedAppGroupType?>("appGroupType"); }
            set { BackingStore?.Set("appGroupType", value); }
        }
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.TargetedManagedAppPolicyAssignment>? Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.TargetedManagedAppPolicyAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.TargetedManagedAppPolicyAssignment> Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.TargetedManagedAppPolicyAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Indicates if the policy is deployed to any inclusion groups or not.</summary>
        public bool? IsAssigned
        {
            get { return BackingStore?.Get<bool?>("isAssigned"); }
            set { BackingStore?.Set("isAssigned", value); }
        }
        /// <summary>Management levels for apps</summary>
        public global::Microsoft.Graph.Beta.Models.AppManagementLevel? TargetedAppManagementLevels
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AppManagementLevel?>("targetedAppManagementLevels"); }
            set { BackingStore?.Set("targetedAppManagementLevels", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.TargetedManagedAppProtection"/> and sets the default values.
        /// </summary>
        public TargetedManagedAppProtection() : base()
        {
            OdataType = "#microsoft.graph.targetedManagedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TargetedManagedAppProtection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.TargetedManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidManagedAppProtection" => new global::Microsoft.Graph.Beta.Models.AndroidManagedAppProtection(),
                "#microsoft.graph.iosManagedAppProtection" => new global::Microsoft.Graph.Beta.Models.IosManagedAppProtection(),
                _ => new global::Microsoft.Graph.Beta.Models.TargetedManagedAppProtection(),
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
                { "appGroupType", n => { AppGroupType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.TargetedManagedAppGroupType>(); } },
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.TargetedManagedAppPolicyAssignment>(global::Microsoft.Graph.Beta.Models.TargetedManagedAppPolicyAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                { "targetedAppManagementLevels", n => { TargetedAppManagementLevels = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AppManagementLevel>(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.TargetedManagedAppGroupType>("appGroupType", AppGroupType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AppManagementLevel>("targetedAppManagementLevels", TargetedAppManagementLevels);
        }
    }
}
#pragma warning restore CS0618
