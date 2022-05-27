using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _10Forms
{
    /// <summary>
    /// Lógica de interacción para Comprobante_Diario.xaml
    /// </summary>
    public partial class Comprobante_Diario : Window
    {
        public Comprobante_Diario()
        {
            InitializeComponent();
        }

        public class comprobantePago
        {

            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Parcial { get; set; }
            public string Debe { get; set; }
            public string Haber { get; set; }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            comprobantePago x = new comprobantePago();

            x.Codigo = "XXXXXX";
            x.Nombre = nombreTxt.Text;
            x.Parcial = parcialTxt.Text;
            x.Debe = debeTxt.Text;
            x.Haber = haberTxt.Text;

            comprobantePagoTbl.Items.Add(x);

        }

        private void volverBtn_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }
    }
}
