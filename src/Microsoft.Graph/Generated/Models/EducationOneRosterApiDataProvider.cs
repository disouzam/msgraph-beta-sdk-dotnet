using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationOneRosterApiDataProvider : EducationSynchronizationDataProvider, IParsable {
        /// <summary>The connectionSettings property</summary>
        public EducationSynchronizationConnectionSettings ConnectionSettings {
            get { return BackingStore?.Get<EducationSynchronizationConnectionSettings>(nameof(ConnectionSettings)); }
            set { BackingStore?.Set(nameof(ConnectionSettings), value); }
        }
        /// <summary>The connectionUrl property</summary>
        public string ConnectionUrl {
            get { return BackingStore?.Get<string>(nameof(ConnectionUrl)); }
            set { BackingStore?.Set(nameof(ConnectionUrl), value); }
        }
        /// <summary>The customizations property</summary>
        public EducationSynchronizationCustomizations Customizations {
            get { return BackingStore?.Get<EducationSynchronizationCustomizations>(nameof(Customizations)); }
            set { BackingStore?.Set(nameof(Customizations), value); }
        }
        /// <summary>The providerName property</summary>
        public string ProviderName {
            get { return BackingStore?.Get<string>(nameof(ProviderName)); }
            set { BackingStore?.Set(nameof(ProviderName), value); }
        }
        /// <summary>The schoolsIds property</summary>
        public List<string> SchoolsIds {
            get { return BackingStore?.Get<List<string>>(nameof(SchoolsIds)); }
            set { BackingStore?.Set(nameof(SchoolsIds), value); }
        }
        /// <summary>The termIds property</summary>
        public List<string> TermIds {
            get { return BackingStore?.Get<List<string>>(nameof(TermIds)); }
            set { BackingStore?.Set(nameof(TermIds), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationOneRosterApiDataProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationOneRosterApiDataProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectionSettings", n => { ConnectionSettings = n.GetObjectValue<EducationSynchronizationConnectionSettings>(EducationSynchronizationConnectionSettings.CreateFromDiscriminatorValue); } },
                {"connectionUrl", n => { ConnectionUrl = n.GetStringValue(); } },
                {"customizations", n => { Customizations = n.GetObjectValue<EducationSynchronizationCustomizations>(EducationSynchronizationCustomizations.CreateFromDiscriminatorValue); } },
                {"providerName", n => { ProviderName = n.GetStringValue(); } },
                {"schoolsIds", n => { SchoolsIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"termIds", n => { TermIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationSynchronizationConnectionSettings>("connectionSettings", ConnectionSettings);
            writer.WriteStringValue("connectionUrl", ConnectionUrl);
            writer.WriteObjectValue<EducationSynchronizationCustomizations>("customizations", Customizations);
            writer.WriteStringValue("providerName", ProviderName);
            writer.WriteCollectionOfPrimitiveValues<string>("schoolsIds", SchoolsIds);
            writer.WriteCollectionOfPrimitiveValues<string>("termIds", TermIds);
        }
    }
}
