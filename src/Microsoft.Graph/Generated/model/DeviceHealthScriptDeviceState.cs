// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Device Health Script Device State.
    /// </summary>
    public partial class DeviceHealthScriptDeviceState : Entity
    {
    
		///<summary>
		/// The DeviceHealthScriptDeviceState constructor
		///</summary>
        public DeviceHealthScriptDeviceState()
        {
            this.ODataType = "microsoft.graph.deviceHealthScriptDeviceState";
        }
	
        /// <summary>
        /// Gets or sets detection state.
        /// Detection state from the lastest device health script execution. Possible values are: unknown, success, fail, scriptError, pending, notApplicable.
        /// </summary>
        [JsonPropertyName("detectionState")]
        public RunState? DetectionState { get; set; }
    
        /// <summary>
        /// Gets or sets expected state update date time.
        /// The next timestamp of when the device health script is expected to execute
        /// </summary>
        [JsonPropertyName("expectedStateUpdateDateTime")]
        public DateTimeOffset? ExpectedStateUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last state update date time.
        /// The last timestamp of when the device health script executed
        /// </summary>
        [JsonPropertyName("lastStateUpdateDateTime")]
        public DateTimeOffset? LastStateUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// The last time that Intune Managment Extension synced with Intune
        /// </summary>
        [JsonPropertyName("lastSyncDateTime")]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets post remediation detection script error.
        /// Error from the detection script after remediation
        /// </summary>
        [JsonPropertyName("postRemediationDetectionScriptError")]
        public string PostRemediationDetectionScriptError { get; set; }
    
        /// <summary>
        /// Gets or sets post remediation detection script output.
        /// Detection script output after remediation
        /// </summary>
        [JsonPropertyName("postRemediationDetectionScriptOutput")]
        public string PostRemediationDetectionScriptOutput { get; set; }
    
        /// <summary>
        /// Gets or sets pre remediation detection script error.
        /// Error from the detection script before remediation
        /// </summary>
        [JsonPropertyName("preRemediationDetectionScriptError")]
        public string PreRemediationDetectionScriptError { get; set; }
    
        /// <summary>
        /// Gets or sets pre remediation detection script output.
        /// Output of the detection script before remediation
        /// </summary>
        [JsonPropertyName("preRemediationDetectionScriptOutput")]
        public string PreRemediationDetectionScriptOutput { get; set; }
    
        /// <summary>
        /// Gets or sets remediation script error.
        /// Error output of the remediation script
        /// </summary>
        [JsonPropertyName("remediationScriptError")]
        public string RemediationScriptError { get; set; }
    
        /// <summary>
        /// Gets or sets remediation state.
        /// Remediation state from the lastest device health script execution. Possible values are: unknown, skipped, success, remediationFailed, scriptError.
        /// </summary>
        [JsonPropertyName("remediationState")]
        public RemediationState? RemediationState { get; set; }
    
        /// <summary>
        /// Gets or sets managed device.
        /// The managed device on which the device health script executed
        /// </summary>
        [JsonPropertyName("managedDevice")]
        public ManagedDevice ManagedDevice { get; set; }
    
    }
}

