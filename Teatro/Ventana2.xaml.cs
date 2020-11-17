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

namespace Teatro
{
    /// <summary>
    /// Lógica de interacción para Ventana2.xaml
    /// </summary>
    public partial class Ventana2 : Window
    {
        public Ventana2()
        {
            InitializeComponent();
        }
        Sala salas = new Sala();
        public Ventana2(Sala s)
        {
            salas = s;
            InitializeComponent();
        }

        private void btnAsientos_Click(object sender, RoutedEventArgs e)
        {
            //enlace a mi ventana 3 con la informacion de la sala
            Window_redireccion vw = new Window_redireccion(salas);
            vw.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //cargo en mis textbox, los datos de la sala pasada por parametro
            txtNombre.Text = salas.NombreEvento;
            txtFecha.Text = salas.Fecha;
            txtHora.Text = salas.Hora;
        }
    }
}
