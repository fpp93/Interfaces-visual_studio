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
    public partial class Alquilar_form : Form
    {
        public Alquilar_form()
        {
            InitializeComponent();
        }
        ArrayList cli = new ArrayList();
        ArrayList video = new ArrayList();
       
        public Alquilar_form(ArrayList videojuegos,ArrayList clientes)
        {
            video = videojuegos;
            cli = clientes;
            InitializeComponent();
        }

        private void btn_alquilar_Click(object sender, EventArgs e)
        {
            Cliente temporal=null;

            if (lst_clientes.SelectedItem != null && lst_videojuegos.SelectedItem != null)
            {
                foreach (Cliente s in cli)
                {
                    if (((Cliente)lst_clientes.SelectedItem).Dni == s.Dni)
                    {
                        temporal = s;

                    }
                }
                video.Remove(lst_videojuegos.SelectedItem);
                lst_videojuegos.Items.RemoveAt(lst_videojuegos.SelectedIndex);
                
                temporal.Videojuegos.Add(lst_videojuegos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe seleccionar elementos en ambas listas");
            }
        }

        private void Alquilar_form_Load(object sender, EventArgs e)
        {
            
            lst_videojuegos.Items.Clear();
            lst_clientes.Items.Clear();

            foreach (Videojuego s in video)
            {
               
                   
                    lst_videojuegos.Items.Add(s);
                
            }
            foreach (Cliente s in cli)
            {
                
                    
                    lst_clientes.Items.Add(s);
                
            }
        }
    }
}
