// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>A list of possible device assignment item types to execute this action on the managed device. Device assignment item represents existing assigned Intune resource such as application or configuration. Currently supported device assignment item types are Application, DeviceConfiguration, DeviceManagementConfigurationPolicy and MobileAppConfiguration</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum DeviceAssignmentItemType
    {
        /// <summary>Default. Indicates that the device assignment item type for the action is graph.mobileApp. Application is uninstalled on removal and installed back on restoration</summary>
        [EnumMember(Value = "application")]
        Application,
        /// <summary>Indicates that the device assignment item type for the action is graph.deviceConfiguration. DeviceConfiguration associated settings are removed on removal and added back on restoration</summary>
        [EnumMember(Value = "deviceConfiguration")]
        DeviceConfiguration,
        /// <summary>Indicates that the device assignment item type for the action is graph.deviceManagementConfigurationPolicy. DeviceManagementConfigurationPolicy associated settings are removed on removal and added back on restoration</summary>
        [EnumMember(Value = "deviceManagementConfigurationPolicy")]
        DeviceManagementConfigurationPolicy,
        /// <summary>Indicates that the device assignment item type for the action is `graph.managedDeviceMobileAppConfiguration`. MobileAppConfiguration associated settings are removed on removal and added back on restoration</summary>
        [EnumMember(Value = "mobileAppConfiguration")]
        MobileAppConfiguration,
        /// <summary>Evolvable enumeration sentinel value. Do not use</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
