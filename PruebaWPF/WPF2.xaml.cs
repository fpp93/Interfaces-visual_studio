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
using System.Windows.Shapes;

namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para WPF2.xaml
    /// </summary>
    public partial class WPF2 : Window
    {
        public WPF2()
        {
            InitializeComponent();
        }
        ArrayList personas;
        public WPF2(ArrayList p)
        {
            personas = p;
            InitializeComponent();
        }

        private void txt_dni_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_apellidos_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_fecha_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_peso_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_altura_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, RoutedEventArgs e)
        {
            //el boton enviar me guarda los textbox en persona 

            int cont = 0;
            //aqui controlo que el programa me deje dejar los campos peso y altura vacios
            //les digo que me lo pongan a cero en caso de ser nulls
            if (String.IsNullOrEmpty(txt_peso.Text))
            {
                txt_peso.Text = "0";
            }
            if (String.IsNullOrEmpty(txt_altura.Text))
            {
                txt_altura.Text = "0";
            }

            //recorro mi array de personas y controlo que no se repitan los dni
            foreach (Persona p in personas)
            {

                if (p.getDNI() == txt_dni.Text)
                {
                   System.Windows.MessageBox.Show("Este DNI ya existe");
                    txt_dni.Clear();
                    txt_nombre.Clear();
                    txt_apellidos.Clear();
                    txt_fecha.Clear();
                    txt_peso.Clear();
                    txt_altura.Clear();
                    cont++;
                }
            }
            if (cont == 0)
            {
                //si todo se cumple se añade una persona nueva, parseando los campos peso y altura
                personas.Add(new Persona(txt_dni.Text, txt_nombre.Text, txt_apellidos.Text, txt_fecha.Text, int.Parse(txt_peso.Text), int.Parse(txt_altura.Text)));
                txt_dni.Clear();
                txt_nombre.Clear();
                txt_apellidos.Clear();
                txt_fecha.Clear();
                txt_peso.Clear();
                txt_altura.Clear();
               System.Windows.MessageBox.Show("Persona Registrada con Exito", "Registro", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.None);
            }
        }
    }
}
