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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //referencia a un nuevo arraylist

        ArrayList personas;
        public Form2(ArrayList p)
        {
            //hago un nuevo constructor y le paso mi array de personas para que apunte a el
            personas = p;
            //importante volver a inicializar
            InitializeComponent();
        }
        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            //el boton enviar me guarda los textbox en persona 
            
            int cont = 0;
            //aqui controlo que el programa me deje dejar los campos peso y altura vacios
            //les digo que me lo pongan a cero en caso de ser nulls
            if (String.IsNullOrEmpty(Peso.Text))
            {
                Peso.Text = "0";
            }
            if(String.IsNullOrEmpty(Altura.Text))
            {
                Altura.Text = "0";
            }

            //recorro mi array de personas y controlo que no se repitan los dni
            foreach (Persona p in personas)
            {
                
                if (p.getDNI() == DNI.Text)
                {
                    MessageBox.Show("Este DNI ya existe");
                    DNI.Clear();
                    Nombre.Clear();
                    Apellidos.Clear();
                    Fecha.Clear();
                    Peso.Clear();
                    Altura.Clear();
                    cont++;
                }
            }
            if(cont == 0)
            {
                //si todo se cumple se añade una persona nueva, parseando los campos peso y altura
                personas.Add(new Persona(DNI.Text, Nombre.Text, Apellidos.Text, Fecha.Text, int.Parse(Peso.Text), int.Parse(Altura.Text)));
                DNI.Clear();
                Nombre.Clear();
                Apellidos.Clear();
                Fecha.Clear();
                Peso.Clear();
                Altura.Clear();
                MessageBox.Show("Persona Registrada con Exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Apellidos_TextChanged(object sender, EventArgs e)
        {

        }
        private void Fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
