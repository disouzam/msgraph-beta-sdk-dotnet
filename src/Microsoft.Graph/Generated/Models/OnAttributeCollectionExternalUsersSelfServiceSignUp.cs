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
    public partial class OnAttributeCollectionExternalUsersSelfServiceSignUp : global::Microsoft.Graph.Beta.Models.OnAttributeCollectionHandler, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Required. The configuration for how attributes are displayed in the sign up experience defined by a user flow, like the externalUsersSelfServiceSignupEventsFlow, specifically on the attribute collection page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPage? AttributeCollectionPage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPage?>("attributeCollectionPage"); }
            set { BackingStore?.Set("attributeCollectionPage", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPage AttributeCollectionPage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPage>("attributeCollectionPage"); }
            set { BackingStore?.Set("attributeCollectionPage", value); }
        }
#endif
        /// <summary>The attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute>? Attributes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute>?>("attributes"); }
            set { BackingStore?.Set("attributes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute> Attributes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute>>("attributes"); }
            set { BackingStore?.Set("attributes", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.OnAttributeCollectionExternalUsersSelfServiceSignUp"/> and sets the default values.
        /// </summary>
        public OnAttributeCollectionExternalUsersSelfServiceSignUp() : base()
        {
            OdataType = "#microsoft.graph.onAttributeCollectionExternalUsersSelfServiceSignUp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.OnAttributeCollectionExternalUsersSelfServiceSignUp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.OnAttributeCollectionExternalUsersSelfServiceSignUp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.OnAttributeCollectionExternalUsersSelfServiceSignUp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "attributeCollectionPage", n => { AttributeCollectionPage = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPage>(global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPage.CreateFromDiscriminatorValue); } },
                { "attributes", n => { Attributes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute>(global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AuthenticationAttributeCollectionPage>("attributeCollectionPage", AttributeCollectionPage);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute>("attributes", Attributes);
        }
    }
}
#pragma warning restore CS0618
