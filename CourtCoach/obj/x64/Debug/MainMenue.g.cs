﻿#pragma checksum "C:\Users\Timo Heckmann\Documents\GitHubLocal\Court-Coach\CourtCoach\MainMenue.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37114AEE3DFED9E7640D7CC2C47CE479F873B3F8D596213205DB650C64AA79B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourtCoach
{
    partial class MainMenue : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainMenue.xaml line 17
                {
                    this.img_background = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3: // MainMenue.xaml line 52
                {
                    this.uc_stats = (global::CourtCoach.ResponsiveButton)(target);
                    ((global::CourtCoach.ResponsiveButton)this.uc_stats).OnClick += this.uc_stats_OnClick;
                }
                break;
            case 4: // MainMenue.xaml line 45
                {
                    this.uc_training = (global::CourtCoach.ResponsiveButton)(target);
                    ((global::CourtCoach.ResponsiveButton)this.uc_training).OnClick += this.uc_training_OnClick;
                }
                break;
            case 5: // MainMenue.xaml line 26
                {
                    this.img_logo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

