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

namespace Examen_practica
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
        Paquete p1 = new Paquete();
        ArrayList vehiculos = new ArrayList();

        private void btn_alta_Click(object sender, RoutedEventArgs e)
        {
            FormAlta f2 = new FormAlta(p1);
            f2.ShowDialog();
            lst_paquetes.Items.Add(p1);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            combo_camiones.Items.Clear();
            Vehiculo c1 = new Vehiculo("SE1234RS", 1000, new ArrayList());
            Vehiculo c2 = new Vehiculo("MA1234TS", 2000, new ArrayList());
            Vehiculo c3 = new Vehiculo("HU1234RW", 500, new ArrayList());
            Vehiculo c4 = new Vehiculo("VA1234JK", 1500, new ArrayList());
            Vehiculo c5 = new Vehiculo("BA1234MR", 2000, new ArrayList());
            combo_camiones.Items.Add(c1);
            combo_camiones.Items.Add(c2);
            combo_camiones.Items.Add(c3);
            combo_camiones.Items.Add(c4);
            combo_camiones.Items.Add(c5);
            

        }

        private void combo_camiones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combo_camiones.SelectedItem != null)
            {
                Vehiculo v1 = (Vehiculo)combo_camiones.SelectedItem;
                Paquete p1 = (Paquete)lst_paquetes.SelectedItem;
                Boolean control = v1.CompruebaPaquete(p1);

                if (control == true)
                {
                    p1.Enviar(v1);
                    lst_paquetes.Items.Remove(p1);

                    foreach (var item in combo_camiones.Items)
                    {
                        vehiculos.Add(item);
                    }

                    combo_camiones.Items.Clear();


                    foreach (Vehiculo v in vehiculos)
                    {
                        combo_camiones.Items.Add(v);
                    }
                }
           



            }
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.F1)

            {

                Help.ShowHelp(null, @"C:\Users\Francisco\Documents\HelpNDoc\Output\chm\Practica10_ayuda.chm");

            }
        }
    }
}
