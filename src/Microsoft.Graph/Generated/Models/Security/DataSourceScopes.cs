// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    [Flags]
    public enum DataSourceScopes {
        [EnumMember(Value = "none")]
        None = 1,
        [EnumMember(Value = "allTenantMailboxes")]
        AllTenantMailboxes = 2,
        [EnumMember(Value = "allTenantSites")]
        AllTenantSites = 4,
        [EnumMember(Value = "allCaseCustodians")]
        AllCaseCustodians = 8,
        [EnumMember(Value = "allCaseNoncustodialDataSources")]
        AllCaseNoncustodialDataSources = 16,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 32,
    }
}
