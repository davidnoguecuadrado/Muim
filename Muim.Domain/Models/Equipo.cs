using System;
using System.Collections.Generic;
using System.Text;

namespace Muim.Domain.Models
{
    public class Equipo
    {
        public int EquipoId { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public int Tier { get; set; }

        public Personaje Personaje{get; set;}
        public int PersonajeId { get; set; }

    }
}
