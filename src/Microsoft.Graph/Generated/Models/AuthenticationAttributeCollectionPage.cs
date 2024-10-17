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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AuthenticationAttributeCollectionPage : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The customStringsFileId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomStringsFileId
        {
            get { return BackingStore?.Get<string?>("customStringsFileId"); }
            set { BackingStore?.Set("customStringsFileId", value); }
        }
#nullable restore
#else
        public string CustomStringsFileId
        {
            get { return BackingStore?.Get<string>("customStringsFileId"); }
            set { BackingStore?.Set("customStringsFileId", value); }
        }
#endif
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
        /// <summary>A collection of displays of the attribute collection page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPageViewConfiguration>? Views
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPageViewConfiguration>?>("views"); }
            set { BackingStore?.Set("views", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPageViewConfiguration> Views
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPageViewConfiguration>>("views"); }
            set { BackingStore?.Set("views", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPage"/> and sets the default values.
        /// </summary>
        public AuthenticationAttributeCollectionPage()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "customStringsFileId", n => { CustomStringsFileId = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "views", n => { Views = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPageViewConfiguration>(global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPageViewConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("customStringsFileId", CustomStringsFileId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPageViewConfiguration>("views", Views);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
