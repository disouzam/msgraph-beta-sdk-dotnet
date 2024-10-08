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
    public partial class UserFlowApiConnectorConfiguration : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The postAttributeCollection property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentityApiConnector? PostAttributeCollection
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentityApiConnector?>("postAttributeCollection"); }
            set { BackingStore?.Set("postAttributeCollection", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentityApiConnector PostAttributeCollection
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>("postAttributeCollection"); }
            set { BackingStore?.Set("postAttributeCollection", value); }
        }
#endif
        /// <summary>The postFederationSignup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentityApiConnector? PostFederationSignup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentityApiConnector?>("postFederationSignup"); }
            set { BackingStore?.Set("postFederationSignup", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentityApiConnector PostFederationSignup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>("postFederationSignup"); }
            set { BackingStore?.Set("postFederationSignup", value); }
        }
#endif
        /// <summary>The preTokenIssuance property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentityApiConnector? PreTokenIssuance
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentityApiConnector?>("preTokenIssuance"); }
            set { BackingStore?.Set("preTokenIssuance", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentityApiConnector PreTokenIssuance
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>("preTokenIssuance"); }
            set { BackingStore?.Set("preTokenIssuance", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.UserFlowApiConnectorConfiguration"/> and sets the default values.
        /// </summary>
        public UserFlowApiConnectorConfiguration()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.UserFlowApiConnectorConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.UserFlowApiConnectorConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.UserFlowApiConnectorConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "postAttributeCollection", n => { PostAttributeCollection = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>(global::Microsoft.Graph.Beta.Models.IdentityApiConnector.CreateFromDiscriminatorValue); } },
                { "postFederationSignup", n => { PostFederationSignup = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>(global::Microsoft.Graph.Beta.Models.IdentityApiConnector.CreateFromDiscriminatorValue); } },
                { "preTokenIssuance", n => { PreTokenIssuance = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>(global::Microsoft.Graph.Beta.Models.IdentityApiConnector.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>("postAttributeCollection", PostAttributeCollection);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>("postFederationSignup", PostFederationSignup);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>("preTokenIssuance", PreTokenIssuance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
