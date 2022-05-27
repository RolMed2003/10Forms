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
    /// Interaction logic for Factura_Credito.xaml
    /// </summary>
    public partial class Factura_Credito : Window
    {

        public class registrar_credito
        {
            public string nombre { get; set; }
            public string direccion { get; set; }
            public string cantidad { get; set; }
            public string precio_unitario { get; set; }

            public string descripcion { get; set; }

            public string total { get; set; }

        }
        public Factura_Credito()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, RoutedEventArgs e)
        {
            registrar_credito x = new registrar_credito();
            x.nombre = nombre_txt.Text;
            x.cantidad = cantidad_txt.Text;
            x.descripcion = desc_txt.Text;
            x.precio_unitario = uni_txt.Text;

            int unit, cant, total_fact;


            cant = int.Parse(x.cantidad);
            unit = int.Parse(x.precio_unitario);

            total_fact = cant * unit;

            x.total = total_fact.ToString();


            tbl_facturaCredito.Items.Add(x);
            nombre_txt.Text = "";
            cantidad_txt.Text = "";
            desc_txt.Text = "";
            uni_txt.Text = "";
            dir_txt.Text = "";
        }

        private void paTras2_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
