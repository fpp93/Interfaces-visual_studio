using System;
using System.Collections.Generic;
using System.Text;

namespace clases
{
    public class Playlist<T>//con esto indicamos que esta clase trabajara con genericos
    {
        //podemos utilizar T para crear un array
        T[] medialist = new T[] { };

        //y para usarlo en metodos
        public void Add(T Media)
        {

        }

        public void PlayAll()
        {
            foreach(T Media in medialist)
            {
                Console.WriteLine(Media);
            }
        }


    }
}
