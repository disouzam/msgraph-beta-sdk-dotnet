// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Possible values for LocalSecurityOptionsInformationShownOnLockScreenType</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum LocalSecurityOptionsInformationShownOnLockScreenType
    {
        /// <summary>Not Configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>User display name, domain and user names</summary>
        [EnumMember(Value = "userDisplayNameDomainUser")]
        UserDisplayNameDomainUser,
        /// <summary>User display name only</summary>
        [EnumMember(Value = "userDisplayNameOnly")]
        UserDisplayNameOnly,
        /// <summary>Do not display user information</summary>
        [EnumMember(Value = "doNotDisplayUser")]
        DoNotDisplayUser,
    }
}
