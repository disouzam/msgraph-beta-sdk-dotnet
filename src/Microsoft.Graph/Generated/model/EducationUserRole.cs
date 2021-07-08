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
    /// The enum EducationUserRole.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EducationUserRole
    {
    
        /// <summary>
        /// Student
        /// </summary>
        Student = 0,
	
        /// <summary>
        /// Teacher
        /// </summary>
        Teacher = 1,
	
        /// <summary>
        /// None
        /// </summary>
        None = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
        /// <summary>
        /// Faculty
        /// </summary>
        Faculty = 4,
	
    }
}
