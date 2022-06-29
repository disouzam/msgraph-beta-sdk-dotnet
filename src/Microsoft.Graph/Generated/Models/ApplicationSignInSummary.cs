using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ApplicationSignInSummary : Entity, IParsable {
        /// <summary>Name of the application that the user signed into.</summary>
        public string AppDisplayName {
            get { return BackingStore?.Get<string>(nameof(AppDisplayName)); }
            set { BackingStore?.Set(nameof(AppDisplayName), value); }
        }
        /// <summary>Count of failed sign-ins made by the application.</summary>
        public long? FailedSignInCount {
            get { return BackingStore?.Get<long?>(nameof(FailedSignInCount)); }
            set { BackingStore?.Set(nameof(FailedSignInCount), value); }
        }
        /// <summary>Count of successful sign-ins made by the application.</summary>
        public long? SuccessfulSignInCount {
            get { return BackingStore?.Get<long?>(nameof(SuccessfulSignInCount)); }
            set { BackingStore?.Set(nameof(SuccessfulSignInCount), value); }
        }
        /// <summary>Percentage of successful sign-ins made by the application.</summary>
        public double? SuccessPercentage {
            get { return BackingStore?.Get<double?>(nameof(SuccessPercentage)); }
            set { BackingStore?.Set(nameof(SuccessPercentage), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApplicationSignInSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationSignInSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"failedSignInCount", n => { FailedSignInCount = n.GetLongValue(); } },
                {"successfulSignInCount", n => { SuccessfulSignInCount = n.GetLongValue(); } },
                {"successPercentage", n => { SuccessPercentage = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteLongValue("failedSignInCount", FailedSignInCount);
            writer.WriteLongValue("successfulSignInCount", SuccessfulSignInCount);
            writer.WriteDoubleValue("successPercentage", SuccessPercentage);
        }
    }
}
