﻿#pragma checksum "..\..\..\View\PricesWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0BBEE7C1A4BD7B9A58C0808806C4B4BA93C033188BDD3CE0D507AC484AA8B043"
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
    /// PricesWindow
    /// </summary>
    public partial class PricesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\View\PricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_BackToMenu;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\View\PricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentPresenter imgContent;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\View\PricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentPresenter imgContent2;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\View\PricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PageNum;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\View\PricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Back;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\View\PricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Next;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\View\PricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Save;
        
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
            System.Uri resourceLocater = new System.Uri("/LittleShop;component/view/priceswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\PricesWindow.xaml"
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
            this.b_BackToMenu = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\View\PricesWindow.xaml"
            this.b_BackToMenu.Click += new System.Windows.RoutedEventHandler(this.b_BackToMenu_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgContent = ((System.Windows.Controls.ContentPresenter)(target));
            return;
            case 3:
            this.imgContent2 = ((System.Windows.Controls.ContentPresenter)(target));
            return;
            case 4:
            this.PageNum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.b_Back = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\View\PricesWindow.xaml"
            this.b_Back.Click += new System.Windows.RoutedEventHandler(this.b_BackPage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.b_Next = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\View\PricesWindow.xaml"
            this.b_Next.Click += new System.Windows.RoutedEventHandler(this.b_NextPage_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.b_Save = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\..\View\PricesWindow.xaml"
            this.b_Save.Click += new System.Windows.RoutedEventHandler(this.b_Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

