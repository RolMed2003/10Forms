﻿#pragma checksum "..\..\..\Comprobante_Pago.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9DD88089225A703832E5462CDB7A4C17512D477D"
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
    /// Comprobante_Pago
    /// </summary>
    public partial class Comprobante_Pago : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Comprobante_Pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombreTxt;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Comprobante_Pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox parcialTxt;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Comprobante_Pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox debeTxt;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Comprobante_Pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox haberTxt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Comprobante_Pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button volverBtn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Comprobante_Pago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid comprobantePagoTbl;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/10Forms;component/comprobante_pago.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Comprobante_Pago.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
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
            
            #line 26 "..\..\..\Comprobante_Pago.xaml"
            this.volverBtn.Click += new System.Windows.RoutedEventHandler(this.volverBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.comprobantePagoTbl = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            
            #line 46 "..\..\..\Comprobante_Pago.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

