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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class OnlineMeetingInfo : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The ID of the conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConferenceId
        {
            get { return BackingStore?.Get<string?>("conferenceId"); }
            set { BackingStore?.Set("conferenceId", value); }
        }
#nullable restore
#else
        public string ConferenceId
        {
            get { return BackingStore?.Get<string>("conferenceId"); }
            set { BackingStore?.Set("conferenceId", value); }
        }
#endif
        /// <summary>The external link that launches the online meeting. This is a URL that clients launch into a browser and will redirect the user to join the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinUrl
        {
            get { return BackingStore?.Get<string?>("joinUrl"); }
            set { BackingStore?.Set("joinUrl", value); }
        }
#nullable restore
#else
        public string JoinUrl
        {
            get { return BackingStore?.Get<string>("joinUrl"); }
            set { BackingStore?.Set("joinUrl", value); }
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
        /// <summary>All of the phone numbers associated with this conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Phone>? Phones
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Phone>?>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Phone> Phones
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Phone>>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#endif
        /// <summary>The preformatted quick dial for this call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QuickDial
        {
            get { return BackingStore?.Get<string?>("quickDial"); }
            set { BackingStore?.Set("quickDial", value); }
        }
#nullable restore
#else
        public string QuickDial
        {
            get { return BackingStore?.Get<string>("quickDial"); }
            set { BackingStore?.Set("quickDial", value); }
        }
#endif
        /// <summary>The toll free numbers that can be used to join the conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TollFreeNumbers
        {
            get { return BackingStore?.Get<List<string>?>("tollFreeNumbers"); }
            set { BackingStore?.Set("tollFreeNumbers", value); }
        }
#nullable restore
#else
        public List<string> TollFreeNumbers
        {
            get { return BackingStore?.Get<List<string>>("tollFreeNumbers"); }
            set { BackingStore?.Set("tollFreeNumbers", value); }
        }
#endif
        /// <summary>The toll number that can be used to join the conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TollNumber
        {
            get { return BackingStore?.Get<string?>("tollNumber"); }
            set { BackingStore?.Set("tollNumber", value); }
        }
#nullable restore
#else
        public string TollNumber
        {
            get { return BackingStore?.Get<string>("tollNumber"); }
            set { BackingStore?.Set("tollNumber", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.OnlineMeetingInfo"/> and sets the default values.
        /// </summary>
        public OnlineMeetingInfo()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OnlineMeetingInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.OnlineMeetingInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.OnlineMeetingInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "conferenceId", n => { ConferenceId = n.GetStringValue(); } },
                { "joinUrl", n => { JoinUrl = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "phones", n => { Phones = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Phone>(global::Microsoft.Graph.Beta.Models.Phone.CreateFromDiscriminatorValue)?.AsList(); } },
                { "quickDial", n => { QuickDial = n.GetStringValue(); } },
                { "tollFreeNumbers", n => { TollFreeNumbers = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "tollNumber", n => { TollNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("conferenceId", ConferenceId);
            writer.WriteStringValue("joinUrl", JoinUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Phone>("phones", Phones);
            writer.WriteStringValue("quickDial", QuickDial);
            writer.WriteCollectionOfPrimitiveValues<string>("tollFreeNumbers", TollFreeNumbers);
            writer.WriteStringValue("tollNumber", TollNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
