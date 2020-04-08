
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muim.Domain.Models
{
    public class Personaje
    {
        public int PersonajeId { get; set; }

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Aspecto { get; set; }
        public string HerenciMaagica { get; set; }
        public string EstadoFisico { get; set; }
        public string EstadoMental { get; set; }
        public int PoderMagico { get; set; }
        public int TierDeArmadura { get; set; }
        public int EscudoMásico { get; set; }
        public int BaseDeKan { get; set; }
        public int PuntosARepartir { get; set; }
        public int Tamaño { get; set; }
        public int Peso { get; set; }
        public int Constitución { get; set; }
        public int Potencial { get; set; }
        public int PoderPuntos { get; set; }
        public int PoderEntrenado { get; set; }
        public int ValorPuntos { get; set; }
        public int ValorEntrenado { get; set; }
        public int AgilidadPuntos { get; set; }
        public int AgilidadEntrenado { get; set; }
        public int SabiduríaPuntos { get; set; }
        public int SabiduríaEntrenado { get; set; }
        public int DestrezaPuntos { get; set; }
        public int DestrezaEntrenado { get; set; }
        public int EsperanzaPuntos { get; set; }
        public int EsperanzaEntrenado { get; set; }
        public int Fortuna { get; set; }

        [ForeignKey("TipoId")]
        public int? TipoId { get; set; }
        public Tipo Tipo { get; set; }

        [ForeignKey("ClassCharacterId")]
        public int? ClassCharacterId { get; set; }
        public ClassCharacter classCharacter { get; set; }


        public List<Equipo> Equipos { get; set; }

    }
}
