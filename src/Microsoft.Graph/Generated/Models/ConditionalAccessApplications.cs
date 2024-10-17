// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ConditionalAccessApplications : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Filter that defines the dynamic-application-syntax rule to include/exclude cloud applications. A filter can use custom security attributes to include/exclude applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ConditionalAccessFilter? ApplicationFilter
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ConditionalAccessFilter?>("applicationFilter"); }
            set { BackingStore?.Set("applicationFilter", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ConditionalAccessFilter ApplicationFilter
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ConditionalAccessFilter>("applicationFilter"); }
            set { BackingStore?.Set("applicationFilter", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Can be one of the following:  The list of client IDs (appId) explicitly excluded from the policy. Office365 - For the list of apps included in Office365, see Apps included in Conditional Access Office 365 app suite  MicrosoftAdminPortals - For more information, see Conditional Access Target resources: Microsoft Admin Portals</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludeApplications
        {
            get { return BackingStore?.Get<List<string>?>("excludeApplications"); }
            set { BackingStore?.Set("excludeApplications", value); }
        }
#nullable restore
#else
        public List<string> ExcludeApplications
        {
            get { return BackingStore?.Get<List<string>>("excludeApplications"); }
            set { BackingStore?.Set("excludeApplications", value); }
        }
#endif
        /// <summary>Can be one of the following:  The list of client IDs (appId) the policy applies to, unless explicitly excluded (in excludeApplications)  All  Office365 - For the list of apps included in Office365, see Apps included in Conditional Access Office 365 app suite  MicrosoftAdminPortals - For more information, see Conditional Access Target resources: Microsoft Admin Portals</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncludeApplications
        {
            get { return BackingStore?.Get<List<string>?>("includeApplications"); }
            set { BackingStore?.Set("includeApplications", value); }
        }
#nullable restore
#else
        public List<string> IncludeApplications
        {
            get { return BackingStore?.Get<List<string>>("includeApplications"); }
            set { BackingStore?.Set("includeApplications", value); }
        }
#endif
        /// <summary>Authentication context class references include. Supported values are c1 through c25.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncludeAuthenticationContextClassReferences
        {
            get { return BackingStore?.Get<List<string>?>("includeAuthenticationContextClassReferences"); }
            set { BackingStore?.Set("includeAuthenticationContextClassReferences", value); }
        }
#nullable restore
#else
        public List<string> IncludeAuthenticationContextClassReferences
        {
            get { return BackingStore?.Get<List<string>>("includeAuthenticationContextClassReferences"); }
            set { BackingStore?.Set("includeAuthenticationContextClassReferences", value); }
        }
#endif
        /// <summary>User actions to include. Supported values are urn:user:registersecurityinfo and urn:user:registerdevice</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncludeUserActions
        {
            get { return BackingStore?.Get<List<string>?>("includeUserActions"); }
            set { BackingStore?.Set("includeUserActions", value); }
        }
#nullable restore
#else
        public List<string> IncludeUserActions
        {
            get { return BackingStore?.Get<List<string>>("includeUserActions"); }
            set { BackingStore?.Set("includeUserActions", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ConditionalAccessApplications"/> and sets the default values.
        /// </summary>
        public ConditionalAccessApplications()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ConditionalAccessApplications"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.ConditionalAccessApplications CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ConditionalAccessApplications();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "applicationFilter", n => { ApplicationFilter = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ConditionalAccessFilter>(global::Microsoft.Graph.Beta.Models.ConditionalAccessFilter.CreateFromDiscriminatorValue); } },
                { "excludeApplications", n => { ExcludeApplications = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "includeApplications", n => { IncludeApplications = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "includeAuthenticationContextClassReferences", n => { IncludeAuthenticationContextClassReferences = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "includeUserActions", n => { IncludeUserActions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ConditionalAccessFilter>("applicationFilter", ApplicationFilter);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeApplications", ExcludeApplications);
            writer.WriteCollectionOfPrimitiveValues<string>("includeApplications", IncludeApplications);
            writer.WriteCollectionOfPrimitiveValues<string>("includeAuthenticationContextClassReferences", IncludeAuthenticationContextClassReferences);
            writer.WriteCollectionOfPrimitiveValues<string>("includeUserActions", IncludeUserActions);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
