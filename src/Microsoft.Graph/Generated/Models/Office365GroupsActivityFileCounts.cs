// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Office365GroupsActivityFileCounts : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The number of files that were viewed, edited, shared, or synced in the group&apos;s SharePoint document library.</summary>
        public long? Active
        {
            get { return BackingStore?.Get<long?>("active"); }
            set { BackingStore?.Set("active", value); }
        }
        /// <summary>The date on which a number of files were active in the group&apos;s SharePoint site.</summary>
        public Date? ReportDate
        {
            get { return BackingStore?.Get<Date?>("reportDate"); }
            set { BackingStore?.Set("reportDate", value); }
        }
        /// <summary>The number of days the report covers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportPeriod
        {
            get { return BackingStore?.Get<string?>("reportPeriod"); }
            set { BackingStore?.Set("reportPeriod", value); }
        }
#nullable restore
#else
        public string ReportPeriod
        {
            get { return BackingStore?.Get<string>("reportPeriod"); }
            set { BackingStore?.Set("reportPeriod", value); }
        }
#endif
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate
        {
            get { return BackingStore?.Get<Date?>("reportRefreshDate"); }
            set { BackingStore?.Set("reportRefreshDate", value); }
        }
        /// <summary>The total number of files in the group&apos;s SharePoint document library.</summary>
        public long? Total
        {
            get { return BackingStore?.Get<long?>("total"); }
            set { BackingStore?.Set("total", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Office365GroupsActivityFileCounts"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Office365GroupsActivityFileCounts CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Office365GroupsActivityFileCounts();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "active", n => { Active = n.GetLongValue(); } },
                { "reportDate", n => { ReportDate = n.GetDateValue(); } },
                { "reportPeriod", n => { ReportPeriod = n.GetStringValue(); } },
                { "reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                { "total", n => { Total = n.GetLongValue(); } },
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
            writer.WriteLongValue("active", Active);
            writer.WriteDateValue("reportDate", ReportDate);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("total", Total);
        }
    }
}
#pragma warning restore CS0618
