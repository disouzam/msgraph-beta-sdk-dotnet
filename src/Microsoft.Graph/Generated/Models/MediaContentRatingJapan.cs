using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MediaContentRatingJapan : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Movies rating selected for Japan. Possible values are: allAllowed, allBlocked, general, parentalGuidance, agesAbove15, agesAbove18.</summary>
        public RatingJapanMoviesType? MovieRating {
            get { return BackingStore?.Get<RatingJapanMoviesType?>(nameof(MovieRating)); }
            set { BackingStore?.Set(nameof(MovieRating), value); }
        }
        /// <summary>TV rating selected for Japan. Possible values are: allAllowed, allBlocked, explicitAllowed.</summary>
        public RatingJapanTelevisionType? TvRating {
            get { return BackingStore?.Get<RatingJapanTelevisionType?>(nameof(TvRating)); }
            set { BackingStore?.Set(nameof(TvRating), value); }
        }
        /// <summary>
        /// Instantiates a new mediaContentRatingJapan and sets the default values.
        /// </summary>
        public MediaContentRatingJapan() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MediaContentRatingJapan CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaContentRatingJapan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"movieRating", n => { MovieRating = n.GetEnumValue<RatingJapanMoviesType>(); } },
                {"tvRating", n => { TvRating = n.GetEnumValue<RatingJapanTelevisionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RatingJapanMoviesType>("movieRating", MovieRating);
            writer.WriteEnumValue<RatingJapanTelevisionType>("tvRating", TvRating);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
