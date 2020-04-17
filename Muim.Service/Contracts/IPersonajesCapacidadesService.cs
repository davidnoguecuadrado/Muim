
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface IPersonajesCapacidadesService
    {
        public bool AddPersonajesCapacidades(PersonajesCapacidades personajesCapacidades);
        public bool DeletePersonajesCapacidades(PersonajesCapacidades personajesCapacidades);
        List<PersonajesCapacidades> GetPersonajesCapacidades(int personajeId);
    }
}
