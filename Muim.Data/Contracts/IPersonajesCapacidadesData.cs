
using Muim.Domain.Models;

namespace Muim.Data.Contracts
{
    public interface IPersonajesCapacidadesData
    {
        bool AddPersonajesCapacidades(PersonajesCapacidades personajesCapacidades);
        bool DeletePersonajesCapacidades(PersonajesCapacidades personajesCapacidades);
    }
}
