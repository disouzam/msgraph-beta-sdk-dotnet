// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class ConditionalAccessSessionControls : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Session control to enforce application restrictions. Only Exchange Online and Sharepoint Online support this session control.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ApplicationEnforcedRestrictionsSessionControl? ApplicationEnforcedRestrictions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ApplicationEnforcedRestrictionsSessionControl?>("applicationEnforcedRestrictions"); }
            set { BackingStore?.Set("applicationEnforcedRestrictions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ApplicationEnforcedRestrictionsSessionControl ApplicationEnforcedRestrictions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ApplicationEnforcedRestrictionsSessionControl>("applicationEnforcedRestrictions"); }
            set { BackingStore?.Set("applicationEnforcedRestrictions", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Session control to apply cloud app security.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CloudAppSecuritySessionControl? CloudAppSecurity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudAppSecuritySessionControl?>("cloudAppSecurity"); }
            set { BackingStore?.Set("cloudAppSecurity", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CloudAppSecuritySessionControl CloudAppSecurity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CloudAppSecuritySessionControl>("cloudAppSecurity"); }
            set { BackingStore?.Set("cloudAppSecurity", value); }
        }
#endif
        /// <summary>Session control for continuous access evaluation settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationSessionControl? ContinuousAccessEvaluation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationSessionControl?>("continuousAccessEvaluation"); }
            set { BackingStore?.Set("continuousAccessEvaluation", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationSessionControl ContinuousAccessEvaluation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationSessionControl>("continuousAccessEvaluation"); }
            set { BackingStore?.Set("continuousAccessEvaluation", value); }
        }
#endif
        /// <summary>Session control that determines whether it&apos;s acceptable for Microsoft Entra ID to extend existing sessions based on information collected prior to an outage or not.</summary>
        public bool? DisableResilienceDefaults
        {
            get { return BackingStore?.Get<bool?>("disableResilienceDefaults"); }
            set { BackingStore?.Set("disableResilienceDefaults", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Session control to define whether to persist cookies or not. All apps should be selected for this session control to work correctly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PersistentBrowserSessionControl? PersistentBrowser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PersistentBrowserSessionControl?>("persistentBrowser"); }
            set { BackingStore?.Set("persistentBrowser", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PersistentBrowserSessionControl PersistentBrowser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PersistentBrowserSessionControl>("persistentBrowser"); }
            set { BackingStore?.Set("persistentBrowser", value); }
        }
#endif
        /// <summary>Session control to require sign in sessions to be bound to a device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.SecureSignInSessionControl? SecureSignInSession
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SecureSignInSessionControl?>("secureSignInSession"); }
            set { BackingStore?.Set("secureSignInSession", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.SecureSignInSessionControl SecureSignInSession
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SecureSignInSessionControl>("secureSignInSession"); }
            set { BackingStore?.Set("secureSignInSession", value); }
        }
#endif
        /// <summary>Session control to enforce signin frequency.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.SignInFrequencySessionControl? SignInFrequency
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SignInFrequencySessionControl?>("signInFrequency"); }
            set { BackingStore?.Set("signInFrequency", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.SignInFrequencySessionControl SignInFrequency
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SignInFrequencySessionControl>("signInFrequency"); }
            set { BackingStore?.Set("signInFrequency", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ConditionalAccessSessionControls"/> and sets the default values.
        /// </summary>
        public ConditionalAccessSessionControls()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ConditionalAccessSessionControls"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.ConditionalAccessSessionControls CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ConditionalAccessSessionControls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "applicationEnforcedRestrictions", n => { ApplicationEnforcedRestrictions = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ApplicationEnforcedRestrictionsSessionControl>(global::Microsoft.Graph.Beta.Models.ApplicationEnforcedRestrictionsSessionControl.CreateFromDiscriminatorValue); } },
                { "cloudAppSecurity", n => { CloudAppSecurity = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CloudAppSecuritySessionControl>(global::Microsoft.Graph.Beta.Models.CloudAppSecuritySessionControl.CreateFromDiscriminatorValue); } },
                { "continuousAccessEvaluation", n => { ContinuousAccessEvaluation = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationSessionControl>(global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationSessionControl.CreateFromDiscriminatorValue); } },
                { "disableResilienceDefaults", n => { DisableResilienceDefaults = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "persistentBrowser", n => { PersistentBrowser = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PersistentBrowserSessionControl>(global::Microsoft.Graph.Beta.Models.PersistentBrowserSessionControl.CreateFromDiscriminatorValue); } },
                { "secureSignInSession", n => { SecureSignInSession = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.SecureSignInSessionControl>(global::Microsoft.Graph.Beta.Models.SecureSignInSessionControl.CreateFromDiscriminatorValue); } },
                { "signInFrequency", n => { SignInFrequency = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.SignInFrequencySessionControl>(global::Microsoft.Graph.Beta.Models.SignInFrequencySessionControl.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ApplicationEnforcedRestrictionsSessionControl>("applicationEnforcedRestrictions", ApplicationEnforcedRestrictions);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CloudAppSecuritySessionControl>("cloudAppSecurity", CloudAppSecurity);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationSessionControl>("continuousAccessEvaluation", ContinuousAccessEvaluation);
            writer.WriteBoolValue("disableResilienceDefaults", DisableResilienceDefaults);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PersistentBrowserSessionControl>("persistentBrowser", PersistentBrowser);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.SecureSignInSessionControl>("secureSignInSession", SecureSignInSession);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.SignInFrequencySessionControl>("signInFrequency", SignInFrequency);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
