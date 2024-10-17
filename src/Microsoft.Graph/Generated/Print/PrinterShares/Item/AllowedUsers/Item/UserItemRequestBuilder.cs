// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item.MailboxSettings;
using Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item.Ref;
using Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item.ServiceProvisioningErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \print\printerShares\{printerShare-id}\allowedUsers\{user-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The mailboxSettings property</summary>
        public global::Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item.MailboxSettings.MailboxSettingsRequestBuilder MailboxSettings
        {
            get => new global::Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item.MailboxSettings.MailboxSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of print entities.</summary>
        public global::Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The serviceProvisioningErrors property</summary>
        public global::Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item.ServiceProvisioningErrors.ServiceProvisioningErrorsRequestBuilder ServiceProvisioningErrors
        {
            get => new global::Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item.ServiceProvisioningErrors.ServiceProvisioningErrorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item.UserItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/printerShares/{printerShare%2Did}/allowedUsers/{user%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Print.PrinterShares.Item.AllowedUsers.Item.UserItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/printerShares/{printerShare%2Did}/allowedUsers/{user%2Did}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
