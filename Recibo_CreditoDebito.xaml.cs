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
  /// Lógica de interacción para Recibo_CreditoDebito.xaml
  /// </summary>
  public partial class Recibo_CreditoDebito : Window
  {

    public class reciboCred
    {
      public string Nombre { get; set; }
      public float Cantidad { get; set; }
      public float precUnit { get; set; }
      public string Descripcion { get; set; }

      public float Total { get; set; }

    }
   
    
    public Recibo_CreditoDebito()
    {
      InitializeComponent();
    }

    private void regist_bton_Click(object sender, RoutedEventArgs e)
    {
      string cant,precU;
      cant = cantidad_input.Text.Trim();
      precU = pUnitario_input.Text.Trim();

      float cantidad = float.Parse(cant);
      float precioUnitario = float.Parse(precU);

      float total = cantidad * precioUnitario;


      reciboCred rec = new reciboCred();
      rec.Cantidad = cantidad;
      rec.Nombre = nombre_input.Text;
      rec.Descripcion = descp_input.Text;
      rec.precUnit = precioUnitario;
      rec.Total = total;

      tbl_reciboCred.Items.Add(rec);

    }

    private void volver_bton_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
