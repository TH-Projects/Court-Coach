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

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace CourtCoach
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class ShootingStatsTable : Page
    {
        private int _twoPointAttempts = 0;
        private int _freethrowAttempts = 0;
        private int _threePointAttempts = 0;
        private int _twoPointHits = 0;
        private int _freethrowHits = 0;
        private int _threePointHits = 0;
        private Control _control;

        public int TwoPointAttempts { set { _twoPointAttempts = value; } }
        public int FreethrowAttempts { set { _freethrowAttempts = value; } }
        public int ThreePointAttempts { set { _threePointAttempts = value; } }
        public int TwoPointHits { set { _twoPointHits = value; } }
        public int FreethrowHits { set { _freethrowHits = value; } }
        public int ThreePointHits { set { _threePointHits = value; } }
        public ShootingStatsTable()
        {
            this.InitializeComponent();
            _control = Control.Instance;
            _control.SplitSessionList();
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
            FreethrowTries.Text = PrintTries(_freethrowAttempts, _freethrowHits);
            TwoPointTries.Text = PrintTries(_twoPointAttempts, _twoPointHits);
            ThreePointTries.Text = PrintTries(_threePointAttempts, _threePointHits);

            FreethrowRate.Text = PrintHitRate(_freethrowAttempts, _freethrowHits);
            TwoPointRate.Text = PrintHitRate(_twoPointAttempts, _twoPointHits);
            ThreePointRate.Text = PrintHitRate(_threePointAttempts, _threePointHits);
        }
    }
}
