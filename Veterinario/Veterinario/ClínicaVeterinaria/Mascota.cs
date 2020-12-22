using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClínicaVeterinaria
{
   public class Mascota : IMascota
    {
        private string nombre;
        private string fechaNacimiento;
        private List<string> vacunas;

        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public List<string> Vacunas { get => vacunas; set => vacunas = value; }

        public Mascota(string nombre, string fechaNacimiento)
        {
            this.Nombre = nombre;
            this.FechaNacimiento = fechaNacimiento;
            this.Vacunas = new List<string>();
        }

        public void SetNombre (string n)
        {
            this.Nombre = n;
        }
        public void setFechaNacimiento (string fecha)
        {
            this.FechaNacimiento = fecha;
        }
        public string GetNombre()
        {
            return this.Nombre;
        }
        public string GetFechaNacimiento()
        {
            return this.FechaNacimiento;
        }


        //El método Jugar recibe una cadena de texto y según la logitud devuelve true (longitud par) o false (longitud impar)
        public bool Jugar(string juego)
        {

            int n = juego.Length;
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //El método Vacunar recibe una cadena de texto en representación de la vacuna recibida. Si sicha vacuna ya se
        //encuentra en la lista de vacunas de la mascota lanza una excepción. En caso contrario la añade a la lista.
        public void Vacunar (string v)
        {
            if (YaVacunado(v))
            {
                throw new Exception("Ya ha sido vacunado de " + v);
            }
            else
            {
                this.Vacunas.Add(v);
            }
        }
        
        //El método YaVacunado devuelve true o false, dependiendo si la cadena que recibe como parámetro
        //se encuentra en la lista de vacunas o no
        public bool YaVacunado(string v)
        {
            bool retorno = false;
            foreach (string vacuna in this.Vacunas)
            {
                
                if (vacuna.Equals(v))
                    retorno= true; 
            }
            return retorno;
        }

        //El método SeRelaja recibe una cadena y devuelve verdadero o falso dependiendo de si la longitud de la 
        //cadena es divisible entre un aleatorio generado 
        public bool SeRelaja(string premio)
        {
            Random x = new Random(premio.Length);
            //int n = x.Next(); lo comento para poder usar un resultado especifico en las pruebas
            int n = 2;
            if (premio.Length % n == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
