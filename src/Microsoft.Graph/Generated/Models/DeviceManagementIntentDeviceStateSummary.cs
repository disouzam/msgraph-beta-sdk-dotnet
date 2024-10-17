// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Entity that represents device state summary for an intent
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementIntentDeviceStateSummary : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Number of devices in conflict</summary>
        public int? ConflictCount
        {
            get { return BackingStore?.Get<int?>("conflictCount"); }
            set { BackingStore?.Set("conflictCount", value); }
        }
        /// <summary>Number of error devices</summary>
        public int? ErrorCount
        {
            get { return BackingStore?.Get<int?>("errorCount"); }
            set { BackingStore?.Set("errorCount", value); }
        }
        /// <summary>Number of failed devices</summary>
        public int? FailedCount
        {
            get { return BackingStore?.Get<int?>("failedCount"); }
            set { BackingStore?.Set("failedCount", value); }
        }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableCount
        {
            get { return BackingStore?.Get<int?>("notApplicableCount"); }
            set { BackingStore?.Set("notApplicableCount", value); }
        }
        /// <summary>Number of not applicable devices due to mismatch platform and policy</summary>
        public int? NotApplicablePlatformCount
        {
            get { return BackingStore?.Get<int?>("notApplicablePlatformCount"); }
            set { BackingStore?.Set("notApplicablePlatformCount", value); }
        }
        /// <summary>Number of succeeded devices</summary>
        public int? SuccessCount
        {
            get { return BackingStore?.Get<int?>("successCount"); }
            set { BackingStore?.Set("successCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceStateSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceStateSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "conflictCount", n => { ConflictCount = n.GetIntValue(); } },
                { "errorCount", n => { ErrorCount = n.GetIntValue(); } },
                { "failedCount", n => { FailedCount = n.GetIntValue(); } },
                { "notApplicableCount", n => { NotApplicableCount = n.GetIntValue(); } },
                { "notApplicablePlatformCount", n => { NotApplicablePlatformCount = n.GetIntValue(); } },
                { "successCount", n => { SuccessCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("conflictCount", ConflictCount);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("failedCount", FailedCount);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("notApplicablePlatformCount", NotApplicablePlatformCount);
            writer.WriteIntValue("successCount", SuccessCount);
        }
    }
}
#pragma warning restore CS0618
