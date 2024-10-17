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
    public partial class ExternallyAccessibleAwsStorageBucketFinding : global::Microsoft.Graph.Beta.Models.Finding, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessibility property</summary>
        public global::Microsoft.Graph.Beta.Models.AwsAccessType? Accessibility
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AwsAccessType?>("accessibility"); }
            set { BackingStore?.Set("accessibility", value); }
        }
        /// <summary>The accountsWithAccess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AccountsWithAccess? AccountsWithAccess
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccountsWithAccess?>("accountsWithAccess"); }
            set { BackingStore?.Set("accountsWithAccess", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AccountsWithAccess AccountsWithAccess
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccountsWithAccess>("accountsWithAccess"); }
            set { BackingStore?.Set("accountsWithAccess", value); }
        }
#endif
        /// <summary>The storageBucket property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource? StorageBucket
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource?>("storageBucket"); }
            set { BackingStore?.Set("storageBucket", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource StorageBucket
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>("storageBucket"); }
            set { BackingStore?.Set("storageBucket", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ExternallyAccessibleAwsStorageBucketFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ExternallyAccessibleAwsStorageBucketFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ExternallyAccessibleAwsStorageBucketFinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessibility", n => { Accessibility = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AwsAccessType>(); } },
                { "accountsWithAccess", n => { AccountsWithAccess = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AccountsWithAccess>(global::Microsoft.Graph.Beta.Models.AccountsWithAccess.CreateFromDiscriminatorValue); } },
                { "storageBucket", n => { StorageBucket = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>(global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AwsAccessType>("accessibility", Accessibility);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AccountsWithAccess>("accountsWithAccess", AccountsWithAccess);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AuthorizationSystemResource>("storageBucket", StorageBucket);
        }
    }
}
#pragma warning restore CS0618
