
namespace Muim.Domain.Models
{
    public class ClassCharacterCapacidades
    {
        public Capacidad Capacidad { get; set; }
        public ClassCharacter ClassCharacter { get; set; }
        public int CapacidadId { get; set; }
        public int ClassCharacterId { get; set; }
    }
}
