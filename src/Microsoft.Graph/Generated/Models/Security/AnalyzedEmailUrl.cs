// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class AnalyzedEmailUrl : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The method used to detect threats in the URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetectionMethod
        {
            get { return BackingStore?.Get<string?>("detectionMethod"); }
            set { BackingStore?.Set("detectionMethod", value); }
        }
#nullable restore
#else
        public string DetectionMethod
        {
            get { return BackingStore?.Get<string>("detectionMethod"); }
            set { BackingStore?.Set("detectionMethod", value); }
        }
#endif
        /// <summary>Detonation data associated with the URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.DetonationDetails? DetonationDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.DetonationDetails?>("detonationDetails"); }
            set { BackingStore?.Set("detonationDetails", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.DetonationDetails DetonationDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.DetonationDetails>("detonationDetails"); }
            set { BackingStore?.Set("detonationDetails", value); }
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
        /// <summary>The type of threat associated with the URL. The possible values are: unknown, spam, malware, phishing, none, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.Security.ThreatType? ThreatType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.ThreatType?>("threatType"); }
            set { BackingStore?.Set("threatType", value); }
        }
        /// <summary>The URL that is found in the email. This is full URL string, including query parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url
        {
            get { return BackingStore?.Get<string?>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#nullable restore
#else
        public string Url
        {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Security.AnalyzedEmailUrl"/> and sets the default values.
        /// </summary>
        public AnalyzedEmailUrl()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.AnalyzedEmailUrl"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.Security.AnalyzedEmailUrl CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.AnalyzedEmailUrl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "detectionMethod", n => { DetectionMethod = n.GetStringValue(); } },
                { "detonationDetails", n => { DetonationDetails = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.DetonationDetails>(global::Microsoft.Graph.Beta.Models.Security.DetonationDetails.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "threatType", n => { ThreatType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Security.ThreatType>(); } },
                { "url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("detectionMethod", DetectionMethod);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.DetonationDetails>("detonationDetails", DetonationDetails);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Security.ThreatType>("threatType", ThreatType);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
