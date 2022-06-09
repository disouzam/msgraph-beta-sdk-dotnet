using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsKioskProfile : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The app base class used to identify the application info for the kiosk configuration</summary>
        public WindowsKioskAppConfiguration AppConfiguration {
            get { return BackingStore?.Get<WindowsKioskAppConfiguration>(nameof(AppConfiguration)); }
            set { BackingStore?.Set(nameof(AppConfiguration), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Key of the entity.</summary>
        public string ProfileId {
            get { return BackingStore?.Get<string>(nameof(ProfileId)); }
            set { BackingStore?.Set(nameof(ProfileId), value); }
        }
        /// <summary>This is a friendly name used to identify a group of applications, the layout of these apps on the start menu and the users to whom this kiosk configuration is assigned.</summary>
        public string ProfileName {
            get { return BackingStore?.Get<string>(nameof(ProfileName)); }
            set { BackingStore?.Set(nameof(ProfileName), value); }
        }
        /// <summary>The user accounts that will be locked to this kiosk configuration. This collection can contain a maximum of 100 elements.</summary>
        public List<WindowsKioskUser> UserAccountsConfiguration {
            get { return BackingStore?.Get<List<WindowsKioskUser>>(nameof(UserAccountsConfiguration)); }
            set { BackingStore?.Set(nameof(UserAccountsConfiguration), value); }
        }
        /// <summary>
        /// Instantiates a new windowsKioskProfile and sets the default values.
        /// </summary>
        public WindowsKioskProfile() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsKioskProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appConfiguration", n => { AppConfiguration = n.GetObjectValue<WindowsKioskAppConfiguration>(WindowsKioskAppConfiguration.CreateFromDiscriminatorValue); } },
                {"profileId", n => { ProfileId = n.GetStringValue(); } },
                {"profileName", n => { ProfileName = n.GetStringValue(); } },
                {"userAccountsConfiguration", n => { UserAccountsConfiguration = n.GetCollectionOfObjectValues<WindowsKioskUser>(WindowsKioskUser.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<WindowsKioskAppConfiguration>("appConfiguration", AppConfiguration);
            writer.WriteStringValue("profileId", ProfileId);
            writer.WriteStringValue("profileName", ProfileName);
            writer.WriteCollectionOfObjectValues<WindowsKioskUser>("userAccountsConfiguration", UserAccountsConfiguration);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
