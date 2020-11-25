using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_examen_19
{
    public class Almacen
    {
        private String nombre;
        private String ubicacion;
        private List<Articulo> listaArticulos = new List<Articulo>();

        public Almacen(string nombre, string ubicacion, List<Articulo> listaArticulos)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.listaArticulos = listaArticulos;
        }
        public Almacen()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public List<Articulo> ListaArticulos { get => listaArticulos; set => listaArticulos = value; }


        public String toString()
        {
            return "Nombre:" + nombre+ " ,Ubicacion:"+ubicacion;
        }
        public double getValor()
        {
            double valor = 0;
            foreach (Articulo l in listaArticulos)
            {
                valor =valor+ (l.Precio * l.Unidades);
            }
            return valor;
        }

        public void comprar(int codigo,int unidades)
        {
            foreach(Articulo l in listaArticulos)
            {
                if (l.Codigo == codigo)
                {
                    l.Unidades = l.Unidades - unidades;
                }
            }
        }
        public void reponer(int codigo,int unidades)
        {
            foreach (Articulo l in listaArticulos)
            {
                if (l.Codigo == codigo)
                {
                    l.Unidades = l.Unidades + unidades;
                }
            }
        }
    }
}
