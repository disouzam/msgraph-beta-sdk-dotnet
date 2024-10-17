// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Category Ingestion source</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum IngestionSource
    {
        /// <summary>Indicates unknown category</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates the category is ingested by IT admin with sufficient permissions through custom ingestion process</summary>
        [EnumMember(Value = "custom")]
        Custom,
        /// <summary>Indicates the category is ingested through system ingestion process</summary>
        [EnumMember(Value = "builtIn")]
        BuiltIn,
        /// <summary>Unknown future enum value</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
