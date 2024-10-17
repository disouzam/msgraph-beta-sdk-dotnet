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
    /// Represents an icon for an app on the Home Screen
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IosHomeScreenApp : global::Microsoft.Graph.Beta.Models.IosHomeScreenItem, IParsable
    {
        /// <summary>BundleID of the app if isWebClip is false or the URL of a web clip if isWebClip is true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleID
        {
            get { return BackingStore?.Get<string?>("bundleID"); }
            set { BackingStore?.Set("bundleID", value); }
        }
#nullable restore
#else
        public string BundleID
        {
            get { return BackingStore?.Get<string>("bundleID"); }
            set { BackingStore?.Set("bundleID", value); }
        }
#endif
        /// <summary>When true, the bundle ID will be handled as a URL for a web clip.</summary>
        public bool? IsWebClip
        {
            get { return BackingStore?.Get<bool?>("isWebClip"); }
            set { BackingStore?.Set("isWebClip", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IosHomeScreenApp"/> and sets the default values.
        /// </summary>
        public IosHomeScreenApp() : base()
        {
            OdataType = "#microsoft.graph.iosHomeScreenApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IosHomeScreenApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IosHomeScreenApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IosHomeScreenApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "bundleID", n => { BundleID = n.GetStringValue(); } },
                { "isWebClip", n => { IsWebClip = n.GetBoolValue(); } },
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
            writer.WriteStringValue("bundleID", BundleID);
            writer.WriteBoolValue("isWebClip", IsWebClip);
        }
    }
}
#pragma warning restore CS0618
