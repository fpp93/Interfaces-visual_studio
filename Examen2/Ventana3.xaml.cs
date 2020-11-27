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

namespace Examen2
{
    /// <summary>
    /// Lógica de interacción para Ventana3.xaml
    /// </summary>
    public partial class Ventana3 : Window
    {
        public Ventana3()
        {
            InitializeComponent();
        }
        Cliente cliente;
        public Ventana3(Cliente s)
        {
            cliente = s;
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txt_dni.Text = cliente.Dni;
            txt_nombre.Text = cliente.Nombre;
            //lista donde guardare los nombres de los paquetes,como condicion para que los paquetes no salgan repetidos en el listbox
            List<String> listatemp=new List<string>();
            
           
            //paquetes para el combobox
            Paquete paquete1 = new Paquete("paquete11", "Maldivas", 1500, DateTime.Parse("18/05/2020"), 13);
            combo.Items.Add(paquete1);
            Paquete paquete2 = new Paquete("paquete12", "Egipto", 300, DateTime.Parse("20/05/2020"), 13);
            combo.Items.Add(paquete2);
            Paquete paquete3 = new Paquete("paquete13", "Italia", 750, DateTime.Parse("21/06/2020"), 13);
            combo.Items.Add(paquete3);
            Paquete paquete4 = new Paquete("paquete14", "islas griegas", 1200, DateTime.Parse("08/09/2020"), 13);
            combo.Items.Add(paquete4);
            Paquete paquete5 = new Paquete("paquete15", "new york", 400, DateTime.Parse("22/04/2020"), 13);
            combo.Items.Add(paquete5);

            foreach (Paquete s in cliente.PaquetesComprados)
            {
                if (!listatemp.Contains(s.Nombre))
                {
                    listatemp.Add(s.Nombre);
                    lst_comprados.Items.Add(s);
                }
                
            }
            foreach (Paquete s in cliente.PaquetesReservados)
            {
                if (!listatemp.Contains(s.Nombre))
                {
                    listatemp.Add(s.Nombre);
                    lst_reservados.Items.Add(s);
                }
            }
        }

        private void btn_compra_Click(object sender, RoutedEventArgs e)
        {
            cliente.comprarPaquete((Paquete)combo.SelectedItem);
            lst_comprados.Items.Add(combo.SelectedItem);
            combo.Items.Remove(combo.SelectedItem);
        }

        private void btn_reserva_Click(object sender, RoutedEventArgs e)
        {
            cliente.reservarPaquete((Paquete)combo.SelectedItem);
            lst_reservados.Items.Add(combo.SelectedItem);
            combo.Items.Remove(combo.SelectedItem);
        }
    }
}
