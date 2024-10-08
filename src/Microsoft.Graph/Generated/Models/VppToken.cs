// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// You purchase multiple licenses for iOS apps through the Apple Volume Purchase Program for Business or Education. This involves setting up an Apple VPP account from the Apple website and uploading the Apple VPP Business or Education token to Intune. You can then synchronize your volume purchase information with Intune and track your volume-purchased app use. You can upload multiple Apple VPP Business or Education tokens.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class VppToken : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The apple Id associated with the given Apple Volume Purchase Program Token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppleId
        {
            get { return BackingStore?.Get<string?>("appleId"); }
            set { BackingStore?.Set("appleId", value); }
        }
#nullable restore
#else
        public string AppleId
        {
            get { return BackingStore?.Get<string>("appleId"); }
            set { BackingStore?.Set("appleId", value); }
        }
#endif
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
        public bool? AutomaticallyUpdateApps
        {
            get { return BackingStore?.Get<bool?>("automaticallyUpdateApps"); }
            set { BackingStore?.Set("automaticallyUpdateApps", value); }
        }
        /// <summary>Admin consent to allow claiming token management from external MDM.</summary>
        public bool? ClaimTokenManagementFromExternalMdm
        {
            get { return BackingStore?.Get<bool?>("claimTokenManagementFromExternalMdm"); }
            set { BackingStore?.Set("claimTokenManagementFromExternalMdm", value); }
        }
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryOrRegion
        {
            get { return BackingStore?.Get<string?>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#nullable restore
#else
        public string CountryOrRegion
        {
            get { return BackingStore?.Get<string>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#endif
        /// <summary>Consent granted for data sharing with the Apple Volume Purchase Program.</summary>
        public bool? DataSharingConsentGranted
        {
            get { return BackingStore?.Get<bool?>("dataSharingConsentGranted"); }
            set { BackingStore?.Set("dataSharingConsentGranted", value); }
        }
        /// <summary>An admin specified token friendly name.</summary>
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
        /// <summary>The expiration date time of the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? ExpirationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Last modification date time associated with the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastSyncDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>Possible sync statuses associated with an Apple Volume Purchase Program token.</summary>
        public global::Microsoft.Graph.Beta.Models.VppTokenSyncStatus? LastSyncStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VppTokenSyncStatus?>("lastSyncStatus"); }
            set { BackingStore?.Set("lastSyncStatus", value); }
        }
        /// <summary>Token location returned from Apple VPP.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationName
        {
            get { return BackingStore?.Get<string?>("locationName"); }
            set { BackingStore?.Set("locationName", value); }
        }
#nullable restore
#else
        public string LocationName
        {
            get { return BackingStore?.Get<string>("locationName"); }
            set { BackingStore?.Set("locationName", value); }
        }
#endif
        /// <summary>The organization associated with the Apple Volume Purchase Program Token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationName
        {
            get { return BackingStore?.Get<string?>("organizationName"); }
            set { BackingStore?.Set("organizationName", value); }
        }
#nullable restore
#else
        public string OrganizationName
        {
            get { return BackingStore?.Get<string>("organizationName"); }
            set { BackingStore?.Set("organizationName", value); }
        }
#endif
        /// <summary>Role Scope Tags IDs assigned to this entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>Possible states associated with an Apple Volume Purchase Program token.</summary>
        public global::Microsoft.Graph.Beta.Models.VppTokenState? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VppTokenState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token
        {
            get { return BackingStore?.Get<string?>("token"); }
            set { BackingStore?.Set("token", value); }
        }
#nullable restore
#else
        public string Token
        {
            get { return BackingStore?.Get<string>("token"); }
            set { BackingStore?.Set("token", value); }
        }
#endif
        /// <summary>The collection of statuses of the actions performed on the Apple Volume Purchase Program Token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.VppTokenActionResult>? TokenActionResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VppTokenActionResult>?>("tokenActionResults"); }
            set { BackingStore?.Set("tokenActionResults", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.VppTokenActionResult> TokenActionResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VppTokenActionResult>>("tokenActionResults"); }
            set { BackingStore?.Set("tokenActionResults", value); }
        }
#endif
        /// <summary>Possible types of an Apple Volume Purchase Program token.</summary>
        public global::Microsoft.Graph.Beta.Models.VppTokenAccountType? VppTokenAccountType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VppTokenAccountType?>("vppTokenAccountType"); }
            set { BackingStore?.Set("vppTokenAccountType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.VppToken"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.VppToken CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.VppToken();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appleId", n => { AppleId = n.GetStringValue(); } },
                { "automaticallyUpdateApps", n => { AutomaticallyUpdateApps = n.GetBoolValue(); } },
                { "claimTokenManagementFromExternalMdm", n => { ClaimTokenManagementFromExternalMdm = n.GetBoolValue(); } },
                { "countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                { "dataSharingConsentGranted", n => { DataSharingConsentGranted = n.GetBoolValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastSyncStatus", n => { LastSyncStatus = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.VppTokenSyncStatus>(); } },
                { "locationName", n => { LocationName = n.GetStringValue(); } },
                { "organizationName", n => { OrganizationName = n.GetStringValue(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.VppTokenState>(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "tokenActionResults", n => { TokenActionResults = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VppTokenActionResult>(global::Microsoft.Graph.Beta.Models.VppTokenActionResult.CreateFromDiscriminatorValue)?.AsList(); } },
                { "vppTokenAccountType", n => { VppTokenAccountType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.VppTokenAccountType>(); } },
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
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteBoolValue("automaticallyUpdateApps", AutomaticallyUpdateApps);
            writer.WriteBoolValue("claimTokenManagementFromExternalMdm", ClaimTokenManagementFromExternalMdm);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteBoolValue("dataSharingConsentGranted", DataSharingConsentGranted);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.VppTokenSyncStatus>("lastSyncStatus", LastSyncStatus);
            writer.WriteStringValue("locationName", LocationName);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.VppTokenState>("state", State);
            writer.WriteStringValue("token", Token);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VppTokenActionResult>("tokenActionResults", TokenActionResults);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.VppTokenAccountType>("vppTokenAccountType", VppTokenAccountType);
        }
    }
}
#pragma warning restore CS0618
