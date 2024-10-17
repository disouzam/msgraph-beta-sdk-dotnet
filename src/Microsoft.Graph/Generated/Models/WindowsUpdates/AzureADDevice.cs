// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AzureADDevice : global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies areas in which the device is enrolled. Read-only. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment>? Enrollments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment>?>("enrollments"); }
            set { BackingStore?.Set("enrollments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment> Enrollments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment>>("enrollments"); }
            set { BackingStore?.Set("enrollments", value); }
        }
#endif
        /// <summary>Specifies any errors that prevent the device from being enrolled in update management or receving deployed content. Read-only. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError>? Errors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError>?>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError> Errors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError>>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.AzureADDevice"/> and sets the default values.
        /// </summary>
        public AzureADDevice() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdates.azureADDevice";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.AzureADDevice"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WindowsUpdates.AzureADDevice CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsUpdates.AzureADDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "enrollments", n => { Enrollments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "errors", n => { Errors = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment>("enrollments", Enrollments);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError>("errors", Errors);
        }
    }
}
#pragma warning restore CS0618
