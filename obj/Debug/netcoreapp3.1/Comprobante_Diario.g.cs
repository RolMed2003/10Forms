﻿#pragma checksum "..\..\..\Comprobante_Diario.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FF37C5A49010A833D7D3E9985575FDB895D45C9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using _10Forms;


namespace _10Forms {
    
    
    /// <summary>
    /// Comprobante_Diario
    /// </summary>
    public partial class Comprobante_Diario : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Comprobante_Diario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombreTxt;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Comprobante_Diario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox parcialTxt;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Comprobante_Diario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox debeTxt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Comprobante_Diario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox haberTxt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Comprobante_Diario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button volverBtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Comprobante_Diario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid comprobantePagoTbl;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/10Forms;component/comprobante_diario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Comprobante_Diario.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nombreTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.parcialTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.debeTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.haberTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.volverBtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Comprobante_Diario.xaml"
            this.volverBtn.Click += new System.Windows.RoutedEventHandler(this.volverBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.comprobantePagoTbl = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            
            #line 47 "..\..\..\Comprobante_Diario.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

