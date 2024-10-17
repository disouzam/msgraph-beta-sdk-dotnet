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
    public partial class DeviceInfo : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The deviceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId
        {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId
        {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The enrollmentProfileName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnrollmentProfileName
        {
            get { return BackingStore?.Get<string?>("enrollmentProfileName"); }
            set { BackingStore?.Set("enrollmentProfileName", value); }
        }
#nullable restore
#else
        public string EnrollmentProfileName
        {
            get { return BackingStore?.Get<string>("enrollmentProfileName"); }
            set { BackingStore?.Set("enrollmentProfileName", value); }
        }
#endif
        /// <summary>The extensionAttribute1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute1
        {
            get { return BackingStore?.Get<string?>("extensionAttribute1"); }
            set { BackingStore?.Set("extensionAttribute1", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute1
        {
            get { return BackingStore?.Get<string>("extensionAttribute1"); }
            set { BackingStore?.Set("extensionAttribute1", value); }
        }
#endif
        /// <summary>The extensionAttribute10 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute10
        {
            get { return BackingStore?.Get<string?>("extensionAttribute10"); }
            set { BackingStore?.Set("extensionAttribute10", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute10
        {
            get { return BackingStore?.Get<string>("extensionAttribute10"); }
            set { BackingStore?.Set("extensionAttribute10", value); }
        }
#endif
        /// <summary>The extensionAttribute11 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute11
        {
            get { return BackingStore?.Get<string?>("extensionAttribute11"); }
            set { BackingStore?.Set("extensionAttribute11", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute11
        {
            get { return BackingStore?.Get<string>("extensionAttribute11"); }
            set { BackingStore?.Set("extensionAttribute11", value); }
        }
#endif
        /// <summary>The extensionAttribute12 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute12
        {
            get { return BackingStore?.Get<string?>("extensionAttribute12"); }
            set { BackingStore?.Set("extensionAttribute12", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute12
        {
            get { return BackingStore?.Get<string>("extensionAttribute12"); }
            set { BackingStore?.Set("extensionAttribute12", value); }
        }
#endif
        /// <summary>The extensionAttribute13 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute13
        {
            get { return BackingStore?.Get<string?>("extensionAttribute13"); }
            set { BackingStore?.Set("extensionAttribute13", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute13
        {
            get { return BackingStore?.Get<string>("extensionAttribute13"); }
            set { BackingStore?.Set("extensionAttribute13", value); }
        }
#endif
        /// <summary>The extensionAttribute14 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute14
        {
            get { return BackingStore?.Get<string?>("extensionAttribute14"); }
            set { BackingStore?.Set("extensionAttribute14", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute14
        {
            get { return BackingStore?.Get<string>("extensionAttribute14"); }
            set { BackingStore?.Set("extensionAttribute14", value); }
        }
#endif
        /// <summary>The extensionAttribute15 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute15
        {
            get { return BackingStore?.Get<string?>("extensionAttribute15"); }
            set { BackingStore?.Set("extensionAttribute15", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute15
        {
            get { return BackingStore?.Get<string>("extensionAttribute15"); }
            set { BackingStore?.Set("extensionAttribute15", value); }
        }
#endif
        /// <summary>The extensionAttribute2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute2
        {
            get { return BackingStore?.Get<string?>("extensionAttribute2"); }
            set { BackingStore?.Set("extensionAttribute2", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute2
        {
            get { return BackingStore?.Get<string>("extensionAttribute2"); }
            set { BackingStore?.Set("extensionAttribute2", value); }
        }
#endif
        /// <summary>The extensionAttribute3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute3
        {
            get { return BackingStore?.Get<string?>("extensionAttribute3"); }
            set { BackingStore?.Set("extensionAttribute3", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute3
        {
            get { return BackingStore?.Get<string>("extensionAttribute3"); }
            set { BackingStore?.Set("extensionAttribute3", value); }
        }
#endif
        /// <summary>The extensionAttribute4 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute4
        {
            get { return BackingStore?.Get<string?>("extensionAttribute4"); }
            set { BackingStore?.Set("extensionAttribute4", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute4
        {
            get { return BackingStore?.Get<string>("extensionAttribute4"); }
            set { BackingStore?.Set("extensionAttribute4", value); }
        }
#endif
        /// <summary>The extensionAttribute5 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute5
        {
            get { return BackingStore?.Get<string?>("extensionAttribute5"); }
            set { BackingStore?.Set("extensionAttribute5", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute5
        {
            get { return BackingStore?.Get<string>("extensionAttribute5"); }
            set { BackingStore?.Set("extensionAttribute5", value); }
        }
#endif
        /// <summary>The extensionAttribute6 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute6
        {
            get { return BackingStore?.Get<string?>("extensionAttribute6"); }
            set { BackingStore?.Set("extensionAttribute6", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute6
        {
            get { return BackingStore?.Get<string>("extensionAttribute6"); }
            set { BackingStore?.Set("extensionAttribute6", value); }
        }
#endif
        /// <summary>The extensionAttribute7 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute7
        {
            get { return BackingStore?.Get<string?>("extensionAttribute7"); }
            set { BackingStore?.Set("extensionAttribute7", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute7
        {
            get { return BackingStore?.Get<string>("extensionAttribute7"); }
            set { BackingStore?.Set("extensionAttribute7", value); }
        }
#endif
        /// <summary>The extensionAttribute8 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute8
        {
            get { return BackingStore?.Get<string?>("extensionAttribute8"); }
            set { BackingStore?.Set("extensionAttribute8", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute8
        {
            get { return BackingStore?.Get<string>("extensionAttribute8"); }
            set { BackingStore?.Set("extensionAttribute8", value); }
        }
#endif
        /// <summary>The extensionAttribute9 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute9
        {
            get { return BackingStore?.Get<string?>("extensionAttribute9"); }
            set { BackingStore?.Set("extensionAttribute9", value); }
        }
#nullable restore
#else
        public string ExtensionAttribute9
        {
            get { return BackingStore?.Get<string>("extensionAttribute9"); }
            set { BackingStore?.Set("extensionAttribute9", value); }
        }
#endif
        /// <summary>The isCompliant property</summary>
        public bool? IsCompliant
        {
            get { return BackingStore?.Get<bool?>("isCompliant"); }
            set { BackingStore?.Set("isCompliant", value); }
        }
        /// <summary>The manufacturer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer
        {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer
        {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>The mdmAppId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MdmAppId
        {
            get { return BackingStore?.Get<string?>("mdmAppId"); }
            set { BackingStore?.Set("mdmAppId", value); }
        }
#nullable restore
#else
        public string MdmAppId
        {
            get { return BackingStore?.Get<string>("mdmAppId"); }
            set { BackingStore?.Set("mdmAppId", value); }
        }
#endif
        /// <summary>The model property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model
        {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model
        {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
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
        /// <summary>The operatingSystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem
        {
            get { return BackingStore?.Get<string?>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#nullable restore
#else
        public string OperatingSystem
        {
            get { return BackingStore?.Get<string>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#endif
        /// <summary>The operatingSystemVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystemVersion
        {
            get { return BackingStore?.Get<string?>("operatingSystemVersion"); }
            set { BackingStore?.Set("operatingSystemVersion", value); }
        }
#nullable restore
#else
        public string OperatingSystemVersion
        {
            get { return BackingStore?.Get<string>("operatingSystemVersion"); }
            set { BackingStore?.Set("operatingSystemVersion", value); }
        }
#endif
        /// <summary>The ownership property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ownership
        {
            get { return BackingStore?.Get<string?>("ownership"); }
            set { BackingStore?.Set("ownership", value); }
        }
#nullable restore
#else
        public string Ownership
        {
            get { return BackingStore?.Get<string>("ownership"); }
            set { BackingStore?.Set("ownership", value); }
        }
#endif
        /// <summary>The physicalIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PhysicalIds
        {
            get { return BackingStore?.Get<List<string>?>("physicalIds"); }
            set { BackingStore?.Set("physicalIds", value); }
        }
#nullable restore
#else
        public List<string> PhysicalIds
        {
            get { return BackingStore?.Get<List<string>>("physicalIds"); }
            set { BackingStore?.Set("physicalIds", value); }
        }
#endif
        /// <summary>The profileType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileType
        {
            get { return BackingStore?.Get<string?>("profileType"); }
            set { BackingStore?.Set("profileType", value); }
        }
#nullable restore
#else
        public string ProfileType
        {
            get { return BackingStore?.Get<string>("profileType"); }
            set { BackingStore?.Set("profileType", value); }
        }
#endif
        /// <summary>The systemLabels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SystemLabels
        {
            get { return BackingStore?.Get<List<string>?>("systemLabels"); }
            set { BackingStore?.Set("systemLabels", value); }
        }
#nullable restore
#else
        public List<string> SystemLabels
        {
            get { return BackingStore?.Get<List<string>>("systemLabels"); }
            set { BackingStore?.Set("systemLabels", value); }
        }
#endif
        /// <summary>The trustType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrustType
        {
            get { return BackingStore?.Get<string?>("trustType"); }
            set { BackingStore?.Set("trustType", value); }
        }
#nullable restore
#else
        public string TrustType
        {
            get { return BackingStore?.Get<string>("trustType"); }
            set { BackingStore?.Set("trustType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeviceInfo"/> and sets the default values.
        /// </summary>
        public DeviceInfo()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.DeviceInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "enrollmentProfileName", n => { EnrollmentProfileName = n.GetStringValue(); } },
                { "extensionAttribute1", n => { ExtensionAttribute1 = n.GetStringValue(); } },
                { "extensionAttribute10", n => { ExtensionAttribute10 = n.GetStringValue(); } },
                { "extensionAttribute11", n => { ExtensionAttribute11 = n.GetStringValue(); } },
                { "extensionAttribute12", n => { ExtensionAttribute12 = n.GetStringValue(); } },
                { "extensionAttribute13", n => { ExtensionAttribute13 = n.GetStringValue(); } },
                { "extensionAttribute14", n => { ExtensionAttribute14 = n.GetStringValue(); } },
                { "extensionAttribute15", n => { ExtensionAttribute15 = n.GetStringValue(); } },
                { "extensionAttribute2", n => { ExtensionAttribute2 = n.GetStringValue(); } },
                { "extensionAttribute3", n => { ExtensionAttribute3 = n.GetStringValue(); } },
                { "extensionAttribute4", n => { ExtensionAttribute4 = n.GetStringValue(); } },
                { "extensionAttribute5", n => { ExtensionAttribute5 = n.GetStringValue(); } },
                { "extensionAttribute6", n => { ExtensionAttribute6 = n.GetStringValue(); } },
                { "extensionAttribute7", n => { ExtensionAttribute7 = n.GetStringValue(); } },
                { "extensionAttribute8", n => { ExtensionAttribute8 = n.GetStringValue(); } },
                { "extensionAttribute9", n => { ExtensionAttribute9 = n.GetStringValue(); } },
                { "isCompliant", n => { IsCompliant = n.GetBoolValue(); } },
                { "manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                { "mdmAppId", n => { MdmAppId = n.GetStringValue(); } },
                { "model", n => { Model = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                { "operatingSystemVersion", n => { OperatingSystemVersion = n.GetStringValue(); } },
                { "ownership", n => { Ownership = n.GetStringValue(); } },
                { "physicalIds", n => { PhysicalIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "profileType", n => { ProfileType = n.GetStringValue(); } },
                { "systemLabels", n => { SystemLabels = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "trustType", n => { TrustType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("enrollmentProfileName", EnrollmentProfileName);
            writer.WriteStringValue("extensionAttribute1", ExtensionAttribute1);
            writer.WriteStringValue("extensionAttribute10", ExtensionAttribute10);
            writer.WriteStringValue("extensionAttribute11", ExtensionAttribute11);
            writer.WriteStringValue("extensionAttribute12", ExtensionAttribute12);
            writer.WriteStringValue("extensionAttribute13", ExtensionAttribute13);
            writer.WriteStringValue("extensionAttribute14", ExtensionAttribute14);
            writer.WriteStringValue("extensionAttribute15", ExtensionAttribute15);
            writer.WriteStringValue("extensionAttribute2", ExtensionAttribute2);
            writer.WriteStringValue("extensionAttribute3", ExtensionAttribute3);
            writer.WriteStringValue("extensionAttribute4", ExtensionAttribute4);
            writer.WriteStringValue("extensionAttribute5", ExtensionAttribute5);
            writer.WriteStringValue("extensionAttribute6", ExtensionAttribute6);
            writer.WriteStringValue("extensionAttribute7", ExtensionAttribute7);
            writer.WriteStringValue("extensionAttribute8", ExtensionAttribute8);
            writer.WriteStringValue("extensionAttribute9", ExtensionAttribute9);
            writer.WriteBoolValue("isCompliant", IsCompliant);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("mdmAppId", MdmAppId);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("operatingSystemVersion", OperatingSystemVersion);
            writer.WriteStringValue("ownership", Ownership);
            writer.WriteCollectionOfPrimitiveValues<string>("physicalIds", PhysicalIds);
            writer.WriteStringValue("profileType", ProfileType);
            writer.WriteCollectionOfPrimitiveValues<string>("systemLabels", SystemLabels);
            writer.WriteStringValue("trustType", TrustType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
