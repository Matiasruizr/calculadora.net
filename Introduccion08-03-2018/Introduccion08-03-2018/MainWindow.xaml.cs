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

namespace Introduccion08_03_2018
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            

            InitializeComponent();


            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(txtNumero1.Text);
            int num2 = int.Parse(txtNumero2.Text); 


            if (suma.IsChecked.Value)
            {
                lblRespuesta.Content = "Resputa: " + (num1 + num2);
            }
            else if (resta.IsChecked.Value)
            {
                lblRespuesta.Content = "Resputa: " + (num1 - num2);
            }
            else if (multi.IsChecked.Value)
            {
                lblRespuesta.Content = "Resputa: " + (num1 * num2);
            }
            else if (division.IsChecked.Value)
            {
                lblRespuesta.Content = "Resputa: " + (num1 / num2);
            }
            else
            {
                lblRespuesta.Content = "Debes ingresar un operador!";
            }


        }

      
    }
}
