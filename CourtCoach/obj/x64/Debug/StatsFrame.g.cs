﻿#pragma checksum "C:\Users\Timo Heckmann\Documents\GithubLocal\CourtCoach\CourtCoach\StatsFrame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8E9DB4F7BB04DA572F2B1F6B74D55555ABE8E0B98B773BE8FA09BD7D175344C0"
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
    partial class StatsFrame : 
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
            case 2: // StatsFrame.xaml line 38
                {
                    this.fr_content = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3: // StatsFrame.xaml line 31
                {
                    this.btn_NextTable = (global::CourtCoach.ResponsiveButton)(target);
                    ((global::CourtCoach.ResponsiveButton)this.btn_NextTable).OnClick += this.btn_NextTable_OnClick;
                }
                break;
            case 4: // StatsFrame.xaml line 24
                {
                    this.btn_PreviousTable = (global::CourtCoach.ResponsiveButton)(target);
                    ((global::CourtCoach.ResponsiveButton)this.btn_PreviousTable).OnClick += this.btn_PreviousTable_OnClick;
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

