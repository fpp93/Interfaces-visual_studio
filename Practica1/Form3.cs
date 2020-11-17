using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ArrayList personas;
        ArrayList largos;
        public Form3(ArrayList p,ArrayList l)
        {
            //paso dos arrays y los apunto a mis personas, el array largos lo utilizo para controlar en la funcion mostrar nombres mas largos
            largos = l;
            personas = p;
            InitializeComponent();
        }

        private void Label_todas_Click(object sender, EventArgs e)
        {

        }

        private void Label_Largo_Click(object sender, EventArgs e)
        {

        }

        private void btn_largo_Click(object sender, EventArgs e)
        {

            //creo variables para ir guardando contenido en ellos, principalmente los atributos de personas
            int cont = 0;
            var cadena = 0;
            string DNI="";
            string nombre="";
            string apellidos="";
            string fecha="";
            int peso=0;
            int altura=0;
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
            //si resulta que mi array de personas tiene menos de 3 registradas, pues salta el mensaje
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

        private void btn_DNI_Click(object sender, EventArgs e)
        {
            //me lleva al formulario 4 para mostrar por dni
            Form f4 = new Form4(personas);
            f4.Show();

        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            //me lleva al formulari 5 para mostrar todas las personas
            Form f5 = new Form5(personas);
            f5.Show();
            
        }

        private void btn_vacio_Click(object sender, EventArgs e)
        {
            //mostrar personas con datos vacios
            int cont = 0;
            //recorro las personas
            foreach (Persona p in personas)
            {
                //si alguno de los campos es alguno de estos, me muestra la funcion toString 
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

        private void Label_Vacio_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
