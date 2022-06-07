using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Singleton entity that acts as a container for all device app management functionality.</summary>
    public class DeviceAppManagement : Entity, IParsable {
        /// <summary>Android managed app policies.</summary>
        public List<AndroidManagedAppProtection> AndroidManagedAppProtections {
            get { return BackingStore?.Get<List<AndroidManagedAppProtection>>(nameof(AndroidManagedAppProtections)); }
            set { BackingStore?.Set(nameof(AndroidManagedAppProtections), value); }
        }
        /// <summary>Default managed app policies.</summary>
        public List<DefaultManagedAppProtection> DefaultManagedAppProtections {
            get { return BackingStore?.Get<List<DefaultManagedAppProtection>>(nameof(DefaultManagedAppProtections)); }
            set { BackingStore?.Set(nameof(DefaultManagedAppProtections), value); }
        }
        /// <summary>iOS managed app policies.</summary>
        public List<IosManagedAppProtection> IosManagedAppProtections {
            get { return BackingStore?.Get<List<IosManagedAppProtection>>(nameof(IosManagedAppProtections)); }
            set { BackingStore?.Set(nameof(IosManagedAppProtections), value); }
        }
        /// <summary>Whether the account is enabled for syncing applications from the Microsoft Store for Business.</summary>
        public bool? IsEnabledForMicrosoftStoreForBusiness {
            get { return BackingStore?.Get<bool?>(nameof(IsEnabledForMicrosoftStoreForBusiness)); }
            set { BackingStore?.Set(nameof(IsEnabledForMicrosoftStoreForBusiness), value); }
        }
        /// <summary>Managed app policies.</summary>
        public List<ManagedAppPolicy> ManagedAppPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>>(nameof(ManagedAppPolicies)); }
            set { BackingStore?.Set(nameof(ManagedAppPolicies), value); }
        }
        /// <summary>The managed app registrations.</summary>
        public List<ManagedAppRegistration> ManagedAppRegistrations {
            get { return BackingStore?.Get<List<ManagedAppRegistration>>(nameof(ManagedAppRegistrations)); }
            set { BackingStore?.Set(nameof(ManagedAppRegistrations), value); }
        }
        /// <summary>The managed app statuses.</summary>
        public List<ManagedAppStatus> ManagedAppStatuses {
            get { return BackingStore?.Get<List<ManagedAppStatus>>(nameof(ManagedAppStatuses)); }
            set { BackingStore?.Set(nameof(ManagedAppStatuses), value); }
        }
        /// <summary>The Managed eBook.</summary>
        public List<ManagedEBook> ManagedEBooks {
            get { return BackingStore?.Get<List<ManagedEBook>>(nameof(ManagedEBooks)); }
            set { BackingStore?.Set(nameof(ManagedEBooks), value); }
        }
        /// <summary>Windows information protection for apps running on devices which are MDM enrolled.</summary>
        public List<MdmWindowsInformationProtectionPolicy> MdmWindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<MdmWindowsInformationProtectionPolicy>>(nameof(MdmWindowsInformationProtectionPolicies)); }
            set { BackingStore?.Set(nameof(MdmWindowsInformationProtectionPolicies), value); }
        }
        /// <summary>The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is &lt;languagecode2&gt;-&lt;country/regioncode2&gt;, where &lt;languagecode2&gt; is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</summary>
        public string MicrosoftStoreForBusinessLanguage {
            get { return BackingStore?.Get<string>(nameof(MicrosoftStoreForBusinessLanguage)); }
            set { BackingStore?.Set(nameof(MicrosoftStoreForBusinessLanguage), value); }
        }
        /// <summary>The last time an application sync from the Microsoft Store for Business was completed.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(MicrosoftStoreForBusinessLastCompletedApplicationSyncTime)); }
            set { BackingStore?.Set(nameof(MicrosoftStoreForBusinessLastCompletedApplicationSyncTime), value); }
        }
        /// <summary>The last time the apps from the Microsoft Store for Business were synced successfully for the account.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(MicrosoftStoreForBusinessLastSuccessfulSyncDateTime)); }
            set { BackingStore?.Set(nameof(MicrosoftStoreForBusinessLastSuccessfulSyncDateTime), value); }
        }
        /// <summary>The mobile app categories.</summary>
        public List<MobileAppCategory> MobileAppCategories {
            get { return BackingStore?.Get<List<MobileAppCategory>>(nameof(MobileAppCategories)); }
            set { BackingStore?.Set(nameof(MobileAppCategories), value); }
        }
        /// <summary>The Managed Device Mobile Application Configurations.</summary>
        public List<ManagedDeviceMobileAppConfiguration> MobileAppConfigurations {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfiguration>>(nameof(MobileAppConfigurations)); }
            set { BackingStore?.Set(nameof(MobileAppConfigurations), value); }
        }
        /// <summary>The mobile apps.</summary>
        public List<MobileApp> MobileApps {
            get { return BackingStore?.Get<List<MobileApp>>(nameof(MobileApps)); }
            set { BackingStore?.Set(nameof(MobileApps), value); }
        }
        /// <summary>Targeted managed app configurations.</summary>
        public List<TargetedManagedAppConfiguration> TargetedManagedAppConfigurations {
            get { return BackingStore?.Get<List<TargetedManagedAppConfiguration>>(nameof(TargetedManagedAppConfigurations)); }
            set { BackingStore?.Set(nameof(TargetedManagedAppConfigurations), value); }
        }
        /// <summary>List of Vpp tokens for this organization.</summary>
        public List<VppToken> VppTokens {
            get { return BackingStore?.Get<List<VppToken>>(nameof(VppTokens)); }
            set { BackingStore?.Set(nameof(VppTokens), value); }
        }
        /// <summary>Windows information protection for apps running on devices which are not MDM enrolled.</summary>
        public List<WindowsInformationProtectionPolicy> WindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<WindowsInformationProtectionPolicy>>(nameof(WindowsInformationProtectionPolicies)); }
            set { BackingStore?.Set(nameof(WindowsInformationProtectionPolicies), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceAppManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAppManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidManagedAppProtections", n => { AndroidManagedAppProtections = n.GetCollectionOfObjectValues<AndroidManagedAppProtection>(AndroidManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"defaultManagedAppProtections", n => { DefaultManagedAppProtections = n.GetCollectionOfObjectValues<DefaultManagedAppProtection>(DefaultManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"iosManagedAppProtections", n => { IosManagedAppProtections = n.GetCollectionOfObjectValues<IosManagedAppProtection>(IosManagedAppProtection.CreateFromDiscriminatorValue).ToList(); } },
                {"isEnabledForMicrosoftStoreForBusiness", n => { IsEnabledForMicrosoftStoreForBusiness = n.GetBoolValue(); } },
                {"managedAppPolicies", n => { ManagedAppPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>(ManagedAppPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"managedAppRegistrations", n => { ManagedAppRegistrations = n.GetCollectionOfObjectValues<ManagedAppRegistration>(ManagedAppRegistration.CreateFromDiscriminatorValue).ToList(); } },
                {"managedAppStatuses", n => { ManagedAppStatuses = n.GetCollectionOfObjectValues<ManagedAppStatus>(ManagedAppStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"managedEBooks", n => { ManagedEBooks = n.GetCollectionOfObjectValues<ManagedEBook>(ManagedEBook.CreateFromDiscriminatorValue).ToList(); } },
                {"mdmWindowsInformationProtectionPolicies", n => { MdmWindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<MdmWindowsInformationProtectionPolicy>(MdmWindowsInformationProtectionPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"microsoftStoreForBusinessLanguage", n => { MicrosoftStoreForBusinessLanguage = n.GetStringValue(); } },
                {"microsoftStoreForBusinessLastCompletedApplicationSyncTime", n => { MicrosoftStoreForBusinessLastCompletedApplicationSyncTime = n.GetDateTimeOffsetValue(); } },
                {"microsoftStoreForBusinessLastSuccessfulSyncDateTime", n => { MicrosoftStoreForBusinessLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"mobileAppCategories", n => { MobileAppCategories = n.GetCollectionOfObjectValues<MobileAppCategory>(MobileAppCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileAppConfigurations", n => { MobileAppConfigurations = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfiguration>(ManagedDeviceMobileAppConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"mobileApps", n => { MobileApps = n.GetCollectionOfObjectValues<MobileApp>(MobileApp.CreateFromDiscriminatorValue).ToList(); } },
                {"targetedManagedAppConfigurations", n => { TargetedManagedAppConfigurations = n.GetCollectionOfObjectValues<TargetedManagedAppConfiguration>(TargetedManagedAppConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"vppTokens", n => { VppTokens = n.GetCollectionOfObjectValues<VppToken>(VppToken.CreateFromDiscriminatorValue).ToList(); } },
                {"windowsInformationProtectionPolicies", n => { WindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<WindowsInformationProtectionPolicy>(WindowsInformationProtectionPolicy.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AndroidManagedAppProtection>("androidManagedAppProtections", AndroidManagedAppProtections);
            writer.WriteCollectionOfObjectValues<DefaultManagedAppProtection>("defaultManagedAppProtections", DefaultManagedAppProtections);
            writer.WriteCollectionOfObjectValues<IosManagedAppProtection>("iosManagedAppProtections", IosManagedAppProtections);
            writer.WriteBoolValue("isEnabledForMicrosoftStoreForBusiness", IsEnabledForMicrosoftStoreForBusiness);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicy>("managedAppPolicies", ManagedAppPolicies);
            writer.WriteCollectionOfObjectValues<ManagedAppRegistration>("managedAppRegistrations", ManagedAppRegistrations);
            writer.WriteCollectionOfObjectValues<ManagedAppStatus>("managedAppStatuses", ManagedAppStatuses);
            writer.WriteCollectionOfObjectValues<ManagedEBook>("managedEBooks", ManagedEBooks);
            writer.WriteCollectionOfObjectValues<MdmWindowsInformationProtectionPolicy>("mdmWindowsInformationProtectionPolicies", MdmWindowsInformationProtectionPolicies);
            writer.WriteStringValue("microsoftStoreForBusinessLanguage", MicrosoftStoreForBusinessLanguage);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastCompletedApplicationSyncTime", MicrosoftStoreForBusinessLastCompletedApplicationSyncTime);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastSuccessfulSyncDateTime", MicrosoftStoreForBusinessLastSuccessfulSyncDateTime);
            writer.WriteCollectionOfObjectValues<MobileAppCategory>("mobileAppCategories", MobileAppCategories);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfiguration>("mobileAppConfigurations", MobileAppConfigurations);
            writer.WriteCollectionOfObjectValues<MobileApp>("mobileApps", MobileApps);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppConfiguration>("targetedManagedAppConfigurations", TargetedManagedAppConfigurations);
            writer.WriteCollectionOfObjectValues<VppToken>("vppTokens", VppTokens);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionPolicy>("windowsInformationProtectionPolicies", WindowsInformationProtectionPolicies);
        }
    }
}
