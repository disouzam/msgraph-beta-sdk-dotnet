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
    /// Singleton entity which represents the Exchange OnPremises Conditional Access Settings for a tenant.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OnPremisesConditionalAccessSettings : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Indicates if on premises conditional access is enabled for this organization</summary>
        public bool? Enabled
        {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? ExcludedGroups
        {
            get { return BackingStore?.Get<List<Guid?>?>("excludedGroups"); }
            set { BackingStore?.Set("excludedGroups", value); }
        }
#nullable restore
#else
        public List<Guid?> ExcludedGroups
        {
            get { return BackingStore?.Get<List<Guid?>>("excludedGroups"); }
            set { BackingStore?.Set("excludedGroups", value); }
        }
#endif
        /// <summary>User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? IncludedGroups
        {
            get { return BackingStore?.Get<List<Guid?>?>("includedGroups"); }
            set { BackingStore?.Set("includedGroups", value); }
        }
#nullable restore
#else
        public List<Guid?> IncludedGroups
        {
            get { return BackingStore?.Get<List<Guid?>>("includedGroups"); }
            set { BackingStore?.Set("includedGroups", value); }
        }
#endif
        /// <summary>Override the default access rule when allowing a device to ensure access is granted.</summary>
        public bool? OverrideDefaultRule
        {
            get { return BackingStore?.Get<bool?>("overrideDefaultRule"); }
            set { BackingStore?.Set("overrideDefaultRule", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OnPremisesConditionalAccessSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.OnPremisesConditionalAccessSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.OnPremisesConditionalAccessSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "excludedGroups", n => { ExcludedGroups = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "includedGroups", n => { IncludedGroups = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
                { "overrideDefaultRule", n => { OverrideDefaultRule = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("excludedGroups", ExcludedGroups);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("includedGroups", IncludedGroups);
            writer.WriteBoolValue("overrideDefaultRule", OverrideDefaultRule);
        }
    }
}
#pragma warning restore CS0618
