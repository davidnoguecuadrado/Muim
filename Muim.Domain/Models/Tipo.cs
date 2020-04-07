
using System.Collections.Generic;

namespace Muim.Domain.Models
{
    public class Tipo
    {
        public int TipoId { get; set; }
        public string Nombre { get; set; }

        public Raza Raza { get; set; }
        public int RazaId { get; set; }
        public Personaje Personaje { get; set; }

    }
}
