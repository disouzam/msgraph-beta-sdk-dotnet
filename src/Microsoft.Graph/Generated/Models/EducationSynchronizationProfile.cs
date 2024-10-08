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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class EducationSynchronizationProfile : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The dataProvider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.EducationSynchronizationDataProvider? DataProvider
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EducationSynchronizationDataProvider?>("dataProvider"); }
            set { BackingStore?.Set("dataProvider", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.EducationSynchronizationDataProvider DataProvider
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EducationSynchronizationDataProvider>("dataProvider"); }
            set { BackingStore?.Set("dataProvider", value); }
        }
#endif
        /// <summary>Name of the configuration profile for syncing identities.</summary>
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
        /// <summary>All errors associated with this synchronization profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.EducationSynchronizationError>? Errors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.EducationSynchronizationError>?>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.EducationSynchronizationError> Errors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.EducationSynchronizationError>>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#endif
        /// <summary>The date the profile should be considered expired and cease syncing. Provide the date in YYYY-MM-DD format, following ISO 8601. Maximum value is 18 months from profile creation.  (optional)</summary>
        public Date? ExpirationDate
        {
            get { return BackingStore?.Get<Date?>("expirationDate"); }
            set { BackingStore?.Set("expirationDate", value); }
        }
        /// <summary>Determines if School Data Sync should automatically replace unsupported special characters while syncing from source.</summary>
        public bool? HandleSpecialCharacterConstraint
        {
            get { return BackingStore?.Get<bool?>("handleSpecialCharacterConstraint"); }
            set { BackingStore?.Set("handleSpecialCharacterConstraint", value); }
        }
        /// <summary>The identitySynchronizationConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.EducationIdentitySynchronizationConfiguration? IdentitySynchronizationConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EducationIdentitySynchronizationConfiguration?>("identitySynchronizationConfiguration"); }
            set { BackingStore?.Set("identitySynchronizationConfiguration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.EducationIdentitySynchronizationConfiguration IdentitySynchronizationConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EducationIdentitySynchronizationConfiguration>("identitySynchronizationConfiguration"); }
            set { BackingStore?.Set("identitySynchronizationConfiguration", value); }
        }
#endif
        /// <summary>License setup configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.EducationSynchronizationLicenseAssignment>? LicensesToAssign
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.EducationSynchronizationLicenseAssignment>?>("licensesToAssign"); }
            set { BackingStore?.Set("licensesToAssign", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.EducationSynchronizationLicenseAssignment> LicensesToAssign
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.EducationSynchronizationLicenseAssignment>>("licensesToAssign"); }
            set { BackingStore?.Set("licensesToAssign", value); }
        }
#endif
        /// <summary>The synchronization status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfileStatus? ProfileStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfileStatus?>("profileStatus"); }
            set { BackingStore?.Set("profileStatus", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfileStatus ProfileStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfileStatus>("profileStatus"); }
            set { BackingStore?.Set("profileStatus", value); }
        }
#endif
        /// <summary>The state of the profile. Possible values are: provisioning, provisioned, provisioningFailed, deleting, deletionFailed.</summary>
        public global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfileState? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfileState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "dataProvider", n => { DataProvider = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.EducationSynchronizationDataProvider>(global::Microsoft.Graph.Beta.Models.EducationSynchronizationDataProvider.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "errors", n => { Errors = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.EducationSynchronizationError>(global::Microsoft.Graph.Beta.Models.EducationSynchronizationError.CreateFromDiscriminatorValue)?.AsList(); } },
                { "expirationDate", n => { ExpirationDate = n.GetDateValue(); } },
                { "handleSpecialCharacterConstraint", n => { HandleSpecialCharacterConstraint = n.GetBoolValue(); } },
                { "identitySynchronizationConfiguration", n => { IdentitySynchronizationConfiguration = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.EducationIdentitySynchronizationConfiguration>(global::Microsoft.Graph.Beta.Models.EducationIdentitySynchronizationConfiguration.CreateFromDiscriminatorValue); } },
                { "licensesToAssign", n => { LicensesToAssign = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.EducationSynchronizationLicenseAssignment>(global::Microsoft.Graph.Beta.Models.EducationSynchronizationLicenseAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "profileStatus", n => { ProfileStatus = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfileStatus>(global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfileStatus.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfileState>(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.EducationSynchronizationDataProvider>("dataProvider", DataProvider);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.EducationSynchronizationError>("errors", Errors);
            writer.WriteDateValue("expirationDate", ExpirationDate);
            writer.WriteBoolValue("handleSpecialCharacterConstraint", HandleSpecialCharacterConstraint);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.EducationIdentitySynchronizationConfiguration>("identitySynchronizationConfiguration", IdentitySynchronizationConfiguration);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.EducationSynchronizationLicenseAssignment>("licensesToAssign", LicensesToAssign);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfileStatus>("profileStatus", ProfileStatus);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.EducationSynchronizationProfileState>("state", State);
        }
    }
}
#pragma warning restore CS0618
