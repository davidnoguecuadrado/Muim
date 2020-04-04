
namespace Muim.Domain.Models
{
    public class MagiaPersonajes
    {
        public Personaje Personaje { get; set; }
        public Magia Magia { get; set; }
        public int PersonajeId { get; set; }
        public int MagiaId { get; set; }
        public int Nivel { get; set; }

    }
}
