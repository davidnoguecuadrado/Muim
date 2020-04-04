using System;
using System.Collections.Generic;
using System.Text;

namespace Muim.Domain.Models
{
    public class PersonajeHabilidadActiva
    {
        public Personaje Personaje { get; set; }
        public HabilidadActiva habilidadActiva { get; set; }
        public int PersonajeId { get; set; }
        public int HabilidadActivaInt { get; set; }
        public int Nivel { get; set; }

    }
}
