// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.NetworkAccess.Reports.MicrosoftGraphNetworkaccessGetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTime {
    [Obsolete("This class is obsolete. Use GetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeGetResponse instead.")]
    public class GetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeResponse : GetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeGetResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetDiscoveredApplicationSegmentReportWithStartDateTimeWithEndDateTimeResponse();
        }
    }
}
