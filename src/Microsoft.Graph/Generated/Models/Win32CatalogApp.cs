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
    /// A mobileApp that is based on a referenced application in a Win32CatalogApp repository
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Win32CatalogApp : global::Microsoft.Graph.Beta.Models.Win32LobApp, IParsable
    {
        /// <summary>The latest available catalog package the app is upgradeable to. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage? LatestUpgradeCatalogPackage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage?>("latestUpgradeCatalogPackage"); }
            set { BackingStore?.Set("latestUpgradeCatalogPackage", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage LatestUpgradeCatalogPackage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage>("latestUpgradeCatalogPackage"); }
            set { BackingStore?.Set("latestUpgradeCatalogPackage", value); }
        }
#endif
        /// <summary>The mobileAppCatalogPackageId property references the mobileAppCatalogPackage entity which contains information about an application catalog package that can be deployed to Intune-managed devices</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MobileAppCatalogPackageId
        {
            get { return BackingStore?.Get<string?>("mobileAppCatalogPackageId"); }
            set { BackingStore?.Set("mobileAppCatalogPackageId", value); }
        }
#nullable restore
#else
        public string MobileAppCatalogPackageId
        {
            get { return BackingStore?.Get<string>("mobileAppCatalogPackageId"); }
            set { BackingStore?.Set("mobileAppCatalogPackageId", value); }
        }
#endif
        /// <summary>The current catalog package the app is synced from. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage? ReferencedCatalogPackage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage?>("referencedCatalogPackage"); }
            set { BackingStore?.Set("referencedCatalogPackage", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage ReferencedCatalogPackage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage>("referencedCatalogPackage"); }
            set { BackingStore?.Set("referencedCatalogPackage", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Win32CatalogApp"/> and sets the default values.
        /// </summary>
        public Win32CatalogApp() : base()
        {
            OdataType = "#microsoft.graph.win32CatalogApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Win32CatalogApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Win32CatalogApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Win32CatalogApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "latestUpgradeCatalogPackage", n => { LatestUpgradeCatalogPackage = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage>(global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage.CreateFromDiscriminatorValue); } },
                { "mobileAppCatalogPackageId", n => { MobileAppCatalogPackageId = n.GetStringValue(); } },
                { "referencedCatalogPackage", n => { ReferencedCatalogPackage = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage>(global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage>("latestUpgradeCatalogPackage", LatestUpgradeCatalogPackage);
            writer.WriteStringValue("mobileAppCatalogPackageId", MobileAppCatalogPackageId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.MobileAppCatalogPackage>("referencedCatalogPackage", ReferencedCatalogPackage);
        }
    }
}
#pragma warning restore CS0618
