using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_parcial_Enero
{
    public class Videojuego
    {
        private int codigo;
        private String nombre;
        private String tema;

        public Videojuego(int codigo, string nombre, string tema)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Tema = tema;

        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tema { get => tema; set => tema = value; }


        override public String ToString()
        {
            return " codigo: " + codigo + " ,Nombre: " + nombre + " Tema: " + tema;
        }
    }
}
