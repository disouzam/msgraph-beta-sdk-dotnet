// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class SimulationAutomation : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Identity of the user who created the attack simulation automation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.EmailIdentity? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EmailIdentity?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.EmailIdentity CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EmailIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Date and time when the attack simulation automation was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description of the attack simulation automation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Display name of the attack simulation automation. Supports $filter and $orderby.</summary>
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
        /// <summary>Identity of the user who most recently modified the attack simulation automation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.EmailIdentity? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EmailIdentity?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.EmailIdentity LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EmailIdentity>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>Date and time when the attack simulation automation was most recently modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Date and time of the latest run of the attack simulation automation.</summary>
        public DateTimeOffset? LastRunDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRunDateTime"); }
            set { BackingStore?.Set("lastRunDateTime", value); }
        }
        /// <summary>Date and time of the upcoming run of the attack simulation automation.</summary>
        public DateTimeOffset? NextRunDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("nextRunDateTime"); }
            set { BackingStore?.Set("nextRunDateTime", value); }
        }
        /// <summary>A collection of simulation automation runs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.SimulationAutomationRun>? Runs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SimulationAutomationRun>?>("runs"); }
            set { BackingStore?.Set("runs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.SimulationAutomationRun> Runs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SimulationAutomationRun>>("runs"); }
            set { BackingStore?.Set("runs", value); }
        }
#endif
        /// <summary>Status of the attack simulation automation. Supports $filter and $orderby. The possible values are: unknown, draft, notRunning, running, completed, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.SimulationAutomationStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SimulationAutomationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SimulationAutomation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.SimulationAutomation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.SimulationAutomation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.EmailIdentity>(global::Microsoft.Graph.Beta.Models.EmailIdentity.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.EmailIdentity>(global::Microsoft.Graph.Beta.Models.EmailIdentity.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastRunDateTime", n => { LastRunDateTime = n.GetDateTimeOffsetValue(); } },
                { "nextRunDateTime", n => { NextRunDateTime = n.GetDateTimeOffsetValue(); } },
                { "runs", n => { Runs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SimulationAutomationRun>(global::Microsoft.Graph.Beta.Models.SimulationAutomationRun.CreateFromDiscriminatorValue)?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.SimulationAutomationStatus>(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastRunDateTime", LastRunDateTime);
            writer.WriteDateTimeOffsetValue("nextRunDateTime", NextRunDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SimulationAutomationRun>("runs", Runs);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.SimulationAutomationStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
