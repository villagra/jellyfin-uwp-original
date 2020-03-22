using Windows.Storage;

namespace jellyfin_uwp
{
    public static class SettingsStore
    {
        public static string AppURL {
            get => "https://demo.jellyfin.org/stable"; //(string)(_localSettings.Values["settings.app.AppURL"] ?? string.Empty);
            set => ApplicationData.Current.LocalSettings.Values["settings.app.AppURL"] = value;
        }

        public static bool AppURLValid {
            get => true; //(bool)(_localSettings.Values["settings.app.AppURLValid"] ?? false);
            set => ApplicationData.Current.LocalSettings.Values["settings.app.AppURLValid"] = value;
        }

        public static bool AppURLIsJellyfin {
            get => true; //(bool)(_localSettings.Values["settings.app.AppURLIsJellyfin"] ?? false);
            set => ApplicationData.Current.LocalSettings.Values["settings.app.AppURLIsJellyfin"] = value;
        }

    }
}
