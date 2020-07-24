﻿#pragma checksum "..\..\..\MainWindow (2).xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89653D2C1DB41E9790F9D850879895ADDC94473D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DesktopChat;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace DesktopChat {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\MainWindow (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LabelLogin;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\MainWindow (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputLogin;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainWindow (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LabelPassword;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox InputPassword;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MainWindow (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserListSearching;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\MainWindow (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UsersList;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\MainWindow (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefreshUserList;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/administration;component/mainwindow%20(2).xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow (2).xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\MainWindow (2).xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.UIElement_OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LabelLogin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.InputLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.LabelPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.InputPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            
            #line 37 "..\..\..\MainWindow (2).xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonRegister_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.UserListSearching = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\MainWindow (2).xaml"
            this.UserListSearching.GotFocus += new System.Windows.RoutedEventHandler(this.UserListSearching_GotFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.UsersList = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.RefreshUserList = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\MainWindow (2).xaml"
            this.RefreshUserList.Click += new System.Windows.RoutedEventHandler(this.Refresh_Users);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

