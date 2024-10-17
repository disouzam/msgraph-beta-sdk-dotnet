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
    public partial class SubjectRightsRequestEnumeratedMailboxLocation : global::Microsoft.Graph.Beta.Models.SubjectRightsRequestMailboxLocation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Collection of mailboxes that should be included in the search. Includes the UPN of each mailbox, for example, Monica.Thompson@contoso.com. Going forward, use the userPrincipalNames property. If you specify either upns or userPrincipalNames, the same values are populated automatically to the other property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Upns
        {
            get { return BackingStore?.Get<List<string>?>("upns"); }
            set { BackingStore?.Set("upns", value); }
        }
#nullable restore
#else
        public List<string> Upns
        {
            get { return BackingStore?.Get<List<string>>("upns"); }
            set { BackingStore?.Set("upns", value); }
        }
#endif
        /// <summary>Collection of mailboxes that should be included in the search. Includes the user principal name (UPN) of each mailbox, for example, Monica.Thompson@contoso.com.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UserPrincipalNames
        {
            get { return BackingStore?.Get<List<string>?>("userPrincipalNames"); }
            set { BackingStore?.Set("userPrincipalNames", value); }
        }
#nullable restore
#else
        public List<string> UserPrincipalNames
        {
            get { return BackingStore?.Get<List<string>>("userPrincipalNames"); }
            set { BackingStore?.Set("userPrincipalNames", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.SubjectRightsRequestEnumeratedMailboxLocation"/> and sets the default values.
        /// </summary>
        public SubjectRightsRequestEnumeratedMailboxLocation() : base()
        {
            OdataType = "#microsoft.graph.subjectRightsRequestEnumeratedMailboxLocation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SubjectRightsRequestEnumeratedMailboxLocation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.SubjectRightsRequestEnumeratedMailboxLocation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.SubjectRightsRequestEnumeratedMailboxLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "upns", n => { Upns = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "userPrincipalNames", n => { UserPrincipalNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("upns", Upns);
            writer.WriteCollectionOfPrimitiveValues<string>("userPrincipalNames", UserPrincipalNames);
        }
    }
}
#pragma warning restore CS0618
