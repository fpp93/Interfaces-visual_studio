using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatro
{
    public class Sala
    {
        private String nombreEvento;
        private String fecha;
        private String hora;
        private List<Asientos> asiento=new List<Asientos>();
        private int num_filas;
        private int num_columnas;

        public Sala(string nombreEvento, string fecha, string hora,int num_filas,int num_columnas)
        {
            this.NombreEvento = nombreEvento;
            this.Fecha = fecha;
            this.Hora = hora;
            this.Num_filas = num_filas;
            this.Num_columnas = num_columnas;

            
        }
        public Sala()
        {

        }

        public string NombreEvento { get => nombreEvento; set => nombreEvento = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        internal List<Asientos> Asiento { get => asiento; set => asiento = value; }
        public int Num_filas { get => num_filas; set => num_filas = value; }
        public int Num_columnas { get => num_columnas; set => num_columnas = value; }
    }
}
