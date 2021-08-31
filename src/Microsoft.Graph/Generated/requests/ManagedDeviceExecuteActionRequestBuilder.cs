// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ManagedDeviceExecuteActionRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceExecuteActionRequestBuilder : BaseActionMethodRequestBuilder<IManagedDeviceExecuteActionRequest>, IManagedDeviceExecuteActionRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ManagedDeviceExecuteActionRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="actionName">A actionName parameter for the OData method call.</param>
        /// <param name="keepEnrollmentData">A keepEnrollmentData parameter for the OData method call.</param>
        /// <param name="keepUserData">A keepUserData parameter for the OData method call.</param>
        /// <param name="deviceIds">A deviceIds parameter for the OData method call.</param>
        /// <param name="notificationTitle">A notificationTitle parameter for the OData method call.</param>
        /// <param name="notificationBody">A notificationBody parameter for the OData method call.</param>
        /// <param name="deviceName">A deviceName parameter for the OData method call.</param>
        /// <param name="carrierUrl">A carrierUrl parameter for the OData method call.</param>
        /// <param name="deprovisionReason">A deprovisionReason parameter for the OData method call.</param>
        /// <param name="organizationalUnitPath">A organizationalUnitPath parameter for the OData method call.</param>
        public ManagedDeviceExecuteActionRequestBuilder(
            string requestUrl,
            IBaseClient client,
            ManagedDeviceRemoteAction actionName,
            bool? keepEnrollmentData,
            bool? keepUserData,
            IEnumerable<string> deviceIds,
            string notificationTitle,
            string notificationBody,
            string deviceName,
            string carrierUrl,
            string deprovisionReason,
            string organizationalUnitPath)
            : base(requestUrl, client)
        {
            this.SetParameter("actionName", actionName, false);
            this.SetParameter("keepEnrollmentData", keepEnrollmentData, true);
            this.SetParameter("keepUserData", keepUserData, true);
            this.SetParameter("deviceIds", deviceIds, true);
            this.SetParameter("notificationTitle", notificationTitle, true);
            this.SetParameter("notificationBody", notificationBody, true);
            this.SetParameter("deviceName", deviceName, true);
            this.SetParameter("carrierUrl", carrierUrl, true);
            this.SetParameter("deprovisionReason", deprovisionReason, true);
            this.SetParameter("organizationalUnitPath", organizationalUnitPath, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IManagedDeviceExecuteActionRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ManagedDeviceExecuteActionRequest(functionUrl, this.Client, options);

            if (this.HasParameter("actionName"))
            {
                request.RequestBody.ActionName = this.GetParameter<ManagedDeviceRemoteAction>("actionName");
            }

            if (this.HasParameter("keepEnrollmentData"))
            {
                request.RequestBody.KeepEnrollmentData = this.GetParameter<bool?>("keepEnrollmentData");
            }

            if (this.HasParameter("keepUserData"))
            {
                request.RequestBody.KeepUserData = this.GetParameter<bool?>("keepUserData");
            }

            if (this.HasParameter("deviceIds"))
            {
                request.RequestBody.DeviceIds = this.GetParameter<IEnumerable<string>>("deviceIds");
            }

            if (this.HasParameter("notificationTitle"))
            {
                request.RequestBody.NotificationTitle = this.GetParameter<string>("notificationTitle");
            }

            if (this.HasParameter("notificationBody"))
            {
                request.RequestBody.NotificationBody = this.GetParameter<string>("notificationBody");
            }

            if (this.HasParameter("deviceName"))
            {
                request.RequestBody.DeviceName = this.GetParameter<string>("deviceName");
            }

            if (this.HasParameter("carrierUrl"))
            {
                request.RequestBody.CarrierUrl = this.GetParameter<string>("carrierUrl");
            }

            if (this.HasParameter("deprovisionReason"))
            {
                request.RequestBody.DeprovisionReason = this.GetParameter<string>("deprovisionReason");
            }

            if (this.HasParameter("organizationalUnitPath"))
            {
                request.RequestBody.OrganizationalUnitPath = this.GetParameter<string>("organizationalUnitPath");
            }

            return request;
        }
    }
}
