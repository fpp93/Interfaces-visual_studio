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
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }
        ArrayList videojuegos = new ArrayList();
        ArrayList clientes = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void Alta_cliente_Click(object sender, EventArgs e)
        {
            Alta_cliente_form v2 = new Alta_cliente_form(clientes);
            v2.Show();
        }

        private void Alquilar_videojuego_Click(object sender, EventArgs e)
        {
            Alquilar_form v3 = new Alquilar_form(videojuegos,clientes);
            v3.Show();
        }

        private void Devolver_videojuego_Click(object sender, EventArgs e)
        {
            Devolver_form v4 = new Devolver_form(clientes,videojuegos);
            v4.Show();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {
            videojuegos.Add(new Videojuego(01, "Resident evil ", "Accion"));
            videojuegos.Add(new Videojuego(02, "Kingdom Hearts ", "Accion"));
            videojuegos.Add(new Videojuego(03, "Mario bros ", "Plataformas"));
            videojuegos.Add(new Videojuego(04, "Outlast ", "Terror"));
            videojuegos.Add(new Videojuego(05, "Asteroids ", "Arcade"));
        }
    }
}
