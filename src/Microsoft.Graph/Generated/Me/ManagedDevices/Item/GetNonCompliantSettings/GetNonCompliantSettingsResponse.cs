// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Me.ManagedDevices.Item.GetNonCompliantSettings
{
    [Obsolete("This class is obsolete. Use GetNonCompliantSettingsGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class GetNonCompliantSettingsResponse : global::Microsoft.Graph.Beta.Me.ManagedDevices.Item.GetNonCompliantSettings.GetNonCompliantSettingsGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Me.ManagedDevices.Item.GetNonCompliantSettings.GetNonCompliantSettingsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Me.ManagedDevices.Item.GetNonCompliantSettings.GetNonCompliantSettingsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Me.ManagedDevices.Item.GetNonCompliantSettings.GetNonCompliantSettingsResponse();
        }
    }
}
#pragma warning restore CS0618
