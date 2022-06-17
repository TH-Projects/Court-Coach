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
    public sealed partial class StatsFrame : Page
    {
        private Control _control;
        public StatsFrame()
        {
            this.InitializeComponent();
            _control = Control.Instance;
            switch (_control.StatsType)
            {
                case "S":
                    fr_content.Navigate(typeof(ShootingStatsTable));
                    break;
            }
            UpdateButtons();
        }
        private void btn_NextTable_OnClick(object sender, EventArgs e)
        {
            _control.CurrentStatsPageNum++;
            UpdateButtons();
            fr_content.Navigate(typeof(ShootingStatsTable));
        }

        private void btn_PreviousTable_OnClick(object sender, EventArgs e)
        {
            _control.CurrentStatsPageNum--;
            UpdateButtons();
            fr_content.Navigate(typeof(ShootingStatsTable));
        }

        private void UpdateButtons()
        {
            if (_control.CurrentStatsPageNum < _control.ShootingSessions.Count - 1)
            {
                btn_NextTable.IsEnabled = true;
            }
            else
            {
                btn_NextTable.IsEnabled = false;
            }
            if (_control.CurrentStatsPageNum > 0)
            {
                btn_PreviousTable.IsEnabled = true;
            }
            else
            {
                btn_PreviousTable.IsEnabled = false;
            }
        }
    }
}
