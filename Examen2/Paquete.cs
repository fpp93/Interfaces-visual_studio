using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class Paquete
    {
        private string nombre;
        private string descripcion;
        private int precio;
        private DateTime fechainicio;
        private int duracion;

        public Paquete(string nombre, string descripcion, int precio, DateTime fechainicio, int duracion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Fechainicio = fechainicio;
            this.Duracion = duracion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public DateTime Fechainicio { get => fechainicio; set => fechainicio = value; }
        public int Duracion { get => duracion; set => duracion = value; }


        override public String ToString()
        {
            return " nombre " + nombre + " precio: " + precio;
        }
        
    }
}
