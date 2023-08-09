// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Wired Network authentication method.</summary>
    public enum WiredNetworkAuthenticationMethod {
        /// <summary>Use an identity certificate for authentication.</summary>
        [EnumMember(Value = "certificate")]
        Certificate,
        /// <summary>Use username and password for authentication.</summary>
        [EnumMember(Value = "usernameAndPassword")]
        UsernameAndPassword,
        /// <summary>Use Derived Credential for authentication.</summary>
        [EnumMember(Value = "derivedCredential")]
        DerivedCredential,
        /// <summary>Sentinel member for cases where the client cannot handle the new enum values.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
