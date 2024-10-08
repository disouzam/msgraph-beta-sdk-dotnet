// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class CloudPcFrontLineServicePlan : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The allotmentLicensesCount property</summary>
        public int? AllotmentLicensesCount
        {
            get { return BackingStore?.Get<int?>("allotmentLicensesCount"); }
            set { BackingStore?.Set("allotmentLicensesCount", value); }
        }
        /// <summary>The display name of the front-line service plan. For example, 2vCPU/8GB/128GB Front-line or 4vCPU/16GB/256GB Front-line.</summary>
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
        /// <summary>The total number of front-line service plans purchased by the customer.</summary>
        public int? TotalCount
        {
            get { return BackingStore?.Get<int?>("totalCount"); }
            set { BackingStore?.Set("totalCount", value); }
        }
        /// <summary>The number of service plans that have been used for the account.</summary>
        public int? UsedCount
        {
            get { return BackingStore?.Get<int?>("usedCount"); }
            set { BackingStore?.Set("usedCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPcFrontLineServicePlan"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CloudPcFrontLineServicePlan CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CloudPcFrontLineServicePlan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allotmentLicensesCount", n => { AllotmentLicensesCount = n.GetIntValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "totalCount", n => { TotalCount = n.GetIntValue(); } },
                { "usedCount", n => { UsedCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("allotmentLicensesCount", AllotmentLicensesCount);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("totalCount", TotalCount);
            writer.WriteIntValue("usedCount", UsedCount);
        }
    }
}
#pragma warning restore CS0618
