using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class NotifyUserAction : DlpActionInfo, IParsable {
        /// <summary>The actionLastModifiedDateTime property</summary>
        public DateTimeOffset? ActionLastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ActionLastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(ActionLastModifiedDateTime), value); }
        }
        /// <summary>The emailText property</summary>
        public string EmailText {
            get { return BackingStore?.Get<string>(nameof(EmailText)); }
            set { BackingStore?.Set(nameof(EmailText), value); }
        }
        /// <summary>The overrideOption property</summary>
        public Microsoft.Graph.Beta.Models.OverrideOption? OverrideOption {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OverrideOption?>(nameof(OverrideOption)); }
            set { BackingStore?.Set(nameof(OverrideOption), value); }
        }
        /// <summary>The policyTip property</summary>
        public string PolicyTip {
            get { return BackingStore?.Get<string>(nameof(PolicyTip)); }
            set { BackingStore?.Set(nameof(PolicyTip), value); }
        }
        /// <summary>The recipients property</summary>
        public List<string> Recipients {
            get { return BackingStore?.Get<List<string>>(nameof(Recipients)); }
            set { BackingStore?.Set(nameof(Recipients), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new NotifyUserAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NotifyUserAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionLastModifiedDateTime", n => { ActionLastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"emailText", n => { EmailText = n.GetStringValue(); } },
                {"overrideOption", n => { OverrideOption = n.GetEnumValue<OverrideOption>(); } },
                {"policyTip", n => { PolicyTip = n.GetStringValue(); } },
                {"recipients", n => { Recipients = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("actionLastModifiedDateTime", ActionLastModifiedDateTime);
            writer.WriteStringValue("emailText", EmailText);
            writer.WriteEnumValue<OverrideOption>("overrideOption", OverrideOption);
            writer.WriteStringValue("policyTip", PolicyTip);
            writer.WriteCollectionOfPrimitiveValues<string>("recipients", Recipients);
        }
    }
}
