using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{

    //creo la clase persona con sus atributos y metodos
    class Persona
    {

        private String DNI;
        private String nombre;
        private String apellidos;
        private String fecha;
        private int peso;
        private int altura;

        public string DNI1 { get => DNI; set => DNI = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Altura { get => altura; set => altura = value; }


        //constructor vacio 
        public Persona()
        {

        }

        //constructor
        public Persona(String DNI, String nombre, String apellidos, String fecha, int peso, int altura)
        {
            this.DNI1 = DNI;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Fecha = fecha;
            this.Peso = peso;
            this.Altura = altura;

        }

        public String getDNI()
        {
            return DNI1;
        }
        public String getNombre()
        {
            return Nombre;
        }
        public String getApellidos()
        {
            return Apellidos;
        }
        public String getFecha()
        {
            return Fecha;
        }
        public int getPeso()
        {
            return Peso;
        }
        public int getAltura()
        {
            return Altura;
        }


        public void setDNI(String DNI)
        {
            this.DNI1 = DNI;
        }
        public void setNombre(String nombre)
        {
            this.Nombre = nombre;
        }
        public void setApellidos(String apellidos)
        {
            this.Apellidos = apellidos;
        }
        public void setFecha(String fecha)
        {
            this.Fecha = fecha;
        }
        public void setPeso(int peso)
        {
            this.Peso = peso;
        }
        public void setAltura(int altura)
        {
            this.Altura = altura;
        }

        public String toString()
        {
            return "DNI: " + DNI1 + " \nNombre: " + Nombre + " \nApellidos: " + Apellidos +
                " \nFecha: " + Fecha + " \nAltura: " + Altura + " \nPeso: " + Peso;
        }




    }
}

