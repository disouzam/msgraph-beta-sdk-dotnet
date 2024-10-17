// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkin
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CheckinPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The checkInAs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CheckInAs
        {
            get { return BackingStore?.Get<string?>("checkInAs"); }
            set { BackingStore?.Set("checkInAs", value); }
        }
#nullable restore
#else
        public string CheckInAs
        {
            get { return BackingStore?.Get<string>("checkInAs"); }
            set { BackingStore?.Set("checkInAs", value); }
        }
#endif
        /// <summary>The comment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment
        {
            get { return BackingStore?.Get<string?>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#nullable restore
#else
        public string Comment
        {
            get { return BackingStore?.Get<string>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkin.CheckinPostRequestBody"/> and sets the default values.
        /// </summary>
        public CheckinPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkin.CheckinPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkin.CheckinPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkin.CheckinPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "checkInAs", n => { CheckInAs = n.GetStringValue(); } },
                { "comment", n => { Comment = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("checkInAs", CheckInAs);
            writer.WriteStringValue("comment", Comment);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
