using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsKioskConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Enable public browsing kiosk mode for the Microsoft Edge browser. The Default is false.</summary>
        public bool? EdgeKioskEnablePublicBrowsing {
            get { return BackingStore?.Get<bool?>(nameof(EdgeKioskEnablePublicBrowsing)); }
            set { BackingStore?.Set(nameof(EdgeKioskEnablePublicBrowsing), value); }
        }
        /// <summary>Specify URLs that the kiosk browser is allowed to navigate to</summary>
        public List<string> KioskBrowserBlockedUrlExceptions {
            get { return BackingStore?.Get<List<string>>(nameof(KioskBrowserBlockedUrlExceptions)); }
            set { BackingStore?.Set(nameof(KioskBrowserBlockedUrlExceptions), value); }
        }
        /// <summary>Specify URLs that the kiosk browsers should not navigate to</summary>
        public List<string> KioskBrowserBlockedURLs {
            get { return BackingStore?.Get<List<string>>(nameof(KioskBrowserBlockedURLs)); }
            set { BackingStore?.Set(nameof(KioskBrowserBlockedURLs), value); }
        }
        /// <summary>Specify the default URL the browser should navigate to on launch.</summary>
        public string KioskBrowserDefaultUrl {
            get { return BackingStore?.Get<string>(nameof(KioskBrowserDefaultUrl)); }
            set { BackingStore?.Set(nameof(KioskBrowserDefaultUrl), value); }
        }
        /// <summary>Enable the kiosk browser&apos;s end session button. By default, the end session button is disabled.</summary>
        public bool? KioskBrowserEnableEndSessionButton {
            get { return BackingStore?.Get<bool?>(nameof(KioskBrowserEnableEndSessionButton)); }
            set { BackingStore?.Set(nameof(KioskBrowserEnableEndSessionButton), value); }
        }
        /// <summary>Enable the kiosk browser&apos;s home button. By default, the home button is disabled.</summary>
        public bool? KioskBrowserEnableHomeButton {
            get { return BackingStore?.Get<bool?>(nameof(KioskBrowserEnableHomeButton)); }
            set { BackingStore?.Set(nameof(KioskBrowserEnableHomeButton), value); }
        }
        /// <summary>Enable the kiosk browser&apos;s navigation buttons(forward/back). By default, the navigation buttons are disabled.</summary>
        public bool? KioskBrowserEnableNavigationButtons {
            get { return BackingStore?.Get<bool?>(nameof(KioskBrowserEnableNavigationButtons)); }
            set { BackingStore?.Set(nameof(KioskBrowserEnableNavigationButtons), value); }
        }
        /// <summary>Specify the number of minutes the session is idle until the kiosk browser restarts in a fresh state.  Valid values are 1-1440. Valid values 1 to 1440</summary>
        public int? KioskBrowserRestartOnIdleTimeInMinutes {
            get { return BackingStore?.Get<int?>(nameof(KioskBrowserRestartOnIdleTimeInMinutes)); }
            set { BackingStore?.Set(nameof(KioskBrowserRestartOnIdleTimeInMinutes), value); }
        }
        /// <summary>This policy setting allows to define a list of Kiosk profiles for a Kiosk configuration. This collection can contain a maximum of 3 elements.</summary>
        public List<WindowsKioskProfile> KioskProfiles {
            get { return BackingStore?.Get<List<WindowsKioskProfile>>(nameof(KioskProfiles)); }
            set { BackingStore?.Set(nameof(KioskProfiles), value); }
        }
        /// <summary>force update schedule for Kiosk devices.</summary>
        public Microsoft.Graph.Beta.Models.WindowsKioskForceUpdateSchedule WindowsKioskForceUpdateSchedule {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsKioskForceUpdateSchedule>(nameof(WindowsKioskForceUpdateSchedule)); }
            set { BackingStore?.Set(nameof(WindowsKioskForceUpdateSchedule), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsKioskConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"edgeKioskEnablePublicBrowsing", n => { EdgeKioskEnablePublicBrowsing = n.GetBoolValue(); } },
                {"kioskBrowserBlockedUrlExceptions", n => { KioskBrowserBlockedUrlExceptions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"kioskBrowserBlockedURLs", n => { KioskBrowserBlockedURLs = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"kioskBrowserDefaultUrl", n => { KioskBrowserDefaultUrl = n.GetStringValue(); } },
                {"kioskBrowserEnableEndSessionButton", n => { KioskBrowserEnableEndSessionButton = n.GetBoolValue(); } },
                {"kioskBrowserEnableHomeButton", n => { KioskBrowserEnableHomeButton = n.GetBoolValue(); } },
                {"kioskBrowserEnableNavigationButtons", n => { KioskBrowserEnableNavigationButtons = n.GetBoolValue(); } },
                {"kioskBrowserRestartOnIdleTimeInMinutes", n => { KioskBrowserRestartOnIdleTimeInMinutes = n.GetIntValue(); } },
                {"kioskProfiles", n => { KioskProfiles = n.GetCollectionOfObjectValues<WindowsKioskProfile>(WindowsKioskProfile.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsKioskForceUpdateSchedule", n => { WindowsKioskForceUpdateSchedule = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsKioskForceUpdateSchedule>(Microsoft.Graph.Beta.Models.WindowsKioskForceUpdateSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("edgeKioskEnablePublicBrowsing", EdgeKioskEnablePublicBrowsing);
            writer.WriteCollectionOfPrimitiveValues<string>("kioskBrowserBlockedUrlExceptions", KioskBrowserBlockedUrlExceptions);
            writer.WriteCollectionOfPrimitiveValues<string>("kioskBrowserBlockedURLs", KioskBrowserBlockedURLs);
            writer.WriteStringValue("kioskBrowserDefaultUrl", KioskBrowserDefaultUrl);
            writer.WriteBoolValue("kioskBrowserEnableEndSessionButton", KioskBrowserEnableEndSessionButton);
            writer.WriteBoolValue("kioskBrowserEnableHomeButton", KioskBrowserEnableHomeButton);
            writer.WriteBoolValue("kioskBrowserEnableNavigationButtons", KioskBrowserEnableNavigationButtons);
            writer.WriteIntValue("kioskBrowserRestartOnIdleTimeInMinutes", KioskBrowserRestartOnIdleTimeInMinutes);
            writer.WriteCollectionOfObjectValues<WindowsKioskProfile>("kioskProfiles", KioskProfiles);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsKioskForceUpdateSchedule>("windowsKioskForceUpdateSchedule", WindowsKioskForceUpdateSchedule);
        }
    }
}
