using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows;

namespace Examen2
{
    public class Cliente
    {

        private string nombre;
        private string apellidos;
        private string dni;
        private int telefono;
        private ArrayList paquetesComprados = new ArrayList();
        private ArrayList paquetesReservados = new ArrayList();

        public Cliente(string nombre, string apellidos, string dni, int telefono, ArrayList paquetesComprados, ArrayList paquetesReservados)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
            this.Telefono = telefono;
            this.PaquetesComprados = paquetesComprados;
            this.PaquetesReservados = paquetesReservados;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public ArrayList PaquetesComprados { get => paquetesComprados; set => paquetesComprados = value; }
        public ArrayList PaquetesReservados { get => paquetesReservados; set => paquetesReservados = value; }


        override public String ToString()
        {
            return " Dni: " + dni + " ,Nombre: " + nombre;
        }
        public void CancelarPaquete(Paquete p)
        {
            Paquete temporal = null;
            int contCompra = 0;
            int contReserva = 0;
           
            foreach (Paquete s in PaquetesComprados)
            {
                if (p.Nombre.Equals(s.Nombre))
                {
                    temporal = s;
                    contCompra++;
                }
            }
            if (contCompra ==1)
            {
          
                PaquetesComprados.Remove((Paquete)temporal);
                MessageBox.Show("compra borrada");
                
            }
            
            
            foreach (Paquete s in PaquetesReservados)
            {
                
                if (p.Nombre.Equals(s.Nombre))
                {
                    temporal = s;
                    contReserva++;
                }
            }
            if (contReserva == 1)
            {
            
                PaquetesReservados.Remove((Paquete)temporal);
                MessageBox.Show("Reserva borrada");
                
              
            }
            
           


        }
        public void comprarPaquete(Paquete p)
        {
            paquetesComprados.Add(p);
        }
        public void reservarPaquete(Paquete p)
        {
            paquetesReservados.Add(p);
        }
    }
}
