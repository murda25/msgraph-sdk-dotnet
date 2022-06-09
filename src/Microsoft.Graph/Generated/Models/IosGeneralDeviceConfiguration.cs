using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class IosGeneralDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to allow account modification when the device is in supervised mode.</summary>
        public bool? AccountBlockModification {
            get { return BackingStore?.Get<bool?>(nameof(AccountBlockModification)); }
            set { BackingStore?.Set(nameof(AccountBlockModification), value); }
        }
        /// <summary>Indicates whether or not to allow activation lock when the device is in the supervised mode.</summary>
        public bool? ActivationLockAllowWhenSupervised {
            get { return BackingStore?.Get<bool?>(nameof(ActivationLockAllowWhenSupervised)); }
            set { BackingStore?.Set(nameof(ActivationLockAllowWhenSupervised), value); }
        }
        /// <summary>Indicates whether or not to allow AirDrop when the device is in supervised mode.</summary>
        public bool? AirDropBlocked {
            get { return BackingStore?.Get<bool?>(nameof(AirDropBlocked)); }
            set { BackingStore?.Set(nameof(AirDropBlocked), value); }
        }
        /// <summary>Indicates whether or not to cause AirDrop to be considered an unmanaged drop target (iOS 9.0 and later).</summary>
        public bool? AirDropForceUnmanagedDropTarget {
            get { return BackingStore?.Get<bool?>(nameof(AirDropForceUnmanagedDropTarget)); }
            set { BackingStore?.Set(nameof(AirDropForceUnmanagedDropTarget), value); }
        }
        /// <summary>Indicates whether or not to enforce all devices receiving AirPlay requests from this device to use a pairing password.</summary>
        public bool? AirPlayForcePairingPasswordForOutgoingRequests {
            get { return BackingStore?.Get<bool?>(nameof(AirPlayForcePairingPasswordForOutgoingRequests)); }
            set { BackingStore?.Set(nameof(AirPlayForcePairingPasswordForOutgoingRequests), value); }
        }
        /// <summary>Indicates whether or not to block the user from using News when the device is in supervised mode (iOS 9.0 and later).</summary>
        public bool? AppleNewsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(AppleNewsBlocked)); }
            set { BackingStore?.Set(nameof(AppleNewsBlocked), value); }
        }
        /// <summary>Indicates whether or not to allow Apple Watch pairing when the device is in supervised mode (iOS 9.0 and later).</summary>
        public bool? AppleWatchBlockPairing {
            get { return BackingStore?.Get<bool?>(nameof(AppleWatchBlockPairing)); }
            set { BackingStore?.Set(nameof(AppleWatchBlockPairing), value); }
        }
        /// <summary>Indicates whether or not to force a paired Apple Watch to use Wrist Detection (iOS 8.2 and later).</summary>
        public bool? AppleWatchForceWristDetection {
            get { return BackingStore?.Get<bool?>(nameof(AppleWatchForceWristDetection)); }
            set { BackingStore?.Set(nameof(AppleWatchForceWristDetection), value); }
        }
        /// <summary>Gets or sets the list of iOS apps allowed to autonomously enter Single App Mode. Supervised only. iOS 7.0 and later. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AppsSingleAppModeList {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(AppsSingleAppModeList)); }
            set { BackingStore?.Set(nameof(AppsSingleAppModeList), value); }
        }
        /// <summary>Indicates whether or not to block the automatic downloading of apps purchased on other devices when the device is in supervised mode (iOS 9.0 and later).</summary>
        public bool? AppStoreBlockAutomaticDownloads {
            get { return BackingStore?.Get<bool?>(nameof(AppStoreBlockAutomaticDownloads)); }
            set { BackingStore?.Set(nameof(AppStoreBlockAutomaticDownloads), value); }
        }
        /// <summary>Indicates whether or not to block the user from using the App Store. Requires a supervised device for iOS 13 and later.</summary>
        public bool? AppStoreBlocked {
            get { return BackingStore?.Get<bool?>(nameof(AppStoreBlocked)); }
            set { BackingStore?.Set(nameof(AppStoreBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the user from making in app purchases.</summary>
        public bool? AppStoreBlockInAppPurchases {
            get { return BackingStore?.Get<bool?>(nameof(AppStoreBlockInAppPurchases)); }
            set { BackingStore?.Set(nameof(AppStoreBlockInAppPurchases), value); }
        }
        /// <summary>Indicates whether or not to block the App Store app, not restricting installation through Host apps. Applies to supervised mode only (iOS 9.0 and later).</summary>
        public bool? AppStoreBlockUIAppInstallation {
            get { return BackingStore?.Get<bool?>(nameof(AppStoreBlockUIAppInstallation)); }
            set { BackingStore?.Set(nameof(AppStoreBlockUIAppInstallation), value); }
        }
        /// <summary>Indicates whether or not to require a password when using the app store.</summary>
        public bool? AppStoreRequirePassword {
            get { return BackingStore?.Get<bool?>(nameof(AppStoreRequirePassword)); }
            set { BackingStore?.Set(nameof(AppStoreRequirePassword), value); }
        }
        /// <summary>List of apps in the visibility list (either visible/launchable apps list or hidden/unlaunchable apps list, controlled by AppsVisibilityListType) (iOS 9.3 and later). This collection can contain a maximum of 10000 elements.</summary>
        public List<AppListItem> AppsVisibilityList {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(AppsVisibilityList)); }
            set { BackingStore?.Set(nameof(AppsVisibilityList), value); }
        }
        /// <summary>Type of list that is in the AppsVisibilityList. Possible values are: none, appsInListCompliant, appsNotInListCompliant.</summary>
        public AppListType? AppsVisibilityListType {
            get { return BackingStore?.Get<AppListType?>(nameof(AppsVisibilityListType)); }
            set { BackingStore?.Set(nameof(AppsVisibilityListType), value); }
        }
        /// <summary>Indicates whether or not to allow modification of Bluetooth settings when the device is in supervised mode (iOS 10.0 and later).</summary>
        public bool? BluetoothBlockModification {
            get { return BackingStore?.Get<bool?>(nameof(BluetoothBlockModification)); }
            set { BackingStore?.Set(nameof(BluetoothBlockModification), value); }
        }
        /// <summary>Indicates whether or not to block the user from accessing the camera of the device. Requires a supervised device for iOS 13 and later.</summary>
        public bool? CameraBlocked {
            get { return BackingStore?.Get<bool?>(nameof(CameraBlocked)); }
            set { BackingStore?.Set(nameof(CameraBlocked), value); }
        }
        /// <summary>Indicates whether or not to block data roaming.</summary>
        public bool? CellularBlockDataRoaming {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockDataRoaming)); }
            set { BackingStore?.Set(nameof(CellularBlockDataRoaming), value); }
        }
        /// <summary>Indicates whether or not to block global background fetch while roaming.</summary>
        public bool? CellularBlockGlobalBackgroundFetchWhileRoaming {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockGlobalBackgroundFetchWhileRoaming)); }
            set { BackingStore?.Set(nameof(CellularBlockGlobalBackgroundFetchWhileRoaming), value); }
        }
        /// <summary>Indicates whether or not to allow changes to cellular app data usage settings when the device is in supervised mode.</summary>
        public bool? CellularBlockPerAppDataModification {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockPerAppDataModification)); }
            set { BackingStore?.Set(nameof(CellularBlockPerAppDataModification), value); }
        }
        /// <summary>Indicates whether or not to block Personal Hotspot.</summary>
        public bool? CellularBlockPersonalHotspot {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockPersonalHotspot)); }
            set { BackingStore?.Set(nameof(CellularBlockPersonalHotspot), value); }
        }
        /// <summary>Indicates whether or not to block voice roaming.</summary>
        public bool? CellularBlockVoiceRoaming {
            get { return BackingStore?.Get<bool?>(nameof(CellularBlockVoiceRoaming)); }
            set { BackingStore?.Set(nameof(CellularBlockVoiceRoaming), value); }
        }
        /// <summary>Indicates whether or not to block untrusted TLS certificates.</summary>
        public bool? CertificatesBlockUntrustedTlsCertificates {
            get { return BackingStore?.Get<bool?>(nameof(CertificatesBlockUntrustedTlsCertificates)); }
            set { BackingStore?.Set(nameof(CertificatesBlockUntrustedTlsCertificates), value); }
        }
        /// <summary>Indicates whether or not to allow remote screen observation by Classroom app when the device is in supervised mode (iOS 9.3 and later).</summary>
        public bool? ClassroomAppBlockRemoteScreenObservation {
            get { return BackingStore?.Get<bool?>(nameof(ClassroomAppBlockRemoteScreenObservation)); }
            set { BackingStore?.Set(nameof(ClassroomAppBlockRemoteScreenObservation), value); }
        }
        /// <summary>Indicates whether or not to automatically give permission to the teacher of a managed course on the Classroom app to view a student&apos;s screen without prompting when the device is in supervised mode.</summary>
        public bool? ClassroomAppForceUnpromptedScreenObservation {
            get { return BackingStore?.Get<bool?>(nameof(ClassroomAppForceUnpromptedScreenObservation)); }
            set { BackingStore?.Set(nameof(ClassroomAppForceUnpromptedScreenObservation), value); }
        }
        /// <summary>List that is in the AppComplianceList. Possible values are: none, appsInListCompliant, appsNotInListCompliant.</summary>
        public AppListType? CompliantAppListType {
            get { return BackingStore?.Get<AppListType?>(nameof(CompliantAppListType)); }
            set { BackingStore?.Set(nameof(CompliantAppListType), value); }
        }
        /// <summary>List of apps in the compliance (either allow list or block list, controlled by CompliantAppListType). This collection can contain a maximum of 10000 elements.</summary>
        public List<AppListItem> CompliantAppsList {
            get { return BackingStore?.Get<List<AppListItem>>(nameof(CompliantAppsList)); }
            set { BackingStore?.Set(nameof(CompliantAppsList), value); }
        }
        /// <summary>Indicates whether or not to block the user from installing configuration profiles and certificates interactively when the device is in supervised mode.</summary>
        public bool? ConfigurationProfileBlockChanges {
            get { return BackingStore?.Get<bool?>(nameof(ConfigurationProfileBlockChanges)); }
            set { BackingStore?.Set(nameof(ConfigurationProfileBlockChanges), value); }
        }
        /// <summary>Indicates whether or not to block definition lookup when the device is in supervised mode (iOS 8.1.3 and later ).</summary>
        public bool? DefinitionLookupBlocked {
            get { return BackingStore?.Get<bool?>(nameof(DefinitionLookupBlocked)); }
            set { BackingStore?.Set(nameof(DefinitionLookupBlocked), value); }
        }
        /// <summary>Indicates whether or not to allow the user to enables restrictions in the device settings when the device is in supervised mode.</summary>
        public bool? DeviceBlockEnableRestrictions {
            get { return BackingStore?.Get<bool?>(nameof(DeviceBlockEnableRestrictions)); }
            set { BackingStore?.Set(nameof(DeviceBlockEnableRestrictions), value); }
        }
        /// <summary>Indicates whether or not to allow the use of the &apos;Erase all content and settings&apos; option on the device when the device is in supervised mode.</summary>
        public bool? DeviceBlockEraseContentAndSettings {
            get { return BackingStore?.Get<bool?>(nameof(DeviceBlockEraseContentAndSettings)); }
            set { BackingStore?.Set(nameof(DeviceBlockEraseContentAndSettings), value); }
        }
        /// <summary>Indicates whether or not to allow device name modification when the device is in supervised mode (iOS 9.0 and later).</summary>
        public bool? DeviceBlockNameModification {
            get { return BackingStore?.Get<bool?>(nameof(DeviceBlockNameModification)); }
            set { BackingStore?.Set(nameof(DeviceBlockNameModification), value); }
        }
        /// <summary>Indicates whether or not to block diagnostic data submission.</summary>
        public bool? DiagnosticDataBlockSubmission {
            get { return BackingStore?.Get<bool?>(nameof(DiagnosticDataBlockSubmission)); }
            set { BackingStore?.Set(nameof(DiagnosticDataBlockSubmission), value); }
        }
        /// <summary>Indicates whether or not to allow diagnostics submission settings modification when the device is in supervised mode (iOS 9.3.2 and later).</summary>
        public bool? DiagnosticDataBlockSubmissionModification {
            get { return BackingStore?.Get<bool?>(nameof(DiagnosticDataBlockSubmissionModification)); }
            set { BackingStore?.Set(nameof(DiagnosticDataBlockSubmissionModification), value); }
        }
        /// <summary>Indicates whether or not to block the user from viewing managed documents in unmanaged apps.</summary>
        public bool? DocumentsBlockManagedDocumentsInUnmanagedApps {
            get { return BackingStore?.Get<bool?>(nameof(DocumentsBlockManagedDocumentsInUnmanagedApps)); }
            set { BackingStore?.Set(nameof(DocumentsBlockManagedDocumentsInUnmanagedApps), value); }
        }
        /// <summary>Indicates whether or not to block the user from viewing unmanaged documents in managed apps.</summary>
        public bool? DocumentsBlockUnmanagedDocumentsInManagedApps {
            get { return BackingStore?.Get<bool?>(nameof(DocumentsBlockUnmanagedDocumentsInManagedApps)); }
            set { BackingStore?.Set(nameof(DocumentsBlockUnmanagedDocumentsInManagedApps), value); }
        }
        /// <summary>An email address lacking a suffix that matches any of these strings will be considered out-of-domain.</summary>
        public List<string> EmailInDomainSuffixes {
            get { return BackingStore?.Get<List<string>>(nameof(EmailInDomainSuffixes)); }
            set { BackingStore?.Set(nameof(EmailInDomainSuffixes), value); }
        }
        /// <summary>Indicates whether or not to block the user from trusting an enterprise app.</summary>
        public bool? EnterpriseAppBlockTrust {
            get { return BackingStore?.Get<bool?>(nameof(EnterpriseAppBlockTrust)); }
            set { BackingStore?.Set(nameof(EnterpriseAppBlockTrust), value); }
        }
        /// <summary>[Deprecated] Configuring this setting and setting the value to &apos;true&apos; has no effect on the device.</summary>
        public bool? EnterpriseAppBlockTrustModification {
            get { return BackingStore?.Get<bool?>(nameof(EnterpriseAppBlockTrustModification)); }
            set { BackingStore?.Set(nameof(EnterpriseAppBlockTrustModification), value); }
        }
        /// <summary>Indicates whether or not to block the user from using FaceTime. Requires a supervised device for iOS 13 and later.</summary>
        public bool? FaceTimeBlocked {
            get { return BackingStore?.Get<bool?>(nameof(FaceTimeBlocked)); }
            set { BackingStore?.Set(nameof(FaceTimeBlocked), value); }
        }
        /// <summary>Indicates whether or not to block changes to Find My Friends when the device is in supervised mode.</summary>
        public bool? FindMyFriendsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(FindMyFriendsBlocked)); }
            set { BackingStore?.Set(nameof(FindMyFriendsBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the user from using Game Center when the device is in supervised mode.</summary>
        public bool? GameCenterBlocked {
            get { return BackingStore?.Get<bool?>(nameof(GameCenterBlocked)); }
            set { BackingStore?.Set(nameof(GameCenterBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the user from having friends in Game Center. Requires a supervised device for iOS 13 and later.</summary>
        public bool? GamingBlockGameCenterFriends {
            get { return BackingStore?.Get<bool?>(nameof(GamingBlockGameCenterFriends)); }
            set { BackingStore?.Set(nameof(GamingBlockGameCenterFriends), value); }
        }
        /// <summary>Indicates whether or not to block the user from using multiplayer gaming. Requires a supervised device for iOS 13 and later.</summary>
        public bool? GamingBlockMultiplayer {
            get { return BackingStore?.Get<bool?>(nameof(GamingBlockMultiplayer)); }
            set { BackingStore?.Set(nameof(GamingBlockMultiplayer), value); }
        }
        /// <summary>indicates whether or not to allow host pairing to control the devices an iOS device can pair with when the iOS device is in supervised mode.</summary>
        public bool? HostPairingBlocked {
            get { return BackingStore?.Get<bool?>(nameof(HostPairingBlocked)); }
            set { BackingStore?.Set(nameof(HostPairingBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the user from using the iBooks Store when the device is in supervised mode.</summary>
        public bool? IBooksStoreBlocked {
            get { return BackingStore?.Get<bool?>(nameof(IBooksStoreBlocked)); }
            set { BackingStore?.Set(nameof(IBooksStoreBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the user from downloading media from the iBookstore that has been tagged as erotica.</summary>
        public bool? IBooksStoreBlockErotica {
            get { return BackingStore?.Get<bool?>(nameof(IBooksStoreBlockErotica)); }
            set { BackingStore?.Set(nameof(IBooksStoreBlockErotica), value); }
        }
        /// <summary>Indicates whether or not to block the user from continuing work they started on iOS device to another iOS or macOS device.</summary>
        public bool? ICloudBlockActivityContinuation {
            get { return BackingStore?.Get<bool?>(nameof(ICloudBlockActivityContinuation)); }
            set { BackingStore?.Set(nameof(ICloudBlockActivityContinuation), value); }
        }
        /// <summary>Indicates whether or not to block iCloud backup. Requires a supervised device for iOS 13 and later.</summary>
        public bool? ICloudBlockBackup {
            get { return BackingStore?.Get<bool?>(nameof(ICloudBlockBackup)); }
            set { BackingStore?.Set(nameof(ICloudBlockBackup), value); }
        }
        /// <summary>Indicates whether or not to block iCloud document sync. Requires a supervised device for iOS 13 and later.</summary>
        public bool? ICloudBlockDocumentSync {
            get { return BackingStore?.Get<bool?>(nameof(ICloudBlockDocumentSync)); }
            set { BackingStore?.Set(nameof(ICloudBlockDocumentSync), value); }
        }
        /// <summary>Indicates whether or not to block Managed Apps Cloud Sync.</summary>
        public bool? ICloudBlockManagedAppsSync {
            get { return BackingStore?.Get<bool?>(nameof(ICloudBlockManagedAppsSync)); }
            set { BackingStore?.Set(nameof(ICloudBlockManagedAppsSync), value); }
        }
        /// <summary>Indicates whether or not to block iCloud Photo Library.</summary>
        public bool? ICloudBlockPhotoLibrary {
            get { return BackingStore?.Get<bool?>(nameof(ICloudBlockPhotoLibrary)); }
            set { BackingStore?.Set(nameof(ICloudBlockPhotoLibrary), value); }
        }
        /// <summary>Indicates whether or not to block iCloud Photo Stream Sync.</summary>
        public bool? ICloudBlockPhotoStreamSync {
            get { return BackingStore?.Get<bool?>(nameof(ICloudBlockPhotoStreamSync)); }
            set { BackingStore?.Set(nameof(ICloudBlockPhotoStreamSync), value); }
        }
        /// <summary>Indicates whether or not to block Shared Photo Stream.</summary>
        public bool? ICloudBlockSharedPhotoStream {
            get { return BackingStore?.Get<bool?>(nameof(ICloudBlockSharedPhotoStream)); }
            set { BackingStore?.Set(nameof(ICloudBlockSharedPhotoStream), value); }
        }
        /// <summary>Indicates whether or not to require backups to iCloud be encrypted.</summary>
        public bool? ICloudRequireEncryptedBackup {
            get { return BackingStore?.Get<bool?>(nameof(ICloudRequireEncryptedBackup)); }
            set { BackingStore?.Set(nameof(ICloudRequireEncryptedBackup), value); }
        }
        /// <summary>Indicates whether or not to block the user from accessing explicit content in iTunes and the App Store. Requires a supervised device for iOS 13 and later.</summary>
        public bool? ITunesBlockExplicitContent {
            get { return BackingStore?.Get<bool?>(nameof(ITunesBlockExplicitContent)); }
            set { BackingStore?.Set(nameof(ITunesBlockExplicitContent), value); }
        }
        /// <summary>Indicates whether or not to block Music service and revert Music app to classic mode when the device is in supervised mode (iOS 9.3 and later and macOS 10.12 and later).</summary>
        public bool? ITunesBlockMusicService {
            get { return BackingStore?.Get<bool?>(nameof(ITunesBlockMusicService)); }
            set { BackingStore?.Set(nameof(ITunesBlockMusicService), value); }
        }
        /// <summary>Indicates whether or not to block the user from using iTunes Radio when the device is in supervised mode (iOS 9.3 and later).</summary>
        public bool? ITunesBlockRadio {
            get { return BackingStore?.Get<bool?>(nameof(ITunesBlockRadio)); }
            set { BackingStore?.Set(nameof(ITunesBlockRadio), value); }
        }
        /// <summary>Indicates whether or not to block keyboard auto-correction when the device is in supervised mode (iOS 8.1.3 and later).</summary>
        public bool? KeyboardBlockAutoCorrect {
            get { return BackingStore?.Get<bool?>(nameof(KeyboardBlockAutoCorrect)); }
            set { BackingStore?.Set(nameof(KeyboardBlockAutoCorrect), value); }
        }
        /// <summary>Indicates whether or not to block the user from using dictation input when the device is in supervised mode.</summary>
        public bool? KeyboardBlockDictation {
            get { return BackingStore?.Get<bool?>(nameof(KeyboardBlockDictation)); }
            set { BackingStore?.Set(nameof(KeyboardBlockDictation), value); }
        }
        /// <summary>Indicates whether or not to block predictive keyboards when device is in supervised mode (iOS 8.1.3 and later).</summary>
        public bool? KeyboardBlockPredictive {
            get { return BackingStore?.Get<bool?>(nameof(KeyboardBlockPredictive)); }
            set { BackingStore?.Set(nameof(KeyboardBlockPredictive), value); }
        }
        /// <summary>Indicates whether or not to block keyboard shortcuts when the device is in supervised mode (iOS 9.0 and later).</summary>
        public bool? KeyboardBlockShortcuts {
            get { return BackingStore?.Get<bool?>(nameof(KeyboardBlockShortcuts)); }
            set { BackingStore?.Set(nameof(KeyboardBlockShortcuts), value); }
        }
        /// <summary>Indicates whether or not to block keyboard spell-checking when the device is in supervised mode (iOS 8.1.3 and later).</summary>
        public bool? KeyboardBlockSpellCheck {
            get { return BackingStore?.Get<bool?>(nameof(KeyboardBlockSpellCheck)); }
            set { BackingStore?.Set(nameof(KeyboardBlockSpellCheck), value); }
        }
        /// <summary>Indicates whether or not to allow assistive speak while in kiosk mode.</summary>
        public bool? KioskModeAllowAssistiveSpeak {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAllowAssistiveSpeak)); }
            set { BackingStore?.Set(nameof(KioskModeAllowAssistiveSpeak), value); }
        }
        /// <summary>Indicates whether or not to allow access to the Assistive Touch Settings while in kiosk mode.</summary>
        public bool? KioskModeAllowAssistiveTouchSettings {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAllowAssistiveTouchSettings)); }
            set { BackingStore?.Set(nameof(KioskModeAllowAssistiveTouchSettings), value); }
        }
        /// <summary>Indicates whether or not to allow device auto lock while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockAutoLock instead.</summary>
        public bool? KioskModeAllowAutoLock {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAllowAutoLock)); }
            set { BackingStore?.Set(nameof(KioskModeAllowAutoLock), value); }
        }
        /// <summary>Indicates whether or not to allow access to the Color Inversion Settings while in kiosk mode.</summary>
        public bool? KioskModeAllowColorInversionSettings {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAllowColorInversionSettings)); }
            set { BackingStore?.Set(nameof(KioskModeAllowColorInversionSettings), value); }
        }
        /// <summary>Indicates whether or not to allow use of the ringer switch while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockRingerSwitch instead.</summary>
        public bool? KioskModeAllowRingerSwitch {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAllowRingerSwitch)); }
            set { BackingStore?.Set(nameof(KioskModeAllowRingerSwitch), value); }
        }
        /// <summary>Indicates whether or not to allow screen rotation while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockScreenRotation instead.</summary>
        public bool? KioskModeAllowScreenRotation {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAllowScreenRotation)); }
            set { BackingStore?.Set(nameof(KioskModeAllowScreenRotation), value); }
        }
        /// <summary>Indicates whether or not to allow use of the sleep button while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockSleepButton instead.</summary>
        public bool? KioskModeAllowSleepButton {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAllowSleepButton)); }
            set { BackingStore?.Set(nameof(KioskModeAllowSleepButton), value); }
        }
        /// <summary>Indicates whether or not to allow use of the touchscreen while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockTouchscreen instead.</summary>
        public bool? KioskModeAllowTouchscreen {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAllowTouchscreen)); }
            set { BackingStore?.Set(nameof(KioskModeAllowTouchscreen), value); }
        }
        /// <summary>Indicates whether or not to allow access to the voice over settings while in kiosk mode.</summary>
        public bool? KioskModeAllowVoiceOverSettings {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAllowVoiceOverSettings)); }
            set { BackingStore?.Set(nameof(KioskModeAllowVoiceOverSettings), value); }
        }
        /// <summary>Indicates whether or not to allow use of the volume buttons while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockVolumeButtons instead.</summary>
        public bool? KioskModeAllowVolumeButtons {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAllowVolumeButtons)); }
            set { BackingStore?.Set(nameof(KioskModeAllowVolumeButtons), value); }
        }
        /// <summary>Indicates whether or not to allow access to the zoom settings while in kiosk mode.</summary>
        public bool? KioskModeAllowZoomSettings {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeAllowZoomSettings)); }
            set { BackingStore?.Set(nameof(KioskModeAllowZoomSettings), value); }
        }
        /// <summary>URL in the app store to the app to use for kiosk mode. Use if KioskModeManagedAppId is not known.</summary>
        public string KioskModeAppStoreUrl {
            get { return BackingStore?.Get<string>(nameof(KioskModeAppStoreUrl)); }
            set { BackingStore?.Set(nameof(KioskModeAppStoreUrl), value); }
        }
        /// <summary>ID for built-in apps to use for kiosk mode. Used when KioskModeManagedAppId and KioskModeAppStoreUrl are not set.</summary>
        public string KioskModeBuiltInAppId {
            get { return BackingStore?.Get<string>(nameof(KioskModeBuiltInAppId)); }
            set { BackingStore?.Set(nameof(KioskModeBuiltInAppId), value); }
        }
        /// <summary>Managed app id of the app to use for kiosk mode. If KioskModeManagedAppId is specified then KioskModeAppStoreUrl will be ignored.</summary>
        public string KioskModeManagedAppId {
            get { return BackingStore?.Get<string>(nameof(KioskModeManagedAppId)); }
            set { BackingStore?.Set(nameof(KioskModeManagedAppId), value); }
        }
        /// <summary>Indicates whether or not to require assistive touch while in kiosk mode.</summary>
        public bool? KioskModeRequireAssistiveTouch {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeRequireAssistiveTouch)); }
            set { BackingStore?.Set(nameof(KioskModeRequireAssistiveTouch), value); }
        }
        /// <summary>Indicates whether or not to require color inversion while in kiosk mode.</summary>
        public bool? KioskModeRequireColorInversion {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeRequireColorInversion)); }
            set { BackingStore?.Set(nameof(KioskModeRequireColorInversion), value); }
        }
        /// <summary>Indicates whether or not to require mono audio while in kiosk mode.</summary>
        public bool? KioskModeRequireMonoAudio {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeRequireMonoAudio)); }
            set { BackingStore?.Set(nameof(KioskModeRequireMonoAudio), value); }
        }
        /// <summary>Indicates whether or not to require voice over while in kiosk mode.</summary>
        public bool? KioskModeRequireVoiceOver {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeRequireVoiceOver)); }
            set { BackingStore?.Set(nameof(KioskModeRequireVoiceOver), value); }
        }
        /// <summary>Indicates whether or not to require zoom while in kiosk mode.</summary>
        public bool? KioskModeRequireZoom {
            get { return BackingStore?.Get<bool?>(nameof(KioskModeRequireZoom)); }
            set { BackingStore?.Set(nameof(KioskModeRequireZoom), value); }
        }
        /// <summary>Indicates whether or not to block the user from using control center on the lock screen.</summary>
        public bool? LockScreenBlockControlCenter {
            get { return BackingStore?.Get<bool?>(nameof(LockScreenBlockControlCenter)); }
            set { BackingStore?.Set(nameof(LockScreenBlockControlCenter), value); }
        }
        /// <summary>Indicates whether or not to block the user from using the notification view on the lock screen.</summary>
        public bool? LockScreenBlockNotificationView {
            get { return BackingStore?.Get<bool?>(nameof(LockScreenBlockNotificationView)); }
            set { BackingStore?.Set(nameof(LockScreenBlockNotificationView), value); }
        }
        /// <summary>Indicates whether or not to block the user from using passbook when the device is locked.</summary>
        public bool? LockScreenBlockPassbook {
            get { return BackingStore?.Get<bool?>(nameof(LockScreenBlockPassbook)); }
            set { BackingStore?.Set(nameof(LockScreenBlockPassbook), value); }
        }
        /// <summary>Indicates whether or not to block the user from using the Today View on the lock screen.</summary>
        public bool? LockScreenBlockTodayView {
            get { return BackingStore?.Get<bool?>(nameof(LockScreenBlockTodayView)); }
            set { BackingStore?.Set(nameof(LockScreenBlockTodayView), value); }
        }
        /// <summary>Media content rating settings for Apps. Possible values are: allAllowed, allBlocked, agesAbove4, agesAbove9, agesAbove12, agesAbove17.</summary>
        public RatingAppsType? MediaContentRatingApps {
            get { return BackingStore?.Get<RatingAppsType?>(nameof(MediaContentRatingApps)); }
            set { BackingStore?.Set(nameof(MediaContentRatingApps), value); }
        }
        /// <summary>Media content rating settings for Australia</summary>
        public Microsoft.Graph.Models.MediaContentRatingAustralia MediaContentRatingAustralia {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaContentRatingAustralia>(nameof(MediaContentRatingAustralia)); }
            set { BackingStore?.Set(nameof(MediaContentRatingAustralia), value); }
        }
        /// <summary>Media content rating settings for Canada</summary>
        public Microsoft.Graph.Models.MediaContentRatingCanada MediaContentRatingCanada {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaContentRatingCanada>(nameof(MediaContentRatingCanada)); }
            set { BackingStore?.Set(nameof(MediaContentRatingCanada), value); }
        }
        /// <summary>Media content rating settings for France</summary>
        public Microsoft.Graph.Models.MediaContentRatingFrance MediaContentRatingFrance {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaContentRatingFrance>(nameof(MediaContentRatingFrance)); }
            set { BackingStore?.Set(nameof(MediaContentRatingFrance), value); }
        }
        /// <summary>Media content rating settings for Germany</summary>
        public Microsoft.Graph.Models.MediaContentRatingGermany MediaContentRatingGermany {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaContentRatingGermany>(nameof(MediaContentRatingGermany)); }
            set { BackingStore?.Set(nameof(MediaContentRatingGermany), value); }
        }
        /// <summary>Media content rating settings for Ireland</summary>
        public Microsoft.Graph.Models.MediaContentRatingIreland MediaContentRatingIreland {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaContentRatingIreland>(nameof(MediaContentRatingIreland)); }
            set { BackingStore?.Set(nameof(MediaContentRatingIreland), value); }
        }
        /// <summary>Media content rating settings for Japan</summary>
        public Microsoft.Graph.Models.MediaContentRatingJapan MediaContentRatingJapan {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaContentRatingJapan>(nameof(MediaContentRatingJapan)); }
            set { BackingStore?.Set(nameof(MediaContentRatingJapan), value); }
        }
        /// <summary>Media content rating settings for New Zealand</summary>
        public Microsoft.Graph.Models.MediaContentRatingNewZealand MediaContentRatingNewZealand {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaContentRatingNewZealand>(nameof(MediaContentRatingNewZealand)); }
            set { BackingStore?.Set(nameof(MediaContentRatingNewZealand), value); }
        }
        /// <summary>Media content rating settings for United Kingdom</summary>
        public Microsoft.Graph.Models.MediaContentRatingUnitedKingdom MediaContentRatingUnitedKingdom {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaContentRatingUnitedKingdom>(nameof(MediaContentRatingUnitedKingdom)); }
            set { BackingStore?.Set(nameof(MediaContentRatingUnitedKingdom), value); }
        }
        /// <summary>Media content rating settings for United States</summary>
        public Microsoft.Graph.Models.MediaContentRatingUnitedStates MediaContentRatingUnitedStates {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaContentRatingUnitedStates>(nameof(MediaContentRatingUnitedStates)); }
            set { BackingStore?.Set(nameof(MediaContentRatingUnitedStates), value); }
        }
        /// <summary>Indicates whether or not to block the user from using the Messages app on the supervised device.</summary>
        public bool? MessagesBlocked {
            get { return BackingStore?.Get<bool?>(nameof(MessagesBlocked)); }
            set { BackingStore?.Set(nameof(MessagesBlocked), value); }
        }
        /// <summary>List of managed apps and the network rules that applies to them. This collection can contain a maximum of 1000 elements.</summary>
        public List<IosNetworkUsageRule> NetworkUsageRules {
            get { return BackingStore?.Get<List<IosNetworkUsageRule>>(nameof(NetworkUsageRules)); }
            set { BackingStore?.Set(nameof(NetworkUsageRules), value); }
        }
        /// <summary>Indicates whether or not to allow notifications settings modification (iOS 9.3 and later).</summary>
        public bool? NotificationsBlockSettingsModification {
            get { return BackingStore?.Get<bool?>(nameof(NotificationsBlockSettingsModification)); }
            set { BackingStore?.Set(nameof(NotificationsBlockSettingsModification), value); }
        }
        /// <summary>Block modification of registered Touch ID fingerprints when in supervised mode.</summary>
        public bool? PasscodeBlockFingerprintModification {
            get { return BackingStore?.Get<bool?>(nameof(PasscodeBlockFingerprintModification)); }
            set { BackingStore?.Set(nameof(PasscodeBlockFingerprintModification), value); }
        }
        /// <summary>Indicates whether or not to block fingerprint unlock.</summary>
        public bool? PasscodeBlockFingerprintUnlock {
            get { return BackingStore?.Get<bool?>(nameof(PasscodeBlockFingerprintUnlock)); }
            set { BackingStore?.Set(nameof(PasscodeBlockFingerprintUnlock), value); }
        }
        /// <summary>Indicates whether or not to allow passcode modification on the supervised device (iOS 9.0 and later).</summary>
        public bool? PasscodeBlockModification {
            get { return BackingStore?.Get<bool?>(nameof(PasscodeBlockModification)); }
            set { BackingStore?.Set(nameof(PasscodeBlockModification), value); }
        }
        /// <summary>Indicates whether or not to block simple passcodes.</summary>
        public bool? PasscodeBlockSimple {
            get { return BackingStore?.Get<bool?>(nameof(PasscodeBlockSimple)); }
            set { BackingStore?.Set(nameof(PasscodeBlockSimple), value); }
        }
        /// <summary>Number of days before the passcode expires. Valid values 1 to 65535</summary>
        public int? PasscodeExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasscodeExpirationDays)); }
            set { BackingStore?.Set(nameof(PasscodeExpirationDays), value); }
        }
        /// <summary>Number of character sets a passcode must contain. Valid values 0 to 4</summary>
        public int? PasscodeMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>(nameof(PasscodeMinimumCharacterSetCount)); }
            set { BackingStore?.Set(nameof(PasscodeMinimumCharacterSetCount), value); }
        }
        /// <summary>Minimum length of passcode. Valid values 4 to 14</summary>
        public int? PasscodeMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasscodeMinimumLength)); }
            set { BackingStore?.Set(nameof(PasscodeMinimumLength), value); }
        }
        /// <summary>Minutes of inactivity before a passcode is required.</summary>
        public int? PasscodeMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>(nameof(PasscodeMinutesOfInactivityBeforeLock)); }
            set { BackingStore?.Set(nameof(PasscodeMinutesOfInactivityBeforeLock), value); }
        }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasscodeMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>(nameof(PasscodeMinutesOfInactivityBeforeScreenTimeout)); }
            set { BackingStore?.Set(nameof(PasscodeMinutesOfInactivityBeforeScreenTimeout), value); }
        }
        /// <summary>Number of previous passcodes to block. Valid values 1 to 24</summary>
        public int? PasscodePreviousPasscodeBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PasscodePreviousPasscodeBlockCount)); }
            set { BackingStore?.Set(nameof(PasscodePreviousPasscodeBlockCount), value); }
        }
        /// <summary>Indicates whether or not to require a passcode.</summary>
        public bool? PasscodeRequired {
            get { return BackingStore?.Get<bool?>(nameof(PasscodeRequired)); }
            set { BackingStore?.Set(nameof(PasscodeRequired), value); }
        }
        /// <summary>Type of passcode that is required. Possible values are: deviceDefault, alphanumeric, numeric.</summary>
        public RequiredPasswordType? PasscodeRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>(nameof(PasscodeRequiredType)); }
            set { BackingStore?.Set(nameof(PasscodeRequiredType), value); }
        }
        /// <summary>Number of sign in failures allowed before wiping the device. Valid values 2 to 11</summary>
        public int? PasscodeSignInFailureCountBeforeWipe {
            get { return BackingStore?.Get<int?>(nameof(PasscodeSignInFailureCountBeforeWipe)); }
            set { BackingStore?.Set(nameof(PasscodeSignInFailureCountBeforeWipe), value); }
        }
        /// <summary>Indicates whether or not to block the user from using podcasts on the supervised device (iOS 8.0 and later).</summary>
        public bool? PodcastsBlocked {
            get { return BackingStore?.Get<bool?>(nameof(PodcastsBlocked)); }
            set { BackingStore?.Set(nameof(PodcastsBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the user from using Auto fill in Safari. Requires a supervised device for iOS 13 and later.</summary>
        public bool? SafariBlockAutofill {
            get { return BackingStore?.Get<bool?>(nameof(SafariBlockAutofill)); }
            set { BackingStore?.Set(nameof(SafariBlockAutofill), value); }
        }
        /// <summary>Indicates whether or not to block the user from using Safari. Requires a supervised device for iOS 13 and later.</summary>
        public bool? SafariBlocked {
            get { return BackingStore?.Get<bool?>(nameof(SafariBlocked)); }
            set { BackingStore?.Set(nameof(SafariBlocked), value); }
        }
        /// <summary>Indicates whether or not to block JavaScript in Safari.</summary>
        public bool? SafariBlockJavaScript {
            get { return BackingStore?.Get<bool?>(nameof(SafariBlockJavaScript)); }
            set { BackingStore?.Set(nameof(SafariBlockJavaScript), value); }
        }
        /// <summary>Indicates whether or not to block popups in Safari.</summary>
        public bool? SafariBlockPopups {
            get { return BackingStore?.Get<bool?>(nameof(SafariBlockPopups)); }
            set { BackingStore?.Set(nameof(SafariBlockPopups), value); }
        }
        /// <summary>Cookie settings for Safari. Possible values are: browserDefault, blockAlways, allowCurrentWebSite, allowFromWebsitesVisited, allowAlways.</summary>
        public WebBrowserCookieSettings? SafariCookieSettings {
            get { return BackingStore?.Get<WebBrowserCookieSettings?>(nameof(SafariCookieSettings)); }
            set { BackingStore?.Set(nameof(SafariCookieSettings), value); }
        }
        /// <summary>URLs matching the patterns listed here will be considered managed.</summary>
        public List<string> SafariManagedDomains {
            get { return BackingStore?.Get<List<string>>(nameof(SafariManagedDomains)); }
            set { BackingStore?.Set(nameof(SafariManagedDomains), value); }
        }
        /// <summary>Users can save passwords in Safari only from URLs matching the patterns listed here. Applies to devices in supervised mode (iOS 9.3 and later).</summary>
        public List<string> SafariPasswordAutoFillDomains {
            get { return BackingStore?.Get<List<string>>(nameof(SafariPasswordAutoFillDomains)); }
            set { BackingStore?.Set(nameof(SafariPasswordAutoFillDomains), value); }
        }
        /// <summary>Indicates whether or not to require fraud warning in Safari.</summary>
        public bool? SafariRequireFraudWarning {
            get { return BackingStore?.Get<bool?>(nameof(SafariRequireFraudWarning)); }
            set { BackingStore?.Set(nameof(SafariRequireFraudWarning), value); }
        }
        /// <summary>Indicates whether or not to block the user from taking Screenshots.</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>(nameof(ScreenCaptureBlocked)); }
            set { BackingStore?.Set(nameof(ScreenCaptureBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the user from using Siri.</summary>
        public bool? SiriBlocked {
            get { return BackingStore?.Get<bool?>(nameof(SiriBlocked)); }
            set { BackingStore?.Set(nameof(SiriBlocked), value); }
        }
        /// <summary>Indicates whether or not to block the user from using Siri when locked.</summary>
        public bool? SiriBlockedWhenLocked {
            get { return BackingStore?.Get<bool?>(nameof(SiriBlockedWhenLocked)); }
            set { BackingStore?.Set(nameof(SiriBlockedWhenLocked), value); }
        }
        /// <summary>Indicates whether or not to block Siri from querying user-generated content when used on a supervised device.</summary>
        public bool? SiriBlockUserGeneratedContent {
            get { return BackingStore?.Get<bool?>(nameof(SiriBlockUserGeneratedContent)); }
            set { BackingStore?.Set(nameof(SiriBlockUserGeneratedContent), value); }
        }
        /// <summary>Indicates whether or not to prevent Siri from dictating, or speaking profane language on supervised device.</summary>
        public bool? SiriRequireProfanityFilter {
            get { return BackingStore?.Get<bool?>(nameof(SiriRequireProfanityFilter)); }
            set { BackingStore?.Set(nameof(SiriRequireProfanityFilter), value); }
        }
        /// <summary>Indicates whether or not to block Spotlight search from returning internet results on supervised device.</summary>
        public bool? SpotlightBlockInternetResults {
            get { return BackingStore?.Get<bool?>(nameof(SpotlightBlockInternetResults)); }
            set { BackingStore?.Set(nameof(SpotlightBlockInternetResults), value); }
        }
        /// <summary>Indicates whether or not to block voice dialing.</summary>
        public bool? VoiceDialingBlocked {
            get { return BackingStore?.Get<bool?>(nameof(VoiceDialingBlocked)); }
            set { BackingStore?.Set(nameof(VoiceDialingBlocked), value); }
        }
        /// <summary>Indicates whether or not to allow wallpaper modification on supervised device (iOS 9.0 and later) .</summary>
        public bool? WallpaperBlockModification {
            get { return BackingStore?.Get<bool?>(nameof(WallpaperBlockModification)); }
            set { BackingStore?.Set(nameof(WallpaperBlockModification), value); }
        }
        /// <summary>Indicates whether or not to force the device to use only Wi-Fi networks from configuration profiles when the device is in supervised mode. Available for devices running iOS and iPadOS versions 14.4 and earlier. Devices running 14.5+ should use the setting, &apos;WiFiConnectToAllowedNetworksOnlyForced.</summary>
        public bool? WiFiConnectOnlyToConfiguredNetworks {
            get { return BackingStore?.Get<bool?>(nameof(WiFiConnectOnlyToConfiguredNetworks)); }
            set { BackingStore?.Set(nameof(WiFiConnectOnlyToConfiguredNetworks), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountBlockModification", n => { AccountBlockModification = n.GetBoolValue(); } },
                {"activationLockAllowWhenSupervised", n => { ActivationLockAllowWhenSupervised = n.GetBoolValue(); } },
                {"airDropBlocked", n => { AirDropBlocked = n.GetBoolValue(); } },
                {"airDropForceUnmanagedDropTarget", n => { AirDropForceUnmanagedDropTarget = n.GetBoolValue(); } },
                {"airPlayForcePairingPasswordForOutgoingRequests", n => { AirPlayForcePairingPasswordForOutgoingRequests = n.GetBoolValue(); } },
                {"appleNewsBlocked", n => { AppleNewsBlocked = n.GetBoolValue(); } },
                {"appleWatchBlockPairing", n => { AppleWatchBlockPairing = n.GetBoolValue(); } },
                {"appleWatchForceWristDetection", n => { AppleWatchForceWristDetection = n.GetBoolValue(); } },
                {"appsSingleAppModeList", n => { AppsSingleAppModeList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"appStoreBlockAutomaticDownloads", n => { AppStoreBlockAutomaticDownloads = n.GetBoolValue(); } },
                {"appStoreBlocked", n => { AppStoreBlocked = n.GetBoolValue(); } },
                {"appStoreBlockInAppPurchases", n => { AppStoreBlockInAppPurchases = n.GetBoolValue(); } },
                {"appStoreBlockUIAppInstallation", n => { AppStoreBlockUIAppInstallation = n.GetBoolValue(); } },
                {"appStoreRequirePassword", n => { AppStoreRequirePassword = n.GetBoolValue(); } },
                {"appsVisibilityList", n => { AppsVisibilityList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"appsVisibilityListType", n => { AppsVisibilityListType = n.GetEnumValue<AppListType>(); } },
                {"bluetoothBlockModification", n => { BluetoothBlockModification = n.GetBoolValue(); } },
                {"cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                {"cellularBlockDataRoaming", n => { CellularBlockDataRoaming = n.GetBoolValue(); } },
                {"cellularBlockGlobalBackgroundFetchWhileRoaming", n => { CellularBlockGlobalBackgroundFetchWhileRoaming = n.GetBoolValue(); } },
                {"cellularBlockPerAppDataModification", n => { CellularBlockPerAppDataModification = n.GetBoolValue(); } },
                {"cellularBlockPersonalHotspot", n => { CellularBlockPersonalHotspot = n.GetBoolValue(); } },
                {"cellularBlockVoiceRoaming", n => { CellularBlockVoiceRoaming = n.GetBoolValue(); } },
                {"certificatesBlockUntrustedTlsCertificates", n => { CertificatesBlockUntrustedTlsCertificates = n.GetBoolValue(); } },
                {"classroomAppBlockRemoteScreenObservation", n => { ClassroomAppBlockRemoteScreenObservation = n.GetBoolValue(); } },
                {"classroomAppForceUnpromptedScreenObservation", n => { ClassroomAppForceUnpromptedScreenObservation = n.GetBoolValue(); } },
                {"compliantAppListType", n => { CompliantAppListType = n.GetEnumValue<AppListType>(); } },
                {"compliantAppsList", n => { CompliantAppsList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"configurationProfileBlockChanges", n => { ConfigurationProfileBlockChanges = n.GetBoolValue(); } },
                {"definitionLookupBlocked", n => { DefinitionLookupBlocked = n.GetBoolValue(); } },
                {"deviceBlockEnableRestrictions", n => { DeviceBlockEnableRestrictions = n.GetBoolValue(); } },
                {"deviceBlockEraseContentAndSettings", n => { DeviceBlockEraseContentAndSettings = n.GetBoolValue(); } },
                {"deviceBlockNameModification", n => { DeviceBlockNameModification = n.GetBoolValue(); } },
                {"diagnosticDataBlockSubmission", n => { DiagnosticDataBlockSubmission = n.GetBoolValue(); } },
                {"diagnosticDataBlockSubmissionModification", n => { DiagnosticDataBlockSubmissionModification = n.GetBoolValue(); } },
                {"documentsBlockManagedDocumentsInUnmanagedApps", n => { DocumentsBlockManagedDocumentsInUnmanagedApps = n.GetBoolValue(); } },
                {"documentsBlockUnmanagedDocumentsInManagedApps", n => { DocumentsBlockUnmanagedDocumentsInManagedApps = n.GetBoolValue(); } },
                {"emailInDomainSuffixes", n => { EmailInDomainSuffixes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"enterpriseAppBlockTrust", n => { EnterpriseAppBlockTrust = n.GetBoolValue(); } },
                {"enterpriseAppBlockTrustModification", n => { EnterpriseAppBlockTrustModification = n.GetBoolValue(); } },
                {"faceTimeBlocked", n => { FaceTimeBlocked = n.GetBoolValue(); } },
                {"findMyFriendsBlocked", n => { FindMyFriendsBlocked = n.GetBoolValue(); } },
                {"gameCenterBlocked", n => { GameCenterBlocked = n.GetBoolValue(); } },
                {"gamingBlockGameCenterFriends", n => { GamingBlockGameCenterFriends = n.GetBoolValue(); } },
                {"gamingBlockMultiplayer", n => { GamingBlockMultiplayer = n.GetBoolValue(); } },
                {"hostPairingBlocked", n => { HostPairingBlocked = n.GetBoolValue(); } },
                {"iBooksStoreBlocked", n => { IBooksStoreBlocked = n.GetBoolValue(); } },
                {"iBooksStoreBlockErotica", n => { IBooksStoreBlockErotica = n.GetBoolValue(); } },
                {"iCloudBlockActivityContinuation", n => { ICloudBlockActivityContinuation = n.GetBoolValue(); } },
                {"iCloudBlockBackup", n => { ICloudBlockBackup = n.GetBoolValue(); } },
                {"iCloudBlockDocumentSync", n => { ICloudBlockDocumentSync = n.GetBoolValue(); } },
                {"iCloudBlockManagedAppsSync", n => { ICloudBlockManagedAppsSync = n.GetBoolValue(); } },
                {"iCloudBlockPhotoLibrary", n => { ICloudBlockPhotoLibrary = n.GetBoolValue(); } },
                {"iCloudBlockPhotoStreamSync", n => { ICloudBlockPhotoStreamSync = n.GetBoolValue(); } },
                {"iCloudBlockSharedPhotoStream", n => { ICloudBlockSharedPhotoStream = n.GetBoolValue(); } },
                {"iCloudRequireEncryptedBackup", n => { ICloudRequireEncryptedBackup = n.GetBoolValue(); } },
                {"iTunesBlockExplicitContent", n => { ITunesBlockExplicitContent = n.GetBoolValue(); } },
                {"iTunesBlockMusicService", n => { ITunesBlockMusicService = n.GetBoolValue(); } },
                {"iTunesBlockRadio", n => { ITunesBlockRadio = n.GetBoolValue(); } },
                {"keyboardBlockAutoCorrect", n => { KeyboardBlockAutoCorrect = n.GetBoolValue(); } },
                {"keyboardBlockDictation", n => { KeyboardBlockDictation = n.GetBoolValue(); } },
                {"keyboardBlockPredictive", n => { KeyboardBlockPredictive = n.GetBoolValue(); } },
                {"keyboardBlockShortcuts", n => { KeyboardBlockShortcuts = n.GetBoolValue(); } },
                {"keyboardBlockSpellCheck", n => { KeyboardBlockSpellCheck = n.GetBoolValue(); } },
                {"kioskModeAllowAssistiveSpeak", n => { KioskModeAllowAssistiveSpeak = n.GetBoolValue(); } },
                {"kioskModeAllowAssistiveTouchSettings", n => { KioskModeAllowAssistiveTouchSettings = n.GetBoolValue(); } },
                {"kioskModeAllowAutoLock", n => { KioskModeAllowAutoLock = n.GetBoolValue(); } },
                {"kioskModeAllowColorInversionSettings", n => { KioskModeAllowColorInversionSettings = n.GetBoolValue(); } },
                {"kioskModeAllowRingerSwitch", n => { KioskModeAllowRingerSwitch = n.GetBoolValue(); } },
                {"kioskModeAllowScreenRotation", n => { KioskModeAllowScreenRotation = n.GetBoolValue(); } },
                {"kioskModeAllowSleepButton", n => { KioskModeAllowSleepButton = n.GetBoolValue(); } },
                {"kioskModeAllowTouchscreen", n => { KioskModeAllowTouchscreen = n.GetBoolValue(); } },
                {"kioskModeAllowVoiceOverSettings", n => { KioskModeAllowVoiceOverSettings = n.GetBoolValue(); } },
                {"kioskModeAllowVolumeButtons", n => { KioskModeAllowVolumeButtons = n.GetBoolValue(); } },
                {"kioskModeAllowZoomSettings", n => { KioskModeAllowZoomSettings = n.GetBoolValue(); } },
                {"kioskModeAppStoreUrl", n => { KioskModeAppStoreUrl = n.GetStringValue(); } },
                {"kioskModeBuiltInAppId", n => { KioskModeBuiltInAppId = n.GetStringValue(); } },
                {"kioskModeManagedAppId", n => { KioskModeManagedAppId = n.GetStringValue(); } },
                {"kioskModeRequireAssistiveTouch", n => { KioskModeRequireAssistiveTouch = n.GetBoolValue(); } },
                {"kioskModeRequireColorInversion", n => { KioskModeRequireColorInversion = n.GetBoolValue(); } },
                {"kioskModeRequireMonoAudio", n => { KioskModeRequireMonoAudio = n.GetBoolValue(); } },
                {"kioskModeRequireVoiceOver", n => { KioskModeRequireVoiceOver = n.GetBoolValue(); } },
                {"kioskModeRequireZoom", n => { KioskModeRequireZoom = n.GetBoolValue(); } },
                {"lockScreenBlockControlCenter", n => { LockScreenBlockControlCenter = n.GetBoolValue(); } },
                {"lockScreenBlockNotificationView", n => { LockScreenBlockNotificationView = n.GetBoolValue(); } },
                {"lockScreenBlockPassbook", n => { LockScreenBlockPassbook = n.GetBoolValue(); } },
                {"lockScreenBlockTodayView", n => { LockScreenBlockTodayView = n.GetBoolValue(); } },
                {"mediaContentRatingApps", n => { MediaContentRatingApps = n.GetEnumValue<RatingAppsType>(); } },
                {"mediaContentRatingAustralia", n => { MediaContentRatingAustralia = n.GetObjectValue<Microsoft.Graph.Models.MediaContentRatingAustralia>(Microsoft.Graph.Models.MediaContentRatingAustralia.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingCanada", n => { MediaContentRatingCanada = n.GetObjectValue<Microsoft.Graph.Models.MediaContentRatingCanada>(Microsoft.Graph.Models.MediaContentRatingCanada.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingFrance", n => { MediaContentRatingFrance = n.GetObjectValue<Microsoft.Graph.Models.MediaContentRatingFrance>(Microsoft.Graph.Models.MediaContentRatingFrance.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingGermany", n => { MediaContentRatingGermany = n.GetObjectValue<Microsoft.Graph.Models.MediaContentRatingGermany>(Microsoft.Graph.Models.MediaContentRatingGermany.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingIreland", n => { MediaContentRatingIreland = n.GetObjectValue<Microsoft.Graph.Models.MediaContentRatingIreland>(Microsoft.Graph.Models.MediaContentRatingIreland.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingJapan", n => { MediaContentRatingJapan = n.GetObjectValue<Microsoft.Graph.Models.MediaContentRatingJapan>(Microsoft.Graph.Models.MediaContentRatingJapan.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingNewZealand", n => { MediaContentRatingNewZealand = n.GetObjectValue<Microsoft.Graph.Models.MediaContentRatingNewZealand>(Microsoft.Graph.Models.MediaContentRatingNewZealand.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingUnitedKingdom", n => { MediaContentRatingUnitedKingdom = n.GetObjectValue<Microsoft.Graph.Models.MediaContentRatingUnitedKingdom>(Microsoft.Graph.Models.MediaContentRatingUnitedKingdom.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingUnitedStates", n => { MediaContentRatingUnitedStates = n.GetObjectValue<Microsoft.Graph.Models.MediaContentRatingUnitedStates>(Microsoft.Graph.Models.MediaContentRatingUnitedStates.CreateFromDiscriminatorValue); } },
                {"messagesBlocked", n => { MessagesBlocked = n.GetBoolValue(); } },
                {"networkUsageRules", n => { NetworkUsageRules = n.GetCollectionOfObjectValues<IosNetworkUsageRule>(IosNetworkUsageRule.CreateFromDiscriminatorValue).ToList(); } },
                {"notificationsBlockSettingsModification", n => { NotificationsBlockSettingsModification = n.GetBoolValue(); } },
                {"passcodeBlockFingerprintModification", n => { PasscodeBlockFingerprintModification = n.GetBoolValue(); } },
                {"passcodeBlockFingerprintUnlock", n => { PasscodeBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"passcodeBlockModification", n => { PasscodeBlockModification = n.GetBoolValue(); } },
                {"passcodeBlockSimple", n => { PasscodeBlockSimple = n.GetBoolValue(); } },
                {"passcodeExpirationDays", n => { PasscodeExpirationDays = n.GetIntValue(); } },
                {"passcodeMinimumCharacterSetCount", n => { PasscodeMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passcodeMinimumLength", n => { PasscodeMinimumLength = n.GetIntValue(); } },
                {"passcodeMinutesOfInactivityBeforeLock", n => { PasscodeMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passcodeMinutesOfInactivityBeforeScreenTimeout", n => { PasscodeMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passcodePreviousPasscodeBlockCount", n => { PasscodePreviousPasscodeBlockCount = n.GetIntValue(); } },
                {"passcodeRequired", n => { PasscodeRequired = n.GetBoolValue(); } },
                {"passcodeRequiredType", n => { PasscodeRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"passcodeSignInFailureCountBeforeWipe", n => { PasscodeSignInFailureCountBeforeWipe = n.GetIntValue(); } },
                {"podcastsBlocked", n => { PodcastsBlocked = n.GetBoolValue(); } },
                {"safariBlockAutofill", n => { SafariBlockAutofill = n.GetBoolValue(); } },
                {"safariBlocked", n => { SafariBlocked = n.GetBoolValue(); } },
                {"safariBlockJavaScript", n => { SafariBlockJavaScript = n.GetBoolValue(); } },
                {"safariBlockPopups", n => { SafariBlockPopups = n.GetBoolValue(); } },
                {"safariCookieSettings", n => { SafariCookieSettings = n.GetEnumValue<WebBrowserCookieSettings>(); } },
                {"safariManagedDomains", n => { SafariManagedDomains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"safariPasswordAutoFillDomains", n => { SafariPasswordAutoFillDomains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"safariRequireFraudWarning", n => { SafariRequireFraudWarning = n.GetBoolValue(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"siriBlocked", n => { SiriBlocked = n.GetBoolValue(); } },
                {"siriBlockedWhenLocked", n => { SiriBlockedWhenLocked = n.GetBoolValue(); } },
                {"siriBlockUserGeneratedContent", n => { SiriBlockUserGeneratedContent = n.GetBoolValue(); } },
                {"siriRequireProfanityFilter", n => { SiriRequireProfanityFilter = n.GetBoolValue(); } },
                {"spotlightBlockInternetResults", n => { SpotlightBlockInternetResults = n.GetBoolValue(); } },
                {"voiceDialingBlocked", n => { VoiceDialingBlocked = n.GetBoolValue(); } },
                {"wallpaperBlockModification", n => { WallpaperBlockModification = n.GetBoolValue(); } },
                {"wiFiConnectOnlyToConfiguredNetworks", n => { WiFiConnectOnlyToConfiguredNetworks = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountBlockModification", AccountBlockModification);
            writer.WriteBoolValue("activationLockAllowWhenSupervised", ActivationLockAllowWhenSupervised);
            writer.WriteBoolValue("airDropBlocked", AirDropBlocked);
            writer.WriteBoolValue("airDropForceUnmanagedDropTarget", AirDropForceUnmanagedDropTarget);
            writer.WriteBoolValue("airPlayForcePairingPasswordForOutgoingRequests", AirPlayForcePairingPasswordForOutgoingRequests);
            writer.WriteBoolValue("appleNewsBlocked", AppleNewsBlocked);
            writer.WriteBoolValue("appleWatchBlockPairing", AppleWatchBlockPairing);
            writer.WriteBoolValue("appleWatchForceWristDetection", AppleWatchForceWristDetection);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsSingleAppModeList", AppsSingleAppModeList);
            writer.WriteBoolValue("appStoreBlockAutomaticDownloads", AppStoreBlockAutomaticDownloads);
            writer.WriteBoolValue("appStoreBlocked", AppStoreBlocked);
            writer.WriteBoolValue("appStoreBlockInAppPurchases", AppStoreBlockInAppPurchases);
            writer.WriteBoolValue("appStoreBlockUIAppInstallation", AppStoreBlockUIAppInstallation);
            writer.WriteBoolValue("appStoreRequirePassword", AppStoreRequirePassword);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsVisibilityList", AppsVisibilityList);
            writer.WriteEnumValue<AppListType>("appsVisibilityListType", AppsVisibilityListType);
            writer.WriteBoolValue("bluetoothBlockModification", BluetoothBlockModification);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("cellularBlockDataRoaming", CellularBlockDataRoaming);
            writer.WriteBoolValue("cellularBlockGlobalBackgroundFetchWhileRoaming", CellularBlockGlobalBackgroundFetchWhileRoaming);
            writer.WriteBoolValue("cellularBlockPerAppDataModification", CellularBlockPerAppDataModification);
            writer.WriteBoolValue("cellularBlockPersonalHotspot", CellularBlockPersonalHotspot);
            writer.WriteBoolValue("cellularBlockVoiceRoaming", CellularBlockVoiceRoaming);
            writer.WriteBoolValue("certificatesBlockUntrustedTlsCertificates", CertificatesBlockUntrustedTlsCertificates);
            writer.WriteBoolValue("classroomAppBlockRemoteScreenObservation", ClassroomAppBlockRemoteScreenObservation);
            writer.WriteBoolValue("classroomAppForceUnpromptedScreenObservation", ClassroomAppForceUnpromptedScreenObservation);
            writer.WriteEnumValue<AppListType>("compliantAppListType", CompliantAppListType);
            writer.WriteCollectionOfObjectValues<AppListItem>("compliantAppsList", CompliantAppsList);
            writer.WriteBoolValue("configurationProfileBlockChanges", ConfigurationProfileBlockChanges);
            writer.WriteBoolValue("definitionLookupBlocked", DefinitionLookupBlocked);
            writer.WriteBoolValue("deviceBlockEnableRestrictions", DeviceBlockEnableRestrictions);
            writer.WriteBoolValue("deviceBlockEraseContentAndSettings", DeviceBlockEraseContentAndSettings);
            writer.WriteBoolValue("deviceBlockNameModification", DeviceBlockNameModification);
            writer.WriteBoolValue("diagnosticDataBlockSubmission", DiagnosticDataBlockSubmission);
            writer.WriteBoolValue("diagnosticDataBlockSubmissionModification", DiagnosticDataBlockSubmissionModification);
            writer.WriteBoolValue("documentsBlockManagedDocumentsInUnmanagedApps", DocumentsBlockManagedDocumentsInUnmanagedApps);
            writer.WriteBoolValue("documentsBlockUnmanagedDocumentsInManagedApps", DocumentsBlockUnmanagedDocumentsInManagedApps);
            writer.WriteCollectionOfPrimitiveValues<string>("emailInDomainSuffixes", EmailInDomainSuffixes);
            writer.WriteBoolValue("enterpriseAppBlockTrust", EnterpriseAppBlockTrust);
            writer.WriteBoolValue("enterpriseAppBlockTrustModification", EnterpriseAppBlockTrustModification);
            writer.WriteBoolValue("faceTimeBlocked", FaceTimeBlocked);
            writer.WriteBoolValue("findMyFriendsBlocked", FindMyFriendsBlocked);
            writer.WriteBoolValue("gameCenterBlocked", GameCenterBlocked);
            writer.WriteBoolValue("gamingBlockGameCenterFriends", GamingBlockGameCenterFriends);
            writer.WriteBoolValue("gamingBlockMultiplayer", GamingBlockMultiplayer);
            writer.WriteBoolValue("hostPairingBlocked", HostPairingBlocked);
            writer.WriteBoolValue("iBooksStoreBlocked", IBooksStoreBlocked);
            writer.WriteBoolValue("iBooksStoreBlockErotica", IBooksStoreBlockErotica);
            writer.WriteBoolValue("iCloudBlockActivityContinuation", ICloudBlockActivityContinuation);
            writer.WriteBoolValue("iCloudBlockBackup", ICloudBlockBackup);
            writer.WriteBoolValue("iCloudBlockDocumentSync", ICloudBlockDocumentSync);
            writer.WriteBoolValue("iCloudBlockManagedAppsSync", ICloudBlockManagedAppsSync);
            writer.WriteBoolValue("iCloudBlockPhotoLibrary", ICloudBlockPhotoLibrary);
            writer.WriteBoolValue("iCloudBlockPhotoStreamSync", ICloudBlockPhotoStreamSync);
            writer.WriteBoolValue("iCloudBlockSharedPhotoStream", ICloudBlockSharedPhotoStream);
            writer.WriteBoolValue("iCloudRequireEncryptedBackup", ICloudRequireEncryptedBackup);
            writer.WriteBoolValue("iTunesBlockExplicitContent", ITunesBlockExplicitContent);
            writer.WriteBoolValue("iTunesBlockMusicService", ITunesBlockMusicService);
            writer.WriteBoolValue("iTunesBlockRadio", ITunesBlockRadio);
            writer.WriteBoolValue("keyboardBlockAutoCorrect", KeyboardBlockAutoCorrect);
            writer.WriteBoolValue("keyboardBlockDictation", KeyboardBlockDictation);
            writer.WriteBoolValue("keyboardBlockPredictive", KeyboardBlockPredictive);
            writer.WriteBoolValue("keyboardBlockShortcuts", KeyboardBlockShortcuts);
            writer.WriteBoolValue("keyboardBlockSpellCheck", KeyboardBlockSpellCheck);
            writer.WriteBoolValue("kioskModeAllowAssistiveSpeak", KioskModeAllowAssistiveSpeak);
            writer.WriteBoolValue("kioskModeAllowAssistiveTouchSettings", KioskModeAllowAssistiveTouchSettings);
            writer.WriteBoolValue("kioskModeAllowAutoLock", KioskModeAllowAutoLock);
            writer.WriteBoolValue("kioskModeAllowColorInversionSettings", KioskModeAllowColorInversionSettings);
            writer.WriteBoolValue("kioskModeAllowRingerSwitch", KioskModeAllowRingerSwitch);
            writer.WriteBoolValue("kioskModeAllowScreenRotation", KioskModeAllowScreenRotation);
            writer.WriteBoolValue("kioskModeAllowSleepButton", KioskModeAllowSleepButton);
            writer.WriteBoolValue("kioskModeAllowTouchscreen", KioskModeAllowTouchscreen);
            writer.WriteBoolValue("kioskModeAllowVoiceOverSettings", KioskModeAllowVoiceOverSettings);
            writer.WriteBoolValue("kioskModeAllowVolumeButtons", KioskModeAllowVolumeButtons);
            writer.WriteBoolValue("kioskModeAllowZoomSettings", KioskModeAllowZoomSettings);
            writer.WriteStringValue("kioskModeAppStoreUrl", KioskModeAppStoreUrl);
            writer.WriteStringValue("kioskModeBuiltInAppId", KioskModeBuiltInAppId);
            writer.WriteStringValue("kioskModeManagedAppId", KioskModeManagedAppId);
            writer.WriteBoolValue("kioskModeRequireAssistiveTouch", KioskModeRequireAssistiveTouch);
            writer.WriteBoolValue("kioskModeRequireColorInversion", KioskModeRequireColorInversion);
            writer.WriteBoolValue("kioskModeRequireMonoAudio", KioskModeRequireMonoAudio);
            writer.WriteBoolValue("kioskModeRequireVoiceOver", KioskModeRequireVoiceOver);
            writer.WriteBoolValue("kioskModeRequireZoom", KioskModeRequireZoom);
            writer.WriteBoolValue("lockScreenBlockControlCenter", LockScreenBlockControlCenter);
            writer.WriteBoolValue("lockScreenBlockNotificationView", LockScreenBlockNotificationView);
            writer.WriteBoolValue("lockScreenBlockPassbook", LockScreenBlockPassbook);
            writer.WriteBoolValue("lockScreenBlockTodayView", LockScreenBlockTodayView);
            writer.WriteEnumValue<RatingAppsType>("mediaContentRatingApps", MediaContentRatingApps);
            writer.WriteObjectValue<Microsoft.Graph.Models.MediaContentRatingAustralia>("mediaContentRatingAustralia", MediaContentRatingAustralia);
            writer.WriteObjectValue<Microsoft.Graph.Models.MediaContentRatingCanada>("mediaContentRatingCanada", MediaContentRatingCanada);
            writer.WriteObjectValue<Microsoft.Graph.Models.MediaContentRatingFrance>("mediaContentRatingFrance", MediaContentRatingFrance);
            writer.WriteObjectValue<Microsoft.Graph.Models.MediaContentRatingGermany>("mediaContentRatingGermany", MediaContentRatingGermany);
            writer.WriteObjectValue<Microsoft.Graph.Models.MediaContentRatingIreland>("mediaContentRatingIreland", MediaContentRatingIreland);
            writer.WriteObjectValue<Microsoft.Graph.Models.MediaContentRatingJapan>("mediaContentRatingJapan", MediaContentRatingJapan);
            writer.WriteObjectValue<Microsoft.Graph.Models.MediaContentRatingNewZealand>("mediaContentRatingNewZealand", MediaContentRatingNewZealand);
            writer.WriteObjectValue<Microsoft.Graph.Models.MediaContentRatingUnitedKingdom>("mediaContentRatingUnitedKingdom", MediaContentRatingUnitedKingdom);
            writer.WriteObjectValue<Microsoft.Graph.Models.MediaContentRatingUnitedStates>("mediaContentRatingUnitedStates", MediaContentRatingUnitedStates);
            writer.WriteBoolValue("messagesBlocked", MessagesBlocked);
            writer.WriteCollectionOfObjectValues<IosNetworkUsageRule>("networkUsageRules", NetworkUsageRules);
            writer.WriteBoolValue("notificationsBlockSettingsModification", NotificationsBlockSettingsModification);
            writer.WriteBoolValue("passcodeBlockFingerprintModification", PasscodeBlockFingerprintModification);
            writer.WriteBoolValue("passcodeBlockFingerprintUnlock", PasscodeBlockFingerprintUnlock);
            writer.WriteBoolValue("passcodeBlockModification", PasscodeBlockModification);
            writer.WriteBoolValue("passcodeBlockSimple", PasscodeBlockSimple);
            writer.WriteIntValue("passcodeExpirationDays", PasscodeExpirationDays);
            writer.WriteIntValue("passcodeMinimumCharacterSetCount", PasscodeMinimumCharacterSetCount);
            writer.WriteIntValue("passcodeMinimumLength", PasscodeMinimumLength);
            writer.WriteIntValue("passcodeMinutesOfInactivityBeforeLock", PasscodeMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passcodeMinutesOfInactivityBeforeScreenTimeout", PasscodeMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passcodePreviousPasscodeBlockCount", PasscodePreviousPasscodeBlockCount);
            writer.WriteBoolValue("passcodeRequired", PasscodeRequired);
            writer.WriteEnumValue<RequiredPasswordType>("passcodeRequiredType", PasscodeRequiredType);
            writer.WriteIntValue("passcodeSignInFailureCountBeforeWipe", PasscodeSignInFailureCountBeforeWipe);
            writer.WriteBoolValue("podcastsBlocked", PodcastsBlocked);
            writer.WriteBoolValue("safariBlockAutofill", SafariBlockAutofill);
            writer.WriteBoolValue("safariBlocked", SafariBlocked);
            writer.WriteBoolValue("safariBlockJavaScript", SafariBlockJavaScript);
            writer.WriteBoolValue("safariBlockPopups", SafariBlockPopups);
            writer.WriteEnumValue<WebBrowserCookieSettings>("safariCookieSettings", SafariCookieSettings);
            writer.WriteCollectionOfPrimitiveValues<string>("safariManagedDomains", SafariManagedDomains);
            writer.WriteCollectionOfPrimitiveValues<string>("safariPasswordAutoFillDomains", SafariPasswordAutoFillDomains);
            writer.WriteBoolValue("safariRequireFraudWarning", SafariRequireFraudWarning);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("siriBlocked", SiriBlocked);
            writer.WriteBoolValue("siriBlockedWhenLocked", SiriBlockedWhenLocked);
            writer.WriteBoolValue("siriBlockUserGeneratedContent", SiriBlockUserGeneratedContent);
            writer.WriteBoolValue("siriRequireProfanityFilter", SiriRequireProfanityFilter);
            writer.WriteBoolValue("spotlightBlockInternetResults", SpotlightBlockInternetResults);
            writer.WriteBoolValue("voiceDialingBlocked", VoiceDialingBlocked);
            writer.WriteBoolValue("wallpaperBlockModification", WallpaperBlockModification);
            writer.WriteBoolValue("wiFiConnectOnlyToConfiguredNetworks", WiFiConnectOnlyToConfiguredNetworks);
        }
    }
}
