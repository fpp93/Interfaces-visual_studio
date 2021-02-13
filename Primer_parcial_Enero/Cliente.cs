using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_parcial_Enero
{
    public class Cliente
    {

        private String nombre;
        private String apellidos;
        private String dni;
        private ArrayList videojuegos = new ArrayList();

        public Cliente(string nombre, string apellidos, string dni,ArrayList videojuegos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
            this.Videojuegos = videojuegos;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public ArrayList Videojuegos { get => videojuegos; set => videojuegos = value; }

        override public String ToString()
        {
            return " nombre: " + nombre + " ,Apellidos: " + apellidos + " dni: " + dni ;
        }
    }
}
