#pragma checksum "..\..\..\..\Windows\Frames\WarehousePaintFrame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4E9F3075DCB51EF5A4220829892985A228E5C86113ABB62A0A3EDE8E7864DAFF"
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
    /// WarehousePaintFrame
    /// </summary>
    public partial class WarehousePaintFrame : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Windows\Frames\WarehousePaintFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FilterNamePaintTbx;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Windows\Frames\WarehousePaintFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FilterNamePaintBtn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Windows\Frames\WarehousePaintFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FiltertISOTbx;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Windows\Frames\WarehousePaintFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FilterISOBtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\Frames\WarehousePaintFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PaintLV;
        
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
            System.Uri resourceLocater = new System.Uri("/Neckhozhin_Cursach;component/windows/frames/warehousepaintframe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Frames\WarehousePaintFrame.xaml"
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
            this.FilterNamePaintTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.FilterNamePaintBtn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Windows\Frames\WarehousePaintFrame.xaml"
            this.FilterNamePaintBtn.Click += new System.Windows.RoutedEventHandler(this.FilterNamePaintBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FiltertISOTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.FilterISOBtn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Windows\Frames\WarehousePaintFrame.xaml"
            this.FilterISOBtn.Click += new System.Windows.RoutedEventHandler(this.FilterISOBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PaintLV = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

