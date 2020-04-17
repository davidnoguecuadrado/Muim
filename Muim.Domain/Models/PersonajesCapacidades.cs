using System;
using System.Collections.Generic;
using System.Text;

namespace Muim.Domain.Models
{
    public class PersonajesCapacidades
    {
        public Personaje Personaje { get; set; }
        public Capacidad Capacidad { get; set; }
        public int PersonajeId { get; set; }
        public int CapacidadId { get; set; }
        public int Nivel { get; set; }

    }
}
