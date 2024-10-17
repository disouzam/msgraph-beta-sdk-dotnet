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
    public partial class CertificateBasedAuthPki : global::Microsoft.Graph.Beta.Models.DirectoryObject, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The certificateAuthorities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CertificateAuthorityDetail>? CertificateAuthorities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CertificateAuthorityDetail>?>("certificateAuthorities"); }
            set { BackingStore?.Set("certificateAuthorities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CertificateAuthorityDetail> CertificateAuthorities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CertificateAuthorityDetail>>("certificateAuthorities"); }
            set { BackingStore?.Set("certificateAuthorities", value); }
        }
#endif
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
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status
        {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status
        {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>The statusDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusDetails
        {
            get { return BackingStore?.Get<string?>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
#nullable restore
#else
        public string StatusDetails
        {
            get { return BackingStore?.Get<string>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CertificateBasedAuthPki"/> and sets the default values.
        /// </summary>
        public CertificateBasedAuthPki() : base()
        {
            OdataType = "#microsoft.graph.certificateBasedAuthPki";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CertificateBasedAuthPki"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CertificateBasedAuthPki CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CertificateBasedAuthPki();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certificateAuthorities", n => { CertificateAuthorities = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CertificateAuthorityDetail>(global::Microsoft.Graph.Beta.Models.CertificateAuthorityDetail.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "statusDetails", n => { StatusDetails = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CertificateAuthorityDetail>("certificateAuthorities", CertificateAuthorities);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("statusDetails", StatusDetails);
        }
    }
}
#pragma warning restore CS0618
