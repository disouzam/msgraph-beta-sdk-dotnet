// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public enum LogDataProvider
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "barracuda")]
        #pragma warning disable CS1591
        Barracuda,
        #pragma warning restore CS1591
        [EnumMember(Value = "bluecoat")]
        #pragma warning disable CS1591
        Bluecoat,
        #pragma warning restore CS1591
        [EnumMember(Value = "checkpoint")]
        #pragma warning disable CS1591
        Checkpoint,
        #pragma warning restore CS1591
        [EnumMember(Value = "ciscoAsa")]
        #pragma warning disable CS1591
        CiscoAsa,
        #pragma warning restore CS1591
        [EnumMember(Value = "ciscoIronportProxy")]
        #pragma warning disable CS1591
        CiscoIronportProxy,
        #pragma warning restore CS1591
        [EnumMember(Value = "fortigate")]
        #pragma warning disable CS1591
        Fortigate,
        #pragma warning restore CS1591
        [EnumMember(Value = "paloAlto")]
        #pragma warning disable CS1591
        PaloAlto,
        #pragma warning restore CS1591
        [EnumMember(Value = "squid")]
        #pragma warning disable CS1591
        Squid,
        #pragma warning restore CS1591
        [EnumMember(Value = "zscaler")]
        #pragma warning disable CS1591
        Zscaler,
        #pragma warning restore CS1591
        [EnumMember(Value = "mcafeeSwg")]
        #pragma warning disable CS1591
        McafeeSwg,
        #pragma warning restore CS1591
        [EnumMember(Value = "ciscoScanSafe")]
        #pragma warning disable CS1591
        CiscoScanSafe,
        #pragma warning restore CS1591
        [EnumMember(Value = "juniperSrx")]
        #pragma warning disable CS1591
        JuniperSrx,
        #pragma warning restore CS1591
        [EnumMember(Value = "sophosSg")]
        #pragma warning disable CS1591
        SophosSg,
        #pragma warning restore CS1591
        [EnumMember(Value = "websenseV75")]
        #pragma warning disable CS1591
        WebsenseV75,
        #pragma warning restore CS1591
        [EnumMember(Value = "websenseSiemCef")]
        #pragma warning disable CS1591
        WebsenseSiemCef,
        #pragma warning restore CS1591
        [EnumMember(Value = "machineZoneMeraki")]
        #pragma warning disable CS1591
        MachineZoneMeraki,
        #pragma warning restore CS1591
        [EnumMember(Value = "squidNative")]
        #pragma warning disable CS1591
        SquidNative,
        #pragma warning restore CS1591
        [EnumMember(Value = "ciscoFwsm")]
        #pragma warning disable CS1591
        CiscoFwsm,
        #pragma warning restore CS1591
        [EnumMember(Value = "microsoftIsaW3C")]
        #pragma warning disable CS1591
        MicrosoftIsaW3C,
        #pragma warning restore CS1591
        [EnumMember(Value = "sonicwall")]
        #pragma warning disable CS1591
        Sonicwall,
        #pragma warning restore CS1591
        [EnumMember(Value = "sophosCyberoam")]
        #pragma warning disable CS1591
        SophosCyberoam,
        #pragma warning restore CS1591
        [EnumMember(Value = "clavister")]
        #pragma warning disable CS1591
        Clavister,
        #pragma warning restore CS1591
        [EnumMember(Value = "customParser")]
        #pragma warning disable CS1591
        CustomParser,
        #pragma warning restore CS1591
        [EnumMember(Value = "juniperSsg")]
        #pragma warning disable CS1591
        JuniperSsg,
        #pragma warning restore CS1591
        [EnumMember(Value = "zscalerQradar")]
        #pragma warning disable CS1591
        ZscalerQradar,
        #pragma warning restore CS1591
        [EnumMember(Value = "juniperSrxSd")]
        #pragma warning disable CS1591
        JuniperSrxSd,
        #pragma warning restore CS1591
        [EnumMember(Value = "juniperSrxWelf")]
        #pragma warning disable CS1591
        JuniperSrxWelf,
        #pragma warning restore CS1591
        [EnumMember(Value = "microsoftConditionalAppAccess")]
        #pragma warning disable CS1591
        MicrosoftConditionalAppAccess,
        #pragma warning restore CS1591
        [EnumMember(Value = "ciscoAsaFirepower")]
        #pragma warning disable CS1591
        CiscoAsaFirepower,
        #pragma warning restore CS1591
        [EnumMember(Value = "genericCef")]
        #pragma warning disable CS1591
        GenericCef,
        #pragma warning restore CS1591
        [EnumMember(Value = "genericLeef")]
        #pragma warning disable CS1591
        GenericLeef,
        #pragma warning restore CS1591
        [EnumMember(Value = "genericW3C")]
        #pragma warning disable CS1591
        GenericW3C,
        #pragma warning restore CS1591
        [EnumMember(Value = "iFilter")]
        #pragma warning disable CS1591
        IFilter,
        #pragma warning restore CS1591
        [EnumMember(Value = "checkpointXml")]
        #pragma warning disable CS1591
        CheckpointXml,
        #pragma warning restore CS1591
        [EnumMember(Value = "checkpointSmartViewTracker")]
        #pragma warning disable CS1591
        CheckpointSmartViewTracker,
        #pragma warning restore CS1591
        [EnumMember(Value = "barracudaNextGenFw")]
        #pragma warning disable CS1591
        BarracudaNextGenFw,
        #pragma warning restore CS1591
        [EnumMember(Value = "barracudaNextGenFwWeblog")]
        #pragma warning disable CS1591
        BarracudaNextGenFwWeblog,
        #pragma warning restore CS1591
        [EnumMember(Value = "microsoftDefenderForEndpoint")]
        #pragma warning disable CS1591
        MicrosoftDefenderForEndpoint,
        #pragma warning restore CS1591
        [EnumMember(Value = "zscalerCef")]
        #pragma warning disable CS1591
        ZscalerCef,
        #pragma warning restore CS1591
        [EnumMember(Value = "sophosXg")]
        #pragma warning disable CS1591
        SophosXg,
        #pragma warning restore CS1591
        [EnumMember(Value = "iboss")]
        #pragma warning disable CS1591
        Iboss,
        #pragma warning restore CS1591
        [EnumMember(Value = "forcepoint")]
        #pragma warning disable CS1591
        Forcepoint,
        #pragma warning restore CS1591
        [EnumMember(Value = "fortios")]
        #pragma warning disable CS1591
        Fortios,
        #pragma warning restore CS1591
        [EnumMember(Value = "ciscoIronportWsaIi")]
        #pragma warning disable CS1591
        CiscoIronportWsaIi,
        #pragma warning restore CS1591
        [EnumMember(Value = "paloAltoLeef")]
        #pragma warning disable CS1591
        PaloAltoLeef,
        #pragma warning restore CS1591
        [EnumMember(Value = "forcepointLeef")]
        #pragma warning disable CS1591
        ForcepointLeef,
        #pragma warning restore CS1591
        [EnumMember(Value = "stormshield")]
        #pragma warning disable CS1591
        Stormshield,
        #pragma warning restore CS1591
        [EnumMember(Value = "contentkeeper")]
        #pragma warning disable CS1591
        Contentkeeper,
        #pragma warning restore CS1591
        [EnumMember(Value = "ciscoIronportWsaIii")]
        #pragma warning disable CS1591
        CiscoIronportWsaIii,
        #pragma warning restore CS1591
        [EnumMember(Value = "checkpointCef")]
        #pragma warning disable CS1591
        CheckpointCef,
        #pragma warning restore CS1591
        [EnumMember(Value = "corrata")]
        #pragma warning disable CS1591
        Corrata,
        #pragma warning restore CS1591
        [EnumMember(Value = "ciscoFirepowerV6")]
        #pragma warning disable CS1591
        CiscoFirepowerV6,
        #pragma warning restore CS1591
        [EnumMember(Value = "menloSecurityCef")]
        #pragma warning disable CS1591
        MenloSecurityCef,
        #pragma warning restore CS1591
        [EnumMember(Value = "watchguardXtm")]
        #pragma warning disable CS1591
        WatchguardXtm,
        #pragma warning restore CS1591
        [EnumMember(Value = "openSystemsSecureWebGateway")]
        #pragma warning disable CS1591
        OpenSystemsSecureWebGateway,
        #pragma warning restore CS1591
        [EnumMember(Value = "wandera")]
        #pragma warning disable CS1591
        Wandera,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue,
        #pragma warning restore CS1591
    }
}
