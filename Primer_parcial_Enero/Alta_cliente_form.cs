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
    public partial class Alta_cliente_form : Form
    {
        public Alta_cliente_form()
        {
            InitializeComponent();
        }
        ArrayList cli=new ArrayList();
        public Alta_cliente_form(ArrayList clientes)
        {
            cli = clientes;
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "" && txt_apellidos.Text != "" && txt_dni.Text != "")
            {
                int cont = 0;
                foreach (Cliente s in cli)
                {
                    if (txt_dni.Text.Equals(s.Dni))
                    {
                        MessageBox.Show("No puede haber dos clientes con el mismo DNI");
                        cont++;
                    }
                }
                if (cont == 0)
                {
                    cli.Add(new Cliente(txt_nombre.Text, txt_apellidos.Text, txt_dni.Text, new ArrayList()));
                    MessageBox.Show("Cliente dado de alta con exito");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }
        }
    }
}
