// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UsageProfilingPoint : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The internetAccessTrafficCount property</summary>
        public long? InternetAccessTrafficCount
        {
            get { return BackingStore?.Get<long?>("internetAccessTrafficCount"); }
            set { BackingStore?.Set("internetAccessTrafficCount", value); }
        }
        /// <summary>The microsoft365AccessTrafficCount property</summary>
        public long? Microsoft365AccessTrafficCount
        {
            get { return BackingStore?.Get<long?>("microsoft365AccessTrafficCount"); }
            set { BackingStore?.Set("microsoft365AccessTrafficCount", value); }
        }
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
        /// <summary>The privateAccessTrafficCount property</summary>
        public long? PrivateAccessTrafficCount
        {
            get { return BackingStore?.Get<long?>("privateAccessTrafficCount"); }
            set { BackingStore?.Set("privateAccessTrafficCount", value); }
        }
        /// <summary>The timeStampDateTime property</summary>
        public DateTimeOffset? TimeStampDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("timeStampDateTime"); }
            set { BackingStore?.Set("timeStampDateTime", value); }
        }
        /// <summary>The totalTrafficCount property</summary>
        public long? TotalTrafficCount
        {
            get { return BackingStore?.Get<long?>("totalTrafficCount"); }
            set { BackingStore?.Set("totalTrafficCount", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Networkaccess.UsageProfilingPoint"/> and sets the default values.
        /// </summary>
        public UsageProfilingPoint()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Networkaccess.UsageProfilingPoint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.Networkaccess.UsageProfilingPoint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Networkaccess.UsageProfilingPoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "internetAccessTrafficCount", n => { InternetAccessTrafficCount = n.GetLongValue(); } },
                { "microsoft365AccessTrafficCount", n => { Microsoft365AccessTrafficCount = n.GetLongValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "privateAccessTrafficCount", n => { PrivateAccessTrafficCount = n.GetLongValue(); } },
                { "timeStampDateTime", n => { TimeStampDateTime = n.GetDateTimeOffsetValue(); } },
                { "totalTrafficCount", n => { TotalTrafficCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("internetAccessTrafficCount", InternetAccessTrafficCount);
            writer.WriteLongValue("microsoft365AccessTrafficCount", Microsoft365AccessTrafficCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("privateAccessTrafficCount", PrivateAccessTrafficCount);
            writer.WriteDateTimeOffsetValue("timeStampDateTime", TimeStampDateTime);
            writer.WriteLongValue("totalTrafficCount", TotalTrafficCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
