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
    public partial class Baja : Form
    {
        public Baja()
        {
            InitializeComponent();
        }
        ArrayList socios;
        public Baja(ArrayList s)
        {
            socios = s;
            InitializeComponent();
        }
        private void Baja_Load(object sender, EventArgs e)
        {
            foreach (Socio s in socios)
            {
                lst_socios.Items.Add(s);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Socio temporal = null;
            int cont = 0;
            try
            {
                foreach(Socio s in socios)
                {
                    if (((Socio)lst_socios.SelectedItem).Id_socio==s.Id_socio) 
                    {
                        if (s.Libros.Count==0)
                        {
                            temporal = s;
                            
                        }
                        else
                        {
                            cont++;
                        }
                        
                    }
                }
                if (cont == 0)
                {
                    socios.Remove((Socio)temporal);
                    lst_socios.Items.RemoveAt(lst_socios.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("No se puede borrar este socio");
                }
               


            }
            catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ningun socio seleccionado");
            }
            

        }

        private void txb_filtro_TextChanged(object sender, EventArgs e)
        {
            lst_socios.Items.Clear();
           
            foreach (Socio s in socios)
            {
                if (s.Nombre.Contains(txb_filtro.Text))
                {
                    lst_socios.Items.Add(s);
                }
                
                if (s.Apellidos.Contains(txb_filtro.Text))
                {
                    lst_socios.Items.Add(s);
                }
                
            }

        }
    }
}
