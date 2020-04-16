
using Muim.Domain.Models;

namespace Muim.Service.Contracts
{
    public interface IPersonajeHabilidadActivaService
    {
        public bool AddPersonajesCapacidades(PersonajeHabilidadActiva personajeHabilidadActiva);
        public bool DeletePersonajesCapacidades(PersonajeHabilidadActiva personajeHabilidadActiva);
        
    }
}
