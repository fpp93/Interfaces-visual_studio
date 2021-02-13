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

namespace Primer_parcial_Enero
{
    public partial class Devolver_form : Form
    {
        public Devolver_form()
        {
            InitializeComponent();
        }
        ArrayList clientes;
        ArrayList videojuegos;
        public Devolver_form(ArrayList s,ArrayList v)
        {
            clientes = s;
            videojuegos = v;
            InitializeComponent();
        }

        private void Devolver_form_Load(object sender, EventArgs e)
        {
            
            foreach (Cliente s in clientes)
            {
                
                
                   
                    videojuegos_cliente.Items.Add(s);
                
            }
        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {

            if (videojuegos_cliente.SelectedItem != null)
            {
                Videojuego temporal = null;
                Cliente temporal2 = null;

                temporal2 = (Cliente)videojuegos_cliente.SelectedItem;

                foreach (Videojuego s in temporal2.Videojuegos)
                {
                    videojuegos.Add(s);



                }
                //temporal2.Videojuegos.Clear();
                temporal2.Videojuegos = new ArrayList();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente");
            }
            
        }
    }
}
