// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Indicates the status of the device in the correlation group. Eg: Device status can be anomalous, affected, at risk.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum UserExperienceAnalyticsDeviceStatus
    {
        /// <summary>Indicates the the device is part of the anomaly.</summary>
        [EnumMember(Value = "anomalous")]
        Anomalous,
        /// <summary>Indicates the device is affected by the anomaly and is part of the correlation group.</summary>
        [EnumMember(Value = "affected")]
        Affected,
        /// <summary>Indicates the device is not part of the anomaly but is part of the correlation group.</summary>
        [EnumMember(Value = "atRisk")]
        AtRisk,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
