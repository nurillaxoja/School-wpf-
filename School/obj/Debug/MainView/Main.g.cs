#pragma checksum "..\..\..\MainView\Main.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AA9422F27B3DDF1CA3BC8A3748E824D0F7264381B751F51BB9F5113021D0899F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using School.MainView;
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


namespace School.MainView {
    
    
    /// <summary>
    /// Main
    /// </summary>
    public partial class Main : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\MainView\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal School.MainView.Main MainWindow;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainView\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProfile;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MainView\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClass;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainView\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLog;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MainView\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\MainView\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/School;component/mainview/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainView\Main.xaml"
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
            this.MainWindow = ((School.MainView.Main)(target));
            return;
            case 2:
            this.btnProfile = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\MainView\Main.xaml"
            this.btnProfile.Click += new System.Windows.RoutedEventHandler(this.profileClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClass = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\MainView\Main.xaml"
            this.btnClass.Click += new System.Windows.RoutedEventHandler(this.classClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnLog = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\MainView\Main.xaml"
            this.btnLog.Click += new System.Windows.RoutedEventHandler(this.logClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\MainView\Main.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.exitClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

