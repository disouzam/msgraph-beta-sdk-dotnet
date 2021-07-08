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
    /// The enum AppliedConditionalAccessPolicyResult.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AppliedConditionalAccessPolicyResult
    {
    
        /// <summary>
        /// Success
        /// </summary>
        Success = 0,
	
        /// <summary>
        /// Failure
        /// </summary>
        Failure = 1,
	
        /// <summary>
        /// Not Applied
        /// </summary>
        NotApplied = 2,
	
        /// <summary>
        /// Not Enabled
        /// </summary>
        NotEnabled = 3,
	
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
        /// <summary>
        /// Report Only Success
        /// </summary>
        ReportOnlySuccess = 6,
	
        /// <summary>
        /// Report Only Failure
        /// </summary>
        ReportOnlyFailure = 7,
	
        /// <summary>
        /// Report Only Not Applied
        /// </summary>
        ReportOnlyNotApplied = 8,
	
        /// <summary>
        /// Report Only Interrupted
        /// </summary>
        ReportOnlyInterrupted = 9,
	
    }
}
