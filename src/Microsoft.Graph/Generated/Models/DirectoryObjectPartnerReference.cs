using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DirectoryObjectPartnerReference : DirectoryObject, IParsable {
        /// <summary>Description of the object returned. Read-only.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Name of directory object being returned, like group or application. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The tenant identifier for the partner tenant. Read-only.</summary>
        public string ExternalPartnerTenantId {
            get { return BackingStore?.Get<string>(nameof(ExternalPartnerTenantId)); }
            set { BackingStore?.Set(nameof(ExternalPartnerTenantId), value); }
        }
        /// <summary>The type of the referenced object in the partner tenant. Read-only.</summary>
        public string ObjectType {
            get { return BackingStore?.Get<string>(nameof(ObjectType)); }
            set { BackingStore?.Set(nameof(ObjectType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DirectoryObjectPartnerReference CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryObjectPartnerReference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalPartnerTenantId", n => { ExternalPartnerTenantId = n.GetStringValue(); } },
                {"objectType", n => { ObjectType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalPartnerTenantId", ExternalPartnerTenantId);
            writer.WriteStringValue("objectType", ObjectType);
        }
    }
}
