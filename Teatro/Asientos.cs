using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatro
{
    public class Asientos
    {
        private int fila;
        private int columna;
        private String estado;

        public Asientos(int fila, int columna, string estado)
        {
            this.Fila = fila;
            this.Columna = columna;
            this.Estado = estado;
        }

        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
