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
    public partial class Host : global::Microsoft.Graph.Beta.Models.Security.Artifact, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The hostPairs that are resources associated with a host, where that host is the parentHost and has an outgoing pairing to a cihldHost.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.HostPair>? ChildHostPairs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostPair>?>("childHostPairs"); }
            set { BackingStore?.Set("childHostPairs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.HostPair> ChildHostPairs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostPair>>("childHostPairs"); }
            set { BackingStore?.Set("childHostPairs", value); }
        }
#endif
        /// <summary>The hostComponents that are associated with this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.HostComponent>? Components
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostComponent>?>("components"); }
            set { BackingStore?.Set("components", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.HostComponent> Components
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostComponent>>("components"); }
            set { BackingStore?.Set("components", value); }
        }
#endif
        /// <summary>The hostCookies that are associated with this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.HostCookie>? Cookies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostCookie>?>("cookies"); }
            set { BackingStore?.Set("cookies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.HostCookie> Cookies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostCookie>>("cookies"); }
            set { BackingStore?.Set("cookies", value); }
        }
#endif
        /// <summary>The first date and time when this host was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The hostPairs that are associated with this host, where this host is either the parentHost or childHost.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.HostPair>? HostPairs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostPair>?>("hostPairs"); }
            set { BackingStore?.Set("hostPairs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.HostPair> HostPairs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostPair>>("hostPairs"); }
            set { BackingStore?.Set("hostPairs", value); }
        }
#endif
        /// <summary>The most recent date and time when this host was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The hostPairs that are associated with a host, where that host is the childHost and has an incoming pairing with a parentHost.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.HostPair>? ParentHostPairs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostPair>?>("parentHostPairs"); }
            set { BackingStore?.Set("parentHostPairs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.HostPair> ParentHostPairs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostPair>>("parentHostPairs"); }
            set { BackingStore?.Set("parentHostPairs", value); }
        }
#endif
        /// <summary>Passive DNS retrieval about this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>? PassiveDns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>?>("passiveDns"); }
            set { BackingStore?.Set("passiveDns", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord> PassiveDns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>>("passiveDns"); }
            set { BackingStore?.Set("passiveDns", value); }
        }
#endif
        /// <summary>Reverse passive DNS retrieval about this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>? PassiveDnsReverse
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>?>("passiveDnsReverse"); }
            set { BackingStore?.Set("passiveDnsReverse", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord> PassiveDnsReverse
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>>("passiveDnsReverse"); }
            set { BackingStore?.Set("passiveDnsReverse", value); }
        }
#endif
        /// <summary>The hostPorts associated with a host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.HostPort>? Ports
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostPort>?>("ports"); }
            set { BackingStore?.Set("ports", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.HostPort> Ports
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostPort>>("ports"); }
            set { BackingStore?.Set("ports", value); }
        }
#endif
        /// <summary>Represents a calculated reputation of this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.HostReputation? Reputation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.HostReputation?>("reputation"); }
            set { BackingStore?.Set("reputation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.HostReputation Reputation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.HostReputation>("reputation"); }
            set { BackingStore?.Set("reputation", value); }
        }
#endif
        /// <summary>The hostSslCertificates that are associated with this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.HostSslCertificate>? SslCertificates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostSslCertificate>?>("sslCertificates"); }
            set { BackingStore?.Set("sslCertificates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.HostSslCertificate> SslCertificates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostSslCertificate>>("sslCertificates"); }
            set { BackingStore?.Set("sslCertificates", value); }
        }
#endif
        /// <summary>The subdomains that are associated with this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.Subdomain>? Subdomains
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.Subdomain>?>("subdomains"); }
            set { BackingStore?.Set("subdomains", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.Subdomain> Subdomains
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.Subdomain>>("subdomains"); }
            set { BackingStore?.Set("subdomains", value); }
        }
#endif
        /// <summary>The hostTrackers that are associated with this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.HostTracker>? Trackers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostTracker>?>("trackers"); }
            set { BackingStore?.Set("trackers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.HostTracker> Trackers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.HostTracker>>("trackers"); }
            set { BackingStore?.Set("trackers", value); }
        }
#endif
        /// <summary>The most recent whoisRecord for this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.WhoisRecord? Whois
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.WhoisRecord?>("whois"); }
            set { BackingStore?.Set("whois", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.WhoisRecord Whois
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.WhoisRecord>("whois"); }
            set { BackingStore?.Set("whois", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Security.Host"/> and sets the default values.
        /// </summary>
        public Host() : base()
        {
            OdataType = "#microsoft.graph.security.host";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.Host"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.Host CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.hostname" => new global::Microsoft.Graph.Beta.Models.Security.Hostname(),
                "#microsoft.graph.security.ipAddress" => new global::Microsoft.Graph.Beta.Models.Security.IpAddress(),
                _ => new global::Microsoft.Graph.Beta.Models.Security.Host(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "childHostPairs", n => { ChildHostPairs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostPair>(global::Microsoft.Graph.Beta.Models.Security.HostPair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "components", n => { Components = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostComponent>(global::Microsoft.Graph.Beta.Models.Security.HostComponent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "cookies", n => { Cookies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostCookie>(global::Microsoft.Graph.Beta.Models.Security.HostCookie.CreateFromDiscriminatorValue)?.AsList(); } },
                { "firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "hostPairs", n => { HostPairs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostPair>(global::Microsoft.Graph.Beta.Models.Security.HostPair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "parentHostPairs", n => { ParentHostPairs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostPair>(global::Microsoft.Graph.Beta.Models.Security.HostPair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "passiveDns", n => { PassiveDns = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>(global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord.CreateFromDiscriminatorValue)?.AsList(); } },
                { "passiveDnsReverse", n => { PassiveDnsReverse = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>(global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord.CreateFromDiscriminatorValue)?.AsList(); } },
                { "ports", n => { Ports = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostPort>(global::Microsoft.Graph.Beta.Models.Security.HostPort.CreateFromDiscriminatorValue)?.AsList(); } },
                { "reputation", n => { Reputation = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.HostReputation>(global::Microsoft.Graph.Beta.Models.Security.HostReputation.CreateFromDiscriminatorValue); } },
                { "sslCertificates", n => { SslCertificates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostSslCertificate>(global::Microsoft.Graph.Beta.Models.Security.HostSslCertificate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "subdomains", n => { Subdomains = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.Subdomain>(global::Microsoft.Graph.Beta.Models.Security.Subdomain.CreateFromDiscriminatorValue)?.AsList(); } },
                { "trackers", n => { Trackers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostTracker>(global::Microsoft.Graph.Beta.Models.Security.HostTracker.CreateFromDiscriminatorValue)?.AsList(); } },
                { "whois", n => { Whois = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.WhoisRecord>(global::Microsoft.Graph.Beta.Models.Security.WhoisRecord.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostPair>("childHostPairs", ChildHostPairs);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostComponent>("components", Components);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostCookie>("cookies", Cookies);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostPair>("hostPairs", HostPairs);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostPair>("parentHostPairs", ParentHostPairs);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>("passiveDns", PassiveDns);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>("passiveDnsReverse", PassiveDnsReverse);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostPort>("ports", Ports);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.HostReputation>("reputation", Reputation);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostSslCertificate>("sslCertificates", SslCertificates);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.Subdomain>("subdomains", Subdomains);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.HostTracker>("trackers", Trackers);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.WhoisRecord>("whois", Whois);
        }
    }
}
#pragma warning restore CS0618
