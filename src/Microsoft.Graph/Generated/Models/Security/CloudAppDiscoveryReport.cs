// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CloudAppDiscoveryReport : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Use 1 if the machine information is anonymized; otherwise use 0.</summary>
        public bool? AnonymizeMachineData
        {
            get { return BackingStore?.Get<bool?>("anonymizeMachineData"); }
            set { BackingStore?.Set("anonymizeMachineData", value); }
        }
        /// <summary>Use 1 if the user information is anonymized; otherwise use 0.</summary>
        public bool? AnonymizeUserData
        {
            get { return BackingStore?.Get<bool?>("anonymizeUserData"); }
            set { BackingStore?.Set("anonymizeUserData", value); }
        }
        /// <summary>The date in the format specified. The Timestamp represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>A comment or description for the report.</summary>
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
        /// <summary>The display name of the continuous report.</summary>
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
        /// <summary>Use 1 for a snapshot report; otherwise use 0.</summary>
        public bool? IsSnapshotReport
        {
            get { return BackingStore?.Get<bool?>("isSnapshotReport"); }
            set { BackingStore?.Set("isSnapshotReport", value); }
        }
        /// <summary>The date when the data was last received. The Timestamp represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastDataReceivedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastDataReceivedDateTime"); }
            set { BackingStore?.Set("lastDataReceivedDateTime", value); }
        }
        /// <summary>The date when the continuous report was last modified. The Timestamp represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The applicable log data provider. Possible values are: barracuda, bluecoat, checkpoint, ciscoAsa, ciscoIronportProxy, fortigate, paloAlto, squid, zscaler, mcafeeSwg, ciscoScanSafe, juniperSrx, sophosSg, websenseV75, websenseSiemCef, machineZoneMeraki, squidNative, ciscoFwsm, microsoftIsaW3C, sonicwall, sophosCyberoam, clavister, customParser, juniperSsg, zscalerQradar, juniperSrxSd, juniperSrxWelf, microsoftConditionalAppAccess, ciscoAsaFirepower, genericCef, genericLeef, genericW3C, iFilter, checkpointXml, checkpointSmartViewTracker, barracudaNextGenFw, barracudaNextGenFwWeblog, microsoftDefenderForEndpoint, zscalerCef, sophosXg, iboss, forcepoint, fortios, ciscoIronportWsaIi, paloAltoLeef, forcepointLeef, stormshield, contentkeeper, ciscoIronportWsaIii, checkpointCef, corrata, ciscoFirepowerV6, menloSecurityCef, watchguardXtm, openSystemsSecureWebGateway, wandera, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.Security.LogDataProvider? LogDataProvider
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.LogDataProvider?>("logDataProvider"); }
            set { BackingStore?.Set("logDataProvider", value); }
        }
        /// <summary>The count of log files history.</summary>
        public int? LogFileCount
        {
            get { return BackingStore?.Get<int?>("logFileCount"); }
            set { BackingStore?.Set("logFileCount", value); }
        }
        /// <summary>The applicable receiver protocol. Possible values are: ftp, ftps, syslogUdp, syslogTcp, syslogTls, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.Security.ReceiverProtocol? ReceiverProtocol
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.ReceiverProtocol?>("receiverProtocol"); }
            set { BackingStore?.Set("receiverProtocol", value); }
        }
        /// <summary>The supported entity type. Possible values are: userName, ipAddress, machineName, other, unknown, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.EntityType?>? SupportedEntityTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EntityType?>?>("supportedEntityTypes"); }
            set { BackingStore?.Set("supportedEntityTypes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.EntityType?> SupportedEntityTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EntityType?>>("supportedEntityTypes"); }
            set { BackingStore?.Set("supportedEntityTypes", value); }
        }
#endif
        /// <summary>The supported traffic type. Possible values are: downloadedBytes, uploadedBytes, unknown, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.TrafficType?>? SupportedTrafficTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.TrafficType?>?>("supportedTrafficTypes"); }
            set { BackingStore?.Set("supportedTrafficTypes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.TrafficType?> SupportedTrafficTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.TrafficType?>>("supportedTrafficTypes"); }
            set { BackingStore?.Set("supportedTrafficTypes", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.CloudAppDiscoveryReport"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.CloudAppDiscoveryReport CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.CloudAppDiscoveryReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "anonymizeMachineData", n => { AnonymizeMachineData = n.GetBoolValue(); } },
                { "anonymizeUserData", n => { AnonymizeUserData = n.GetBoolValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isSnapshotReport", n => { IsSnapshotReport = n.GetBoolValue(); } },
                { "lastDataReceivedDateTime", n => { LastDataReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "logDataProvider", n => { LogDataProvider = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Security.LogDataProvider>(); } },
                { "logFileCount", n => { LogFileCount = n.GetIntValue(); } },
                { "receiverProtocol", n => { ReceiverProtocol = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Security.ReceiverProtocol>(); } },
                { "supportedEntityTypes", n => { SupportedEntityTypes = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.Security.EntityType>()?.AsList(); } },
                { "supportedTrafficTypes", n => { SupportedTrafficTypes = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.Security.TrafficType>()?.AsList(); } },
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
            writer.WriteBoolValue("anonymizeMachineData", AnonymizeMachineData);
            writer.WriteBoolValue("anonymizeUserData", AnonymizeUserData);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isSnapshotReport", IsSnapshotReport);
            writer.WriteDateTimeOffsetValue("lastDataReceivedDateTime", LastDataReceivedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Security.LogDataProvider>("logDataProvider", LogDataProvider);
            writer.WriteIntValue("logFileCount", LogFileCount);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Security.ReceiverProtocol>("receiverProtocol", ReceiverProtocol);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.Security.EntityType>("supportedEntityTypes", SupportedEntityTypes);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.Security.TrafficType>("supportedTrafficTypes", SupportedTrafficTypes);
        }
    }
}
#pragma warning restore CS0618
