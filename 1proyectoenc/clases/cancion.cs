using System;
using System.Collections.Generic;
using System.Text;

namespace clases
{


     public class cancion : Media,Imedia //implementacion de interfaz,con herencia se utiliza la misma sintaxis
    {
        //atributos

        public string titulo { get; set; }

        public int segundos { get; set; }

        //implemento clase estanteria como un atributo para poder usarla en el main
        public Estanteria posicion { get; set; }

        //metodo de la interfaz implementado
        public void play()
        {
            //el signo $ permite una cadena interpolada, permite llamar funciones dentro de la cadena
            //en este caso la funcion del titulo
            //tengo que investigarlo mas a fondo
            Console.WriteLine($"Sonando {titulo}");
        }
    }
}
