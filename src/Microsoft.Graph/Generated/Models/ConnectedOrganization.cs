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
    public partial class ConnectedOrganization : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>UPN of the user who created this resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy
        {
            get { return BackingStore?.Get<string?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public string CreatedBy
        {
            get { return BackingStore?.Get<string>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description of the connected organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the connected organization. Supports $filter (eq).</summary>
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
        /// <summary>The externalSponsors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DirectoryObject>? ExternalSponsors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DirectoryObject>?>("externalSponsors"); }
            set { BackingStore?.Set("externalSponsors", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DirectoryObject> ExternalSponsors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DirectoryObject>>("externalSponsors"); }
            set { BackingStore?.Set("externalSponsors", value); }
        }
#endif
        /// <summary>The identity sources in this connected organization, one of azureActiveDirectoryTenant, crossCloudAzureActiveDirectoryTenant, domainIdentitySource, externalDomainFederation, or socialIdentitySource. Read-only. Nullable. Supports $select and $filter(eq). To filter by the derived types, you must declare the resource using its full OData cast, for example, $filter=identitySources/any(is:is/microsoft.graph.azureActiveDirectoryTenant/tenantId eq &apos;bcfdfff4-cbc3-43f2-9000-ba7b7515054f&apos;).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IdentitySource>? IdentitySources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentitySource>?>("identitySources"); }
            set { BackingStore?.Set("identitySources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IdentitySource> IdentitySources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentitySource>>("identitySources"); }
            set { BackingStore?.Set("identitySources", value); }
        }
#endif
        /// <summary>The internalSponsors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DirectoryObject>? InternalSponsors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DirectoryObject>?>("internalSponsors"); }
            set { BackingStore?.Set("internalSponsors", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DirectoryObject> InternalSponsors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DirectoryObject>>("internalSponsors"); }
            set { BackingStore?.Set("internalSponsors", value); }
        }
#endif
        /// <summary>UPN of the user who last modified this resource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModifiedBy
        {
            get { return BackingStore?.Get<string?>("modifiedBy"); }
            set { BackingStore?.Set("modifiedBy", value); }
        }
#nullable restore
#else
        public string ModifiedBy
        {
            get { return BackingStore?.Get<string>("modifiedBy"); }
            set { BackingStore?.Set("modifiedBy", value); }
        }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>The state of a connected organization defines whether assignment policies with requestor scope type AllConfiguredConnectedOrganizationSubjects are applicable or not. Possible values are: configured, proposed.</summary>
        public global::Microsoft.Graph.Beta.Models.ConnectedOrganizationState? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ConnectedOrganizationState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ConnectedOrganization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ConnectedOrganization CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ConnectedOrganization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdBy", n => { CreatedBy = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "externalSponsors", n => { ExternalSponsors = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DirectoryObject>(global::Microsoft.Graph.Beta.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "identitySources", n => { IdentitySources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentitySource>(global::Microsoft.Graph.Beta.Models.IdentitySource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "internalSponsors", n => { InternalSponsors = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DirectoryObject>(global::Microsoft.Graph.Beta.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "modifiedBy", n => { ModifiedBy = n.GetStringValue(); } },
                { "modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ConnectedOrganizationState>(); } },
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
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DirectoryObject>("externalSponsors", ExternalSponsors);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentitySource>("identitySources", IdentitySources);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DirectoryObject>("internalSponsors", InternalSponsors);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ConnectedOrganizationState>("state", State);
        }
    }
}
#pragma warning restore CS0618
