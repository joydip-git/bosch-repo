#pragma checksum "..\..\StaticVsDynamic.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E4A29ED1AEEE5CDABD3668B295D1400BEEBB391E85B34D2B891AEE6E43F794EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using wpf_ResourcesBasic;


namespace wpf_ResourcesBasic {
    
    
    /// <summary>
    /// StaticVsDynamic
    /// </summary>
    public partial class StaticVsDynamic : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\StaticVsDynamic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDynamic;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\StaticVsDynamic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChange;
        
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
            System.Uri resourceLocater = new System.Uri("/wpf_ResourcesBasic;component/staticvsdynamic.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StaticVsDynamic.xaml"
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
            this.btnDynamic = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\StaticVsDynamic.xaml"
            this.btnDynamic.Click += new System.Windows.RoutedEventHandler(this.btnDynamic_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnChange = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\StaticVsDynamic.xaml"
            this.btnChange.Click += new System.Windows.RoutedEventHandler(this.btnChange_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

