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

namespace practica_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        ArrayList personas = new ArrayList();
        Persona p =new Persona();
        private void Boton_Click(object sender, EventArgs e)
        {
            personas.Add(new Persona(DNI.Text,Nombre.Text,Apellidos.Text,Fecha.Text,int.Parse(Peso.Text),int.Parse(Altura.Text)));
            DNI.Clear();
        }

        private void DNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void Altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            foreach(Persona p in personas)
            {
                MessageBox.Show(p.toString());
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
