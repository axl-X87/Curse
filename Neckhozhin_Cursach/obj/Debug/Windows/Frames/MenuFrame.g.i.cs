﻿#pragma checksum "..\..\..\..\Windows\Frames\MenuFrame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E844B1EFE3B935CC4AC26F89D0C8FE90C3CCD679D507F3F9F580AA546EF9F464"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Neckhozhin_Cursach.Windows.Frames;
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


namespace Neckhozhin_Cursach.Windows.Frames {
    
    
    /// <summary>
    /// MenuFrame
    /// </summary>
    public partial class MenuFrame : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Windows\Frames\MenuFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Employee_Test;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Windows\Frames\MenuFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TestBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\Frames\MenuFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreatorTest;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Windows\Frames\MenuFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Employer_LV;
        
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
            System.Uri resourceLocater = new System.Uri("/Neckhozhin_Cursach;component/windows/frames/menuframe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Frames\MenuFrame.xaml"
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
            this.Employee_Test = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\..\Windows\Frames\MenuFrame.xaml"
            this.Employee_Test.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Employee_Test_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TestBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CreatorTest = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Windows\Frames\MenuFrame.xaml"
            this.CreatorTest.Click += new System.Windows.RoutedEventHandler(this.CreatorTest_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Employer_LV = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

