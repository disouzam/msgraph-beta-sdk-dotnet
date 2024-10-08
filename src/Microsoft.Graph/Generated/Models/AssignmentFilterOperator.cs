// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Represents the different type of operators which can be used to craft the AssignmentFilter rule.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum AssignmentFilterOperator
    {
        /// <summary>Indicates operator is not set</summary>
        [EnumMember(Value = "notSet")]
        NotSet,
        /// <summary>Indicates the devices whose property value equals the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "equals")]
        Equals,
        /// <summary>Indicates the devices whose property value not equals the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "notEquals")]
        NotEquals,
        /// <summary>Indicates the devices whose property value starts with the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "startsWith")]
        StartsWith,
        /// <summary>Indicates the devices whose property value does not start with the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "notStartsWith")]
        NotStartsWith,
        /// <summary>Indicates the devices whose property value contains the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "contains")]
        Contains,
        /// <summary>Indicates the devices whose property value does not contain the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "notContains")]
        NotContains,
        /// <summary>Indicates the devices whose property value equals one of the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "in")]
        In,
        /// <summary>Indicates the devices whose property value does not equals any of the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "notIn")]
        NotIn,
        /// <summary>Indicates the devices whose property value ends with the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "endsWith")]
        EndsWith,
        /// <summary>Indicates the devices whose property value does not end with the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "notEndsWith")]
        NotEndsWith,
        /// <summary>Indicates the devices whose property value is greater than the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "greaterThan")]
        GreaterThan,
        /// <summary>`Indicates the devices whose property value is greater than or equal to the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "greaterThanOrEquals")]
        GreaterThanOrEquals,
        /// <summary>Indicates the devices whose property value is less than the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "lessThan")]
        LessThan,
        /// <summary>Indicates the devices whose property value is less than or equal to the configured input in Assignment Filters.</summary>
        [EnumMember(Value = "lessThanOrEquals")]
        LessThanOrEquals,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
