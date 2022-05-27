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
    /// Interaction logic for Factura_Contado.xaml
    /// </summary>
    public partial class Factura_Contado : Window
    {
        public class registrar
        {
            public string nombre { get; set; }
            public string Direccion { get; set; }
            public string Cantidad { get; set; }
            public string Precio_Unitario { get; set; }

            public string Descripcion { get; set; }

            public string total { get; set; }

        }
        public Factura_Contado()
        {
            InitializeComponent();
            
        }

        private void btn_registrar_Click(object sender, RoutedEventArgs e)
        {
            registrar recibo = new registrar();
            recibo.nombre = nombre_txt.Text;
            recibo.Cantidad = cantidad_txt.Text;
            recibo.Descripcion = desc_txt.Text;
            recibo.Precio_Unitario = uni_txt.Text;

            int unit, cant, total_fact;


            cant = int.Parse(recibo.Cantidad);
            unit = int.Parse(recibo.Precio_Unitario);

            total_fact = cant * unit;

            recibo.total = total_fact.ToString();


            tbl_facturaContado.Items.Add(recibo);
            nombre_txt.Text = "";
            cantidad_txt.Text = "";
            desc_txt.Text = "";
            uni_txt.Text = "";
            dir_txt.Text = "";
        }

        private void paTras_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
