// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateClassificationResults {
    [Obsolete("This class is obsolete. Use EvaluateClassificationResultsPostResponse instead.")]
    public class EvaluateClassificationResultsResponse : EvaluateClassificationResultsPostResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EvaluateClassificationResultsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EvaluateClassificationResultsResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateClassificationResultsResponse();
        }
    }
}
