﻿#pragma checksum "..\..\Offert.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0511D15F5F91CA37B2CF45043DB0EA16FB7A9B52D130FC120D9A7A1C74887E70"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Sotov;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Sotov {
    
    
    /// <summary>
    /// Offert
    /// </summary>
    public partial class Offert : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Head;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Head2;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Return;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border UpHead;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Main;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Name;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Phone;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Zakaz;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_dost;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_Nal;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_Online;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Offert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Add;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Sotov;component/offert.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Offert.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Head = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.Head2 = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.Return = ((System.Windows.Controls.Label)(target));
            
            #line 39 "..\..\Offert.xaml"
            this.Return.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Return_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UpHead = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.Main = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.tb_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tb_Phone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tb_Zakaz = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.CB_dost = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.cb_Nal = ((System.Windows.Controls.CheckBox)(target));
            
            #line 62 "..\..\Offert.xaml"
            this.cb_Nal.Checked += new System.Windows.RoutedEventHandler(this.cb_Nal_Checked);
            
            #line default
            #line hidden
            
            #line 62 "..\..\Offert.xaml"
            this.cb_Nal.Unchecked += new System.Windows.RoutedEventHandler(this.cb_Nal_Unchecked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cb_Online = ((System.Windows.Controls.CheckBox)(target));
            
            #line 64 "..\..\Offert.xaml"
            this.cb_Online.Checked += new System.Windows.RoutedEventHandler(this.cb_Online_Checked);
            
            #line default
            #line hidden
            
            #line 64 "..\..\Offert.xaml"
            this.cb_Online.Unchecked += new System.Windows.RoutedEventHandler(this.cb_Online_Unchecked);
            
            #line default
            #line hidden
            return;
            case 12:
            this.bt_Add = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\Offert.xaml"
            this.bt_Add.Click += new System.Windows.RoutedEventHandler(this.bt_Add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

