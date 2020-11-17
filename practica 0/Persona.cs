using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_0
{
    class Persona
    {
        private String DNI;
        private String nombre;
        private String apellidos;
        private String fecha;
        private int peso;
        private int altura;


        public Persona()
        {

        }

        public Persona(String DNI,String nombre,String apellidos,String fecha,int peso,int altura)
        {
            this.DNI = DNI;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fecha = fecha;
            this.peso = peso;
            this.altura = altura;
            
        }

        public String getDNI()
        {
            return DNI;
        }
        public String getNombre()
        {
            return nombre;
        }
        public String getApellidos()
        {
            return apellidos;
        }
        public String getFecha()
        {
            return fecha;
        }
        public int getPeso()
        {
            return peso;
        }
        public int getAltura()
        {
            return altura;
        }
        

        public void setDNI(String DNI)
        {
            this.DNI = DNI;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setApellidos(String apellidos)
        {
            this.apellidos = apellidos;
        }
        public void setFecha(String fecha)
        {
            this.fecha = fecha;
        }
        public void setPeso(int peso)
        {
            this.peso = peso;
        }
        public void setAltura(int altura)
        {
            this.altura = altura;
        }

        public String toString()
        {
            return "DNI:" + DNI + "\nNombre:" + nombre + "\nApellidos:" + apellidos +
                "\nFecha:" + fecha + "\nAltura:" + altura + "\nPeso:" + peso;
        }
        



    }
}
