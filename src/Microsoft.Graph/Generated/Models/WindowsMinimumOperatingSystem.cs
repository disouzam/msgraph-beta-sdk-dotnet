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
    /// <summary>
    /// The minimum operating system required for a Windows mobile app.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WindowsMinimumOperatingSystem : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>Windows version 10.0 or later.</summary>
        public bool? V100
        {
            get { return BackingStore?.Get<bool?>("v10_0"); }
            set { BackingStore?.Set("v10_0", value); }
        }
        /// <summary>Windows 10 1607 or later.</summary>
        public bool? V101607
        {
            get { return BackingStore?.Get<bool?>("v10_1607"); }
            set { BackingStore?.Set("v10_1607", value); }
        }
        /// <summary>Windows 10 1703 or later.</summary>
        public bool? V101703
        {
            get { return BackingStore?.Get<bool?>("v10_1703"); }
            set { BackingStore?.Set("v10_1703", value); }
        }
        /// <summary>Windows 10 1709 or later.</summary>
        public bool? V101709
        {
            get { return BackingStore?.Get<bool?>("v10_1709"); }
            set { BackingStore?.Set("v10_1709", value); }
        }
        /// <summary>Windows 10 1803 or later.</summary>
        public bool? V101803
        {
            get { return BackingStore?.Get<bool?>("v10_1803"); }
            set { BackingStore?.Set("v10_1803", value); }
        }
        /// <summary>Windows 10 1809 or later.</summary>
        public bool? V101809
        {
            get { return BackingStore?.Get<bool?>("v10_1809"); }
            set { BackingStore?.Set("v10_1809", value); }
        }
        /// <summary>Windows 10 1903 or later.</summary>
        public bool? V101903
        {
            get { return BackingStore?.Get<bool?>("v10_1903"); }
            set { BackingStore?.Set("v10_1903", value); }
        }
        /// <summary>Windows 10 1909 or later.</summary>
        public bool? V101909
        {
            get { return BackingStore?.Get<bool?>("v10_1909"); }
            set { BackingStore?.Set("v10_1909", value); }
        }
        /// <summary>Windows 10 2004 or later.</summary>
        public bool? V102004
        {
            get { return BackingStore?.Get<bool?>("v10_2004"); }
            set { BackingStore?.Set("v10_2004", value); }
        }
        /// <summary>Windows 10 21H1 or later.</summary>
        public bool? V1021H1
        {
            get { return BackingStore?.Get<bool?>("v10_21H1"); }
            set { BackingStore?.Set("v10_21H1", value); }
        }
        /// <summary>Windows 10 2H20 or later.</summary>
        public bool? V102H20
        {
            get { return BackingStore?.Get<bool?>("v10_2H20"); }
            set { BackingStore?.Set("v10_2H20", value); }
        }
        /// <summary>Windows version 8.0 or later.</summary>
        public bool? V80
        {
            get { return BackingStore?.Get<bool?>("v8_0"); }
            set { BackingStore?.Set("v8_0", value); }
        }
        /// <summary>Windows version 8.1 or later.</summary>
        public bool? V81
        {
            get { return BackingStore?.Get<bool?>("v8_1"); }
            set { BackingStore?.Set("v8_1", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WindowsMinimumOperatingSystem"/> and sets the default values.
        /// </summary>
        public WindowsMinimumOperatingSystem()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsMinimumOperatingSystem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.WindowsMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "v10_0", n => { V100 = n.GetBoolValue(); } },
                { "v10_1607", n => { V101607 = n.GetBoolValue(); } },
                { "v10_1703", n => { V101703 = n.GetBoolValue(); } },
                { "v10_1709", n => { V101709 = n.GetBoolValue(); } },
                { "v10_1803", n => { V101803 = n.GetBoolValue(); } },
                { "v10_1809", n => { V101809 = n.GetBoolValue(); } },
                { "v10_1903", n => { V101903 = n.GetBoolValue(); } },
                { "v10_1909", n => { V101909 = n.GetBoolValue(); } },
                { "v10_2004", n => { V102004 = n.GetBoolValue(); } },
                { "v10_21H1", n => { V1021H1 = n.GetBoolValue(); } },
                { "v10_2H20", n => { V102H20 = n.GetBoolValue(); } },
                { "v8_0", n => { V80 = n.GetBoolValue(); } },
                { "v8_1", n => { V81 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("v10_0", V100);
            writer.WriteBoolValue("v10_1607", V101607);
            writer.WriteBoolValue("v10_1703", V101703);
            writer.WriteBoolValue("v10_1709", V101709);
            writer.WriteBoolValue("v10_1803", V101803);
            writer.WriteBoolValue("v10_1809", V101809);
            writer.WriteBoolValue("v10_1903", V101903);
            writer.WriteBoolValue("v10_1909", V101909);
            writer.WriteBoolValue("v10_2004", V102004);
            writer.WriteBoolValue("v10_21H1", V1021H1);
            writer.WriteBoolValue("v10_2H20", V102H20);
            writer.WriteBoolValue("v8_0", V80);
            writer.WriteBoolValue("v8_1", V81);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
