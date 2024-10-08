// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Activities;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Analytics;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.AssignSensitivityLabel;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkin;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkout;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Children;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Content;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.ContentStream;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Copy;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.CreateLink;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.CreateUploadSession;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.CreatedByUser;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Delta;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.DeltaWithToken;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.DiscardCheckout;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.ExtractSensitivityLabels;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Follow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Invite;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.LastModifiedByUser;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.ListItem;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.PermanentDelete;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Permissions;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Preview;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Restore;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.RetentionLabel;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.SearchWithQ;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Subscriptions;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Thumbnails;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Unfollow;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.ValidatePermission;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Versions;
using Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item
{
    /// <summary>
    /// Provides operations to manage the items property of the microsoft.graph.drive entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DriveItemItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the activities property of the microsoft.graph.driveItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Activities.ActivitiesRequestBuilder Activities
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Activities.ActivitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the analytics property of the microsoft.graph.driveItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Analytics.AnalyticsRequestBuilder Analytics
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Analytics.AnalyticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the assignSensitivityLabel method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.AssignSensitivityLabel.AssignSensitivityLabelRequestBuilder AssignSensitivityLabel
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.AssignSensitivityLabel.AssignSensitivityLabelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkin method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkin.CheckinRequestBuilder Checkin
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkin.CheckinRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkout method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkout.CheckoutRequestBuilder Checkout
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Checkout.CheckoutRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the children property of the microsoft.graph.driveItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Children.ChildrenRequestBuilder Children
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Children.ChildrenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the drive entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Content.ContentRequestBuilder Content
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Content.ContentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the drive entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.ContentStream.ContentStreamRequestBuilder ContentStream
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.ContentStream.ContentStreamRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the copy method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Copy.CopyRequestBuilder Copy
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Copy.CopyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdByUser property of the microsoft.graph.baseItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.CreatedByUser.CreatedByUserRequestBuilder CreatedByUser
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.CreatedByUser.CreatedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createLink method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.CreateLink.CreateLinkRequestBuilder CreateLink
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.CreateLink.CreateLinkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createUploadSession method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.CreateUploadSession.CreateUploadSessionRequestBuilder CreateUploadSession
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.CreateUploadSession.CreateUploadSessionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the delta method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Delta.DeltaRequestBuilder Delta
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Delta.DeltaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the discardCheckout method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DiscardCheckout.DiscardCheckoutRequestBuilder DiscardCheckout
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DiscardCheckout.DiscardCheckoutRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the extractSensitivityLabels method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.ExtractSensitivityLabels.ExtractSensitivityLabelsRequestBuilder ExtractSensitivityLabels
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.ExtractSensitivityLabels.ExtractSensitivityLabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the follow method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Follow.FollowRequestBuilder Follow
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Follow.FollowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the invite method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Invite.InviteRequestBuilder Invite
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Invite.InviteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedByUser property of the microsoft.graph.baseItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder LastModifiedByUser
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.LastModifiedByUser.LastModifiedByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the listItem property of the microsoft.graph.driveItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.ListItem.ListItemRequestBuilder ListItem
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.ListItem.ListItemRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the permanentDelete method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.PermanentDelete.PermanentDeleteRequestBuilder PermanentDelete
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.PermanentDelete.PermanentDeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissions property of the microsoft.graph.driveItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Permissions.PermissionsRequestBuilder Permissions
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Permissions.PermissionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the preview method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Preview.PreviewRequestBuilder Preview
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Preview.PreviewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Restore.RestoreRequestBuilder Restore
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Restore.RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the retentionLabel property of the microsoft.graph.driveItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.RetentionLabel.RetentionLabelRequestBuilder RetentionLabel
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.RetentionLabel.RetentionLabelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the subscriptions property of the microsoft.graph.driveItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Subscriptions.SubscriptionsRequestBuilder Subscriptions
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Subscriptions.SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the thumbnails property of the microsoft.graph.driveItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Thumbnails.ThumbnailsRequestBuilder Thumbnails
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Thumbnails.ThumbnailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unfollow method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Unfollow.UnfollowRequestBuilder Unfollow
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Unfollow.UnfollowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the validatePermission method.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.ValidatePermission.ValidatePermissionRequestBuilder ValidatePermission
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.ValidatePermission.ValidatePermissionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the versions property of the microsoft.graph.driveItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Versions.VersionsRequestBuilder Versions
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Versions.VersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the workbook property of the microsoft.graph.driveItem entity.</summary>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder Workbook
        {
            get => new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.WorkbookRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DriveItemItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DriveItemItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property items for drives
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the delta method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DeltaWithToken.DeltaWithTokenRequestBuilder"/></returns>
        /// <param name="token">Usage: token=&apos;{token}&apos;</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DeltaWithToken.DeltaWithTokenRequestBuilder DeltaWithToken(string token)
        {
            if(string.IsNullOrEmpty(token)) throw new ArgumentNullException(nameof(token));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DeltaWithToken.DeltaWithTokenRequestBuilder(PathParameters, RequestAdapter, token);
        }
        /// <summary>
        /// Provides operations to call the getActivitiesByInterval method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder"/></returns>
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="interval">Usage: interval=&apos;{interval}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval(string endDateTime, string interval, string startDateTime)
        {
            if(string.IsNullOrEmpty(endDateTime)) throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(interval)) throw new ArgumentNullException(nameof(interval));
            if(string.IsNullOrEmpty(startDateTime)) throw new ArgumentNullException(nameof(startDateTime));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(PathParameters, RequestAdapter, endDateTime, interval, startDateTime);
        }
        /// <summary>
        /// All items contained in the drive. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DriveItem"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.DriveItem?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder.DriveItemItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.DriveItem> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder.DriveItemItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.DriveItem>(requestInfo, global::Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property items in drives
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DriveItem"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Beta.Models.DriveItem?> PatchAsync(global::Microsoft.Graph.Beta.Models.DriveItem body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Beta.Models.DriveItem> PatchAsync(global::Microsoft.Graph.Beta.Models.DriveItem body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Beta.Models.DriveItem>(requestInfo, global::Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the search method.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.SearchWithQ.SearchWithQRequestBuilder"/></returns>
        /// <param name="q">Usage: q=&apos;{q}&apos;</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.SearchWithQ.SearchWithQRequestBuilder SearchWithQ(string q)
        {
            if(string.IsNullOrEmpty(q)) throw new ArgumentNullException(nameof(q));
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.SearchWithQ.SearchWithQRequestBuilder(PathParameters, RequestAdapter, q);
        }
        /// <summary>
        /// Delete navigation property items for drives
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// All items contained in the drive. Read-only. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder.DriveItemItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder.DriveItemItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property items in drives
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.DriveItem body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Beta.Models.DriveItem body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DriveItemItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// All items contained in the drive. Read-only. Nullable.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DriveItemItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DriveItemItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Beta.Drives.Item.Items.Item.DriveItemItemRequestBuilder.DriveItemItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class DriveItemItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
