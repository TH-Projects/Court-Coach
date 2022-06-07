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
    public sealed partial class ResponsiveTextBlock : UserControl
    {
        private int _maxTextHeight = 9999;

        public string Text { set { txt.Text = value; } }
        public int MaxTextHeight { set { _maxTextHeight = value; } }
        public ResponsiveTextBlock()
        {
            this.InitializeComponent();
            txt.Text = "No text loaded";
        }

    }
}
