using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exameninterfaces
{
    class Socio
    {
        private String nombre;
        private String apellidos;
        private int id_socio;
        private ArrayList libros = new ArrayList();

        public Socio(string nombre, string apellidos,int id_socio,ArrayList libros)
        {
           
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.id_socio = id_socio;
            this.libros = libros;
            
           
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Id_socio { get => id_socio; set => id_socio = value; }
        public ArrayList Libros { get => libros; set => libros = value; }



       override public String ToString()
        {
            return " \nID " + id_socio + " \nNombre: " + nombre + " \nApellidos: " + apellidos;
        }
    }
}
