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
    /// Lógica de interacción para Comprobante_CajaChica.xaml
    /// </summary>
    public partial class Comprobante_CajaChica : Window
    {
        public Comprobante_CajaChica()
        {
            InitializeComponent();
        }

        private void volverBtn_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

        //Obviar metodo
        private void pagueseTxt_Copy2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void registrarBtn_Click(object sender, RoutedEventArgs e)
        {

            pagueseLbl.Content = pagueseTxt.Text;
            cantidadLbl.Content = cantidadTxt.Text;
            valorLetrasLbl.Content = valorLetrasTxt.Text;
            conceptoLbl.Content = conceptoTxt.Text;
            pagadoLbl.Content = pagadoTxt.Text;
            recibidoLbl.Content = recibidoTxt.Text;

            pagueseTxt.Text = "";
            cantidadTxt.Text = "";
            valorLetrasTxt.Text = "";
            conceptoTxt.Text = "";
            pagadoTxt.Text = "";
            recibidoTxt.Text = "";

        }
    }
}
