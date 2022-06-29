using Microsoft.Graph.Beta.Models.Search;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SearchEntity : Entity, IParsable {
        /// <summary>Administrative answer in Microsoft Search results to define common acronyms in a organization.</summary>
        public List<Acronym> Acronyms {
            get { return BackingStore?.Get<List<Acronym>>(nameof(Acronyms)); }
            set { BackingStore?.Set(nameof(Acronyms), value); }
        }
        /// <summary>Administrative answer in Microsoft Search results for common search queries in an organization.</summary>
        public List<Bookmark> Bookmarks {
            get { return BackingStore?.Get<List<Bookmark>>(nameof(Bookmarks)); }
            set { BackingStore?.Set(nameof(Bookmarks), value); }
        }
        /// <summary>Administrative answer in Microsoft Search results which provide answers for specific search keywords in an organization.</summary>
        public List<Qna> Qnas {
            get { return BackingStore?.Get<List<Qna>>(nameof(Qnas)); }
            set { BackingStore?.Set(nameof(Qnas), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SearchEntity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchEntity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acronyms", n => { Acronyms = n.GetCollectionOfObjectValues<Acronym>(Acronym.CreateFromDiscriminatorValue).ToList(); } },
                {"bookmarks", n => { Bookmarks = n.GetCollectionOfObjectValues<Bookmark>(Bookmark.CreateFromDiscriminatorValue).ToList(); } },
                {"qnas", n => { Qnas = n.GetCollectionOfObjectValues<Qna>(Qna.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Acronym>("acronyms", Acronyms);
            writer.WriteCollectionOfObjectValues<Bookmark>("bookmarks", Bookmarks);
            writer.WriteCollectionOfObjectValues<Qna>("qnas", Qnas);
        }
    }
}
