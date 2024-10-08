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
    public partial class PrinterDocumentConfiguration : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The collate property</summary>
        public bool? Collate
        {
            get { return BackingStore?.Get<bool?>("collate"); }
            set { BackingStore?.Set("collate", value); }
        }
        /// <summary>The colorMode property</summary>
        public global::Microsoft.Graph.Beta.Models.PrintColorMode? ColorMode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrintColorMode?>("colorMode"); }
            set { BackingStore?.Set("colorMode", value); }
        }
        /// <summary>The copies property</summary>
        public int? Copies
        {
            get { return BackingStore?.Get<int?>("copies"); }
            set { BackingStore?.Set("copies", value); }
        }
        /// <summary>The dpi property</summary>
        public int? Dpi
        {
            get { return BackingStore?.Get<int?>("dpi"); }
            set { BackingStore?.Set("dpi", value); }
        }
        /// <summary>The duplexMode property</summary>
        public global::Microsoft.Graph.Beta.Models.PrintDuplexMode? DuplexMode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrintDuplexMode?>("duplexMode"); }
            set { BackingStore?.Set("duplexMode", value); }
        }
        /// <summary>The feedDirection property</summary>
        public global::Microsoft.Graph.Beta.Models.PrinterFeedDirection? FeedDirection
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrinterFeedDirection?>("feedDirection"); }
            set { BackingStore?.Set("feedDirection", value); }
        }
        /// <summary>The feedOrientation property</summary>
        public global::Microsoft.Graph.Beta.Models.PrinterFeedOrientation? FeedOrientation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrinterFeedOrientation?>("feedOrientation"); }
            set { BackingStore?.Set("feedOrientation", value); }
        }
        /// <summary>The finishings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.PrintFinishing?>? Finishings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PrintFinishing?>?>("finishings"); }
            set { BackingStore?.Set("finishings", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.PrintFinishing?> Finishings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PrintFinishing?>>("finishings"); }
            set { BackingStore?.Set("finishings", value); }
        }
#endif
        /// <summary>The fitPdfToPage property</summary>
        public bool? FitPdfToPage
        {
            get { return BackingStore?.Get<bool?>("fitPdfToPage"); }
            set { BackingStore?.Set("fitPdfToPage", value); }
        }
        /// <summary>The inputBin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InputBin
        {
            get { return BackingStore?.Get<string?>("inputBin"); }
            set { BackingStore?.Set("inputBin", value); }
        }
#nullable restore
#else
        public string InputBin
        {
            get { return BackingStore?.Get<string>("inputBin"); }
            set { BackingStore?.Set("inputBin", value); }
        }
#endif
        /// <summary>The margin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PrintMargin? Margin
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrintMargin?>("margin"); }
            set { BackingStore?.Set("margin", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PrintMargin Margin
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrintMargin>("margin"); }
            set { BackingStore?.Set("margin", value); }
        }
#endif
        /// <summary>The mediaSize property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaSize
        {
            get { return BackingStore?.Get<string?>("mediaSize"); }
            set { BackingStore?.Set("mediaSize", value); }
        }
#nullable restore
#else
        public string MediaSize
        {
            get { return BackingStore?.Get<string>("mediaSize"); }
            set { BackingStore?.Set("mediaSize", value); }
        }
#endif
        /// <summary>The mediaType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaType
        {
            get { return BackingStore?.Get<string?>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
#nullable restore
#else
        public string MediaType
        {
            get { return BackingStore?.Get<string>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
#endif
        /// <summary>The multipageLayout property</summary>
        public global::Microsoft.Graph.Beta.Models.PrintMultipageLayout? MultipageLayout
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrintMultipageLayout?>("multipageLayout"); }
            set { BackingStore?.Set("multipageLayout", value); }
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
        /// <summary>The orientation property</summary>
        public global::Microsoft.Graph.Beta.Models.PrintOrientation? Orientation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrintOrientation?>("orientation"); }
            set { BackingStore?.Set("orientation", value); }
        }
        /// <summary>The outputBin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputBin
        {
            get { return BackingStore?.Get<string?>("outputBin"); }
            set { BackingStore?.Set("outputBin", value); }
        }
#nullable restore
#else
        public string OutputBin
        {
            get { return BackingStore?.Get<string>("outputBin"); }
            set { BackingStore?.Set("outputBin", value); }
        }
#endif
        /// <summary>The pageRanges property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IntegerRange>? PageRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IntegerRange>?>("pageRanges"); }
            set { BackingStore?.Set("pageRanges", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IntegerRange> PageRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IntegerRange>>("pageRanges"); }
            set { BackingStore?.Set("pageRanges", value); }
        }
#endif
        /// <summary>The pagesPerSheet property</summary>
        public int? PagesPerSheet
        {
            get { return BackingStore?.Get<int?>("pagesPerSheet"); }
            set { BackingStore?.Set("pagesPerSheet", value); }
        }
        /// <summary>The quality property</summary>
        public global::Microsoft.Graph.Beta.Models.PrintQuality? Quality
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrintQuality?>("quality"); }
            set { BackingStore?.Set("quality", value); }
        }
        /// <summary>The scaling property</summary>
        public global::Microsoft.Graph.Beta.Models.PrintScaling? Scaling
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PrintScaling?>("scaling"); }
            set { BackingStore?.Set("scaling", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.PrinterDocumentConfiguration"/> and sets the default values.
        /// </summary>
        public PrinterDocumentConfiguration()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.PrinterDocumentConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.PrinterDocumentConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.PrinterDocumentConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "collate", n => { Collate = n.GetBoolValue(); } },
                { "colorMode", n => { ColorMode = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PrintColorMode>(); } },
                { "copies", n => { Copies = n.GetIntValue(); } },
                { "dpi", n => { Dpi = n.GetIntValue(); } },
                { "duplexMode", n => { DuplexMode = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PrintDuplexMode>(); } },
                { "feedDirection", n => { FeedDirection = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PrinterFeedDirection>(); } },
                { "feedOrientation", n => { FeedOrientation = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PrinterFeedOrientation>(); } },
                { "finishings", n => { Finishings = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.PrintFinishing>()?.AsList(); } },
                { "fitPdfToPage", n => { FitPdfToPage = n.GetBoolValue(); } },
                { "inputBin", n => { InputBin = n.GetStringValue(); } },
                { "margin", n => { Margin = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PrintMargin>(global::Microsoft.Graph.Beta.Models.PrintMargin.CreateFromDiscriminatorValue); } },
                { "mediaSize", n => { MediaSize = n.GetStringValue(); } },
                { "mediaType", n => { MediaType = n.GetStringValue(); } },
                { "multipageLayout", n => { MultipageLayout = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PrintMultipageLayout>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "orientation", n => { Orientation = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PrintOrientation>(); } },
                { "outputBin", n => { OutputBin = n.GetStringValue(); } },
                { "pageRanges", n => { PageRanges = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IntegerRange>(global::Microsoft.Graph.Beta.Models.IntegerRange.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pagesPerSheet", n => { PagesPerSheet = n.GetIntValue(); } },
                { "quality", n => { Quality = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PrintQuality>(); } },
                { "scaling", n => { Scaling = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PrintScaling>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("collate", Collate);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PrintColorMode>("colorMode", ColorMode);
            writer.WriteIntValue("copies", Copies);
            writer.WriteIntValue("dpi", Dpi);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PrintDuplexMode>("duplexMode", DuplexMode);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PrinterFeedDirection>("feedDirection", FeedDirection);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PrinterFeedOrientation>("feedOrientation", FeedOrientation);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.PrintFinishing>("finishings", Finishings);
            writer.WriteBoolValue("fitPdfToPage", FitPdfToPage);
            writer.WriteStringValue("inputBin", InputBin);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PrintMargin>("margin", Margin);
            writer.WriteStringValue("mediaSize", MediaSize);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PrintMultipageLayout>("multipageLayout", MultipageLayout);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PrintOrientation>("orientation", Orientation);
            writer.WriteStringValue("outputBin", OutputBin);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IntegerRange>("pageRanges", PageRanges);
            writer.WriteIntValue("pagesPerSheet", PagesPerSheet);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PrintQuality>("quality", Quality);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PrintScaling>("scaling", Scaling);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
