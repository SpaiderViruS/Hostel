﻿#pragma checksum "..\..\..\Windows\RegistrationWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A7014966F4C5D56F6B50B0D0CA9A231F22BD5C9B672BA3A39133DE6C27235B72"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Hostel.Windows;
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


namespace Hostel.Windows {
    
    
    /// <summary>
    /// RegistrationWindow
    /// </summary>
    public partial class RegistrationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RegistrationLabel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurnameTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PatronomycTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PhoneLabel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordPasswodBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Windows\RegistrationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TryRegistration;
        
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
            System.Uri resourceLocater = new System.Uri("/Hostel;component/windows/registrationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\RegistrationWindow.xaml"
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
            this.RegistrationLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Windows\RegistrationWindow.xaml"
            this.NameTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NameTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SurnameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\Windows\RegistrationWindow.xaml"
            this.SurnameTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NameTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PatronomycTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Windows\RegistrationWindow.xaml"
            this.PatronomycTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NameTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PhoneLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.PhoneTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\Windows\RegistrationWindow.xaml"
            this.PhoneTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.PhoneTextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\Windows\RegistrationWindow.xaml"
            this.PhoneTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PhoneTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PasswordPasswodBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.TryRegistration = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Windows\RegistrationWindow.xaml"
            this.TryRegistration.Click += new System.Windows.RoutedEventHandler(this.TryRegistration_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

