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
    public partial class LicenseDetails : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Information about the service plans assigned with the license. Read-only. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ServicePlanInfo>? ServicePlans
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ServicePlanInfo>?>("servicePlans"); }
            set { BackingStore?.Set("servicePlans", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ServicePlanInfo> ServicePlans
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ServicePlanInfo>>("servicePlans"); }
            set { BackingStore?.Set("servicePlans", value); }
        }
#endif
        /// <summary>Unique identifier (GUID) for the service SKU. Equal to the skuId property on the related subscribedSku object. Read-only.</summary>
        public Guid? SkuId
        {
            get { return BackingStore?.Get<Guid?>("skuId"); }
            set { BackingStore?.Set("skuId", value); }
        }
        /// <summary>Unique SKU display name. Equal to the skuPartNumber on the related subscribedSku object; for example, AAD_Premium. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SkuPartNumber
        {
            get { return BackingStore?.Get<string?>("skuPartNumber"); }
            set { BackingStore?.Set("skuPartNumber", value); }
        }
#nullable restore
#else
        public string SkuPartNumber
        {
            get { return BackingStore?.Get<string>("skuPartNumber"); }
            set { BackingStore?.Set("skuPartNumber", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.LicenseDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.LicenseDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.LicenseDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "servicePlans", n => { ServicePlans = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ServicePlanInfo>(global::Microsoft.Graph.Beta.Models.ServicePlanInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "skuId", n => { SkuId = n.GetGuidValue(); } },
                { "skuPartNumber", n => { SkuPartNumber = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ServicePlanInfo>("servicePlans", ServicePlans);
            writer.WriteGuidValue("skuId", SkuId);
            writer.WriteStringValue("skuPartNumber", SkuPartNumber);
        }
    }
}
#pragma warning restore CS0618
