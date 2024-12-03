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
    public partial class Payload : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The branch of a payload. Possible values are: unknown, other, americanExpress, capitalOne, dhl, docuSign, dropbox, facebook, firstAmerican, microsoft, netflix, scotiabank, sendGrid, stewartTitle, tesco, wellsFargo, syrinxCloud, adobe, teams, zoom, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.PayloadBrand? Brand
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PayloadBrand?>("brand"); }
            set { BackingStore?.Set("brand", value); }
        }
        /// <summary>The complexity of a payload. Possible values are: unknown, low, medium, high, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.PayloadComplexity? Complexity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PayloadComplexity?>("complexity"); }
            set { BackingStore?.Set("complexity", value); }
        }
        /// <summary>Identity of the user who created the attack simulation and training campaign payload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.EmailIdentity? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EmailIdentity?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.EmailIdentity CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EmailIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>Date and time when the attack simulation and training campaign payload. The timestamp represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description of the attack simulation and training campaign payload.</summary>
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
        /// <summary>More details about the payload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PayloadDetail? Detail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PayloadDetail?>("detail"); }
            set { BackingStore?.Set("detail", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PayloadDetail Detail
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PayloadDetail>("detail"); }
            set { BackingStore?.Set("detail", value); }
        }
#endif
        /// <summary>Display name of the attack simulation and training campaign payload. Supports $filter and $orderby.</summary>
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
        /// <summary>Industry of a payload. Possible values are: unknown, other, banking, businessServices, consumerServices, education, energy, construction, consulting, financialServices, government, hospitality, insurance, legal, courierServices, IT, healthcare, manufacturing, retail, telecom, realEstate, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.PayloadIndustry? Industry
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PayloadIndustry?>("industry"); }
            set { BackingStore?.Set("industry", value); }
        }
        /// <summary>Indicates whether the attack simulation and training campaign payload was created from an automation flow. Supports $filter and $orderby.</summary>
        public bool? IsAutomated
        {
            get { return BackingStore?.Get<bool?>("isAutomated"); }
            set { BackingStore?.Set("isAutomated", value); }
        }
        /// <summary>Indicates whether the payload is controversial.</summary>
        public bool? IsControversial
        {
            get { return BackingStore?.Get<bool?>("isControversial"); }
            set { BackingStore?.Set("isControversial", value); }
        }
        /// <summary>Indicates whether the payload is from any recent event.</summary>
        public bool? IsCurrentEvent
        {
            get { return BackingStore?.Get<bool?>("isCurrentEvent"); }
            set { BackingStore?.Set("isCurrentEvent", value); }
        }
        /// <summary>Payload language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language
        {
            get { return BackingStore?.Get<string?>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#nullable restore
#else
        public string Language
        {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#endif
        /// <summary>Identity of the user who most recently modified the attack simulation and training campaign payload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.EmailIdentity? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EmailIdentity?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.EmailIdentity LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EmailIdentity>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>Date and time when the attack simulation and training campaign payload was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Free text tags for a payload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PayloadTags
        {
            get { return BackingStore?.Get<List<string>?>("payloadTags"); }
            set { BackingStore?.Set("payloadTags", value); }
        }
#nullable restore
#else
        public List<string> PayloadTags
        {
            get { return BackingStore?.Get<List<string>>("payloadTags"); }
            set { BackingStore?.Set("payloadTags", value); }
        }
#endif
        /// <summary>The payload delivery platform for a simulation. Possible values are: unknown, sms, email, teams, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.PayloadDeliveryPlatform? Platform
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PayloadDeliveryPlatform?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>Predicted probability for a payload to phish a targeted user.</summary>
        public double? PredictedCompromiseRate
        {
            get { return BackingStore?.Get<double?>("predictedCompromiseRate"); }
            set { BackingStore?.Set("predictedCompromiseRate", value); }
        }
        /// <summary>Attack type of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, social, cloud, endpoint, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.SimulationAttackType? SimulationAttackType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SimulationAttackType?>("simulationAttackType"); }
            set { BackingStore?.Set("simulationAttackType", value); }
        }
        /// <summary>The source property</summary>
        public global::Microsoft.Graph.Beta.Models.SimulationContentSource? Source
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SimulationContentSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>Simulation content status. Supports $filter and $orderby. Possible values are: unknown, draft, ready, archive, delete, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.SimulationContentStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SimulationContentStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The social engineering technique used in the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, credentialHarvesting, attachmentMalware, driveByUrl, linkInAttachment, linkToMalwareFile, unknownFutureValue, oAuthConsentGrant, phishTraining. You must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: oAuthConsentGrant, phishTraining. For more information on the types of social engineering attack techniques, see simulations.</summary>
        public global::Microsoft.Graph.Beta.Models.SimulationAttackTechnique? Technique
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SimulationAttackTechnique?>("technique"); }
            set { BackingStore?.Set("technique", value); }
        }
        /// <summary>The theme of a payload. Possible values are: unknown, other, accountActivation, accountVerification, billing, cleanUpMail, controversial, documentReceived, expense, fax, financeReport, incomingMessages, invoice, itemReceived, loginAlert, mailReceived, password, payment, payroll, personalizedOffer, quarantine, remoteWork, reviewMessage, securityUpdate, serviceSuspended, signatureRequired, upgradeMailboxStorage, verifyMailbox, voicemail, advertisement, employeeEngagement, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.PayloadTheme? Theme
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PayloadTheme?>("theme"); }
            set { BackingStore?.Set("theme", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Payload"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Payload CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Payload();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "brand", n => { Brand = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PayloadBrand>(); } },
                { "complexity", n => { Complexity = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PayloadComplexity>(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.EmailIdentity>(global::Microsoft.Graph.Beta.Models.EmailIdentity.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "detail", n => { Detail = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PayloadDetail>(global::Microsoft.Graph.Beta.Models.PayloadDetail.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "industry", n => { Industry = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PayloadIndustry>(); } },
                { "isAutomated", n => { IsAutomated = n.GetBoolValue(); } },
                { "isControversial", n => { IsControversial = n.GetBoolValue(); } },
                { "isCurrentEvent", n => { IsCurrentEvent = n.GetBoolValue(); } },
                { "language", n => { Language = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.EmailIdentity>(global::Microsoft.Graph.Beta.Models.EmailIdentity.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "payloadTags", n => { PayloadTags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "platform", n => { Platform = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PayloadDeliveryPlatform>(); } },
                { "predictedCompromiseRate", n => { PredictedCompromiseRate = n.GetDoubleValue(); } },
                { "simulationAttackType", n => { SimulationAttackType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.SimulationAttackType>(); } },
                { "source", n => { Source = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.SimulationContentSource>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.SimulationContentStatus>(); } },
                { "technique", n => { Technique = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.SimulationAttackTechnique>(); } },
                { "theme", n => { Theme = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.PayloadTheme>(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PayloadBrand>("brand", Brand);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PayloadComplexity>("complexity", Complexity);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PayloadDetail>("detail", Detail);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PayloadIndustry>("industry", Industry);
            writer.WriteBoolValue("isAutomated", IsAutomated);
            writer.WriteBoolValue("isControversial", IsControversial);
            writer.WriteBoolValue("isCurrentEvent", IsCurrentEvent);
            writer.WriteStringValue("language", Language);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("payloadTags", PayloadTags);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PayloadDeliveryPlatform>("platform", Platform);
            writer.WriteDoubleValue("predictedCompromiseRate", PredictedCompromiseRate);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.SimulationAttackType>("simulationAttackType", SimulationAttackType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.SimulationContentSource>("source", Source);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.SimulationContentStatus>("status", Status);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.SimulationAttackTechnique>("technique", Technique);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.PayloadTheme>("theme", Theme);
        }
    }
}
#pragma warning restore CS0618
