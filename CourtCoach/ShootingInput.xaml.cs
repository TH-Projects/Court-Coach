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

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace CourtCoach
{
    public sealed partial class ShootingInput : UserControl
    {
        private int TwoPointAttempts = 0;
        private int FreethrowAttempts = 0;
        private int ThreePointAttempts = 0;
        private int TwoPointHits = 0;
        private int FreethrowHits = 0;
        private int ThreePointHits = 0;
        public ShootingInput()
        {
            this.InitializeComponent();
            FreethrowRate.Text = PrintHitRate(0, 0);
            TwoPointRate.Text = PrintHitRate(0, 0);
            ThreePointRate.Text = PrintHitRate(0, 0);
        }

        private string PrintHitRate( int att, int hits)
        {
            if (att != 0)
                return String.Format("{0}/{1}, {2}%", hits, att, Math.Round(((double)hits / att) * 100));
            else
                return String.Format("0/0, 0%");
        }
        private void btn_FreethrowHit_Click(object sender, RoutedEventArgs e)
        {
            incFreethrow(true);
            PrintHitRate(FreethrowAttempts, FreethrowHits);
            FreethrowRate.Text = PrintHitRate(FreethrowAttempts, FreethrowHits);
        }

        private void btn_FreethrowMiss_Click(object sender, RoutedEventArgs e)
        {
            incFreethrow(false);
            FreethrowRate.Text = PrintHitRate(FreethrowAttempts, FreethrowHits);
        }
        private void incFreethrow(bool hit)
        {
            if (hit)
                FreethrowHits++;
            FreethrowAttempts++;
        }

        private void btn_TwoPointHit_Click(object sender, RoutedEventArgs e)
        {
            incTwoPointer(true);
            TwoPointRate.Text = PrintHitRate(TwoPointAttempts, TwoPointHits);
        }

        private void btn_TwoPointMiss_Click(object sender, RoutedEventArgs e)
        {
            incTwoPointer(false);
            TwoPointRate.Text = PrintHitRate(TwoPointAttempts, TwoPointHits);
        }
        private void incTwoPointer(bool hit)
        {
            if (hit)
                TwoPointHits++;
            TwoPointAttempts++;
        }

        private void btn_ThreePointHit_Click(object sender, RoutedEventArgs e)
        {
            incThreePointer(true);
            ThreePointRate.Text = PrintHitRate(ThreePointAttempts, ThreePointHits);
        }

        private void btn_ThreePointMiss_Click(object sender, RoutedEventArgs e)
        {
            incThreePointer(false);
            ThreePointRate.Text = PrintHitRate(ThreePointAttempts, ThreePointHits);
        }
        private void incThreePointer(bool hit)
        {
            if (hit)
                ThreePointHits++;
            ThreePointAttempts++;
        }
    }
}
