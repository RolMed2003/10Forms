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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Recibo_caja recibo_caja = new Recibo_caja();
            recibo_caja.Owner = this;
            recibo_caja.ShowDialog();
        }


        private void Gonorrea_Click(object sender, RoutedEventArgs e)
        {

            Comprobante_Pago comprobante_Pago = new Comprobante_Pago();
            comprobante_Pago.Owner = this;
            comprobante_Pago.ShowDialog();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }
    }

}

