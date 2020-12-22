﻿using System;

namespace ExamenWPF
{
    public interface IPaquete
    {
        string Descripcion { get; set; }
        int Duracion { get; set; }
        DateTime FechaInicio { get; set; }
        string Nombre { get; set; }
        int Precio { get; set; }

        string ToString();
    }
}