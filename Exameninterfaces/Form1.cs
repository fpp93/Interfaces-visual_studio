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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList libros = new ArrayList();

        ArrayList socios = new ArrayList();
        private void btn_alta_Click(object sender, EventArgs e)
        {
            Alta f2 = new Alta(socios);
            f2.Show();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            Baja f3 = new Baja(socios);
            f3.Show();
        }

        private void btn_sacar_Click(object sender, EventArgs e)
        {
            Sacar f4 = new Sacar(libros,socios);
            f4.Show();
        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {
            Devolver f5 = new Devolver(socios);
            f5.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            libros.Add(new Libro("1001", "harry potter", "J.K ROWLING"));
            libros.Add(new Libro("1002", "el señor de los anillos", "Tolkien"));
            libros.Add(new Libro("1003", "juego de tronos", "george rr martin"));
            libros.Add(new Libro("1004", "las cronicas de narnia", "gustavo"));
            libros.Add(new Libro("1005", "los pilares de la tierra", "cameron"));

            socios.Add(new Socio("pepe", "martin suarez",1,new ArrayList()));
            socios.Add(new Socio("antonio", "luna marin",2,new ArrayList()));
            socios.Add(new Socio("manuel", "parra paez",3, new ArrayList()));
            socios.Add(new Socio("maria", "valido safra",4, new ArrayList()));
            socios.Add(new Socio("marta", "murillo jimenez",5, new ArrayList()));
        }
    }
}
