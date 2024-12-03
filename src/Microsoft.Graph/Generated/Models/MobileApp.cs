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
    /// An abstract class containing the base properties for Intune mobile apps. Note: Listing mobile apps with `$expand=assignments` has been deprecated. Instead get the list of apps without the `$expand` query on `assignments`. Then, perform the expansion on individual applications.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MobileApp : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The list of group assignments for this mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MobileAppAssignment>? Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileAppAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MobileAppAssignment> Assignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileAppAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>The list of categories for this app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MobileAppCategory>? Categories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileAppCategory>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MobileAppCategory> Categories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileAppCategory>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>The date and time the app was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The total number of dependencies the child app has.</summary>
        public int? DependentAppCount
        {
            get { return BackingStore?.Get<int?>("dependentAppCount"); }
            set { BackingStore?.Set("dependentAppCount", value); }
        }
        /// <summary>The description of the app.</summary>
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
        /// <summary>The developer of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Developer
        {
            get { return BackingStore?.Get<string?>("developer"); }
            set { BackingStore?.Set("developer", value); }
        }
#nullable restore
#else
        public string Developer
        {
            get { return BackingStore?.Get<string>("developer"); }
            set { BackingStore?.Set("developer", value); }
        }
#endif
        /// <summary>The admin provided or imported title of the app.</summary>
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
        /// <summary>The more information Url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InformationUrl
        {
            get { return BackingStore?.Get<string?>("informationUrl"); }
            set { BackingStore?.Set("informationUrl", value); }
        }
#nullable restore
#else
        public string InformationUrl
        {
            get { return BackingStore?.Get<string>("informationUrl"); }
            set { BackingStore?.Set("informationUrl", value); }
        }
#endif
        /// <summary>The value indicating whether the app is assigned to at least one group.</summary>
        public bool? IsAssigned
        {
            get { return BackingStore?.Get<bool?>("isAssigned"); }
            set { BackingStore?.Set("isAssigned", value); }
        }
        /// <summary>The value indicating whether the app is marked as featured by the admin.</summary>
        public bool? IsFeatured
        {
            get { return BackingStore?.Get<bool?>("isFeatured"); }
            set { BackingStore?.Set("isFeatured", value); }
        }
        /// <summary>The large icon, to be displayed in the app details and used for upload of the icon.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MimeContent? LargeIcon
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MimeContent?>("largeIcon"); }
            set { BackingStore?.Set("largeIcon", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MimeContent LargeIcon
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MimeContent>("largeIcon"); }
            set { BackingStore?.Set("largeIcon", value); }
        }
#endif
        /// <summary>The date and time the app was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Notes for the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes
        {
            get { return BackingStore?.Get<string?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public string Notes
        {
            get { return BackingStore?.Get<string>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>The owner of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner
        {
            get { return BackingStore?.Get<string?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public string Owner
        {
            get { return BackingStore?.Get<string>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>The privacy statement Url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyInformationUrl
        {
            get { return BackingStore?.Get<string?>("privacyInformationUrl"); }
            set { BackingStore?.Set("privacyInformationUrl", value); }
        }
#nullable restore
#else
        public string PrivacyInformationUrl
        {
            get { return BackingStore?.Get<string>("privacyInformationUrl"); }
            set { BackingStore?.Set("privacyInformationUrl", value); }
        }
#endif
        /// <summary>The publisher of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher
        {
            get { return BackingStore?.Get<string?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#nullable restore
#else
        public string Publisher
        {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#endif
        /// <summary>Indicates the publishing state of an app.</summary>
        public global::Microsoft.Graph.Beta.Models.MobileAppPublishingState? PublishingState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MobileAppPublishingState?>("publishingState"); }
            set { BackingStore?.Set("publishingState", value); }
        }
        /// <summary>List of relationships for this mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MobileAppRelationship>? Relationships
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileAppRelationship>?>("relationships"); }
            set { BackingStore?.Set("relationships", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MobileAppRelationship> Relationships
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MobileAppRelationship>>("relationships"); }
            set { BackingStore?.Set("relationships", value); }
        }
#endif
        /// <summary>List of scope tag ids for this mobile app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>The total number of apps this app is directly or indirectly superseded by. This property is read-only.</summary>
        public int? SupersededAppCount
        {
            get { return BackingStore?.Get<int?>("supersededAppCount"); }
            set { BackingStore?.Set("supersededAppCount", value); }
        }
        /// <summary>The total number of apps this app directly or indirectly supersedes. This property is read-only.</summary>
        public int? SupersedingAppCount
        {
            get { return BackingStore?.Get<int?>("supersedingAppCount"); }
            set { BackingStore?.Set("supersedingAppCount", value); }
        }
        /// <summary>The upload state.</summary>
        public int? UploadState
        {
            get { return BackingStore?.Get<int?>("uploadState"); }
            set { BackingStore?.Set("uploadState", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MobileApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MobileApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidForWorkApp" => new global::Microsoft.Graph.Beta.Models.AndroidForWorkApp(),
                "#microsoft.graph.androidLobApp" => new global::Microsoft.Graph.Beta.Models.AndroidLobApp(),
                "#microsoft.graph.androidManagedStoreApp" => new global::Microsoft.Graph.Beta.Models.AndroidManagedStoreApp(),
                "#microsoft.graph.androidManagedStoreWebApp" => new global::Microsoft.Graph.Beta.Models.AndroidManagedStoreWebApp(),
                "#microsoft.graph.androidStoreApp" => new global::Microsoft.Graph.Beta.Models.AndroidStoreApp(),
                "#microsoft.graph.iosiPadOSWebClip" => new global::Microsoft.Graph.Beta.Models.IosiPadOSWebClip(),
                "#microsoft.graph.iosLobApp" => new global::Microsoft.Graph.Beta.Models.IosLobApp(),
                "#microsoft.graph.iosStoreApp" => new global::Microsoft.Graph.Beta.Models.IosStoreApp(),
                "#microsoft.graph.iosVppApp" => new global::Microsoft.Graph.Beta.Models.IosVppApp(),
                "#microsoft.graph.macOSDmgApp" => new global::Microsoft.Graph.Beta.Models.MacOSDmgApp(),
                "#microsoft.graph.macOSLobApp" => new global::Microsoft.Graph.Beta.Models.MacOSLobApp(),
                "#microsoft.graph.macOSMicrosoftDefenderApp" => new global::Microsoft.Graph.Beta.Models.MacOSMicrosoftDefenderApp(),
                "#microsoft.graph.macOSMicrosoftEdgeApp" => new global::Microsoft.Graph.Beta.Models.MacOSMicrosoftEdgeApp(),
                "#microsoft.graph.macOSOfficeSuiteApp" => new global::Microsoft.Graph.Beta.Models.MacOSOfficeSuiteApp(),
                "#microsoft.graph.macOSPkgApp" => new global::Microsoft.Graph.Beta.Models.MacOSPkgApp(),
                "#microsoft.graph.macOsVppApp" => new global::Microsoft.Graph.Beta.Models.MacOsVppApp(),
                "#microsoft.graph.macOSWebClip" => new global::Microsoft.Graph.Beta.Models.MacOSWebClip(),
                "#microsoft.graph.managedAndroidLobApp" => new global::Microsoft.Graph.Beta.Models.ManagedAndroidLobApp(),
                "#microsoft.graph.managedAndroidStoreApp" => new global::Microsoft.Graph.Beta.Models.ManagedAndroidStoreApp(),
                "#microsoft.graph.managedApp" => new global::Microsoft.Graph.Beta.Models.ManagedApp(),
                "#microsoft.graph.managedIOSLobApp" => new global::Microsoft.Graph.Beta.Models.ManagedIOSLobApp(),
                "#microsoft.graph.managedIOSStoreApp" => new global::Microsoft.Graph.Beta.Models.ManagedIOSStoreApp(),
                "#microsoft.graph.managedMobileLobApp" => new global::Microsoft.Graph.Beta.Models.ManagedMobileLobApp(),
                "#microsoft.graph.microsoftStoreForBusinessApp" => new global::Microsoft.Graph.Beta.Models.MicrosoftStoreForBusinessApp(),
                "#microsoft.graph.mobileLobApp" => new global::Microsoft.Graph.Beta.Models.MobileLobApp(),
                "#microsoft.graph.officeSuiteApp" => new global::Microsoft.Graph.Beta.Models.OfficeSuiteApp(),
                "#microsoft.graph.webApp" => new global::Microsoft.Graph.Beta.Models.WebApp(),
                "#microsoft.graph.win32CatalogApp" => new global::Microsoft.Graph.Beta.Models.Win32CatalogApp(),
                "#microsoft.graph.win32LobApp" => new global::Microsoft.Graph.Beta.Models.Win32LobApp(),
                "#microsoft.graph.windowsAppX" => new global::Microsoft.Graph.Beta.Models.WindowsAppX(),
                "#microsoft.graph.windowsMicrosoftEdgeApp" => new global::Microsoft.Graph.Beta.Models.WindowsMicrosoftEdgeApp(),
                "#microsoft.graph.windowsMobileMSI" => new global::Microsoft.Graph.Beta.Models.WindowsMobileMSI(),
                "#microsoft.graph.windowsPhone81AppX" => new global::Microsoft.Graph.Beta.Models.WindowsPhone81AppX(),
                "#microsoft.graph.windowsPhone81AppXBundle" => new global::Microsoft.Graph.Beta.Models.WindowsPhone81AppXBundle(),
                "#microsoft.graph.windowsPhone81StoreApp" => new global::Microsoft.Graph.Beta.Models.WindowsPhone81StoreApp(),
                "#microsoft.graph.windowsPhoneXAP" => new global::Microsoft.Graph.Beta.Models.WindowsPhoneXAP(),
                "#microsoft.graph.windowsStoreApp" => new global::Microsoft.Graph.Beta.Models.WindowsStoreApp(),
                "#microsoft.graph.windowsUniversalAppX" => new global::Microsoft.Graph.Beta.Models.WindowsUniversalAppX(),
                "#microsoft.graph.windowsWebApp" => new global::Microsoft.Graph.Beta.Models.WindowsWebApp(),
                "#microsoft.graph.winGetApp" => new global::Microsoft.Graph.Beta.Models.WinGetApp(),
                _ => new global::Microsoft.Graph.Beta.Models.MobileApp(),
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
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileAppAssignment>(global::Microsoft.Graph.Beta.Models.MobileAppAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "categories", n => { Categories = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileAppCategory>(global::Microsoft.Graph.Beta.Models.MobileAppCategory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "dependentAppCount", n => { DependentAppCount = n.GetIntValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "developer", n => { Developer = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "informationUrl", n => { InformationUrl = n.GetStringValue(); } },
                { "isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                { "isFeatured", n => { IsFeatured = n.GetBoolValue(); } },
                { "largeIcon", n => { LargeIcon = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MimeContent>(global::Microsoft.Graph.Beta.Models.MimeContent.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "notes", n => { Notes = n.GetStringValue(); } },
                { "owner", n => { Owner = n.GetStringValue(); } },
                { "privacyInformationUrl", n => { PrivacyInformationUrl = n.GetStringValue(); } },
                { "publisher", n => { Publisher = n.GetStringValue(); } },
                { "publishingState", n => { PublishingState = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.MobileAppPublishingState>(); } },
                { "relationships", n => { Relationships = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileAppRelationship>(global::Microsoft.Graph.Beta.Models.MobileAppRelationship.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "supersededAppCount", n => { SupersededAppCount = n.GetIntValue(); } },
                { "supersedingAppCount", n => { SupersedingAppCount = n.GetIntValue(); } },
                { "uploadState", n => { UploadState = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileAppAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileAppCategory>("categories", Categories);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("developer", Developer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("informationUrl", InformationUrl);
            writer.WriteBoolValue("isFeatured", IsFeatured);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MimeContent>("largeIcon", LargeIcon);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("owner", Owner);
            writer.WriteStringValue("privacyInformationUrl", PrivacyInformationUrl);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.MobileAppPublishingState>("publishingState", PublishingState);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MobileAppRelationship>("relationships", Relationships);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}
#pragma warning restore CS0618
