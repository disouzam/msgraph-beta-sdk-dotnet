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
    /// Represents a customer of the business.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class BookingCustomer : global::Microsoft.Graph.Beta.Models.BookingPerson, IParsable
    {
        /// <summary>Addresses associated with the customer, including home, business and other addresses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.PhysicalAddress>? Addresses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PhysicalAddress>?>("addresses"); }
            set { BackingStore?.Set("addresses", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.PhysicalAddress> Addresses
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.PhysicalAddress>>("addresses"); }
            set { BackingStore?.Set("addresses", value); }
        }
#endif
        /// <summary>The date, time, and timezone when the customer was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date, time, and timezone when the customer was last updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>Phone numbers associated with the customer, including home, business and mobile numbers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Phone>? Phones
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Phone>?>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Phone> Phones
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Phone>>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.BookingCustomer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.BookingCustomer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.BookingCustomer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addresses", n => { Addresses = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PhysicalAddress>(global::Microsoft.Graph.Beta.Models.PhysicalAddress.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "phones", n => { Phones = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Phone>(global::Microsoft.Graph.Beta.Models.Phone.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.PhysicalAddress>("addresses", Addresses);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Phone>("phones", Phones);
        }
    }
}
#pragma warning restore CS0618
