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
    /// Interaction logic for Conciliacion_Bancaria.xaml
    /// </summary>
    public partial class Conciliacion_Bancaria : Window
    {
        public Conciliacion_Bancaria()
        {
            InitializeComponent();
        }

        private void Label_TextInput(object sender, TextCompositionEventArgs e)
        {
           
        }

        private void paTras3_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
