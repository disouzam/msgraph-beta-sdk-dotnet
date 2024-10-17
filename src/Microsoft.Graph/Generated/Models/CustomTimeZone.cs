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
    public partial class CustomTimeZone : global::Microsoft.Graph.Beta.Models.TimeZoneBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The time offset of the time zone from Coordinated Universal Time (UTC). This value is in minutes. Time zones that are ahead of UTC have a positive offset; time zones that are behind UTC have a negative offset.</summary>
        public int? Bias
        {
            get { return BackingStore?.Get<int?>("bias"); }
            set { BackingStore?.Set("bias", value); }
        }
        /// <summary>Specifies when the time zone switches from standard time to daylight saving time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DaylightTimeZoneOffset? DaylightOffset
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DaylightTimeZoneOffset?>("daylightOffset"); }
            set { BackingStore?.Set("daylightOffset", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DaylightTimeZoneOffset DaylightOffset
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DaylightTimeZoneOffset>("daylightOffset"); }
            set { BackingStore?.Set("daylightOffset", value); }
        }
#endif
        /// <summary>Specifies when the time zone switches from daylight saving time to standard time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.StandardTimeZoneOffset? StandardOffset
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.StandardTimeZoneOffset?>("standardOffset"); }
            set { BackingStore?.Set("standardOffset", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.StandardTimeZoneOffset StandardOffset
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.StandardTimeZoneOffset>("standardOffset"); }
            set { BackingStore?.Set("standardOffset", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CustomTimeZone"/> and sets the default values.
        /// </summary>
        public CustomTimeZone() : base()
        {
            OdataType = "#microsoft.graph.customTimeZone";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CustomTimeZone"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CustomTimeZone CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CustomTimeZone();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "bias", n => { Bias = n.GetIntValue(); } },
                { "daylightOffset", n => { DaylightOffset = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DaylightTimeZoneOffset>(global::Microsoft.Graph.Beta.Models.DaylightTimeZoneOffset.CreateFromDiscriminatorValue); } },
                { "standardOffset", n => { StandardOffset = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.StandardTimeZoneOffset>(global::Microsoft.Graph.Beta.Models.StandardTimeZoneOffset.CreateFromDiscriminatorValue); } },
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
            writer.WriteIntValue("bias", Bias);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DaylightTimeZoneOffset>("daylightOffset", DaylightOffset);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.StandardTimeZoneOffset>("standardOffset", StandardOffset);
        }
    }
}
#pragma warning restore CS0618
