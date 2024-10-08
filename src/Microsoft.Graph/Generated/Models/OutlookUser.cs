// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class OutlookUser : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A list of categories defined for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.OutlookCategory>? MasterCategories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OutlookCategory>?>("masterCategories"); }
            set { BackingStore?.Set("masterCategories", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.OutlookCategory> MasterCategories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OutlookCategory>>("masterCategories"); }
            set { BackingStore?.Set("masterCategories", value); }
        }
#endif
        /// <summary>The user&apos;s Outlook task folders. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.OutlookTaskFolder>? TaskFolders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OutlookTaskFolder>?>("taskFolders"); }
            set { BackingStore?.Set("taskFolders", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.OutlookTaskFolder> TaskFolders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OutlookTaskFolder>>("taskFolders"); }
            set { BackingStore?.Set("taskFolders", value); }
        }
#endif
        /// <summary>The user&apos;s Outlook task groups. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.OutlookTaskGroup>? TaskGroups
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OutlookTaskGroup>?>("taskGroups"); }
            set { BackingStore?.Set("taskGroups", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.OutlookTaskGroup> TaskGroups
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OutlookTaskGroup>>("taskGroups"); }
            set { BackingStore?.Set("taskGroups", value); }
        }
#endif
        /// <summary>The user&apos;s Outlook tasks. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.OutlookTask>? Tasks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OutlookTask>?>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.OutlookTask> Tasks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.OutlookTask>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OutlookUser"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.OutlookUser CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.OutlookUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "masterCategories", n => { MasterCategories = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OutlookCategory>(global::Microsoft.Graph.Beta.Models.OutlookCategory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "taskFolders", n => { TaskFolders = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OutlookTaskFolder>(global::Microsoft.Graph.Beta.Models.OutlookTaskFolder.CreateFromDiscriminatorValue)?.AsList(); } },
                { "taskGroups", n => { TaskGroups = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OutlookTaskGroup>(global::Microsoft.Graph.Beta.Models.OutlookTaskGroup.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tasks", n => { Tasks = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OutlookTask>(global::Microsoft.Graph.Beta.Models.OutlookTask.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OutlookCategory>("masterCategories", MasterCategories);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OutlookTaskFolder>("taskFolders", TaskFolders);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OutlookTaskGroup>("taskGroups", TaskGroups);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.OutlookTask>("tasks", Tasks);
        }
    }
}
#pragma warning restore CS0618
