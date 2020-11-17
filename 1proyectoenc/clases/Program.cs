using System;
using System.Collections;
using System.Collections.Generic;
namespace clases
{

    
    class Program
    {
        //distintas colecciones
        List<int> nombreLista = new List<int>();
        Stack<int> nombreStack = new Stack<int>();
        Queue<int> nombreQueue = new Queue<int>();
        
        static void Main(string[] args)
        {
            cancion song = new cancion();
            song.titulo = "Beautiful";
            song.segundos = 500;
            //le añado el constrructor de la otra clase a mi cancion
            song.posicion = new Estanteria(0, 0);
            //metodo de la interfaz
            song.play();

            Playlist<cancion> nombreplaylist = new Playlist<cancion>();

            nombreplaylist.Add(song);

            //esto es para que no se cierre la consola tras la ejecuccion
            Console.ReadKey();
        }
    }
}
