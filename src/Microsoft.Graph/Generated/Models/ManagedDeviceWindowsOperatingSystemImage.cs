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
    /// This entity defines different Windows Operating System products, like &apos;Windows 11 22H1&apos;, &apos;Windows 11 22H2&apos; etc., along with their available configurations.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManagedDeviceWindowsOperatingSystemImage : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Indicates the available Quality/Security updates for a specific Windows product version (example: Windows 11 22H1), for upto last 3 Patch Tuesdays . This value in the API response would be updated 2-3 days after every Patch Tuesday. Supports: $filter, $select, $top, $skip. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemUpdate>? AvailableUpdates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemUpdate>?>("availableUpdates"); }
            set { BackingStore?.Set("availableUpdates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemUpdate> AvailableUpdates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemUpdate>>("availableUpdates"); }
            set { BackingStore?.Set("availableUpdates", value); }
        }
#endif
        /// <summary>Indicates the list of architectures supported by the image. E.g. [&apos;ARM64&apos;,&apos;X86&apos;]. Supports: $filter, $select, $top, $skip. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceArchitecture?>? SupportedArchitectures
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceArchitecture?>?>("supportedArchitectures"); }
            set { BackingStore?.Set("supportedArchitectures", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceArchitecture?> SupportedArchitectures
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceArchitecture?>>("supportedArchitectures"); }
            set { BackingStore?.Set("supportedArchitectures", value); }
        }
#endif
        /// <summary>Indicates the list of editions supported by the image along with their support dates. Supports: $filter, $select, $top, $skip. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemEdition>? SupportedEditions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemEdition>?>("supportedEditions"); }
            set { BackingStore?.Set("supportedEditions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemEdition> SupportedEditions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemEdition>>("supportedEditions"); }
            set { BackingStore?.Set("supportedEditions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemImage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemImage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemImage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "availableUpdates", n => { AvailableUpdates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemUpdate>(global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemUpdate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "supportedArchitectures", n => { SupportedArchitectures = n.GetCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceArchitecture>()?.AsList(); } },
                { "supportedEditions", n => { SupportedEditions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemEdition>(global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemEdition.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemUpdate>("availableUpdates", AvailableUpdates);
            writer.WriteCollectionOfEnumValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceArchitecture>("supportedArchitectures", SupportedArchitectures);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ManagedDeviceWindowsOperatingSystemEdition>("supportedEditions", SupportedEditions);
        }
    }
}
#pragma warning restore CS0618
