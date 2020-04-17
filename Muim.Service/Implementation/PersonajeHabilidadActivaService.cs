
using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class PersonajeHabilidadActivaService : IPersonajeHabilidadActivaService
    {
        private readonly IPersonajeHabilidadActivaData _personajeHabilidadActivaData;

        public PersonajeHabilidadActivaService(IPersonajeHabilidadActivaData personajeHabilidadActivaData)
        {
            _personajeHabilidadActivaData = personajeHabilidadActivaData;
        }

        public bool AddPersonajesCapacidades(PersonajeHabilidadActiva personajeHabilidadActiva)
        {
            return _personajeHabilidadActivaData.AddPersonajeHabilidadActiva(personajeHabilidadActiva);
        }
        public bool DeletePersonajesCapacidades(PersonajeHabilidadActiva personajeHabilidadActiva)
        {
            return _personajeHabilidadActivaData.DeletePersonajeHabilidadActiva(personajeHabilidadActiva);
        }
        public List<PersonajeHabilidadActiva> GetPersonajeHabilidadActiva(int personajeId)
        {
            return _personajeHabilidadActivaData.GetPersonajeHabilidadActiva(personajeId);
        }
    }
}
