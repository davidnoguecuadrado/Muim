using System;
using System.Collections.Generic;
using System.Text;

namespace Muim.Domain.Models
{
    public class PersonajeHabilidadPasivas
    {
        public Personaje Personaje { get; set; }
        public HabilidadPasiva habilidadPasiva { get; set; }
        public int PersonajeId { get; set; }
        public int HabilidadPasivaId { get; set; }
        public int Nivel { get; set; }

    }
}
