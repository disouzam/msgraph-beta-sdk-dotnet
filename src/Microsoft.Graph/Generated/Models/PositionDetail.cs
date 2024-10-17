// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PositionDetail : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Information about the company or employer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CompanyDetail? Company
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CompanyDetail?>("company"); }
            set { BackingStore?.Set("company", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CompanyDetail Company
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CompanyDetail>("company"); }
            set { BackingStore?.Set("company", value); }
        }
#endif
        /// <summary>A description for the position in question.</summary>
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
        /// <summary>The date when the position ended.</summary>
        public Date? EndMonthYear
        {
            get { return BackingStore?.Get<Date?>("endMonthYear"); }
            set { BackingStore?.Set("endMonthYear", value); }
        }
        /// <summary>The title of the position.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle
        {
            get { return BackingStore?.Get<string?>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#nullable restore
#else
        public string JobTitle
        {
            get { return BackingStore?.Get<string>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#endif
        /// <summary>The place where the employee is within the organizational hierarchy.</summary>
        public int? Layer
        {
            get { return BackingStore?.Get<int?>("layer"); }
            set { BackingStore?.Set("layer", value); }
        }
        /// <summary>The employee’s experience or management level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Level
        {
            get { return BackingStore?.Get<string?>("level"); }
            set { BackingStore?.Set("level", value); }
        }
#nullable restore
#else
        public string Level
        {
            get { return BackingStore?.Get<string>("level"); }
            set { BackingStore?.Set("level", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The role the position entailed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role
        {
            get { return BackingStore?.Get<string?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#nullable restore
#else
        public string Role
        {
            get { return BackingStore?.Get<string>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#endif
        /// <summary>An optional job title for the position.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecondaryJobTitle
        {
            get { return BackingStore?.Get<string?>("secondaryJobTitle"); }
            set { BackingStore?.Set("secondaryJobTitle", value); }
        }
#nullable restore
#else
        public string SecondaryJobTitle
        {
            get { return BackingStore?.Get<string>("secondaryJobTitle"); }
            set { BackingStore?.Set("secondaryJobTitle", value); }
        }
#endif
        /// <summary>An optional role for the position entailed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecondaryRole
        {
            get { return BackingStore?.Get<string?>("secondaryRole"); }
            set { BackingStore?.Set("secondaryRole", value); }
        }
#nullable restore
#else
        public string SecondaryRole
        {
            get { return BackingStore?.Get<string>("secondaryRole"); }
            set { BackingStore?.Set("secondaryRole", value); }
        }
#endif
        /// <summary>The start date of the position.</summary>
        public Date? StartMonthYear
        {
            get { return BackingStore?.Get<Date?>("startMonthYear"); }
            set { BackingStore?.Set("startMonthYear", value); }
        }
        /// <summary>The summary of the position.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary
        {
            get { return BackingStore?.Get<string?>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#nullable restore
#else
        public string Summary
        {
            get { return BackingStore?.Get<string>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.PositionDetail"/> and sets the default values.
        /// </summary>
        public PositionDetail()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PositionDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.PositionDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.PositionDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "company", n => { Company = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CompanyDetail>(global::Microsoft.Graph.Beta.Models.CompanyDetail.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "endMonthYear", n => { EndMonthYear = n.GetDateValue(); } },
                { "jobTitle", n => { JobTitle = n.GetStringValue(); } },
                { "layer", n => { Layer = n.GetIntValue(); } },
                { "level", n => { Level = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "role", n => { Role = n.GetStringValue(); } },
                { "secondaryJobTitle", n => { SecondaryJobTitle = n.GetStringValue(); } },
                { "secondaryRole", n => { SecondaryRole = n.GetStringValue(); } },
                { "startMonthYear", n => { StartMonthYear = n.GetDateValue(); } },
                { "summary", n => { Summary = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CompanyDetail>("company", Company);
            writer.WriteStringValue("description", Description);
            writer.WriteDateValue("endMonthYear", EndMonthYear);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteIntValue("layer", Layer);
            writer.WriteStringValue("level", Level);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("role", Role);
            writer.WriteStringValue("secondaryJobTitle", SecondaryJobTitle);
            writer.WriteStringValue("secondaryRole", SecondaryRole);
            writer.WriteDateValue("startMonthYear", StartMonthYear);
            writer.WriteStringValue("summary", Summary);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
