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
    public partial class MicrosoftManagedDesktop : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Indicates the provisioning policy associated with Microsoft Managed Desktop settings. Possible values are: notManaged, premiumManaged, standardManaged, starterManaged, unknownFutureValue. The default value is notManaged.</summary>
        public global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktopType? ManagedType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktopType?>("managedType"); }
            set { BackingStore?.Set("managedType", value); }
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
        /// <summary>The name of the Microsoft Managed Desktop profile that the Windows 365 Cloud PC is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Profile
        {
            get { return BackingStore?.Get<string?>("profile"); }
            set { BackingStore?.Set("profile", value); }
        }
#nullable restore
#else
        public string Profile
        {
            get { return BackingStore?.Get<string>("profile"); }
            set { BackingStore?.Set("profile", value); }
        }
#endif
        /// <summary>Indicates whether the provisioning policy enables Microsoft Managed Desktop and, if enabled, specifies the type of plan managing the device. Possible values are: notManaged, premiumManaged, standardManaged, starterManaged, unknownFutureValue. The type property is deprecated and will stop returning data on January 31, 2024. Going forward, use the managedType property.</summary>
        public global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktopType? Type
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktopType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop"/> and sets the default values.
        /// </summary>
        public MicrosoftManagedDesktop()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "managedType", n => { ManagedType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktopType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "profile", n => { Profile = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktopType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktopType>("managedType", ManagedType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("profile", Profile);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.MicrosoftManagedDesktopType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
