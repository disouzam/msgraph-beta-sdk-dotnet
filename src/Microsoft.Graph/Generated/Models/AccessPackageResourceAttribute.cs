// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class AccessPackageResourceAttribute : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Information about how to set the attribute, currently a accessPackageUserDirectoryAttributeStore object type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeDestination? AttributeDestination
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeDestination?>("attributeDestination"); }
            set { BackingStore?.Set("attributeDestination", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeDestination AttributeDestination
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeDestination>("attributeDestination"); }
            set { BackingStore?.Set("attributeDestination", value); }
        }
#endif
        /// <summary>The name of the attribute in the end system. If the destination is accessPackageUserDirectoryAttributeStore, then a user property such as jobTitle or a directory schema extension for the user object type, such as extension2b676109c7c74ae2b41549205f1947edpersonalTitle.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AttributeName
        {
            get { return BackingStore?.Get<string?>("attributeName"); }
            set { BackingStore?.Set("attributeName", value); }
        }
#nullable restore
#else
        public string AttributeName
        {
            get { return BackingStore?.Get<string>("attributeName"); }
            set { BackingStore?.Set("attributeName", value); }
        }
#endif
        /// <summary>Information about how to populate the attribute value when an accessPackageAssignmentRequest is being fulfilled, currently a accessPackageResourceAttributeQuestion object type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeSource? AttributeSource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeSource?>("attributeSource"); }
            set { BackingStore?.Set("attributeSource", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeSource AttributeSource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeSource>("attributeSource"); }
            set { BackingStore?.Set("attributeSource", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Unique identifier for the attribute on the access package resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id
        {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id
        {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
        /// <summary>Specifies whether or not an existing attribute value can be edited by the requester.</summary>
        public bool? IsEditable
        {
            get { return BackingStore?.Get<bool?>("isEditable"); }
            set { BackingStore?.Set("isEditable", value); }
        }
        /// <summary>Specifies whether the attribute will remain in the end system after an assignment ends.</summary>
        public bool? IsPersistedOnAssignmentRemoval
        {
            get { return BackingStore?.Get<bool?>("isPersistedOnAssignmentRemoval"); }
            set { BackingStore?.Set("isPersistedOnAssignmentRemoval", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttribute"/> and sets the default values.
        /// </summary>
        public AccessPackageResourceAttribute()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttribute"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttribute CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttribute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attributeDestination", n => { AttributeDestination = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeDestination>(global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeDestination.CreateFromDiscriminatorValue); } },
                { "attributeName", n => { AttributeName = n.GetStringValue(); } },
                { "attributeSource", n => { AttributeSource = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeSource>(global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeSource.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "isEditable", n => { IsEditable = n.GetBoolValue(); } },
                { "isPersistedOnAssignmentRemoval", n => { IsPersistedOnAssignmentRemoval = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeDestination>("attributeDestination", AttributeDestination);
            writer.WriteStringValue("attributeName", AttributeName);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AccessPackageResourceAttributeSource>("attributeSource", AttributeSource);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isEditable", IsEditable);
            writer.WriteBoolValue("isPersistedOnAssignmentRemoval", IsPersistedOnAssignmentRemoval);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
