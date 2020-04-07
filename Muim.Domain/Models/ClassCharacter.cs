
using System.Collections.Generic;

namespace Muim.Domain.Models
{
    public class ClassCharacter
    {
        public int ClassCharacterId { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }

        public List<Capacidad> Capacidades { get; set; }
    }
}
