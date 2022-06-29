using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class Tasks : Entity, IParsable {
        /// <summary>All tasks in the users mailbox.</summary>
        public List<BaseTask> Alltasks {
            get { return BackingStore?.Get<List<BaseTask>>(nameof(Alltasks)); }
            set { BackingStore?.Set(nameof(Alltasks), value); }
        }
        /// <summary>The task lists in the users mailbox.</summary>
        public List<BaseTaskList> Lists {
            get { return BackingStore?.Get<List<BaseTaskList>>(nameof(Lists)); }
            set { BackingStore?.Set(nameof(Lists), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Tasks CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Tasks();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alltasks", n => { Alltasks = n.GetCollectionOfObjectValues<BaseTask>(BaseTask.CreateFromDiscriminatorValue).ToList(); } },
                {"lists", n => { Lists = n.GetCollectionOfObjectValues<BaseTaskList>(BaseTaskList.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<BaseTask>("alltasks", Alltasks);
            writer.WriteCollectionOfObjectValues<BaseTaskList>("lists", Lists);
        }
    }
}
