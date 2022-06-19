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

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace CourtCoach
{
    public sealed partial class StatisticPage : Page
    {
        private static BitmapImage s_background = new BitmapImage(new Uri("ms-appx:///Assets/LayupOne.jpg"));
        private Control _control;
        public StatisticPage()
        {
            this.InitializeComponent();
            img_background.Source = s_background;
            _control = Control.Instance;
            _control.SplitSessionList();
        }

        private void btn_shootingStats_OnClick(object sender, EventArgs e)
        {
            _control.StatsType = "S";
            _control.Navigate(typeof(StatsFrame));
        }

        private void btn_handlingStats_OnClick(object sender, EventArgs e)
        {
            _control.StatsType = "H";
            _control.Navigate(typeof(StatsFrame));
        }
    }
}
