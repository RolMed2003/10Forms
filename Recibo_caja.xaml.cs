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
  /// Lógica de interacción para Recibo_caja.xaml
  /// </summary>
  public partial class Recibo_caja : Window
  {

    public class Recibo_diario
    {
      public string Nombre { get; set; }
      public string Cantidad { get; set; }
      public string Concepto { get; set; }
      public string Valor_letras { get; set; }
      public string Codigo { get; set; } 

      
    }


    public Recibo_caja()
    {
      InitializeComponent();
    }

    private void regist_bton_Click(object sender, RoutedEventArgs e)
    {
      Recibo_diario recibo = new Recibo_diario();
      recibo.Codigo = "XXXX";
      recibo.Nombre = nombre_txt.Text;
      recibo.Cantidad = cantidad_txt.Text;
      recibo.Concepto = concepto_txt.Text;
      recibo.Valor_letras = valorLetras_txt.Text;
     

      tbl_reciboDiario.Items.Add(recibo);
      nombre_txt.Text = "";
      cantidad_txt.Text = "";
      concepto_txt.Text = "";
      valorLetras_txt.Text = "";

    }
  }
}
