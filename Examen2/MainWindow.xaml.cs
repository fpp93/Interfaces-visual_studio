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

namespace Examen2
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
        ArrayList clientes = new ArrayList();
        Cliente temporal;
        ArrayList comprados = new ArrayList();
        ArrayList reservados = new ArrayList();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            clientes.Add(new Cliente("pepe", "martin ", "11111111A",954440347, new ArrayList(), new ArrayList()));
            clientes.Add(new Cliente("antonio", "luna ", "2222222B", 954440347, new ArrayList(), new ArrayList()));
            clientes.Add(new Cliente("manuel", "parra ", "33333333C", 954440347, new ArrayList(), new ArrayList()));
            clientes.Add(new Cliente("maria", "valido ", "44444444D", 954440347, new ArrayList(), new ArrayList()));
            clientes.Add(new Cliente("marta", "murillo ", "55555555E", 954440347, new ArrayList(), new ArrayList()));

            comprados.Add(new Paquete("paquete1", "lampara de lava", 15, DateTime.Parse("01/12/2020"), 3));
            comprados.Add(new Paquete("paquete2", "mesa madera", 10, DateTime.Parse("09/02/2019"), 5));
            comprados.Add(new Paquete("paquete3", "bola de cristal", 17, DateTime.Parse("20/10/2020"), 10));
            comprados.Add(new Paquete("paquete4", "juguete infantil", 20, DateTime.Parse("21/11/2020"), 2));
            comprados.Add(new Paquete("paquete5", "figura anime", 40, DateTime.Parse("23/03/2020"), 6));
            reservados.Add(new Paquete("paquete6", "silla plastico", 12, DateTime.Parse("24/05/2020"), 13));
            reservados.Add(new Paquete("paquete7", "cesta mimbre", 5, DateTime.Parse("01/10/2020"), 13));
            reservados.Add(new Paquete("paquete8", "iphone 13", 1000, DateTime.Parse("04/09/2020"), 13));
            reservados.Add(new Paquete("paquete9", "portatil lenovo", 350, DateTime.Parse("15/06/2020"), 13));
            reservados.Add(new Paquete("paquete10", "pizarra electronica", 500, DateTime.Parse("18/05/2020"), 13));
            foreach (Cliente s in clientes)
            {
                lst_main.Items.Add(s);
            }
          
        }

        private void lst_main_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_siguiente_Click(object sender, RoutedEventArgs e)
        {
            temporal = (Cliente)lst_main.SelectedItem;

            foreach(Paquete p in comprados)
            {
                temporal.PaquetesComprados.Add(p);
            }
            foreach (Paquete p in reservados)
            {
                temporal.PaquetesReservados.Add(p);
            }
            Ventana2 v2 = new Ventana2(temporal);
            v2.Show();
        }

        private void btn_alta_Click(object sender, RoutedEventArgs e)
        {
            temporal = (Cliente)lst_main.SelectedItem;

            foreach (Paquete p in comprados)
            {
                temporal.PaquetesComprados.Add(p);
            }
            foreach (Paquete p in reservados)
            {
                temporal.PaquetesReservados.Add(p);
            }
            Ventana3 v3 = new Ventana3(temporal);
            v3.Show();
        }
       

        private void Window_KeyDown_1(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.F1)

            {

                Help.ShowHelp(null, @"C:\Users\Francisco\Documents\HelpNDoc\Output\chm\Practica10_ayuda.chm");

            }
        }
    }
}
