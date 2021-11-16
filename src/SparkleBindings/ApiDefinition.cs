using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace Sparkle
{

	// @interface SUAppcast : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SUAppcast
	{
		// @property (readonly, copy) NSArray<SUAppcastItem *> * _Nonnull items;
		[Export("items", ArgumentSemantic.Copy)]
		SUAppcastItem[] Items { get; }
	}

	// @interface SUAppcastItem : NSObject <NSSecureCoding>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SUAppcastItem : INSSecureCoding
	{
		// @property (readonly, copy) NSString * _Nonnull versionString;
		[Export("versionString")]
		string VersionString { get; }

		// @property (readonly, copy) NSString * _Nullable displayVersionString;
		[NullAllowed, Export("displayVersionString")]
		string DisplayVersionString { get; }

		// @property (readonly) NSURL * _Nullable fileURL;
		[NullAllowed, Export("fileURL")]
		NSUrl FileURL { get; }

		// @property (readonly, nonatomic) uint64_t contentLength;
		[Export("contentLength")]
		ulong ContentLength { get; }

		// @property (readonly) NSURL * _Nullable infoURL;
		[NullAllowed, Export("infoURL")]
		NSUrl InfoURL { get; }

		// @property (readonly, getter = isInformationOnlyUpdate) BOOL informationOnlyUpdate;
		[Export("informationOnlyUpdate")]
		bool InformationOnlyUpdate { [Bind("isInformationOnlyUpdate")] get; }

		// @property (readonly, copy) NSString * _Nullable title;
		[NullAllowed, Export("title")]
		string Title { get; }

		// @property (readonly, copy) NSString * _Nullable dateString;
		[NullAllowed, Export("dateString")]
		string DateString { get; }

		// @property (readonly, copy) NSDate * _Nullable date;
		[NullAllowed, Export("date", ArgumentSemantic.Copy)]
		NSDate Date { get; }

		// @property (readonly) NSURL * _Nullable releaseNotesURL;
		[NullAllowed, Export("releaseNotesURL")]
		NSUrl ReleaseNotesURL { get; }

		// @property (readonly, copy) NSString * _Nullable itemDescription;
		[NullAllowed, Export("itemDescription")]
		string ItemDescription { get; }

		// @property (readonly) NSURL * _Nullable fullReleaseNotesURL;
		[NullAllowed, Export("fullReleaseNotesURL")]
		NSUrl FullReleaseNotesURL { get; }

		// @property (readonly, copy) NSString * _Nullable minimumSystemVersion;
		[NullAllowed, Export("minimumSystemVersion")]
		string MinimumSystemVersion { get; }

		// @property (readonly, nonatomic) BOOL minimumOperatingSystemVersionIsOK;
		[Export("minimumOperatingSystemVersionIsOK")]
		bool MinimumOperatingSystemVersionIsOK { get; }

		// @property (readonly, copy) NSString * _Nullable maximumSystemVersion;
		[NullAllowed, Export("maximumSystemVersion")]
		string MaximumSystemVersion { get; }

		// @property (readonly, nonatomic) BOOL maximumOperatingSystemVersionIsOK;
		[Export("maximumOperatingSystemVersionIsOK")]
		bool MaximumOperatingSystemVersionIsOK { get; }

		// @property (readonly, nonatomic) NSString * _Nullable channel;
		[NullAllowed, Export("channel")]
		string Channel { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull installationType;
		[Export("installationType")]
		string InstallationType { get; }

		// @property (readonly, copy) NSNumber * _Nullable phasedRolloutInterval;
		[NullAllowed, Export("phasedRolloutInterval", ArgumentSemantic.Copy)]
		NSNumber PhasedRolloutInterval { get; }

		// @property (readonly, copy) NSString * _Nullable minimumAutoupdateVersion;
		[NullAllowed, Export("minimumAutoupdateVersion")]
		string MinimumAutoupdateVersion { get; }

		// @property (readonly, getter = isMajorUpgrade) BOOL majorUpgrade;
		[Export("majorUpgrade")]
		bool MajorUpgrade { [Bind("isMajorUpgrade")] get; }

		// @property (readonly, getter = isCriticalUpdate) BOOL criticalUpdate;
		[Export("criticalUpdate")]
		bool CriticalUpdate { [Bind("isCriticalUpdate")] get; }

		// @property (readonly, copy) NSString * _Nullable osString;
		[NullAllowed, Export("osString")]
		string OsString { get; }

		// @property (readonly, getter = isMacOsUpdate) BOOL macOsUpdate;
		[Export("macOsUpdate")]
		bool MacOsUpdate { [Bind("isMacOsUpdate")] get; }

		// @property (readonly, copy) NSDictionary<NSString *,SUAppcastItem *> * _Nullable deltaUpdates;
		[NullAllowed, Export("deltaUpdates", ArgumentSemantic.Copy)]
		NSDictionary<NSString, SUAppcastItem> DeltaUpdates { get; }

		// @property (readonly, getter = isDeltaUpdate) BOOL deltaUpdate;
		[Export("deltaUpdate")]
		bool DeltaUpdate { [Bind("isDeltaUpdate")] get; }

		// @property (readonly, copy) NSDictionary * _Nonnull propertiesDictionary;
		[Export("propertiesDictionary", ArgumentSemantic.Copy)]
		NSDictionary PropertiesDictionary { get; }

		// +(instancetype _Nonnull)emptyAppcastItem;
		[Static]
		[Export("emptyAppcastItem")]
		SUAppcastItem EmptyAppcastItem();

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict __attribute__((deprecated("Properties that depend on the system or application version are not supported when used with this initializer. The designated initializer is available in SUAppcastItem+Private.h. Please first explore other APIs or contact us to describe your use case.")));
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary dict);

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict failureReason:(NSString * _Nullable * _Nullable)error __attribute__((deprecated("Properties that depend on the system or application version are not supported when used with this initializer. The designated initializer is available in SUAppcastItem+Private.h. Please first explore other APIs or contact us to describe your use case.")));
		[Export("initWithDictionary:failureReason:")]
		IntPtr Constructor(NSDictionary dict, [NullAllowed] out string error);

		// -(instancetype _Nullable)initWithDictionary:(NSDictionary * _Nonnull)dict relativeToURL:(NSURL * _Nullable)appcastURL failureReason:(NSString * _Nullable * _Nullable)error __attribute__((deprecated("Properties that depend on the system or application version are not supported when used with this initializer. The designated initializer is available in SUAppcastItem+Private.h. Please first explore other APIs or contact us to describe your use case.")));
		[Export("initWithDictionary:relativeToURL:failureReason:")]
		IntPtr Constructor(NSDictionary dict, [NullAllowed] NSUrl appcastURL, [NullAllowed] out string error);
	}

	// @protocol SUVersionComparison
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface SUVersionComparison
	{
		// @required -(NSComparisonResult)compareVersion:(NSString * _Nonnull)versionA toVersion:(NSString * _Nonnull)versionB;
		[Abstract]
		[Export("compareVersion:toVersion:")]
		NSComparisonResult ToVersion(string versionA, string versionB);
	}

	// @interface SUStandardVersionComparator : NSObject <SUVersionComparison>
	[BaseType(typeof(NSObject))]
	interface SUStandardVersionComparator
	{
		// @property (readonly, nonatomic, class) SUStandardVersionComparator * _Nonnull defaultComparator;
		[Static]
		[Export("defaultComparator")]
		SUStandardVersionComparator DefaultComparator { get; }

		// -(NSComparisonResult)compareVersion:(NSString * _Nonnull)versionA toVersion:(NSString * _Nonnull)versionB;
		[Export("compareVersion:toVersion:")]
		NSComparisonResult CompareVersion(string versionA, string versionB);
	}

	// @interface SPUUserUpdateState : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SPUUserUpdateState
	{
		// @property (readonly, nonatomic) SPUUserUpdateStage stage;
		[Export("stage")]
		int Stage { get; }

		// @property (readonly, nonatomic) BOOL userInitiated;
		[Export("userInitiated")]
		bool UserInitiated { get; }
	}

	// @protocol SPUUserDriver <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface SPUUserDriver
	{
		// @required -(void)showUpdatePermissionRequest:(SPUUpdatePermissionRequest * _Nonnull)request reply:(void (^ _Nonnull)(SUUpdatePermissionResponse * _Nonnull))reply;
		[Abstract]
		[Export("showUpdatePermissionRequest:reply:")]
		void ShowUpdatePermissionRequest(SPUUpdatePermissionRequest request, Action<SUUpdatePermissionResponse> reply);

		// @required -(void)showUserInitiatedUpdateCheckWithCancellation:(void (^ _Nonnull)(void))cancellation;
		[Abstract]
		[Export("showUserInitiatedUpdateCheckWithCancellation:")]
		void ShowUserInitiatedUpdateCheckWithCancellation(Action cancellation);

		// @required -(void)showUpdateFoundWithAppcastItem:(SUAppcastItem * _Nonnull)appcastItem state:(SPUUserUpdateState * _Nonnull)state reply:(void (^ _Nonnull)(SPUUserUpdateChoice))reply;
		[Abstract]
		[Export("showUpdateFoundWithAppcastItem:state:reply:")]
		void ShowUpdateFoundWithAppcastItem(SUAppcastItem appcastItem, SPUUserUpdateState state, Action<int> reply);

		// @required -(void)showUpdateReleaseNotesWithDownloadData:(SPUDownloadData * _Nonnull)downloadData;
		[Abstract]
		[Export("showUpdateReleaseNotesWithDownloadData:")]
		void ShowUpdateReleaseNotesWithDownloadData(SPUDownloadData downloadData);

		// @required -(void)showUpdateReleaseNotesFailedToDownloadWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export("showUpdateReleaseNotesFailedToDownloadWithError:")]
		void ShowUpdateReleaseNotesFailedToDownloadWithError(NSError error);

		// @required -(void)showUpdateNotFoundWithError:(NSError * _Nonnull)error acknowledgement:(void (^ _Nonnull)(void))acknowledgement;
		[Abstract]
		[Export("showUpdateNotFoundWithError:acknowledgement:")]
		void ShowUpdateNotFoundWithError(NSError error, Action acknowledgement);

		// @required -(void)showUpdaterError:(NSError * _Nonnull)error acknowledgement:(void (^ _Nonnull)(void))acknowledgement;
		[Abstract]
		[Export("showUpdaterError:acknowledgement:")]
		void ShowUpdaterError(NSError error, Action acknowledgement);

		// @required -(void)showDownloadInitiatedWithCancellation:(void (^ _Nonnull)(void))cancellation;
		[Abstract]
		[Export("showDownloadInitiatedWithCancellation:")]
		void ShowDownloadInitiatedWithCancellation(Action cancellation);

		// @required -(void)showDownloadDidReceiveExpectedContentLength:(uint64_t)expectedContentLength;
		[Abstract]
		[Export("showDownloadDidReceiveExpectedContentLength:")]
		void ShowDownloadDidReceiveExpectedContentLength(ulong expectedContentLength);

		// @required -(void)showDownloadDidReceiveDataOfLength:(uint64_t)length;
		[Abstract]
		[Export("showDownloadDidReceiveDataOfLength:")]
		void ShowDownloadDidReceiveDataOfLength(ulong length);

		// @required -(void)showDownloadDidStartExtractingUpdate;
		[Abstract]
		[Export("showDownloadDidStartExtractingUpdate")]
		void ShowDownloadDidStartExtractingUpdate();

		// @required -(void)showExtractionReceivedProgress:(double)progress;
		[Abstract]
		[Export("showExtractionReceivedProgress:")]
		void ShowExtractionReceivedProgress(double progress);

		// @required -(void)showInstallingUpdate;
		[Abstract]
		[Export("showInstallingUpdate")]
		void ShowInstallingUpdate();

		// @required -(void)showReadyToInstallAndRelaunch:(void (^ _Nonnull)(SPUUserUpdateChoice))reply;
		[Abstract]
		[Export("showReadyToInstallAndRelaunch:")]
		void ShowReadyToInstallAndRelaunch(Action<int> reply);

		// @required -(void)showSendingTerminationSignal;
		[Abstract]
		[Export("showSendingTerminationSignal")]
		void ShowSendingTerminationSignal();

		// @required -(void)showUpdateInstalledAndRelaunched:(BOOL)relaunched acknowledgement:(void (^ _Nonnull)(void))acknowledgement;
		[Abstract]
		[Export("showUpdateInstalledAndRelaunched:acknowledgement:")]
		void ShowUpdateInstalledAndRelaunched(bool relaunched, Action acknowledgement);

		// @required -(void)showUpdateInFocus;
		[Abstract]
		[Export("showUpdateInFocus")]
		void ShowUpdateInFocus();

		// @required -(void)dismissUpdateInstallation;
		[Abstract]
		[Export("dismissUpdateInstallation")]
		void DismissUpdateInstallation();

		// @optional -(void)showUpdateNotFoundWithAcknowledgement:(void (^ _Nonnull)(void))acknowledgement __attribute__((deprecated("Implement -showUpdateNotFoundWithError:acknowledgement: instead")));
		[Export("showUpdateNotFoundWithAcknowledgement:")]
		void ShowUpdateNotFoundWithAcknowledgement(Action acknowledgement);

		// @optional -(void)showUpdateInstallationDidFinishWithAcknowledgement:(void (^ _Nonnull)(void))acknowledgement __attribute__((deprecated("Implement -showUpdateInstalledAndRelaunched:acknowledgement: instead")));
		[Export("showUpdateInstallationDidFinishWithAcknowledgement:")]
		void ShowUpdateInstallationDidFinishWithAcknowledgement(Action acknowledgement);

		// @optional -(void)dismissUserInitiatedUpdateCheck __attribute__((deprecated("Transition to new UI appropriately when a new update is shown, when no update is found, or when an update error occurs.")));
		[Export("dismissUserInitiatedUpdateCheck")]
		void DismissUserInitiatedUpdateCheck();
	}

	// @interface SPUUpdater : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SPUUpdater
	{
		// -(instancetype _Nonnull)initWithHostBundle:(NSBundle * _Nonnull)hostBundle applicationBundle:(NSBundle * _Nonnull)applicationBundle userDriver:(id<SPUUserDriver> _Nonnull)userDriver delegate:(id<SPUUpdaterDelegate> _Nullable)delegate;
		[Export("initWithHostBundle:applicationBundle:userDriver:delegate:")]
		IntPtr Constructor(NSBundle hostBundle, NSBundle applicationBundle, SPUUserDriver userDriver, [NullAllowed] SPUUpdaterDelegate @delegate);

		// -(BOOL)startUpdater:(NSError * _Nullable * _Nullable)error;
		[Export("startUpdater:")]
		bool StartUpdater([NullAllowed] out NSError error);

		// -(void)checkForUpdates;
		[Export("checkForUpdates")]
		void CheckForUpdates();

		// -(void)checkForUpdatesInBackground;
		[Export("checkForUpdatesInBackground")]
		void CheckForUpdatesInBackground();

		// -(void)checkForUpdateInformation;
		[Export("checkForUpdateInformation")]
		void CheckForUpdateInformation();

		// @property (readonly, nonatomic) BOOL canCheckForUpdates;
		[Export("canCheckForUpdates")]
		bool CanCheckForUpdates { get; }

		// @property (readonly, nonatomic) BOOL sessionInProgress;
		[Export("sessionInProgress")]
		bool SessionInProgress { get; }

		// @property (nonatomic) BOOL automaticallyChecksForUpdates;
		[Export("automaticallyChecksForUpdates")]
		bool AutomaticallyChecksForUpdates { get; set; }

		// @property (nonatomic) NSTimeInterval updateCheckInterval;
		[Export("updateCheckInterval")]
		double UpdateCheckInterval { get; set; }

		// @property (nonatomic) BOOL automaticallyDownloadsUpdates;
		[Export("automaticallyDownloadsUpdates")]
		bool AutomaticallyDownloadsUpdates { get; set; }

		// @property (readonly, nonatomic) NSURL * _Nullable feedURL;
		[NullAllowed, Export("feedURL")]
		NSUrl FeedURL { get; }

		// -(void)setFeedURL:(NSURL * _Nullable)feedURL;
		[Export("setFeedURL:")]
		void SetFeedURL([NullAllowed] NSUrl feedURL);

		// @property (readonly, nonatomic) NSBundle * _Nonnull hostBundle;
		[Export("hostBundle")]
		NSBundle HostBundle { get; }

		// @property (copy, nonatomic) NSString * _Nonnull userAgentString;
		[Export("userAgentString")]
		string UserAgentString { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable httpHeaders;
		[NullAllowed, Export("httpHeaders", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> HttpHeaders { get; set; }

		// @property (nonatomic) BOOL sendsSystemProfile;
		[Export("sendsSystemProfile")]
		bool SendsSystemProfile { get; set; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable lastUpdateCheckDate;
		[NullAllowed, Export("lastUpdateCheckDate", ArgumentSemantic.Copy)]
		NSDate LastUpdateCheckDate { get; }

		// -(void)resetUpdateCycle;
		[Export("resetUpdateCycle")]
		void ResetUpdateCycle();

		// @property (readonly, copy, nonatomic) NSArray<NSDictionary<NSString *,NSString *> *> * _Nonnull systemProfileArray;
		[Export("systemProfileArray", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString>[] SystemProfileArray { get; }
	}

	[Static]
	partial interface Constants
	{
		// extern NSString *const _Nonnull SUUpdaterDidFinishLoadingAppCastNotification;
		[Field("SUUpdaterDidFinishLoadingAppCastNotification", LibraryName = "__Internal")]
		NSString SUUpdaterDidFinishLoadingAppCastNotification { get; }

		// extern NSString *const _Nonnull SUUpdaterDidFindValidUpdateNotification;
		[Field("SUUpdaterDidFindValidUpdateNotification", LibraryName = "__Internal")]
		NSString SUUpdaterDidFindValidUpdateNotification { get; }

		// extern NSString *const _Nonnull SUUpdaterDidNotFindUpdateNotification;
		[Field("SUUpdaterDidNotFindUpdateNotification", LibraryName = "__Internal")]
		NSString SUUpdaterDidNotFindUpdateNotification { get; }

		// extern NSString *const _Nonnull SUUpdaterWillRestartNotification;
		[Field("SUUpdaterWillRestartNotification", LibraryName = "__Internal")]
		NSString SUUpdaterWillRestartNotification { get; }

		// extern NSString *const _Nonnull SUUpdaterAppcastItemNotificationKey;
		[Field("SUUpdaterAppcastItemNotificationKey", LibraryName = "__Internal")]
		NSString SUUpdaterAppcastItemNotificationKey { get; }

		// extern NSString *const _Nonnull SUUpdaterAppcastNotificationKey;
		[Field("SUUpdaterAppcastNotificationKey", LibraryName = "__Internal")]
		NSString SUUpdaterAppcastNotificationKey { get; }

		// extern NSString *const _Nonnull SUSystemProfilerApplicationNameKey;
		[Field("SUSystemProfilerApplicationNameKey", LibraryName = "__Internal")]
		NSString SUSystemProfilerApplicationNameKey { get; }

		// extern NSString *const _Nonnull SUSystemProfilerApplicationVersionKey;
		[Field("SUSystemProfilerApplicationVersionKey", LibraryName = "__Internal")]
		NSString SUSystemProfilerApplicationVersionKey { get; }

		// extern NSString *const _Nonnull SUSystemProfilerCPU64bitKey;
		[Field("SUSystemProfilerCPU64bitKey", LibraryName = "__Internal")]
		NSString SUSystemProfilerCPU64bitKey { get; }

		// extern NSString *const _Nonnull SUSystemProfilerCPUCountKey;
		[Field("SUSystemProfilerCPUCountKey", LibraryName = "__Internal")]
		NSString SUSystemProfilerCPUCountKey { get; }

		// extern NSString *const _Nonnull SUSystemProfilerCPUFrequencyKey;
		[Field("SUSystemProfilerCPUFrequencyKey", LibraryName = "__Internal")]
		NSString SUSystemProfilerCPUFrequencyKey { get; }

		// extern NSString *const _Nonnull SUSystemProfilerCPUTypeKey;
		[Field("SUSystemProfilerCPUTypeKey", LibraryName = "__Internal")]
		NSString SUSystemProfilerCPUTypeKey { get; }

		// extern NSString *const _Nonnull SUSystemProfilerCPUSubtypeKey;
		[Field("SUSystemProfilerCPUSubtypeKey", LibraryName = "__Internal")]
		NSString SUSystemProfilerCPUSubtypeKey { get; }

		// extern NSString *const _Nonnull SUSystemProfilerHardwareModelKey;
		[Field("SUSystemProfilerHardwareModelKey", LibraryName = "__Internal")]
		NSString SUSystemProfilerHardwareModelKey { get; }

		// extern NSString *const _Nonnull SUSystemProfilerMemoryKey;
		[Field("SUSystemProfilerMemoryKey", LibraryName = "__Internal")]
		NSString SUSystemProfilerMemoryKey { get; }

		// extern NSString *const _Nonnull SUSystemProfilerOperatingSystemVersionKey;
		[Field("SUSystemProfilerOperatingSystemVersionKey", LibraryName = "__Internal")]
		NSString SUSystemProfilerOperatingSystemVersionKey { get; }

		// extern NSString *const _Nonnull SUSystemProfilerPreferredLanguageKey;
		[Field("SUSystemProfilerPreferredLanguageKey", LibraryName = "__Internal")]
		NSString SUSystemProfilerPreferredLanguageKey { get; }
	}

	// @protocol SPUUpdaterDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface SPUUpdaterDelegate
	{
		// @optional -(BOOL)updater:(SPUUpdater * _Nonnull)updater mayPerformUpdateCheck:(SPUUpdateCheck)updateCheck error:(NSError * _Nullable * _Nullable)error;
		[Export("updater:mayPerformUpdateCheck:error:")]
		bool Updater(SPUUpdater updater, int updateCheck, [NullAllowed] out NSError error);

		// @optional -(NSSet<NSString *> * _Nonnull)allowedChannelsForUpdater:(SPUUpdater * _Nonnull)updater;
		[Export("allowedChannelsForUpdater:")]
		NSSet<NSString> AllowedChannelsForUpdater(SPUUpdater updater);

		// @optional -(NSString * _Nullable)feedURLStringForUpdater:(SPUUpdater * _Nonnull)updater;
		[Export("feedURLStringForUpdater:")]
		[return: NullAllowed]
		string FeedURLStringForUpdater(SPUUpdater updater);

		// @optional -(NSArray<NSDictionary<NSString *,NSString *> *> * _Nonnull)feedParametersForUpdater:(SPUUpdater * _Nonnull)updater sendingSystemProfile:(BOOL)sendingProfile;
		[Export("feedParametersForUpdater:sendingSystemProfile:")]
		NSDictionary<NSString, NSString>[] FeedParametersForUpdater(SPUUpdater updater, bool sendingProfile);

		// @optional -(BOOL)updaterShouldPromptForPermissionToCheckForUpdates:(SPUUpdater * _Nonnull)updater;
		[Export("updaterShouldPromptForPermissionToCheckForUpdates:")]
		bool UpdaterShouldPromptForPermissionToCheckForUpdates(SPUUpdater updater);

		// @optional -(NSArray<NSString *> * _Nullable)allowedSystemProfileKeysForUpdater:(SPUUpdater * _Nonnull)updater;
		[Export("allowedSystemProfileKeysForUpdater:")]
		[return: NullAllowed]
		string[] AllowedSystemProfileKeysForUpdater(SPUUpdater updater);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater didFinishLoadingAppcast:(SUAppcast * _Nonnull)appcast;
		[Export("updater:didFinishLoadingAppcast:")]
		void Updater(SPUUpdater updater, SUAppcast appcast);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater didFindValidUpdate:(SUAppcastItem * _Nonnull)item;
		[Export("updater:didFindValidUpdate:")]
		void Updater(SPUUpdater updater, SUAppcastItem item);

		// @optional -(void)updaterDidNotFindUpdate:(SPUUpdater * _Nonnull)updater error:(NSError * _Nonnull)error;
		[Export("updaterDidNotFindUpdate:error:")]
		void UpdaterDidNotFindUpdate(SPUUpdater updater, NSError error);

		// @optional -(void)updaterDidNotFindUpdate:(SPUUpdater * _Nonnull)updater;
		[Export("updaterDidNotFindUpdate:")]
		void UpdaterDidNotFindUpdate(SPUUpdater updater);

		// @optional -(SUAppcastItem * _Nullable)bestValidUpdateInAppcast:(SUAppcast * _Nonnull)appcast forUpdater:(SPUUpdater * _Nonnull)updater;
		[Export("bestValidUpdateInAppcast:forUpdater:")]
		[return: NullAllowed]
		SUAppcastItem BestValidUpdateInAppcast(SUAppcast appcast, SPUUpdater updater);

		// @optional -(BOOL)updater:(SPUUpdater * _Nonnull)updater shouldProceedWithUpdate:(SUAppcastItem * _Nonnull)updateItem updateCheck:(SPUUpdateCheck)updateCheck error:(NSError * _Nullable * _Nullable)error;
		[Export("updater:shouldProceedWithUpdate:updateCheck:error:")]
		bool Updater(SPUUpdater updater, SUAppcastItem updateItem, int updateCheck, [NullAllowed] out NSError error);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater userDidSkipThisVersion:(SUAppcastItem * _Nonnull)item;
		[Export("updater:userDidSkipThisVersion:")]
		void Updater1(SPUUpdater updater, SUAppcastItem item);

		// @optional -(BOOL)updater:(SPUUpdater * _Nonnull)updater shouldDownloadReleaseNotesForUpdate:(SUAppcastItem * _Nonnull)updateItem;
		[Export("updater:shouldDownloadReleaseNotesForUpdate:")]
		bool Updater2(SPUUpdater updater, SUAppcastItem updateItem);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater willDownloadUpdate:(SUAppcastItem * _Nonnull)item withRequest:(NSMutableURLRequest * _Nonnull)request;
		[Export("updater:willDownloadUpdate:withRequest:")]
		void Updater3(SPUUpdater updater, SUAppcastItem item, NSMutableUrlRequest request);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater didDownloadUpdate:(SUAppcastItem * _Nonnull)item;
		[Export("updater:didDownloadUpdate:")]
		void Updater4(SPUUpdater updater, SUAppcastItem item);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater failedToDownloadUpdate:(SUAppcastItem * _Nonnull)item error:(NSError * _Nonnull)error;
		[Export("updater:failedToDownloadUpdate:error:")]
		void Updater(SPUUpdater updater, SUAppcastItem item, NSError error);

		// @optional -(void)userDidCancelDownload:(SPUUpdater * _Nonnull)updater;
		[Export("userDidCancelDownload:")]
		void UserDidCancelDownload(SPUUpdater updater);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater willExtractUpdate:(SUAppcastItem * _Nonnull)item;
		[Export("updater:willExtractUpdate:")]
		void Updater5(SPUUpdater updater, SUAppcastItem item);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater didExtractUpdate:(SUAppcastItem * _Nonnull)item;
		[Export("updater:didExtractUpdate:")]
		void Updater6(SPUUpdater updater, SUAppcastItem item);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater willInstallUpdate:(SUAppcastItem * _Nonnull)item;
		[Export("updater:willInstallUpdate:")]
		void Updater7(SPUUpdater updater, SUAppcastItem item);

		// @optional -(BOOL)updater:(SPUUpdater * _Nonnull)updater shouldPostponeRelaunchForUpdate:(SUAppcastItem * _Nonnull)item untilInvokingBlock:(void (^ _Nonnull)(void))installHandler;
		[Export("updater:shouldPostponeRelaunchForUpdate:untilInvokingBlock:")]
		bool Updater(SPUUpdater updater, SUAppcastItem item, Action installHandler);

		// @optional -(BOOL)updaterShouldRelaunchApplication:(SPUUpdater * _Nonnull)updater;
		[Export("updaterShouldRelaunchApplication:")]
		bool UpdaterShouldRelaunchApplication(SPUUpdater updater);

		// @optional -(void)updaterWillRelaunchApplication:(SPUUpdater * _Nonnull)updater;
		[Export("updaterWillRelaunchApplication:")]
		void UpdaterWillRelaunchApplication(SPUUpdater updater);

		// @optional -(id<SUVersionComparison> _Nullable)versionComparatorForUpdater:(SPUUpdater * _Nonnull)updater;
		[Export("versionComparatorForUpdater:")]
		[return: NullAllowed]
		SUVersionComparison VersionComparatorForUpdater(SPUUpdater updater);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater willScheduleUpdateCheckAfterDelay:(NSTimeInterval)delay;
		[Export("updater:willScheduleUpdateCheckAfterDelay:")]
		void Updater(SPUUpdater updater, double delay);

		// @optional -(void)updaterWillNotScheduleUpdateCheck:(SPUUpdater * _Nonnull)updater;
		[Export("updaterWillNotScheduleUpdateCheck:")]
		void UpdaterWillNotScheduleUpdateCheck(SPUUpdater updater);

		// @optional -(NSString * _Nullable)decryptionPasswordForUpdater:(SPUUpdater * _Nonnull)updater;
		[Export("decryptionPasswordForUpdater:")]
		[return: NullAllowed]
		string DecryptionPasswordForUpdater(SPUUpdater updater);

		// @optional -(BOOL)updater:(SPUUpdater * _Nonnull)updater willInstallUpdateOnQuit:(SUAppcastItem * _Nonnull)item immediateInstallationBlock:(void (^ _Nonnull)(void))immediateInstallHandler;
		[Export("updater:willInstallUpdateOnQuit:immediateInstallationBlock:")]
		bool Updater8(SPUUpdater updater, SUAppcastItem item, Action immediateInstallHandler);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater didAbortWithError:(NSError * _Nonnull)error;
		[Export("updater:didAbortWithError:")]
		void Updater9(SPUUpdater updater, NSError error);

		// @optional -(void)updater:(SPUUpdater * _Nonnull)updater didFinishUpdateCycleForUpdateCheck:(SPUUpdateCheck)updateCheck error:(NSError * _Nullable)error;
		[Export("updater:didFinishUpdateCycleForUpdateCheck:error:")]
		void Updater(SPUUpdater updater, int updateCheck, [NullAllowed] NSError error);

		// @optional -(BOOL)updaterMayCheckForUpdates:(SPUUpdater * _Nonnull)updater __attribute__((deprecated("Please use -[SPUUpdaterDelegate updater:mayPerformUpdateCheck:error:] instead.")));
		[Export("updaterMayCheckForUpdates:")]
		bool UpdaterMayCheckForUpdates(SPUUpdater updater);
	}

	// @interface SPUUpdaterSettings : NSObject
	[BaseType(typeof(NSObject))]
	interface SPUUpdaterSettings
	{
		// -(instancetype _Nonnull)initWithHostBundle:(NSBundle * _Nonnull)hostBundle;
		[Export("initWithHostBundle:")]
		IntPtr Constructor(NSBundle hostBundle);

		// @property (readonly, nonatomic) BOOL automaticallyChecksForUpdates;
		[Export("automaticallyChecksForUpdates")]
		bool AutomaticallyChecksForUpdates { get; }

		// @property (readonly, nonatomic) NSTimeInterval updateCheckInterval;
		[Export("updateCheckInterval")]
		double UpdateCheckInterval { get; }

		// @property (readonly, nonatomic) BOOL allowsAutomaticUpdates;
		[Export("allowsAutomaticUpdates")]
		bool AllowsAutomaticUpdates { get; }

		// @property (readonly, nonatomic) BOOL automaticallyDownloadsUpdates;
		[Export("automaticallyDownloadsUpdates")]
		bool AutomaticallyDownloadsUpdates { get; }

		// @property (readonly, nonatomic) BOOL sendsSystemProfile;
		[Export("sendsSystemProfile")]
		bool SendsSystemProfile { get; }
	}

	// @protocol SUVersionDisplay
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface SUVersionDisplay
	{
		// @required -(void)formatVersion:(NSString * _Nonnull * _Nonnull)inOutVersionA andVersion:(NSString * _Nonnull * _Nonnull)inOutVersionB;
		[Abstract]
		[Export("formatVersion:andVersion:")]
		void AndVersion(out string inOutVersionA, out string inOutVersionB);
	}

	partial interface Constants
	{
		// extern NSString *const SUSparkleErrorDomain;
		[Field("SUSparkleErrorDomain", LibraryName = "__Internal")]
		NSString SUSparkleErrorDomain { get; }
	}

	partial interface Constants
	{
		// extern NSString *const SPUNoUpdateFoundReasonKey;
		[Field("SPUNoUpdateFoundReasonKey", LibraryName = "__Internal")]
		NSString SPUNoUpdateFoundReasonKey { get; }

		// extern NSString *const SPULatestAppcastItemFoundKey;
		[Field("SPULatestAppcastItemFoundKey", LibraryName = "__Internal")]
		NSString SPULatestAppcastItemFoundKey { get; }

		// extern NSString *const SPUNoUpdateFoundUserInitiatedKey;
		[Field("SPUNoUpdateFoundUserInitiatedKey", LibraryName = "__Internal")]
		NSString SPUNoUpdateFoundUserInitiatedKey { get; }
	}

	// @interface SPUUpdatePermissionRequest : NSObject <NSSecureCoding>
	[BaseType(typeof(NSObject))]
	interface SPUUpdatePermissionRequest : INSSecureCoding
	{
		// -(instancetype _Nonnull)initWithSystemProfile:(NSArray<NSDictionary<NSString *,NSString *> *> * _Nonnull)systemProfile;
		[Export("initWithSystemProfile:")]
		IntPtr Constructor(NSDictionary<NSString, NSString>[] systemProfile);

		// @property (readonly, nonatomic) NSArray<NSDictionary<NSString *,NSString *> *> * _Nonnull systemProfile;
		[Export("systemProfile")]
		NSDictionary<NSString, NSString>[] SystemProfile { get; }
	}

	// @interface SUUpdatePermissionResponse : NSObject <NSSecureCoding>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SUUpdatePermissionResponse : INSSecureCoding
	{
		// -(instancetype)initWithAutomaticUpdateChecks:(BOOL)automaticUpdateChecks sendSystemProfile:(BOOL)sendSystemProfile;
		[Export("initWithAutomaticUpdateChecks:sendSystemProfile:")]
		IntPtr Constructor(bool automaticUpdateChecks, bool sendSystemProfile);

		// @property (readonly, nonatomic) BOOL automaticUpdateChecks;
		[Export("automaticUpdateChecks")]
		bool AutomaticUpdateChecks { get; }

		// @property (readonly, nonatomic) BOOL sendSystemProfile;
		[Export("sendSystemProfile")]
		bool SendSystemProfile { get; }
	}

	// @interface SPUDownloadData : NSObject <NSSecureCoding>
	[BaseType(typeof(NSObject))]
	interface SPUDownloadData : INSSecureCoding
	{
		// @property (readonly, nonatomic) NSData * _Nonnull data;
		[Export("data")]
		NSData Data { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull URL;
		[Export("URL", ArgumentSemantic.Copy)]
		NSUrl URL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable textEncodingName;
		[NullAllowed, Export("textEncodingName")]
		string TextEncodingName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable MIMEType;
		[NullAllowed, Export("MIMEType")]
		string MIMEType { get; }
	}

	// @interface SPUStandardUpdaterController : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SPUStandardUpdaterController
	{
		// @property (readonly, nonatomic) SPUUpdater * _Nonnull updater;
		[Export("updater")]
		SPUUpdater Updater { get; }

		// @property (readonly, nonatomic) SPUStandardUserDriver * _Nonnull userDriver;
		[Export("userDriver")]
		SPUStandardUserDriver UserDriver { get; }

		// -(instancetype _Nonnull)initWithUpdaterDelegate:(id<SPUUpdaterDelegate> _Nullable)updaterDelegate userDriverDelegate:(id<SPUStandardUserDriverDelegate> _Nullable)userDriverDelegate;
		[Export("initWithUpdaterDelegate:userDriverDelegate:")]
		IntPtr Constructor([NullAllowed] SPUUpdaterDelegate updaterDelegate, [NullAllowed] SPUStandardUserDriverDelegate userDriverDelegate);

		// -(instancetype _Nonnull)initWithStartingUpdater:(BOOL)startUpdater updaterDelegate:(id<SPUUpdaterDelegate> _Nullable)updaterDelegate userDriverDelegate:(id<SPUStandardUserDriverDelegate> _Nullable)userDriverDelegate;
		[Export("initWithStartingUpdater:updaterDelegate:userDriverDelegate:")]
		IntPtr Constructor(bool startUpdater, [NullAllowed] SPUUpdaterDelegate updaterDelegate, [NullAllowed] SPUStandardUserDriverDelegate userDriverDelegate);

		// -(void)startUpdater;
		[Export("startUpdater")]
		void StartUpdater();

		// -(void)checkForUpdates:(id _Nullable)sender __attribute__((ibaction));
		[Export("checkForUpdates:")]
		void CheckForUpdates([NullAllowed] NSObject sender);
	}

	// @interface SPUStandardUserDriver : NSObject <SPUUserDriver>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SPUStandardUserDriver : SPUUserDriver
	{
		// -(instancetype _Nonnull)initWithHostBundle:(NSBundle * _Nonnull)hostBundle delegate:(id<SPUStandardUserDriverDelegate> _Nullable)delegate;
		[Export("initWithHostBundle:delegate:")]
		IntPtr Constructor(NSBundle hostBundle, [NullAllowed] SPUStandardUserDriverDelegate @delegate);
	}

	// @protocol SPUStandardUserDriverDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface SPUStandardUserDriverDelegate
	{
		// @optional -(void)standardUserDriverWillShowModalAlert;
		[Export("standardUserDriverWillShowModalAlert")]
		void StandardUserDriverWillShowModalAlert();

		// @optional -(void)standardUserDriverDidShowModalAlert;
		[Export("standardUserDriverDidShowModalAlert")]
		void StandardUserDriverDidShowModalAlert();

		// @optional -(id<SUVersionDisplay> _Nullable)standardUserDriverRequestsVersionDisplayer;
		[NullAllowed, Export("standardUserDriverRequestsVersionDisplayer")]
		SUVersionDisplay StandardUserDriverRequestsVersionDisplayer { get; }

		// @optional -(void)standardUserDriverShowVersionHistoryForAppcastItem:(SUAppcastItem * _Nonnull)item;
		[Export("standardUserDriverShowVersionHistoryForAppcastItem:")]
		void StandardUserDriverShowVersionHistoryForAppcastItem(SUAppcastItem item);
	}

	// @protocol SUUpdaterDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface SUUpdaterDelegate
	{
		// @optional -(BOOL)updaterMayCheckForUpdates:(SUUpdater * _Nonnull)updater;
		[Export("updaterMayCheckForUpdates:")]
		bool UpdaterMayCheckForUpdates(SUUpdater updater);

		// @optional -(NSArray<NSDictionary<NSString *,NSString *> *> * _Nonnull)feedParametersForUpdater:(SUUpdater * _Nonnull)updater sendingSystemProfile:(BOOL)sendingProfile;
		[Export("feedParametersForUpdater:sendingSystemProfile:")]
		NSDictionary<NSString, NSString>[] FeedParametersForUpdater(SUUpdater updater, bool sendingProfile);

		// @optional -(NSString * _Nullable)feedURLStringForUpdater:(SUUpdater * _Nonnull)updater;
		[Export("feedURLStringForUpdater:")]
		[return: NullAllowed]
		string FeedURLStringForUpdater(SUUpdater updater);

		// @optional -(BOOL)updaterShouldPromptForPermissionToCheckForUpdates:(SUUpdater * _Nonnull)updater;
		[Export("updaterShouldPromptForPermissionToCheckForUpdates:")]
		bool UpdaterShouldPromptForPermissionToCheckForUpdates(SUUpdater updater);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater didFinishLoadingAppcast:(SUAppcast * _Nonnull)appcast;
		[Export("updater:didFinishLoadingAppcast:")]
		void Updater(SUUpdater updater, SUAppcast appcast);

		// @optional -(SUAppcastItem * _Nullable)bestValidUpdateInAppcast:(SUAppcast * _Nonnull)appcast forUpdater:(SUUpdater * _Nonnull)updater;
		[Export("bestValidUpdateInAppcast:forUpdater:")]
		[return: NullAllowed]
		SUAppcastItem BestValidUpdateInAppcast(SUAppcast appcast, SUUpdater updater);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater didFindValidUpdate:(SUAppcastItem * _Nonnull)item;
		[Export("updater:didFindValidUpdate:")]
		void Updater(SUUpdater updater, SUAppcastItem item);

		// @optional -(void)updaterDidNotFindUpdate:(SUUpdater * _Nonnull)updater;
		[Export("updaterDidNotFindUpdate:")]
		void UpdaterDidNotFindUpdate(SUUpdater updater);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater willDownloadUpdate:(SUAppcastItem * _Nonnull)item withRequest:(NSMutableURLRequest * _Nonnull)request;
		[Export("updater:willDownloadUpdate:withRequest:")]
		void Updater(SUUpdater updater, SUAppcastItem item, NSMutableUrlRequest request);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater didDownloadUpdate:(SUAppcastItem * _Nonnull)item;
		[Export("updater:didDownloadUpdate:")]
		void Updater1(SUUpdater updater, SUAppcastItem item);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater failedToDownloadUpdate:(SUAppcastItem * _Nonnull)item error:(NSError * _Nonnull)error;
		[Export("updater:failedToDownloadUpdate:error:")]
		void Updater(SUUpdater updater, SUAppcastItem item, NSError error);

		// @optional -(void)userDidCancelDownload:(SUUpdater * _Nonnull)updater;
		[Export("userDidCancelDownload:")]
		void UserDidCancelDownload(SUUpdater updater);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater willExtractUpdate:(SUAppcastItem * _Nonnull)item;
		[Export("updater:willExtractUpdate:")]
		void Updater2(SUUpdater updater, SUAppcastItem item);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater didExtractUpdate:(SUAppcastItem * _Nonnull)item;
		[Export("updater:didExtractUpdate:")]
		void Updater3(SUUpdater updater, SUAppcastItem item);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater willInstallUpdate:(SUAppcastItem * _Nonnull)item;
		[Export("updater:willInstallUpdate:")]
		void Updater4(SUUpdater updater, SUAppcastItem item);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater userDidSkipThisVersion:(SUAppcastItem * _Nonnull)item;
		[Export("updater:userDidSkipThisVersion:")]
		void Updater5(SUUpdater updater, SUAppcastItem item);

		// @optional -(BOOL)updater:(SUUpdater * _Nonnull)updater shouldPostponeRelaunchForUpdate:(SUAppcastItem * _Nonnull)item untilInvoking:(NSInvocation * _Nonnull)invocation;
		[Export("updater:shouldPostponeRelaunchForUpdate:untilInvoking:")]
		bool Updater(SUUpdater updater, SUAppcastItem item, NSInvocation invocation);

		// @optional -(BOOL)updater:(SUUpdater * _Nonnull)updater shouldPostponeRelaunchForUpdate:(SUAppcastItem * _Nonnull)item;
		[Export("updater:shouldPostponeRelaunchForUpdate:")]
		bool Updater6(SUUpdater updater, SUAppcastItem item);

		// @optional -(BOOL)updaterShouldRelaunchApplication:(SUUpdater * _Nonnull)updater;
		[Export("updaterShouldRelaunchApplication:")]
		bool UpdaterShouldRelaunchApplication(SUUpdater updater);

		// @optional -(void)updaterWillRelaunchApplication:(SUUpdater * _Nonnull)updater;
		[Export("updaterWillRelaunchApplication:")]
		void UpdaterWillRelaunchApplication(SUUpdater updater);

		// @optional -(void)updaterDidRelaunchApplication:(SUUpdater * _Nonnull)updater;
		[Export("updaterDidRelaunchApplication:")]
		void UpdaterDidRelaunchApplication(SUUpdater updater);

		// @optional -(id<SUVersionComparison> _Nullable)versionComparatorForUpdater:(SUUpdater * _Nonnull)updater;
		[Export("versionComparatorForUpdater:")]
		[return: NullAllowed]
		SUVersionComparison VersionComparatorForUpdater(SUUpdater updater);

		// @optional -(id<SUVersionDisplay> _Nullable)versionDisplayerForUpdater:(SUUpdater * _Nonnull)updater;
		[Export("versionDisplayerForUpdater:")]
		[return: NullAllowed]
		SUVersionDisplay VersionDisplayerForUpdater(SUUpdater updater);

		// @optional -(NSString * _Nullable)pathToRelaunchForUpdater:(SUUpdater * _Nonnull)updater;
		[Export("pathToRelaunchForUpdater:")]
		[return: NullAllowed]
		string PathToRelaunchForUpdater(SUUpdater updater);

		// @optional -(void)updaterWillShowModalAlert:(SUUpdater * _Nonnull)updater;
		[Export("updaterWillShowModalAlert:")]
		void UpdaterWillShowModalAlert(SUUpdater updater);

		// @optional -(void)updaterDidShowModalAlert:(SUUpdater * _Nonnull)updater;
		[Export("updaterDidShowModalAlert:")]
		void UpdaterDidShowModalAlert(SUUpdater updater);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater willInstallUpdateOnQuit:(SUAppcastItem * _Nonnull)item immediateInstallationInvocation:(NSInvocation * _Nonnull)invocation;
		[Export("updater:willInstallUpdateOnQuit:immediateInstallationInvocation:")]
		void Updater7(SUUpdater updater, SUAppcastItem item, NSInvocation invocation);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater willInstallUpdateOnQuit:(SUAppcastItem * _Nonnull)item immediateInstallationBlock:(void (^ _Nonnull)(void))installationBlock;
		[Export("updater:willInstallUpdateOnQuit:immediateInstallationBlock:")]
		void Updater(SUUpdater updater, SUAppcastItem item, Action installationBlock);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater didCancelInstallUpdateOnQuit:(SUAppcastItem * _Nonnull)item __attribute__((deprecated("")));
		[Export("updater:didCancelInstallUpdateOnQuit:")]
		void Updater8(SUUpdater updater, SUAppcastItem item);

		// @optional -(void)updater:(SUUpdater * _Nonnull)updater didAbortWithError:(NSError * _Nonnull)error;
		[Export("updater:didAbortWithError:")]
		void Updater(SUUpdater updater, NSError error);
	}

	// @interface SUUpdater : NSObject
	[BaseType(typeof(NSObject))]
	interface SUUpdater
	{
		[Wrap("WeakDelegate")]
		SUUpdaterDelegate Delegate { get; set; }

		// @property (nonatomic, unsafe_unretained) id<SUUpdaterDelegate> delegate __attribute__((iboutlet));
		[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// +(SUUpdater *)sharedUpdater;
		[Static]
		[Export("sharedUpdater")]
		SUUpdater SharedUpdater { get; }

		// +(SUUpdater *)updaterForBundle:(NSBundle *)bundle;
		[Static]
		[Export("updaterForBundle:")]
		SUUpdater UpdaterForBundle(NSBundle bundle);

		// -(instancetype)initForBundle:(NSBundle *)bundle;
		[Export("initForBundle:")]
		IntPtr Constructor(NSBundle bundle);

		// -(void)checkForUpdates:(id)sender __attribute__((ibaction));
		[Export("checkForUpdates:")]
		void CheckForUpdates(NSObject sender);

		// -(BOOL)validateMenuItem:(NSMenuItem *)menuItem;
		[Export("validateMenuItem:")]
		bool ValidateMenuItem(NSMenuItem menuItem);

		// -(void)checkForUpdatesInBackground;
		[Export("checkForUpdatesInBackground")]
		void CheckForUpdatesInBackground();

		// @property (nonatomic) BOOL automaticallyChecksForUpdates;
		[Export("automaticallyChecksForUpdates")]
		bool AutomaticallyChecksForUpdates { get; set; }

		// @property (nonatomic) BOOL automaticallyDownloadsUpdates;
		[Export("automaticallyDownloadsUpdates")]
		bool AutomaticallyDownloadsUpdates { get; set; }

		// @property (nonatomic) NSTimeInterval updateCheckInterval;
		[Export("updateCheckInterval")]
		double UpdateCheckInterval { get; set; }

		// -(void)checkForUpdateInformation;
		[Export("checkForUpdateInformation")]
		void CheckForUpdateInformation();

		// @property (copy, nonatomic) NSURL * feedURL;
		[Export("feedURL", ArgumentSemantic.Copy)]
		NSUrl FeedURL { get; set; }

		// @property (readonly, nonatomic) NSBundle * hostBundle;
		[Export("hostBundle")]
		NSBundle HostBundle { get; }

		// @property (readonly, nonatomic) NSBundle * sparkleBundle;
		[Export("sparkleBundle")]
		NSBundle SparkleBundle { get; }

		// @property (copy, nonatomic) NSString * userAgentString;
		[Export("userAgentString")]
		string UserAgentString { get; set; }

		// @property (copy) NSDictionary<NSString *,NSString *> * httpHeaders;
		[Export("httpHeaders", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> HttpHeaders { get; set; }

		// @property (nonatomic) BOOL sendsSystemProfile;
		[Export("sendsSystemProfile")]
		bool SendsSystemProfile { get; set; }

		// @property (copy, nonatomic) NSString * decryptionPassword;
		[Export("decryptionPassword")]
		string DecryptionPassword { get; set; }

		// @property (readonly, copy, nonatomic) NSDate * lastUpdateCheckDate;
		[Export("lastUpdateCheckDate", ArgumentSemantic.Copy)]
		NSDate LastUpdateCheckDate { get; }

		// -(void)resetUpdateCycle;
		[Export("resetUpdateCycle")]
		void ResetUpdateCycle();

		// @property (readonly, nonatomic) BOOL updateInProgress;
		[Export("updateInProgress")]
		bool UpdateInProgress { get; }
	}

}