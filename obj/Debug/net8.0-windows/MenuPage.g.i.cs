﻿#pragma checksum "..\..\..\MenuPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FB83EB7109B610C7253A539710E34EC39C953A61"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using pr7;


namespace pr7 {
    
    
    /// <summary>
    /// MenuPage
    /// </summary>
    public partial class MenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tint1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Tint2;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Create_Chat;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Enter_Chat;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/pr7;component/menupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MenuPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Tint1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Tint2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Create_Chat = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\MenuPage.xaml"
            this.Create_Chat.Click += new System.Windows.RoutedEventHandler(this.Create_Chat_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Enter_Chat = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\MenuPage.xaml"
            this.Enter_Chat.Click += new System.Windows.RoutedEventHandler(this.Enter_Chat_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

