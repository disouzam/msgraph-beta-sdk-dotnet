// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Contracts.Item.GetMemberObjects
{
    [Obsolete("This class is obsolete. Use GetMemberObjectsPostResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class GetMemberObjectsResponse : global::Microsoft.Graph.Beta.Contracts.Item.GetMemberObjects.GetMemberObjectsPostResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Contracts.Item.GetMemberObjects.GetMemberObjectsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Contracts.Item.GetMemberObjects.GetMemberObjectsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Contracts.Item.GetMemberObjects.GetMemberObjectsResponse();
        }
    }
}
#pragma warning restore CS0618
