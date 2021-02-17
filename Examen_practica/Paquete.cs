using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Examen_practica
{
    public class Paquete
    {
        private String NombreDest;
        private String  DireccionDest;
        private String ProvinciaDest;
        private int Peso;

        public string NombreDest1 { get => NombreDest; set => NombreDest = value; }
        public string DireccionDest1 { get => DireccionDest; set => DireccionDest = value; }
        public string ProvinciaDest1 { get => ProvinciaDest; set => ProvinciaDest = value; }
        public int Peso1 { get => Peso; set => Peso = value; }

        public Paquete(string nombreDest, string direccionDest, string provinciaDest, int peso)
        {
            NombreDest = nombreDest;
            DireccionDest = direccionDest;
            ProvinciaDest = provinciaDest;
            Peso = peso;


        }
        public Paquete()
        {

        }
        override public String ToString()
        {
            return " Provincia: " + ProvinciaDest + " ,Peso: " + Peso;
        }

        public void Enviar(Vehiculo v)
        {
            v.Paquetes.Add(this);
            MessageBox.Show("Paquete enviado con exito");
        }
    }
}
