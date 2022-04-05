using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceAppManagement.ManagedAppPolicies.Item.TargetedManagedAppProtection.TargetApps {
    /// <summary>Provides operations to call the targetApps method.</summary>
    public class TargetAppsRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The appGroupType property</summary>
        public TargetedManagedAppGroupType? AppGroupType { get; set; }
        /// <summary>The apps property</summary>
        public List<ManagedMobileApp> Apps { get; set; }
        /// <summary>
        /// Instantiates a new targetAppsRequestBody and sets the default values.
        /// </summary>
        public TargetAppsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TargetAppsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TargetAppsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appGroupType", (o,n) => { (o as TargetAppsRequestBody).AppGroupType = n.GetEnumValue<TargetedManagedAppGroupType>(); } },
                {"apps", (o,n) => { (o as TargetAppsRequestBody).Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<TargetedManagedAppGroupType>("appGroupType", AppGroupType);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
