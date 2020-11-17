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

namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Crear_A_Click(object sender, EventArgs e)
        {
            //enlace a otro formulario a traves de un boton
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //este es el boton de salir
            DialogResult respt = MessageBox.Show("Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (respt == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
