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
using System.Windows.Shapes;

namespace Examen_practica
{
    /// <summary>
    /// Lógica de interacción para FormAlta.xaml
    /// </summary>
    public partial class FormAlta : Window
    {
        public FormAlta()
        {
            InitializeComponent();
        }
        Paquete p1 = new Paquete();
        public FormAlta(Paquete p)
        {
            p1 = p;
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            p1.NombreDest1 = txt_nombre.Text;
            p1.DireccionDest1 = txt_direccion.Text;
            p1.ProvinciaDest1 = txt_provincia.Text;
            p1.Peso1 = Convert.ToInt32(txt_peso.Text);
        }
    }
}
