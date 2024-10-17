// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AwsAuthorizationSystem : global::Microsoft.Graph.Beta.Models.AuthorizationSystem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of actions for service in authorization system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemTypeAction>? Actions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemTypeAction>?>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemTypeAction> Actions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemTypeAction>>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#endif
        /// <summary>Identities in the authorization system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AwsAssociatedIdentities? AssociatedIdentities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AwsAssociatedIdentities?>("associatedIdentities"); }
            set { BackingStore?.Set("associatedIdentities", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AwsAssociatedIdentities AssociatedIdentities
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AwsAssociatedIdentities>("associatedIdentities"); }
            set { BackingStore?.Set("associatedIdentities", value); }
        }
#endif
        /// <summary>Policies associated with the AWS authorization system type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AwsPolicy>? Policies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AwsPolicy>?>("policies"); }
            set { BackingStore?.Set("policies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AwsPolicy> Policies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AwsPolicy>>("policies"); }
            set { BackingStore?.Set("policies", value); }
        }
#endif
        /// <summary>Resources associated with the authorization system type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemResource>? Resources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemResource>?>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemResource> Resources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#endif
        /// <summary>Services associated with the authorization system type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AuthorizationSystemTypeService>? Services
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthorizationSystemTypeService>?>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AuthorizationSystemTypeService> Services
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthorizationSystemTypeService>>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystem"/> and sets the default values.
        /// </summary>
        public AwsAuthorizationSystem() : base()
        {
            OdataType = "#microsoft.graph.awsAuthorizationSystem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actions", n => { Actions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemTypeAction>(global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemTypeAction.CreateFromDiscriminatorValue)?.AsList(); } },
                { "associatedIdentities", n => { AssociatedIdentities = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AwsAssociatedIdentities>(global::Microsoft.Graph.Beta.Models.AwsAssociatedIdentities.CreateFromDiscriminatorValue); } },
                { "policies", n => { Policies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AwsPolicy>(global::Microsoft.Graph.Beta.Models.AwsPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "resources", n => { Resources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemResource>(global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "services", n => { Services = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthorizationSystemTypeService>(global::Microsoft.Graph.Beta.Models.AuthorizationSystemTypeService.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemTypeAction>("actions", Actions);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AwsAssociatedIdentities>("associatedIdentities", AssociatedIdentities);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AwsPolicy>("policies", Policies);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AwsAuthorizationSystemResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthorizationSystemTypeService>("services", Services);
        }
    }
}
#pragma warning restore CS0618
