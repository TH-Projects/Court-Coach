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
        static BitmapImage PlaceholderBG = new BitmapImage(new Uri("ms-appx:///Assets/placeholder.png"));
        public TrainingPage()
        {
            this.InitializeComponent();
            placehold1.Source=PlaceholderBG;
            placeholder2.Source=PlaceholderBG;
        }

        private void btn_backToMainMenue_Click(object sender, RoutedEventArgs e)
        {
            this.Content= new MainPage();   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Shooting();
        }
    }
}
