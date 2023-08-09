// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class TaskDefinition : Entity, IParsable {
        /// <summary>The category property</summary>
        public LifecycleTaskCategory? Category {
            get { return BackingStore?.Get<LifecycleTaskCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The continueOnError property</summary>
        public bool? ContinueOnError {
            get { return BackingStore?.Get<bool?>("continueOnError"); }
            set { BackingStore?.Set("continueOnError", value); }
        }
        /// <summary>The description of the taskDefinition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the taskDefinition.Supports $filter(eq, ne) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The parameters that must be supplied when creating a workflow task object.Supports $filter(any).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Parameter>? Parameters {
            get { return BackingStore?.Get<List<Parameter>?>("parameters"); }
            set { BackingStore?.Set("parameters", value); }
        }
#nullable restore
#else
        public List<Parameter> Parameters {
            get { return BackingStore?.Get<List<Parameter>>("parameters"); }
            set { BackingStore?.Set("parameters", value); }
        }
#endif
        /// <summary>The version number of the taskDefinition. New records are pushed when we add support for new parameters.Supports $filter(ge, gt, le, lt, eq, ne) and $orderby.</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TaskDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaskDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"category", n => { Category = n.GetEnumValue<LifecycleTaskCategory>(); } },
                {"continueOnError", n => { ContinueOnError = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"parameters", n => { Parameters = n.GetCollectionOfObjectValues<Parameter>(Parameter.CreateFromDiscriminatorValue)?.ToList(); } },
                {"version", n => { Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<LifecycleTaskCategory>("category", Category);
            writer.WriteBoolValue("continueOnError", ContinueOnError);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Parameter>("parameters", Parameters);
            writer.WriteIntValue("version", Version);
        }
    }
}
