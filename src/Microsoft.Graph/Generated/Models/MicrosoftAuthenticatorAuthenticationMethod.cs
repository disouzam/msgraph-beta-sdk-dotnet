// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MicrosoftAuthenticatorAuthenticationMethod : global::Microsoft.Graph.Beta.Models.AuthenticationMethod, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The app that the user has registered to use to approve push notifications. The possible values are: microsoftAuthenticator, outlookMobile, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethodClientAppName? ClientAppName
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethodClientAppName?>("clientAppName"); }
            set { BackingStore?.Set("clientAppName", value); }
        }
        /// <summary>The registered device on which Microsoft Authenticator resides. This property is null if the device isn&apos;t registered for passwordless Phone Sign-In.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Device? Device
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Device?>("device"); }
            set { BackingStore?.Set("device", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Device Device
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Device>("device"); }
            set { BackingStore?.Set("device", value); }
        }
#endif
        /// <summary>Tags containing app metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceTag
        {
            get { return BackingStore?.Get<string?>("deviceTag"); }
            set { BackingStore?.Set("deviceTag", value); }
        }
#nullable restore
#else
        public string DeviceTag
        {
            get { return BackingStore?.Get<string>("deviceTag"); }
            set { BackingStore?.Set("deviceTag", value); }
        }
#endif
        /// <summary>The name of the device on which this app is registered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Numerical version of this instance of the Authenticator app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneAppVersion
        {
            get { return BackingStore?.Get<string?>("phoneAppVersion"); }
            set { BackingStore?.Set("phoneAppVersion", value); }
        }
#nullable restore
#else
        public string PhoneAppVersion
        {
            get { return BackingStore?.Get<string>("phoneAppVersion"); }
            set { BackingStore?.Set("phoneAppVersion", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethod"/> and sets the default values.
        /// </summary>
        public MicrosoftAuthenticatorAuthenticationMethod() : base()
        {
            OdataType = "#microsoft.graph.microsoftAuthenticatorAuthenticationMethod";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethod"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "clientAppName", n => { ClientAppName = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethodClientAppName>(); } },
                { "device", n => { Device = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Device>(global::Microsoft.Graph.Beta.Models.Device.CreateFromDiscriminatorValue); } },
                { "deviceTag", n => { DeviceTag = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "phoneAppVersion", n => { PhoneAppVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethodClientAppName>("clientAppName", ClientAppName);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Device>("device", Device);
            writer.WriteStringValue("deviceTag", DeviceTag);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("phoneAppVersion", PhoneAppVersion);
        }
    }
}
#pragma warning restore CS0618
