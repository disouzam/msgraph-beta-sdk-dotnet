// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class ScheduleItem : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date, time, and time zone that the corresponding event ends.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone? End
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone?>("end"); }
            set { BackingStore?.Set("end", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone End
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("end"); }
            set { BackingStore?.Set("end", value); }
        }
#endif
        /// <summary>The sensitivity of the corresponding event. True if the event is marked private, false otherwise. Optional.</summary>
        public bool? IsPrivate
        {
            get { return BackingStore?.Get<bool?>("isPrivate"); }
            set { BackingStore?.Set("isPrivate", value); }
        }
        /// <summary>The location where the corresponding event is held or attended from. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location
        {
            get { return BackingStore?.Get<string?>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#nullable restore
#else
        public string Location
        {
            get { return BackingStore?.Get<string>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The date, time, and time zone that the corresponding event starts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone? Start
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone?>("start"); }
            set { BackingStore?.Set("start", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DateTimeTimeZone Start
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("start"); }
            set { BackingStore?.Set("start", value); }
        }
#endif
        /// <summary>The availability status of the user or resource during the corresponding event. The possible values are: free, tentative, busy, oof, workingElsewhere, unknown.</summary>
        public global::Microsoft.Graph.Beta.Models.FreeBusyStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.FreeBusyStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The corresponding event&apos;s subject line. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject
        {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject
        {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ScheduleItem"/> and sets the default values.
        /// </summary>
        public ScheduleItem()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ScheduleItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.ScheduleItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ScheduleItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "end", n => { End = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>(global::Microsoft.Graph.Beta.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "isPrivate", n => { IsPrivate = n.GetBoolValue(); } },
                { "location", n => { Location = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "start", n => { Start = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>(global::Microsoft.Graph.Beta.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.FreeBusyStatus>(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("end", End);
            writer.WriteBoolValue("isPrivate", IsPrivate);
            writer.WriteStringValue("location", Location);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DateTimeTimeZone>("start", Start);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.FreeBusyStatus>("status", Status);
            writer.WriteStringValue("subject", Subject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
