﻿#pragma checksum "..\..\..\View\AdminPassWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F4B26B0A91524CE60F93BCB87E7BDF25FCDF1C0B04DBC9F950D8D3864D3F3A75"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LittleShop.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace LittleShop.View {
    
    
    /// <summary>
    /// AdminPassWindow
    /// </summary>
    public partial class AdminPassWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\View\AdminPassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Exit;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\View\AdminPassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox login;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\View\AdminPassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox password;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\View\AdminPassWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Login;
        
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
            System.Uri resourceLocater = new System.Uri("/LittleShop;component/view/adminpasswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AdminPassWindow.xaml"
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
            this.b_Exit = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\View\AdminPassWindow.xaml"
            this.b_Exit.Click += new System.Windows.RoutedEventHandler(this.b_Exit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.login = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\View\AdminPassWindow.xaml"
            this.login.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.login_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.b_Login = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\View\AdminPassWindow.xaml"
            this.b_Login.Click += new System.Windows.RoutedEventHandler(this.b_LogIn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

