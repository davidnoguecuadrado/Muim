
namespace Muim.Domain.Models
{
    public class PUP
    {
        public Personaje Personaje { get; set; }
        public int PersonajeId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Partida Partida { get; set; }
        public int PartidaId { get; set; }

    }
}
