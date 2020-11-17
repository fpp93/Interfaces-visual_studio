using System;
using System.Collections.Generic;
using System.Text;

namespace clases
{

    //struct es un tipo de estructura
    public struct Estanteria
    {

        //constructor
        public Estanteria(int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
        }

        //deben empezar por mayuscula
        public int Fila { get; set; }
        public int Columna { get; set; }
    }
}
