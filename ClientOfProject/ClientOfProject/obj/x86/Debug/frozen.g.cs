﻿#pragma checksum "F:\כיתה י'ב\תכנות\פרויקט כיתה יב שהגשתי\הפרויקט סופי\ClientOfProject\ClientOfProject\frozen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AB41F287474707A9DFA2E3F1FD3862AF0C6AC0A9A216D23BB9C0A20B5092B056"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientOfProject
{
    partial class frozen : 
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
            case 2: // frozen.xaml line 59
                {
                    this.lvCategory = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3: // frozen.xaml line 67
                {
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element3 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element3).Click += this.HyperlinkButton_Click;
                }
                break;
            case 4: // frozen.xaml line 74
                {
                    this.lvspecial = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5: // frozen.xaml line 77
                {
                    this.cSpecial = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 9: // frozen.xaml line 62
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Tapped += this.Button_Click;
                }
                break;
            case 10: // frozen.xaml line 39
                {
                    this.lvAddition = (global::Windows.UI.Xaml.Controls.ListView)(target);
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

