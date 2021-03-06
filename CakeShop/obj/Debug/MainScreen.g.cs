#pragma checksum "..\..\MainScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "39C0F71E3CEBFF632E753BD8AAF6B5BE4427871FB840BC6B3944BD32FCFD801E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CakeShop;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace CakeShop {
    
    
    /// <summary>
    /// MainScreen
    /// </summary>
    public partial class MainScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\MainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CakeShop.MainScreen mainScreen;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid titleBar;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button aboutButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button settingsButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimizeWindowButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeWindowButton;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton menuButton;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\MainScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox menuBox;
        
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
            System.Uri resourceLocater = new System.Uri("/CakeShop;component/mainscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainScreen.xaml"
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
            this.mainScreen = ((CakeShop.MainScreen)(target));
            
            #line 19 "..\..\MainScreen.xaml"
            this.mainScreen.Loaded += new System.Windows.RoutedEventHandler(this.mainScreen_Loaded);
            
            #line default
            #line hidden
            
            #line 20 "..\..\MainScreen.xaml"
            this.mainScreen.Closed += new System.EventHandler(this.mainScreen_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.titleBar = ((System.Windows.Controls.Grid)(target));
            
            #line 28 "..\..\MainScreen.xaml"
            this.titleBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.titleBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.aboutButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\MainScreen.xaml"
            this.aboutButton.Click += new System.Windows.RoutedEventHandler(this.settingsButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.settingsButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\MainScreen.xaml"
            this.settingsButton.Click += new System.Windows.RoutedEventHandler(this.aboutButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.minimizeWindowButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\MainScreen.xaml"
            this.minimizeWindowButton.Click += new System.Windows.RoutedEventHandler(this.minimizeWindowButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.closeWindowButton = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\MainScreen.xaml"
            this.closeWindowButton.Click += new System.Windows.RoutedEventHandler(this.closeWindowButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.menuButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 8:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.menuBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 91 "..\..\MainScreen.xaml"
            this.menuBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.menuBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

