﻿#pragma checksum "..\..\..\Add Windows\AddManually_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F6CCBEFEAD72A76B9B1F90775287725FACFCC429C83E19CB01337067DBA16F62"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Autolect;
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


namespace Autolect {
    
    
    /// <summary>
    /// AddManually_Window
    /// </summary>
    public partial class AddManually_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Add Windows\AddManually_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Autolect.AddManually_Window window;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Add Windows\AddManually_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IMG_Icon;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Add Windows\AddManually_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_Close;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Add Windows\AddManually_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_OpenFile;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Add Windows\AddManually_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_SaveFile;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Add Windows\AddManually_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Participants;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Add Windows\AddManually_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_Add;
        
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
            System.Uri resourceLocater = new System.Uri("/Autolect;component/add%20windows/addmanually_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Add Windows\AddManually_Window.xaml"
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
            this.window = ((Autolect.AddManually_Window)(target));
            return;
            case 2:
            
            #line 13 "..\..\..\Add Windows\AddManually_Window.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_Header_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.IMG_Icon = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.BT_Close = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Add Windows\AddManually_Window.xaml"
            this.BT_Close.Click += new System.Windows.RoutedEventHandler(this.BT_Close_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BT_OpenFile = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Add Windows\AddManually_Window.xaml"
            this.BT_OpenFile.Click += new System.Windows.RoutedEventHandler(this.BT_OpenFile_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BT_SaveFile = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Add Windows\AddManually_Window.xaml"
            this.BT_SaveFile.Click += new System.Windows.RoutedEventHandler(this.BT_SaveFile_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TB_Participants = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BT_Add = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Add Windows\AddManually_Window.xaml"
            this.BT_Add.Click += new System.Windows.RoutedEventHandler(this.BT_Add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

