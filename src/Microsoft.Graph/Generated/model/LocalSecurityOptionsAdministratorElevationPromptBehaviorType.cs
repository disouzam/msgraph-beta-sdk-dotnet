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
    /// The enum LocalSecurityOptionsAdministratorElevationPromptBehaviorType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LocalSecurityOptionsAdministratorElevationPromptBehaviorType
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Elevate Without Prompting
        /// </summary>
        ElevateWithoutPrompting = 1,
	
        /// <summary>
        /// Prompt For Credentials On The Secure Desktop
        /// </summary>
        PromptForCredentialsOnTheSecureDesktop = 2,
	
        /// <summary>
        /// Prompt For Consent On The Secure Desktop
        /// </summary>
        PromptForConsentOnTheSecureDesktop = 3,
	
        /// <summary>
        /// Prompt For Credentials
        /// </summary>
        PromptForCredentials = 4,
	
        /// <summary>
        /// Prompt For Consent
        /// </summary>
        PromptForConsent = 5,
	
        /// <summary>
        /// Prompt For Consent For Non Windows Binaries
        /// </summary>
        PromptForConsentForNonWindowsBinaries = 6,
	
    }
}
