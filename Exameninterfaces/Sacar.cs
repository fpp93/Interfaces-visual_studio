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
    public partial class Sacar : Form
    {
        public Sacar()
        {
            InitializeComponent();
        }
        ArrayList libros;
        ArrayList socios;
        public Sacar(ArrayList l,ArrayList s)
        {
            socios = s;
            libros = l;
            InitializeComponent();
        }

        private void Sacar_Load(object sender, EventArgs e)
        {
            foreach (Socio s in socios)
            {
                lst_socios1.Items.Add(s);
            }
            foreach (Libro l in libros)
            {
                lst_libros.Items.Add(l);
            }
        }

        private void lst_libros_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lst_socios1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_sacar_Click(object sender, EventArgs e)
        {
            Libro temporal = null;
            
            foreach(Socio s in socios)
            {
                if (((Socio)lst_socios1.SelectedItem).Id_socio == s.Id_socio)
                {
                    temporal = (Libro)lst_libros.SelectedItem;
                    s.Libros.Add(temporal);
                    libros.Remove((Libro)temporal);
                    lst_libros.Items.RemoveAt(lst_libros.SelectedIndex);
                    MessageBox.Show("Libro sacado");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lst_socios1.Items.Clear();

            foreach (Socio s in socios)
            {
                if (s.Nombre.Contains(textBox1.Text))
                {
                    lst_socios1.Items.Add(s);
                }

                if (s.Apellidos.Contains(textBox1.Text))
                {
                    lst_socios1.Items.Add(s);
                }

            }
        }

        private void txtFiltrarlibros_TextChanged(object sender, EventArgs e)
        {
            lst_libros.Items.Clear();

            foreach (Socio s in socios)
            {
                if (s.Nombre.Contains(txtFiltrarlibros.Text))
                {
                    lst_libros.Items.Add(s);
                }

                if (s.Apellidos.Contains(txtFiltrarlibros.Text))
                {
                    lst_libros.Items.Add(s);
                }

            }
        }
    }
}
