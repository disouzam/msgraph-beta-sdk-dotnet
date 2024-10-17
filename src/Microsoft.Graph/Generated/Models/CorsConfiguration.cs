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
    public partial class CorsConfiguration : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The request headers that the origin domain may specify on the CORS request. The wildcard character * indicates that any header beginning with the specified prefix is allowed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedHeaders
        {
            get { return BackingStore?.Get<List<string>?>("allowedHeaders"); }
            set { BackingStore?.Set("allowedHeaders", value); }
        }
#nullable restore
#else
        public List<string> AllowedHeaders
        {
            get { return BackingStore?.Get<List<string>>("allowedHeaders"); }
            set { BackingStore?.Set("allowedHeaders", value); }
        }
#endif
        /// <summary>The HTTP request methods that the origin domain may use for a CORS request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedMethods
        {
            get { return BackingStore?.Get<List<string>?>("allowedMethods"); }
            set { BackingStore?.Set("allowedMethods", value); }
        }
#nullable restore
#else
        public List<string> AllowedMethods
        {
            get { return BackingStore?.Get<List<string>>("allowedMethods"); }
            set { BackingStore?.Set("allowedMethods", value); }
        }
#endif
        /// <summary>The origin domains that are permitted to make a request against the service via CORS. The origin domain is the domain from which the request originates. The origin must be an exact case-sensitive match with the origin that the user age sends to the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedOrigins
        {
            get { return BackingStore?.Get<List<string>?>("allowedOrigins"); }
            set { BackingStore?.Set("allowedOrigins", value); }
        }
#nullable restore
#else
        public List<string> AllowedOrigins
        {
            get { return BackingStore?.Get<List<string>>("allowedOrigins"); }
            set { BackingStore?.Set("allowedOrigins", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The maximum amount of time that a browser should cache the response to the preflight OPTIONS request.</summary>
        public int? MaxAgeInSeconds
        {
            get { return BackingStore?.Get<int?>("maxAgeInSeconds"); }
            set { BackingStore?.Set("maxAgeInSeconds", value); }
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
        /// <summary>Resource within the application segment for which CORS permissions are granted. / grants permission for whole app segment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Resource
        {
            get { return BackingStore?.Get<string?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public string Resource
        {
            get { return BackingStore?.Get<string>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CorsConfiguration"/> and sets the default values.
        /// </summary>
        public CorsConfiguration()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CorsConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.CorsConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CorsConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowedHeaders", n => { AllowedHeaders = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "allowedMethods", n => { AllowedMethods = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "allowedOrigins", n => { AllowedOrigins = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "maxAgeInSeconds", n => { MaxAgeInSeconds = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "resource", n => { Resource = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowedHeaders", AllowedHeaders);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedMethods", AllowedMethods);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedOrigins", AllowedOrigins);
            writer.WriteIntValue("maxAgeInSeconds", MaxAgeInSeconds);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("resource", Resource);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
