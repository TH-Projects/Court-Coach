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
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace CourtCoach
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainMenue : Page
    {
        private static BitmapImage s_mainBackground = new BitmapImage(new Uri("ms-appx:///Assets/Fotolia_149218236_XL.jpg"));
        private static BitmapImage s_mainLogo = new BitmapImage(new Uri("ms-appx:///Assets/CourtCoach.png"));
        private Control _control;
        public MainMenue()
        {
            this.InitializeComponent();
            img_background.Source = s_mainBackground;
            img_logo.Source = s_mainLogo;
            _control = Control.Instance;
        }
        private void uc_stats_OnClick(object sender, EventArgs e)
        {
            _control.Navigate(typeof(StatisticPage));
        }
        private void uc_training_OnClick(object sender, EventArgs e)
        {
            _control.Navigate(typeof(TrainingPage));
        }
    }
}
