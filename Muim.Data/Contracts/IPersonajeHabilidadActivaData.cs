
using Muim.Domain.Models;

namespace Muim.Data.Contracts
{
    public interface IPersonajeHabilidadActivaData
    {
        public bool AddPersonajeHabilidadActiva(PersonajeHabilidadActiva personajeHabilidadActiva);
        public bool DeletePersonajeHabilidadActiva(PersonajeHabilidadActiva personajeHabilidadActiva);
    }
}
