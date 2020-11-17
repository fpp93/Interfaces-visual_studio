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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        ArrayList personas;
        public Form4(ArrayList p)
        {
            personas = p;
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            //recorro y compruebo el dni introducido con el que exista
            foreach (Persona p in personas)
            {
                if (textBox1.Text == p.getDNI())
                {
                    MessageBox.Show(p.toString());
                    cont++;

                }  
            }
            if (cont ==0)
            {
                //si no hay pues muestro esto
                MessageBox.Show("No se encontró ninguna persona registrada con ese DNI");
            }
            textBox1.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
