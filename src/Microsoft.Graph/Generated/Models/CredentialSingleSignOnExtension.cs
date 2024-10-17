// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Represents a Credential-type Single Sign-On extension profile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CredentialSingleSignOnExtension : global::Microsoft.Graph.Beta.Models.SingleSignOnExtension, IParsable
    {
        /// <summary>Gets or sets a list of typed key-value pairs used to configure Credential-type profiles. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair>? Configurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair>?>("configurations"); }
            set { BackingStore?.Set("configurations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair> Configurations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair>>("configurations"); }
            set { BackingStore?.Set("configurations", value); }
        }
#endif
        /// <summary>Gets or sets a list of hosts or domain names for which the app extension performs SSO.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Domains
        {
            get { return BackingStore?.Get<List<string>?>("domains"); }
            set { BackingStore?.Set("domains", value); }
        }
#nullable restore
#else
        public List<string> Domains
        {
            get { return BackingStore?.Get<List<string>>("domains"); }
            set { BackingStore?.Set("domains", value); }
        }
#endif
        /// <summary>Gets or sets the bundle ID of the app extension that performs SSO for the specified URLs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionIdentifier
        {
            get { return BackingStore?.Get<string?>("extensionIdentifier"); }
            set { BackingStore?.Set("extensionIdentifier", value); }
        }
#nullable restore
#else
        public string ExtensionIdentifier
        {
            get { return BackingStore?.Get<string>("extensionIdentifier"); }
            set { BackingStore?.Set("extensionIdentifier", value); }
        }
#endif
        /// <summary>Gets or sets the case-sensitive realm name for this profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Realm
        {
            get { return BackingStore?.Get<string?>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
#nullable restore
#else
        public string Realm
        {
            get { return BackingStore?.Get<string>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
#endif
        /// <summary>Gets or sets the team ID of the app extension that performs SSO for the specified URLs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamIdentifier
        {
            get { return BackingStore?.Get<string?>("teamIdentifier"); }
            set { BackingStore?.Set("teamIdentifier", value); }
        }
#nullable restore
#else
        public string TeamIdentifier
        {
            get { return BackingStore?.Get<string>("teamIdentifier"); }
            set { BackingStore?.Set("teamIdentifier", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CredentialSingleSignOnExtension"/> and sets the default values.
        /// </summary>
        public CredentialSingleSignOnExtension() : base()
        {
            OdataType = "#microsoft.graph.credentialSingleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CredentialSingleSignOnExtension"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CredentialSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CredentialSingleSignOnExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configurations", n => { Configurations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair>(global::Microsoft.Graph.Beta.Models.KeyTypedValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "domains", n => { Domains = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "extensionIdentifier", n => { ExtensionIdentifier = n.GetStringValue(); } },
                { "realm", n => { Realm = n.GetStringValue(); } },
                { "teamIdentifier", n => { TeamIdentifier = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.KeyTypedValuePair>("configurations", Configurations);
            writer.WriteCollectionOfPrimitiveValues<string>("domains", Domains);
            writer.WriteStringValue("extensionIdentifier", ExtensionIdentifier);
            writer.WriteStringValue("realm", Realm);
            writer.WriteStringValue("teamIdentifier", TeamIdentifier);
        }
    }
}
#pragma warning restore CS0618
