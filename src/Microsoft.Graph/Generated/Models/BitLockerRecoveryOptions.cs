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
    /// BitLocker Recovery Options.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class BitLockerRecoveryOptions : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether to block certificate-based data recovery agent.</summary>
        public bool? BlockDataRecoveryAgent
        {
            get { return BackingStore?.Get<bool?>("blockDataRecoveryAgent"); }
            set { BackingStore?.Set("blockDataRecoveryAgent", value); }
        }
        /// <summary>Indicates whether or not to enable BitLocker until recovery information is stored in AD DS.</summary>
        public bool? EnableBitLockerAfterRecoveryInformationToStore
        {
            get { return BackingStore?.Get<bool?>("enableBitLockerAfterRecoveryInformationToStore"); }
            set { BackingStore?.Set("enableBitLockerAfterRecoveryInformationToStore", value); }
        }
        /// <summary>Indicates whether or not to allow BitLocker recovery information to store in AD DS.</summary>
        public bool? EnableRecoveryInformationSaveToStore
        {
            get { return BackingStore?.Get<bool?>("enableRecoveryInformationSaveToStore"); }
            set { BackingStore?.Set("enableRecoveryInformationSaveToStore", value); }
        }
        /// <summary>Indicates whether or not to allow showing recovery options in BitLocker Setup Wizard for fixed or system disk.</summary>
        public bool? HideRecoveryOptions
        {
            get { return BackingStore?.Get<bool?>("hideRecoveryOptions"); }
            set { BackingStore?.Set("hideRecoveryOptions", value); }
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
        /// <summary>BitLockerRecoveryInformationType types</summary>
        public global::Microsoft.Graph.Beta.Models.BitLockerRecoveryInformationType? RecoveryInformationToStore
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.BitLockerRecoveryInformationType?>("recoveryInformationToStore"); }
            set { BackingStore?.Set("recoveryInformationToStore", value); }
        }
        /// <summary>Possible values of the ConfigurationUsage list.</summary>
        public global::Microsoft.Graph.Beta.Models.ConfigurationUsage? RecoveryKeyUsage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ConfigurationUsage?>("recoveryKeyUsage"); }
            set { BackingStore?.Set("recoveryKeyUsage", value); }
        }
        /// <summary>Possible values of the ConfigurationUsage list.</summary>
        public global::Microsoft.Graph.Beta.Models.ConfigurationUsage? RecoveryPasswordUsage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ConfigurationUsage?>("recoveryPasswordUsage"); }
            set { BackingStore?.Set("recoveryPasswordUsage", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.BitLockerRecoveryOptions"/> and sets the default values.
        /// </summary>
        public BitLockerRecoveryOptions()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.BitLockerRecoveryOptions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.BitLockerRecoveryOptions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.BitLockerRecoveryOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "blockDataRecoveryAgent", n => { BlockDataRecoveryAgent = n.GetBoolValue(); } },
                { "enableBitLockerAfterRecoveryInformationToStore", n => { EnableBitLockerAfterRecoveryInformationToStore = n.GetBoolValue(); } },
                { "enableRecoveryInformationSaveToStore", n => { EnableRecoveryInformationSaveToStore = n.GetBoolValue(); } },
                { "hideRecoveryOptions", n => { HideRecoveryOptions = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "recoveryInformationToStore", n => { RecoveryInformationToStore = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.BitLockerRecoveryInformationType>(); } },
                { "recoveryKeyUsage", n => { RecoveryKeyUsage = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ConfigurationUsage>(); } },
                { "recoveryPasswordUsage", n => { RecoveryPasswordUsage = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ConfigurationUsage>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("blockDataRecoveryAgent", BlockDataRecoveryAgent);
            writer.WriteBoolValue("enableBitLockerAfterRecoveryInformationToStore", EnableBitLockerAfterRecoveryInformationToStore);
            writer.WriteBoolValue("enableRecoveryInformationSaveToStore", EnableRecoveryInformationSaveToStore);
            writer.WriteBoolValue("hideRecoveryOptions", HideRecoveryOptions);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.BitLockerRecoveryInformationType>("recoveryInformationToStore", RecoveryInformationToStore);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ConfigurationUsage>("recoveryKeyUsage", RecoveryKeyUsage);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ConfigurationUsage>("recoveryPasswordUsage", RecoveryPasswordUsage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
