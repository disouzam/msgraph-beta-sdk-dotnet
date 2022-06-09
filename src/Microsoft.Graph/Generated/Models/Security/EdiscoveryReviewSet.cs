using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EdiscoveryReviewSet : DataSet, IParsable {
        /// <summary>Represents files within the review set.</summary>
        public List<EdiscoveryFile> Files {
            get { return BackingStore?.Get<List<EdiscoveryFile>>(nameof(Files)); }
            set { BackingStore?.Set(nameof(Files), value); }
        }
        /// <summary>Represents queries within the review set.</summary>
        public List<EdiscoveryReviewSetQuery> Queries {
            get { return BackingStore?.Get<List<EdiscoveryReviewSetQuery>>(nameof(Queries)); }
            set { BackingStore?.Set(nameof(Queries), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EdiscoveryReviewSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryReviewSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"files", n => { Files = n.GetCollectionOfObjectValues<EdiscoveryFile>(EdiscoveryFile.CreateFromDiscriminatorValue).ToList(); } },
                {"queries", n => { Queries = n.GetCollectionOfObjectValues<EdiscoveryReviewSetQuery>(EdiscoveryReviewSetQuery.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EdiscoveryFile>("files", Files);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewSetQuery>("queries", Queries);
        }
    }
}
