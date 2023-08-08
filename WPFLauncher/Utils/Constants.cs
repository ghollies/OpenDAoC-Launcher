namespace WPFLauncher
{
    internal class Constants
    {
        public const string LauncherVersion = "1.0.0";

        #region Patcher

        public const string LauncherUpdaterName = "AriadolisReloadedLauncher_Update.exe";
        public const string AppData = @"%AppData%\";
        public const string UserPath = "\\Electronic Arts\\Dark Age of Camelot\\AriadolisReloaded\\user.dat";
        
        public const string
            RemoteVersionUrl = "http://localhost:8080/version-new.txt";
        public const string
            RemoteFileList = "http://localhost:8080/patchlist-new.txt"; 
        
        public static string RemoteFilePath;

        #endregion

        #region gameserver

        public const string LiveIP = "34.95.24.250";
        public const string PtrIP = "ptr.atlasfreeshard.com";
        public const string QueueApiIP = "https://queue.atlasfreeshard.com";

        #endregion

        #region Player Urls

        public const string RegisterUrl = "https://atlasl.ink/register";
        public const string LinkUrl = "https://atlasl.ink/link-discord";
        public const string PatchNotesUrl = "https://discord.com/channels/1128756393139261523/1128777773155098654";
        
        #endregion
        
        #region Messages

        public const string MessageDownloadError = "Error downloading files. Please try again later.";
        public const string MessageInvalidCredentials = "An account with these credentials could not be found. Invalid account name or password.";
        public const string MessageNotInQueue = "Your account is not in the queue. Please re-open the launcher!";
        public const string MessageQueueError = "Error communicating with Queue Service. Please try again later. If this continues to occur please contact AriadolisReloaded Staff.";
        public const string MessageNoCredentials = "Please enter your account and password.";
        
        public const string DiscordMessage = "Linking the account to Discord is now required to play on AriadolisReloaded. Would you like to do this now?";
        public const string DiscordCaption = "Game account not linked to Discord";
        public const string DiscordError = "You won't be able to play on AriadolisReloaded without linking your account to Discord";

        public const string MessageReviewInstallation =
            "There was an error launching the game; please review your installation.";

        #endregion
    }
}