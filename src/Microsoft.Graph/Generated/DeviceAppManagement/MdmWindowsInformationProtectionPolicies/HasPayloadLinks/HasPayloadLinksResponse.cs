// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.DeviceAppManagement.MdmWindowsInformationProtectionPolicies.HasPayloadLinks
{
    [Obsolete("This class is obsolete. Use HasPayloadLinksPostResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class HasPayloadLinksResponse : global::Microsoft.Graph.Beta.DeviceAppManagement.MdmWindowsInformationProtectionPolicies.HasPayloadLinks.HasPayloadLinksPostResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.DeviceAppManagement.MdmWindowsInformationProtectionPolicies.HasPayloadLinks.HasPayloadLinksResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.DeviceAppManagement.MdmWindowsInformationProtectionPolicies.HasPayloadLinks.HasPayloadLinksResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.DeviceAppManagement.MdmWindowsInformationProtectionPolicies.HasPayloadLinks.HasPayloadLinksResponse();
        }
    }
}
#pragma warning restore CS0618
