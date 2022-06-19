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
    public sealed partial class TrainingPage : Page
    {
        private static BitmapImage s_shootingBG = new BitmapImage(new Uri("ms-appx:///Assets/Shoot.jpg"));
        private static BitmapImage s_handleBG = new BitmapImage(new Uri("ms-appx:///Assets/handleOne.jpg"));
        private Control _control;

        public TrainingPage()
        {
            this.InitializeComponent();
            _control = Control.Instance;
            img_shootBackground.Source = s_shootingBG;
            img_handleBackground.Source = s_handleBG;
        }

        private void btn_shooting_OnClick(object sender, EventArgs e)
        {
            _control.Navigate(typeof(Shooting));
        }

        private void btn_handling_OnClick(object sender, EventArgs e)
        {
            //Handling page missing yet
            _control.Navigate(typeof(MainPage));
        }
    }
}
