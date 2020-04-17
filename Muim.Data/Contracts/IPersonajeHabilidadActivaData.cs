
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IPersonajeHabilidadActivaData
    {
        public bool AddPersonajeHabilidadActiva(PersonajeHabilidadActiva personajeHabilidadActiva);
        public bool DeletePersonajeHabilidadActiva(PersonajeHabilidadActiva personajeHabilidadActiva);
        List<PersonajeHabilidadActiva> GetPersonajeHabilidadActiva(int personajeId);

    }
}
