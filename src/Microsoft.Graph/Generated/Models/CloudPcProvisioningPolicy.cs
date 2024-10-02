// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class CloudPcProvisioningPolicy : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The URL of the alternate resource that links to this provisioning policy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlternateResourceUrl
        {
            get { return BackingStore?.Get<string?>("alternateResourceUrl"); }
            set { BackingStore?.Set("alternateResourceUrl", value); }
        }
#nullable restore
#else
        public string AlternateResourceUrl
        {
            get { return BackingStore?.Get<string>("alternateResourceUrl"); }
            set { BackingStore?.Set("alternateResourceUrl", value); }
        }
#endif
        /// <summary>A defined collection of provisioning policy assignments. Represents the set of Microsoft 365 groups and security groups in Microsoft Entra ID that have provisioning policy assigned. Returned only on $expand. For an example about how to get the assignments relationship, see Get cloudPcProvisioningPolicy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAssignment>? Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAssignment> Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>The specific settings for Windows Autopatch that enable its customers to experience it on Cloud PC. The settings take effect when the tenant enrolls in Windows Autopatch and the managedType of the microsoftManagedDesktop property is set as starterManaged. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAutopatch? Autopatch
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAutopatch?>("autopatch"); }
            set { BackingStore?.Set("autopatch", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAutopatch Autopatch
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAutopatch>("autopatch"); }
            set { BackingStore?.Set("autopatch", value); }
        }
#endif
        /// <summary>The specific settings for Windows Autopilot that enable Windows 365 customers to experience it on Cloud PC. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CloudPcAutopilotConfiguration? AutopilotConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcAutopilotConfiguration?>("autopilotConfiguration"); }
            set { BackingStore?.Set("autopilotConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CloudPcAutopilotConfiguration AutopilotConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcAutopilotConfiguration>("autopilotConfiguration"); }
            set { BackingStore?.Set("autopilotConfiguration", value); }
        }
#endif
        /// <summary>The display name of the Cloud PC group that the Cloud PCs reside in. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudPcGroupDisplayName
        {
            get { return BackingStore?.Get<string?>("cloudPcGroupDisplayName"); }
            set { BackingStore?.Set("cloudPcGroupDisplayName", value); }
        }
#nullable restore
#else
        public string CloudPcGroupDisplayName
        {
            get { return BackingStore?.Get<string>("cloudPcGroupDisplayName"); }
            set { BackingStore?.Set("cloudPcGroupDisplayName", value); }
        }
#endif
        /// <summary>The template used to name Cloud PCs provisioned using this policy. The template can contain custom text and replacement tokens, including %USERNAME:x% and %RAND:x%, which represent the user&apos;s name and a randomly generated number, respectively. For example, CPC-%USERNAME:4%-%RAND:5% means that the name of the Cloud PC starts with CPC-, followed by a four-character username, a - character, and then five random characters. The total length of the text generated by the template can&apos;t exceed 15 characters. Supports $filter, $select, and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudPcNamingTemplate
        {
            get { return BackingStore?.Get<string?>("cloudPcNamingTemplate"); }
            set { BackingStore?.Set("cloudPcNamingTemplate", value); }
        }
#nullable restore
#else
        public string CloudPcNamingTemplate
        {
            get { return BackingStore?.Get<string>("cloudPcNamingTemplate"); }
            set { BackingStore?.Set("cloudPcNamingTemplate", value); }
        }
#endif
        /// <summary>The provisioning policy description. Supports $filter, $select, and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name for the provisioning policy.</summary>
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
        /// <summary>Specifies a list ordered by priority on how Cloud PCs join Microsoft Entra ID (Azure AD). Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CloudPcDomainJoinConfiguration>? DomainJoinConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CloudPcDomainJoinConfiguration>?>("domainJoinConfigurations"); }
            set { BackingStore?.Set("domainJoinConfigurations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CloudPcDomainJoinConfiguration> DomainJoinConfigurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CloudPcDomainJoinConfiguration>>("domainJoinConfigurations"); }
            set { BackingStore?.Set("domainJoinConfigurations", value); }
        }
#endif
        /// <summary>True if single sign-on can access the provisioned Cloud PC. False indicates that the provisioned Cloud PC doesn&apos;t support this feature. The default value is false. Windows 365 users can use single sign-on to authenticate to Microsoft Entra ID with passwordless options (for example, FIDO keys) to access their Cloud PC. Optional.</summary>
        public bool? EnableSingleSignOn
        {
            get { return BackingStore?.Get<bool?>("enableSingleSignOn"); }
            set { BackingStore?.Set("enableSingleSignOn", value); }
        }
        /// <summary>The number of hours to wait before reprovisioning/deprovisioning happens. Read-only.</summary>
        public int? GracePeriodInHours
        {
            get { return BackingStore?.Get<int?>("gracePeriodInHours"); }
            set { BackingStore?.Set("gracePeriodInHours", value); }
        }
        /// <summary>The display name of the operating system image that is used for provisioning. For example, Windows 11 Preview + Microsoft 365 Apps 23H2 23H2. Supports $filter, $select, and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageDisplayName
        {
            get { return BackingStore?.Get<string?>("imageDisplayName"); }
            set { BackingStore?.Set("imageDisplayName", value); }
        }
#nullable restore
#else
        public string ImageDisplayName
        {
            get { return BackingStore?.Get<string>("imageDisplayName"); }
            set { BackingStore?.Set("imageDisplayName", value); }
        }
#endif
        /// <summary>The unique identifier that represents an operating system image that is used for provisioning new Cloud PCs. The format for a gallery type image is: {publisherNameofferNameskuName}. Supported values for each of the parameters are:publisher: Microsoftwindowsdesktop offer: windows-ent-cpc sku: 21h1-ent-cpc-m365, 21h1-ent-cpc-os, 20h2-ent-cpc-m365, 20h2-ent-cpc-os, 20h1-ent-cpc-m365, 20h1-ent-cpc-os, 19h2-ent-cpc-m365, and 19h2-ent-cpc-os Supports $filter, $select, and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageId
        {
            get { return BackingStore?.Get<string?>("imageId"); }
            set { BackingStore?.Set("imageId", value); }
        }
#nullable restore
#else
        public string ImageId
        {
            get { return BackingStore?.Get<string>("imageId"); }
            set { BackingStore?.Set("imageId", value); }
        }
#endif
        /// <summary>The imageType property</summary>
        public global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyImageType? ImageType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyImageType?>("imageType"); }
            set { BackingStore?.Set("imageType", value); }
        }
        /// <summary>When true, the local admin is enabled for Cloud PCs; false indicates that the local admin isn&apos;t enabled for Cloud PCs. The default value is false. Supports $filter, $select, and $orderBy.</summary>
        public bool? LocalAdminEnabled
        {
            get { return BackingStore?.Get<bool?>("localAdminEnabled"); }
            set { BackingStore?.Set("localAdminEnabled", value); }
        }
        /// <summary>The managedBy property</summary>
        public global::Microsoft.Graph.Beta.Models.CloudPcManagementService? ManagedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcManagementService?>("managedBy"); }
            set { BackingStore?.Set("managedBy", value); }
        }
        /// <summary>The specific settings to microsoftManagedDesktop that enables Microsoft Managed Desktop customers to get device managed experience for Cloud PC. To enable microsoftManagedDesktop to provide more value, an admin needs to specify certain settings in it. Supports $filter, $select, and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop? MicrosoftManagedDesktop
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop?>("microsoftManagedDesktop"); }
            set { BackingStore?.Set("microsoftManagedDesktop", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop MicrosoftManagedDesktop
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop>("microsoftManagedDesktop"); }
            set { BackingStore?.Set("microsoftManagedDesktop", value); }
        }
#endif
        /// <summary>Specifies the type of licenses to be used when provisioning Cloud PCs using this policy. The possible values are dedicated, shared, unknownFutureValue, sharedByUser, sharedByEntraGroup. You must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: sharedByUser, sharedByEntraGroup. The shared member is deprecated and will stop returning on April 30, 2027; going forward, use the sharedByUser member. For example, a dedicated service plan can be assigned to only one user and provision only one Cloud PC. The shared and sharedByUser plans require customers to purchase a shared service plan. Each shared license purchased can enable up to three Cloud PCs, with only one user signed in at a time. The sharedByEntraGroup plan also requires the purchase of a shared service plan. Each shared license under this plan can enable one Cloud PC, which is shared for the group according to the assignments of this policy. By default, the license type is dedicated if the provisioningType isn&apos;t specified when you create the cloudPcProvisioningPolicy. You can&apos;t change this property after the cloudPcProvisioningPolicy is created.</summary>
        public global::Microsoft.Graph.Beta.Models.CloudPcProvisioningType? ProvisioningType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningType?>("provisioningType"); }
            set { BackingStore?.Set("provisioningType", value); }
        }
        /// <summary>The scopeIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ScopeIds
        {
            get { return BackingStore?.Get<List<string>?>("scopeIds"); }
            set { BackingStore?.Set("scopeIds", value); }
        }
#nullable restore
#else
        public List<string> ScopeIds
        {
            get { return BackingStore?.Get<List<string>>("scopeIds"); }
            set { BackingStore?.Set("scopeIds", value); }
        }
#endif
        /// <summary>Indicates a specific Windows setting to configure during the creation of Cloud PCs for this provisioning policy. Supports $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CloudPcWindowsSetting? WindowsSetting
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcWindowsSetting?>("windowsSetting"); }
            set { BackingStore?.Set("windowsSetting", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CloudPcWindowsSetting WindowsSetting
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcWindowsSetting>("windowsSetting"); }
            set { BackingStore?.Set("windowsSetting", value); }
        }
#endif
        /// <summary>Specific Windows settings to configure during the creation of Cloud PCs for this provisioning policy. Supports $select. The windowsSettings property is deprecated and will stop returning data on January 31, 2024. Going forward, use the windowsSetting property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CloudPcWindowsSettings? WindowsSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcWindowsSettings?>("windowsSettings"); }
            set { BackingStore?.Set("windowsSettings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CloudPcWindowsSettings WindowsSettings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudPcWindowsSettings>("windowsSettings"); }
            set { BackingStore?.Set("windowsSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alternateResourceUrl", n => { AlternateResourceUrl = n.GetStringValue(); } },
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAssignment>(global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "autopatch", n => { Autopatch = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAutopatch>(global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAutopatch.CreateFromDiscriminatorValue); } },
                { "autopilotConfiguration", n => { AutopilotConfiguration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CloudPcAutopilotConfiguration>(global::Microsoft.Graph.Beta.Models.CloudPcAutopilotConfiguration.CreateFromDiscriminatorValue); } },
                { "cloudPcGroupDisplayName", n => { CloudPcGroupDisplayName = n.GetStringValue(); } },
                { "cloudPcNamingTemplate", n => { CloudPcNamingTemplate = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "domainJoinConfigurations", n => { DomainJoinConfigurations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CloudPcDomainJoinConfiguration>(global::Microsoft.Graph.Beta.Models.CloudPcDomainJoinConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "enableSingleSignOn", n => { EnableSingleSignOn = n.GetBoolValue(); } },
                { "gracePeriodInHours", n => { GracePeriodInHours = n.GetIntValue(); } },
                { "imageDisplayName", n => { ImageDisplayName = n.GetStringValue(); } },
                { "imageId", n => { ImageId = n.GetStringValue(); } },
                { "imageType", n => { ImageType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyImageType>(); } },
                { "localAdminEnabled", n => { LocalAdminEnabled = n.GetBoolValue(); } },
                { "managedBy", n => { ManagedBy = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcManagementService>(); } },
                { "microsoftManagedDesktop", n => { MicrosoftManagedDesktop = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop>(global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop.CreateFromDiscriminatorValue); } },
                { "provisioningType", n => { ProvisioningType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningType>(); } },
                { "scopeIds", n => { ScopeIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "windowsSetting", n => { WindowsSetting = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CloudPcWindowsSetting>(global::Microsoft.Graph.Beta.Models.CloudPcWindowsSetting.CreateFromDiscriminatorValue); } },
                { "windowsSettings", n => { WindowsSettings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CloudPcWindowsSettings>(global::Microsoft.Graph.Beta.Models.CloudPcWindowsSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("alternateResourceUrl", AlternateResourceUrl);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAssignment>("assignments", Assignments);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyAutopatch>("autopatch", Autopatch);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CloudPcAutopilotConfiguration>("autopilotConfiguration", AutopilotConfiguration);
            writer.WriteStringValue("cloudPcGroupDisplayName", CloudPcGroupDisplayName);
            writer.WriteStringValue("cloudPcNamingTemplate", CloudPcNamingTemplate);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CloudPcDomainJoinConfiguration>("domainJoinConfigurations", DomainJoinConfigurations);
            writer.WriteBoolValue("enableSingleSignOn", EnableSingleSignOn);
            writer.WriteIntValue("gracePeriodInHours", GracePeriodInHours);
            writer.WriteStringValue("imageDisplayName", ImageDisplayName);
            writer.WriteStringValue("imageId", ImageId);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningPolicyImageType>("imageType", ImageType);
            writer.WriteBoolValue("localAdminEnabled", LocalAdminEnabled);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcManagementService>("managedBy", ManagedBy);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop>("microsoftManagedDesktop", MicrosoftManagedDesktop);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CloudPcProvisioningType>("provisioningType", ProvisioningType);
            writer.WriteCollectionOfPrimitiveValues<string>("scopeIds", ScopeIds);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CloudPcWindowsSetting>("windowsSetting", WindowsSetting);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CloudPcWindowsSettings>("windowsSettings", WindowsSettings);
        }
    }
}
#pragma warning restore CS0618
