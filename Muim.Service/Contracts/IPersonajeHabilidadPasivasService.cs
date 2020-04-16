
using Muim.Domain.Models;

namespace Muim.Service.Contracts
{
    public interface IPersonajeHabilidadPasivasService
    {
        public bool AddPersonajesCapacidades(PersonajeHabilidadPasivas personajeHabilidadPasivas);
        public bool DeletePersonajesCapacidades(PersonajeHabilidadPasivas personajeHabilidadPasivas);
    }
}
