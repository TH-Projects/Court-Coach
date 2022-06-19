using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace CourtCoach
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Control _control;
        public static MainPage Instance { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();
            Instance = this;
            _control = Control.Instance;
            fr_content.Navigated += OnNavigated;
            fr_content.Navigate(typeof(MainMenue));
            this.Loading += OnLoading;
        }
        private async void OnLoading(object sender,object arg)
        {
            await _control.LoadSessionData();
        }
        private void OnNavigated(object sender, NavigationEventArgs args)
        {
            if (args.SourcePageType == typeof(MainMenue))
                btn_pageReturn.Visibility = Visibility.Collapsed;
            else
                btn_pageReturn.Visibility = Visibility.Visible;
        }

        public void NavigateTo(Type page)
        {
            fr_content.Navigate(page);
        }

        private void btn_pageReturn_OnClick(object sender, EventArgs e)
        {
            if (fr_content.CanGoBack)
                fr_content.GoBack();
        }
    }
}
