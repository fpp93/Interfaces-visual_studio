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
    /// Lógica de interacción para Ventana2.xaml
    /// </summary>
    public partial class Ventana2 : Window
    {
        public Ventana2()
        {
            InitializeComponent();
        }
        Cliente cliente;
        public Ventana2(Cliente s)
        {
            cliente = s;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txt_dni.Text = cliente.Dni;
            txt_nombre.Text = cliente.Nombre;
            List<String> listatemp = new List<string>();

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

        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            //fecha del sistema
            DateTime actual = DateTime.Today;
            Paquete temporal = null;
            
            try
            {
                if (lst_comprados.SelectedItem == null)
                {
                    foreach (Paquete s in cliente.PaquetesReservados)
                    {
                        if (((Paquete)lst_reservados.SelectedItem).Nombre == s.Nombre)
                        {
                            temporal = s;
                           
                        }
                    }
                    //filtro de fecha
                    if (temporal.Fechainicio > actual)
                    {
                        MessageBox.Show("la fecha no es correcta");
                    }
                    else
                    {
                        lst_reservados.Items.RemoveAt(lst_reservados.SelectedIndex);
                        cliente.CancelarPaquete(temporal);
                    }
                    
                }
                else
                {
                    foreach (Paquete s in cliente.PaquetesComprados)
                    {

                        if (((Paquete)lst_comprados.SelectedItem).Nombre == s.Nombre)
                        {
                            temporal = s;

                           
                        }
                    }
                    if (temporal.Fechainicio > actual)
                    {
                        MessageBox.Show("la fecha no es correcta");
                    }
                    else
                    {
                        lst_comprados.Items.RemoveAt(lst_comprados.SelectedIndex);
                        cliente.CancelarPaquete(temporal);
                    }
                    
                }
               
               

            }
            catch (System.Exception ex)
            {
               MessageBox.Show("Ningun elemento seleccionado");
            }
        }
    }
}
