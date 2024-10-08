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
    public partial class RiskUserActivity : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The possible values are none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.RiskDetail? Detail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.RiskDetail?>("detail"); }
            set { BackingStore?.Set("detail", value); }
        }
        /// <summary>List of risk event types. Deprecated. Use riskEventType instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.RiskEventType?>? EventTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.RiskEventType?>?>("eventTypes"); }
            set { BackingStore?.Set("eventTypes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.RiskEventType?> EventTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.RiskEventType?>>("eventTypes"); }
            set { BackingStore?.Set("eventTypes", value); }
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
        /// <summary>The type of risk event detected. The possible values are: anonymizedIPAddress, investigationsThreatIntelligence, investigationsThreatIntelligenceSigninLinked,leakedCredentials, maliciousIPAddress, maliciousIPAddressValidCredentialsBlockedIP, malwareInfectedIPAddress, mcasImpossibleTravel, mcasSuspiciousInboxManipulationRules, suspiciousAPITraffic, suspiciousIPAddress,   unfamiliarFeatures, unlikelyTravel. For more information about each value, see Risk types and detection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RiskEventTypes
        {
            get { return BackingStore?.Get<List<string>?>("riskEventTypes"); }
            set { BackingStore?.Set("riskEventTypes", value); }
        }
#nullable restore
#else
        public List<string> RiskEventTypes
        {
            get { return BackingStore?.Get<List<string>>("riskEventTypes"); }
            set { BackingStore?.Set("riskEventTypes", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.RiskUserActivity"/> and sets the default values.
        /// </summary>
        public RiskUserActivity()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.RiskUserActivity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.RiskUserActivity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.RiskUserActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "detail", n => { Detail = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.RiskDetail>(); } },
                { "eventTypes", n => { EventTypes = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.RiskEventType>()?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "riskEventTypes", n => { RiskEventTypes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.RiskDetail>("detail", Detail);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.RiskEventType>("eventTypes", EventTypes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("riskEventTypes", RiskEventTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
