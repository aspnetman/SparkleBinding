using ObjCRuntime;

namespace Sparkle
{
	[Native]
	public enum SPUUserUpdateChoice : long
	{
		Skip,
		Install,
		Dismiss
	}

	[Native]
	public enum SPUUserUpdateStage : long
	{
		NotDownloaded,
		Downloaded,
		Installing
	}

	[Native]
	public enum SPUUpdateCheck : long
	{
		s = 0,
		sInBackground = 1,
		Information = 2
	}

	public enum SUError
	{
		NoPublicDSAFoundError = 1,
		InsufficientSigningError = 2,
		InsecureFeedURLError = 3,
		InvalidFeedURLError = 4,
		InvalidUpdaterError = 5,
		InvalidHostBundleIdentifierError = 6,
		InvalidHostVersionError = 7,
		AppcastParseError = 1000,
		NoUpdateError = 1001,
		AppcastError = 1002,
		RunningFromDiskImageError = 1003,
		ResumeAppcastError = 1004,
		RunningTranslocated = 1005,
		WebKitTerminationError = 1006,
		TemporaryDirectoryError = 2000,
		DownloadError = 2001,
		UnarchivingError = 3000,
		SignatureError = 3001,
		ValidationError = 3002,
		FileCopyFailure = 4000,
		AuthenticationFailure = 4001,
		MissingUpdateError = 4002,
		MissingInstallerToolError = 4003,
		RelaunchError = 4004,
		InstallationError = 4005,
		DowngradeError = 4006,
		InstallationCanceledError = 4007,
		InstallationAuthorizeLaterError = 4008,
		NotValidUpdateError = 4009,
		AgentInvalidationError = 4010,
		IncorrectAPIUsageError = 5000
	}

	public enum SPUNoUpdateFoundReason
	{
		Unknown,
		OnLatestVersion,
		OnNewerThanLatestVersion,
		SystemIsTooOld,
		SystemIsTooNew
	}
}