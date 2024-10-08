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
    public partial class AppManagementConfiguration : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Collection of certificate restrictions settings to be applied to an application or service principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.KeyCredentialConfiguration>? KeyCredentials
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyCredentialConfiguration>?>("keyCredentials"); }
            set { BackingStore?.Set("keyCredentials", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.KeyCredentialConfiguration> KeyCredentials
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyCredentialConfiguration>>("keyCredentials"); }
            set { BackingStore?.Set("keyCredentials", value); }
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
        /// <summary>Collection of password restrictions settings to be applied to an application or service principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.PasswordCredentialConfiguration>? PasswordCredentials
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PasswordCredentialConfiguration>?>("passwordCredentials"); }
            set { BackingStore?.Set("passwordCredentials", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.PasswordCredentialConfiguration> PasswordCredentials
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PasswordCredentialConfiguration>>("passwordCredentials"); }
            set { BackingStore?.Set("passwordCredentials", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AppManagementConfiguration"/> and sets the default values.
        /// </summary>
        public AppManagementConfiguration()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AppManagementConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.AppManagementConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.appManagementApplicationConfiguration" => new global::Microsoft.Graph.Beta.Models.AppManagementApplicationConfiguration(),
                "#microsoft.graph.appManagementServicePrincipalConfiguration" => new global::Microsoft.Graph.Beta.Models.AppManagementServicePrincipalConfiguration(),
                "#microsoft.graph.customAppManagementConfiguration" => new global::Microsoft.Graph.Beta.Models.CustomAppManagementConfiguration(),
                _ => new global::Microsoft.Graph.Beta.Models.AppManagementConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "keyCredentials", n => { KeyCredentials = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyCredentialConfiguration>(global::Microsoft.Graph.Beta.Models.KeyCredentialConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "passwordCredentials", n => { PasswordCredentials = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PasswordCredentialConfiguration>(global::Microsoft.Graph.Beta.Models.PasswordCredentialConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyCredentialConfiguration>("keyCredentials", KeyCredentials);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PasswordCredentialConfiguration>("passwordCredentials", PasswordCredentials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
