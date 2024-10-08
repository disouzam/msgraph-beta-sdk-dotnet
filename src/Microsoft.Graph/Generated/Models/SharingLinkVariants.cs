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
    public partial class SharingLinkVariants : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Indicates the most permissive role with which an address bar link can be created. The possible values are: none, view, edit, manageList, review, restrictedView, submitOnly, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.SharingRole? AddressBarLinkPermission
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SharingRole?>("addressBarLinkPermission"); }
            set { BackingStore?.Set("addressBarLinkPermission", value); }
        }
        /// <summary>Indicates whether a link can be embedded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.SharingOperationStatus? AllowEmbed
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SharingOperationStatus?>("allowEmbed"); }
            set { BackingStore?.Set("allowEmbed", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.SharingOperationStatus AllowEmbed
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SharingOperationStatus>("allowEmbed"); }
            set { BackingStore?.Set("allowEmbed", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>Indicates whether a link can be password protected, meaning that link users would need to enter a password to access the item for which the sharing link is produced. Creating a passwordProtected link for the first time requires providing a password.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.SharingOperationStatus? PasswordProtected
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SharingOperationStatus?>("passwordProtected"); }
            set { BackingStore?.Set("passwordProtected", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.SharingOperationStatus PasswordProtected
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SharingOperationStatus>("passwordProtected"); }
            set { BackingStore?.Set("passwordProtected", value); }
        }
#endif
        /// <summary>Indicates whether a link requires identity authentication for recipients. Users can be verified through either an email address or identity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.SharingOperationStatus? RequiresAuthentication
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SharingOperationStatus?>("requiresAuthentication"); }
            set { BackingStore?.Set("requiresAuthentication", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.SharingOperationStatus RequiresAuthentication
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SharingOperationStatus>("requiresAuthentication"); }
            set { BackingStore?.Set("requiresAuthentication", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.SharingLinkVariants"/> and sets the default values.
        /// </summary>
        public SharingLinkVariants()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SharingLinkVariants"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.SharingLinkVariants CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.SharingLinkVariants();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "addressBarLinkPermission", n => { AddressBarLinkPermission = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.SharingRole>(); } },
                { "allowEmbed", n => { AllowEmbed = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.SharingOperationStatus>(global::Microsoft.Graph.Beta.Models.SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "passwordProtected", n => { PasswordProtected = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.SharingOperationStatus>(global::Microsoft.Graph.Beta.Models.SharingOperationStatus.CreateFromDiscriminatorValue); } },
                { "requiresAuthentication", n => { RequiresAuthentication = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.SharingOperationStatus>(global::Microsoft.Graph.Beta.Models.SharingOperationStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.SharingRole>("addressBarLinkPermission", AddressBarLinkPermission);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.SharingOperationStatus>("allowEmbed", AllowEmbed);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.SharingOperationStatus>("passwordProtected", PasswordProtected);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.SharingOperationStatus>("requiresAuthentication", RequiresAuthentication);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
