// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class LogonUser : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Domain of user account used to logon.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountDomain
        {
            get { return BackingStore?.Get<string?>("accountDomain"); }
            set { BackingStore?.Set("accountDomain", value); }
        }
#nullable restore
#else
        public string AccountDomain
        {
            get { return BackingStore?.Get<string>("accountDomain"); }
            set { BackingStore?.Set("accountDomain", value); }
        }
#endif
        /// <summary>Account name of user account used to logon.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountName
        {
            get { return BackingStore?.Get<string?>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
#nullable restore
#else
        public string AccountName
        {
            get { return BackingStore?.Get<string>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
#endif
        /// <summary>User Account type, per Windows definition. Possible values are: unknown, standard, power, administrator.</summary>
        public global::Microsoft.Graph.Beta.Models.UserAccountSecurityType? AccountType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.UserAccountSecurityType?>("accountType"); }
            set { BackingStore?.Set("accountType", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>DateTime at which the earliest logon by this user account occurred (provider-determined period). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>DateTime at which the latest logon by this user account occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>User logon ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogonId
        {
            get { return BackingStore?.Get<string?>("logonId"); }
            set { BackingStore?.Set("logonId", value); }
        }
#nullable restore
#else
        public string LogonId
        {
            get { return BackingStore?.Get<string>("logonId"); }
            set { BackingStore?.Set("logonId", value); }
        }
#endif
        /// <summary>Collection of the logon types observed for the logged on user from when first to last seen. Possible values are: unknown, interactive, remoteInteractive, network, batch, service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.LogonType?>? LogonTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.LogonType?>?>("logonTypes"); }
            set { BackingStore?.Set("logonTypes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.LogonType?> LogonTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.LogonType?>>("logonTypes"); }
            set { BackingStore?.Set("logonTypes", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.LogonUser"/> and sets the default values.
        /// </summary>
        public LogonUser()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.LogonUser"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.LogonUser CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.LogonUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accountDomain", n => { AccountDomain = n.GetStringValue(); } },
                { "accountName", n => { AccountName = n.GetStringValue(); } },
                { "accountType", n => { AccountType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.UserAccountSecurityType>(); } },
                { "firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "logonId", n => { LogonId = n.GetStringValue(); } },
                { "logonTypes", n => { LogonTypes = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.LogonType>()?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accountDomain", AccountDomain);
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.UserAccountSecurityType>("accountType", AccountType);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteStringValue("logonId", LogonId);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.LogonType>("logonTypes", LogonTypes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
