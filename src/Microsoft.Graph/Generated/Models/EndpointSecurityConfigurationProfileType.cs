// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>The endpoint security policy profile type.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum EndpointSecurityConfigurationProfileType
    {
        /// <summary>Unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Antivirus.</summary>
        [EnumMember(Value = "antivirus")]
        Antivirus,
        /// <summary>Windows Security.</summary>
        [EnumMember(Value = "windowsSecurity")]
        WindowsSecurity,
        /// <summary>BitLocker.</summary>
        [EnumMember(Value = "bitLocker")]
        BitLocker,
        /// <summary>FileVault.</summary>
        [EnumMember(Value = "fileVault")]
        FileVault,
        /// <summary>Firewall.</summary>
        [EnumMember(Value = "firewall")]
        Firewall,
        /// <summary>Firewall rules.</summary>
        [EnumMember(Value = "firewallRules")]
        FirewallRules,
        /// <summary>Endpoint detection and response.</summary>
        [EnumMember(Value = "endpointDetectionAndResponse")]
        EndpointDetectionAndResponse,
        /// <summary>Device control.</summary>
        [EnumMember(Value = "deviceControl")]
        DeviceControl,
        /// <summary>App and browser isolation.</summary>
        [EnumMember(Value = "appAndBrowserIsolation")]
        AppAndBrowserIsolation,
        /// <summary>Exploit protection.</summary>
        [EnumMember(Value = "exploitProtection")]
        ExploitProtection,
        /// <summary>Web protection.</summary>
        [EnumMember(Value = "webProtection")]
        WebProtection,
        /// <summary>Application control.</summary>
        [EnumMember(Value = "applicationControl")]
        ApplicationControl,
        /// <summary>Attack surface reduction rules.</summary>
        [EnumMember(Value = "attackSurfaceReductionRules")]
        AttackSurfaceReductionRules,
        /// <summary>Account protection.</summary>
        [EnumMember(Value = "accountProtection")]
        AccountProtection,
    }
}
