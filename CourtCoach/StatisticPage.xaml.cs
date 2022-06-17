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
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class StatisticPage : Page
    {
        static BitmapImage PlaceholderBG = new BitmapImage(new Uri("ms-appx:///Assets/Basketball_spielende_Jugendliche_in_der_Panzerhalle_in_Tübingen.jpg"));
        private Control _control;
        public StatisticPage()
        {
            this.InitializeComponent();
            _control = Control.Instance;
        }

        private void uc_handlingStats_OnClick(object sender, EventArgs e)
        {
            _control.StatsType = "H";
            _control.Navigate(typeof(StatsFrame));
        }

        private void uc_shootingStats_OnClick(object sender, EventArgs e)
        {
            _control.StatsType = "S";
            _control.Navigate(typeof(StatsFrame));
        }
    }
}
