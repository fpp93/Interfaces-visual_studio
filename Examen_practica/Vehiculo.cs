using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Examen_practica
{
    public class Vehiculo
    {
        private String Matricula;
        private int PesoPermitido;
        private ArrayList paquetes = new ArrayList();

        public string Matricula1 { get => Matricula; set => Matricula = value; }
        public int PesoPermitido1 { get => PesoPermitido; set => PesoPermitido = value; }
        public ArrayList Paquetes { get => paquetes; set => paquetes = value; }

        public Vehiculo(string matricula, int pesoPermitido, ArrayList paquetes)
        {
            Matricula = matricula;
            PesoPermitido = pesoPermitido;
            this.paquetes = paquetes;
        }

       
        override public String ToString()
        {
            return " Matriculo: " + Matricula + " ,Peso libre: " + PesoPermitido;
        }

        public Boolean CompruebaPaquete(Paquete p)
        {
          string provinciaM=this.Matricula.Substring(0, 2);
          string ProvinciaC = p.ProvinciaDest1.Substring(0, 2);
            int pesoLibre = this.compruebaPeso()-p.Peso1;
           
            if (provinciaM.Equals(ProvinciaC.ToUpper())){

                if( pesoLibre > 0)
                {
                    this.PesoPermitido = pesoLibre;
                    return true;
                }
                else
                {
                    MessageBox.Show("ERROR:Peso insuficiente");
                    return false;
                }
                
            }
            else
            {
                MessageBox.Show("ERROR:La provincia es distinta");
                return false;
            }
            
        }
        public int compruebaPeso()
        {
            return this.PesoPermitido;
        }

    }
}
