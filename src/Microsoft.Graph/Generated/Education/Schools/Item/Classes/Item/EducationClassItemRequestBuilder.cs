// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Education.Schools.Item.Classes.Item.Ref;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Beta.Education.Schools.Item.Classes.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \education\schools\{educationSchool-id}\classes\{educationClass-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EducationClassItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the collection of educationRoot entities.</summary>
        public global::Microsoft.Graph.Beta.Education.Schools.Item.Classes.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Beta.Education.Schools.Item.Classes.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Education.Schools.Item.Classes.Item.EducationClassItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EducationClassItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/education/schools/{educationSchool%2Did}/classes/{educationClass%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Education.Schools.Item.Classes.Item.EducationClassItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EducationClassItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/education/schools/{educationSchool%2Did}/classes/{educationClass%2Did}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
