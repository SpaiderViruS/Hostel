﻿#pragma checksum "..\..\..\Windows\ConfirmationReservingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3633012C31C0608865BAF51F6D47BB84728EA86C3994B4D765C0B772AB98FF5E"
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
    /// ConfirmationReservingWindow
    /// </summary>
    public partial class ConfirmationReservingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Windows\ConfirmationReservingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SNPUserLabel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\ConfirmationReservingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RoomLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\ConfirmationReservingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker SettlementDatePicker;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\ConfirmationReservingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ReleaseDatePicker;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\ConfirmationReservingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Windows\ConfirmationReservingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfirmOrderButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Hostel;component/windows/confirmationreservingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ConfirmationReservingWindow.xaml"
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
            this.SNPUserLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.RoomLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.SettlementDatePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 30 "..\..\..\Windows\ConfirmationReservingWindow.xaml"
            this.SettlementDatePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.SettlementDatePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ReleaseDatePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 33 "..\..\..\Windows\ConfirmationReservingWindow.xaml"
            this.ReleaseDatePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.ReleaseDatePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Windows\ConfirmationReservingWindow.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ConfirmOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Windows\ConfirmationReservingWindow.xaml"
            this.ConfirmOrderButton.Click += new System.Windows.RoutedEventHandler(this.ConfirmOrderButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
