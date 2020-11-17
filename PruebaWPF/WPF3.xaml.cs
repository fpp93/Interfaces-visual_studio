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
    /// Lógica de interacción para WPF3.xaml
    /// </summary>
    public partial class WPF3 : Window
    {
        public WPF3()
        {
            InitializeComponent();
        }
        ArrayList personas;
        ArrayList largos;
        public WPF3(ArrayList p ,ArrayList l)
        {
            personas = p;
            largos = l;
            InitializeComponent();
        }

        private void btn_dni_Click(object sender, RoutedEventArgs e)
        {
            WPF4 w4 = new WPF4(personas);
            w4.Show();
        }

        private void btn_largos_Click(object sender, RoutedEventArgs e)
        {
            int cont = 0;
            var cadena = 0;
            string DNI = "";
            string nombre = "";
            string apellidos = "";
            string fecha = "";
            int peso = 0;
            int altura = 0;
            //una lista para controlar que no salgan personas repetidas utilizando el nombre
            List<string> nombres = new List<string>();
            do
            {
                //recorro las personas
                foreach (Persona p in personas)
                {
                    //si el nombre no esta en la lista,entra
                    if (!nombres.Contains(p.getNombre()))
                    {
                        //si la variable vacia "cadena" es menor al primer nombre, entra
                        if (cadena < p.getNombre().Length)
                        {
                            //igualo cadena a esa longitud de nombre
                            cadena = p.getNombre().Length;
                            //guardo cada atributo a mis variables
                            DNI = p.getDNI();
                            nombre = p.getNombre();
                            apellidos = p.getApellidos();
                            fecha = p.getFecha();
                            peso = p.getPeso();
                            altura = p.getAltura();
                        }
                    }
                }
                //añado esa persona a un nuevo arraylist
                largos.Add(new Persona(DNI, nombre, apellidos, fecha, peso, altura));
                cont++;
                //vuelvo a inicializar "cadena"
                cadena = 0;
                nombres.Add(nombre);
                //el while me indica que hasta que no haya 3 personas no salga mediante "cont"
            } while (cont < 3);
            //si resulta que mi array de personas tiene menos de 3 egistradas, pues salta el mensaje
            if (personas.Count < 3)
            {
                MessageBox.Show("Hay menos de 3 Personas registradas");
            }
            else
            {
                //si se cumple todo pues muestra las 3 personas con mi nuevo array de 3 personas solo
                foreach (Persona l in largos)
                {
                    MessageBox.Show(l.toString());
                }
                largos.Clear();
            }
        }

        private void btn_todos_Click(object sender, RoutedEventArgs e)
        {
            WPF5xaml w5 = new WPF5xaml(personas);
            w5.Show();
        }

        private void btn_vacios_Click(object sender, RoutedEventArgs e)
        {
            int cont = 0;
            //recorro las personas
            foreach (Persona p in personas)
            {
                //si alguno de los campos es alguno de estos, me muesra la funcion toString 
                if (p.getDNI() == "" || p.getNombre() == "" || p.getApellidos() == "" || p.getFecha() == ""
                    || p.getPeso() == 0 || p.getAltura() == 0)
                {
                    MessageBox.Show(p.toString());
                    cont++;
                }

            }
            if (cont == 0)
            {
                //condicion por si no hay ninguna
                MessageBox.Show("No hay personas con datos vacios");
            }
        }
    }
}
