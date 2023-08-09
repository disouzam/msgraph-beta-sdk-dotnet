// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RequirementProvider {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "request")]
        Request,
        [EnumMember(Value = "servicePrincipal")]
        ServicePrincipal,
        [EnumMember(Value = "v1ConditionalAccess")]
        V1ConditionalAccess,
        [EnumMember(Value = "multiConditionalAccess")]
        MultiConditionalAccess,
        [EnumMember(Value = "tenantSessionRiskPolicy")]
        TenantSessionRiskPolicy,
        [EnumMember(Value = "accountCompromisePolicies")]
        AccountCompromisePolicies,
        [EnumMember(Value = "v1ConditionalAccessDependency")]
        V1ConditionalAccessDependency,
        [EnumMember(Value = "v1ConditionalAccessPolicyIdRequested")]
        V1ConditionalAccessPolicyIdRequested,
        [EnumMember(Value = "mfaRegistrationRequiredByIdentityProtectionPolicy")]
        MfaRegistrationRequiredByIdentityProtectionPolicy,
        [EnumMember(Value = "baselineProtection")]
        BaselineProtection,
        [EnumMember(Value = "mfaRegistrationRequiredByBaselineProtection")]
        MfaRegistrationRequiredByBaselineProtection,
        [EnumMember(Value = "mfaRegistrationRequiredByMultiConditionalAccess")]
        MfaRegistrationRequiredByMultiConditionalAccess,
        [EnumMember(Value = "enforcedForCspAdmins")]
        EnforcedForCspAdmins,
        [EnumMember(Value = "securityDefaults")]
        SecurityDefaults,
        [EnumMember(Value = "mfaRegistrationRequiredBySecurityDefaults")]
        MfaRegistrationRequiredBySecurityDefaults,
        [EnumMember(Value = "proofUpCodeRequest")]
        ProofUpCodeRequest,
        [EnumMember(Value = "crossTenantOutboundRule")]
        CrossTenantOutboundRule,
        [EnumMember(Value = "gpsLocationCondition")]
        GpsLocationCondition,
        [EnumMember(Value = "riskBasedPolicy")]
        RiskBasedPolicy,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
