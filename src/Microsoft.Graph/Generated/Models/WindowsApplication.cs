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
    public partial class WindowsApplication : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The package security identifier that Microsoft has assigned the application. Optional. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageSid
        {
            get { return BackingStore?.Get<string?>("packageSid"); }
            set { BackingStore?.Set("packageSid", value); }
        }
#nullable restore
#else
        public string PackageSid
        {
            get { return BackingStore?.Get<string>("packageSid"); }
            set { BackingStore?.Set("packageSid", value); }
        }
#endif
        /// <summary>Specifies the URLs where user tokens are sent for sign-in or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent. Only available for applications that support the PersonalMicrosoftAccount signInAudience.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RedirectUris
        {
            get { return BackingStore?.Get<List<string>?>("redirectUris"); }
            set { BackingStore?.Set("redirectUris", value); }
        }
#nullable restore
#else
        public List<string> RedirectUris
        {
            get { return BackingStore?.Get<List<string>>("redirectUris"); }
            set { BackingStore?.Set("redirectUris", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WindowsApplication"/> and sets the default values.
        /// </summary>
        public WindowsApplication()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsApplication"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.WindowsApplication CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsApplication();
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
                { "packageSid", n => { PackageSid = n.GetStringValue(); } },
                { "redirectUris", n => { RedirectUris = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteStringValue("packageSid", PackageSid);
            writer.WriteCollectionOfPrimitiveValues<string>("redirectUris", RedirectUris);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
