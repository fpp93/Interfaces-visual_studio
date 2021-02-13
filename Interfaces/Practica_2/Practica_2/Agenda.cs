using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Agenda
    {
        private int ID;
        private string nombre;
        private int año;

        public int ID1 { get => ID; set => ID = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Año { get => año; set => año = value; }


        public Agenda()
        {

        }
        public Agenda(int iD, string nombre, int año)
        {
            ID = iD;
            Nombre = nombre;
            Año = año;
            
        }

       
    }
}
