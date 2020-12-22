using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenWPF
{
    public class Paquete : IPaquete
    {
        string nombre;
        string descripcion;
        int precio;
        DateTime fechaInicio;
        int duracion;

        public Paquete(string nombre, string descripcion, int precio, DateTime fechaInicio, int duracion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.FechaInicio = fechaInicio;
            this.Duracion = duracion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public override string ToString()
        {
            return this.nombre + " -> " + this.precio;
        }
    }
}
