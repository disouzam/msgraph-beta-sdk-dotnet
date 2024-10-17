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
    public partial class AuthenticationRequirementPolicy : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Provides additional detail on the feature identified in requirementProvider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Detail
        {
            get { return BackingStore?.Get<string?>("detail"); }
            set { BackingStore?.Set("detail", value); }
        }
#nullable restore
#else
        public string Detail
        {
            get { return BackingStore?.Get<string>("detail"); }
            set { BackingStore?.Set("detail", value); }
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
        /// <summary>Identifies what Microsoft Entra feature requires MFA in this policy. Possible values are: user, request, servicePrincipal, v1ConditionalAccess, multiConditionalAccess, tenantSessionRiskPolicy, accountCompromisePolicies, v1ConditionalAccessDependency, v1ConditionalAccessPolicyIdRequested, mfaRegistrationRequiredByIdentityProtectionPolicy, baselineProtection, mfaRegistrationRequiredByBaselineProtection, mfaRegistrationRequiredByMultiConditionalAccess, enforcedForCspAdmins, securityDefaults, mfaRegistrationRequiredBySecurityDefaults, proofUpCodeRequest, crossTenantOutboundRule, gpsLocationCondition, riskBasedPolicy, unknownFutureValue, scopeBasedAuthRequirementPolicy, authenticationStrengths . Also, note that you must use the Prefer: include-unknown-enum-members request header to get the following value or values in this evolvable enum: scopeBasedAuthRequirementPolicy, authenticationStrengths.</summary>
        public global::Microsoft.Graph.Beta.Models.RequirementProvider? RequirementProvider
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.RequirementProvider?>("requirementProvider"); }
            set { BackingStore?.Set("requirementProvider", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AuthenticationRequirementPolicy"/> and sets the default values.
        /// </summary>
        public AuthenticationRequirementPolicy()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AuthenticationRequirementPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.AuthenticationRequirementPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AuthenticationRequirementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "detail", n => { Detail = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "requirementProvider", n => { RequirementProvider = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.RequirementProvider>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("detail", Detail);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.RequirementProvider>("requirementProvider", RequirementProvider);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
