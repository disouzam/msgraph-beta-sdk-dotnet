// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.DeviceHealthScripts.Item.UpdateGlobalScript {
    [Obsolete("This class is obsolete. Use UpdateGlobalScriptPostResponse instead.")]
    public class UpdateGlobalScriptResponse : UpdateGlobalScriptPostResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UpdateGlobalScriptResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UpdateGlobalScriptResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateGlobalScriptResponse();
        }
    }
}
