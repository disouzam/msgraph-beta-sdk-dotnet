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
    public partial class VoiceAuthenticationMethodConfiguration : global::Microsoft.Graph.Beta.Models.AuthenticationMethodConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of groups that are enabled to use the authentication method. Expanded by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.VoiceAuthenticationMethodTarget>? IncludeTargets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VoiceAuthenticationMethodTarget>?>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.VoiceAuthenticationMethodTarget> IncludeTargets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.VoiceAuthenticationMethodTarget>>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#endif
        /// <summary>true if users can register office phones, otherwise, false.</summary>
        public bool? IsOfficePhoneAllowed
        {
            get { return BackingStore?.Get<bool?>("isOfficePhoneAllowed"); }
            set { BackingStore?.Set("isOfficePhoneAllowed", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.VoiceAuthenticationMethodConfiguration"/> and sets the default values.
        /// </summary>
        public VoiceAuthenticationMethodConfiguration() : base()
        {
            OdataType = "#microsoft.graph.voiceAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.VoiceAuthenticationMethodConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.VoiceAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.VoiceAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VoiceAuthenticationMethodTarget>(global::Microsoft.Graph.Beta.Models.VoiceAuthenticationMethodTarget.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isOfficePhoneAllowed", n => { IsOfficePhoneAllowed = n.GetBoolValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.VoiceAuthenticationMethodTarget>("includeTargets", IncludeTargets);
            writer.WriteBoolValue("isOfficePhoneAllowed", IsOfficePhoneAllowed);
        }
    }
}
#pragma warning restore CS0618
