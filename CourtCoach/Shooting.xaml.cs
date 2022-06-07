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
        private Control _control;
        public Shooting()
        {
            this.InitializeComponent();
            MainBG.Source = PlaceholderBG;
            _control = Control.Instance;
            DisableAll();
            ResetRate();
            
        }
        private string PrintHitRate(int att, int hits)
        {
            if (att != 0)
                return String.Format("{0}/{1}, {2}%", hits, att, Math.Round(((double)hits / att) * 100));
            else
                return String.Format("0/0, 0%");
        }

        private void uc_FreethrowHit_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("free", true);
            FreethrowRate.Text = PrintHitRate(_control.GetRate("FA"), _control.GetRate("FH"));
        }

        private void uc_TwoPointHit_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("two", true);
            TwoPointRate.Text = PrintHitRate(_control.GetRate("2A"), _control.GetRate("2H"));
        }

        private void uc_ThreePointHit_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("three", true);
            ThreePointRate.Text = PrintHitRate(_control.GetRate("3A"), _control.GetRate("3H"));
        }

        private void uc_FreethrowMiss_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("free", false);
            FreethrowRate.Text = PrintHitRate(_control.GetRate("FA"), _control.GetRate("FH"));
        }

        private void uc_TwoPointMiss_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("two", false);
            TwoPointRate.Text = PrintHitRate(_control.GetRate("2A"), _control.GetRate("2H"));
        }

        private void uc_ThreePointMiss_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("three", false);
            ThreePointRate.Text = PrintHitRate(_control.GetRate("3A"), _control.GetRate("3H"));
        }

        private void uc_saveSession_OnClick(object sender, EventArgs e)
        {
            DisableAll();
            ResetRate();
        }

        private void uc_startSession_OnClick(object sender, EventArgs e)
        {
            _control.AddShootingSession();
            EnableAll();
        }

        private void EnableAll()
        {
            uc_FreethrowHit.IsEnabled = true;
            uc_FreethrowMiss.IsEnabled = true;
            uc_TwoPointHit.IsEnabled = true;
            uc_TwoPointMiss.IsEnabled = true;
            uc_ThreePointMiss.IsEnabled = true;
            uc_ThreePointHit.IsEnabled = true;
        }

        private void DisableAll()
        {
            uc_FreethrowHit.IsEnabled = false;
            uc_FreethrowMiss.IsEnabled = false;
            uc_TwoPointHit.IsEnabled = false;
            uc_TwoPointMiss.IsEnabled = false;
            uc_ThreePointMiss.IsEnabled = false;
            uc_ThreePointHit.IsEnabled = false;
        }
        private void ResetRate()
        {
            FreethrowRate.Text = PrintHitRate(0, 0);
            TwoPointRate.Text = PrintHitRate(0, 0);
            ThreePointRate.Text = PrintHitRate(0, 0);
        }
        
    }
}
