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
    public partial class PersonOrGroupColumn : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Indicates whether multiple values can be selected from the source.</summary>
        public bool? AllowMultipleSelection
        {
            get { return BackingStore?.Get<bool?>("allowMultipleSelection"); }
            set { BackingStore?.Set("allowMultipleSelection", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Whether to allow selection of people only, or people and groups. Must be one of peopleAndGroups or peopleOnly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChooseFromType
        {
            get { return BackingStore?.Get<string?>("chooseFromType"); }
            set { BackingStore?.Set("chooseFromType", value); }
        }
#nullable restore
#else
        public string ChooseFromType
        {
            get { return BackingStore?.Get<string>("chooseFromType"); }
            set { BackingStore?.Set("chooseFromType", value); }
        }
#endif
        /// <summary>How to display the information about the person or group chosen. See below.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayAs
        {
            get { return BackingStore?.Get<string?>("displayAs"); }
            set { BackingStore?.Set("displayAs", value); }
        }
#nullable restore
#else
        public string DisplayAs
        {
            get { return BackingStore?.Get<string>("displayAs"); }
            set { BackingStore?.Set("displayAs", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.PersonOrGroupColumn"/> and sets the default values.
        /// </summary>
        public PersonOrGroupColumn()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PersonOrGroupColumn"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.PersonOrGroupColumn CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.PersonOrGroupColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowMultipleSelection", n => { AllowMultipleSelection = n.GetBoolValue(); } },
                { "chooseFromType", n => { ChooseFromType = n.GetStringValue(); } },
                { "displayAs", n => { DisplayAs = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleSelection", AllowMultipleSelection);
            writer.WriteStringValue("chooseFromType", ChooseFromType);
            writer.WriteStringValue("displayAs", DisplayAs);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
