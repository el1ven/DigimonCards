﻿

#pragma checksum "C:\Users\lhc\Documents\Visual Studio 2012\Projects\DigimonCard\DigimonCard\RegistPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B81D51961266932C360ADAEEA6A35BB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigimonCard
{
    partial class RegistPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 26 "..\..\RegistPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.register_Name_TextChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 29 "..\..\RegistPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 30 "..\..\RegistPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click_1;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

