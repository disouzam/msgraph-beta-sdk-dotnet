// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudience
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class UpdateAudiencePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The addExclusions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>? AddExclusions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>?>("addExclusions"); }
            set { BackingStore?.Set("addExclusions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset> AddExclusions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>>("addExclusions"); }
            set { BackingStore?.Set("addExclusions", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The addMembers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>? AddMembers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>?>("addMembers"); }
            set { BackingStore?.Set("addMembers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset> AddMembers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>>("addMembers"); }
            set { BackingStore?.Set("addMembers", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The removeExclusions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>? RemoveExclusions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>?>("removeExclusions"); }
            set { BackingStore?.Set("removeExclusions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset> RemoveExclusions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>>("removeExclusions"); }
            set { BackingStore?.Set("removeExclusions", value); }
        }
#endif
        /// <summary>The removeMembers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>? RemoveMembers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>?>("removeMembers"); }
            set { BackingStore?.Set("removeMembers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset> RemoveMembers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>>("removeMembers"); }
            set { BackingStore?.Set("removeMembers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudience.UpdateAudiencePostRequestBody"/> and sets the default values.
        /// </summary>
        public UpdateAudiencePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudience.UpdateAudiencePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudience.UpdateAudiencePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Admin.Windows.Updates.Deployments.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudience.UpdateAudiencePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "addExclusions", n => { AddExclusions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset.CreateFromDiscriminatorValue)?.AsList(); } },
                { "addMembers", n => { AddMembers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset.CreateFromDiscriminatorValue)?.AsList(); } },
                { "removeExclusions", n => { RemoveExclusions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset.CreateFromDiscriminatorValue)?.AsList(); } },
                { "removeMembers", n => { RemoveMembers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>("addExclusions", AddExclusions);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>("addMembers", AddMembers);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>("removeExclusions", RemoveExclusions);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>("removeMembers", RemoveMembers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
