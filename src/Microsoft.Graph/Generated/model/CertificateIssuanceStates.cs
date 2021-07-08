// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum CertificateIssuanceStates.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CertificateIssuanceStates
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Challenge Issued
        /// </summary>
        ChallengeIssued = 1,
	
        /// <summary>
        /// Challenge Issue Failed
        /// </summary>
        ChallengeIssueFailed = 2,
	
        /// <summary>
        /// Request Creation Failed
        /// </summary>
        RequestCreationFailed = 3,
	
        /// <summary>
        /// Request Submit Failed
        /// </summary>
        RequestSubmitFailed = 4,
	
        /// <summary>
        /// Challenge Validation Succeeded
        /// </summary>
        ChallengeValidationSucceeded = 5,
	
        /// <summary>
        /// Challenge Validation Failed
        /// </summary>
        ChallengeValidationFailed = 6,
	
        /// <summary>
        /// Issue Failed
        /// </summary>
        IssueFailed = 7,
	
        /// <summary>
        /// Issue Pending
        /// </summary>
        IssuePending = 8,
	
        /// <summary>
        /// Issued
        /// </summary>
        Issued = 9,
	
        /// <summary>
        /// Response Processing Failed
        /// </summary>
        ResponseProcessingFailed = 10,
	
        /// <summary>
        /// Response Pending
        /// </summary>
        ResponsePending = 11,
	
        /// <summary>
        /// Enrollment Succeeded
        /// </summary>
        EnrollmentSucceeded = 12,
	
        /// <summary>
        /// Enrollment Not Needed
        /// </summary>
        EnrollmentNotNeeded = 13,
	
        /// <summary>
        /// Revoked
        /// </summary>
        Revoked = 14,
	
        /// <summary>
        /// Removed From Collection
        /// </summary>
        RemovedFromCollection = 15,
	
        /// <summary>
        /// Renew Verified
        /// </summary>
        RenewVerified = 16,
	
        /// <summary>
        /// Install Failed
        /// </summary>
        InstallFailed = 17,
	
        /// <summary>
        /// Installed
        /// </summary>
        Installed = 18,
	
        /// <summary>
        /// Delete Failed
        /// </summary>
        DeleteFailed = 19,
	
        /// <summary>
        /// Deleted
        /// </summary>
        Deleted = 20,
	
        /// <summary>
        /// Renewal Requested
        /// </summary>
        RenewalRequested = 21,
	
        /// <summary>
        /// Requested
        /// </summary>
        Requested = 22,
	
    }
}
