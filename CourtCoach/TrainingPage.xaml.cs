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
        static BitmapImage ShootingBG = new BitmapImage(new Uri("ms-appx:///Assets/Shoot.jpg"));
        static BitmapImage HandleBG = new BitmapImage(new Uri("ms-appx:///Assets/handleOne.jpg"));
        private Control _control;


        public TrainingPage()
        {
            this.InitializeComponent();
            shootBG.Source=ShootingBG;
            handleBG.Source=HandleBG;
            _control = Control.Instance;
        }
        private void uc_shooting_OnClick(object sender, EventArgs e)
        {
            _control.Navigate(typeof(Shooting));
        }

        private void uc_handling_OnClick(object sender, EventArgs e)
        {
            //Handling page missing yet
            _control.Navigate(typeof(MainPage));
        }
    }
}
