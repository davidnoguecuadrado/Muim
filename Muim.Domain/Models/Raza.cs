using System.Collections.Generic;

namespace Muim.Domain.Models
{
    public class Raza
    {
        public int RazaId { get; set;}
        public string Nombre { get; set;}
        public List<Tipo> Tipos { get; set;}
        public Personaje Personaje { get; set; }

    }
}
