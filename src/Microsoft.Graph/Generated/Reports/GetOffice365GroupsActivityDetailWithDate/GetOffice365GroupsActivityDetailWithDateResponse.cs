// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Reports.GetOffice365GroupsActivityDetailWithDate {
    [Obsolete("This class is obsolete. Use GetOffice365GroupsActivityDetailWithDateGetResponse instead.")]
    public class GetOffice365GroupsActivityDetailWithDateResponse : GetOffice365GroupsActivityDetailWithDateGetResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GetOffice365GroupsActivityDetailWithDateResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GetOffice365GroupsActivityDetailWithDateResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetOffice365GroupsActivityDetailWithDateResponse();
        }
    }
}
