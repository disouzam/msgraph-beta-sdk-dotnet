// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for the Certificate Destination Store.</summary>
    public enum CertificateDestinationStore {
        /// <summary>Computer Certificate Store - Root.</summary>
        [EnumMember(Value = "computerCertStoreRoot")]
        ComputerCertStoreRoot,
        /// <summary>Computer Certificate Store - Intermediate.</summary>
        [EnumMember(Value = "computerCertStoreIntermediate")]
        ComputerCertStoreIntermediate,
        /// <summary>User Certificate Store - Intermediate.</summary>
        [EnumMember(Value = "userCertStoreIntermediate")]
        UserCertStoreIntermediate,
    }
}
