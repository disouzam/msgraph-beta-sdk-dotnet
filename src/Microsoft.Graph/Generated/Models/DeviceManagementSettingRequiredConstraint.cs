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
    /// Constraint that enforces a particular required setting that is not null/undefined/empty string/not configured
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceManagementSettingRequiredConstraint : global::Microsoft.Graph.Beta.Models.DeviceManagementConstraint, IParsable
    {
        /// <summary>List of value which means not configured for the setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotConfiguredValue
        {
            get { return BackingStore?.Get<string?>("notConfiguredValue"); }
            set { BackingStore?.Set("notConfiguredValue", value); }
        }
#nullable restore
#else
        public string NotConfiguredValue
        {
            get { return BackingStore?.Get<string>("notConfiguredValue"); }
            set { BackingStore?.Set("notConfiguredValue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementSettingRequiredConstraint"/> and sets the default values.
        /// </summary>
        public DeviceManagementSettingRequiredConstraint() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementSettingRequiredConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagementSettingRequiredConstraint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagementSettingRequiredConstraint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagementSettingRequiredConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "notConfiguredValue", n => { NotConfiguredValue = n.GetStringValue(); } },
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
            writer.WriteStringValue("notConfiguredValue", NotConfiguredValue);
        }
    }
}
#pragma warning restore CS0618
