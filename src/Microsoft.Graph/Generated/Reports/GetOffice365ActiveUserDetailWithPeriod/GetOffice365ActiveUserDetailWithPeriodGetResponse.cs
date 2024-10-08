// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Reports.GetOffice365ActiveUserDetailWithPeriod
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class GetOffice365ActiveUserDetailWithPeriodGetResponse : global::Microsoft.Graph.Beta.Models.BaseCollectionPaginationCountResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Office365ActiveUserDetail>? Value
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Office365ActiveUserDetail>?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Office365ActiveUserDetail> Value
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Office365ActiveUserDetail>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Reports.GetOffice365ActiveUserDetailWithPeriod.GetOffice365ActiveUserDetailWithPeriodGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Reports.GetOffice365ActiveUserDetailWithPeriod.GetOffice365ActiveUserDetailWithPeriodGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Reports.GetOffice365ActiveUserDetailWithPeriod.GetOffice365ActiveUserDetailWithPeriodGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "value", n => { Value = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Office365ActiveUserDetail>(global::Microsoft.Graph.Beta.Models.Office365ActiveUserDetail.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Office365ActiveUserDetail>("value", Value);
        }
    }
}
#pragma warning restore CS0618
