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
    public sealed partial class ShootingStatsTable : Page
    {
        private int _twoPointAttempts = 0;
        private int _freethrowAttempts = 0;
        private int _threePointAttempts = 0;
        private int _twoPointHits = 0;
        private int _freethrowHits = 0;
        private int _threePointHits = 0;
        private string _startTime;
        private string _endTime;
        private Control _control;

        public int TwoPointAttempts { set { _twoPointAttempts = value; } }
        public int FreethrowAttempts { set { _freethrowAttempts = value; } }
        public int ThreePointAttempts { set { _threePointAttempts = value; } }
        public int TwoPointHits { set { _twoPointHits = value; } }
        public int FreethrowHits { set { _freethrowHits = value; } }
        public int ThreePointHits { set { _threePointHits = value; } }
        public string StartTime { set { _startTime = value; } }
        public string EndTime { set { _endTime = value; } }
        public ShootingStatsTable()
        {
            this.InitializeComponent();
            _control = Control.Instance;
            _control.GetShootingValues(this);
            FillTable();
        }
        private string PrintHitRate(int att, int hits)
        {
            if (att != 0)
                return String.Format("{0}%", Math.Round(((double)hits / att) * 100));
            else
                return String.Format("0%");
        }
        private string PrintTries(int att, int hits)
        {
            return String.Format("{0}/{1}", hits, att);
        }
        private void FillTable()
        {
            txt_freethrowTries.Text = PrintTries(_freethrowAttempts, _freethrowHits);
            txt_twoPointTries.Text = PrintTries(_twoPointAttempts, _twoPointHits);
            txt_threePointTries.Text = PrintTries(_threePointAttempts, _threePointHits);

            txt_freethrowRate.Text = PrintHitRate(_freethrowAttempts, _freethrowHits);
            txt_twoPointRate.Text = PrintHitRate(_twoPointAttempts, _twoPointHits);
            txt_threePointRate.Text = PrintHitRate(_threePointAttempts, _threePointHits);

            txt_endTime.Text = String.Format("bis {0}", _endTime);
            txt_startTime.Text = String.Format("Von {0}", _startTime);
        }
    }
}
