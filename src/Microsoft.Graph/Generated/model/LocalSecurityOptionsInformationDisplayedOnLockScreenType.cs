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
    /// The enum LocalSecurityOptionsInformationDisplayedOnLockScreenType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LocalSecurityOptionsInformationDisplayedOnLockScreenType
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Administrators
        /// </summary>
        Administrators = 1,
	
        /// <summary>
        /// Administrators And Power Users
        /// </summary>
        AdministratorsAndPowerUsers = 2,
	
        /// <summary>
        /// Administrators And Interactive Users
        /// </summary>
        AdministratorsAndInteractiveUsers = 3,
	
    }
}
