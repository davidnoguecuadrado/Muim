
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IPersonajesCapacidadesData
    {
        bool AddPersonajesCapacidades(PersonajesCapacidades personajesCapacidades);
        bool DeletePersonajesCapacidades(PersonajesCapacidades personajesCapacidades);
        List<PersonajesCapacidades> GetPersonajesCapacidades(int personajeId);
    }
}
