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

namespace ExamenWPF
{
    /// <summary>
    /// Lógica de interacción para ventanaComprar.xaml
    /// </summary>
    public partial class ventanaComprar : Window
    {
        ArrayList paquetes = new ArrayList();
        Cliente cliente_seleccionado;
        public ventanaComprar()
        {
            InitializeComponent();
        }

        public ventanaComprar(Cliente cliente_seleccionado)
        {
            InitializeComponent();
            this.cliente_seleccionado = cliente_seleccionado;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Precargamos una lista de paquetes para cargar el combo
            paquetes.Add(new Paquete("Paquete 1", "descrición 1", 100, new DateTime(2020, 12, 15), 10));
            paquetes.Add(new Paquete("Paquete 2", "descrición 2", 200, new DateTime(2020, 12, 24), 10));
            paquetes.Add(new Paquete("Paquete 3", "descrición 3", 300, new DateTime(2020, 12, 31), 10));
            paquetes.Add(new Paquete("Paquete 4", "descrición 4", 400, new DateTime(2020, 11, 15), 10));
            paquetes.Add(new Paquete("Paquete 5", "descrición 5", 500, new DateTime(2020, 10, 15), 10));

            //Rellenamos el combo
            cmbPaquetes.Items.Clear();
            foreach (Paquete p in paquetes)
            {
                cmbPaquetes.Items.Add(p);
            }
            cmbPaquetes.SelectedIndex = 0;

            lblCliente.Content = this.cliente_seleccionado;

            //Cargamos el listBox de Paquetes Reservados
            foreach (Paquete p in this.cliente_seleccionado.PaquetesReservados)
            {
                lbReservados.Items.Add(p);
            }

            //Cargamos el listBox de Paquetes Comprados
            foreach (Paquete p in this.cliente_seleccionado.PaquetesComprados)
            {
                lbComprados.Items.Add(p);
            }
        }

        private void btnReservar_Click(object sender, RoutedEventArgs e)
        {
            cliente_seleccionado.reservarPaquete((Paquete)cmbPaquetes.SelectedItem);
            lbReservados.Items.Add((Paquete)cmbPaquetes.SelectedItem);
            lbReservados.Items.Refresh();
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            cliente_seleccionado.comprarPaquete((Paquete)cmbPaquetes.SelectedItem);
            lbComprados.Items.Add((Paquete)cmbPaquetes.SelectedItem);
            lbComprados.Items.Refresh();
        }
    }
}
