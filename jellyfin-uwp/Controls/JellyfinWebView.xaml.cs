using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace jellyfin_uwp.Controls
{
    public sealed partial class JellyfinWebView : UserControl
    {
        public JellyfinWebView()
        {
            this.InitializeComponent();

            WView.ContainsFullScreenElementChanged += JellyfinWebView_ContainsFullScreenElementChanged;
            WView.NavigationCompleted += JellyfinWebView_NavigationCompleted;

            WView.Navigate(new Uri(SettingsStore.AppURL));
        }

        private async void JellyfinWebView_NavigationCompleted(Windows.UI.Xaml.Controls.WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            await WView.InvokeScriptAsync("eval", new string[] { "navigator.gamepadInputEmulation = 'gamepad';" });
        }

        private void JellyfinWebView_ContainsFullScreenElementChanged(Windows.UI.Xaml.Controls.WebView sender, object args)
        {
            ApplicationView appView = ApplicationView.GetForCurrentView();

            if (sender.ContainsFullScreenElement)
            {
                appView.TryEnterFullScreenMode();
                return;
            }

            if (!appView.IsFullScreenMode)
            {
                return;
            }

            appView.ExitFullScreenMode();
        }
    }
}
