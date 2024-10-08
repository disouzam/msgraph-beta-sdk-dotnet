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
    public partial class InvalidLicenseAlertIncident : global::Microsoft.Graph.Beta.Models.UnifiedRoleManagementAlertIncident, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Status of the tenant&apos;s Microsoft Entra ID P2 license.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantLicenseStatus
        {
            get { return BackingStore?.Get<string?>("tenantLicenseStatus"); }
            set { BackingStore?.Set("tenantLicenseStatus", value); }
        }
#nullable restore
#else
        public string TenantLicenseStatus
        {
            get { return BackingStore?.Get<string>("tenantLicenseStatus"); }
            set { BackingStore?.Set("tenantLicenseStatus", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.InvalidLicenseAlertIncident"/> and sets the default values.
        /// </summary>
        public InvalidLicenseAlertIncident() : base()
        {
            OdataType = "#microsoft.graph.invalidLicenseAlertIncident";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.InvalidLicenseAlertIncident"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.InvalidLicenseAlertIncident CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.InvalidLicenseAlertIncident();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "tenantLicenseStatus", n => { TenantLicenseStatus = n.GetStringValue(); } },
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
            writer.WriteStringValue("tenantLicenseStatus", TenantLicenseStatus);
        }
    }
}
#pragma warning restore CS0618
