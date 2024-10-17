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
    public partial class EnumeratedDeviceRegistrationMembership : global::Microsoft.Graph.Beta.Models.DeviceRegistrationMembership, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of groups that this policy applies to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Groups
        {
            get { return BackingStore?.Get<List<string>?>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#nullable restore
#else
        public List<string> Groups
        {
            get { return BackingStore?.Get<List<string>>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#endif
        /// <summary>List of users that this policy applies to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Users
        {
            get { return BackingStore?.Get<List<string>?>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#nullable restore
#else
        public List<string> Users
        {
            get { return BackingStore?.Get<List<string>>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.EnumeratedDeviceRegistrationMembership"/> and sets the default values.
        /// </summary>
        public EnumeratedDeviceRegistrationMembership() : base()
        {
            OdataType = "#microsoft.graph.enumeratedDeviceRegistrationMembership";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.EnumeratedDeviceRegistrationMembership"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.EnumeratedDeviceRegistrationMembership CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.EnumeratedDeviceRegistrationMembership();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "groups", n => { Groups = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "users", n => { Users = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("groups", Groups);
            writer.WriteCollectionOfPrimitiveValues<string>("users", Users);
        }
    }
}
#pragma warning restore CS0618
