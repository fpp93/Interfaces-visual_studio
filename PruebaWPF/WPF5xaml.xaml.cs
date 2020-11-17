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

namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para WPF5xaml.xaml
    /// </summary>
    public partial class WPF5xaml : Window
    {
        public WPF5xaml()
        {
            InitializeComponent();
        }
        ArrayList personas;
        public WPF5xaml(ArrayList p)
        {
            personas = p;
            InitializeComponent();
        }

        private void lst_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void WPF5xaml_Load(object sender, EventArgs e)
        {
        
            

            //muestro en un listbox todas las personas

            foreach (Persona p in personas)
            {
                 lst_1.Items.Add(p.toString());
            }
        }

        
    }
}
