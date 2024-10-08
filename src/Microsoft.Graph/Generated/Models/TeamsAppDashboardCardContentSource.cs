// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class TeamsAppDashboardCardContentSource : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The configuration for the bot source. Required if sourceType is set to bot.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardBotConfiguration? BotConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardBotConfiguration?>("botConfiguration"); }
            set { BackingStore?.Set("botConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardBotConfiguration BotConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardBotConfiguration>("botConfiguration"); }
            set { BackingStore?.Set("botConfiguration", value); }
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
        /// <summary>Represents the type of source that powers the content of the dashboard card. The possible values are: bot, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardSourceType? SourceType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardSourceType?>("sourceType"); }
            set { BackingStore?.Set("sourceType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardContentSource"/> and sets the default values.
        /// </summary>
        public TeamsAppDashboardCardContentSource()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardContentSource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardContentSource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardContentSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "botConfiguration", n => { BotConfiguration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardBotConfiguration>(global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardBotConfiguration.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "sourceType", n => { SourceType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardSourceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardBotConfiguration>("botConfiguration", BotConfiguration);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.TeamsAppDashboardCardSourceType>("sourceType", SourceType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
