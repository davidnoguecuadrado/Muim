
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface IPersonajeHabilidadActivaService
    {
        public bool AddPersonajesCapacidades(PersonajeHabilidadActiva personajeHabilidadActiva);
        public bool DeletePersonajesCapacidades(PersonajeHabilidadActiva personajeHabilidadActiva);
        public List<PersonajeHabilidadActiva> GetPersonajeHabilidadActiva(int personajeId);
    }
}
