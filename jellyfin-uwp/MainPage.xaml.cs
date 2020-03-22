using Windows.UI.Xaml.Controls;

namespace jellyfin_uwp
{
    /// <summary>
    /// MainPage controls frame switching and global settings
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            /*
            globalSettingsStore = new SettingsStore();

            jfFrame = JellyfinFrame;

            if (!globalSettingsStore.AppURLValid)
            {
                JellyfinFrame.Navigate(typeof(AppSettings));
            }
            else {
                JellyfinFrame.Navigate(typeof(WebView));
            }
            */
        }
    }
}
