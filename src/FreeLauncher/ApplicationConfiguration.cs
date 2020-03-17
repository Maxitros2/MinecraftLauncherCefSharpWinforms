namespace FreeLauncher
{
    public class ApplicationConfiguration
    {
        public bool CheckLauncherUpdates { get; set; } = false;
        public bool SkipAssetsDownload { get; set; }
        public bool EnableGameLogging { get; set; }
        public bool CloseTabAfterSuccessfulExitCode { get; set; } = true;
        public string SelectedLanguage { get; set; } = "ru_RU";
        public bool SnapEnable { get; set; } = false;
        public bool FullSceen { get; set; } = false;
        public bool Hkey { get; set; } = false;
    }
}
