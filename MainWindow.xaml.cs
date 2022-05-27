using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _10Forms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Obviar este metodo
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Recibo_caja recibo_caja = new Recibo_caja();
            recibo_caja.Owner = this;
            recibo_caja.ShowDialog();
        }

        //Boton del menu Comprobantes-Pago
        private void Gonorrea_Click(object sender, RoutedEventArgs e)
        {

            Comprobante_Pago comprobante_Pago = new Comprobante_Pago();
            comprobante_Pago.Owner = this;
            comprobante_Pago.ShowDialog();

        }

        //Boton para salir del programa
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

        private void comprobanteDiario_Click(object sender, RoutedEventArgs e)
        {

            Comprobante_Diario x = new Comprobante_Diario();
            x.Owner = this;
            x.ShowDialog();

        }

        private void comprobanteCajaChica_Click(object sender, RoutedEventArgs e)
        {

            Comprobante_CajaChica x = new Comprobante_CajaChica();
            x.Owner = this;
            x.ShowDialog();

        }

        private void reciboCreditoDebito_Click(object sender, RoutedEventArgs e)
        {

            //Code

        }

        private void facturaContado_Click(object sender, RoutedEventArgs e)
        {

            //Code

        }

        private void facturaCredito_Click(object sender, RoutedEventArgs e)
        {

            //Code

        }

        private void detalleCheques_Click(object sender, RoutedEventArgs e)
        {

            //Code

        }

        private void conciliacionBancaria_Click(object sender, RoutedEventArgs e)
        {

            //Code

        }
    }

}

