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
    public sealed partial class Shooting : Page
    {
        static BitmapImage PlaceholderBG = new BitmapImage(new Uri("ms-appx:///Assets/Basketball_spielende_Jugendliche_in_der_Panzerhalle_in_Tübingen.jpg"));
        public Shooting()
        {
            this.InitializeComponent();
            MainBG.Source = PlaceholderBG;
        }

        private void backToTrainingPage(object sender, RoutedEventArgs e)
        {
            this.Content = new TrainingPage();
        }
    }
}
