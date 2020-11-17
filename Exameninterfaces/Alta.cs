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

namespace Exameninterfaces
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }
        ArrayList socios;
        ArrayList libros;
        public Alta(ArrayList s)
        {
            socios = s;
            InitializeComponent();
        }

        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txb_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            int idTemp = 0;
            foreach(Socio s in socios)
            {
                idTemp = s.Id_socio;
            }
            socios.Add(new Socio(txb_nombre.Text, txb_apellidos.Text, idTemp+1,new ArrayList()));
            txb_nombre.Clear();
            txb_apellidos.Clear();
            MessageBox.Show("Socio registrado con exito");
        }
    }
}
