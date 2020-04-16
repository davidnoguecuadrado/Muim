
using Muim.Domain.Models;

namespace Muim.Service.Contracts
{
    public interface IPersonajesCapacidadesService
    {
        public bool AddPersonajesCapacidades(PersonajesCapacidades personajesCapacidades);
        public bool DeletePersonajesCapacidades(PersonajesCapacidades personajesCapacidades);
    }
}
