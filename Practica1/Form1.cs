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
    //la clase del primer furmulario
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //creo los arraylist y referencias que coy a necesitar
        
        ArrayList personas = new ArrayList();
        
        ArrayList largos = new ArrayList();
        
        
        //dentro del boton invoco al formulario 2 y le paso mi array de personas
        private void Crear_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(personas);
            f2.Show();
        }

        //en este boton llamo al formulario 3
        private void Consultar_Click(object sender, EventArgs e)
        {
            if(personas.Count == 0)
            {
                MessageBox.Show("No hay ninguna persona registrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form3 f3 = new Form3(personas, largos);
                f3.Show();

            }
            
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            //mensaje de bienvenida
            MessageBox.Show("Bienvenido Al formulario de registro de personas de FESAC","Practica 1",MessageBoxButtons.OK);
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            //mensaje de salida
           DialogResult respt = MessageBox.Show("Está seguro de que desea salir?","Salir",MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (respt == DialogResult.Yes)
            {
                Close();
            }
            

        }
    }
}
