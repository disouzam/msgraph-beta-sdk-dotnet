// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public enum SubmissionResultDetail
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
        [EnumMember(Value = "underInvestigation")]
        #pragma warning disable CS1591
        UnderInvestigation,
        #pragma warning restore CS1591
        [EnumMember(Value = "simulatedThreat")]
        #pragma warning disable CS1591
        SimulatedThreat,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedBySecOps")]
        #pragma warning disable CS1591
        AllowedBySecOps,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedByThirdPartyFilters")]
        #pragma warning disable CS1591
        AllowedByThirdPartyFilters,
        #pragma warning restore CS1591
        [EnumMember(Value = "messageNotFound")]
        #pragma warning disable CS1591
        MessageNotFound,
        #pragma warning restore CS1591
        [EnumMember(Value = "urlFileShouldNotBeBlocked")]
        #pragma warning disable CS1591
        UrlFileShouldNotBeBlocked,
        #pragma warning restore CS1591
        [EnumMember(Value = "urlFileShouldBeBlocked")]
        #pragma warning disable CS1591
        UrlFileShouldBeBlocked,
        #pragma warning restore CS1591
        [EnumMember(Value = "urlFileCannotMakeDecision")]
        #pragma warning disable CS1591
        UrlFileCannotMakeDecision,
        #pragma warning restore CS1591
        [EnumMember(Value = "domainImpersonation")]
        #pragma warning disable CS1591
        DomainImpersonation,
        #pragma warning restore CS1591
        [EnumMember(Value = "userImpersonation")]
        #pragma warning disable CS1591
        UserImpersonation,
        #pragma warning restore CS1591
        [EnumMember(Value = "brandImpersonation")]
        #pragma warning disable CS1591
        BrandImpersonation,
        #pragma warning restore CS1591
        [EnumMember(Value = "outboundShouldNotBeBlocked")]
        #pragma warning disable CS1591
        OutboundShouldNotBeBlocked,
        #pragma warning restore CS1591
        [EnumMember(Value = "outboundShouldBeBlocked")]
        #pragma warning disable CS1591
        OutboundShouldBeBlocked,
        #pragma warning restore CS1591
        [EnumMember(Value = "outboundBulk")]
        #pragma warning disable CS1591
        OutboundBulk,
        #pragma warning restore CS1591
        [EnumMember(Value = "outboundCannotMakeDecision")]
        #pragma warning disable CS1591
        OutboundCannotMakeDecision,
        #pragma warning restore CS1591
        [EnumMember(Value = "outboundNotRescanned")]
        #pragma warning disable CS1591
        OutboundNotRescanned,
        #pragma warning restore CS1591
        [EnumMember(Value = "zeroHourAutoPurgeAllowed")]
        #pragma warning disable CS1591
        ZeroHourAutoPurgeAllowed,
        #pragma warning restore CS1591
        [EnumMember(Value = "zeroHourAutoPurgeBlocked")]
        #pragma warning disable CS1591
        ZeroHourAutoPurgeBlocked,
        #pragma warning restore CS1591
        [EnumMember(Value = "zeroHourAutoPurgeQuarantineReleased")]
        #pragma warning disable CS1591
        ZeroHourAutoPurgeQuarantineReleased,
        #pragma warning restore CS1591
        [EnumMember(Value = "onPremisesSkip")]
        #pragma warning disable CS1591
        OnPremisesSkip,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedByTenantAllowBlockList")]
        #pragma warning disable CS1591
        AllowedByTenantAllowBlockList,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedByTenantAllowBlockList")]
        #pragma warning disable CS1591
        BlockedByTenantAllowBlockList,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedUrlByTenantAllowBlockList")]
        #pragma warning disable CS1591
        AllowedUrlByTenantAllowBlockList,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedFileByTenantAllowBlockList")]
        #pragma warning disable CS1591
        AllowedFileByTenantAllowBlockList,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedSenderByTenantAllowBlockList")]
        #pragma warning disable CS1591
        AllowedSenderByTenantAllowBlockList,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedRecipientByTenantAllowBlockList")]
        #pragma warning disable CS1591
        AllowedRecipientByTenantAllowBlockList,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedUrlByTenantAllowBlockList")]
        #pragma warning disable CS1591
        BlockedUrlByTenantAllowBlockList,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedFileByTenantAllowBlockList")]
        #pragma warning disable CS1591
        BlockedFileByTenantAllowBlockList,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedSenderByTenantAllowBlockList")]
        #pragma warning disable CS1591
        BlockedSenderByTenantAllowBlockList,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedRecipientByTenantAllowBlockList")]
        #pragma warning disable CS1591
        BlockedRecipientByTenantAllowBlockList,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedByConnection")]
        #pragma warning disable CS1591
        AllowedByConnection,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedByConnection")]
        #pragma warning disable CS1591
        BlockedByConnection,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedByExchangeTransportRule")]
        #pragma warning disable CS1591
        AllowedByExchangeTransportRule,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedByExchangeTransportRule")]
        #pragma warning disable CS1591
        BlockedByExchangeTransportRule,
        #pragma warning restore CS1591
        [EnumMember(Value = "quarantineReleased")]
        #pragma warning disable CS1591
        QuarantineReleased,
        #pragma warning restore CS1591
        [EnumMember(Value = "quarantineReleasedThenBlocked")]
        #pragma warning disable CS1591
        QuarantineReleasedThenBlocked,
        #pragma warning restore CS1591
        [EnumMember(Value = "junkMailRuleDisabled")]
        #pragma warning disable CS1591
        JunkMailRuleDisabled,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedByUserSetting")]
        #pragma warning disable CS1591
        AllowedByUserSetting,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedByUserSetting")]
        #pragma warning disable CS1591
        BlockedByUserSetting,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedByTenant")]
        #pragma warning disable CS1591
        AllowedByTenant,
        #pragma warning restore CS1591
        [EnumMember(Value = "blockedByTenant")]
        #pragma warning disable CS1591
        BlockedByTenant,
        #pragma warning restore CS1591
        [EnumMember(Value = "invalidFalsePositive")]
        #pragma warning disable CS1591
        InvalidFalsePositive,
        #pragma warning restore CS1591
        [EnumMember(Value = "invalidFalseNegative")]
        #pragma warning disable CS1591
        InvalidFalseNegative,
        #pragma warning restore CS1591
        [EnumMember(Value = "spoofBlocked")]
        #pragma warning disable CS1591
        SpoofBlocked,
        #pragma warning restore CS1591
        [EnumMember(Value = "goodReclassifiedAsBad")]
        #pragma warning disable CS1591
        GoodReclassifiedAsBad,
        #pragma warning restore CS1591
        [EnumMember(Value = "goodReclassifiedAsBulk")]
        #pragma warning disable CS1591
        GoodReclassifiedAsBulk,
        #pragma warning restore CS1591
        [EnumMember(Value = "goodReclassifiedAsGood")]
        #pragma warning disable CS1591
        GoodReclassifiedAsGood,
        #pragma warning restore CS1591
        [EnumMember(Value = "goodReclassifiedAsCannotMakeDecision")]
        #pragma warning disable CS1591
        GoodReclassifiedAsCannotMakeDecision,
        #pragma warning restore CS1591
        [EnumMember(Value = "badReclassifiedAsGood")]
        #pragma warning disable CS1591
        BadReclassifiedAsGood,
        #pragma warning restore CS1591
        [EnumMember(Value = "badReclassifiedAsBulk")]
        #pragma warning disable CS1591
        BadReclassifiedAsBulk,
        #pragma warning restore CS1591
        [EnumMember(Value = "badReclassifiedAsBad")]
        #pragma warning disable CS1591
        BadReclassifiedAsBad,
        #pragma warning restore CS1591
        [EnumMember(Value = "badReclassifiedAsCannotMakeDecision")]
        #pragma warning disable CS1591
        BadReclassifiedAsCannotMakeDecision,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue,
        #pragma warning restore CS1591
        [EnumMember(Value = "willNotifyOnceDone")]
        #pragma warning disable CS1591
        WillNotifyOnceDone,
        #pragma warning restore CS1591
        [EnumMember(Value = "checkUserReportedSettings")]
        #pragma warning disable CS1591
        CheckUserReportedSettings,
        #pragma warning restore CS1591
        [EnumMember(Value = "partOfEducationCampaign")]
        #pragma warning disable CS1591
        PartOfEducationCampaign,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedByAdvancedDelivery")]
        #pragma warning disable CS1591
        AllowedByAdvancedDelivery,
        #pragma warning restore CS1591
        [EnumMember(Value = "allowedByEnhancedFiltering")]
        #pragma warning disable CS1591
        AllowedByEnhancedFiltering,
        #pragma warning restore CS1591
        [EnumMember(Value = "itemDeleted")]
        #pragma warning disable CS1591
        ItemDeleted,
        #pragma warning restore CS1591
        [EnumMember(Value = "itemFoundClean")]
        #pragma warning disable CS1591
        ItemFoundClean,
        #pragma warning restore CS1591
        [EnumMember(Value = "itemFoundMalicious")]
        #pragma warning disable CS1591
        ItemFoundMalicious,
        #pragma warning restore CS1591
        [EnumMember(Value = "unableToMakeDecision")]
        #pragma warning disable CS1591
        UnableToMakeDecision,
        #pragma warning restore CS1591
        [EnumMember(Value = "domainResembledYourOrganization")]
        #pragma warning disable CS1591
        DomainResembledYourOrganization,
        #pragma warning restore CS1591
        [EnumMember(Value = "endUserBeingImpersonated")]
        #pragma warning disable CS1591
        EndUserBeingImpersonated,
        #pragma warning restore CS1591
        [EnumMember(Value = "associatedWithBrand")]
        #pragma warning disable CS1591
        AssociatedWithBrand,
        #pragma warning restore CS1591
        [EnumMember(Value = "senderFailedAuthentication")]
        #pragma warning disable CS1591
        SenderFailedAuthentication,
        #pragma warning restore CS1591
        [EnumMember(Value = "endUserBeingSpoofed")]
        #pragma warning disable CS1591
        EndUserBeingSpoofed,
        #pragma warning restore CS1591
        [EnumMember(Value = "itemFoundBulk")]
        #pragma warning disable CS1591
        ItemFoundBulk,
        #pragma warning restore CS1591
        [EnumMember(Value = "itemNotReceivedByService")]
        #pragma warning disable CS1591
        ItemNotReceivedByService,
        #pragma warning restore CS1591
        [EnumMember(Value = "itemFoundSpam")]
        #pragma warning disable CS1591
        ItemFoundSpam,
        #pragma warning restore CS1591
    }
}
