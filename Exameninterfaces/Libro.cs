using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exameninterfaces
{
    class Libro
    {
        private String iban;
        private String titulo;
        private String autor;

        public Libro(string iban, string titulo, string autor)
        {
            this.Iban = iban;
            this.Titulo = titulo;
            this.Autor = autor;
        }

        public string Iban { get => iban; set => iban = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }


        override public String ToString()
        {
            return " \nIban " + iban + " \ntitulo: " + titulo + " \nautor: " + autor;
        }
    }
}
