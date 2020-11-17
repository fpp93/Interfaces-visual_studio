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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para WPF4.xaml
    /// </summary>
    public partial class WPF4 : Window
    {
        public WPF4()
        {
            InitializeComponent();
        }
        ArrayList personas;
        public WPF4(ArrayList p)
        {
            personas = p;
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int cont = 0;
            //recorro y compruebo el dni introducido con el que exista
            foreach (Persona p in personas)
            {
                if (textBox1.Text == p.getDNI())
                {
                    MessageBox.Show(p.toString());
                    cont++;

                }
            }
            if (cont == 0)
            {
                //si no hay pues muestro esto
                MessageBox.Show("No se encontró ninguna persona registrada con ese DNI");
            }
            textBox1.Clear();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
