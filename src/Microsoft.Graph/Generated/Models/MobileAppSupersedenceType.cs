// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Indicates the supersedence type associated with a relationship between two mobile apps.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum MobileAppSupersedenceType
    {
        /// <summary>Indicates that the child app should be updated by the internal logic of the parent app.</summary>
        [EnumMember(Value = "update")]
        Update,
        /// <summary>Indicates that the child app should be uninstalled before installing the parent app.</summary>
        [EnumMember(Value = "replace")]
        Replace,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
