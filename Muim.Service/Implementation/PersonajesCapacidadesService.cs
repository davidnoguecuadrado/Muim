using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class PersonajesCapacidadesService : IPersonajesCapacidadesService
    {
        private readonly IPersonajesCapacidadesData _personajesCapacidadesData;

        public PersonajesCapacidadesService(IPersonajesCapacidadesData personajesCapacidadesData)
        {
            _personajesCapacidadesData = personajesCapacidadesData;

        }

        public bool AddPersonajesCapacidades(PersonajesCapacidades personajesCapacidades)
        {
            return _personajesCapacidadesData.AddPersonajesCapacidades(personajesCapacidades);
        }
        public bool DeletePersonajesCapacidades(PersonajesCapacidades personajesCapacidades)
        {
            return _personajesCapacidadesData.DeletePersonajesCapacidades(personajesCapacidades);
        }

        public List<PersonajesCapacidades> GetPersonajesCapacidades(int personajeId)
        {
            return _personajesCapacidadesData.GetPersonajesCapacidades(personajeId);
        }

    }
}
