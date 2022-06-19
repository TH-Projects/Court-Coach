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
        private static BitmapImage s_background = new BitmapImage(new Uri("ms-appx:///Assets/Basketball_spielende_Jugendliche_in_der_Panzerhalle_in_Tübingen.jpg"));
        private Control _control;

        public Shooting()
        {
            this.InitializeComponent();
            img_mainBackground.Source = s_background;
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

        private void EnableAll()
        {
            btn_freethrowHit.IsEnabled = true;
            btn_freethrowMiss.IsEnabled = true;
            btn_twoPointHit.IsEnabled = true;
            btn_twoPointMiss.IsEnabled = true;
            btn_threePointMiss.IsEnabled = true;
            btn_threePointHit.IsEnabled = true;
        }

        private void DisableAll()
        {
            btn_freethrowHit.IsEnabled = false;
            btn_freethrowMiss.IsEnabled = false;
            btn_twoPointHit.IsEnabled = false;
            btn_twoPointMiss.IsEnabled = false;
            btn_threePointMiss.IsEnabled = false;
            btn_threePointHit.IsEnabled = false;
        }

        private void ResetRate()
        {
            txt_freethrowRate.Text = PrintHitRate(0, 0);
            txt_twoPointRate.Text = PrintHitRate(0, 0);
            txt_threePointRate.Text = PrintHitRate(0, 0);
        }

        private void btn_startSession_OnClick(object sender, EventArgs e)
        {
            _control.AddShootingSession();
            EnableAll();
        }

        private void btn_saveSession_OnClick(object sender, EventArgs e)
        {
            _control.EndShootingSession();
            DisableAll();
            ResetRate();
        }

        private void btn_threePointMiss_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("three", false);
            txt_threePointRate.Text = PrintHitRate(_control.GetRate("3A"), _control.GetRate("3H"));
        }

        private void btn_twoPointMiss_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("two", false);
            txt_twoPointRate.Text = PrintHitRate(_control.GetRate("2A"), _control.GetRate("2H"));
        }

        private void btn_freethrowMiss_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("free", false);
            txt_freethrowRate.Text = PrintHitRate(_control.GetRate("FA"), _control.GetRate("FH"));
        }

        private void btn_threePointHit_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("three", true);
            txt_threePointRate.Text = PrintHitRate(_control.GetRate("3A"), _control.GetRate("3H"));
        }

        private void btn_twoPointHit_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("two", true);
            txt_twoPointRate.Text = PrintHitRate(_control.GetRate("2A"), _control.GetRate("2H"));
        }

        private void btn_freethrowHit_OnClick(object sender, EventArgs e)
        {
            _control.incCounter("free", true);
            txt_freethrowRate.Text = PrintHitRate(_control.GetRate("FA"), _control.GetRate("FH"));
        }
    }
}
