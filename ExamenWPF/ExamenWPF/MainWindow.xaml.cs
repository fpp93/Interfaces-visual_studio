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

namespace ExamenWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList listaClientes = new ArrayList();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            if (lbClientes.SelectedItem == null)
            {
                MessageBox.Show("No ha seleccionado ningún cliente");
                return;
            }
            ventanaComprar v = new ventanaComprar((Cliente)lbClientes.SelectedItem);
            v.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listaClientes.Add(new Cliente("Nombre 1", "Apellido 1", "11111111A", "600111111", new List<IPaquete>(), new List<IPaquete>()));
            listaClientes.Add(new Cliente("Nombre 2", "Apellido 2", "22222222B", "600222222", new List<IPaquete>(), new List<IPaquete>()));
            listaClientes.Add(new Cliente("Nombre 3", "Apellido 3", "33333333C", "600333333", new List<IPaquete>(), new List<IPaquete>()));
            listaClientes.Add(new Cliente("Nombre 4", "Apellido 4", "44444444D", "600444444", new List<IPaquete>(), new List<IPaquete>()));
            listaClientes.Add(new Cliente("Nombre 5", "Apellido 5", "55555555E", "600555555", new List<IPaquete>(), new List<IPaquete>()));

            lbClientes.Items.Clear();
            foreach (Cliente cli in listaClientes)
            {
                lbClientes.Items.Add(cli);
            }

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            ventanaCancelar v = new ventanaCancelar((Cliente)lbClientes.SelectedItem);
            v.ShowDialog();
        }
    }
}
