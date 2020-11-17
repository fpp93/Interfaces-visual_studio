using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Tarea
    {
        private int id_agenda;
        private int dia;
        private int mes;
        private DateTime hora;
        private string descripcion;
        private string lugar;

        public int Id_agenda { get => id_agenda; set => id_agenda = value; }
        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Lugar { get => lugar; set => lugar = value; }

        public Tarea()
        {

        }
        public Tarea(int id_agenda, int dia, int mes, DateTime hora, string descripcion, string lugar)
        {
            this.id_agenda = id_agenda;
            this.dia = dia;
            this.mes = mes;
            this.hora = hora;
            this.descripcion = descripcion;
            this.lugar = lugar;
        }
    }
}
