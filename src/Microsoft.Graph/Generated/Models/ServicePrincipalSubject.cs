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
    public partial class ServicePrincipalSubject : global::Microsoft.Graph.Beta.Models.ConditionalAccessWhatIfSubject, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The servicePrincipalId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalId
        {
            get { return BackingStore?.Get<string?>("servicePrincipalId"); }
            set { BackingStore?.Set("servicePrincipalId", value); }
        }
#nullable restore
#else
        public string ServicePrincipalId
        {
            get { return BackingStore?.Get<string>("servicePrincipalId"); }
            set { BackingStore?.Set("servicePrincipalId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ServicePrincipalSubject"/> and sets the default values.
        /// </summary>
        public ServicePrincipalSubject() : base()
        {
            OdataType = "#microsoft.graph.servicePrincipalSubject";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ServicePrincipalSubject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ServicePrincipalSubject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ServicePrincipalSubject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "servicePrincipalId", n => { ServicePrincipalId = n.GetStringValue(); } },
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
            writer.WriteStringValue("servicePrincipalId", ServicePrincipalId);
        }
    }
}
#pragma warning restore CS0618
