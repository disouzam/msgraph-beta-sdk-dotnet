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
    public partial class CloudPcServicePlan : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name for the service plan. Read-only.</summary>
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
        /// <summary>Specifies the type of license used when provisioning Cloud PCs. By default, the license type is dedicated. Possible values are: dedicated, shared, unknownFutureValue, sharedByUser, sharedByEntraGroup. You must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: sharedByUser, sharedByEntraGroup. The shared member is deprecated and will stop returning on April 30, 2027; going forward, use the sharedByUser member.</summary>
        public global::Microsoft.Graph.Beta.Models.CloudPcProvisioningType? ProvisioningType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningType?>("provisioningType"); }
            set { BackingStore?.Set("provisioningType", value); }
        }
        /// <summary>The size of the RAM in GB. Read-only.</summary>
        public int? RamInGB
        {
            get { return BackingStore?.Get<int?>("ramInGB"); }
            set { BackingStore?.Set("ramInGB", value); }
        }
        /// <summary>The size of the OS Disk in GB. Read-only.</summary>
        public int? StorageInGB
        {
            get { return BackingStore?.Get<int?>("storageInGB"); }
            set { BackingStore?.Set("storageInGB", value); }
        }
        /// <summary>The supportedSolution property</summary>
        public global::Microsoft.Graph.Beta.Models.CloudPcManagementService? SupportedSolution
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcManagementService?>("supportedSolution"); }
            set { BackingStore?.Set("supportedSolution", value); }
        }
        /// <summary>The type of the service plan. Possible values are: enterprise, business, unknownFutureValue. Read-only.</summary>
        public global::Microsoft.Graph.Beta.Models.CloudPcServicePlanType? Type
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcServicePlanType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>The size of the user profile disk in GB. Read-only.</summary>
        public int? UserProfileInGB
        {
            get { return BackingStore?.Get<int?>("userProfileInGB"); }
            set { BackingStore?.Set("userProfileInGB", value); }
        }
        /// <summary>The number of vCPUs. Read-only.</summary>
        public int? VCpuCount
        {
            get { return BackingStore?.Get<int?>("vCpuCount"); }
            set { BackingStore?.Set("vCpuCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPcServicePlan"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CloudPcServicePlan CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CloudPcServicePlan();
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
                { "provisioningType", n => { ProvisioningType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningType>(); } },
                { "ramInGB", n => { RamInGB = n.GetIntValue(); } },
                { "storageInGB", n => { StorageInGB = n.GetIntValue(); } },
                { "supportedSolution", n => { SupportedSolution = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcManagementService>(); } },
                { "type", n => { Type = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcServicePlanType>(); } },
                { "userProfileInGB", n => { UserProfileInGB = n.GetIntValue(); } },
                { "vCpuCount", n => { VCpuCount = n.GetIntValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningType>("provisioningType", ProvisioningType);
            writer.WriteIntValue("ramInGB", RamInGB);
            writer.WriteIntValue("storageInGB", StorageInGB);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcManagementService>("supportedSolution", SupportedSolution);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcServicePlanType>("type", Type);
            writer.WriteIntValue("userProfileInGB", UserProfileInGB);
            writer.WriteIntValue("vCpuCount", VCpuCount);
        }
    }
}
#pragma warning restore CS0618
