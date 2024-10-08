// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class MailboxConfigurationEvidence : global::Microsoft.Graph.Beta.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The configurationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConfigurationId
        {
            get { return BackingStore?.Get<string?>("configurationId"); }
            set { BackingStore?.Set("configurationId", value); }
        }
#nullable restore
#else
        public string ConfigurationId
        {
            get { return BackingStore?.Get<string>("configurationId"); }
            set { BackingStore?.Set("configurationId", value); }
        }
#endif
        /// <summary>The configurationType property</summary>
        public global::Microsoft.Graph.Beta.Models.Security.MailboxConfigurationType? ConfigurationType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.MailboxConfigurationType?>("configurationType"); }
            set { BackingStore?.Set("configurationType", value); }
        }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The externalDirectoryObjectId property</summary>
        public Guid? ExternalDirectoryObjectId
        {
            get { return BackingStore?.Get<Guid?>("externalDirectoryObjectId"); }
            set { BackingStore?.Set("externalDirectoryObjectId", value); }
        }
        /// <summary>The mailboxPrimaryAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MailboxPrimaryAddress
        {
            get { return BackingStore?.Get<string?>("mailboxPrimaryAddress"); }
            set { BackingStore?.Set("mailboxPrimaryAddress", value); }
        }
#nullable restore
#else
        public string MailboxPrimaryAddress
        {
            get { return BackingStore?.Get<string>("mailboxPrimaryAddress"); }
            set { BackingStore?.Set("mailboxPrimaryAddress", value); }
        }
#endif
        /// <summary>The upn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Upn
        {
            get { return BackingStore?.Get<string?>("upn"); }
            set { BackingStore?.Set("upn", value); }
        }
#nullable restore
#else
        public string Upn
        {
            get { return BackingStore?.Get<string>("upn"); }
            set { BackingStore?.Set("upn", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Security.MailboxConfigurationEvidence"/> and sets the default values.
        /// </summary>
        public MailboxConfigurationEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.mailboxConfigurationEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.MailboxConfigurationEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.MailboxConfigurationEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.MailboxConfigurationEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configurationId", n => { ConfigurationId = n.GetStringValue(); } },
                { "configurationType", n => { ConfigurationType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Security.MailboxConfigurationType>(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "externalDirectoryObjectId", n => { ExternalDirectoryObjectId = n.GetGuidValue(); } },
                { "mailboxPrimaryAddress", n => { MailboxPrimaryAddress = n.GetStringValue(); } },
                { "upn", n => { Upn = n.GetStringValue(); } },
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
            writer.WriteStringValue("configurationId", ConfigurationId);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Security.MailboxConfigurationType>("configurationType", ConfigurationType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteGuidValue("externalDirectoryObjectId", ExternalDirectoryObjectId);
            writer.WriteStringValue("mailboxPrimaryAddress", MailboxPrimaryAddress);
            writer.WriteStringValue("upn", Upn);
        }
    }
}
#pragma warning restore CS0618
