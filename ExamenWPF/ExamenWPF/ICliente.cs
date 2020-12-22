using System.Collections.Generic;

namespace ExamenWPF
{
    public interface ICliente
    {
        string Apellido { get; set; }
        string Dni { get; set; }
        string Nombre { get; set; }
        List<IPaquete> PaquetesComprados { get; set; }
        List<IPaquete> PaquetesReservados { get; set; }
        string Telefono { get; set; }

        void cancelarPaquete(IPaquete paquete);
        void comprarPaquete(IPaquete paquete);
        void reservarPaquete(IPaquete paquete);
        string ToString();
    }
}