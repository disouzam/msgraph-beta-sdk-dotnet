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
    public partial class CalendarPermission : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CalendarRoleType?>? AllowedRoles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CalendarRoleType?>?>("allowedRoles"); }
            set { BackingStore?.Set("allowedRoles", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CalendarRoleType?> AllowedRoles
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CalendarRoleType?>>("allowedRoles"); }
            set { BackingStore?.Set("allowedRoles", value); }
        }
#endif
        /// <summary>Represents a share recipient or delegate who has access to the calendar. For the &apos;My Organization&apos; share recipient, the address property is null. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.EmailAddress? EmailAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EmailAddress?>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.EmailAddress EmailAddress
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EmailAddress>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#endif
        /// <summary>True if the user in context (share recipient or delegate) is inside the same organization as the calendar owner.</summary>
        public bool? IsInsideOrganization
        {
            get { return BackingStore?.Get<bool?>("isInsideOrganization"); }
            set { BackingStore?.Set("isInsideOrganization", value); }
        }
        /// <summary>True if the user can be removed from the list of recipients or delegates for the specified calendar, false otherwise. The &apos;My organization&apos; user determines the permissions other people within your organization have to the given calendar. You can&apos;t remove &apos;My organization&apos; as a recipient to a calendar.</summary>
        public bool? IsRemovable
        {
            get { return BackingStore?.Get<bool?>("isRemovable"); }
            set { BackingStore?.Set("isRemovable", value); }
        }
        /// <summary>Current permission level of the calendar share recipient or delegate.</summary>
        public global::Microsoft.Graph.Beta.Models.CalendarRoleType? Role
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CalendarRoleType?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CalendarPermission"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CalendarPermission CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CalendarPermission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowedRoles", n => { AllowedRoles = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.CalendarRoleType>()?.AsList(); } },
                { "emailAddress", n => { EmailAddress = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.EmailAddress>(global::Microsoft.Graph.Beta.Models.EmailAddress.CreateFromDiscriminatorValue); } },
                { "isInsideOrganization", n => { IsInsideOrganization = n.GetBoolValue(); } },
                { "isRemovable", n => { IsRemovable = n.GetBoolValue(); } },
                { "role", n => { Role = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CalendarRoleType>(); } },
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
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.CalendarRoleType>("allowedRoles", AllowedRoles);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.EmailAddress>("emailAddress", EmailAddress);
            writer.WriteBoolValue("isInsideOrganization", IsInsideOrganization);
            writer.WriteBoolValue("isRemovable", IsRemovable);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CalendarRoleType>("role", Role);
        }
    }
}
#pragma warning restore CS0618
