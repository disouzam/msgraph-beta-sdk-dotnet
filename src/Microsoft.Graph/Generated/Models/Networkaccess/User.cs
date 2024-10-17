// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class User : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>User display Name.</summary>
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
        /// <summary>The firstAccessDateTime property</summary>
        public DateTimeOffset? FirstAccessDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstAccessDateTime"); }
            set { BackingStore?.Set("firstAccessDateTime", value); }
        }
        /// <summary>The date and time of the most recent access.</summary>
        public DateTimeOffset? LastAccessDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastAccessDateTime"); }
            set { BackingStore?.Set("lastAccessDateTime", value); }
        }
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
        /// <summary>The totalBytesReceived property</summary>
        public long? TotalBytesReceived
        {
            get { return BackingStore?.Get<long?>("totalBytesReceived"); }
            set { BackingStore?.Set("totalBytesReceived", value); }
        }
        /// <summary>The totalBytesSent property</summary>
        public long? TotalBytesSent
        {
            get { return BackingStore?.Get<long?>("totalBytesSent"); }
            set { BackingStore?.Set("totalBytesSent", value); }
        }
        /// <summary>The trafficType property</summary>
        public global::Microsoft.Graph.Beta.Models.Networkaccess.TrafficType? TrafficType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Networkaccess.TrafficType?>("trafficType"); }
            set { BackingStore?.Set("trafficType", value); }
        }
        /// <summary>The transactionCount property</summary>
        public long? TransactionCount
        {
            get { return BackingStore?.Get<long?>("transactionCount"); }
            set { BackingStore?.Set("transactionCount", value); }
        }
        /// <summary>The ID for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId
        {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId
        {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>A unique identifier that is associated with a user in a system or directory. Typically, this value is an email address that is used for user authentication and identification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName
        {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName
        {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>The userType property</summary>
        public global::Microsoft.Graph.Beta.Models.Networkaccess.UserType? UserType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Networkaccess.UserType?>("userType"); }
            set { BackingStore?.Set("userType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Networkaccess.User"/> and sets the default values.
        /// </summary>
        public User()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Networkaccess.User"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.Networkaccess.User CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Networkaccess.User();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "firstAccessDateTime", n => { FirstAccessDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastAccessDateTime", n => { LastAccessDateTime = n.GetDateTimeOffsetValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "totalBytesReceived", n => { TotalBytesReceived = n.GetLongValue(); } },
                { "totalBytesSent", n => { TotalBytesSent = n.GetLongValue(); } },
                { "trafficType", n => { TrafficType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Networkaccess.TrafficType>(); } },
                { "transactionCount", n => { TransactionCount = n.GetLongValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                { "userType", n => { UserType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Networkaccess.UserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("firstAccessDateTime", FirstAccessDateTime);
            writer.WriteDateTimeOffsetValue("lastAccessDateTime", LastAccessDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("totalBytesReceived", TotalBytesReceived);
            writer.WriteLongValue("totalBytesSent", TotalBytesSent);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Networkaccess.TrafficType>("trafficType", TrafficType);
            writer.WriteLongValue("transactionCount", TransactionCount);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Networkaccess.UserType>("userType", UserType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
