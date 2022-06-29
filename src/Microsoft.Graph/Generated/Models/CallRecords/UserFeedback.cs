using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    public class UserFeedback : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The rating provided by the user of this endpoint about the quality of this Session. Possible values are: notRated, bad, poor, fair, good, excellent, unknownFutureValue.</summary>
        public UserFeedbackRating? Rating {
            get { return BackingStore?.Get<UserFeedbackRating?>(nameof(Rating)); }
            set { BackingStore?.Set(nameof(Rating), value); }
        }
        /// <summary>The feedback text provided by the user of this endpoint for the session.</summary>
        public string Text {
            get { return BackingStore?.Get<string>(nameof(Text)); }
            set { BackingStore?.Set(nameof(Text), value); }
        }
        /// <summary>The set of feedback tokens provided by the user of this endpoint for the session. This is a set of Boolean properties. The property names should not be relied upon since they may change depending on what tokens are offered to the user.</summary>
        public FeedbackTokenSet Tokens {
            get { return BackingStore?.Get<FeedbackTokenSet>(nameof(Tokens)); }
            set { BackingStore?.Set(nameof(Tokens), value); }
        }
        /// <summary>
        /// Instantiates a new userFeedback and sets the default values.
        /// </summary>
        public UserFeedback() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserFeedback CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserFeedback();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"rating", n => { Rating = n.GetEnumValue<UserFeedbackRating>(); } },
                {"text", n => { Text = n.GetStringValue(); } },
                {"tokens", n => { Tokens = n.GetObjectValue<FeedbackTokenSet>(FeedbackTokenSet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<UserFeedbackRating>("rating", Rating);
            writer.WriteStringValue("text", Text);
            writer.WriteObjectValue<FeedbackTokenSet>("tokens", Tokens);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
