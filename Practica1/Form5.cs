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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        ArrayList personas;
        public Form5(ArrayList p)
        {
            personas = p;
            InitializeComponent();
        }
        private void List_todas_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //no me funciono cambiar el color asi, pero lo dejo para futuros experimentos
            List_todas.ForeColor = System.Drawing.Color.Black;

            //muestro en un listbox todas las personas

            foreach (Persona p in personas)
            {
                List_todas.Items.Add(p.toString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
