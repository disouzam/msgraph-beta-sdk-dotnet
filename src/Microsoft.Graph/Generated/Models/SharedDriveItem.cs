// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class SharedDriveItem : global::Microsoft.Graph.Beta.Models.BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Used to access the underlying driveItem</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DriveItem? DriveItem
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DriveItem?>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DriveItem DriveItem
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DriveItem>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#endif
        /// <summary>All driveItems contained in the sharing root. This collection cannot be enumerated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DriveItem>? Items
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DriveItem>?>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DriveItem> Items
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DriveItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#endif
        /// <summary>Used to access the underlying list</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.List? List
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.List?>("list"); }
            set { BackingStore?.Set("list", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.List List
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.List>("list"); }
            set { BackingStore?.Set("list", value); }
        }
#endif
        /// <summary>Used to access the underlying listItem</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ListItem? ListItem
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ListItem?>("listItem"); }
            set { BackingStore?.Set("listItem", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ListItem ListItem
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ListItem>("listItem"); }
            set { BackingStore?.Set("listItem", value); }
        }
#endif
        /// <summary>Information about the owner of the shared item being referenced.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentitySet? Owner
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentitySet Owner
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>Used to access the permission representing the underlying sharing link</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Permission? Permission
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Permission?>("permission"); }
            set { BackingStore?.Set("permission", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Permission Permission
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Permission>("permission"); }
            set { BackingStore?.Set("permission", value); }
        }
#endif
        /// <summary>The root property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DriveItem? Root
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DriveItem?>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DriveItem Root
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DriveItem>("root"); }
            set { BackingStore?.Set("root", value); }
        }
#endif
        /// <summary>Used to access the underlying site</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Site? Site
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Site?>("site"); }
            set { BackingStore?.Set("site", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Site Site
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Site>("site"); }
            set { BackingStore?.Set("site", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.SharedDriveItem"/> and sets the default values.
        /// </summary>
        public SharedDriveItem() : base()
        {
            OdataType = "#microsoft.graph.sharedDriveItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SharedDriveItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.SharedDriveItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.SharedDriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "driveItem", n => { DriveItem = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DriveItem>(global::Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DriveItem>(global::Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "list", n => { List = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.List>(global::Microsoft.Graph.Beta.Models.List.CreateFromDiscriminatorValue); } },
                { "listItem", n => { ListItem = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ListItem>(global::Microsoft.Graph.Beta.Models.ListItem.CreateFromDiscriminatorValue); } },
                { "owner", n => { Owner = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>(global::Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "permission", n => { Permission = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Permission>(global::Microsoft.Graph.Beta.Models.Permission.CreateFromDiscriminatorValue); } },
                { "root", n => { Root = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DriveItem>(global::Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "site", n => { Site = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Site>(global::Microsoft.Graph.Beta.Models.Site.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DriveItem>("items", Items);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.List>("list", List);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>("owner", Owner);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Permission>("permission", Permission);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DriveItem>("root", Root);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Site>("site", Site);
        }
    }
}
#pragma warning restore CS0618
