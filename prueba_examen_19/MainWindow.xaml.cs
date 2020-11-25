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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prueba_examen_19
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
        Almacen a = new Almacen();
        private void btn_alta_Click(object sender, RoutedEventArgs e)
        {
            foreach(Articulo i in a.ListaArticulos)
            {
                if (txt_codigo_alta.Text.Equals( i.Codigo))
                {
                    i.Unidades = i.Unidades + Convert.ToInt32(txt_unidades_alta.Text);
                    MessageBox.Show("Unidades añadidas a stock");
                }
            }
        }

        private void btn_baja_Click(object sender, RoutedEventArgs e)
        {
            foreach (Articulo i in a.ListaArticulos)
            {
                if (txt_codigo_baja.Text.Equals(i.Codigo)&& i.Unidades> Convert.ToInt32(txt_unidades_baja.Text))
                {
                    i.Unidades = i.Unidades + Convert.ToInt32(txt_unidades_baja.Text);
                    MessageBox.Show("Unidades eliminadas del stock");
                }
                else
                {
                    MessageBox.Show("No se ha podido realizar la operacion");
                }

            }
        }

        private void btn_valor_Click(object sender, RoutedEventArgs e)
        {
            a.getValor();
            MessageBox.Show(a.getValor().ToString());
        }
    }
}
