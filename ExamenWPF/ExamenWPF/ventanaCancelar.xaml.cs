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

namespace ExamenWPF
{
    /// <summary>
    /// Lógica de interacción para ventanaCancelar.xaml
    /// </summary>
    public partial class ventanaCancelar : Window
    {
        Cliente cliente_seleccionado;
       
        public ventanaCancelar()
        {
            InitializeComponent();
        }
        public ventanaCancelar(Cliente cliente_seleccionado)
        {
            InitializeComponent();
            this.cliente_seleccionado = cliente_seleccionado;
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Nombre del cliente en la cabecera
            lblCliente.Content = cliente_seleccionado;

            //Rellenamos el listBox de Paquetes Reservados
            foreach (Paquete p in this.cliente_seleccionado.PaquetesReservados)
            {
                lbReservados.Items.Add(p);
            }

            //Rellenamos el listBox de Paquetes Comprados
            foreach (Paquete p in this.cliente_seleccionado.PaquetesComprados)
            {
                lbComprados.Items.Add(p);
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            if (lbReservados.SelectedItem != null)
            {
                cliente_seleccionado.cancelarPaquete((Paquete)lbReservados.SelectedItem);
                lbReservados.Items.Remove(lbReservados.SelectedItem);
                lbReservados.Items.Refresh();
                MessageBox.Show("Paquete eliminado con éxito");

            }

            if (lbComprados.SelectedItem != null)
            {
                cliente_seleccionado.cancelarPaquete((Paquete)lbComprados.SelectedItem);
                lbComprados.Items.Remove(lbComprados.SelectedItem);
                lbComprados.Items.Refresh();
                MessageBox.Show("Paquete eliminado con éxito");

            }

        }
    }
}
