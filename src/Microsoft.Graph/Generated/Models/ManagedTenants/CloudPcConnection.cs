// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class CloudPcConnection : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The display name of the cloud PC connection. Required. Read-only.</summary>
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
        /// <summary>The health status of the cloud PC connection. Possible values are: pending, running, passed, failed, unknownFutureValue.  Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HealthCheckStatus
        {
            get { return BackingStore?.Get<string?>("healthCheckStatus"); }
            set { BackingStore?.Set("healthCheckStatus", value); }
        }
#nullable restore
#else
        public string HealthCheckStatus
        {
            get { return BackingStore?.Get<string>("healthCheckStatus"); }
            set { BackingStore?.Set("healthCheckStatus", value); }
        }
#endif
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Required. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshedDateTime"); }
            set { BackingStore?.Set("lastRefreshedDateTime", value); }
        }
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDisplayName
        {
            get { return BackingStore?.Get<string?>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#nullable restore
#else
        public string TenantDisplayName
        {
            get { return BackingStore?.Get<string>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#endif
        /// <summary>The Microsoft Entra tenant identifier for the managed tenant. Required. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId
        {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId
        {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ManagedTenants.CloudPcConnection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ManagedTenants.CloudPcConnection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ManagedTenants.CloudPcConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "healthCheckStatus", n => { HealthCheckStatus = n.GetStringValue(); } },
                { "lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                { "tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("healthCheckStatus", HealthCheckStatus);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
#pragma warning restore CS0618
