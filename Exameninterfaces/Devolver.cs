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
    public partial class Devolver : Form
    {
        public Devolver()
        {
            InitializeComponent();
        }
        ArrayList socios;
        public Devolver(ArrayList s)
        {
            socios = s;
            InitializeComponent();
        }

        private void Devolver_Load(object sender, EventArgs e)
        {
            foreach(Socio s in socios)
            {
                if (s.Libros.Count != 0)
                {
                    dataGridView1.DataSource = socios;
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Socio temporal;
            //sin terminar
            foreach(Socio s in socios)
            {
               // if(dataGridView1.SelectedRows)
            }
           
        }
    }
}
