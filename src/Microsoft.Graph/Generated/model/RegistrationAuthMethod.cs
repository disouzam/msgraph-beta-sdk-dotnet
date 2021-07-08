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
    /// The enum RegistrationAuthMethod.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RegistrationAuthMethod
    {
    
        /// <summary>
        /// Email
        /// </summary>
        Email = 0,
	
        /// <summary>
        /// Mobile Phone
        /// </summary>
        MobilePhone = 1,
	
        /// <summary>
        /// Office Phone
        /// </summary>
        OfficePhone = 2,
	
        /// <summary>
        /// Security Question
        /// </summary>
        SecurityQuestion = 3,
	
        /// <summary>
        /// App Notification
        /// </summary>
        AppNotification = 4,
	
        /// <summary>
        /// App Code
        /// </summary>
        AppCode = 5,
	
        /// <summary>
        /// Alternate Mobile Phone
        /// </summary>
        AlternateMobilePhone = 6,
	
        /// <summary>
        /// Fido
        /// </summary>
        Fido = 7,
	
        /// <summary>
        /// App Password
        /// </summary>
        AppPassword = 8,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 9,
	
    }
}
