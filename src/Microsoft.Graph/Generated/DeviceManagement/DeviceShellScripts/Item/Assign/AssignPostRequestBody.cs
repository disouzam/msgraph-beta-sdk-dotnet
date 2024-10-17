// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.DeviceShellScripts.Item.Assign
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AssignPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deviceManagementScriptAssignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptAssignment>? DeviceManagementScriptAssignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptAssignment>?>("deviceManagementScriptAssignments"); }
            set { BackingStore?.Set("deviceManagementScriptAssignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptAssignment> DeviceManagementScriptAssignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptAssignment>>("deviceManagementScriptAssignments"); }
            set { BackingStore?.Set("deviceManagementScriptAssignments", value); }
        }
#endif
        /// <summary>The deviceManagementScriptGroupAssignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptGroupAssignment>? DeviceManagementScriptGroupAssignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptGroupAssignment>?>("deviceManagementScriptGroupAssignments"); }
            set { BackingStore?.Set("deviceManagementScriptGroupAssignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptGroupAssignment> DeviceManagementScriptGroupAssignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptGroupAssignment>>("deviceManagementScriptGroupAssignments"); }
            set { BackingStore?.Set("deviceManagementScriptGroupAssignments", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.DeviceManagement.DeviceShellScripts.Item.Assign.AssignPostRequestBody"/> and sets the default values.
        /// </summary>
        public AssignPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceManagement.DeviceShellScripts.Item.Assign.AssignPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.DeviceManagement.DeviceShellScripts.Item.Assign.AssignPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.DeviceManagement.DeviceShellScripts.Item.Assign.AssignPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deviceManagementScriptAssignments", n => { DeviceManagementScriptAssignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptAssignment>(global::Microsoft.Graph.Beta.Models.DeviceManagementScriptAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deviceManagementScriptGroupAssignments", n => { DeviceManagementScriptGroupAssignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptGroupAssignment>(global::Microsoft.Graph.Beta.Models.DeviceManagementScriptGroupAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptAssignment>("deviceManagementScriptAssignments", DeviceManagementScriptAssignments);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagementScriptGroupAssignment>("deviceManagementScriptGroupAssignments", DeviceManagementScriptGroupAssignments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
