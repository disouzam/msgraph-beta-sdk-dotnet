// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Represents the current consent status of the associated `managedAppLogCollectionRequest`.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ManagedAppLogUploadConsent
    {
        /// <summary>Default. Indicates app log consent state is &apos;Unknown&apos;. This state is automatically assigned at request creation time and is updated when the log collection completes.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>The User has Declined the Log Collection Request. The Log collection and uploads will not be initiated/triggered, and the log collection request will be abandoned.</summary>
        [EnumMember(Value = "declined")]
        Declined,
        /// <summary>The User has Accepted the Log Collection Request. The log collection and upload will be initiated.</summary>
        [EnumMember(Value = "accepted")]
        Accepted,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
