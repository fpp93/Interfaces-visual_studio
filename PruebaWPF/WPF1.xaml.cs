using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class WPF1 : Window
    {
        public WPF1()
        {
            InitializeComponent();
        }
        ArrayList personas = new ArrayList();
        Persona p = new Persona();
        ArrayList largos = new ArrayList();
        Persona l = new Persona();


        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = System.Windows.MessageBox.Show("Está seguro de que desea salir?", "Salir", (MessageBoxButton)MessageBoxButtons.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes) { 
                Close();
            }
        }

        private void btn_consultar_Click(object sender, RoutedEventArgs e)
        {
            if (personas.Count == 0)
            {
                System.Windows.MessageBox.Show("No hay ninguna persona registrada", "Información", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Warning);
            }
            else
            {
                WPF3 W3 = new WPF3(personas, largos);
                W3.Show();

            }


        }

        private void btn_crear_Click(object sender, RoutedEventArgs e)
        {
            WPF2 w2 = new WPF2(personas);
            w2.Show();
        }
    }
}

