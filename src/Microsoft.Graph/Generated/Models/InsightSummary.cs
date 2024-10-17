// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class InsightSummary : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Daily active users.</summary>
        public long? ActiveUsers
        {
            get { return BackingStore?.Get<long?>("activeUsers"); }
            set { BackingStore?.Set("activeUsers", value); }
        }
        /// <summary>The ID of the Microsoft Entra application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId
        {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId
        {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>Daily authentication completions.</summary>
        public long? AuthenticationCompletions
        {
            get { return BackingStore?.Get<long?>("authenticationCompletions"); }
            set { BackingStore?.Set("authenticationCompletions", value); }
        }
        /// <summary>Daily authentication requests.</summary>
        public long? AuthenticationRequests
        {
            get { return BackingStore?.Get<long?>("authenticationRequests"); }
            set { BackingStore?.Set("authenticationRequests", value); }
        }
        /// <summary>The date of the insight.</summary>
        public Date? FactDate
        {
            get { return BackingStore?.Get<Date?>("factDate"); }
            set { BackingStore?.Set("factDate", value); }
        }
        /// <summary>The platform for the device that the customers used. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Os
        {
            get { return BackingStore?.Get<string?>("os"); }
            set { BackingStore?.Set("os", value); }
        }
#nullable restore
#else
        public string Os
        {
            get { return BackingStore?.Get<string>("os"); }
            set { BackingStore?.Set("os", value); }
        }
#endif
        /// <summary>Daily MFA SMS completions.</summary>
        public long? SecurityTextCompletions
        {
            get { return BackingStore?.Get<long?>("securityTextCompletions"); }
            set { BackingStore?.Set("securityTextCompletions", value); }
        }
        /// <summary>Daily MFA SMS requests.</summary>
        public long? SecurityTextRequests
        {
            get { return BackingStore?.Get<long?>("securityTextRequests"); }
            set { BackingStore?.Set("securityTextRequests", value); }
        }
        /// <summary>Daily MFA Voice completions.</summary>
        public long? SecurityVoiceCompletions
        {
            get { return BackingStore?.Get<long?>("securityVoiceCompletions"); }
            set { BackingStore?.Set("securityVoiceCompletions", value); }
        }
        /// <summary>Daily MFA Voice requests.</summary>
        public long? SecurityVoiceRequests
        {
            get { return BackingStore?.Get<long?>("securityVoiceRequests"); }
            set { BackingStore?.Set("securityVoiceRequests", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.InsightSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.InsightSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.InsightSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeUsers", n => { ActiveUsers = n.GetLongValue(); } },
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "authenticationCompletions", n => { AuthenticationCompletions = n.GetLongValue(); } },
                { "authenticationRequests", n => { AuthenticationRequests = n.GetLongValue(); } },
                { "factDate", n => { FactDate = n.GetDateValue(); } },
                { "os", n => { Os = n.GetStringValue(); } },
                { "securityTextCompletions", n => { SecurityTextCompletions = n.GetLongValue(); } },
                { "securityTextRequests", n => { SecurityTextRequests = n.GetLongValue(); } },
                { "securityVoiceCompletions", n => { SecurityVoiceCompletions = n.GetLongValue(); } },
                { "securityVoiceRequests", n => { SecurityVoiceRequests = n.GetLongValue(); } },
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
            writer.WriteLongValue("activeUsers", ActiveUsers);
            writer.WriteStringValue("appId", AppId);
            writer.WriteLongValue("authenticationCompletions", AuthenticationCompletions);
            writer.WriteLongValue("authenticationRequests", AuthenticationRequests);
            writer.WriteDateValue("factDate", FactDate);
            writer.WriteStringValue("os", Os);
            writer.WriteLongValue("securityTextCompletions", SecurityTextCompletions);
            writer.WriteLongValue("securityTextRequests", SecurityTextRequests);
            writer.WriteLongValue("securityVoiceCompletions", SecurityVoiceCompletions);
            writer.WriteLongValue("securityVoiceRequests", SecurityVoiceRequests);
        }
    }
}
#pragma warning restore CS0618
