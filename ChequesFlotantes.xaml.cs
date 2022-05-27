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
  /// Lógica de interacción para ChequesFlotantes.xaml
  /// </summary>
  public partial class ChequesFlotantes : Window
  {

    public class Cheques
    {
      public string Nombre { get; set; }
      public string Monto { get; set; }

      public string NoCheque { get; set; }

    }
    public ChequesFlotantes()
    {
      InitializeComponent();
    }

    private void regist_bton_Click(object sender, RoutedEventArgs e)
    {
      Cheques ch = new Cheques();
      ch.NoCheque = "XXXX";
      ch.Nombre = nombre_input.Text;
      ch.Monto = cantidad_input.Text.Trim();

      tbl_Cheques.Items.Add(ch);
    }

    private void volver_bton_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
