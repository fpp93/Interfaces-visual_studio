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
using System.Windows.Threading;

namespace Teatro
{
    /// <summary>
    /// Lógica de interacción para Window_redireccion.xaml
    /// </summary>
    public partial class Window_redireccion : Window
    {
        public Window_redireccion()
        {
            InitializeComponent();
        }
        Sala salas = new Sala();
        public Window_redireccion(Sala s)
        {
            salas = s;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(10) };
            timer.Tick += repeticion;
            timer.Start();
        }
        private void repeticion(object sender, EventArgs e)
        {
            pb.Value++;
            if (pb.Value == 100)
            {
                ((DispatcherTimer)sender).Stop();
                Ventana3 v3 = new Ventana3(salas);
                v3.Show();
                this.Close();
            }
        }
    }
}
