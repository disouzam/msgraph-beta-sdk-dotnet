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
    /// <summary>
    /// The number of devices remediated by a device health script on a given date.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DeviceHealthScriptRemediationHistoryData : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date on which devices were remediated by the device health script.</summary>
        public Date? Date
        {
            get { return BackingStore?.Get<Date?>("date"); }
            set { BackingStore?.Set("date", value); }
        }
        /// <summary>The number of devices for which the detection script found an issue.</summary>
        public int? DetectFailedDeviceCount
        {
            get { return BackingStore?.Get<int?>("detectFailedDeviceCount"); }
            set { BackingStore?.Set("detectFailedDeviceCount", value); }
        }
        /// <summary>The number of devices that were found to have no issue by the device health script.</summary>
        public int? NoIssueDeviceCount
        {
            get { return BackingStore?.Get<int?>("noIssueDeviceCount"); }
            set { BackingStore?.Set("noIssueDeviceCount", value); }
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
        /// <summary>The number of devices remediated by the device health script.</summary>
        public int? RemediatedDeviceCount
        {
            get { return BackingStore?.Get<int?>("remediatedDeviceCount"); }
            set { BackingStore?.Set("remediatedDeviceCount", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeviceHealthScriptRemediationHistoryData"/> and sets the default values.
        /// </summary>
        public DeviceHealthScriptRemediationHistoryData()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceHealthScriptRemediationHistoryData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.DeviceHealthScriptRemediationHistoryData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceHealthScriptRemediationHistoryData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "date", n => { Date = n.GetDateValue(); } },
                { "detectFailedDeviceCount", n => { DetectFailedDeviceCount = n.GetIntValue(); } },
                { "noIssueDeviceCount", n => { NoIssueDeviceCount = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "remediatedDeviceCount", n => { RemediatedDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateValue("date", Date);
            writer.WriteIntValue("detectFailedDeviceCount", DetectFailedDeviceCount);
            writer.WriteIntValue("noIssueDeviceCount", NoIssueDeviceCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
