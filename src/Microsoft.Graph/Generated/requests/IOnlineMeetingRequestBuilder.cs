// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IOnlineMeetingRequestBuilder.
    /// </summary>
    public partial interface IOnlineMeetingRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IOnlineMeetingRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IOnlineMeetingRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for MeetingAttendanceReport.
        /// </summary>
        /// <returns>The <see cref="IMeetingAttendanceReportRequestBuilder"/>.</returns>
        IMeetingAttendanceReportRequestBuilder MeetingAttendanceReport { get; }

        /// <summary>
        /// Gets the request builder for Registration.
        /// </summary>
        /// <returns>The <see cref="IMeetingRegistrationRequestBuilder"/>.</returns>
        IMeetingRegistrationRequestBuilder Registration { get; }
    
        /// <summary>
        /// Gets the request builder for AlternativeRecording.
        /// </summary>
        /// <returns>The <see cref="IOnlineMeetingAlternativeRecordingRequestBuilder"/>.</returns>
        IOnlineMeetingAlternativeRecordingRequestBuilder AlternativeRecording { get; }

        /// <summary>
        /// Gets the request builder for AttendeeReport.
        /// </summary>
        /// <returns>The <see cref="IOnlineMeetingAttendeeReportRequestBuilder"/>.</returns>
        IOnlineMeetingAttendeeReportRequestBuilder AttendeeReport { get; }

        /// <summary>
        /// Gets the request builder for Recording.
        /// </summary>
        /// <returns>The <see cref="IOnlineMeetingRecordingRequestBuilder"/>.</returns>
        IOnlineMeetingRecordingRequestBuilder Recording { get; }
    
        
    
    }
}
