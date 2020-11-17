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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Teatro
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //creo salas fuera de los metodos para poder usarlas en toda la clase
        Sala sala1;
        Sala sala2;
        Sala sala3;
        Sala sala4;
        Sala sala5;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //los instancio en el load
            sala1 = new Sala("El rey leon", "10/08/2020", "22:00",10,20);
            sala2 = new Sala("El show de Berto", "21/07/2020", "14:00",5,10);
            sala3 = new Sala("El sentido del Humor", "15/01/2020", "18:30",10,5);
            sala4 = new Sala("Mcbeth", "20/10/2020", "21:00",10,10);
            sala5 = new Sala("Romeo y Julieta", "30/10/2020", "00:30",2,10);
        }
        //dependiendo de que boton pulse, se cargará un evento u otro y las paso a la siguiente ventana
        private void Evento1_Click(object sender, RoutedEventArgs e)
        {
           
            Ventana2 v2 = new Ventana2(sala1);
            v2.Show();
        }

        private void Evento2_Click(object sender, RoutedEventArgs e)
        {
            Ventana2 v2 = new Ventana2(sala2);
            v2.Show();
        }

        private void Evento3_Click(object sender, RoutedEventArgs e)
        {
            Ventana2 v2 = new Ventana2(sala3);
            v2.Show();
        }

        private void Evento4_Click(object sender, RoutedEventArgs e)
        {
            Ventana2 v2 = new Ventana2(sala4);
            v2.Show();
        }

        private void Evento5_Click(object sender, RoutedEventArgs e)
        {
            Ventana2 v2 = new Ventana2(sala5);
            v2.Show();
        }

        
    }
}
