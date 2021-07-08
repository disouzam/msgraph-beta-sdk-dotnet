// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type DeviceManagementConfigurationChoiceSettingValueTemplate.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceManagementConfigurationChoiceSettingValueTemplate>))]
    public partial class DeviceManagementConfigurationChoiceSettingValueTemplate
    {

        /// <summary>
        /// Gets or sets defaultValue.
        /// Choice Setting Value Default Template.
        /// </summary>
        [JsonPropertyName("defaultValue")]
        public DeviceManagementConfigurationChoiceSettingValueDefaultTemplate DefaultValue { get; set; }
    
        /// <summary>
        /// Gets or sets recommendedValueDefinition.
        /// Recommended definition override.
        /// </summary>
        [JsonPropertyName("recommendedValueDefinition")]
        public DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate RecommendedValueDefinition { get; set; }
    
        /// <summary>
        /// Gets or sets requiredValueDefinition.
        /// Required definition override.
        /// </summary>
        [JsonPropertyName("requiredValueDefinition")]
        public DeviceManagementConfigurationChoiceSettingValueDefinitionTemplate RequiredValueDefinition { get; set; }
    
        /// <summary>
        /// Gets or sets settingValueTemplateId.
        /// Setting Value Template Id
        /// </summary>
        [JsonPropertyName("settingValueTemplateId")]
        public string SettingValueTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
