// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class YearTimePeriodDefinition : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the year. Maximum supported length is 100 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The last day of the year using ISO 8601 format for date.</summary>
        public Date? EndDate
        {
            get { return BackingStore?.Get<Date?>("endDate"); }
            set { BackingStore?.Set("endDate", value); }
        }
        /// <summary>The first day of the year using ISO 8601 format for date.</summary>
        public Date? StartDate
        {
            get { return BackingStore?.Get<Date?>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
        /// <summary>The year property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IndustryData.YearReferenceValue? Year
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IndustryData.YearReferenceValue?>("year"); }
            set { BackingStore?.Set("year", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IndustryData.YearReferenceValue Year
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IndustryData.YearReferenceValue>("year"); }
            set { BackingStore?.Set("year", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IndustryData.YearTimePeriodDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IndustryData.YearTimePeriodDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IndustryData.YearTimePeriodDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "endDate", n => { EndDate = n.GetDateValue(); } },
                { "startDate", n => { StartDate = n.GetDateValue(); } },
                { "year", n => { Year = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IndustryData.YearReferenceValue>(global::Microsoft.Graph.Beta.Models.IndustryData.YearReferenceValue.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IndustryData.YearReferenceValue>("year", Year);
        }
    }
}
#pragma warning restore CS0618
