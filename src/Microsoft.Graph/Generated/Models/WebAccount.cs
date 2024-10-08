// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class WebAccount : global::Microsoft.Graph.Beta.Models.ItemFacet, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Contains the description the user has provided for the account on the service being referenced.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The service property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ServiceInformation? Service
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ServiceInformation?>("service"); }
            set { BackingStore?.Set("service", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ServiceInformation Service
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ServiceInformation>("service"); }
            set { BackingStore?.Set("service", value); }
        }
#endif
        /// <summary>Contains a status message from the cloud service if provided or synchronized.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusMessage
        {
            get { return BackingStore?.Get<string?>("statusMessage"); }
            set { BackingStore?.Set("statusMessage", value); }
        }
#nullable restore
#else
        public string StatusMessage
        {
            get { return BackingStore?.Get<string>("statusMessage"); }
            set { BackingStore?.Set("statusMessage", value); }
        }
#endif
        /// <summary>The thumbnailUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbnailUrl
        {
            get { return BackingStore?.Get<string?>("thumbnailUrl"); }
            set { BackingStore?.Set("thumbnailUrl", value); }
        }
#nullable restore
#else
        public string ThumbnailUrl
        {
            get { return BackingStore?.Get<string>("thumbnailUrl"); }
            set { BackingStore?.Set("thumbnailUrl", value); }
        }
#endif
        /// <summary>The user name  displayed for the webaccount.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId
        {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId
        {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>Contains a link to the user&apos;s profile on the cloud service if one exists.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WebAccount"/> and sets the default values.
        /// </summary>
        public WebAccount() : base()
        {
            OdataType = "#microsoft.graph.webAccount";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WebAccount"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WebAccount CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WebAccount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "service", n => { Service = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ServiceInformation>(global::Microsoft.Graph.Beta.Models.ServiceInformation.CreateFromDiscriminatorValue); } },
                { "statusMessage", n => { StatusMessage = n.GetStringValue(); } },
                { "thumbnailUrl", n => { ThumbnailUrl = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ServiceInformation>("service", Service);
            writer.WriteStringValue("statusMessage", StatusMessage);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
#pragma warning restore CS0618
