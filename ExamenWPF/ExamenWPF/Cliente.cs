using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenWPF
{
    public class Cliente : ICliente
    {
        string nombre;
        string apellido;
        string dni;
        string telefono;
        List<IPaquete> paquetesReservados;
        List<IPaquete> paquetesComprados;

        public Cliente(string nombre, string apellido, string dni, string telefono, List<IPaquete> paquetesReservados, List<IPaquete> paquetesComprados)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Telefono = telefono;
            this.PaquetesReservados = paquetesReservados;
            this.PaquetesComprados = paquetesComprados;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<IPaquete> PaquetesReservados { get => paquetesReservados; set => paquetesReservados = value; }
        public List<IPaquete> PaquetesComprados { get => paquetesComprados; set => paquetesComprados = value; }

        public override string ToString()
        {
            return this.dni + "  " + this.nombre;
        }

        public void reservarPaquete(IPaquete paquete)
        {
            this.paquetesReservados.Add(paquete);
        }

        public void comprarPaquete(IPaquete paquete)
        {
            this.paquetesComprados.Add(paquete);
        }

        public void cancelarPaquete(IPaquete paquete)
        {

            if (this.paquetesReservados.Contains(paquete))
            {
                this.paquetesReservados.Remove(paquete);
            }
            else
            {
                this.paquetesComprados.Remove(paquete);
            }


        }

    }
}
